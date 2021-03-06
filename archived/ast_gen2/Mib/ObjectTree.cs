// Portions copyright (c) 2008-2012, Lex Li
// Portions copyright (c) 2010, Wim Looman
// All rights reserved.
//   
// Redistribution and use in source and binary forms, with or without modification, are 
// permitted provided that the following conditions are met:
//   
// - Redistributions of source code must retain the above copyright notice, this list 
//   of conditions and the following disclaimer.
//   
// - Redistributions in binary form must reproduce the above copyright notice, this list
//   of conditions and the following disclaimer in the documentation and/or other materials 
//   provided with the distribution.
//   
// - Neither the name of the <ORGANIZATION> nor the names of its contributors may be used to 
//   endorse or promote products derived from this software without specific prior written 
//   permission.
//   
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS &AS IS& AND ANY EXPRESS 
// OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY 
// AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL 
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, 
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER 
// IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT 
// OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
#if !MA && !MT
using log4net;
#endif
namespace Lextm.SharpSnmpLib.Mib
{
    /// <summary>
    /// Object tree class.
    /// </summary>
    internal sealed class ObjectTree : IObjectTree
    {
        private readonly IDictionary<string, MibModule> _loaded = new Dictionary<string, MibModule>();
        private readonly IDictionary<string, MibModule> _pendings = new Dictionary<string, MibModule>();
        private readonly IDictionary<string, Definition> _nameTable;
        private readonly Definition _root;
#if !MA && !MT
        private static readonly ILog Logger = LogManager.GetLogger("Lextm.SharpSnmpLib.Mib");
#endif 
        /// <summary>
        /// Creates an <see cref="ObjectTree"/> instance.
        /// </summary>
        public ObjectTree()
        {
            _root = Definition.RootDefinition;
            var ccitt = new Definition(new ObjectIdentifierType("SNMPv2-SMI", "ccitt", null, 0), _root);
            var iso = new Definition(new ObjectIdentifierType("SNMPv2-SMI", "iso", null, 1), _root);
            var jointIsoCcitt = new Definition(new ObjectIdentifierType("SNMPv2-SMI", "joint-iso-ccitt", null, 2), _root);
            _nameTable = new Dictionary<string, Definition>
                             {
                                 { iso.TextualForm, iso },
                                 { ccitt.TextualForm, ccitt },
                                 { jointIsoCcitt.TextualForm, jointIsoCcitt }
                             };
        }
        
        public ObjectTree(ICollection<ModuleLoader> loaders) : this()
        {
            if (loaders == null)
            {
                throw new ArgumentNullException("loaders");
            }
#if !MA && !MT     
            Logger.InfoFormat(CultureInfo.InvariantCulture, "{0} module files found", loaders.Count);
#endif
            var defines = new List<Definition>();
            foreach (ModuleLoader loader in loaders)
            {
                Import(loader.Module);
                defines.AddRange(loader.Nodes);
            }
            
            AddNodes(defines);
            Refresh();
        }
        
        public ObjectTree(IEnumerable<string> files) : this(PrepareFiles(files))
        {
        }
        
        private static ICollection<ModuleLoader> PrepareFiles(IEnumerable<string> files)
        {
            if (files == null)
            {
                throw new ArgumentNullException("files");
            }

            IList<ModuleLoader> result = new List<ModuleLoader>();
            // TODO: disable loading cache right now. Need to change cache file format and then re-enable.
            foreach (string file in files)
            {
                if (!File.Exists(file))
                {
                    continue;
                }

                string moduleName = Path.GetFileNameWithoutExtension(file);
                using (var reader = new StreamReader(file))
                {
                    result.Add(new ModuleLoader(reader, moduleName));
                    reader.Close();
                }
            }

            return result;
        }
        
        /// <summary>
        /// Root definition.
        /// </summary>
        public IDefinition Root
        {
            get
            {
                return _root;
            }
        }

        public IDefinition Find(string moduleName, string name)
        {
            string full = moduleName + "::" + name;
            return _nameTable.ContainsKey(full) ? _nameTable[full] : null;
        }

        private Definition Find(string name)
        {
            return (from key in _nameTable.Keys
                    where string.CompareOrdinal(key.Split(new[] {"::"}, StringSplitOptions.None)[1], name) == 0
                    select _nameTable[key]).FirstOrDefault();
        }

        private Definition Find(IList<uint> numerical)
        {
            if (numerical == null)
            {
                throw new ArgumentNullException("numerical");
            }
            
            if (numerical.Count == 0)
            {
                throw new ArgumentException("numerical cannot be empty");
            }
            
            Definition result = _root;
// ReSharper disable LoopCanBePartlyConvertedToQuery
            foreach (uint digit in numerical)
// ReSharper restore LoopCanBePartlyConvertedToQuery
            {
                var temp = result.GetChildAt(digit) as Definition;
                if (temp == null)
                {
                    return null;
                }

                result = temp;
            }

            return result;
        }

        public SearchResult Search(uint[] id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            if (id.Length == 0)
            {
                throw new ArgumentException("numerical cannot be empty");
            }

            IDefinition result = _root;
            int end = id.Length;
            for (int i = 0; i < id.Length; i++)
            {
                IDefinition temp = result.GetChildAt(id[i]);
                if (temp == null)
                {
                    end = i;
                    break;
                }

                result = temp;
            }

            var remaining = new List<uint>();
            for (int j = end; j < id.Length; j++)
            {
                remaining.Add(id[j]);
            }

            return new SearchResult(result, remaining.ToArray());
        }

        private bool CanParse(MibModule module)
        {
            if (!module.Validate(_loaded))
            {
                return false;
            }
            
            bool exists = _loaded.ContainsKey(module.Name); // FIXME: don't parse the same module twice now.
            if (!exists)
            {
                _loaded.Add(module.Name, module);
            }

            return true;
        }

        private void Parse(MibModule module)
        {
            var watch = new Stopwatch();
            watch.Start();
            AddNodes(module);
#if !MA && !MT
            Logger.InfoFormat(CultureInfo.InvariantCulture, "{0}-ms used to assemble {1}", watch.ElapsedMilliseconds, module.Name);
#endif
            watch.Stop();
        }

        private Definition CreateSelf(IEntity node)
        {
            var o = node as ObjectTypeMacro;
            if (o != null)
            {
                var syn = o.Syntax;
            }
            /* algorithm 2: slower, dropped
            IDefinition parent = Find(node.Parent);
            if (parent == null)
            {
                return null;
            }

            return ((Definition)parent).Add(node);
            // */
            
            // * algorithm 1
            return _root.Add(node);
            
            // */
        }

        private void AddNodes(MibModule module)
        {
            var pendingNodes = new List<IEntity>();
            
            // parse all direct nodes.
            foreach (IEntity node in module.Entities)
            {
                if (node.Parent.Contains("."))
                {
                    pendingNodes.Add(node);
                    continue;
                }
                
                Definition result = CreateSelf(node);
                if (result == null)
                {
                    pendingNodes.Add(node);
                    continue;
                }

                AddToTable(result);
            }

            // parse indirect nodes.
            int current = pendingNodes.Count;
            while (current != 0)
            {
                var parsed = new List<IEntity>();
                int previous = current;
                foreach (IEntity node in pendingNodes)
                {
                    if (node.Parent.Contains("."))
                    {
                        if (!FirstNodeExists(node))
                        {
                            // wait till first node available.
                            continue;
                        }

                        // create all place holders.
                        IDefinition unknown = CreateExtraNodes(module, node.Parent);
                        if (unknown != null)
                        {
                            node.Parent = unknown.Name;
                            AddToTable(CreateSelf(node));
                        }
                    }
                    else
                    {
                        Definition result = CreateSelf(node);
                        if (result == null)
                        {
                            // wait for parent
                            continue;
                        }

                        AddToTable(result);
                    }
                    
                    parsed.Add(node);
                }
                
                foreach (IEntity en in parsed)
                {
                    pendingNodes.Remove(en);
                }

                current = pendingNodes.Count;
                if (previous == current)
                {
                    break;
                }
            }
        }

        private bool FirstNodeExists(IEntity node)
        {
            return Find(ExtractName(node.Parent.Split('.')[0])) != null;
        }

        private Definition CreateExtraNodes(MibModule module, string longParent)
        {
            string[] content = longParent.Split('.');
            Definition node = Find(ExtractName(content[0]));
            uint[] rootId = node.GetNumericalForm();
            var all = new uint[content.Length + rootId.Length - 1];
            for (int j = rootId.Length - 1; j >= 0; j--)
            {
                all[j] = rootId[j];
            }
            
            // change all to numerical
            for (int i = 1; i < content.Length; i++)
            {
                uint value;
                bool numberFound = uint.TryParse(content[i], out value);
                int currentCursor = rootId.Length + i - 1;
                if (numberFound)
                {
                    all[currentCursor] = value;
                    node = Find(ExtractParent(all, currentCursor + 1));
                    if (node != null)
                    {
                        continue;
                    }

                    IDefinition subroot = Find(ExtractParent(all, currentCursor));
                    
                    // if not, create Prefix node.
                    var prefix = new ObjectIdentifierType(module.Name, subroot.Name + "_" + value.ToString(CultureInfo.InvariantCulture), subroot.Name, value);
#if !MA && !MT
                    Logger.Info(module.ReportImplicitObjectIdentifier(prefix));
#endif
                    node = CreateSelf(prefix);
                    AddToTable(node);
                }
                else
                {
                    string self = content[i];
                    string parent = content[i - 1];
                    var extra = new ObjectIdentifierType(module.Name, ExtractName(self), ExtractName(parent), ExtractValue(self));
                    node = CreateSelf(extra);
                    if (node != null)
                    {
#if !MA && !MT
                        Logger.Info(module.ReportImplicitObjectIdentifier(extra));
#endif
                        AddToTable(node);
                        all[currentCursor] = node.Value;
                    }
                    else
                    {
#if !MA && !MT
                        Logger.Info(module.ReportIgnoredImplicitEntity(longParent));
#endif
                    }
                }
            }

            return node;
        }

        private static uint[] ExtractParent(IList<uint> input, int length)
        {
            var result = new uint[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = input[i];
            }
            
            return result;
        }
        
        private void AddToTable(Definition result)
        {
            if (result != null && !_nameTable.ContainsKey(result.TextualForm))
            {
                _nameTable.Add(result.TextualForm, result);
            }
        }

        public void Refresh()
        {
#if !MA && !MT
            Logger.Info("loading modules started");
#endif
            var watch = new Stopwatch();
            watch.Start();
            int current = _pendings.Count;
            while (current != 0)
            {
                int previous = current;
                IList<string> parsed = new List<string>();
                foreach (MibModule pending in
                    from pending in _pendings.Values
                    let succeeded = CanParse(pending)
                    where succeeded
                    select pending)
                {
                    Parse(pending);
                    parsed.Add(pending.Name);
                }

                foreach (string file in parsed)
                {
                    _pendings.Remove(file);
                }

                current = _pendings.Count;
#if !MA && !MT
                Logger.InfoFormat(CultureInfo.InvariantCulture, "{0} pending after {1}-ms", current,
                                  watch.ElapsedMilliseconds);
#endif
                if (current == previous)
                {
                    // cannot parse more
                    break;
                }
            }

            watch.Stop();
#if !MA && !MT
            foreach (string loaded in _loaded.Keys)
            {
                Logger.InfoFormat(CultureInfo.InvariantCulture, "{0} is parsed", loaded);
            }
            
            foreach (MibModule module in _pendings.Values)
            {
                Logger.Info(module.ReportMissingDependencies(LoadedModules));
            }

            Logger.Info("loading modules ended");
#endif
        }

        public void Import(IEnumerable<IModule> modules)
        {
            if (modules == null)
            {
                throw new ArgumentNullException("modules");
            }
            
            foreach (MibModule module in modules)
            {
                if (_loaded.ContainsKey(module.Name))
                {
#if !MA && !MT
                    Logger.Info(module.ReportDuplicate(_loaded[module.Name]));
#endif
                    continue;
                }

                if (_pendings.ContainsKey(module.Name))
                {
#if !MA && !MT
                    Logger.Info(module.ReportDuplicate(_pendings[module.Name]));
#endif
                    continue;
                }

                _pendings.Add(module.Name, module);
            }
        }

        private void Import(MibModule module)
        {
            if (module == null)
            {
                throw new ArgumentNullException("module");
            }

            if (_loaded.ContainsKey(module.Name))
            {
#if !MA && !MT
                Logger.Info(module.ReportDuplicate(_loaded[module.Name]));
#endif
            }
            else if (_pendings.ContainsKey(module.Name))
            {
#if !MA && !MT
                Logger.Info(module.ReportDuplicate(_pendings[module.Name]));
#endif
            }
            else
            {
                _pendings.Add(module.Name, module);
            }
        }

        /// <summary>
        /// Loaded MIB modules.
        /// </summary>
        public ICollection<IModule> LoadedModules
        {
            get { return _loaded.Values.Cast<IModule>().ToList(); }
        }
        
        /// <summary>
        /// Pending MIB modules.
        /// </summary>
        public ICollection<IModule> PendingModules
        {
            get { return _pendings.Values.Cast<IModule>().ToList(); }
        }

        private void AddNodes(IEnumerable<Definition> nodes)
        {
            var pendings = new List<Definition>(nodes);
            int current = pendings.Count;
            while (current != 0)
            {
                int previous = current;
                var parsed = new List<Definition>();
                foreach (Definition node in pendings)
                {
                    IDefinition parent = Find(Definition.GetParent(node));
                    if (parent == null)
                    {
                        continue;
                    }

                    node.DetermineType(parent);
                    node.ParentDefinition = parent;
                    AddToTable(node);
                    parsed.Add(node);
                }

                foreach (Definition d in parsed)
                {
                    pendings.Remove(d);
                }

                current = pendings.Count;
                if (current == previous)
                {
                    break;
                }
            }
        }
        
        #region IObjectTree Members

        public void Remove(string moduleName)
        {
            if (_loaded.ContainsKey(moduleName))
            {
                _loaded.Remove(moduleName);
            }

            if (_pendings.ContainsKey(moduleName))
            {
                _pendings.Remove(moduleName);
            }

            // TODO: remove all those nodes
        }

        #endregion

        /// <summary>
        /// Extracts the name.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        internal static string ExtractName(string input)
        {
            int left = input.IndexOf('(');
            return left == -1 ? input : input.Substring(0, left);
        }

        /// <summary>
        /// Extracts the value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        internal static uint ExtractValue(string input)
        {
            int left = input.IndexOf('(');
            int right = input.IndexOf(')');
            if (left >= right)
            {
                throw new FormatException("input does not contain a value");
            }

            uint temp;
            if (uint.TryParse(input.Substring(left + 1, right - left - 1), out temp))
            {
                return temp;
            }

            throw new FormatException("input does not contain a value");
        }

        /// <summary>
        /// Unloads the specified module.
        /// </summary>
        /// <param name="name">The name.</param>
        public void Unload(string name)
        {
            // IMPORTANT: not implemented in open source version.
        }
    }
}
