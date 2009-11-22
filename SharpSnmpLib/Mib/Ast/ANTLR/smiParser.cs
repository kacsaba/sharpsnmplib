// $ANTLR 3.1.2 Smi.g 2009-11-14 17:28:09

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


#pragma warning disable 3001, 3003, 3005, 3009, 1591 


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  Lextm.SharpSnmpLib.Mib.Ast.ANTLR 
{
public partial class SmiParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ABSENT_KW", 
		"ABSTRACT_SYNTAX_KW", 
		"ALL_KW", 
		"ANY_KW", 
		"APPLICATION_KW", 
		"ARGUMENT_KW", 
		"ASSIGN_OP", 
		"AUTOMATIC_KW", 
		"B_OR_H_STRING", 
		"B_STRING", 
		"BAR", 
		"BASED_NUM_KW", 
		"BDIG", 
		"BEGIN_KW", 
		"BIT_KW", 
		"BMP_STR_KW", 
		"BOOLEAN_KW", 
		"BY_KW", 
		"C_STRING", 
		"CHARACTER_KW", 
		"CHARB", 
		"CHARH", 
		"CHOICE_KW", 
		"CLASS_KW", 
		"COLON", 
		"COMMA", 
		"COMMENT", 
		"COMPONENT_KW", 
		"COMPONENTS_KW", 
		"CONSTRAINED_KW", 
		"DEFAULT_KW", 
		"DEFINED_KW", 
		"DEFINITIONS_KW", 
		"DOT", 
		"DOTDOT", 
		"DOTDOTDOT", 
		"EMBEDDED_KW", 
		"END_KW", 
		"ENUMERATED_KW", 
		"ERROR_KW", 
		"ERRORS_KW", 
		"EXCEPT_KW", 
		"EXCLAMATION", 
		"EXPLICIT_KW", 
		"EXPORTS_KW", 
		"EXTENSIBILITY_KW", 
		"EXTERNAL_KW", 
		"FALSE_KW", 
		"FROM_KW", 
		"GENERAL_STR_KW", 
		"GENERALIZED_TIME_KW", 
		"GRAPHIC_STR_KW", 
		"H_STRING", 
		"HDIG", 
		"IA5_STRING_KW", 
		"IDENTIFIER_KW", 
		"IMPLICIT_KW", 
		"IMPLIED_KW", 
		"IMPORTS_KW", 
		"INCLUDES_KW", 
		"INSTANCE_KW", 
		"INTEGER_KW", 
		"INTERSECTION", 
		"INTERSECTION_KW", 
		"ISO646_STR_KW", 
		"L_BRACE", 
		"L_BRACKET", 
		"L_PAREN", 
		"LESS", 
		"LINKED_KW", 
		"LOWER", 
		"MAX_KW", 
		"MIN_KW", 
		"MINUS", 
		"MINUS_INFINITY_KW", 
		"NULL_KW", 
		"NUMBER", 
		"NUMERIC_STR_KW", 
		"OBJECT_DESCRIPTOR_KW", 
		"OBJECT_KW", 
		"OCTET_KW", 
		"OF_KW", 
		"OID_KW", 
		"OPERATION_KW", 
		"OPTIONAL_KW", 
		"PARAMETER_KW", 
		"PATTERN_KW", 
		"PDV_KW", 
		"PLUS", 
		"PLUS_INFINITY_KW", 
		"PRESENT_KW", 
		"PRINTABLE_STR_KW", 
		"PRIVATE_KW", 
		"R_BRACE", 
		"R_BRACKET", 
		"R_PAREN", 
		"REAL_KW", 
		"RELATIVE_KW", 
		"RESULT_KW", 
		"SEMI", 
		"SEQUENCE_KW", 
		"SET_KW", 
		"SINGLE_QUOTE", 
		"SIZE_KW", 
		"SL_COMMENT", 
		"STRING_KW", 
		"T61_STR_KW", 
		"TAGS_KW", 
		"TELETEX_STR_KW", 
		"TRUE_KW", 
		"TYPE_IDENTIFIER_KW", 
		"UNION_KW", 
		"UNIQUE_KW", 
		"UNIVERSAL_KW", 
		"UNIVERSAL_STR_KW", 
		"UPPER", 
		"UTC_TIME_KW", 
		"UTF8_STR_KW", 
		"VIDEOTEX_STR_KW", 
		"VISIBLE_STR_KW", 
		"WITH_KW", 
		"WS", 
		"'ABSTRACT-BIND'", 
		"'ABSTRACT-ERROR'", 
		"'ABSTRACT-OPERATION'", 
		"'ABSTRACT-UNBIND'", 
		"'ACCESS'", 
		"'AGENT-CAPABILITIES'", 
		"'ALGORITHM'", 
		"'APPLICATION-CONTEXT'", 
		"'APPLICATION-SERVICE-ELEMENT'", 
		"'AUGMENTS'", 
		"'BIND'", 
		"'BITS'", 
		"'CONTACT-INFO'", 
		"'CREATION-REQUIRES'", 
		"'DEFVAL'", 
		"'DESCRIPTION'", 
		"'DISPLAY-HINT'", 
		"'ENCRYPTED'", 
		"'ENTERPRISE'", 
		"'EXTENDS'", 
		"'EXTENSION'", 
		"'EXTENSION-ATTRIBUTE'", 
		"'EXTENSIONS'", 
		"'GROUP'", 
		"'INDEX'", 
		"'INSTALL-ERRORS'", 
		"'LAST-UPDATED'", 
		"'MACRO'", 
		"'MANDATORY-GROUPS'", 
		"'MAX-ACCESS'", 
		"'MIN-ACCESS'", 
		"'MODULE'", 
		"'MODULE-COMPLIANCE'", 
		"'MODULE-IDENTITY'", 
		"'NOTIFICATION-GROUP'", 
		"'NOTIFICATIONS'", 
		"'NOTIFICATION-TYPE'", 
		"'OBJECT-GROUP'", 
		"'OBJECT-IDENTITY'", 
		"'OBJECTS'", 
		"'OBJECT-TYPE'", 
		"'ORGANIZATION'", 
		"'PIB-ACCESS'", 
		"'PIB-DEFINITIONS'", 
		"'PIB-INDEX'", 
		"'PIB-MIN-ACCESS'", 
		"'PIB-REFERENCES'", 
		"'PIB-TAG'", 
		"'PORT'", 
		"'PRODUCT-RELEASE'", 
		"'PROTECTED'", 
		"'REFERENCE'", 
		"'REFINE'", 
		"'RELATIVE-OID'", 
		"'REVISION'", 
		"'SECURITY-CATEGORY'", 
		"'SIGNATURE'", 
		"'SIGNED'", 
		"'STATUS'", 
		"'SUBJECT-CATEGORIES'", 
		"'SUPPORTS'", 
		"'SYNTAX'", 
		"'TEXTUAL-CONVENTION'", 
		"'TOKEN'", 
		"'TOKEN-DATA'", 
		"'TRAP-TYPE'", 
		"'UNBIND'", 
		"'UNIQUENESS'", 
		"'UNITS'", 
		"'VARIABLES'", 
		"'VARIATION'", 
		"'WRITE-SYNTAX'"
    };

    public const int EOF = -1;
    public const int T__126 = 126;
    public const int T__127 = 127;
    public const int T__128 = 128;
    public const int T__129 = 129;
    public const int T__130 = 130;
    public const int T__131 = 131;
    public const int T__132 = 132;
    public const int T__133 = 133;
    public const int T__134 = 134;
    public const int T__135 = 135;
    public const int T__136 = 136;
    public const int T__137 = 137;
    public const int T__138 = 138;
    public const int T__139 = 139;
    public const int T__140 = 140;
    public const int T__141 = 141;
    public const int T__142 = 142;
    public const int T__143 = 143;
    public const int T__144 = 144;
    public const int T__145 = 145;
    public const int T__146 = 146;
    public const int T__147 = 147;
    public const int T__148 = 148;
    public const int T__149 = 149;
    public const int T__150 = 150;
    public const int T__151 = 151;
    public const int T__152 = 152;
    public const int T__153 = 153;
    public const int T__154 = 154;
    public const int T__155 = 155;
    public const int T__156 = 156;
    public const int T__157 = 157;
    public const int T__158 = 158;
    public const int T__159 = 159;
    public const int T__160 = 160;
    public const int T__161 = 161;
    public const int T__162 = 162;
    public const int T__163 = 163;
    public const int T__164 = 164;
    public const int T__165 = 165;
    public const int T__166 = 166;
    public const int T__167 = 167;
    public const int T__168 = 168;
    public const int T__169 = 169;
    public const int T__170 = 170;
    public const int T__171 = 171;
    public const int T__172 = 172;
    public const int T__173 = 173;
    public const int T__174 = 174;
    public const int T__175 = 175;
    public const int T__176 = 176;
    public const int T__177 = 177;
    public const int T__178 = 178;
    public const int T__179 = 179;
    public const int T__180 = 180;
    public const int T__181 = 181;
    public const int T__182 = 182;
    public const int T__183 = 183;
    public const int T__184 = 184;
    public const int T__185 = 185;
    public const int T__186 = 186;
    public const int T__187 = 187;
    public const int T__188 = 188;
    public const int T__189 = 189;
    public const int T__190 = 190;
    public const int T__191 = 191;
    public const int T__192 = 192;
    public const int T__193 = 193;
    public const int T__194 = 194;
    public const int T__195 = 195;
    public const int T__196 = 196;
    public const int T__197 = 197;
    public const int ABSENT_KW = 4;
    public const int ABSTRACT_SYNTAX_KW = 5;
    public const int ALL_KW = 6;
    public const int ANY_KW = 7;
    public const int APPLICATION_KW = 8;
    public const int ARGUMENT_KW = 9;
    public const int ASSIGN_OP = 10;
    public const int AUTOMATIC_KW = 11;
    public const int B_OR_H_STRING = 12;
    public const int B_STRING = 13;
    public const int BAR = 14;
    public const int BASED_NUM_KW = 15;
    public const int BDIG = 16;
    public const int BEGIN_KW = 17;
    public const int BIT_KW = 18;
    public const int BMP_STR_KW = 19;
    public const int BOOLEAN_KW = 20;
    public const int BY_KW = 21;
    public const int C_STRING = 22;
    public const int CHARACTER_KW = 23;
    public const int CHARB = 24;
    public const int CHARH = 25;
    public const int CHOICE_KW = 26;
    public const int CLASS_KW = 27;
    public const int COLON = 28;
    public const int COMMA = 29;
    public const int COMMENT = 30;
    public const int COMPONENT_KW = 31;
    public const int COMPONENTS_KW = 32;
    public const int CONSTRAINED_KW = 33;
    public const int DEFAULT_KW = 34;
    public const int DEFINED_KW = 35;
    public const int DEFINITIONS_KW = 36;
    public const int DOT = 37;
    public const int DOTDOT = 38;
    public const int DOTDOTDOT = 39;
    public const int EMBEDDED_KW = 40;
    public const int END_KW = 41;
    public const int ENUMERATED_KW = 42;
    public const int ERROR_KW = 43;
    public const int ERRORS_KW = 44;
    public const int EXCEPT_KW = 45;
    public const int EXCLAMATION = 46;
    public const int EXPLICIT_KW = 47;
    public const int EXPORTS_KW = 48;
    public const int EXTENSIBILITY_KW = 49;
    public const int EXTERNAL_KW = 50;
    public const int FALSE_KW = 51;
    public const int FROM_KW = 52;
    public const int GENERAL_STR_KW = 53;
    public const int GENERALIZED_TIME_KW = 54;
    public const int GRAPHIC_STR_KW = 55;
    public const int H_STRING = 56;
    public const int HDIG = 57;
    public const int IA5_STRING_KW = 58;
    public const int IDENTIFIER_KW = 59;
    public const int IMPLICIT_KW = 60;
    public const int IMPLIED_KW = 61;
    public const int IMPORTS_KW = 62;
    public const int INCLUDES_KW = 63;
    public const int INSTANCE_KW = 64;
    public const int INTEGER_KW = 65;
    public const int INTERSECTION = 66;
    public const int INTERSECTION_KW = 67;
    public const int ISO646_STR_KW = 68;
    public const int L_BRACE = 69;
    public const int L_BRACKET = 70;
    public const int L_PAREN = 71;
    public const int LESS = 72;
    public const int LINKED_KW = 73;
    public const int LOWER = 74;
    public const int MAX_KW = 75;
    public const int MIN_KW = 76;
    public const int MINUS = 77;
    public const int MINUS_INFINITY_KW = 78;
    public const int NULL_KW = 79;
    public const int NUMBER = 80;
    public const int NUMERIC_STR_KW = 81;
    public const int OBJECT_DESCRIPTOR_KW = 82;
    public const int OBJECT_KW = 83;
    public const int OCTET_KW = 84;
    public const int OF_KW = 85;
    public const int OID_KW = 86;
    public const int OPERATION_KW = 87;
    public const int OPTIONAL_KW = 88;
    public const int PARAMETER_KW = 89;
    public const int PATTERN_KW = 90;
    public const int PDV_KW = 91;
    public const int PLUS = 92;
    public const int PLUS_INFINITY_KW = 93;
    public const int PRESENT_KW = 94;
    public const int PRINTABLE_STR_KW = 95;
    public const int PRIVATE_KW = 96;
    public const int R_BRACE = 97;
    public const int R_BRACKET = 98;
    public const int R_PAREN = 99;
    public const int REAL_KW = 100;
    public const int RELATIVE_KW = 101;
    public const int RESULT_KW = 102;
    public const int SEMI = 103;
    public const int SEQUENCE_KW = 104;
    public const int SET_KW = 105;
    public const int SINGLE_QUOTE = 106;
    public const int SIZE_KW = 107;
    public const int SL_COMMENT = 108;
    public const int STRING_KW = 109;
    public const int T61_STR_KW = 110;
    public const int TAGS_KW = 111;
    public const int TELETEX_STR_KW = 112;
    public const int TRUE_KW = 113;
    public const int TYPE_IDENTIFIER_KW = 114;
    public const int UNION_KW = 115;
    public const int UNIQUE_KW = 116;
    public const int UNIVERSAL_KW = 117;
    public const int UNIVERSAL_STR_KW = 118;
    public const int UPPER = 119;
    public const int UTC_TIME_KW = 120;
    public const int UTF8_STR_KW = 121;
    public const int VIDEOTEX_STR_KW = 122;
    public const int VISIBLE_STR_KW = 123;
    public const int WITH_KW = 124;
    public const int WS = 125;

    // delegates
    // delegators



        public SmiParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SmiParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return SmiParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Smi.g"; }
    }


    public class statement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statement"
    // Smi.g:593:0: statement : ( module_definition )* ;
    public SmiParser.statement_return statement() // throws RecognitionException [1]
    {   
        SmiParser.statement_return retval = new SmiParser.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.module_definition_return module_definition1 = default(SmiParser.module_definition_return);



        try 
    	{
            // Smi.g:594:7: ( ( module_definition )* )
            // Smi.g:594:7: ( module_definition )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:594:7: ( module_definition )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == UPPER) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Smi.g:594:8: module_definition
            			    {
            			    	PushFollow(FOLLOW_module_definition_in_statement1862);
            			    	module_definition1 = module_definition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, module_definition1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class module_definition_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "module_definition"
    // Smi.g:600:0: module_definition : module_identifier ( 'PIB-DEFINITIONS' | DEFINITIONS_KW ) ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )? ( EXTENSIBILITY_KW IMPLIED_KW )? ASSIGN_OP BEGIN_KW module_body END_KW ;
    public SmiParser.module_definition_return module_definition() // throws RecognitionException [1]
    {   
        SmiParser.module_definition_return retval = new SmiParser.module_definition_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set3 = null;
        IToken set4 = null;
        IToken TAGS_KW5 = null;
        IToken EXTENSIBILITY_KW6 = null;
        IToken IMPLIED_KW7 = null;
        IToken ASSIGN_OP8 = null;
        IToken BEGIN_KW9 = null;
        IToken END_KW11 = null;
        SmiParser.module_identifier_return module_identifier2 = default(SmiParser.module_identifier_return);

        SmiParser.module_body_return module_body10 = default(SmiParser.module_body_return);


        CommonTree set3_tree=null;
        CommonTree set4_tree=null;
        CommonTree TAGS_KW5_tree=null;
        CommonTree EXTENSIBILITY_KW6_tree=null;
        CommonTree IMPLIED_KW7_tree=null;
        CommonTree ASSIGN_OP8_tree=null;
        CommonTree BEGIN_KW9_tree=null;
        CommonTree END_KW11_tree=null;

        try 
    	{
            // Smi.g:600:20: ( module_identifier ( 'PIB-DEFINITIONS' | DEFINITIONS_KW ) ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )? ( EXTENSIBILITY_KW IMPLIED_KW )? ASSIGN_OP BEGIN_KW module_body END_KW )
            // Smi.g:600:20: module_identifier ( 'PIB-DEFINITIONS' | DEFINITIONS_KW ) ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )? ( EXTENSIBILITY_KW IMPLIED_KW )? ASSIGN_OP BEGIN_KW module_body END_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_module_identifier_in_module_definition1879);
            	module_identifier2 = module_identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, module_identifier2.Tree);
            	set3 = (IToken)input.LT(1);
            	if ( input.LA(1) == DEFINITIONS_KW || input.LA(1) == 169 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set3));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	// Smi.g:601:3: ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == AUTOMATIC_KW || LA2_0 == EXPLICIT_KW || LA2_0 == IMPLICIT_KW) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // Smi.g:601:5: ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW
            	        {
            	        	set4 = (IToken)input.LT(1);
            	        	if ( input.LA(1) == AUTOMATIC_KW || input.LA(1) == EXPLICIT_KW || input.LA(1) == IMPLICIT_KW ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set4));
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	TAGS_KW5=(IToken)Match(input,TAGS_KW,FOLLOW_TAGS_KW_in_module_definition1906); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{TAGS_KW5_tree = (CommonTree)adaptor.Create(TAGS_KW5);
            	        		adaptor.AddChild(root_0, TAGS_KW5_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:602:3: ( EXTENSIBILITY_KW IMPLIED_KW )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == EXTENSIBILITY_KW) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // Smi.g:602:4: EXTENSIBILITY_KW IMPLIED_KW
            	        {
            	        	EXTENSIBILITY_KW6=(IToken)Match(input,EXTENSIBILITY_KW,FOLLOW_EXTENSIBILITY_KW_in_module_definition1915); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{EXTENSIBILITY_KW6_tree = (CommonTree)adaptor.Create(EXTENSIBILITY_KW6);
            	        		adaptor.AddChild(root_0, EXTENSIBILITY_KW6_tree);
            	        	}
            	        	IMPLIED_KW7=(IToken)Match(input,IMPLIED_KW,FOLLOW_IMPLIED_KW_in_module_definition1917); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{IMPLIED_KW7_tree = (CommonTree)adaptor.Create(IMPLIED_KW7);
            	        		adaptor.AddChild(root_0, IMPLIED_KW7_tree);
            	        	}

            	        }
            	        break;

            	}

            	ASSIGN_OP8=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_module_definition1923); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ASSIGN_OP8_tree = (CommonTree)adaptor.Create(ASSIGN_OP8);
            		adaptor.AddChild(root_0, ASSIGN_OP8_tree);
            	}
            	BEGIN_KW9=(IToken)Match(input,BEGIN_KW,FOLLOW_BEGIN_KW_in_module_definition1925); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BEGIN_KW9_tree = (CommonTree)adaptor.Create(BEGIN_KW9);
            		adaptor.AddChild(root_0, BEGIN_KW9_tree);
            	}
            	PushFollow(FOLLOW_module_body_in_module_definition1927);
            	module_body10 = module_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, module_body10.Tree);
            	END_KW11=(IToken)Match(input,END_KW,FOLLOW_END_KW_in_module_definition1929); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{END_KW11_tree = (CommonTree)adaptor.Create(END_KW11);
            		adaptor.AddChild(root_0, END_KW11_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module_definition"

    public class module_identifier_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "module_identifier"
    // Smi.g:605:0: module_identifier : UPPER ( obj_id_comp_lst )? ;
    public SmiParser.module_identifier_return module_identifier() // throws RecognitionException [1]
    {   
        SmiParser.module_identifier_return retval = new SmiParser.module_identifier_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER12 = null;
        SmiParser.obj_id_comp_lst_return obj_id_comp_lst13 = default(SmiParser.obj_id_comp_lst_return);


        CommonTree UPPER12_tree=null;

        try 
    	{
            // Smi.g:605:20: ( UPPER ( obj_id_comp_lst )? )
            // Smi.g:605:20: UPPER ( obj_id_comp_lst )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	UPPER12=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_module_identifier1936); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPPER12_tree = (CommonTree)adaptor.Create(UPPER12);
            		adaptor.AddChild(root_0, UPPER12_tree);
            	}
            	// Smi.g:605:26: ( obj_id_comp_lst )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == L_BRACE) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Smi.g:605:27: obj_id_comp_lst
            	        {
            	        	PushFollow(FOLLOW_obj_id_comp_lst_in_module_identifier1939);
            	        	obj_id_comp_lst13 = obj_id_comp_lst();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_comp_lst13.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module_identifier"

    public class module_body_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "module_body"
    // Smi.g:607:0: module_body : ( exports )? ( imports )? ( assignment )* ;
    public SmiParser.module_body_return module_body() // throws RecognitionException [1]
    {   
        SmiParser.module_body_return retval = new SmiParser.module_body_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.exports_return exports14 = default(SmiParser.exports_return);

        SmiParser.imports_return imports15 = default(SmiParser.imports_return);

        SmiParser.assignment_return assignment16 = default(SmiParser.assignment_return);



        try 
    	{
            // Smi.g:607:14: ( ( exports )? ( imports )? ( assignment )* )
            // Smi.g:607:14: ( exports )? ( imports )? ( assignment )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:607:14: ( exports )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == EXPORTS_KW) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // Smi.g:607:15: exports
            	        {
            	        	PushFollow(FOLLOW_exports_in_module_body1950);
            	        	exports14 = exports();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exports14.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:607:25: ( imports )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == IMPORTS_KW) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // Smi.g:607:26: imports
            	        {
            	        	PushFollow(FOLLOW_imports_in_module_body1955);
            	        	imports15 = imports();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, imports15.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:607:36: ( assignment )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == ERROR_KW || LA7_0 == LOWER || LA7_0 == OBJECT_KW || LA7_0 == OPERATION_KW || LA7_0 == UPPER || (LA7_0 >= 126 && LA7_0 <= 129) || (LA7_0 >= 131 && LA7_0 <= 134) || LA7_0 == 136 || LA7_0 == 143 || (LA7_0 >= 146 && LA7_0 <= 148) || (LA7_0 >= 158 && LA7_0 <= 160) || (LA7_0 >= 162 && LA7_0 <= 164) || LA7_0 == 166 || LA7_0 == 174 || LA7_0 == 176 || LA7_0 == 178 || (LA7_0 >= 181 && LA7_0 <= 183) || (LA7_0 >= 188 && LA7_0 <= 192)) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // Smi.g:607:37: assignment
            			    {
            			    	PushFollow(FOLLOW_assignment_in_module_body1960);
            			    	assignment16 = assignment();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment16.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module_body"

    public class obj_id_comp_lst_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "obj_id_comp_lst"
    // Smi.g:610:0: obj_id_comp_lst : L_BRACE (=> defined_value )? ( obj_id_component )+ R_BRACE ;
    public SmiParser.obj_id_comp_lst_return obj_id_comp_lst() // throws RecognitionException [1]
    {   
        SmiParser.obj_id_comp_lst_return retval = new SmiParser.obj_id_comp_lst_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE17 = null;
        IToken R_BRACE20 = null;
        SmiParser.defined_value_return defined_value18 = default(SmiParser.defined_value_return);

        SmiParser.obj_id_component_return obj_id_component19 = default(SmiParser.obj_id_component_return);


        CommonTree L_BRACE17_tree=null;
        CommonTree R_BRACE20_tree=null;

        try 
    	{
            // Smi.g:610:18: ( L_BRACE (=> defined_value )? ( obj_id_component )+ R_BRACE )
            // Smi.g:610:18: L_BRACE (=> defined_value )? ( obj_id_component )+ R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE17=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_obj_id_comp_lst1972); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE17_tree = (CommonTree)adaptor.Create(L_BRACE17);
            		adaptor.AddChild(root_0, L_BRACE17_tree);
            	}
            	// Smi.g:610:26: (=> defined_value )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == UPPER) && (synpred1_Smi()) )
            	{
            	    alt8 = 1;
            	}
            	else if ( (LA8_0 == LOWER) )
            	{
            	    int LA8_2 = input.LA(2);

            	    if ( (synpred1_Smi()) )
            	    {
            	        alt8 = 1;
            	    }
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // Smi.g:610:27: => defined_value
            	        {

            	        	PushFollow(FOLLOW_defined_value_in_obj_id_comp_lst1987);
            	        	defined_value18 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value18.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:610:69: ( obj_id_component )+
            	int cnt9 = 0;
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == LOWER || LA9_0 == NUMBER) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // Smi.g:610:70: obj_id_component
            			    {
            			    	PushFollow(FOLLOW_obj_id_component_in_obj_id_comp_lst1992);
            			    	obj_id_component19 = obj_id_component();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_component19.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt9 >= 1 ) goto loop9;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee9 =
            		                new EarlyExitException(9, input);
            		            throw eee9;
            	    }
            	    cnt9++;
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	R_BRACE20=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_obj_id_comp_lst1996); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE20_tree = (CommonTree)adaptor.Create(R_BRACE20);
            		adaptor.AddChild(root_0, R_BRACE20_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "obj_id_comp_lst"

    public class defined_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "defined_value"
    // Smi.g:613:0: protected defined_value : ( UPPER DOT )? LOWER ;
    public SmiParser.defined_value_return defined_value() // throws RecognitionException [1]
    {   
        SmiParser.defined_value_return retval = new SmiParser.defined_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER21 = null;
        IToken DOT22 = null;
        IToken LOWER23 = null;

        CommonTree UPPER21_tree=null;
        CommonTree DOT22_tree=null;
        CommonTree LOWER23_tree=null;

        try 
    	{
            // Smi.g:613:26: ( ( UPPER DOT )? LOWER )
            // Smi.g:613:26: ( UPPER DOT )? LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:613:26: ( UPPER DOT )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == UPPER) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // Smi.g:613:27: UPPER DOT
            	        {
            	        	UPPER21=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_defined_value2007); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UPPER21_tree = (CommonTree)adaptor.Create(UPPER21);
            	        		adaptor.AddChild(root_0, UPPER21_tree);
            	        	}
            	        	DOT22=(IToken)Match(input,DOT,FOLLOW_DOT_in_defined_value2009); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOT22_tree = (CommonTree)adaptor.Create(DOT22);
            	        		adaptor.AddChild(root_0, DOT22_tree);
            	        	}

            	        }
            	        break;

            	}

            	LOWER23=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_defined_value2013); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER23_tree = (CommonTree)adaptor.Create(LOWER23);
            		adaptor.AddChild(root_0, LOWER23_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defined_value"

    public class obj_id_component_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "obj_id_component"
    // Smi.g:616:0: obj_id_component : ( NUMBER | LOWER ( L_PAREN NUMBER R_PAREN )? );
    public SmiParser.obj_id_component_return obj_id_component() // throws RecognitionException [1]
    {   
        SmiParser.obj_id_component_return retval = new SmiParser.obj_id_component_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NUMBER24 = null;
        IToken LOWER25 = null;
        IToken L_PAREN26 = null;
        IToken NUMBER27 = null;
        IToken R_PAREN28 = null;

        CommonTree NUMBER24_tree=null;
        CommonTree LOWER25_tree=null;
        CommonTree L_PAREN26_tree=null;
        CommonTree NUMBER27_tree=null;
        CommonTree R_PAREN28_tree=null;

        try 
    	{
            // Smi.g:616:19: ( NUMBER | LOWER ( L_PAREN NUMBER R_PAREN )? )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == NUMBER) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == LOWER) )
            {
                alt12 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // Smi.g:616:19: NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	NUMBER24=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_obj_id_component2023); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER24_tree = (CommonTree)adaptor.Create(NUMBER24);
                    		adaptor.AddChild(root_0, NUMBER24_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:617:19: LOWER ( L_PAREN NUMBER R_PAREN )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LOWER25=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_obj_id_component2044); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER25_tree = (CommonTree)adaptor.Create(LOWER25);
                    		adaptor.AddChild(root_0, LOWER25_tree);
                    	}
                    	// Smi.g:617:25: ( L_PAREN NUMBER R_PAREN )?
                    	int alt11 = 2;
                    	int LA11_0 = input.LA(1);

                    	if ( (LA11_0 == L_PAREN) )
                    	{
                    	    alt11 = 1;
                    	}
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // Smi.g:617:26: L_PAREN NUMBER R_PAREN
                    	        {
                    	        	L_PAREN26=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_obj_id_component2047); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{L_PAREN26_tree = (CommonTree)adaptor.Create(L_PAREN26);
                    	        		adaptor.AddChild(root_0, L_PAREN26_tree);
                    	        	}
                    	        	NUMBER27=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_obj_id_component2049); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{NUMBER27_tree = (CommonTree)adaptor.Create(NUMBER27);
                    	        		adaptor.AddChild(root_0, NUMBER27_tree);
                    	        	}
                    	        	R_PAREN28=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_obj_id_component2051); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{R_PAREN28_tree = (CommonTree)adaptor.Create(R_PAREN28);
                    	        		adaptor.AddChild(root_0, R_PAREN28_tree);
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "obj_id_component"

    public class tag_default_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tag_default"
    // Smi.g:623:0: tag_default : ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW );
    public SmiParser.tag_default_return tag_default() // throws RecognitionException [1]
    {   
        SmiParser.tag_default_return retval = new SmiParser.tag_default_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set29 = null;

        CommonTree set29_tree=null;

        try 
    	{
            // Smi.g:623:14: ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW )
            // Smi.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set29 = (IToken)input.LT(1);
            	if ( input.LA(1) == AUTOMATIC_KW || input.LA(1) == EXPLICIT_KW || input.LA(1) == IMPLICIT_KW ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set29));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tag_default"

    public class exports_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "exports"
    // Smi.g:625:0: exports : EXPORTS_KW ( ( symbol_list )? | ALL_KW ) SEMI ;
    public SmiParser.exports_return exports() // throws RecognitionException [1]
    {   
        SmiParser.exports_return retval = new SmiParser.exports_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EXPORTS_KW30 = null;
        IToken ALL_KW32 = null;
        IToken SEMI33 = null;
        SmiParser.symbol_list_return symbol_list31 = default(SmiParser.symbol_list_return);


        CommonTree EXPORTS_KW30_tree=null;
        CommonTree ALL_KW32_tree=null;
        CommonTree SEMI33_tree=null;

        try 
    	{
            // Smi.g:625:10: ( EXPORTS_KW ( ( symbol_list )? | ALL_KW ) SEMI )
            // Smi.g:625:10: EXPORTS_KW ( ( symbol_list )? | ALL_KW ) SEMI
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	EXPORTS_KW30=(IToken)Match(input,EXPORTS_KW,FOLLOW_EXPORTS_KW_in_exports2079); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXPORTS_KW30_tree = (CommonTree)adaptor.Create(EXPORTS_KW30);
            		adaptor.AddChild(root_0, EXPORTS_KW30_tree);
            	}
            	// Smi.g:625:21: ( ( symbol_list )? | ALL_KW )
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == ERROR_KW || LA14_0 == LOWER || LA14_0 == OBJECT_KW || LA14_0 == OPERATION_KW || LA14_0 == SEMI || LA14_0 == UPPER || (LA14_0 >= 126 && LA14_0 <= 129) || (LA14_0 >= 131 && LA14_0 <= 134) || LA14_0 == 136 || LA14_0 == 143 || (LA14_0 >= 146 && LA14_0 <= 148) || (LA14_0 >= 158 && LA14_0 <= 160) || (LA14_0 >= 162 && LA14_0 <= 164) || LA14_0 == 166 || LA14_0 == 174 || LA14_0 == 176 || LA14_0 == 178 || (LA14_0 >= 181 && LA14_0 <= 183) || (LA14_0 >= 188 && LA14_0 <= 192)) )
            	{
            	    alt14 = 1;
            	}
            	else if ( (LA14_0 == ALL_KW) )
            	{
            	    alt14 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // Smi.g:625:23: ( symbol_list )?
            	        {
            	        	// Smi.g:625:23: ( symbol_list )?
            	        	int alt13 = 2;
            	        	int LA13_0 = input.LA(1);

            	        	if ( (LA13_0 == ERROR_KW || LA13_0 == LOWER || LA13_0 == OBJECT_KW || LA13_0 == OPERATION_KW || LA13_0 == UPPER || (LA13_0 >= 126 && LA13_0 <= 129) || (LA13_0 >= 131 && LA13_0 <= 134) || LA13_0 == 136 || LA13_0 == 143 || (LA13_0 >= 146 && LA13_0 <= 148) || (LA13_0 >= 158 && LA13_0 <= 160) || (LA13_0 >= 162 && LA13_0 <= 164) || LA13_0 == 166 || LA13_0 == 174 || LA13_0 == 176 || LA13_0 == 178 || (LA13_0 >= 181 && LA13_0 <= 183) || (LA13_0 >= 188 && LA13_0 <= 192)) )
            	        	{
            	        	    alt13 = 1;
            	        	}
            	        	switch (alt13) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:625:24: symbol_list
            	        	        {
            	        	        	PushFollow(FOLLOW_symbol_list_in_exports2084);
            	        	        	symbol_list31 = symbol_list();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol_list31.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:625:40: ALL_KW
            	        {
            	        	ALL_KW32=(IToken)Match(input,ALL_KW,FOLLOW_ALL_KW_in_exports2090); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ALL_KW32_tree = (CommonTree)adaptor.Create(ALL_KW32);
            	        		adaptor.AddChild(root_0, ALL_KW32_tree);
            	        	}

            	        }
            	        break;

            	}

            	SEMI33=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_exports2094); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEMI33_tree = (CommonTree)adaptor.Create(SEMI33);
            		adaptor.AddChild(root_0, SEMI33_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exports"

    public class imports_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "imports"
    // Smi.g:627:0: imports : IMPORTS_KW ( symbols_from_module )* SEMI ;
    public SmiParser.imports_return imports() // throws RecognitionException [1]
    {   
        SmiParser.imports_return retval = new SmiParser.imports_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IMPORTS_KW34 = null;
        IToken SEMI36 = null;
        SmiParser.symbols_from_module_return symbols_from_module35 = default(SmiParser.symbols_from_module_return);


        CommonTree IMPORTS_KW34_tree=null;
        CommonTree SEMI36_tree=null;

        try 
    	{
            // Smi.g:627:10: ( IMPORTS_KW ( symbols_from_module )* SEMI )
            // Smi.g:627:10: IMPORTS_KW ( symbols_from_module )* SEMI
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	IMPORTS_KW34=(IToken)Match(input,IMPORTS_KW,FOLLOW_IMPORTS_KW_in_imports2101); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IMPORTS_KW34_tree = (CommonTree)adaptor.Create(IMPORTS_KW34);
            		adaptor.AddChild(root_0, IMPORTS_KW34_tree);
            	}
            	// Smi.g:627:21: ( symbols_from_module )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == ERROR_KW || LA15_0 == LOWER || LA15_0 == OBJECT_KW || LA15_0 == OPERATION_KW || LA15_0 == UPPER || (LA15_0 >= 126 && LA15_0 <= 129) || (LA15_0 >= 131 && LA15_0 <= 134) || LA15_0 == 136 || LA15_0 == 143 || (LA15_0 >= 146 && LA15_0 <= 148) || (LA15_0 >= 158 && LA15_0 <= 160) || (LA15_0 >= 162 && LA15_0 <= 164) || LA15_0 == 166 || LA15_0 == 174 || LA15_0 == 176 || LA15_0 == 178 || (LA15_0 >= 181 && LA15_0 <= 183) || (LA15_0 >= 188 && LA15_0 <= 192)) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // Smi.g:627:22: symbols_from_module
            			    {
            			    	PushFollow(FOLLOW_symbols_from_module_in_imports2104);
            			    	symbols_from_module35 = symbols_from_module();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbols_from_module35.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	SEMI36=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_imports2108); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEMI36_tree = (CommonTree)adaptor.Create(SEMI36);
            		adaptor.AddChild(root_0, SEMI36_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "imports"

    public class assignment_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignment"
    // Smi.g:630:0: assignment : ( UPPER ASSIGN_OP type | LOWER type ASSIGN_OP value | ( UPPER | macroName ) 'MACRO' ASSIGN_OP BEGIN_KW (~ ( END_KW ) )* END_KW );
    public SmiParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SmiParser.assignment_return retval = new SmiParser.assignment_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER37 = null;
        IToken ASSIGN_OP38 = null;
        IToken LOWER40 = null;
        IToken ASSIGN_OP42 = null;
        IToken UPPER44 = null;
        IToken string_literal46 = null;
        IToken ASSIGN_OP47 = null;
        IToken BEGIN_KW48 = null;
        IToken set49 = null;
        IToken END_KW50 = null;
        SmiParser.type_return type39 = default(SmiParser.type_return);

        SmiParser.type_return type41 = default(SmiParser.type_return);

        SmiParser.value_return value43 = default(SmiParser.value_return);

        SmiParser.macroName_return macroName45 = default(SmiParser.macroName_return);


        CommonTree UPPER37_tree=null;
        CommonTree ASSIGN_OP38_tree=null;
        CommonTree LOWER40_tree=null;
        CommonTree ASSIGN_OP42_tree=null;
        CommonTree UPPER44_tree=null;
        CommonTree string_literal46_tree=null;
        CommonTree ASSIGN_OP47_tree=null;
        CommonTree BEGIN_KW48_tree=null;
        CommonTree set49_tree=null;
        CommonTree END_KW50_tree=null;

        try 
    	{
            // Smi.g:630:13: ( UPPER ASSIGN_OP type | LOWER type ASSIGN_OP value | ( UPPER | macroName ) 'MACRO' ASSIGN_OP BEGIN_KW (~ ( END_KW ) )* END_KW )
            int alt18 = 3;
            switch ( input.LA(1) ) 
            {
            case UPPER:
            	{
                int LA18_1 = input.LA(2);

                if ( (LA18_1 == ASSIGN_OP) )
                {
                    alt18 = 1;
                }
                else if ( (LA18_1 == 153) )
                {
                    alt18 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d18s1 =
                        new NoViableAltException("", 18, 1, input);

                    throw nvae_d18s1;
                }
                }
                break;
            case LOWER:
            	{
                alt18 = 2;
                }
                break;
            case ERROR_KW:
            case OBJECT_KW:
            case OPERATION_KW:
            case 126:
            case 127:
            case 128:
            case 129:
            case 131:
            case 132:
            case 133:
            case 134:
            case 136:
            case 143:
            case 146:
            case 147:
            case 148:
            case 158:
            case 159:
            case 160:
            case 162:
            case 163:
            case 164:
            case 166:
            case 174:
            case 176:
            case 178:
            case 181:
            case 182:
            case 183:
            case 188:
            case 189:
            case 190:
            case 191:
            case 192:
            	{
                alt18 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d18s0 =
            	        new NoViableAltException("", 18, 0, input);

            	    throw nvae_d18s0;
            }

            switch (alt18) 
            {
                case 1 :
                    // Smi.g:630:13: UPPER ASSIGN_OP type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	UPPER37=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_assignment2118); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UPPER37_tree = (CommonTree)adaptor.Create(UPPER37);
                    		adaptor.AddChild(root_0, UPPER37_tree);
                    	}
                    	ASSIGN_OP38=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_assignment2120); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN_OP38_tree = (CommonTree)adaptor.Create(ASSIGN_OP38);
                    		adaptor.AddChild(root_0, ASSIGN_OP38_tree);
                    	}
                    	PushFollow(FOLLOW_type_in_assignment2122);
                    	type39 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type39.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:631:13: LOWER type ASSIGN_OP value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LOWER40=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_assignment2137); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER40_tree = (CommonTree)adaptor.Create(LOWER40);
                    		adaptor.AddChild(root_0, LOWER40_tree);
                    	}
                    	PushFollow(FOLLOW_type_in_assignment2139);
                    	type41 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type41.Tree);
                    	ASSIGN_OP42=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_assignment2141); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN_OP42_tree = (CommonTree)adaptor.Create(ASSIGN_OP42);
                    		adaptor.AddChild(root_0, ASSIGN_OP42_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_assignment2143);
                    	value43 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value43.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:632:13: ( UPPER | macroName ) 'MACRO' ASSIGN_OP BEGIN_KW (~ ( END_KW ) )* END_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// Smi.g:632:13: ( UPPER | macroName )
                    	int alt16 = 2;
                    	int LA16_0 = input.LA(1);

                    	if ( (LA16_0 == UPPER) )
                    	{
                    	    alt16 = 1;
                    	}
                    	else if ( (LA16_0 == ERROR_KW || LA16_0 == OBJECT_KW || LA16_0 == OPERATION_KW || (LA16_0 >= 126 && LA16_0 <= 129) || (LA16_0 >= 131 && LA16_0 <= 134) || LA16_0 == 136 || LA16_0 == 143 || (LA16_0 >= 146 && LA16_0 <= 148) || (LA16_0 >= 158 && LA16_0 <= 160) || (LA16_0 >= 162 && LA16_0 <= 164) || LA16_0 == 166 || LA16_0 == 174 || LA16_0 == 176 || LA16_0 == 178 || (LA16_0 >= 181 && LA16_0 <= 183) || (LA16_0 >= 188 && LA16_0 <= 192)) )
                    	{
                    	    alt16 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d16s0 =
                    	        new NoViableAltException("", 16, 0, input);

                    	    throw nvae_d16s0;
                    	}
                    	switch (alt16) 
                    	{
                    	    case 1 :
                    	        // Smi.g:632:14: UPPER
                    	        {
                    	        	UPPER44=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_assignment2159); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{UPPER44_tree = (CommonTree)adaptor.Create(UPPER44);
                    	        		adaptor.AddChild(root_0, UPPER44_tree);
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:632:22: macroName
                    	        {
                    	        	PushFollow(FOLLOW_macroName_in_assignment2163);
                    	        	macroName45 = macroName();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, macroName45.Tree);

                    	        }
                    	        break;

                    	}

                    	string_literal46=(IToken)Match(input,153,FOLLOW_153_in_assignment2166); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal46_tree = (CommonTree)adaptor.Create(string_literal46);
                    		adaptor.AddChild(root_0, string_literal46_tree);
                    	}
                    	ASSIGN_OP47=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_assignment2168); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN_OP47_tree = (CommonTree)adaptor.Create(ASSIGN_OP47);
                    		adaptor.AddChild(root_0, ASSIGN_OP47_tree);
                    	}
                    	BEGIN_KW48=(IToken)Match(input,BEGIN_KW,FOLLOW_BEGIN_KW_in_assignment2170); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BEGIN_KW48_tree = (CommonTree)adaptor.Create(BEGIN_KW48);
                    		adaptor.AddChild(root_0, BEGIN_KW48_tree);
                    	}
                    	// Smi.g:632:60: (~ ( END_KW ) )*
                    	do 
                    	{
                    	    int alt17 = 2;
                    	    int LA17_0 = input.LA(1);

                    	    if ( ((LA17_0 >= ABSENT_KW && LA17_0 <= EMBEDDED_KW) || (LA17_0 >= ENUMERATED_KW && LA17_0 <= 197)) )
                    	    {
                    	        alt17 = 1;
                    	    }


                    	    switch (alt17) 
                    		{
                    			case 1 :
                    			    // Smi.g:
                    			    {
                    			    	set49 = (IToken)input.LT(1);
                    			    	if ( (input.LA(1) >= ABSENT_KW && input.LA(1) <= EMBEDDED_KW) || (input.LA(1) >= ENUMERATED_KW && input.LA(1) <= 197) ) 
                    			    	{
                    			    	    input.Consume();
                    			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set49));
                    			    	    state.errorRecovery = false;state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    throw mse;
                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop17;
                    	    }
                    	} while (true);

                    	loop17:
                    		;	// Stops C# compiler whining that label 'loop17' has no statements

                    	END_KW50=(IToken)Match(input,END_KW,FOLLOW_END_KW_in_assignment2180); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{END_KW50_tree = (CommonTree)adaptor.Create(END_KW50);
                    		adaptor.AddChild(root_0, END_KW50_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class symbol_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "symbol_list"
    // Smi.g:640:0: symbol_list : symbol ( COMMA symbol )* ;
    public SmiParser.symbol_list_return symbol_list() // throws RecognitionException [1]
    {   
        SmiParser.symbol_list_return retval = new SmiParser.symbol_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA52 = null;
        SmiParser.symbol_return symbol51 = default(SmiParser.symbol_return);

        SmiParser.symbol_return symbol53 = default(SmiParser.symbol_return);


        CommonTree COMMA52_tree=null;

        try 
    	{
            // Smi.g:640:14: ( symbol ( COMMA symbol )* )
            // Smi.g:640:14: symbol ( COMMA symbol )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_symbol_in_symbol_list2194);
            	symbol51 = symbol();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol51.Tree);
            	// Smi.g:640:21: ( COMMA symbol )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == COMMA) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // Smi.g:640:22: COMMA symbol
            			    {
            			    	COMMA52=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_symbol_list2197); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA52_tree = (CommonTree)adaptor.Create(COMMA52);
            			    		adaptor.AddChild(root_0, COMMA52_tree);
            			    	}
            			    	PushFollow(FOLLOW_symbol_in_symbol_list2199);
            			    	symbol53 = symbol();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol53.Tree);

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "symbol_list"

    public class symbols_from_module_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "symbols_from_module"
    // Smi.g:642:0: symbols_from_module : symbol_list FROM_KW UPPER ( obj_id_comp_lst |=> defined_value )? ;
    public SmiParser.symbols_from_module_return symbols_from_module() // throws RecognitionException [1]
    {   
        SmiParser.symbols_from_module_return retval = new SmiParser.symbols_from_module_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken FROM_KW55 = null;
        IToken UPPER56 = null;
        SmiParser.symbol_list_return symbol_list54 = default(SmiParser.symbol_list_return);

        SmiParser.obj_id_comp_lst_return obj_id_comp_lst57 = default(SmiParser.obj_id_comp_lst_return);

        SmiParser.defined_value_return defined_value58 = default(SmiParser.defined_value_return);


        CommonTree FROM_KW55_tree=null;
        CommonTree UPPER56_tree=null;

        try 
    	{
            // Smi.g:642:22: ( symbol_list FROM_KW UPPER ( obj_id_comp_lst |=> defined_value )? )
            // Smi.g:642:22: symbol_list FROM_KW UPPER ( obj_id_comp_lst |=> defined_value )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_symbol_list_in_symbols_from_module2209);
            	symbol_list54 = symbol_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol_list54.Tree);
            	FROM_KW55=(IToken)Match(input,FROM_KW,FOLLOW_FROM_KW_in_symbols_from_module2211); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{FROM_KW55_tree = (CommonTree)adaptor.Create(FROM_KW55);
            		adaptor.AddChild(root_0, FROM_KW55_tree);
            	}
            	UPPER56=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_symbols_from_module2213); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPPER56_tree = (CommonTree)adaptor.Create(UPPER56);
            		adaptor.AddChild(root_0, UPPER56_tree);
            	}
            	// Smi.g:643:25: ( obj_id_comp_lst |=> defined_value )?
            	int alt20 = 3;
            	alt20 = dfa20.Predict(input);
            	switch (alt20) 
            	{
            	    case 1 :
            	        // Smi.g:643:27: obj_id_comp_lst
            	        {
            	        	PushFollow(FOLLOW_obj_id_comp_lst_in_symbols_from_module2242);
            	        	obj_id_comp_lst57 = obj_id_comp_lst();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_comp_lst57.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:644:29: => defined_value
            	        {

            	        	PushFollow(FOLLOW_defined_value_in_symbols_from_module2279);
            	        	defined_value58 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value58.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "symbols_from_module"

    public class symbol_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "symbol"
    // Smi.g:647:0: symbol : ( UPPER | LOWER | macroName );
    public SmiParser.symbol_return symbol() // throws RecognitionException [1]
    {   
        SmiParser.symbol_return retval = new SmiParser.symbol_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER59 = null;
        IToken LOWER60 = null;
        SmiParser.macroName_return macroName61 = default(SmiParser.macroName_return);


        CommonTree UPPER59_tree=null;
        CommonTree LOWER60_tree=null;

        try 
    	{
            // Smi.g:647:9: ( UPPER | LOWER | macroName )
            int alt21 = 3;
            switch ( input.LA(1) ) 
            {
            case UPPER:
            	{
                alt21 = 1;
                }
                break;
            case LOWER:
            	{
                alt21 = 2;
                }
                break;
            case ERROR_KW:
            case OBJECT_KW:
            case OPERATION_KW:
            case 126:
            case 127:
            case 128:
            case 129:
            case 131:
            case 132:
            case 133:
            case 134:
            case 136:
            case 143:
            case 146:
            case 147:
            case 148:
            case 158:
            case 159:
            case 160:
            case 162:
            case 163:
            case 164:
            case 166:
            case 174:
            case 176:
            case 178:
            case 181:
            case 182:
            case 183:
            case 188:
            case 189:
            case 190:
            case 191:
            case 192:
            	{
                alt21 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            }

            switch (alt21) 
            {
                case 1 :
                    // Smi.g:647:9: UPPER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	UPPER59=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_symbol2315); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UPPER59_tree = (CommonTree)adaptor.Create(UPPER59);
                    		adaptor.AddChild(root_0, UPPER59_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:647:17: LOWER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LOWER60=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_symbol2319); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER60_tree = (CommonTree)adaptor.Create(LOWER60);
                    		adaptor.AddChild(root_0, LOWER60_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:647:25: macroName
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_macroName_in_symbol2323);
                    	macroName61 = macroName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, macroName61.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "symbol"

    public class macroName_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "macroName"
    // Smi.g:649:0: macroName : ( OPERATION_KW | ERROR_KW | 'BIND' | 'UNBIND' | 'APPLICATION-SERVICE-ELEMENT' | 'APPLICATION-CONTEXT' | 'EXTENSION' | 'EXTENSIONS' | 'EXTENSION-ATTRIBUTE' | 'TOKEN' | 'TOKEN-DATA' | 'SECURITY-CATEGORY' | 'OBJECT' | 'PORT' | 'REFINE' | 'ABSTRACT-BIND' | 'ABSTRACT-UNBIND' | 'ABSTRACT-OPERATION' | 'ABSTRACT-ERROR' | 'ALGORITHM' | 'ENCRYPTED' | 'SIGNED' | 'SIGNATURE' | 'PROTECTED' | smi_macros );
    public SmiParser.macroName_return macroName() // throws RecognitionException [1]
    {   
        SmiParser.macroName_return retval = new SmiParser.macroName_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken OPERATION_KW62 = null;
        IToken ERROR_KW63 = null;
        IToken string_literal64 = null;
        IToken string_literal65 = null;
        IToken string_literal66 = null;
        IToken string_literal67 = null;
        IToken string_literal68 = null;
        IToken string_literal69 = null;
        IToken string_literal70 = null;
        IToken string_literal71 = null;
        IToken string_literal72 = null;
        IToken string_literal73 = null;
        IToken string_literal74 = null;
        IToken string_literal75 = null;
        IToken string_literal76 = null;
        IToken string_literal77 = null;
        IToken string_literal78 = null;
        IToken string_literal79 = null;
        IToken string_literal80 = null;
        IToken string_literal81 = null;
        IToken string_literal82 = null;
        IToken string_literal83 = null;
        IToken string_literal84 = null;
        IToken string_literal85 = null;
        SmiParser.smi_macros_return smi_macros86 = default(SmiParser.smi_macros_return);


        CommonTree OPERATION_KW62_tree=null;
        CommonTree ERROR_KW63_tree=null;
        CommonTree string_literal64_tree=null;
        CommonTree string_literal65_tree=null;
        CommonTree string_literal66_tree=null;
        CommonTree string_literal67_tree=null;
        CommonTree string_literal68_tree=null;
        CommonTree string_literal69_tree=null;
        CommonTree string_literal70_tree=null;
        CommonTree string_literal71_tree=null;
        CommonTree string_literal72_tree=null;
        CommonTree string_literal73_tree=null;
        CommonTree string_literal74_tree=null;
        CommonTree string_literal75_tree=null;
        CommonTree string_literal76_tree=null;
        CommonTree string_literal77_tree=null;
        CommonTree string_literal78_tree=null;
        CommonTree string_literal79_tree=null;
        CommonTree string_literal80_tree=null;
        CommonTree string_literal81_tree=null;
        CommonTree string_literal82_tree=null;
        CommonTree string_literal83_tree=null;
        CommonTree string_literal84_tree=null;
        CommonTree string_literal85_tree=null;

        try 
    	{
            // Smi.g:649:12: ( OPERATION_KW | ERROR_KW | 'BIND' | 'UNBIND' | 'APPLICATION-SERVICE-ELEMENT' | 'APPLICATION-CONTEXT' | 'EXTENSION' | 'EXTENSIONS' | 'EXTENSION-ATTRIBUTE' | 'TOKEN' | 'TOKEN-DATA' | 'SECURITY-CATEGORY' | 'OBJECT' | 'PORT' | 'REFINE' | 'ABSTRACT-BIND' | 'ABSTRACT-UNBIND' | 'ABSTRACT-OPERATION' | 'ABSTRACT-ERROR' | 'ALGORITHM' | 'ENCRYPTED' | 'SIGNED' | 'SIGNATURE' | 'PROTECTED' | smi_macros )
            int alt22 = 25;
            switch ( input.LA(1) ) 
            {
            case OPERATION_KW:
            	{
                alt22 = 1;
                }
                break;
            case ERROR_KW:
            	{
                alt22 = 2;
                }
                break;
            case 136:
            	{
                alt22 = 3;
                }
                break;
            case 192:
            	{
                alt22 = 4;
                }
                break;
            case 134:
            	{
                alt22 = 5;
                }
                break;
            case 133:
            	{
                alt22 = 6;
                }
                break;
            case 146:
            	{
                alt22 = 7;
                }
                break;
            case 148:
            	{
                alt22 = 8;
                }
                break;
            case 147:
            	{
                alt22 = 9;
                }
                break;
            case 189:
            	{
                alt22 = 10;
                }
                break;
            case 190:
            	{
                alt22 = 11;
                }
                break;
            case 181:
            	{
                alt22 = 12;
                }
                break;
            case OBJECT_KW:
            	{
                alt22 = 13;
                }
                break;
            case 174:
            	{
                alt22 = 14;
                }
                break;
            case 178:
            	{
                alt22 = 15;
                }
                break;
            case 126:
            	{
                alt22 = 16;
                }
                break;
            case 129:
            	{
                alt22 = 17;
                }
                break;
            case 128:
            	{
                alt22 = 18;
                }
                break;
            case 127:
            	{
                alt22 = 19;
                }
                break;
            case 132:
            	{
                alt22 = 20;
                }
                break;
            case 143:
            	{
                alt22 = 21;
                }
                break;
            case 183:
            	{
                alt22 = 22;
                }
                break;
            case 182:
            	{
                alt22 = 23;
                }
                break;
            case 176:
            	{
                alt22 = 24;
                }
                break;
            case 131:
            case 158:
            case 159:
            case 160:
            case 162:
            case 163:
            case 164:
            case 166:
            case 188:
            case 191:
            	{
                alt22 = 25;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d22s0 =
            	        new NoViableAltException("", 22, 0, input);

            	    throw nvae_d22s0;
            }

            switch (alt22) 
            {
                case 1 :
                    // Smi.g:649:12: OPERATION_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	OPERATION_KW62=(IToken)Match(input,OPERATION_KW,FOLLOW_OPERATION_KW_in_macroName2330); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OPERATION_KW62_tree = (CommonTree)adaptor.Create(OPERATION_KW62);
                    		adaptor.AddChild(root_0, OPERATION_KW62_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:649:27: ERROR_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ERROR_KW63=(IToken)Match(input,ERROR_KW,FOLLOW_ERROR_KW_in_macroName2334); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ERROR_KW63_tree = (CommonTree)adaptor.Create(ERROR_KW63);
                    		adaptor.AddChild(root_0, ERROR_KW63_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:649:39: 'BIND'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal64=(IToken)Match(input,136,FOLLOW_136_in_macroName2339); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal64_tree = (CommonTree)adaptor.Create(string_literal64);
                    		adaptor.AddChild(root_0, string_literal64_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Smi.g:649:48: 'UNBIND'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal65=(IToken)Match(input,192,FOLLOW_192_in_macroName2343); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal65_tree = (CommonTree)adaptor.Create(string_literal65);
                    		adaptor.AddChild(root_0, string_literal65_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Smi.g:650:12: 'APPLICATION-SERVICE-ELEMENT'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal66=(IToken)Match(input,134,FOLLOW_134_in_macroName2357); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal66_tree = (CommonTree)adaptor.Create(string_literal66);
                    		adaptor.AddChild(root_0, string_literal66_tree);
                    	}

                    }
                    break;
                case 6 :
                    // Smi.g:650:44: 'APPLICATION-CONTEXT'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal67=(IToken)Match(input,133,FOLLOW_133_in_macroName2361); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal67_tree = (CommonTree)adaptor.Create(string_literal67);
                    		adaptor.AddChild(root_0, string_literal67_tree);
                    	}

                    }
                    break;
                case 7 :
                    // Smi.g:650:68: 'EXTENSION'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal68=(IToken)Match(input,146,FOLLOW_146_in_macroName2365); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal68_tree = (CommonTree)adaptor.Create(string_literal68);
                    		adaptor.AddChild(root_0, string_literal68_tree);
                    	}

                    }
                    break;
                case 8 :
                    // Smi.g:651:12: 'EXTENSIONS'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal69=(IToken)Match(input,148,FOLLOW_148_in_macroName2379); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal69_tree = (CommonTree)adaptor.Create(string_literal69);
                    		adaptor.AddChild(root_0, string_literal69_tree);
                    	}

                    }
                    break;
                case 9 :
                    // Smi.g:651:27: 'EXTENSION-ATTRIBUTE'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal70=(IToken)Match(input,147,FOLLOW_147_in_macroName2383); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal70_tree = (CommonTree)adaptor.Create(string_literal70);
                    		adaptor.AddChild(root_0, string_literal70_tree);
                    	}

                    }
                    break;
                case 10 :
                    // Smi.g:651:51: 'TOKEN'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal71=(IToken)Match(input,189,FOLLOW_189_in_macroName2387); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal71_tree = (CommonTree)adaptor.Create(string_literal71);
                    		adaptor.AddChild(root_0, string_literal71_tree);
                    	}

                    }
                    break;
                case 11 :
                    // Smi.g:651:61: 'TOKEN-DATA'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal72=(IToken)Match(input,190,FOLLOW_190_in_macroName2391); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal72_tree = (CommonTree)adaptor.Create(string_literal72);
                    		adaptor.AddChild(root_0, string_literal72_tree);
                    	}

                    }
                    break;
                case 12 :
                    // Smi.g:652:5: 'SECURITY-CATEGORY'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal73=(IToken)Match(input,181,FOLLOW_181_in_macroName2398); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal73_tree = (CommonTree)adaptor.Create(string_literal73);
                    		adaptor.AddChild(root_0, string_literal73_tree);
                    	}

                    }
                    break;
                case 13 :
                    // Smi.g:652:27: 'OBJECT'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal74=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_macroName2402); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal74_tree = (CommonTree)adaptor.Create(string_literal74);
                    		adaptor.AddChild(root_0, string_literal74_tree);
                    	}

                    }
                    break;
                case 14 :
                    // Smi.g:652:38: 'PORT'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal75=(IToken)Match(input,174,FOLLOW_174_in_macroName2406); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal75_tree = (CommonTree)adaptor.Create(string_literal75);
                    		adaptor.AddChild(root_0, string_literal75_tree);
                    	}

                    }
                    break;
                case 15 :
                    // Smi.g:652:47: 'REFINE'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal76=(IToken)Match(input,178,FOLLOW_178_in_macroName2410); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal76_tree = (CommonTree)adaptor.Create(string_literal76);
                    		adaptor.AddChild(root_0, string_literal76_tree);
                    	}

                    }
                    break;
                case 16 :
                    // Smi.g:652:58: 'ABSTRACT-BIND'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal77=(IToken)Match(input,126,FOLLOW_126_in_macroName2414); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal77_tree = (CommonTree)adaptor.Create(string_literal77);
                    		adaptor.AddChild(root_0, string_literal77_tree);
                    	}

                    }
                    break;
                case 17 :
                    // Smi.g:653:5: 'ABSTRACT-UNBIND'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal78=(IToken)Match(input,129,FOLLOW_129_in_macroName2421); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal78_tree = (CommonTree)adaptor.Create(string_literal78);
                    		adaptor.AddChild(root_0, string_literal78_tree);
                    	}

                    }
                    break;
                case 18 :
                    // Smi.g:653:25: 'ABSTRACT-OPERATION'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal79=(IToken)Match(input,128,FOLLOW_128_in_macroName2425); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal79_tree = (CommonTree)adaptor.Create(string_literal79);
                    		adaptor.AddChild(root_0, string_literal79_tree);
                    	}

                    }
                    break;
                case 19 :
                    // Smi.g:653:48: 'ABSTRACT-ERROR'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal80=(IToken)Match(input,127,FOLLOW_127_in_macroName2429); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal80_tree = (CommonTree)adaptor.Create(string_literal80);
                    		adaptor.AddChild(root_0, string_literal80_tree);
                    	}

                    }
                    break;
                case 20 :
                    // Smi.g:654:5: 'ALGORITHM'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal81=(IToken)Match(input,132,FOLLOW_132_in_macroName2436); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal81_tree = (CommonTree)adaptor.Create(string_literal81);
                    		adaptor.AddChild(root_0, string_literal81_tree);
                    	}

                    }
                    break;
                case 21 :
                    // Smi.g:654:19: 'ENCRYPTED'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal82=(IToken)Match(input,143,FOLLOW_143_in_macroName2440); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal82_tree = (CommonTree)adaptor.Create(string_literal82);
                    		adaptor.AddChild(root_0, string_literal82_tree);
                    	}

                    }
                    break;
                case 22 :
                    // Smi.g:654:33: 'SIGNED'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal83=(IToken)Match(input,183,FOLLOW_183_in_macroName2444); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal83_tree = (CommonTree)adaptor.Create(string_literal83);
                    		adaptor.AddChild(root_0, string_literal83_tree);
                    	}

                    }
                    break;
                case 23 :
                    // Smi.g:654:44: 'SIGNATURE'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal84=(IToken)Match(input,182,FOLLOW_182_in_macroName2448); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal84_tree = (CommonTree)adaptor.Create(string_literal84);
                    		adaptor.AddChild(root_0, string_literal84_tree);
                    	}

                    }
                    break;
                case 24 :
                    // Smi.g:654:58: 'PROTECTED'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal85=(IToken)Match(input,176,FOLLOW_176_in_macroName2452); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal85_tree = (CommonTree)adaptor.Create(string_literal85);
                    		adaptor.AddChild(root_0, string_literal85_tree);
                    	}

                    }
                    break;
                case 25 :
                    // Smi.g:655:5: smi_macros
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_smi_macros_in_macroName2459);
                    	smi_macros86 = smi_macros();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_macros86.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "macroName"

    public class type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "type"
    // Smi.g:657:0: type : ( built_in_type | defined_type | selection_type | macros_type | smi_type );
    public SmiParser.type_return type() // throws RecognitionException [1]
    {   
        SmiParser.type_return retval = new SmiParser.type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.built_in_type_return built_in_type87 = default(SmiParser.built_in_type_return);

        SmiParser.defined_type_return defined_type88 = default(SmiParser.defined_type_return);

        SmiParser.selection_type_return selection_type89 = default(SmiParser.selection_type_return);

        SmiParser.macros_type_return macros_type90 = default(SmiParser.macros_type_return);

        SmiParser.smi_type_return smi_type91 = default(SmiParser.smi_type_return);



        try 
    	{
            // Smi.g:657:7: ( built_in_type | defined_type | selection_type | macros_type | smi_type )
            int alt23 = 5;
            alt23 = dfa23.Predict(input);
            switch (alt23) 
            {
                case 1 :
                    // Smi.g:657:7: built_in_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_built_in_type_in_type2466);
                    	built_in_type87 = built_in_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, built_in_type87.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:657:23: defined_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defined_type_in_type2470);
                    	defined_type88 = defined_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_type88.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:657:38: selection_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selection_type_in_type2474);
                    	selection_type89 = selection_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selection_type89.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:657:55: macros_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_macros_type_in_type2478);
                    	macros_type90 = macros_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, macros_type90.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:657:69: smi_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_smi_type_in_type2482);
                    	smi_type91 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type91.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type"

    public class value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "value"
    // Smi.g:659:0: value : (=> TRUE_KW |=> FALSE_KW |=> NULL_KW |=> C_STRING |=> defined_value |=> signed_number |=> choice_value |=> sequence_value |=> sequenceof_value |=> cstr_value |=> obj_id_comp_lst |=> PLUS_INFINITY_KW |=> MINUS_INFINITY_KW );
    public SmiParser.value_return value() // throws RecognitionException [1]
    {   
        SmiParser.value_return retval = new SmiParser.value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken TRUE_KW92 = null;
        IToken FALSE_KW93 = null;
        IToken NULL_KW94 = null;
        IToken C_STRING95 = null;
        IToken PLUS_INFINITY_KW103 = null;
        IToken MINUS_INFINITY_KW104 = null;
        SmiParser.defined_value_return defined_value96 = default(SmiParser.defined_value_return);

        SmiParser.signed_number_return signed_number97 = default(SmiParser.signed_number_return);

        SmiParser.choice_value_return choice_value98 = default(SmiParser.choice_value_return);

        SmiParser.sequence_value_return sequence_value99 = default(SmiParser.sequence_value_return);

        SmiParser.sequenceof_value_return sequenceof_value100 = default(SmiParser.sequenceof_value_return);

        SmiParser.cstr_value_return cstr_value101 = default(SmiParser.cstr_value_return);

        SmiParser.obj_id_comp_lst_return obj_id_comp_lst102 = default(SmiParser.obj_id_comp_lst_return);


        CommonTree TRUE_KW92_tree=null;
        CommonTree FALSE_KW93_tree=null;
        CommonTree NULL_KW94_tree=null;
        CommonTree C_STRING95_tree=null;
        CommonTree PLUS_INFINITY_KW103_tree=null;
        CommonTree MINUS_INFINITY_KW104_tree=null;

        try 
    	{
            // Smi.g:659:8: (=> TRUE_KW |=> FALSE_KW |=> NULL_KW |=> C_STRING |=> defined_value |=> signed_number |=> choice_value |=> sequence_value |=> sequenceof_value |=> cstr_value |=> obj_id_comp_lst |=> PLUS_INFINITY_KW |=> MINUS_INFINITY_KW )
            int alt24 = 13;
            alt24 = dfa24.Predict(input);
            switch (alt24) 
            {
                case 1 :
                    // Smi.g:659:8: => TRUE_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	TRUE_KW92=(IToken)Match(input,TRUE_KW,FOLLOW_TRUE_KW_in_value2495); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{TRUE_KW92_tree = (CommonTree)adaptor.Create(TRUE_KW92);
                    		adaptor.AddChild(root_0, TRUE_KW92_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:660:8: => FALSE_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	FALSE_KW93=(IToken)Match(input,FALSE_KW,FOLLOW_FALSE_KW_in_value2511); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FALSE_KW93_tree = (CommonTree)adaptor.Create(FALSE_KW93);
                    		adaptor.AddChild(root_0, FALSE_KW93_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:661:8: => NULL_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	NULL_KW94=(IToken)Match(input,NULL_KW,FOLLOW_NULL_KW_in_value2527); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NULL_KW94_tree = (CommonTree)adaptor.Create(NULL_KW94);
                    		adaptor.AddChild(root_0, NULL_KW94_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Smi.g:662:8: => C_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	C_STRING95=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_value2544); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING95_tree = (CommonTree)adaptor.Create(C_STRING95);
                    		adaptor.AddChild(root_0, C_STRING95_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Smi.g:663:8: => defined_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_defined_value_in_value2560);
                    	defined_value96 = defined_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value96.Tree);

                    }
                    break;
                case 6 :
                    // Smi.g:664:8: => signed_number
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_signed_number_in_value2576);
                    	signed_number97 = signed_number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number97.Tree);

                    }
                    break;
                case 7 :
                    // Smi.g:665:8: => choice_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_choice_value_in_value2591);
                    	choice_value98 = choice_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, choice_value98.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:666:8: => sequence_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_sequence_value_in_value2607);
                    	sequence_value99 = sequence_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequence_value99.Tree);

                    }
                    break;
                case 9 :
                    // Smi.g:667:8: => sequenceof_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_sequenceof_value_in_value2623);
                    	sequenceof_value100 = sequenceof_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequenceof_value100.Tree);

                    }
                    break;
                case 10 :
                    // Smi.g:668:8: => cstr_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_cstr_value_in_value2639);
                    	cstr_value101 = cstr_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cstr_value101.Tree);

                    }
                    break;
                case 11 :
                    // Smi.g:669:8: => obj_id_comp_lst
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_obj_id_comp_lst_in_value2655);
                    	obj_id_comp_lst102 = obj_id_comp_lst();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_comp_lst102.Tree);

                    }
                    break;
                case 12 :
                    // Smi.g:670:8: => PLUS_INFINITY_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PLUS_INFINITY_KW103=(IToken)Match(input,PLUS_INFINITY_KW,FOLLOW_PLUS_INFINITY_KW_in_value2671); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PLUS_INFINITY_KW103_tree = (CommonTree)adaptor.Create(PLUS_INFINITY_KW103);
                    		adaptor.AddChild(root_0, PLUS_INFINITY_KW103_tree);
                    	}

                    }
                    break;
                case 13 :
                    // Smi.g:671:8: => MINUS_INFINITY_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	MINUS_INFINITY_KW104=(IToken)Match(input,MINUS_INFINITY_KW,FOLLOW_MINUS_INFINITY_KW_in_value2687); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{MINUS_INFINITY_KW104_tree = (CommonTree)adaptor.Create(MINUS_INFINITY_KW104);
                    		adaptor.AddChild(root_0, MINUS_INFINITY_KW104_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value"

    public class built_in_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "built_in_type"
    // Smi.g:673:0: built_in_type : ( any_type | bit_string_type | boolean_type | character_str_type | choice_type | embedded_type EMBEDDED_KW PDV_KW | enum_type | external_type | integer_type | null_type | object_identifier_type | octetString_type | real_type | relativeOid_type | sequence_type | sequenceof_type | set_type | setof_type | tagged_type );
    public SmiParser.built_in_type_return built_in_type() // throws RecognitionException [1]
    {   
        SmiParser.built_in_type_return retval = new SmiParser.built_in_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EMBEDDED_KW111 = null;
        IToken PDV_KW112 = null;
        SmiParser.any_type_return any_type105 = default(SmiParser.any_type_return);

        SmiParser.bit_string_type_return bit_string_type106 = default(SmiParser.bit_string_type_return);

        SmiParser.boolean_type_return boolean_type107 = default(SmiParser.boolean_type_return);

        SmiParser.character_str_type_return character_str_type108 = default(SmiParser.character_str_type_return);

        SmiParser.choice_type_return choice_type109 = default(SmiParser.choice_type_return);

        SmiParser.embedded_type_return embedded_type110 = default(SmiParser.embedded_type_return);

        SmiParser.enum_type_return enum_type113 = default(SmiParser.enum_type_return);

        SmiParser.external_type_return external_type114 = default(SmiParser.external_type_return);

        SmiParser.integer_type_return integer_type115 = default(SmiParser.integer_type_return);

        SmiParser.null_type_return null_type116 = default(SmiParser.null_type_return);

        SmiParser.object_identifier_type_return object_identifier_type117 = default(SmiParser.object_identifier_type_return);

        SmiParser.octetString_type_return octetString_type118 = default(SmiParser.octetString_type_return);

        SmiParser.real_type_return real_type119 = default(SmiParser.real_type_return);

        SmiParser.relativeOid_type_return relativeOid_type120 = default(SmiParser.relativeOid_type_return);

        SmiParser.sequence_type_return sequence_type121 = default(SmiParser.sequence_type_return);

        SmiParser.sequenceof_type_return sequenceof_type122 = default(SmiParser.sequenceof_type_return);

        SmiParser.set_type_return set_type123 = default(SmiParser.set_type_return);

        SmiParser.setof_type_return setof_type124 = default(SmiParser.setof_type_return);

        SmiParser.tagged_type_return tagged_type125 = default(SmiParser.tagged_type_return);


        CommonTree EMBEDDED_KW111_tree=null;
        CommonTree PDV_KW112_tree=null;

        try 
    	{
            // Smi.g:673:16: ( any_type | bit_string_type | boolean_type | character_str_type | choice_type | embedded_type EMBEDDED_KW PDV_KW | enum_type | external_type | integer_type | null_type | object_identifier_type | octetString_type | real_type | relativeOid_type | sequence_type | sequenceof_type | set_type | setof_type | tagged_type )
            int alt25 = 19;
            alt25 = dfa25.Predict(input);
            switch (alt25) 
            {
                case 1 :
                    // Smi.g:673:16: any_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_any_type_in_built_in_type2694);
                    	any_type105 = any_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, any_type105.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:674:16: bit_string_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bit_string_type_in_built_in_type2712);
                    	bit_string_type106 = bit_string_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bit_string_type106.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:675:16: boolean_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_type_in_built_in_type2730);
                    	boolean_type107 = boolean_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolean_type107.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:676:16: character_str_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_character_str_type_in_built_in_type2748);
                    	character_str_type108 = character_str_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, character_str_type108.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:677:16: choice_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_choice_type_in_built_in_type2766);
                    	choice_type109 = choice_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, choice_type109.Tree);

                    }
                    break;
                case 6 :
                    // Smi.g:678:16: embedded_type EMBEDDED_KW PDV_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_embedded_type_in_built_in_type2783);
                    	embedded_type110 = embedded_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, embedded_type110.Tree);
                    	EMBEDDED_KW111=(IToken)Match(input,EMBEDDED_KW,FOLLOW_EMBEDDED_KW_in_built_in_type2785); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{EMBEDDED_KW111_tree = (CommonTree)adaptor.Create(EMBEDDED_KW111);
                    		adaptor.AddChild(root_0, EMBEDDED_KW111_tree);
                    	}
                    	PDV_KW112=(IToken)Match(input,PDV_KW,FOLLOW_PDV_KW_in_built_in_type2787); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PDV_KW112_tree = (CommonTree)adaptor.Create(PDV_KW112);
                    		adaptor.AddChild(root_0, PDV_KW112_tree);
                    	}

                    }
                    break;
                case 7 :
                    // Smi.g:679:16: enum_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_enum_type_in_built_in_type2805);
                    	enum_type113 = enum_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, enum_type113.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:680:16: external_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_external_type_in_built_in_type2822);
                    	external_type114 = external_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, external_type114.Tree);

                    }
                    break;
                case 9 :
                    // Smi.g:681:9: integer_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_type_in_built_in_type2832);
                    	integer_type115 = integer_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, integer_type115.Tree);

                    }
                    break;
                case 10 :
                    // Smi.g:682:9: null_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_null_type_in_built_in_type2842);
                    	null_type116 = null_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, null_type116.Tree);

                    }
                    break;
                case 11 :
                    // Smi.g:683:9: object_identifier_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_object_identifier_type_in_built_in_type2852);
                    	object_identifier_type117 = object_identifier_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, object_identifier_type117.Tree);

                    }
                    break;
                case 12 :
                    // Smi.g:684:9: octetString_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_octetString_type_in_built_in_type2862);
                    	octetString_type118 = octetString_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, octetString_type118.Tree);

                    }
                    break;
                case 13 :
                    // Smi.g:685:9: real_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_real_type_in_built_in_type2872);
                    	real_type119 = real_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, real_type119.Tree);

                    }
                    break;
                case 14 :
                    // Smi.g:686:9: relativeOid_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_relativeOid_type_in_built_in_type2882);
                    	relativeOid_type120 = relativeOid_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relativeOid_type120.Tree);

                    }
                    break;
                case 15 :
                    // Smi.g:687:9: sequence_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_sequence_type_in_built_in_type2892);
                    	sequence_type121 = sequence_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequence_type121.Tree);

                    }
                    break;
                case 16 :
                    // Smi.g:688:9: sequenceof_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_sequenceof_type_in_built_in_type2902);
                    	sequenceof_type122 = sequenceof_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequenceof_type122.Tree);

                    }
                    break;
                case 17 :
                    // Smi.g:689:9: set_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_set_type_in_built_in_type2912);
                    	set_type123 = set_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, set_type123.Tree);

                    }
                    break;
                case 18 :
                    // Smi.g:690:9: setof_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_setof_type_in_built_in_type2922);
                    	setof_type124 = setof_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, setof_type124.Tree);

                    }
                    break;
                case 19 :
                    // Smi.g:691:9: tagged_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tagged_type_in_built_in_type2932);
                    	tagged_type125 = tagged_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tagged_type125.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "built_in_type"

    public class defined_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "defined_type"
    // Smi.g:693:0: defined_type : ( UPPER DOT )? UPPER ( constraint )? ;
    public SmiParser.defined_type_return defined_type() // throws RecognitionException [1]
    {   
        SmiParser.defined_type_return retval = new SmiParser.defined_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER126 = null;
        IToken DOT127 = null;
        IToken UPPER128 = null;
        SmiParser.constraint_return constraint129 = default(SmiParser.constraint_return);


        CommonTree UPPER126_tree=null;
        CommonTree DOT127_tree=null;
        CommonTree UPPER128_tree=null;

        try 
    	{
            // Smi.g:693:15: ( ( UPPER DOT )? UPPER ( constraint )? )
            // Smi.g:693:15: ( UPPER DOT )? UPPER ( constraint )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:693:15: ( UPPER DOT )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == UPPER) )
            	{
            	    int LA26_1 = input.LA(2);

            	    if ( (LA26_1 == DOT) )
            	    {
            	        alt26 = 1;
            	    }
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // Smi.g:693:16: UPPER DOT
            	        {
            	        	UPPER126=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_defined_type2940); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UPPER126_tree = (CommonTree)adaptor.Create(UPPER126);
            	        		adaptor.AddChild(root_0, UPPER126_tree);
            	        	}
            	        	DOT127=(IToken)Match(input,DOT,FOLLOW_DOT_in_defined_type2942); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOT127_tree = (CommonTree)adaptor.Create(DOT127);
            	        		adaptor.AddChild(root_0, DOT127_tree);
            	        	}

            	        }
            	        break;

            	}

            	UPPER128=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_defined_type2946); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPPER128_tree = (CommonTree)adaptor.Create(UPPER128);
            		adaptor.AddChild(root_0, UPPER128_tree);
            	}
            	// Smi.g:693:34: ( constraint )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == L_PAREN) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // Smi.g:693:35: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_defined_type2949);
            	        	constraint129 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint129.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defined_type"

    public class selection_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selection_type"
    // Smi.g:695:0: selection_type : LOWER LESS type ;
    public SmiParser.selection_type_return selection_type() // throws RecognitionException [1]
    {   
        SmiParser.selection_type_return retval = new SmiParser.selection_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER130 = null;
        IToken LESS131 = null;
        SmiParser.type_return type132 = default(SmiParser.type_return);


        CommonTree LOWER130_tree=null;
        CommonTree LESS131_tree=null;

        try 
    	{
            // Smi.g:695:17: ( LOWER LESS type )
            // Smi.g:695:17: LOWER LESS type
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER130=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_selection_type2959); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER130_tree = (CommonTree)adaptor.Create(LOWER130);
            		adaptor.AddChild(root_0, LOWER130_tree);
            	}
            	LESS131=(IToken)Match(input,LESS,FOLLOW_LESS_in_selection_type2961); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LESS131_tree = (CommonTree)adaptor.Create(LESS131);
            		adaptor.AddChild(root_0, LESS131_tree);
            	}
            	PushFollow(FOLLOW_type_in_selection_type2963);
            	type132 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type132.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selection_type"

    public class any_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "any_type"
    // Smi.g:697:0: any_type : ANY_KW ( DEFINED_KW BY_KW LOWER )? ;
    public SmiParser.any_type_return any_type() // throws RecognitionException [1]
    {   
        SmiParser.any_type_return retval = new SmiParser.any_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ANY_KW133 = null;
        IToken DEFINED_KW134 = null;
        IToken BY_KW135 = null;
        IToken LOWER136 = null;

        CommonTree ANY_KW133_tree=null;
        CommonTree DEFINED_KW134_tree=null;
        CommonTree BY_KW135_tree=null;
        CommonTree LOWER136_tree=null;

        try 
    	{
            // Smi.g:697:11: ( ANY_KW ( DEFINED_KW BY_KW LOWER )? )
            // Smi.g:697:11: ANY_KW ( DEFINED_KW BY_KW LOWER )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	ANY_KW133=(IToken)Match(input,ANY_KW,FOLLOW_ANY_KW_in_any_type2970); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ANY_KW133_tree = (CommonTree)adaptor.Create(ANY_KW133);
            		adaptor.AddChild(root_0, ANY_KW133_tree);
            	}
            	// Smi.g:697:18: ( DEFINED_KW BY_KW LOWER )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == DEFINED_KW) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // Smi.g:697:19: DEFINED_KW BY_KW LOWER
            	        {
            	        	DEFINED_KW134=(IToken)Match(input,DEFINED_KW,FOLLOW_DEFINED_KW_in_any_type2973); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DEFINED_KW134_tree = (CommonTree)adaptor.Create(DEFINED_KW134);
            	        		adaptor.AddChild(root_0, DEFINED_KW134_tree);
            	        	}
            	        	BY_KW135=(IToken)Match(input,BY_KW,FOLLOW_BY_KW_in_any_type2975); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{BY_KW135_tree = (CommonTree)adaptor.Create(BY_KW135);
            	        		adaptor.AddChild(root_0, BY_KW135_tree);
            	        	}
            	        	LOWER136=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_any_type2977); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LOWER136_tree = (CommonTree)adaptor.Create(LOWER136);
            	        		adaptor.AddChild(root_0, LOWER136_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "any_type"

    public class bit_string_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "bit_string_type"
    // Smi.g:700:0: bit_string_type : BIT_KW STRING_KW (=> namedNumber_list )? ( constraint )? ;
    public SmiParser.bit_string_type_return bit_string_type() // throws RecognitionException [1]
    {   
        SmiParser.bit_string_type_return retval = new SmiParser.bit_string_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken BIT_KW137 = null;
        IToken STRING_KW138 = null;
        SmiParser.namedNumber_list_return namedNumber_list139 = default(SmiParser.namedNumber_list_return);

        SmiParser.constraint_return constraint140 = default(SmiParser.constraint_return);


        CommonTree BIT_KW137_tree=null;
        CommonTree STRING_KW138_tree=null;

        try 
    	{
            // Smi.g:700:18: ( BIT_KW STRING_KW (=> namedNumber_list )? ( constraint )? )
            // Smi.g:700:18: BIT_KW STRING_KW (=> namedNumber_list )? ( constraint )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	BIT_KW137=(IToken)Match(input,BIT_KW,FOLLOW_BIT_KW_in_bit_string_type2989); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BIT_KW137_tree = (CommonTree)adaptor.Create(BIT_KW137);
            		adaptor.AddChild(root_0, BIT_KW137_tree);
            	}
            	STRING_KW138=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_bit_string_type2991); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{STRING_KW138_tree = (CommonTree)adaptor.Create(STRING_KW138);
            		adaptor.AddChild(root_0, STRING_KW138_tree);
            	}
            	// Smi.g:700:35: (=> namedNumber_list )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( (LA29_0 == L_BRACE) && (synpred16_Smi()) )
            	{
            	    alt29 = 1;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // Smi.g:700:36: => namedNumber_list
            	        {

            	        	PushFollow(FOLLOW_namedNumber_list_in_bit_string_type3002);
            	        	namedNumber_list139 = namedNumber_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber_list139.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:700:80: ( constraint )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == L_PAREN) )
            	{
            	    alt30 = 1;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // Smi.g:700:81: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_bit_string_type3007);
            	        	constraint140 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint140.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bit_string_type"

    public class boolean_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "boolean_type"
    // Smi.g:703:0: boolean_type : BOOLEAN_KW ;
    public SmiParser.boolean_type_return boolean_type() // throws RecognitionException [1]
    {   
        SmiParser.boolean_type_return retval = new SmiParser.boolean_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken BOOLEAN_KW141 = null;

        CommonTree BOOLEAN_KW141_tree=null;

        try 
    	{
            // Smi.g:703:15: ( BOOLEAN_KW )
            // Smi.g:703:15: BOOLEAN_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	BOOLEAN_KW141=(IToken)Match(input,BOOLEAN_KW,FOLLOW_BOOLEAN_KW_in_boolean_type3018); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BOOLEAN_KW141_tree = (CommonTree)adaptor.Create(BOOLEAN_KW141);
            		adaptor.AddChild(root_0, BOOLEAN_KW141_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "boolean_type"

    public class character_str_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "character_str_type"
    // Smi.g:705:0: character_str_type : ( CHARACTER_KW STRING_KW | character_set ( constraint )? );
    public SmiParser.character_str_type_return character_str_type() // throws RecognitionException [1]
    {   
        SmiParser.character_str_type_return retval = new SmiParser.character_str_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken CHARACTER_KW142 = null;
        IToken STRING_KW143 = null;
        SmiParser.character_set_return character_set144 = default(SmiParser.character_set_return);

        SmiParser.constraint_return constraint145 = default(SmiParser.constraint_return);


        CommonTree CHARACTER_KW142_tree=null;
        CommonTree STRING_KW143_tree=null;

        try 
    	{
            // Smi.g:705:21: ( CHARACTER_KW STRING_KW | character_set ( constraint )? )
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == CHARACTER_KW) )
            {
                alt32 = 1;
            }
            else if ( (LA32_0 == BMP_STR_KW || (LA32_0 >= GENERAL_STR_KW && LA32_0 <= GRAPHIC_STR_KW) || LA32_0 == IA5_STRING_KW || LA32_0 == ISO646_STR_KW || LA32_0 == NUMERIC_STR_KW || LA32_0 == PRINTABLE_STR_KW || LA32_0 == T61_STR_KW || LA32_0 == TELETEX_STR_KW || LA32_0 == UNIVERSAL_STR_KW || (LA32_0 >= UTC_TIME_KW && LA32_0 <= VISIBLE_STR_KW)) )
            {
                alt32 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d32s0 =
                    new NoViableAltException("", 32, 0, input);

                throw nvae_d32s0;
            }
            switch (alt32) 
            {
                case 1 :
                    // Smi.g:705:21: CHARACTER_KW STRING_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHARACTER_KW142=(IToken)Match(input,CHARACTER_KW,FOLLOW_CHARACTER_KW_in_character_str_type3025); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CHARACTER_KW142_tree = (CommonTree)adaptor.Create(CHARACTER_KW142);
                    		adaptor.AddChild(root_0, CHARACTER_KW142_tree);
                    	}
                    	STRING_KW143=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_character_str_type3027); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING_KW143_tree = (CommonTree)adaptor.Create(STRING_KW143);
                    		adaptor.AddChild(root_0, STRING_KW143_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:705:46: character_set ( constraint )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_character_set_in_character_str_type3031);
                    	character_set144 = character_set();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, character_set144.Tree);
                    	// Smi.g:705:60: ( constraint )?
                    	int alt31 = 2;
                    	int LA31_0 = input.LA(1);

                    	if ( (LA31_0 == L_PAREN) )
                    	{
                    	    alt31 = 1;
                    	}
                    	switch (alt31) 
                    	{
                    	    case 1 :
                    	        // Smi.g:705:61: constraint
                    	        {
                    	        	PushFollow(FOLLOW_constraint_in_character_str_type3034);
                    	        	constraint145 = constraint();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint145.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "character_str_type"

    public class choice_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "choice_type"
    // Smi.g:707:0: choice_type : CHOICE_KW L_BRACE elementType_list R_BRACE ;
    public SmiParser.choice_type_return choice_type() // throws RecognitionException [1]
    {   
        SmiParser.choice_type_return retval = new SmiParser.choice_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken CHOICE_KW146 = null;
        IToken L_BRACE147 = null;
        IToken R_BRACE149 = null;
        SmiParser.elementType_list_return elementType_list148 = default(SmiParser.elementType_list_return);


        CommonTree CHOICE_KW146_tree=null;
        CommonTree L_BRACE147_tree=null;
        CommonTree R_BRACE149_tree=null;

        try 
    	{
            // Smi.g:707:14: ( CHOICE_KW L_BRACE elementType_list R_BRACE )
            // Smi.g:707:14: CHOICE_KW L_BRACE elementType_list R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	CHOICE_KW146=(IToken)Match(input,CHOICE_KW,FOLLOW_CHOICE_KW_in_choice_type3044); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{CHOICE_KW146_tree = (CommonTree)adaptor.Create(CHOICE_KW146);
            		adaptor.AddChild(root_0, CHOICE_KW146_tree);
            	}
            	L_BRACE147=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_choice_type3046); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE147_tree = (CommonTree)adaptor.Create(L_BRACE147);
            		adaptor.AddChild(root_0, L_BRACE147_tree);
            	}
            	PushFollow(FOLLOW_elementType_list_in_choice_type3048);
            	elementType_list148 = elementType_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType_list148.Tree);
            	R_BRACE149=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_choice_type3050); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE149_tree = (CommonTree)adaptor.Create(R_BRACE149);
            		adaptor.AddChild(root_0, R_BRACE149_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "choice_type"

    public class embedded_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "embedded_type"
    // Smi.g:709:0: embedded_type : EMBEDDED_KW PDV_KW ;
    public SmiParser.embedded_type_return embedded_type() // throws RecognitionException [1]
    {   
        SmiParser.embedded_type_return retval = new SmiParser.embedded_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EMBEDDED_KW150 = null;
        IToken PDV_KW151 = null;

        CommonTree EMBEDDED_KW150_tree=null;
        CommonTree PDV_KW151_tree=null;

        try 
    	{
            // Smi.g:709:16: ( EMBEDDED_KW PDV_KW )
            // Smi.g:709:16: EMBEDDED_KW PDV_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	EMBEDDED_KW150=(IToken)Match(input,EMBEDDED_KW,FOLLOW_EMBEDDED_KW_in_embedded_type3057); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EMBEDDED_KW150_tree = (CommonTree)adaptor.Create(EMBEDDED_KW150);
            		adaptor.AddChild(root_0, EMBEDDED_KW150_tree);
            	}
            	PDV_KW151=(IToken)Match(input,PDV_KW,FOLLOW_PDV_KW_in_embedded_type3059); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{PDV_KW151_tree = (CommonTree)adaptor.Create(PDV_KW151);
            		adaptor.AddChild(root_0, PDV_KW151_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "embedded_type"

    public class enum_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "enum_type"
    // Smi.g:711:0: enum_type : ENUMERATED_KW namedNumber_list ;
    public SmiParser.enum_type_return enum_type() // throws RecognitionException [1]
    {   
        SmiParser.enum_type_return retval = new SmiParser.enum_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ENUMERATED_KW152 = null;
        SmiParser.namedNumber_list_return namedNumber_list153 = default(SmiParser.namedNumber_list_return);


        CommonTree ENUMERATED_KW152_tree=null;

        try 
    	{
            // Smi.g:711:12: ( ENUMERATED_KW namedNumber_list )
            // Smi.g:711:12: ENUMERATED_KW namedNumber_list
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	ENUMERATED_KW152=(IToken)Match(input,ENUMERATED_KW,FOLLOW_ENUMERATED_KW_in_enum_type3066); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ENUMERATED_KW152_tree = (CommonTree)adaptor.Create(ENUMERATED_KW152);
            		adaptor.AddChild(root_0, ENUMERATED_KW152_tree);
            	}
            	PushFollow(FOLLOW_namedNumber_list_in_enum_type3068);
            	namedNumber_list153 = namedNumber_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber_list153.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "enum_type"

    public class external_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "external_type"
    // Smi.g:713:0: external_type : EXTERNAL_KW ;
    public SmiParser.external_type_return external_type() // throws RecognitionException [1]
    {   
        SmiParser.external_type_return retval = new SmiParser.external_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EXTERNAL_KW154 = null;

        CommonTree EXTERNAL_KW154_tree=null;

        try 
    	{
            // Smi.g:713:16: ( EXTERNAL_KW )
            // Smi.g:713:16: EXTERNAL_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	EXTERNAL_KW154=(IToken)Match(input,EXTERNAL_KW,FOLLOW_EXTERNAL_KW_in_external_type3075); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXTERNAL_KW154_tree = (CommonTree)adaptor.Create(EXTERNAL_KW154);
            		adaptor.AddChild(root_0, EXTERNAL_KW154_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "external_type"

    public class integer_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "integer_type"
    // Smi.g:716:0: integer_type : INTEGER_KW (=> namedNumber_list | constraint )? ;
    public SmiParser.integer_type_return integer_type() // throws RecognitionException [1]
    {   
        SmiParser.integer_type_return retval = new SmiParser.integer_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken INTEGER_KW155 = null;
        SmiParser.namedNumber_list_return namedNumber_list156 = default(SmiParser.namedNumber_list_return);

        SmiParser.constraint_return constraint157 = default(SmiParser.constraint_return);


        CommonTree INTEGER_KW155_tree=null;

        try 
    	{
            // Smi.g:716:15: ( INTEGER_KW (=> namedNumber_list | constraint )? )
            // Smi.g:716:15: INTEGER_KW (=> namedNumber_list | constraint )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	INTEGER_KW155=(IToken)Match(input,INTEGER_KW,FOLLOW_INTEGER_KW_in_integer_type3084); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{INTEGER_KW155_tree = (CommonTree)adaptor.Create(INTEGER_KW155);
            		adaptor.AddChild(root_0, INTEGER_KW155_tree);
            	}
            	// Smi.g:716:26: (=> namedNumber_list | constraint )?
            	int alt33 = 3;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == L_BRACE) && (synpred17_Smi()) )
            	{
            	    alt33 = 1;
            	}
            	else if ( (LA33_0 == L_PAREN) )
            	{
            	    alt33 = 2;
            	}
            	switch (alt33) 
            	{
            	    case 1 :
            	        // Smi.g:716:27: => namedNumber_list
            	        {

            	        	PushFollow(FOLLOW_namedNumber_list_in_integer_type3095);
            	        	namedNumber_list156 = namedNumber_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber_list156.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:716:71: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_integer_type3099);
            	        	constraint157 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint157.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "integer_type"

    public class null_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "null_type"
    // Smi.g:719:0: null_type : NULL_KW ;
    public SmiParser.null_type_return null_type() // throws RecognitionException [1]
    {   
        SmiParser.null_type_return retval = new SmiParser.null_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NULL_KW158 = null;

        CommonTree NULL_KW158_tree=null;

        try 
    	{
            // Smi.g:719:12: ( NULL_KW )
            // Smi.g:719:12: NULL_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	NULL_KW158=(IToken)Match(input,NULL_KW,FOLLOW_NULL_KW_in_null_type3110); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NULL_KW158_tree = (CommonTree)adaptor.Create(NULL_KW158);
            		adaptor.AddChild(root_0, NULL_KW158_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "null_type"

    public class object_identifier_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "object_identifier_type"
    // Smi.g:721:0: object_identifier_type : OBJECT_KW IDENTIFIER_KW ;
    public SmiParser.object_identifier_type_return object_identifier_type() // throws RecognitionException [1]
    {   
        SmiParser.object_identifier_type_return retval = new SmiParser.object_identifier_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken OBJECT_KW159 = null;
        IToken IDENTIFIER_KW160 = null;

        CommonTree OBJECT_KW159_tree=null;
        CommonTree IDENTIFIER_KW160_tree=null;

        try 
    	{
            // Smi.g:721:25: ( OBJECT_KW IDENTIFIER_KW )
            // Smi.g:721:25: OBJECT_KW IDENTIFIER_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	OBJECT_KW159=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_object_identifier_type3117); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OBJECT_KW159_tree = (CommonTree)adaptor.Create(OBJECT_KW159);
            		adaptor.AddChild(root_0, OBJECT_KW159_tree);
            	}
            	IDENTIFIER_KW160=(IToken)Match(input,IDENTIFIER_KW,FOLLOW_IDENTIFIER_KW_in_object_identifier_type3119); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENTIFIER_KW160_tree = (CommonTree)adaptor.Create(IDENTIFIER_KW160);
            		adaptor.AddChild(root_0, IDENTIFIER_KW160_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "object_identifier_type"

    public class octetString_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "octetString_type"
    // Smi.g:723:0: octetString_type : OCTET_KW STRING_KW ( constraint )? ;
    public SmiParser.octetString_type_return octetString_type() // throws RecognitionException [1]
    {   
        SmiParser.octetString_type_return retval = new SmiParser.octetString_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken OCTET_KW161 = null;
        IToken STRING_KW162 = null;
        SmiParser.constraint_return constraint163 = default(SmiParser.constraint_return);


        CommonTree OCTET_KW161_tree=null;
        CommonTree STRING_KW162_tree=null;

        try 
    	{
            // Smi.g:723:19: ( OCTET_KW STRING_KW ( constraint )? )
            // Smi.g:723:19: OCTET_KW STRING_KW ( constraint )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	OCTET_KW161=(IToken)Match(input,OCTET_KW,FOLLOW_OCTET_KW_in_octetString_type3126); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OCTET_KW161_tree = (CommonTree)adaptor.Create(OCTET_KW161);
            		adaptor.AddChild(root_0, OCTET_KW161_tree);
            	}
            	STRING_KW162=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_octetString_type3128); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{STRING_KW162_tree = (CommonTree)adaptor.Create(STRING_KW162);
            		adaptor.AddChild(root_0, STRING_KW162_tree);
            	}
            	// Smi.g:723:38: ( constraint )?
            	int alt34 = 2;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == L_PAREN) )
            	{
            	    alt34 = 1;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // Smi.g:723:39: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_octetString_type3131);
            	        	constraint163 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint163.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "octetString_type"

    public class real_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "real_type"
    // Smi.g:725:0: real_type : REAL_KW ;
    public SmiParser.real_type_return real_type() // throws RecognitionException [1]
    {   
        SmiParser.real_type_return retval = new SmiParser.real_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken REAL_KW164 = null;

        CommonTree REAL_KW164_tree=null;

        try 
    	{
            // Smi.g:725:12: ( REAL_KW )
            // Smi.g:725:12: REAL_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	REAL_KW164=(IToken)Match(input,REAL_KW,FOLLOW_REAL_KW_in_real_type3141); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{REAL_KW164_tree = (CommonTree)adaptor.Create(REAL_KW164);
            		adaptor.AddChild(root_0, REAL_KW164_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "real_type"

    public class relativeOid_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relativeOid_type"
    // Smi.g:728:0: relativeOid_type : 'RELATIVE-OID' ;
    public SmiParser.relativeOid_type_return relativeOid_type() // throws RecognitionException [1]
    {   
        SmiParser.relativeOid_type_return retval = new SmiParser.relativeOid_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal165 = null;

        CommonTree string_literal165_tree=null;

        try 
    	{
            // Smi.g:728:19: ( 'RELATIVE-OID' )
            // Smi.g:728:19: 'RELATIVE-OID'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal165=(IToken)Match(input,179,FOLLOW_179_in_relativeOid_type3150); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal165_tree = (CommonTree)adaptor.Create(string_literal165);
            		adaptor.AddChild(root_0, string_literal165_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relativeOid_type"

    public class sequence_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "sequence_type"
    // Smi.g:731:0: sequence_type : SEQUENCE_KW L_BRACE ( elementType_list )? R_BRACE ;
    public SmiParser.sequence_type_return sequence_type() // throws RecognitionException [1]
    {   
        SmiParser.sequence_type_return retval = new SmiParser.sequence_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SEQUENCE_KW166 = null;
        IToken L_BRACE167 = null;
        IToken R_BRACE169 = null;
        SmiParser.elementType_list_return elementType_list168 = default(SmiParser.elementType_list_return);


        CommonTree SEQUENCE_KW166_tree=null;
        CommonTree L_BRACE167_tree=null;
        CommonTree R_BRACE169_tree=null;

        try 
    	{
            // Smi.g:731:16: ( SEQUENCE_KW L_BRACE ( elementType_list )? R_BRACE )
            // Smi.g:731:16: SEQUENCE_KW L_BRACE ( elementType_list )? R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	SEQUENCE_KW166=(IToken)Match(input,SEQUENCE_KW,FOLLOW_SEQUENCE_KW_in_sequence_type3158); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEQUENCE_KW166_tree = (CommonTree)adaptor.Create(SEQUENCE_KW166);
            		adaptor.AddChild(root_0, SEQUENCE_KW166_tree);
            	}
            	L_BRACE167=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_sequence_type3160); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE167_tree = (CommonTree)adaptor.Create(L_BRACE167);
            		adaptor.AddChild(root_0, L_BRACE167_tree);
            	}
            	// Smi.g:731:36: ( elementType_list )?
            	int alt35 = 2;
            	int LA35_0 = input.LA(1);

            	if ( (LA35_0 == COMPONENTS_KW || LA35_0 == LOWER) )
            	{
            	    alt35 = 1;
            	}
            	switch (alt35) 
            	{
            	    case 1 :
            	        // Smi.g:731:37: elementType_list
            	        {
            	        	PushFollow(FOLLOW_elementType_list_in_sequence_type3163);
            	        	elementType_list168 = elementType_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType_list168.Tree);

            	        }
            	        break;

            	}

            	R_BRACE169=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_sequence_type3167); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE169_tree = (CommonTree)adaptor.Create(R_BRACE169);
            		adaptor.AddChild(root_0, R_BRACE169_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequence_type"

    public class sequenceof_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "sequenceof_type"
    // Smi.g:733:0: sequenceof_type : SEQUENCE_KW ( SIZE_KW constraint )? OF_KW type ;
    public SmiParser.sequenceof_type_return sequenceof_type() // throws RecognitionException [1]
    {   
        SmiParser.sequenceof_type_return retval = new SmiParser.sequenceof_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SEQUENCE_KW170 = null;
        IToken SIZE_KW171 = null;
        IToken OF_KW173 = null;
        SmiParser.constraint_return constraint172 = default(SmiParser.constraint_return);

        SmiParser.type_return type174 = default(SmiParser.type_return);


        CommonTree SEQUENCE_KW170_tree=null;
        CommonTree SIZE_KW171_tree=null;
        CommonTree OF_KW173_tree=null;

        try 
    	{
            // Smi.g:733:18: ( SEQUENCE_KW ( SIZE_KW constraint )? OF_KW type )
            // Smi.g:733:18: SEQUENCE_KW ( SIZE_KW constraint )? OF_KW type
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	SEQUENCE_KW170=(IToken)Match(input,SEQUENCE_KW,FOLLOW_SEQUENCE_KW_in_sequenceof_type3175); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEQUENCE_KW170_tree = (CommonTree)adaptor.Create(SEQUENCE_KW170);
            		adaptor.AddChild(root_0, SEQUENCE_KW170_tree);
            	}
            	// Smi.g:733:30: ( SIZE_KW constraint )?
            	int alt36 = 2;
            	int LA36_0 = input.LA(1);

            	if ( (LA36_0 == SIZE_KW) )
            	{
            	    alt36 = 1;
            	}
            	switch (alt36) 
            	{
            	    case 1 :
            	        // Smi.g:733:31: SIZE_KW constraint
            	        {
            	        	SIZE_KW171=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_sequenceof_type3178); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{SIZE_KW171_tree = (CommonTree)adaptor.Create(SIZE_KW171);
            	        		adaptor.AddChild(root_0, SIZE_KW171_tree);
            	        	}
            	        	PushFollow(FOLLOW_constraint_in_sequenceof_type3180);
            	        	constraint172 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint172.Tree);

            	        }
            	        break;

            	}

            	OF_KW173=(IToken)Match(input,OF_KW,FOLLOW_OF_KW_in_sequenceof_type3184); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OF_KW173_tree = (CommonTree)adaptor.Create(OF_KW173);
            		adaptor.AddChild(root_0, OF_KW173_tree);
            	}
            	PushFollow(FOLLOW_type_in_sequenceof_type3186);
            	type174 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type174.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequenceof_type"

    public class set_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "set_type"
    // Smi.g:735:0: set_type : SET_KW L_BRACE ( elementType_list )? R_BRACE ;
    public SmiParser.set_type_return set_type() // throws RecognitionException [1]
    {   
        SmiParser.set_type_return retval = new SmiParser.set_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SET_KW175 = null;
        IToken L_BRACE176 = null;
        IToken R_BRACE178 = null;
        SmiParser.elementType_list_return elementType_list177 = default(SmiParser.elementType_list_return);


        CommonTree SET_KW175_tree=null;
        CommonTree L_BRACE176_tree=null;
        CommonTree R_BRACE178_tree=null;

        try 
    	{
            // Smi.g:735:11: ( SET_KW L_BRACE ( elementType_list )? R_BRACE )
            // Smi.g:735:11: SET_KW L_BRACE ( elementType_list )? R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	SET_KW175=(IToken)Match(input,SET_KW,FOLLOW_SET_KW_in_set_type3193); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SET_KW175_tree = (CommonTree)adaptor.Create(SET_KW175);
            		adaptor.AddChild(root_0, SET_KW175_tree);
            	}
            	L_BRACE176=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_set_type3195); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE176_tree = (CommonTree)adaptor.Create(L_BRACE176);
            		adaptor.AddChild(root_0, L_BRACE176_tree);
            	}
            	// Smi.g:735:26: ( elementType_list )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == COMPONENTS_KW || LA37_0 == LOWER) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // Smi.g:735:27: elementType_list
            	        {
            	        	PushFollow(FOLLOW_elementType_list_in_set_type3198);
            	        	elementType_list177 = elementType_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType_list177.Tree);

            	        }
            	        break;

            	}

            	R_BRACE178=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_set_type3202); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE178_tree = (CommonTree)adaptor.Create(R_BRACE178);
            		adaptor.AddChild(root_0, R_BRACE178_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "set_type"

    public class setof_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "setof_type"
    // Smi.g:737:0: setof_type : SET_KW ( SIZE_KW constraint )? OF_KW type ;
    public SmiParser.setof_type_return setof_type() // throws RecognitionException [1]
    {   
        SmiParser.setof_type_return retval = new SmiParser.setof_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SET_KW179 = null;
        IToken SIZE_KW180 = null;
        IToken OF_KW182 = null;
        SmiParser.constraint_return constraint181 = default(SmiParser.constraint_return);

        SmiParser.type_return type183 = default(SmiParser.type_return);


        CommonTree SET_KW179_tree=null;
        CommonTree SIZE_KW180_tree=null;
        CommonTree OF_KW182_tree=null;

        try 
    	{
            // Smi.g:737:13: ( SET_KW ( SIZE_KW constraint )? OF_KW type )
            // Smi.g:737:13: SET_KW ( SIZE_KW constraint )? OF_KW type
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	SET_KW179=(IToken)Match(input,SET_KW,FOLLOW_SET_KW_in_setof_type3209); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SET_KW179_tree = (CommonTree)adaptor.Create(SET_KW179);
            		adaptor.AddChild(root_0, SET_KW179_tree);
            	}
            	// Smi.g:737:20: ( SIZE_KW constraint )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( (LA38_0 == SIZE_KW) )
            	{
            	    alt38 = 1;
            	}
            	switch (alt38) 
            	{
            	    case 1 :
            	        // Smi.g:737:21: SIZE_KW constraint
            	        {
            	        	SIZE_KW180=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_setof_type3212); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{SIZE_KW180_tree = (CommonTree)adaptor.Create(SIZE_KW180);
            	        		adaptor.AddChild(root_0, SIZE_KW180_tree);
            	        	}
            	        	PushFollow(FOLLOW_constraint_in_setof_type3214);
            	        	constraint181 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint181.Tree);

            	        }
            	        break;

            	}

            	OF_KW182=(IToken)Match(input,OF_KW,FOLLOW_OF_KW_in_setof_type3218); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OF_KW182_tree = (CommonTree)adaptor.Create(OF_KW182);
            		adaptor.AddChild(root_0, OF_KW182_tree);
            	}
            	PushFollow(FOLLOW_type_in_setof_type3220);
            	type183 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type183.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "setof_type"

    public class tagged_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tagged_type"
    // Smi.g:739:0: tagged_type : tag ( tag_default )? type ;
    public SmiParser.tagged_type_return tagged_type() // throws RecognitionException [1]
    {   
        SmiParser.tagged_type_return retval = new SmiParser.tagged_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.tag_return tag184 = default(SmiParser.tag_return);

        SmiParser.tag_default_return tag_default185 = default(SmiParser.tag_default_return);

        SmiParser.type_return type186 = default(SmiParser.type_return);



        try 
    	{
            // Smi.g:739:14: ( tag ( tag_default )? type )
            // Smi.g:739:14: tag ( tag_default )? type
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tag_in_tagged_type3227);
            	tag184 = tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag184.Tree);
            	// Smi.g:739:18: ( tag_default )?
            	int alt39 = 2;
            	int LA39_0 = input.LA(1);

            	if ( (LA39_0 == AUTOMATIC_KW || LA39_0 == EXPLICIT_KW || LA39_0 == IMPLICIT_KW) )
            	{
            	    alt39 = 1;
            	}
            	switch (alt39) 
            	{
            	    case 1 :
            	        // Smi.g:739:19: tag_default
            	        {
            	        	PushFollow(FOLLOW_tag_default_in_tagged_type3230);
            	        	tag_default185 = tag_default();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag_default185.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_type_in_tagged_type3234);
            	type186 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type186.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tagged_type"

    public class namedNumber_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "namedNumber_list"
    // Smi.g:741:0: namedNumber_list : L_BRACE namedNumber ( COMMA namedNumber )* R_BRACE ;
    public SmiParser.namedNumber_list_return namedNumber_list() // throws RecognitionException [1]
    {   
        SmiParser.namedNumber_list_return retval = new SmiParser.namedNumber_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE187 = null;
        IToken COMMA189 = null;
        IToken R_BRACE191 = null;
        SmiParser.namedNumber_return namedNumber188 = default(SmiParser.namedNumber_return);

        SmiParser.namedNumber_return namedNumber190 = default(SmiParser.namedNumber_return);


        CommonTree L_BRACE187_tree=null;
        CommonTree COMMA189_tree=null;
        CommonTree R_BRACE191_tree=null;

        try 
    	{
            // Smi.g:741:19: ( L_BRACE namedNumber ( COMMA namedNumber )* R_BRACE )
            // Smi.g:741:19: L_BRACE namedNumber ( COMMA namedNumber )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE187=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_namedNumber_list3241); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE187_tree = (CommonTree)adaptor.Create(L_BRACE187);
            		adaptor.AddChild(root_0, L_BRACE187_tree);
            	}
            	PushFollow(FOLLOW_namedNumber_in_namedNumber_list3243);
            	namedNumber188 = namedNumber();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber188.Tree);
            	// Smi.g:741:39: ( COMMA namedNumber )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == COMMA) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // Smi.g:741:40: COMMA namedNumber
            			    {
            			    	COMMA189=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_namedNumber_list3246); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA189_tree = (CommonTree)adaptor.Create(COMMA189);
            			    		adaptor.AddChild(root_0, COMMA189_tree);
            			    	}
            			    	PushFollow(FOLLOW_namedNumber_in_namedNumber_list3248);
            			    	namedNumber190 = namedNumber();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber190.Tree);

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements

            	R_BRACE191=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_namedNumber_list3252); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE191_tree = (CommonTree)adaptor.Create(R_BRACE191);
            		adaptor.AddChild(root_0, R_BRACE191_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "namedNumber_list"

    public class constraint_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constraint"
    // Smi.g:743:0: constraint : L_PAREN ( element_set_specs )? ( exception_spec )? R_PAREN ;
    public SmiParser.constraint_return constraint() // throws RecognitionException [1]
    {   
        SmiParser.constraint_return retval = new SmiParser.constraint_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_PAREN192 = null;
        IToken R_PAREN195 = null;
        SmiParser.element_set_specs_return element_set_specs193 = default(SmiParser.element_set_specs_return);

        SmiParser.exception_spec_return exception_spec194 = default(SmiParser.exception_spec_return);


        CommonTree L_PAREN192_tree=null;
        CommonTree R_PAREN195_tree=null;

        try 
    	{
            // Smi.g:743:13: ( L_PAREN ( element_set_specs )? ( exception_spec )? R_PAREN )
            // Smi.g:743:13: L_PAREN ( element_set_specs )? ( exception_spec )? R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_PAREN192=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_constraint3259); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN192_tree = (CommonTree)adaptor.Create(L_PAREN192);
            		adaptor.AddChild(root_0, L_PAREN192_tree);
            	}
            	// Smi.g:743:21: ( element_set_specs )?
            	int alt41 = 2;
            	int LA41_0 = input.LA(1);

            	if ( ((LA41_0 >= ALL_KW && LA41_0 <= ANY_KW) || LA41_0 == B_STRING || (LA41_0 >= BIT_KW && LA41_0 <= BOOLEAN_KW) || (LA41_0 >= C_STRING && LA41_0 <= CHARACTER_KW) || LA41_0 == CHOICE_KW || LA41_0 == EMBEDDED_KW || (LA41_0 >= ENUMERATED_KW && LA41_0 <= ERROR_KW) || (LA41_0 >= EXTERNAL_KW && LA41_0 <= H_STRING) || LA41_0 == IA5_STRING_KW || LA41_0 == INCLUDES_KW || LA41_0 == INTEGER_KW || (LA41_0 >= ISO646_STR_KW && LA41_0 <= L_PAREN) || LA41_0 == LOWER || (LA41_0 >= MIN_KW && LA41_0 <= NUMERIC_STR_KW) || (LA41_0 >= OBJECT_KW && LA41_0 <= OCTET_KW) || LA41_0 == OPERATION_KW || LA41_0 == PATTERN_KW || LA41_0 == PLUS_INFINITY_KW || LA41_0 == PRINTABLE_STR_KW || LA41_0 == REAL_KW || (LA41_0 >= SEQUENCE_KW && LA41_0 <= SET_KW) || LA41_0 == SIZE_KW || LA41_0 == T61_STR_KW || (LA41_0 >= TELETEX_STR_KW && LA41_0 <= TRUE_KW) || (LA41_0 >= UNIVERSAL_STR_KW && LA41_0 <= WITH_KW) || LA41_0 == 131 || LA41_0 == 137 || (LA41_0 >= 158 && LA41_0 <= 160) || (LA41_0 >= 162 && LA41_0 <= 164) || LA41_0 == 166 || LA41_0 == 179 || LA41_0 == 188 || LA41_0 == 191) )
            	{
            	    alt41 = 1;
            	}
            	switch (alt41) 
            	{
            	    case 1 :
            	        // Smi.g:743:22: element_set_specs
            	        {
            	        	PushFollow(FOLLOW_element_set_specs_in_constraint3262);
            	        	element_set_specs193 = element_set_specs();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_specs193.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:743:42: ( exception_spec )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( (LA42_0 == EXCLAMATION) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // Smi.g:743:43: exception_spec
            	        {
            	        	PushFollow(FOLLOW_exception_spec_in_constraint3267);
            	        	exception_spec194 = exception_spec();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exception_spec194.Tree);

            	        }
            	        break;

            	}

            	R_PAREN195=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_constraint3271); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN195_tree = (CommonTree)adaptor.Create(R_PAREN195);
            		adaptor.AddChild(root_0, R_PAREN195_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constraint"

    public class character_set_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "character_set"
    // Smi.g:745:0: character_set : ( BMP_STR_KW | GENERALIZED_TIME_KW | GENERAL_STR_KW | GRAPHIC_STR_KW | IA5_STRING_KW | ISO646_STR_KW | NUMERIC_STR_KW | PRINTABLE_STR_KW | TELETEX_STR_KW | T61_STR_KW | UNIVERSAL_STR_KW | UTF8_STR_KW | UTC_TIME_KW | VIDEOTEX_STR_KW | VISIBLE_STR_KW );
    public SmiParser.character_set_return character_set() // throws RecognitionException [1]
    {   
        SmiParser.character_set_return retval = new SmiParser.character_set_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set196 = null;

        CommonTree set196_tree=null;

        try 
    	{
            // Smi.g:745:16: ( BMP_STR_KW | GENERALIZED_TIME_KW | GENERAL_STR_KW | GRAPHIC_STR_KW | IA5_STRING_KW | ISO646_STR_KW | NUMERIC_STR_KW | PRINTABLE_STR_KW | TELETEX_STR_KW | T61_STR_KW | UNIVERSAL_STR_KW | UTF8_STR_KW | UTC_TIME_KW | VIDEOTEX_STR_KW | VISIBLE_STR_KW )
            // Smi.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set196 = (IToken)input.LT(1);
            	if ( input.LA(1) == BMP_STR_KW || (input.LA(1) >= GENERAL_STR_KW && input.LA(1) <= GRAPHIC_STR_KW) || input.LA(1) == IA5_STRING_KW || input.LA(1) == ISO646_STR_KW || input.LA(1) == NUMERIC_STR_KW || input.LA(1) == PRINTABLE_STR_KW || input.LA(1) == T61_STR_KW || input.LA(1) == TELETEX_STR_KW || input.LA(1) == UNIVERSAL_STR_KW || (input.LA(1) >= UTC_TIME_KW && input.LA(1) <= VISIBLE_STR_KW) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set196));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "character_set"

    public class elementType_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "elementType_list"
    // Smi.g:750:0: elementType_list : elementType ( COMMA elementType )* ;
    public SmiParser.elementType_list_return elementType_list() // throws RecognitionException [1]
    {   
        SmiParser.elementType_list_return retval = new SmiParser.elementType_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA198 = null;
        SmiParser.elementType_return elementType197 = default(SmiParser.elementType_return);

        SmiParser.elementType_return elementType199 = default(SmiParser.elementType_return);


        CommonTree COMMA198_tree=null;

        try 
    	{
            // Smi.g:750:19: ( elementType ( COMMA elementType )* )
            // Smi.g:750:19: elementType ( COMMA elementType )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_elementType_in_elementType_list3380);
            	elementType197 = elementType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType197.Tree);
            	// Smi.g:750:31: ( COMMA elementType )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == COMMA) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // Smi.g:750:32: COMMA elementType
            			    {
            			    	COMMA198=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_elementType_list3383); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA198_tree = (CommonTree)adaptor.Create(COMMA198);
            			    		adaptor.AddChild(root_0, COMMA198_tree);
            			    	}
            			    	PushFollow(FOLLOW_elementType_in_elementType_list3385);
            			    	elementType199 = elementType();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType199.Tree);

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elementType_list"

    public class tag_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tag"
    // Smi.g:752:0: tag : L_BRACKET ( clazz )? class_NUMBER R_BRACKET ;
    public SmiParser.tag_return tag() // throws RecognitionException [1]
    {   
        SmiParser.tag_return retval = new SmiParser.tag_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACKET200 = null;
        IToken R_BRACKET203 = null;
        SmiParser.clazz_return clazz201 = default(SmiParser.clazz_return);

        SmiParser.class_NUMBER_return class_NUMBER202 = default(SmiParser.class_NUMBER_return);


        CommonTree L_BRACKET200_tree=null;
        CommonTree R_BRACKET203_tree=null;

        try 
    	{
            // Smi.g:752:6: ( L_BRACKET ( clazz )? class_NUMBER R_BRACKET )
            // Smi.g:752:6: L_BRACKET ( clazz )? class_NUMBER R_BRACKET
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACKET200=(IToken)Match(input,L_BRACKET,FOLLOW_L_BRACKET_in_tag3395); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACKET200_tree = (CommonTree)adaptor.Create(L_BRACKET200);
            		adaptor.AddChild(root_0, L_BRACKET200_tree);
            	}
            	// Smi.g:752:16: ( clazz )?
            	int alt44 = 2;
            	int LA44_0 = input.LA(1);

            	if ( (LA44_0 == APPLICATION_KW || LA44_0 == PRIVATE_KW || LA44_0 == UNIVERSAL_KW) )
            	{
            	    alt44 = 1;
            	}
            	switch (alt44) 
            	{
            	    case 1 :
            	        // Smi.g:752:17: clazz
            	        {
            	        	PushFollow(FOLLOW_clazz_in_tag3398);
            	        	clazz201 = clazz();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, clazz201.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_class_NUMBER_in_tag3402);
            	class_NUMBER202 = class_NUMBER();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, class_NUMBER202.Tree);
            	R_BRACKET203=(IToken)Match(input,R_BRACKET,FOLLOW_R_BRACKET_in_tag3404); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACKET203_tree = (CommonTree)adaptor.Create(R_BRACKET203);
            		adaptor.AddChild(root_0, R_BRACKET203_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tag"

    public class clazz_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "clazz"
    // Smi.g:754:0: clazz : ( UNIVERSAL_KW | APPLICATION_KW | PRIVATE_KW );
    public SmiParser.clazz_return clazz() // throws RecognitionException [1]
    {   
        SmiParser.clazz_return retval = new SmiParser.clazz_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set204 = null;

        CommonTree set204_tree=null;

        try 
    	{
            // Smi.g:754:8: ( UNIVERSAL_KW | APPLICATION_KW | PRIVATE_KW )
            // Smi.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set204 = (IToken)input.LT(1);
            	if ( input.LA(1) == APPLICATION_KW || input.LA(1) == PRIVATE_KW || input.LA(1) == UNIVERSAL_KW ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set204));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "clazz"

    public class class_NUMBER_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "class_NUMBER"
    // Smi.g:757:0: class_NUMBER : ( NUMBER | defined_value );
    public SmiParser.class_NUMBER_return class_NUMBER() // throws RecognitionException [1]
    {   
        SmiParser.class_NUMBER_return retval = new SmiParser.class_NUMBER_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NUMBER205 = null;
        SmiParser.defined_value_return defined_value206 = default(SmiParser.defined_value_return);


        CommonTree NUMBER205_tree=null;

        try 
    	{
            // Smi.g:757:15: ( NUMBER | defined_value )
            int alt45 = 2;
            int LA45_0 = input.LA(1);

            if ( (LA45_0 == NUMBER) )
            {
                alt45 = 1;
            }
            else if ( (LA45_0 == LOWER || LA45_0 == UPPER) )
            {
                alt45 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d45s0 =
                    new NoViableAltException("", 45, 0, input);

                throw nvae_d45s0;
            }
            switch (alt45) 
            {
                case 1 :
                    // Smi.g:757:15: NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	NUMBER205=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_class_NUMBER3428); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER205_tree = (CommonTree)adaptor.Create(NUMBER205);
                    		adaptor.AddChild(root_0, NUMBER205_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:757:24: defined_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defined_value_in_class_NUMBER3432);
                    	defined_value206 = defined_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value206.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "class_NUMBER"

    public class operation_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "operation_macro"
    // Smi.g:760:0: operation_macro : 'OPERATION' ( ARGUMENT_KW (=> LOWER )? type )? (=> RESULT_KW (=> (=> LOWER )? type )? )? (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )? (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )? ;
    public SmiParser.operation_macro_return operation_macro() // throws RecognitionException [1]
    {   
        SmiParser.operation_macro_return retval = new SmiParser.operation_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal207 = null;
        IToken ARGUMENT_KW208 = null;
        IToken LOWER209 = null;
        IToken RESULT_KW211 = null;
        IToken LOWER212 = null;
        IToken ERRORS_KW214 = null;
        IToken L_BRACE215 = null;
        IToken R_BRACE217 = null;
        IToken LINKED_KW218 = null;
        IToken L_BRACE219 = null;
        IToken R_BRACE221 = null;
        SmiParser.type_return type210 = default(SmiParser.type_return);

        SmiParser.type_return type213 = default(SmiParser.type_return);

        SmiParser.operation_errorlist_return operation_errorlist216 = default(SmiParser.operation_errorlist_return);

        SmiParser.linkedOp_list_return linkedOp_list220 = default(SmiParser.linkedOp_list_return);


        CommonTree string_literal207_tree=null;
        CommonTree ARGUMENT_KW208_tree=null;
        CommonTree LOWER209_tree=null;
        CommonTree RESULT_KW211_tree=null;
        CommonTree LOWER212_tree=null;
        CommonTree ERRORS_KW214_tree=null;
        CommonTree L_BRACE215_tree=null;
        CommonTree R_BRACE217_tree=null;
        CommonTree LINKED_KW218_tree=null;
        CommonTree L_BRACE219_tree=null;
        CommonTree R_BRACE221_tree=null;

        try 
    	{
            // Smi.g:760:18: ( 'OPERATION' ( ARGUMENT_KW (=> LOWER )? type )? (=> RESULT_KW (=> (=> LOWER )? type )? )? (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )? (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )? )
            // Smi.g:760:18: 'OPERATION' ( ARGUMENT_KW (=> LOWER )? type )? (=> RESULT_KW (=> (=> LOWER )? type )? )? (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )? (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal207=(IToken)Match(input,OPERATION_KW,FOLLOW_OPERATION_KW_in_operation_macro3441); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal207_tree = (CommonTree)adaptor.Create(string_literal207);
            		adaptor.AddChild(root_0, string_literal207_tree);
            	}
            	// Smi.g:760:30: ( ARGUMENT_KW (=> LOWER )? type )?
            	int alt47 = 2;
            	int LA47_0 = input.LA(1);

            	if ( (LA47_0 == ARGUMENT_KW) )
            	{
            	    alt47 = 1;
            	}
            	switch (alt47) 
            	{
            	    case 1 :
            	        // Smi.g:760:31: ARGUMENT_KW (=> LOWER )? type
            	        {
            	        	ARGUMENT_KW208=(IToken)Match(input,ARGUMENT_KW,FOLLOW_ARGUMENT_KW_in_operation_macro3444); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ARGUMENT_KW208_tree = (CommonTree)adaptor.Create(ARGUMENT_KW208);
            	        		adaptor.AddChild(root_0, ARGUMENT_KW208_tree);
            	        	}
            	        	// Smi.g:760:43: (=> LOWER )?
            	        	int alt46 = 2;
            	        	alt46 = dfa46.Predict(input);
            	        	switch (alt46) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:760:44: => LOWER
            	        	        {

            	        	        	LOWER209=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_operation_macro3453); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{LOWER209_tree = (CommonTree)adaptor.Create(LOWER209);
            	        	        		adaptor.AddChild(root_0, LOWER209_tree);
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	PushFollow(FOLLOW_type_in_operation_macro3457);
            	        	type210 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type210.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:761:21: (=> RESULT_KW (=> (=> LOWER )? type )? )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == RESULT_KW) )
            	{
            	    int LA50_1 = input.LA(2);

            	    if ( (synpred19_Smi()) )
            	    {
            	        alt50 = 1;
            	    }
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // Smi.g:761:23: => RESULT_KW (=> (=> LOWER )? type )?
            	        {

            	        	RESULT_KW211=(IToken)Match(input,RESULT_KW,FOLLOW_RESULT_KW_in_operation_macro3491); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{RESULT_KW211_tree = (CommonTree)adaptor.Create(RESULT_KW211);
            	        		adaptor.AddChild(root_0, RESULT_KW211_tree);
            	        	}
            	        	// Smi.g:762:25: (=> (=> LOWER )? type )?
            	        	int alt49 = 2;
            	        	alt49 = dfa49.Predict(input);
            	        	switch (alt49) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:762:26: => (=> LOWER )? type
            	        	        {

            	        	        	// Smi.g:762:37: (=> LOWER )?
            	        	        	int alt48 = 2;
            	        	        	alt48 = dfa48.Predict(input);
            	        	        	switch (alt48) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // Smi.g:762:38: => LOWER
            	        	        	        {

            	        	        	        	LOWER212=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_operation_macro3532); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{LOWER212_tree = (CommonTree)adaptor.Create(LOWER212);
            	        	        	        		adaptor.AddChild(root_0, LOWER212_tree);
            	        	        	        	}

            	        	        	        }
            	        	        	        break;

            	        	        	}

            	        	        	PushFollow(FOLLOW_type_in_operation_macro3536);
            	        	        	type213 = type();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type213.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// Smi.g:764:21: (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )?
            	int alt52 = 2;
            	int LA52_0 = input.LA(1);

            	if ( (LA52_0 == ERRORS_KW) )
            	{
            	    int LA52_1 = input.LA(2);

            	    if ( (synpred22_Smi()) )
            	    {
            	        alt52 = 1;
            	    }
            	}
            	switch (alt52) 
            	{
            	    case 1 :
            	        // Smi.g:764:23: => ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE
            	        {

            	        	ERRORS_KW214=(IToken)Match(input,ERRORS_KW,FOLLOW_ERRORS_KW_in_operation_macro3578); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ERRORS_KW214_tree = (CommonTree)adaptor.Create(ERRORS_KW214);
            	        		adaptor.AddChild(root_0, ERRORS_KW214_tree);
            	        	}
            	        	L_BRACE215=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_operation_macro3580); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE215_tree = (CommonTree)adaptor.Create(L_BRACE215);
            	        		adaptor.AddChild(root_0, L_BRACE215_tree);
            	        	}
            	        	// Smi.g:764:56: ( operation_errorlist )?
            	        	int alt51 = 2;
            	        	int LA51_0 = input.LA(1);

            	        	if ( (LA51_0 == ANY_KW || LA51_0 == B_STRING || (LA51_0 >= BIT_KW && LA51_0 <= BOOLEAN_KW) || (LA51_0 >= C_STRING && LA51_0 <= CHARACTER_KW) || LA51_0 == CHOICE_KW || LA51_0 == EMBEDDED_KW || (LA51_0 >= ENUMERATED_KW && LA51_0 <= ERROR_KW) || (LA51_0 >= EXTERNAL_KW && LA51_0 <= FALSE_KW) || (LA51_0 >= GENERAL_STR_KW && LA51_0 <= H_STRING) || LA51_0 == IA5_STRING_KW || LA51_0 == INTEGER_KW || (LA51_0 >= ISO646_STR_KW && LA51_0 <= L_BRACKET) || LA51_0 == LOWER || (LA51_0 >= MINUS && LA51_0 <= NUMERIC_STR_KW) || (LA51_0 >= OBJECT_KW && LA51_0 <= OCTET_KW) || LA51_0 == OPERATION_KW || LA51_0 == PLUS_INFINITY_KW || LA51_0 == PRINTABLE_STR_KW || LA51_0 == REAL_KW || (LA51_0 >= SEQUENCE_KW && LA51_0 <= SET_KW) || LA51_0 == T61_STR_KW || (LA51_0 >= TELETEX_STR_KW && LA51_0 <= TRUE_KW) || (LA51_0 >= UNIVERSAL_STR_KW && LA51_0 <= VISIBLE_STR_KW) || LA51_0 == 131 || LA51_0 == 137 || (LA51_0 >= 158 && LA51_0 <= 160) || (LA51_0 >= 162 && LA51_0 <= 164) || LA51_0 == 166 || LA51_0 == 179 || LA51_0 == 188 || LA51_0 == 191) )
            	        	{
            	        	    alt51 = 1;
            	        	}
            	        	switch (alt51) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:764:57: operation_errorlist
            	        	        {
            	        	        	PushFollow(FOLLOW_operation_errorlist_in_operation_macro3583);
            	        	        	operation_errorlist216 = operation_errorlist();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operation_errorlist216.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE217=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_operation_macro3587); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE217_tree = (CommonTree)adaptor.Create(R_BRACE217);
            	        		adaptor.AddChild(root_0, R_BRACE217_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:765:21: (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )?
            	int alt54 = 2;
            	int LA54_0 = input.LA(1);

            	if ( (LA54_0 == LINKED_KW) )
            	{
            	    int LA54_1 = input.LA(2);

            	    if ( (synpred23_Smi()) )
            	    {
            	        alt54 = 1;
            	    }
            	}
            	switch (alt54) 
            	{
            	    case 1 :
            	        // Smi.g:765:23: => LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE
            	        {

            	        	LINKED_KW218=(IToken)Match(input,LINKED_KW,FOLLOW_LINKED_KW_in_operation_macro3621); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LINKED_KW218_tree = (CommonTree)adaptor.Create(LINKED_KW218);
            	        		adaptor.AddChild(root_0, LINKED_KW218_tree);
            	        	}
            	        	L_BRACE219=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_operation_macro3623); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE219_tree = (CommonTree)adaptor.Create(L_BRACE219);
            	        		adaptor.AddChild(root_0, L_BRACE219_tree);
            	        	}
            	        	// Smi.g:765:56: ( linkedOp_list )?
            	        	int alt53 = 2;
            	        	int LA53_0 = input.LA(1);

            	        	if ( (LA53_0 == ANY_KW || LA53_0 == B_STRING || (LA53_0 >= BIT_KW && LA53_0 <= BOOLEAN_KW) || (LA53_0 >= C_STRING && LA53_0 <= CHARACTER_KW) || LA53_0 == CHOICE_KW || LA53_0 == EMBEDDED_KW || (LA53_0 >= ENUMERATED_KW && LA53_0 <= ERROR_KW) || (LA53_0 >= EXTERNAL_KW && LA53_0 <= FALSE_KW) || (LA53_0 >= GENERAL_STR_KW && LA53_0 <= H_STRING) || LA53_0 == IA5_STRING_KW || LA53_0 == INTEGER_KW || (LA53_0 >= ISO646_STR_KW && LA53_0 <= L_BRACKET) || LA53_0 == LOWER || (LA53_0 >= MINUS && LA53_0 <= NUMERIC_STR_KW) || (LA53_0 >= OBJECT_KW && LA53_0 <= OCTET_KW) || LA53_0 == OPERATION_KW || LA53_0 == PLUS_INFINITY_KW || LA53_0 == PRINTABLE_STR_KW || LA53_0 == REAL_KW || (LA53_0 >= SEQUENCE_KW && LA53_0 <= SET_KW) || LA53_0 == T61_STR_KW || (LA53_0 >= TELETEX_STR_KW && LA53_0 <= TRUE_KW) || (LA53_0 >= UNIVERSAL_STR_KW && LA53_0 <= VISIBLE_STR_KW) || LA53_0 == 131 || LA53_0 == 137 || (LA53_0 >= 158 && LA53_0 <= 160) || (LA53_0 >= 162 && LA53_0 <= 164) || LA53_0 == 166 || LA53_0 == 179 || LA53_0 == 188 || LA53_0 == 191) )
            	        	{
            	        	    alt53 = 1;
            	        	}
            	        	switch (alt53) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:765:57: linkedOp_list
            	        	        {
            	        	        	PushFollow(FOLLOW_linkedOp_list_in_operation_macro3626);
            	        	        	linkedOp_list220 = linkedOp_list();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, linkedOp_list220.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE221=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_operation_macro3630); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE221_tree = (CommonTree)adaptor.Create(R_BRACE221);
            	        		adaptor.AddChild(root_0, R_BRACE221_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "operation_macro"

    public class error_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "error_macro"
    // Smi.g:775:0: error_macro : ERROR_KW ( PARAMETER_KW (=> LOWER )? type )? ;
    public SmiParser.error_macro_return error_macro() // throws RecognitionException [1]
    {   
        SmiParser.error_macro_return retval = new SmiParser.error_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ERROR_KW222 = null;
        IToken PARAMETER_KW223 = null;
        IToken LOWER224 = null;
        SmiParser.type_return type225 = default(SmiParser.type_return);


        CommonTree ERROR_KW222_tree=null;
        CommonTree PARAMETER_KW223_tree=null;
        CommonTree LOWER224_tree=null;

        try 
    	{
            // Smi.g:775:14: ( ERROR_KW ( PARAMETER_KW (=> LOWER )? type )? )
            // Smi.g:775:14: ERROR_KW ( PARAMETER_KW (=> LOWER )? type )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	ERROR_KW222=(IToken)Match(input,ERROR_KW,FOLLOW_ERROR_KW_in_error_macro3650); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ERROR_KW222_tree = (CommonTree)adaptor.Create(ERROR_KW222);
            		adaptor.AddChild(root_0, ERROR_KW222_tree);
            	}
            	// Smi.g:775:23: ( PARAMETER_KW (=> LOWER )? type )?
            	int alt56 = 2;
            	int LA56_0 = input.LA(1);

            	if ( (LA56_0 == PARAMETER_KW) )
            	{
            	    alt56 = 1;
            	}
            	switch (alt56) 
            	{
            	    case 1 :
            	        // Smi.g:775:25: PARAMETER_KW (=> LOWER )? type
            	        {
            	        	PARAMETER_KW223=(IToken)Match(input,PARAMETER_KW,FOLLOW_PARAMETER_KW_in_error_macro3654); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{PARAMETER_KW223_tree = (CommonTree)adaptor.Create(PARAMETER_KW223);
            	        		adaptor.AddChild(root_0, PARAMETER_KW223_tree);
            	        	}
            	        	// Smi.g:775:38: (=> LOWER )?
            	        	int alt55 = 2;
            	        	alt55 = dfa55.Predict(input);
            	        	switch (alt55) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:775:39: => LOWER
            	        	        {

            	        	        	LOWER224=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_error_macro3663); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{LOWER224_tree = (CommonTree)adaptor.Create(LOWER224);
            	        	        		adaptor.AddChild(root_0, LOWER224_tree);
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	PushFollow(FOLLOW_type_in_error_macro3667);
            	        	type225 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type225.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "error_macro"

    public class macros_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "macros_type"
    // Smi.g:782:0: macros_type : ( operation_macro | error_macro | objecttype_macro | moduleidentity_macro | objectidentity_macro | notificationtype_macro | textualconvention_macro | objectgroup_macro | notificationgroup_macro | modulecompliance_macro | agentcapabilities_macro | traptype_macro );
    public SmiParser.macros_type_return macros_type() // throws RecognitionException [1]
    {   
        SmiParser.macros_type_return retval = new SmiParser.macros_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.operation_macro_return operation_macro226 = default(SmiParser.operation_macro_return);

        SmiParser.error_macro_return error_macro227 = default(SmiParser.error_macro_return);

        SmiParser.objecttype_macro_return objecttype_macro228 = default(SmiParser.objecttype_macro_return);

        SmiParser.moduleidentity_macro_return moduleidentity_macro229 = default(SmiParser.moduleidentity_macro_return);

        SmiParser.objectidentity_macro_return objectidentity_macro230 = default(SmiParser.objectidentity_macro_return);

        SmiParser.notificationtype_macro_return notificationtype_macro231 = default(SmiParser.notificationtype_macro_return);

        SmiParser.textualconvention_macro_return textualconvention_macro232 = default(SmiParser.textualconvention_macro_return);

        SmiParser.objectgroup_macro_return objectgroup_macro233 = default(SmiParser.objectgroup_macro_return);

        SmiParser.notificationgroup_macro_return notificationgroup_macro234 = default(SmiParser.notificationgroup_macro_return);

        SmiParser.modulecompliance_macro_return modulecompliance_macro235 = default(SmiParser.modulecompliance_macro_return);

        SmiParser.agentcapabilities_macro_return agentcapabilities_macro236 = default(SmiParser.agentcapabilities_macro_return);

        SmiParser.traptype_macro_return traptype_macro237 = default(SmiParser.traptype_macro_return);



        try 
    	{
            // Smi.g:782:14: ( operation_macro | error_macro | objecttype_macro | moduleidentity_macro | objectidentity_macro | notificationtype_macro | textualconvention_macro | objectgroup_macro | notificationgroup_macro | modulecompliance_macro | agentcapabilities_macro | traptype_macro )
            int alt57 = 12;
            switch ( input.LA(1) ) 
            {
            case OPERATION_KW:
            	{
                alt57 = 1;
                }
                break;
            case ERROR_KW:
            	{
                alt57 = 2;
                }
                break;
            case 166:
            	{
                alt57 = 3;
                }
                break;
            case 159:
            	{
                alt57 = 4;
                }
                break;
            case 164:
            	{
                alt57 = 5;
                }
                break;
            case 162:
            	{
                alt57 = 6;
                }
                break;
            case 188:
            	{
                alt57 = 7;
                }
                break;
            case 163:
            	{
                alt57 = 8;
                }
                break;
            case 160:
            	{
                alt57 = 9;
                }
                break;
            case 158:
            	{
                alt57 = 10;
                }
                break;
            case 131:
            	{
                alt57 = 11;
                }
                break;
            case 191:
            	{
                alt57 = 12;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d57s0 =
            	        new NoViableAltException("", 57, 0, input);

            	    throw nvae_d57s0;
            }

            switch (alt57) 
            {
                case 1 :
                    // Smi.g:782:14: operation_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_operation_macro_in_macros_type3685);
                    	operation_macro226 = operation_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operation_macro226.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:782:32: error_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_error_macro_in_macros_type3689);
                    	error_macro227 = error_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, error_macro227.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:782:46: objecttype_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objecttype_macro_in_macros_type3693);
                    	objecttype_macro228 = objecttype_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro228.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:782:65: moduleidentity_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moduleidentity_macro_in_macros_type3697);
                    	moduleidentity_macro229 = moduleidentity_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro229.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:783:14: objectidentity_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectidentity_macro_in_macros_type3713);
                    	objectidentity_macro230 = objectidentity_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectidentity_macro230.Tree);

                    }
                    break;
                case 6 :
                    // Smi.g:783:37: notificationtype_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_notificationtype_macro_in_macros_type3717);
                    	notificationtype_macro231 = notificationtype_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationtype_macro231.Tree);

                    }
                    break;
                case 7 :
                    // Smi.g:783:62: textualconvention_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_textualconvention_macro_in_macros_type3721);
                    	textualconvention_macro232 = textualconvention_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro232.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:784:14: objectgroup_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectgroup_macro_in_macros_type3737);
                    	objectgroup_macro233 = objectgroup_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectgroup_macro233.Tree);

                    }
                    break;
                case 9 :
                    // Smi.g:784:34: notificationgroup_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_notificationgroup_macro_in_macros_type3741);
                    	notificationgroup_macro234 = notificationgroup_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationgroup_macro234.Tree);

                    }
                    break;
                case 10 :
                    // Smi.g:784:60: modulecompliance_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_modulecompliance_macro_in_macros_type3745);
                    	modulecompliance_macro235 = modulecompliance_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro235.Tree);

                    }
                    break;
                case 11 :
                    // Smi.g:785:14: agentcapabilities_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_agentcapabilities_macro_in_macros_type3761);
                    	agentcapabilities_macro236 = agentcapabilities_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro236.Tree);

                    }
                    break;
                case 12 :
                    // Smi.g:785:40: traptype_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_traptype_macro_in_macros_type3765);
                    	traptype_macro237 = traptype_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, traptype_macro237.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "macros_type"

    public class smi_macros_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "smi_macros"
    // Smi.g:787:0: smi_macros : ( 'OBJECT-TYPE' | 'MODULE-IDENTITY' | 'OBJECT-IDENTITY' | 'NOTIFICATION-TYPE' | 'TEXTUAL-CONVENTION' | 'OBJECT-GROUP' | 'NOTIFICATION-GROUP' | 'MODULE-COMPLIANCE' | 'AGENT-CAPABILITIES' | 'TRAP-TYPE' );
    public SmiParser.smi_macros_return smi_macros() // throws RecognitionException [1]
    {   
        SmiParser.smi_macros_return retval = new SmiParser.smi_macros_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set238 = null;

        CommonTree set238_tree=null;

        try 
    	{
            // Smi.g:787:13: ( 'OBJECT-TYPE' | 'MODULE-IDENTITY' | 'OBJECT-IDENTITY' | 'NOTIFICATION-TYPE' | 'TEXTUAL-CONVENTION' | 'OBJECT-GROUP' | 'NOTIFICATION-GROUP' | 'MODULE-COMPLIANCE' | 'AGENT-CAPABILITIES' | 'TRAP-TYPE' )
            // Smi.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set238 = (IToken)input.LT(1);
            	if ( input.LA(1) == 131 || (input.LA(1) >= 158 && input.LA(1) <= 160) || (input.LA(1) >= 162 && input.LA(1) <= 164) || input.LA(1) == 166 || input.LA(1) == 188 || input.LA(1) == 191 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set238));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "smi_macros"

    public class smi_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "smi_type"
    // Smi.g:793:0: smi_type : ( 'BITS' | INTEGER_KW | OCTET_KW STRING_KW | OBJECT_KW IDENTIFIER_KW | UPPER );
    public SmiParser.smi_type_return smi_type() // throws RecognitionException [1]
    {   
        SmiParser.smi_type_return retval = new SmiParser.smi_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal239 = null;
        IToken INTEGER_KW240 = null;
        IToken OCTET_KW241 = null;
        IToken STRING_KW242 = null;
        IToken OBJECT_KW243 = null;
        IToken IDENTIFIER_KW244 = null;
        IToken UPPER245 = null;

        CommonTree string_literal239_tree=null;
        CommonTree INTEGER_KW240_tree=null;
        CommonTree OCTET_KW241_tree=null;
        CommonTree STRING_KW242_tree=null;
        CommonTree OBJECT_KW243_tree=null;
        CommonTree IDENTIFIER_KW244_tree=null;
        CommonTree UPPER245_tree=null;

        try 
    	{
            // Smi.g:793:11: ( 'BITS' | INTEGER_KW | OCTET_KW STRING_KW | OBJECT_KW IDENTIFIER_KW | UPPER )
            int alt58 = 5;
            switch ( input.LA(1) ) 
            {
            case 137:
            	{
                alt58 = 1;
                }
                break;
            case INTEGER_KW:
            	{
                alt58 = 2;
                }
                break;
            case OCTET_KW:
            	{
                alt58 = 3;
                }
                break;
            case OBJECT_KW:
            	{
                alt58 = 4;
                }
                break;
            case UPPER:
            	{
                alt58 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d58s0 =
            	        new NoViableAltException("", 58, 0, input);

            	    throw nvae_d58s0;
            }

            switch (alt58) 
            {
                case 1 :
                    // Smi.g:793:11: 'BITS'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal239=(IToken)Match(input,137,FOLLOW_137_in_smi_type3839); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal239_tree = (CommonTree)adaptor.Create(string_literal239);
                    		adaptor.AddChild(root_0, string_literal239_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:793:20: INTEGER_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INTEGER_KW240=(IToken)Match(input,INTEGER_KW,FOLLOW_INTEGER_KW_in_smi_type3843); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INTEGER_KW240_tree = (CommonTree)adaptor.Create(INTEGER_KW240);
                    		adaptor.AddChild(root_0, INTEGER_KW240_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:793:33: OCTET_KW STRING_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	OCTET_KW241=(IToken)Match(input,OCTET_KW,FOLLOW_OCTET_KW_in_smi_type3847); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OCTET_KW241_tree = (CommonTree)adaptor.Create(OCTET_KW241);
                    		adaptor.AddChild(root_0, OCTET_KW241_tree);
                    	}
                    	STRING_KW242=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_smi_type3849); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING_KW242_tree = (CommonTree)adaptor.Create(STRING_KW242);
                    		adaptor.AddChild(root_0, STRING_KW242_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Smi.g:793:54: OBJECT_KW IDENTIFIER_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	OBJECT_KW243=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_smi_type3853); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OBJECT_KW243_tree = (CommonTree)adaptor.Create(OBJECT_KW243);
                    		adaptor.AddChild(root_0, OBJECT_KW243_tree);
                    	}
                    	IDENTIFIER_KW244=(IToken)Match(input,IDENTIFIER_KW,FOLLOW_IDENTIFIER_KW_in_smi_type3855); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENTIFIER_KW244_tree = (CommonTree)adaptor.Create(IDENTIFIER_KW244);
                    		adaptor.AddChild(root_0, IDENTIFIER_KW244_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Smi.g:793:80: UPPER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	UPPER245=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_smi_type3859); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UPPER245_tree = (CommonTree)adaptor.Create(UPPER245);
                    		adaptor.AddChild(root_0, UPPER245_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "smi_type"

    public class smi_subtyping_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "smi_subtyping"
    // Smi.g:799:0: smi_subtyping : ( L_PAREN subtype_range ( BAR subtype_range )* R_PAREN | L_PAREN 'SIZE' L_PAREN subtype_range ( BAR subtype_range )* R_PAREN R_PAREN );
    public SmiParser.smi_subtyping_return smi_subtyping() // throws RecognitionException [1]
    {   
        SmiParser.smi_subtyping_return retval = new SmiParser.smi_subtyping_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_PAREN246 = null;
        IToken BAR248 = null;
        IToken R_PAREN250 = null;
        IToken L_PAREN251 = null;
        IToken string_literal252 = null;
        IToken L_PAREN253 = null;
        IToken BAR255 = null;
        IToken R_PAREN257 = null;
        IToken R_PAREN258 = null;
        SmiParser.subtype_range_return subtype_range247 = default(SmiParser.subtype_range_return);

        SmiParser.subtype_range_return subtype_range249 = default(SmiParser.subtype_range_return);

        SmiParser.subtype_range_return subtype_range254 = default(SmiParser.subtype_range_return);

        SmiParser.subtype_range_return subtype_range256 = default(SmiParser.subtype_range_return);


        CommonTree L_PAREN246_tree=null;
        CommonTree BAR248_tree=null;
        CommonTree R_PAREN250_tree=null;
        CommonTree L_PAREN251_tree=null;
        CommonTree string_literal252_tree=null;
        CommonTree L_PAREN253_tree=null;
        CommonTree BAR255_tree=null;
        CommonTree R_PAREN257_tree=null;
        CommonTree R_PAREN258_tree=null;

        try 
    	{
            // Smi.g:799:16: ( L_PAREN subtype_range ( BAR subtype_range )* R_PAREN | L_PAREN 'SIZE' L_PAREN subtype_range ( BAR subtype_range )* R_PAREN R_PAREN )
            int alt61 = 2;
            int LA61_0 = input.LA(1);

            if ( (LA61_0 == L_PAREN) )
            {
                int LA61_1 = input.LA(2);

                if ( (LA61_1 == SIZE_KW) )
                {
                    alt61 = 2;
                }
                else if ( (LA61_1 == B_STRING || LA61_1 == H_STRING || LA61_1 == MINUS || LA61_1 == NUMBER) )
                {
                    alt61 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d61s1 =
                        new NoViableAltException("", 61, 1, input);

                    throw nvae_d61s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d61s0 =
                    new NoViableAltException("", 61, 0, input);

                throw nvae_d61s0;
            }
            switch (alt61) 
            {
                case 1 :
                    // Smi.g:799:16: L_PAREN subtype_range ( BAR subtype_range )* R_PAREN
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_PAREN246=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_smi_subtyping3873); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN246_tree = (CommonTree)adaptor.Create(L_PAREN246);
                    		adaptor.AddChild(root_0, L_PAREN246_tree);
                    	}
                    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3875);
                    	subtype_range247 = subtype_range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range247.Tree);
                    	// Smi.g:799:38: ( BAR subtype_range )*
                    	do 
                    	{
                    	    int alt59 = 2;
                    	    int LA59_0 = input.LA(1);

                    	    if ( (LA59_0 == BAR) )
                    	    {
                    	        alt59 = 1;
                    	    }


                    	    switch (alt59) 
                    		{
                    			case 1 :
                    			    // Smi.g:799:39: BAR subtype_range
                    			    {
                    			    	BAR248=(IToken)Match(input,BAR,FOLLOW_BAR_in_smi_subtyping3878); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{BAR248_tree = (CommonTree)adaptor.Create(BAR248);
                    			    		adaptor.AddChild(root_0, BAR248_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3880);
                    			    	subtype_range249 = subtype_range();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range249.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop59;
                    	    }
                    	} while (true);

                    	loop59:
                    		;	// Stops C# compiler whining that label 'loop59' has no statements

                    	R_PAREN250=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_smi_subtyping3884); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN250_tree = (CommonTree)adaptor.Create(R_PAREN250);
                    		adaptor.AddChild(root_0, R_PAREN250_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:800:16: L_PAREN 'SIZE' L_PAREN subtype_range ( BAR subtype_range )* R_PAREN R_PAREN
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_PAREN251=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_smi_subtyping3901); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN251_tree = (CommonTree)adaptor.Create(L_PAREN251);
                    		adaptor.AddChild(root_0, L_PAREN251_tree);
                    	}
                    	string_literal252=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_smi_subtyping3903); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal252_tree = (CommonTree)adaptor.Create(string_literal252);
                    		adaptor.AddChild(root_0, string_literal252_tree);
                    	}
                    	L_PAREN253=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_smi_subtyping3905); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN253_tree = (CommonTree)adaptor.Create(L_PAREN253);
                    		adaptor.AddChild(root_0, L_PAREN253_tree);
                    	}
                    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3907);
                    	subtype_range254 = subtype_range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range254.Tree);
                    	// Smi.g:800:53: ( BAR subtype_range )*
                    	do 
                    	{
                    	    int alt60 = 2;
                    	    int LA60_0 = input.LA(1);

                    	    if ( (LA60_0 == BAR) )
                    	    {
                    	        alt60 = 1;
                    	    }


                    	    switch (alt60) 
                    		{
                    			case 1 :
                    			    // Smi.g:800:54: BAR subtype_range
                    			    {
                    			    	BAR255=(IToken)Match(input,BAR,FOLLOW_BAR_in_smi_subtyping3910); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{BAR255_tree = (CommonTree)adaptor.Create(BAR255);
                    			    		adaptor.AddChild(root_0, BAR255_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3912);
                    			    	subtype_range256 = subtype_range();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range256.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop60;
                    	    }
                    	} while (true);

                    	loop60:
                    		;	// Stops C# compiler whining that label 'loop60' has no statements

                    	R_PAREN257=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_smi_subtyping3916); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN257_tree = (CommonTree)adaptor.Create(R_PAREN257);
                    		adaptor.AddChild(root_0, R_PAREN257_tree);
                    	}
                    	R_PAREN258=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_smi_subtyping3918); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN258_tree = (CommonTree)adaptor.Create(R_PAREN258);
                    		adaptor.AddChild(root_0, R_PAREN258_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "smi_subtyping"

    public class subtype_range_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "subtype_range"
    // Smi.g:801:0: subtype_range : subtype_value ( DOTDOT subtype_value )? ;
    public SmiParser.subtype_range_return subtype_range() // throws RecognitionException [1]
    {   
        SmiParser.subtype_range_return retval = new SmiParser.subtype_range_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DOTDOT260 = null;
        SmiParser.subtype_value_return subtype_value259 = default(SmiParser.subtype_value_return);

        SmiParser.subtype_value_return subtype_value261 = default(SmiParser.subtype_value_return);


        CommonTree DOTDOT260_tree=null;

        try 
    	{
            // Smi.g:801:16: ( subtype_value ( DOTDOT subtype_value )? )
            // Smi.g:801:16: subtype_value ( DOTDOT subtype_value )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_subtype_value_in_subtype_range3924);
            	subtype_value259 = subtype_value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_value259.Tree);
            	// Smi.g:801:30: ( DOTDOT subtype_value )?
            	int alt62 = 2;
            	int LA62_0 = input.LA(1);

            	if ( (LA62_0 == DOTDOT) )
            	{
            	    alt62 = 1;
            	}
            	switch (alt62) 
            	{
            	    case 1 :
            	        // Smi.g:801:31: DOTDOT subtype_value
            	        {
            	        	DOTDOT260=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_subtype_range3927); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOTDOT260_tree = (CommonTree)adaptor.Create(DOTDOT260);
            	        		adaptor.AddChild(root_0, DOTDOT260_tree);
            	        	}
            	        	PushFollow(FOLLOW_subtype_value_in_subtype_range3929);
            	        	subtype_value261 = subtype_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_value261.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "subtype_range"

    public class subtype_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "subtype_value"
    // Smi.g:802:0: subtype_value : ( ( MINUS )? NUMBER | B_STRING | H_STRING );
    public SmiParser.subtype_value_return subtype_value() // throws RecognitionException [1]
    {   
        SmiParser.subtype_value_return retval = new SmiParser.subtype_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS262 = null;
        IToken NUMBER263 = null;
        IToken B_STRING264 = null;
        IToken H_STRING265 = null;

        CommonTree MINUS262_tree=null;
        CommonTree NUMBER263_tree=null;
        CommonTree B_STRING264_tree=null;
        CommonTree H_STRING265_tree=null;

        try 
    	{
            // Smi.g:802:16: ( ( MINUS )? NUMBER | B_STRING | H_STRING )
            int alt64 = 3;
            switch ( input.LA(1) ) 
            {
            case MINUS:
            case NUMBER:
            	{
                alt64 = 1;
                }
                break;
            case B_STRING:
            	{
                alt64 = 2;
                }
                break;
            case H_STRING:
            	{
                alt64 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d64s0 =
            	        new NoViableAltException("", 64, 0, input);

            	    throw nvae_d64s0;
            }

            switch (alt64) 
            {
                case 1 :
                    // Smi.g:802:16: ( MINUS )? NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// Smi.g:802:16: ( MINUS )?
                    	int alt63 = 2;
                    	int LA63_0 = input.LA(1);

                    	if ( (LA63_0 == MINUS) )
                    	{
                    	    alt63 = 1;
                    	}
                    	switch (alt63) 
                    	{
                    	    case 1 :
                    	        // Smi.g:802:17: MINUS
                    	        {
                    	        	MINUS262=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_subtype_value3939); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{MINUS262_tree = (CommonTree)adaptor.Create(MINUS262);
                    	        		adaptor.AddChild(root_0, MINUS262_tree);
                    	        	}

                    	        }
                    	        break;

                    	}

                    	NUMBER263=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_subtype_value3943); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER263_tree = (CommonTree)adaptor.Create(NUMBER263);
                    		adaptor.AddChild(root_0, NUMBER263_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:802:34: B_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	B_STRING264=(IToken)Match(input,B_STRING,FOLLOW_B_STRING_in_subtype_value3947); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{B_STRING264_tree = (CommonTree)adaptor.Create(B_STRING264);
                    		adaptor.AddChild(root_0, B_STRING264_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:802:45: H_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	H_STRING265=(IToken)Match(input,H_STRING,FOLLOW_H_STRING_in_subtype_value3951); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{H_STRING265_tree = (CommonTree)adaptor.Create(H_STRING265);
                    		adaptor.AddChild(root_0, H_STRING265_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "subtype_value"

    public class objecttype_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro"
    // Smi.g:805:0: objecttype_macro : 'OBJECT-TYPE' 'SYNTAX' (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type ) ( 'UNITS' C_STRING )? ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )? ( 'PIB-REFERENCES' L_BRACE value R_BRACE )? ( 'PIB-TAG' L_BRACE value R_BRACE )? 'STATUS' objecttype_macro_statustypes (=> 'DESCRIPTION' C_STRING )? ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )? ( 'REFERENCE' C_STRING )? (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )? ( 'INDEX' objecttype_macro_index )? ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )? (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )? ;
    public SmiParser.objecttype_macro_return objecttype_macro() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_return retval = new SmiParser.objecttype_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal266 = null;
        IToken string_literal267 = null;
        IToken string_literal273 = null;
        IToken C_STRING274 = null;
        IToken set275 = null;
        IToken string_literal277 = null;
        IToken string_literal279 = null;
        IToken L_BRACE280 = null;
        IToken R_BRACE282 = null;
        IToken string_literal283 = null;
        IToken L_BRACE284 = null;
        IToken R_BRACE286 = null;
        IToken string_literal287 = null;
        IToken string_literal289 = null;
        IToken C_STRING290 = null;
        IToken string_literal291 = null;
        IToken L_BRACE292 = null;
        IToken COMMA294 = null;
        IToken R_BRACE296 = null;
        IToken string_literal297 = null;
        IToken C_STRING298 = null;
        IToken string_literal299 = null;
        IToken string_literal301 = null;
        IToken string_literal303 = null;
        IToken L_BRACE304 = null;
        IToken R_BRACE306 = null;
        IToken string_literal307 = null;
        IToken L_BRACE308 = null;
        IToken R_BRACE310 = null;
        IToken string_literal311 = null;
        IToken string_literal313 = null;
        IToken L_BRACE314 = null;
        IToken COMMA316 = null;
        IToken R_BRACE318 = null;
        IToken string_literal319 = null;
        IToken L_BRACE320 = null;
        IToken R_BRACE323 = null;
        SmiParser.smi_type_return smi_type268 = default(SmiParser.smi_type_return);

        SmiParser.objecttype_macro_namedbits_return objecttype_macro_namedbits269 = default(SmiParser.objecttype_macro_namedbits_return);

        SmiParser.smi_type_return smi_type270 = default(SmiParser.smi_type_return);

        SmiParser.smi_subtyping_return smi_subtyping271 = default(SmiParser.smi_subtyping_return);

        SmiParser.type_return type272 = default(SmiParser.type_return);

        SmiParser.objecttype_macro_accesstypes_return objecttype_macro_accesstypes276 = default(SmiParser.objecttype_macro_accesstypes_return);

        SmiParser.objecttype_macro_pibaccess_return objecttype_macro_pibaccess278 = default(SmiParser.objecttype_macro_pibaccess_return);

        SmiParser.value_return value281 = default(SmiParser.value_return);

        SmiParser.value_return value285 = default(SmiParser.value_return);

        SmiParser.objecttype_macro_statustypes_return objecttype_macro_statustypes288 = default(SmiParser.objecttype_macro_statustypes_return);

        SmiParser.objecttype_macro_error_return objecttype_macro_error293 = default(SmiParser.objecttype_macro_error_return);

        SmiParser.objecttype_macro_error_return objecttype_macro_error295 = default(SmiParser.objecttype_macro_error_return);

        SmiParser.objecttype_macro_index_return objecttype_macro_index300 = default(SmiParser.objecttype_macro_index_return);

        SmiParser.objecttype_macro_augments_return objecttype_macro_augments302 = default(SmiParser.objecttype_macro_augments_return);

        SmiParser.value_return value305 = default(SmiParser.value_return);

        SmiParser.value_return value309 = default(SmiParser.value_return);

        SmiParser.objecttype_macro_index_return objecttype_macro_index312 = default(SmiParser.objecttype_macro_index_return);

        SmiParser.value_return value315 = default(SmiParser.value_return);

        SmiParser.value_return value317 = default(SmiParser.value_return);

        SmiParser.objecttype_macro_bitsvalue_return objecttype_macro_bitsvalue321 = default(SmiParser.objecttype_macro_bitsvalue_return);

        SmiParser.value_return value322 = default(SmiParser.value_return);


        CommonTree string_literal266_tree=null;
        CommonTree string_literal267_tree=null;
        CommonTree string_literal273_tree=null;
        CommonTree C_STRING274_tree=null;
        CommonTree set275_tree=null;
        CommonTree string_literal277_tree=null;
        CommonTree string_literal279_tree=null;
        CommonTree L_BRACE280_tree=null;
        CommonTree R_BRACE282_tree=null;
        CommonTree string_literal283_tree=null;
        CommonTree L_BRACE284_tree=null;
        CommonTree R_BRACE286_tree=null;
        CommonTree string_literal287_tree=null;
        CommonTree string_literal289_tree=null;
        CommonTree C_STRING290_tree=null;
        CommonTree string_literal291_tree=null;
        CommonTree L_BRACE292_tree=null;
        CommonTree COMMA294_tree=null;
        CommonTree R_BRACE296_tree=null;
        CommonTree string_literal297_tree=null;
        CommonTree C_STRING298_tree=null;
        CommonTree string_literal299_tree=null;
        CommonTree string_literal301_tree=null;
        CommonTree string_literal303_tree=null;
        CommonTree L_BRACE304_tree=null;
        CommonTree R_BRACE306_tree=null;
        CommonTree string_literal307_tree=null;
        CommonTree L_BRACE308_tree=null;
        CommonTree R_BRACE310_tree=null;
        CommonTree string_literal311_tree=null;
        CommonTree string_literal313_tree=null;
        CommonTree L_BRACE314_tree=null;
        CommonTree COMMA316_tree=null;
        CommonTree R_BRACE318_tree=null;
        CommonTree string_literal319_tree=null;
        CommonTree L_BRACE320_tree=null;
        CommonTree R_BRACE323_tree=null;

        try 
    	{
            // Smi.g:805:19: ( 'OBJECT-TYPE' 'SYNTAX' (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type ) ( 'UNITS' C_STRING )? ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )? ( 'PIB-REFERENCES' L_BRACE value R_BRACE )? ( 'PIB-TAG' L_BRACE value R_BRACE )? 'STATUS' objecttype_macro_statustypes (=> 'DESCRIPTION' C_STRING )? ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )? ( 'REFERENCE' C_STRING )? (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )? ( 'INDEX' objecttype_macro_index )? ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )? (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )? )
            // Smi.g:805:19: 'OBJECT-TYPE' 'SYNTAX' (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type ) ( 'UNITS' C_STRING )? ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )? ( 'PIB-REFERENCES' L_BRACE value R_BRACE )? ( 'PIB-TAG' L_BRACE value R_BRACE )? 'STATUS' objecttype_macro_statustypes (=> 'DESCRIPTION' C_STRING )? ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )? ( 'REFERENCE' C_STRING )? (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )? ( 'INDEX' objecttype_macro_index )? ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )? (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal266=(IToken)Match(input,166,FOLLOW_166_in_objecttype_macro3960); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal266_tree = (CommonTree)adaptor.Create(string_literal266);
            		adaptor.AddChild(root_0, string_literal266_tree);
            	}
            	string_literal267=(IToken)Match(input,187,FOLLOW_187_in_objecttype_macro3962); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal267_tree = (CommonTree)adaptor.Create(string_literal267);
            		adaptor.AddChild(root_0, string_literal267_tree);
            	}
            	// Smi.g:806:21: (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type )
            	int alt66 = 3;
            	alt66 = dfa66.Predict(input);
            	switch (alt66) 
            	{
            	    case 1 :
            	        // Smi.g:806:23: => smi_type objecttype_macro_namedbits
            	        {

            	        	PushFollow(FOLLOW_smi_type_in_objecttype_macro3995);
            	        	smi_type268 = smi_type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type268.Tree);
            	        	PushFollow(FOLLOW_objecttype_macro_namedbits_in_objecttype_macro3997);
            	        	objecttype_macro_namedbits269 = objecttype_macro_namedbits();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_namedbits269.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:807:24: => smi_type ( smi_subtyping )?
            	        {

            	        	PushFollow(FOLLOW_smi_type_in_objecttype_macro4029);
            	        	smi_type270 = smi_type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type270.Tree);
            	        	// Smi.g:807:47: ( smi_subtyping )?
            	        	int alt65 = 2;
            	        	int LA65_0 = input.LA(1);

            	        	if ( (LA65_0 == L_PAREN) )
            	        	{
            	        	    alt65 = 1;
            	        	}
            	        	switch (alt65) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:807:48: smi_subtyping
            	        	        {
            	        	        	PushFollow(FOLLOW_smi_subtyping_in_objecttype_macro4032);
            	        	        	smi_subtyping271 = smi_subtyping();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_subtyping271.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // Smi.g:808:24: type
            	        {
            	        	PushFollow(FOLLOW_type_in_objecttype_macro4059);
            	        	type272 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type272.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:810:19: ( 'UNITS' C_STRING )?
            	int alt67 = 2;
            	int LA67_0 = input.LA(1);

            	if ( (LA67_0 == 194) )
            	{
            	    alt67 = 1;
            	}
            	switch (alt67) 
            	{
            	    case 1 :
            	        // Smi.g:810:20: 'UNITS' C_STRING
            	        {
            	        	string_literal273=(IToken)Match(input,194,FOLLOW_194_in_objecttype_macro4103); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal273_tree = (CommonTree)adaptor.Create(string_literal273);
            	        		adaptor.AddChild(root_0, string_literal273_tree);
            	        	}
            	        	C_STRING274=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objecttype_macro4105); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING274_tree = (CommonTree)adaptor.Create(C_STRING274);
            	        		adaptor.AddChild(root_0, C_STRING274_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:811:19: ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )?
            	int alt68 = 3;
            	int LA68_0 = input.LA(1);

            	if ( (LA68_0 == 130 || LA68_0 == 155) )
            	{
            	    alt68 = 1;
            	}
            	else if ( (LA68_0 == 168) )
            	{
            	    alt68 = 2;
            	}
            	switch (alt68) 
            	{
            	    case 1 :
            	        // Smi.g:811:21: ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes
            	        {
            	        	set275 = (IToken)input.LT(1);
            	        	if ( input.LA(1) == 130 || input.LA(1) == 155 ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set275));
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	PushFollow(FOLLOW_objecttype_macro_accesstypes_in_objecttype_macro4138);
            	        	objecttype_macro_accesstypes276 = objecttype_macro_accesstypes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_accesstypes276.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:812:22: 'PIB-ACCESS' objecttype_macro_pibaccess
            	        {
            	        	string_literal277=(IToken)Match(input,168,FOLLOW_168_in_objecttype_macro4162); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal277_tree = (CommonTree)adaptor.Create(string_literal277);
            	        		adaptor.AddChild(root_0, string_literal277_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_pibaccess_in_objecttype_macro4164);
            	        	objecttype_macro_pibaccess278 = objecttype_macro_pibaccess();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_pibaccess278.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:813:19: ( 'PIB-REFERENCES' L_BRACE value R_BRACE )?
            	int alt69 = 2;
            	int LA69_0 = input.LA(1);

            	if ( (LA69_0 == 172) )
            	{
            	    alt69 = 1;
            	}
            	switch (alt69) 
            	{
            	    case 1 :
            	        // Smi.g:813:20: 'PIB-REFERENCES' L_BRACE value R_BRACE
            	        {
            	        	string_literal279=(IToken)Match(input,172,FOLLOW_172_in_objecttype_macro4202); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal279_tree = (CommonTree)adaptor.Create(string_literal279);
            	        		adaptor.AddChild(root_0, string_literal279_tree);
            	        	}
            	        	L_BRACE280=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4204); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE280_tree = (CommonTree)adaptor.Create(L_BRACE280);
            	        		adaptor.AddChild(root_0, L_BRACE280_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4206);
            	        	value281 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value281.Tree);
            	        	R_BRACE282=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4208); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE282_tree = (CommonTree)adaptor.Create(R_BRACE282);
            	        		adaptor.AddChild(root_0, R_BRACE282_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:814:19: ( 'PIB-TAG' L_BRACE value R_BRACE )?
            	int alt70 = 2;
            	int LA70_0 = input.LA(1);

            	if ( (LA70_0 == 173) )
            	{
            	    alt70 = 1;
            	}
            	switch (alt70) 
            	{
            	    case 1 :
            	        // Smi.g:814:20: 'PIB-TAG' L_BRACE value R_BRACE
            	        {
            	        	string_literal283=(IToken)Match(input,173,FOLLOW_173_in_objecttype_macro4249); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal283_tree = (CommonTree)adaptor.Create(string_literal283);
            	        		adaptor.AddChild(root_0, string_literal283_tree);
            	        	}
            	        	L_BRACE284=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4251); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE284_tree = (CommonTree)adaptor.Create(L_BRACE284);
            	        		adaptor.AddChild(root_0, L_BRACE284_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4253);
            	        	value285 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value285.Tree);
            	        	R_BRACE286=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4255); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE286_tree = (CommonTree)adaptor.Create(R_BRACE286);
            	        		adaptor.AddChild(root_0, R_BRACE286_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal287=(IToken)Match(input,184,FOLLOW_184_in_objecttype_macro4302); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal287_tree = (CommonTree)adaptor.Create(string_literal287);
            		adaptor.AddChild(root_0, string_literal287_tree);
            	}
            	PushFollow(FOLLOW_objecttype_macro_statustypes_in_objecttype_macro4304);
            	objecttype_macro_statustypes288 = objecttype_macro_statustypes();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_statustypes288.Tree);
            	// Smi.g:816:19: (=> 'DESCRIPTION' C_STRING )?
            	int alt71 = 2;
            	int LA71_0 = input.LA(1);

            	if ( (LA71_0 == 141) )
            	{
            	    int LA71_1 = input.LA(2);

            	    if ( (LA71_1 == C_STRING) )
            	    {
            	        int LA71_3 = input.LA(3);

            	        if ( (synpred27_Smi()) )
            	        {
            	            alt71 = 1;
            	        }
            	    }
            	}
            	switch (alt71) 
            	{
            	    case 1 :
            	        // Smi.g:816:21: => 'DESCRIPTION' C_STRING
            	        {

            	        	string_literal289=(IToken)Match(input,141,FOLLOW_141_in_objecttype_macro4333); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal289_tree = (CommonTree)adaptor.Create(string_literal289);
            	        		adaptor.AddChild(root_0, string_literal289_tree);
            	        	}
            	        	C_STRING290=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objecttype_macro4335); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING290_tree = (CommonTree)adaptor.Create(C_STRING290);
            	        		adaptor.AddChild(root_0, C_STRING290_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:817:19: ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )?
            	int alt73 = 2;
            	int LA73_0 = input.LA(1);

            	if ( (LA73_0 == 151) )
            	{
            	    alt73 = 1;
            	}
            	switch (alt73) 
            	{
            	    case 1 :
            	        // Smi.g:817:20: 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE
            	        {
            	        	string_literal291=(IToken)Match(input,151,FOLLOW_151_in_objecttype_macro4391); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal291_tree = (CommonTree)adaptor.Create(string_literal291);
            	        		adaptor.AddChild(root_0, string_literal291_tree);
            	        	}
            	        	L_BRACE292=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4393); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE292_tree = (CommonTree)adaptor.Create(L_BRACE292);
            	        		adaptor.AddChild(root_0, L_BRACE292_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_error_in_objecttype_macro4395);
            	        	objecttype_macro_error293 = objecttype_macro_error();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_error293.Tree);
            	        	// Smi.g:817:68: ( COMMA objecttype_macro_error )*
            	        	do 
            	        	{
            	        	    int alt72 = 2;
            	        	    int LA72_0 = input.LA(1);

            	        	    if ( (LA72_0 == COMMA) )
            	        	    {
            	        	        alt72 = 1;
            	        	    }


            	        	    switch (alt72) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:817:69: COMMA objecttype_macro_error
            	        			    {
            	        			    	COMMA294=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro4398); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA294_tree = (CommonTree)adaptor.Create(COMMA294);
            	        			    		adaptor.AddChild(root_0, COMMA294_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_objecttype_macro_error_in_objecttype_macro4400);
            	        			    	objecttype_macro_error295 = objecttype_macro_error();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_error295.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop72;
            	        	    }
            	        	} while (true);

            	        	loop72:
            	        		;	// Stops C# compiler whining that label 'loop72' has no statements

            	        	R_BRACE296=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4404); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE296_tree = (CommonTree)adaptor.Create(R_BRACE296);
            	        		adaptor.AddChild(root_0, R_BRACE296_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:818:5: ( 'REFERENCE' C_STRING )?
            	int alt74 = 2;
            	int LA74_0 = input.LA(1);

            	if ( (LA74_0 == 177) )
            	{
            	    alt74 = 1;
            	}
            	switch (alt74) 
            	{
            	    case 1 :
            	        // Smi.g:818:7: 'REFERENCE' C_STRING
            	        {
            	        	string_literal297=(IToken)Match(input,177,FOLLOW_177_in_objecttype_macro4419); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal297_tree = (CommonTree)adaptor.Create(string_literal297);
            	        		adaptor.AddChild(root_0, string_literal297_tree);
            	        	}
            	        	C_STRING298=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objecttype_macro4421); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING298_tree = (CommonTree)adaptor.Create(C_STRING298);
            	        		adaptor.AddChild(root_0, C_STRING298_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:819:5: (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )?
            	int alt75 = 5;
            	alt75 = dfa75.Predict(input);
            	switch (alt75) 
            	{
            	    case 1 :
            	        // Smi.g:819:7: => 'INDEX' objecttype_macro_index
            	        {

            	        	string_literal299=(IToken)Match(input,150,FOLLOW_150_in_objecttype_macro4442); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal299_tree = (CommonTree)adaptor.Create(string_literal299);
            	        		adaptor.AddChild(root_0, string_literal299_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_index_in_objecttype_macro4444);
            	        	objecttype_macro_index300 = objecttype_macro_index();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_index300.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:820:23: 'AUGMENTS' objecttype_macro_augments
            	        {
            	        	string_literal301=(IToken)Match(input,135,FOLLOW_135_in_objecttype_macro4469); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal301_tree = (CommonTree)adaptor.Create(string_literal301);
            	        		adaptor.AddChild(root_0, string_literal301_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_augments_in_objecttype_macro4471);
            	        	objecttype_macro_augments302 = objecttype_macro_augments();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_augments302.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // Smi.g:821:23: 'PIB-INDEX' L_BRACE value R_BRACE
            	        {
            	        	string_literal303=(IToken)Match(input,170,FOLLOW_170_in_objecttype_macro4496); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal303_tree = (CommonTree)adaptor.Create(string_literal303);
            	        		adaptor.AddChild(root_0, string_literal303_tree);
            	        	}
            	        	L_BRACE304=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4498); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE304_tree = (CommonTree)adaptor.Create(L_BRACE304);
            	        		adaptor.AddChild(root_0, L_BRACE304_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4500);
            	        	value305 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value305.Tree);
            	        	R_BRACE306=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4502); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE306_tree = (CommonTree)adaptor.Create(R_BRACE306);
            	        		adaptor.AddChild(root_0, R_BRACE306_tree);
            	        	}

            	        }
            	        break;
            	    case 4 :
            	        // Smi.g:822:23: 'EXTENDS' L_BRACE value R_BRACE
            	        {
            	        	string_literal307=(IToken)Match(input,145,FOLLOW_145_in_objecttype_macro4548); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal307_tree = (CommonTree)adaptor.Create(string_literal307);
            	        		adaptor.AddChild(root_0, string_literal307_tree);
            	        	}
            	        	L_BRACE308=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4550); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE308_tree = (CommonTree)adaptor.Create(L_BRACE308);
            	        		adaptor.AddChild(root_0, L_BRACE308_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4552);
            	        	value309 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value309.Tree);
            	        	R_BRACE310=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4554); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE310_tree = (CommonTree)adaptor.Create(R_BRACE310);
            	        		adaptor.AddChild(root_0, R_BRACE310_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:824:19: ( 'INDEX' objecttype_macro_index )?
            	int alt76 = 2;
            	int LA76_0 = input.LA(1);

            	if ( (LA76_0 == 150) )
            	{
            	    alt76 = 1;
            	}
            	switch (alt76) 
            	{
            	    case 1 :
            	        // Smi.g:824:21: 'INDEX' objecttype_macro_index
            	        {
            	        	string_literal311=(IToken)Match(input,150,FOLLOW_150_in_objecttype_macro4622); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal311_tree = (CommonTree)adaptor.Create(string_literal311);
            	        		adaptor.AddChild(root_0, string_literal311_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_index_in_objecttype_macro4624);
            	        	objecttype_macro_index312 = objecttype_macro_index();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_index312.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:825:19: ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )?
            	int alt79 = 2;
            	int LA79_0 = input.LA(1);

            	if ( (LA79_0 == 193) )
            	{
            	    alt79 = 1;
            	}
            	switch (alt79) 
            	{
            	    case 1 :
            	        // Smi.g:825:21: 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE
            	        {
            	        	string_literal313=(IToken)Match(input,193,FOLLOW_193_in_objecttype_macro4673); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal313_tree = (CommonTree)adaptor.Create(string_literal313);
            	        		adaptor.AddChild(root_0, string_literal313_tree);
            	        	}
            	        	L_BRACE314=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4675); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE314_tree = (CommonTree)adaptor.Create(L_BRACE314);
            	        		adaptor.AddChild(root_0, L_BRACE314_tree);
            	        	}
            	        	// Smi.g:825:42: ( value ( COMMA value )* )?
            	        	int alt78 = 2;
            	        	int LA78_0 = input.LA(1);

            	        	if ( (LA78_0 == B_STRING || LA78_0 == C_STRING || LA78_0 == FALSE_KW || LA78_0 == H_STRING || LA78_0 == L_BRACE || LA78_0 == LOWER || (LA78_0 >= MINUS && LA78_0 <= NUMBER) || LA78_0 == PLUS_INFINITY_KW || LA78_0 == TRUE_KW || LA78_0 == UPPER) )
            	        	{
            	        	    alt78 = 1;
            	        	}
            	        	switch (alt78) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:825:43: value ( COMMA value )*
            	        	        {
            	        	        	PushFollow(FOLLOW_value_in_objecttype_macro4678);
            	        	        	value315 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value315.Tree);
            	        	        	// Smi.g:825:49: ( COMMA value )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt77 = 2;
            	        	        	    int LA77_0 = input.LA(1);

            	        	        	    if ( (LA77_0 == COMMA) )
            	        	        	    {
            	        	        	        alt77 = 1;
            	        	        	    }


            	        	        	    switch (alt77) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // Smi.g:825:50: COMMA value
            	        	        			    {
            	        	        			    	COMMA316=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro4681); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{COMMA316_tree = (CommonTree)adaptor.Create(COMMA316);
            	        	        			    		adaptor.AddChild(root_0, COMMA316_tree);
            	        	        			    	}
            	        	        			    	PushFollow(FOLLOW_value_in_objecttype_macro4683);
            	        	        			    	value317 = value();
            	        	        			    	state.followingStackPointer--;
            	        	        			    	if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value317.Tree);

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop77;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop77:
            	        	        		;	// Stops C# compiler whining that label 'loop77' has no statements


            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE318=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4690); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE318_tree = (CommonTree)adaptor.Create(R_BRACE318);
            	        		adaptor.AddChild(root_0, R_BRACE318_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:826:5: (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )?
            	int alt81 = 2;
            	alt81 = dfa81.Predict(input);
            	switch (alt81) 
            	{
            	    case 1 :
            	        // Smi.g:826:7: => 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE
            	        {

            	        	string_literal319=(IToken)Match(input,140,FOLLOW_140_in_objecttype_macro4729); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal319_tree = (CommonTree)adaptor.Create(string_literal319);
            	        		adaptor.AddChild(root_0, string_literal319_tree);
            	        	}
            	        	L_BRACE320=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4731); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE320_tree = (CommonTree)adaptor.Create(L_BRACE320);
            	        		adaptor.AddChild(root_0, L_BRACE320_tree);
            	        	}
            	        	// Smi.g:827:21: (=> objecttype_macro_bitsvalue | value )
            	        	int alt80 = 2;
            	        	alt80 = dfa80.Predict(input);
            	        	switch (alt80) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:827:23: => objecttype_macro_bitsvalue
            	        	        {

            	        	        	PushFollow(FOLLOW_objecttype_macro_bitsvalue_in_objecttype_macro4772);
            	        	        	objecttype_macro_bitsvalue321 = objecttype_macro_bitsvalue();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_bitsvalue321.Tree);

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Smi.g:828:26: value
            	        	        {
            	        	        	PushFollow(FOLLOW_value_in_objecttype_macro4799);
            	        	        	value322 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value322.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE323=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4823); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE323_tree = (CommonTree)adaptor.Create(R_BRACE323);
            	        		adaptor.AddChild(root_0, R_BRACE323_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro"

    public class objecttype_macro_accesstypes_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_accesstypes"
    // Smi.g:830:0: protected objecttype_macro_accesstypes : l= LOWER ;
    public SmiParser.objecttype_macro_accesstypes_return objecttype_macro_accesstypes() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_accesstypes_return retval = new SmiParser.objecttype_macro_accesstypes_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:830:41: (l= LOWER )
            // Smi.g:830:41: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_accesstypes4837); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("read-only") || l.Text == ("read-write") 
            	                                              || l.Text == ("write-only") || l.Text == ("read-create") 
            	                                              || l.Text == ("not-accessible") || l.Text == ("accessible-for-notify"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_accesstypes"

    public class objecttype_macro_pibaccess_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_pibaccess"
    // Smi.g:835:0: protected objecttype_macro_pibaccess : l= LOWER ;
    public SmiParser.objecttype_macro_pibaccess_return objecttype_macro_pibaccess() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_pibaccess_return retval = new SmiParser.objecttype_macro_pibaccess_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:835:39: (l= LOWER )
            // Smi.g:835:39: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_pibaccess4890); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("install") 
            	                                              || l.Text == ("notify") 
            	                                              || l.Text == ("install-notify") 
            	                                              || l.Text == ("report-only"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_pibaccess"

    public class objecttype_macro_statustypes_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_statustypes"
    // Smi.g:841:0: protected objecttype_macro_statustypes : l= LOWER ;
    public SmiParser.objecttype_macro_statustypes_return objecttype_macro_statustypes() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_statustypes_return retval = new SmiParser.objecttype_macro_statustypes_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:841:41: (l= LOWER )
            // Smi.g:841:41: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_statustypes4943); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("mandatory") 
            	                                              || l.Text == ("optional") 
            	                                              || l.Text == ("obsolete") 
            	                                              || l.Text == ("current") 
            	                                              || l.Text == ("deprecated"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_statustypes"

    public class objecttype_macro_index_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_index"
    // Smi.g:850:0: objecttype_macro_index : L_BRACE objecttype_macro_indextype ( COMMA objecttype_macro_indextype )* R_BRACE ;
    public SmiParser.objecttype_macro_index_return objecttype_macro_index() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_index_return retval = new SmiParser.objecttype_macro_index_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE324 = null;
        IToken COMMA326 = null;
        IToken R_BRACE328 = null;
        SmiParser.objecttype_macro_indextype_return objecttype_macro_indextype325 = default(SmiParser.objecttype_macro_indextype_return);

        SmiParser.objecttype_macro_indextype_return objecttype_macro_indextype327 = default(SmiParser.objecttype_macro_indextype_return);


        CommonTree L_BRACE324_tree=null;
        CommonTree COMMA326_tree=null;
        CommonTree R_BRACE328_tree=null;

        try 
    	{
            // Smi.g:850:25: ( L_BRACE objecttype_macro_indextype ( COMMA objecttype_macro_indextype )* R_BRACE )
            // Smi.g:850:25: L_BRACE objecttype_macro_indextype ( COMMA objecttype_macro_indextype )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE324=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_index4993); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE324_tree = (CommonTree)adaptor.Create(L_BRACE324);
            		adaptor.AddChild(root_0, L_BRACE324_tree);
            	}
            	PushFollow(FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index4995);
            	objecttype_macro_indextype325 = objecttype_macro_indextype();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_indextype325.Tree);
            	// Smi.g:850:60: ( COMMA objecttype_macro_indextype )*
            	do 
            	{
            	    int alt82 = 2;
            	    int LA82_0 = input.LA(1);

            	    if ( (LA82_0 == COMMA) )
            	    {
            	        alt82 = 1;
            	    }


            	    switch (alt82) 
            		{
            			case 1 :
            			    // Smi.g:850:61: COMMA objecttype_macro_indextype
            			    {
            			    	COMMA326=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro_index4998); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA326_tree = (CommonTree)adaptor.Create(COMMA326);
            			    		adaptor.AddChild(root_0, COMMA326_tree);
            			    	}
            			    	PushFollow(FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index5000);
            			    	objecttype_macro_indextype327 = objecttype_macro_indextype();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_indextype327.Tree);

            			    }
            			    break;

            			default:
            			    goto loop82;
            	    }
            	} while (true);

            	loop82:
            		;	// Stops C# compiler whining that label 'loop82' has no statements

            	R_BRACE328=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_index5004); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE328_tree = (CommonTree)adaptor.Create(R_BRACE328);
            		adaptor.AddChild(root_0, R_BRACE328_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_index"

    public class objecttype_macro_indextype_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_indextype"
    // Smi.g:851:0: objecttype_macro_indextype : ( 'IMPLIED' )? value ;
    public SmiParser.objecttype_macro_indextype_return objecttype_macro_indextype() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_indextype_return retval = new SmiParser.objecttype_macro_indextype_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal329 = null;
        SmiParser.value_return value330 = default(SmiParser.value_return);


        CommonTree string_literal329_tree=null;

        try 
    	{
            // Smi.g:851:29: ( ( 'IMPLIED' )? value )
            // Smi.g:851:29: ( 'IMPLIED' )? value
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:851:29: ( 'IMPLIED' )?
            	int alt83 = 2;
            	int LA83_0 = input.LA(1);

            	if ( (LA83_0 == IMPLIED_KW) )
            	{
            	    alt83 = 1;
            	}
            	switch (alt83) 
            	{
            	    case 1 :
            	        // Smi.g:851:30: 'IMPLIED'
            	        {
            	        	string_literal329=(IToken)Match(input,IMPLIED_KW,FOLLOW_IMPLIED_KW_in_objecttype_macro_indextype5018); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal329_tree = (CommonTree)adaptor.Create(string_literal329);
            	        		adaptor.AddChild(root_0, string_literal329_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_value_in_objecttype_macro_indextype5022);
            	value330 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value330.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_indextype"

    public class objecttype_macro_augments_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_augments"
    // Smi.g:852:0: objecttype_macro_augments : L_BRACE value R_BRACE ;
    public SmiParser.objecttype_macro_augments_return objecttype_macro_augments() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_augments_return retval = new SmiParser.objecttype_macro_augments_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE331 = null;
        IToken R_BRACE333 = null;
        SmiParser.value_return value332 = default(SmiParser.value_return);


        CommonTree L_BRACE331_tree=null;
        CommonTree R_BRACE333_tree=null;

        try 
    	{
            // Smi.g:852:28: ( L_BRACE value R_BRACE )
            // Smi.g:852:28: L_BRACE value R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE331=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_augments5028); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE331_tree = (CommonTree)adaptor.Create(L_BRACE331);
            		adaptor.AddChild(root_0, L_BRACE331_tree);
            	}
            	PushFollow(FOLLOW_value_in_objecttype_macro_augments5030);
            	value332 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value332.Tree);
            	R_BRACE333=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_augments5032); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE333_tree = (CommonTree)adaptor.Create(R_BRACE333);
            		adaptor.AddChild(root_0, R_BRACE333_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_augments"

    public class objecttype_macro_namedbits_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_namedbits"
    // Smi.g:854:0: objecttype_macro_namedbits : L_BRACE ( LOWER ) L_PAREN NUMBER R_PAREN ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )* R_BRACE ;
    public SmiParser.objecttype_macro_namedbits_return objecttype_macro_namedbits() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_namedbits_return retval = new SmiParser.objecttype_macro_namedbits_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE334 = null;
        IToken LOWER335 = null;
        IToken L_PAREN336 = null;
        IToken NUMBER337 = null;
        IToken R_PAREN338 = null;
        IToken COMMA339 = null;
        IToken LOWER340 = null;
        IToken L_PAREN341 = null;
        IToken NUMBER342 = null;
        IToken R_PAREN343 = null;
        IToken R_BRACE344 = null;

        CommonTree L_BRACE334_tree=null;
        CommonTree LOWER335_tree=null;
        CommonTree L_PAREN336_tree=null;
        CommonTree NUMBER337_tree=null;
        CommonTree R_PAREN338_tree=null;
        CommonTree COMMA339_tree=null;
        CommonTree LOWER340_tree=null;
        CommonTree L_PAREN341_tree=null;
        CommonTree NUMBER342_tree=null;
        CommonTree R_PAREN343_tree=null;
        CommonTree R_BRACE344_tree=null;

        try 
    	{
            // Smi.g:854:29: ( L_BRACE ( LOWER ) L_PAREN NUMBER R_PAREN ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )* R_BRACE )
            // Smi.g:854:29: L_BRACE ( LOWER ) L_PAREN NUMBER R_PAREN ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE334=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_namedbits5042); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE334_tree = (CommonTree)adaptor.Create(L_BRACE334);
            		adaptor.AddChild(root_0, L_BRACE334_tree);
            	}
            	// Smi.g:854:37: ( LOWER )
            	// Smi.g:854:38: LOWER
            	{
            		LOWER335=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_namedbits5045); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{LOWER335_tree = (CommonTree)adaptor.Create(LOWER335);
            			adaptor.AddChild(root_0, LOWER335_tree);
            		}

            	}

            	L_PAREN336=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_objecttype_macro_namedbits5048); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN336_tree = (CommonTree)adaptor.Create(L_PAREN336);
            		adaptor.AddChild(root_0, L_PAREN336_tree);
            	}
            	NUMBER337=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_objecttype_macro_namedbits5050); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER337_tree = (CommonTree)adaptor.Create(NUMBER337);
            		adaptor.AddChild(root_0, NUMBER337_tree);
            	}
            	R_PAREN338=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_objecttype_macro_namedbits5052); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN338_tree = (CommonTree)adaptor.Create(R_PAREN338);
            		adaptor.AddChild(root_0, R_PAREN338_tree);
            	}
            	// Smi.g:854:68: ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )*
            	do 
            	{
            	    int alt84 = 2;
            	    int LA84_0 = input.LA(1);

            	    if ( (LA84_0 == COMMA) )
            	    {
            	        alt84 = 1;
            	    }


            	    switch (alt84) 
            		{
            			case 1 :
            			    // Smi.g:854:69: COMMA ( LOWER ) L_PAREN NUMBER R_PAREN
            			    {
            			    	COMMA339=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro_namedbits5055); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA339_tree = (CommonTree)adaptor.Create(COMMA339);
            			    		adaptor.AddChild(root_0, COMMA339_tree);
            			    	}
            			    	// Smi.g:854:75: ( LOWER )
            			    	// Smi.g:854:76: LOWER
            			    	{
            			    		LOWER340=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_namedbits5058); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{LOWER340_tree = (CommonTree)adaptor.Create(LOWER340);
            			    			adaptor.AddChild(root_0, LOWER340_tree);
            			    		}

            			    	}

            			    	L_PAREN341=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_objecttype_macro_namedbits5061); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{L_PAREN341_tree = (CommonTree)adaptor.Create(L_PAREN341);
            			    		adaptor.AddChild(root_0, L_PAREN341_tree);
            			    	}
            			    	NUMBER342=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_objecttype_macro_namedbits5063); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{NUMBER342_tree = (CommonTree)adaptor.Create(NUMBER342);
            			    		adaptor.AddChild(root_0, NUMBER342_tree);
            			    	}
            			    	R_PAREN343=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_objecttype_macro_namedbits5065); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{R_PAREN343_tree = (CommonTree)adaptor.Create(R_PAREN343);
            			    		adaptor.AddChild(root_0, R_PAREN343_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop84;
            	    }
            	} while (true);

            	loop84:
            		;	// Stops C# compiler whining that label 'loop84' has no statements

            	R_BRACE344=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_namedbits5069); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE344_tree = (CommonTree)adaptor.Create(R_BRACE344);
            		adaptor.AddChild(root_0, R_BRACE344_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_namedbits"

    public class objecttype_macro_bitsvalue_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_bitsvalue"
    // Smi.g:855:0: objecttype_macro_bitsvalue : L_BRACE LOWER ( COMMA LOWER )* R_BRACE ;
    public SmiParser.objecttype_macro_bitsvalue_return objecttype_macro_bitsvalue() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_bitsvalue_return retval = new SmiParser.objecttype_macro_bitsvalue_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE345 = null;
        IToken LOWER346 = null;
        IToken COMMA347 = null;
        IToken LOWER348 = null;
        IToken R_BRACE349 = null;

        CommonTree L_BRACE345_tree=null;
        CommonTree LOWER346_tree=null;
        CommonTree COMMA347_tree=null;
        CommonTree LOWER348_tree=null;
        CommonTree R_BRACE349_tree=null;

        try 
    	{
            // Smi.g:855:29: ( L_BRACE LOWER ( COMMA LOWER )* R_BRACE )
            // Smi.g:855:29: L_BRACE LOWER ( COMMA LOWER )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE345=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_bitsvalue5080); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE345_tree = (CommonTree)adaptor.Create(L_BRACE345);
            		adaptor.AddChild(root_0, L_BRACE345_tree);
            	}
            	LOWER346=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_bitsvalue5082); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER346_tree = (CommonTree)adaptor.Create(LOWER346);
            		adaptor.AddChild(root_0, LOWER346_tree);
            	}
            	// Smi.g:855:43: ( COMMA LOWER )*
            	do 
            	{
            	    int alt85 = 2;
            	    int LA85_0 = input.LA(1);

            	    if ( (LA85_0 == COMMA) )
            	    {
            	        alt85 = 1;
            	    }


            	    switch (alt85) 
            		{
            			case 1 :
            			    // Smi.g:855:44: COMMA LOWER
            			    {
            			    	COMMA347=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro_bitsvalue5085); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA347_tree = (CommonTree)adaptor.Create(COMMA347);
            			    		adaptor.AddChild(root_0, COMMA347_tree);
            			    	}
            			    	LOWER348=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_bitsvalue5087); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LOWER348_tree = (CommonTree)adaptor.Create(LOWER348);
            			    		adaptor.AddChild(root_0, LOWER348_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop85;
            	    }
            	} while (true);

            	loop85:
            		;	// Stops C# compiler whining that label 'loop85' has no statements

            	R_BRACE349=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_bitsvalue5091); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE349_tree = (CommonTree)adaptor.Create(R_BRACE349);
            		adaptor.AddChild(root_0, R_BRACE349_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_bitsvalue"

    public class objecttype_macro_error_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_error"
    // Smi.g:856:0: objecttype_macro_error : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.objecttype_macro_error_return objecttype_macro_error() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_error_return retval = new SmiParser.objecttype_macro_error_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER350 = null;
        IToken L_PAREN351 = null;
        IToken NUMBER352 = null;
        IToken R_PAREN353 = null;

        CommonTree LOWER350_tree=null;
        CommonTree L_PAREN351_tree=null;
        CommonTree NUMBER352_tree=null;
        CommonTree R_PAREN353_tree=null;

        try 
    	{
            // Smi.g:856:25: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:856:25: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER350=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_error5102); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER350_tree = (CommonTree)adaptor.Create(LOWER350);
            		adaptor.AddChild(root_0, LOWER350_tree);
            	}
            	L_PAREN351=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_objecttype_macro_error5104); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN351_tree = (CommonTree)adaptor.Create(L_PAREN351);
            		adaptor.AddChild(root_0, L_PAREN351_tree);
            	}
            	NUMBER352=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_objecttype_macro_error5106); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER352_tree = (CommonTree)adaptor.Create(NUMBER352);
            		adaptor.AddChild(root_0, NUMBER352_tree);
            	}
            	R_PAREN353=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_objecttype_macro_error5108); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN353_tree = (CommonTree)adaptor.Create(R_PAREN353);
            		adaptor.AddChild(root_0, R_PAREN353_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_error"

    public class moduleidentity_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro"
    // Smi.g:859:0: moduleidentity_macro : 'MODULE-IDENTITY' ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )? 'LAST-UPDATED' C_STRING 'ORGANIZATION' C_STRING 'CONTACT-INFO' C_STRING 'DESCRIPTION' C_STRING ( moduleidentity_macro_revision )* ;
    public SmiParser.moduleidentity_macro_return moduleidentity_macro() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_return retval = new SmiParser.moduleidentity_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal354 = null;
        IToken string_literal355 = null;
        IToken L_BRACE356 = null;
        IToken R_BRACE358 = null;
        IToken string_literal359 = null;
        IToken C_STRING360 = null;
        IToken string_literal361 = null;
        IToken C_STRING362 = null;
        IToken string_literal363 = null;
        IToken C_STRING364 = null;
        IToken string_literal365 = null;
        IToken C_STRING366 = null;
        SmiParser.moduleidentity_macro_categories_return moduleidentity_macro_categories357 = default(SmiParser.moduleidentity_macro_categories_return);

        SmiParser.moduleidentity_macro_revision_return moduleidentity_macro_revision367 = default(SmiParser.moduleidentity_macro_revision_return);


        CommonTree string_literal354_tree=null;
        CommonTree string_literal355_tree=null;
        CommonTree L_BRACE356_tree=null;
        CommonTree R_BRACE358_tree=null;
        CommonTree string_literal359_tree=null;
        CommonTree C_STRING360_tree=null;
        CommonTree string_literal361_tree=null;
        CommonTree C_STRING362_tree=null;
        CommonTree string_literal363_tree=null;
        CommonTree C_STRING364_tree=null;
        CommonTree string_literal365_tree=null;
        CommonTree C_STRING366_tree=null;

        try 
    	{
            // Smi.g:859:23: ( 'MODULE-IDENTITY' ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )? 'LAST-UPDATED' C_STRING 'ORGANIZATION' C_STRING 'CONTACT-INFO' C_STRING 'DESCRIPTION' C_STRING ( moduleidentity_macro_revision )* )
            // Smi.g:859:23: 'MODULE-IDENTITY' ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )? 'LAST-UPDATED' C_STRING 'ORGANIZATION' C_STRING 'CONTACT-INFO' C_STRING 'DESCRIPTION' C_STRING ( moduleidentity_macro_revision )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal354=(IToken)Match(input,159,FOLLOW_159_in_moduleidentity_macro5117); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal354_tree = (CommonTree)adaptor.Create(string_literal354);
            		adaptor.AddChild(root_0, string_literal354_tree);
            	}
            	// Smi.g:860:25: ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )?
            	int alt86 = 2;
            	int LA86_0 = input.LA(1);

            	if ( (LA86_0 == 185) )
            	{
            	    alt86 = 1;
            	}
            	switch (alt86) 
            	{
            	    case 1 :
            	        // Smi.g:860:26: 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE
            	        {
            	        	string_literal355=(IToken)Match(input,185,FOLLOW_185_in_moduleidentity_macro5145); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal355_tree = (CommonTree)adaptor.Create(string_literal355);
            	        		adaptor.AddChild(root_0, string_literal355_tree);
            	        	}
            	        	L_BRACE356=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_moduleidentity_macro5147); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE356_tree = (CommonTree)adaptor.Create(L_BRACE356);
            	        		adaptor.AddChild(root_0, L_BRACE356_tree);
            	        	}
            	        	PushFollow(FOLLOW_moduleidentity_macro_categories_in_moduleidentity_macro5149);
            	        	moduleidentity_macro_categories357 = moduleidentity_macro_categories();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_categories357.Tree);
            	        	R_BRACE358=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_moduleidentity_macro5151); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE358_tree = (CommonTree)adaptor.Create(R_BRACE358);
            	        		adaptor.AddChild(root_0, R_BRACE358_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal359=(IToken)Match(input,152,FOLLOW_152_in_moduleidentity_macro5181); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal359_tree = (CommonTree)adaptor.Create(string_literal359);
            		adaptor.AddChild(root_0, string_literal359_tree);
            	}
            	C_STRING360=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5183); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING360_tree = (CommonTree)adaptor.Create(C_STRING360);
            		adaptor.AddChild(root_0, C_STRING360_tree);
            	}
            	string_literal361=(IToken)Match(input,167,FOLLOW_167_in_moduleidentity_macro5185); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal361_tree = (CommonTree)adaptor.Create(string_literal361);
            		adaptor.AddChild(root_0, string_literal361_tree);
            	}
            	C_STRING362=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5187); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING362_tree = (CommonTree)adaptor.Create(C_STRING362);
            		adaptor.AddChild(root_0, C_STRING362_tree);
            	}
            	string_literal363=(IToken)Match(input,138,FOLLOW_138_in_moduleidentity_macro5189); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal363_tree = (CommonTree)adaptor.Create(string_literal363);
            		adaptor.AddChild(root_0, string_literal363_tree);
            	}
            	C_STRING364=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5191); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING364_tree = (CommonTree)adaptor.Create(C_STRING364);
            		adaptor.AddChild(root_0, C_STRING364_tree);
            	}
            	string_literal365=(IToken)Match(input,141,FOLLOW_141_in_moduleidentity_macro5218); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal365_tree = (CommonTree)adaptor.Create(string_literal365);
            		adaptor.AddChild(root_0, string_literal365_tree);
            	}
            	C_STRING366=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5220); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING366_tree = (CommonTree)adaptor.Create(C_STRING366);
            		adaptor.AddChild(root_0, C_STRING366_tree);
            	}
            	// Smi.g:862:48: ( moduleidentity_macro_revision )*
            	do 
            	{
            	    int alt87 = 2;
            	    int LA87_0 = input.LA(1);

            	    if ( (LA87_0 == 180) )
            	    {
            	        alt87 = 1;
            	    }


            	    switch (alt87) 
            		{
            			case 1 :
            			    // Smi.g:862:49: moduleidentity_macro_revision
            			    {
            			    	PushFollow(FOLLOW_moduleidentity_macro_revision_in_moduleidentity_macro5223);
            			    	moduleidentity_macro_revision367 = moduleidentity_macro_revision();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_revision367.Tree);

            			    }
            			    break;

            			default:
            			    goto loop87;
            	    }
            	} while (true);

            	loop87:
            		;	// Stops C# compiler whining that label 'loop87' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro"

    public class moduleidentity_macro_revision_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro_revision"
    // Smi.g:863:0: moduleidentity_macro_revision : 'REVISION' C_STRING 'DESCRIPTION' C_STRING ;
    public SmiParser.moduleidentity_macro_revision_return moduleidentity_macro_revision() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_revision_return retval = new SmiParser.moduleidentity_macro_revision_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal368 = null;
        IToken C_STRING369 = null;
        IToken string_literal370 = null;
        IToken C_STRING371 = null;

        CommonTree string_literal368_tree=null;
        CommonTree C_STRING369_tree=null;
        CommonTree string_literal370_tree=null;
        CommonTree C_STRING371_tree=null;

        try 
    	{
            // Smi.g:863:32: ( 'REVISION' C_STRING 'DESCRIPTION' C_STRING )
            // Smi.g:863:32: 'REVISION' C_STRING 'DESCRIPTION' C_STRING
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal368=(IToken)Match(input,180,FOLLOW_180_in_moduleidentity_macro_revision5232); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal368_tree = (CommonTree)adaptor.Create(string_literal368);
            		adaptor.AddChild(root_0, string_literal368_tree);
            	}
            	C_STRING369=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro_revision5234); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING369_tree = (CommonTree)adaptor.Create(C_STRING369);
            		adaptor.AddChild(root_0, C_STRING369_tree);
            	}
            	string_literal370=(IToken)Match(input,141,FOLLOW_141_in_moduleidentity_macro_revision5236); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal370_tree = (CommonTree)adaptor.Create(string_literal370);
            		adaptor.AddChild(root_0, string_literal370_tree);
            	}
            	C_STRING371=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro_revision5238); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING371_tree = (CommonTree)adaptor.Create(C_STRING371);
            		adaptor.AddChild(root_0, C_STRING371_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro_revision"

    public class moduleidentity_macro_categories_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro_categories"
    // Smi.g:864:0: moduleidentity_macro_categories : (l= LOWER | moduleidentity_macro_categoryid ( COMMA moduleidentity_macro_categoryid )* );
    public SmiParser.moduleidentity_macro_categories_return moduleidentity_macro_categories() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_categories_return retval = new SmiParser.moduleidentity_macro_categories_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;
        IToken COMMA373 = null;
        SmiParser.moduleidentity_macro_categoryid_return moduleidentity_macro_categoryid372 = default(SmiParser.moduleidentity_macro_categoryid_return);

        SmiParser.moduleidentity_macro_categoryid_return moduleidentity_macro_categoryid374 = default(SmiParser.moduleidentity_macro_categoryid_return);


        CommonTree l_tree=null;
        CommonTree COMMA373_tree=null;

        try 
    	{
            // Smi.g:864:34: (l= LOWER | moduleidentity_macro_categoryid ( COMMA moduleidentity_macro_categoryid )* )
            int alt89 = 2;
            int LA89_0 = input.LA(1);

            if ( (LA89_0 == LOWER) )
            {
                int LA89_1 = input.LA(2);

                if ( (LA89_1 == L_PAREN) )
                {
                    alt89 = 2;
                }
                else if ( (LA89_1 == R_BRACE) )
                {
                    alt89 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d89s1 =
                        new NoViableAltException("", 89, 1, input);

                    throw nvae_d89s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d89s0 =
                    new NoViableAltException("", 89, 0, input);

                throw nvae_d89s0;
            }
            switch (alt89) 
            {
                case 1 :
                    // Smi.g:864:34: l= LOWER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_moduleidentity_macro_categories5247); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{l_tree = (CommonTree)adaptor.Create(l);
                    		adaptor.AddChild(root_0, l_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	  if (l.Text !=  ("all")) {throw new SemanticException ("(invalid)");}
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:865:34: moduleidentity_macro_categoryid ( COMMA moduleidentity_macro_categoryid )*
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5285);
                    	moduleidentity_macro_categoryid372 = moduleidentity_macro_categoryid();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_categoryid372.Tree);
                    	// Smi.g:865:66: ( COMMA moduleidentity_macro_categoryid )*
                    	do 
                    	{
                    	    int alt88 = 2;
                    	    int LA88_0 = input.LA(1);

                    	    if ( (LA88_0 == COMMA) )
                    	    {
                    	        alt88 = 1;
                    	    }


                    	    switch (alt88) 
                    		{
                    			case 1 :
                    			    // Smi.g:865:67: COMMA moduleidentity_macro_categoryid
                    			    {
                    			    	COMMA373=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_moduleidentity_macro_categories5288); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{COMMA373_tree = (CommonTree)adaptor.Create(COMMA373);
                    			    		adaptor.AddChild(root_0, COMMA373_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5290);
                    			    	moduleidentity_macro_categoryid374 = moduleidentity_macro_categoryid();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_categoryid374.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop88;
                    	    }
                    	} while (true);

                    	loop88:
                    		;	// Stops C# compiler whining that label 'loop88' has no statements


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro_categories"

    public class moduleidentity_macro_categoryid_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro_categoryid"
    // Smi.g:866:0: moduleidentity_macro_categoryid : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.moduleidentity_macro_categoryid_return moduleidentity_macro_categoryid() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_categoryid_return retval = new SmiParser.moduleidentity_macro_categoryid_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER375 = null;
        IToken L_PAREN376 = null;
        IToken NUMBER377 = null;
        IToken R_PAREN378 = null;

        CommonTree LOWER375_tree=null;
        CommonTree L_PAREN376_tree=null;
        CommonTree NUMBER377_tree=null;
        CommonTree R_PAREN378_tree=null;

        try 
    	{
            // Smi.g:866:34: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:866:34: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER375=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_moduleidentity_macro_categoryid5298); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER375_tree = (CommonTree)adaptor.Create(LOWER375);
            		adaptor.AddChild(root_0, LOWER375_tree);
            	}
            	L_PAREN376=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_moduleidentity_macro_categoryid5300); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN376_tree = (CommonTree)adaptor.Create(L_PAREN376);
            		adaptor.AddChild(root_0, L_PAREN376_tree);
            	}
            	NUMBER377=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_moduleidentity_macro_categoryid5302); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER377_tree = (CommonTree)adaptor.Create(NUMBER377);
            		adaptor.AddChild(root_0, NUMBER377_tree);
            	}
            	R_PAREN378=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_moduleidentity_macro_categoryid5304); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN378_tree = (CommonTree)adaptor.Create(R_PAREN378);
            		adaptor.AddChild(root_0, R_PAREN378_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro_categoryid"

    public class objectidentity_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectidentity_macro"
    // Smi.g:869:0: objectidentity_macro : 'OBJECT-IDENTITY' 'STATUS' objectidentity_macro_statustypes 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.objectidentity_macro_return objectidentity_macro() // throws RecognitionException [1]
    {   
        SmiParser.objectidentity_macro_return retval = new SmiParser.objectidentity_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal379 = null;
        IToken string_literal380 = null;
        IToken string_literal382 = null;
        IToken C_STRING383 = null;
        IToken string_literal384 = null;
        IToken C_STRING385 = null;
        SmiParser.objectidentity_macro_statustypes_return objectidentity_macro_statustypes381 = default(SmiParser.objectidentity_macro_statustypes_return);


        CommonTree string_literal379_tree=null;
        CommonTree string_literal380_tree=null;
        CommonTree string_literal382_tree=null;
        CommonTree C_STRING383_tree=null;
        CommonTree string_literal384_tree=null;
        CommonTree C_STRING385_tree=null;

        try 
    	{
            // Smi.g:869:23: ( 'OBJECT-IDENTITY' 'STATUS' objectidentity_macro_statustypes 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:869:23: 'OBJECT-IDENTITY' 'STATUS' objectidentity_macro_statustypes 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal379=(IToken)Match(input,164,FOLLOW_164_in_objectidentity_macro5314); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal379_tree = (CommonTree)adaptor.Create(string_literal379);
            		adaptor.AddChild(root_0, string_literal379_tree);
            	}
            	string_literal380=(IToken)Match(input,184,FOLLOW_184_in_objectidentity_macro5316); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal380_tree = (CommonTree)adaptor.Create(string_literal380);
            		adaptor.AddChild(root_0, string_literal380_tree);
            	}
            	PushFollow(FOLLOW_objectidentity_macro_statustypes_in_objectidentity_macro5318);
            	objectidentity_macro_statustypes381 = objectidentity_macro_statustypes();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectidentity_macro_statustypes381.Tree);
            	string_literal382=(IToken)Match(input,141,FOLLOW_141_in_objectidentity_macro5320); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal382_tree = (CommonTree)adaptor.Create(string_literal382);
            		adaptor.AddChild(root_0, string_literal382_tree);
            	}
            	C_STRING383=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectidentity_macro5322); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING383_tree = (CommonTree)adaptor.Create(C_STRING383);
            		adaptor.AddChild(root_0, C_STRING383_tree);
            	}
            	// Smi.g:869:106: ( 'REFERENCE' C_STRING )?
            	int alt90 = 2;
            	int LA90_0 = input.LA(1);

            	if ( (LA90_0 == 177) )
            	{
            	    alt90 = 1;
            	}
            	switch (alt90) 
            	{
            	    case 1 :
            	        // Smi.g:869:107: 'REFERENCE' C_STRING
            	        {
            	        	string_literal384=(IToken)Match(input,177,FOLLOW_177_in_objectidentity_macro5325); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal384_tree = (CommonTree)adaptor.Create(string_literal384);
            	        		adaptor.AddChild(root_0, string_literal384_tree);
            	        	}
            	        	C_STRING385=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectidentity_macro5327); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING385_tree = (CommonTree)adaptor.Create(C_STRING385);
            	        		adaptor.AddChild(root_0, C_STRING385_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectidentity_macro"

    public class objectidentity_macro_statustypes_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectidentity_macro_statustypes"
    // Smi.g:870:0: protected objectidentity_macro_statustypes : l= LOWER ;
    public SmiParser.objectidentity_macro_statustypes_return objectidentity_macro_statustypes() // throws RecognitionException [1]
    {   
        SmiParser.objectidentity_macro_statustypes_return retval = new SmiParser.objectidentity_macro_statustypes_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:870:45: (l= LOWER )
            // Smi.g:870:45: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objectidentity_macro_statustypes5340); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectidentity_macro_statustypes"

    public class notificationtype_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notificationtype_macro"
    // Smi.g:878:0: notificationtype_macro : 'NOTIFICATION-TYPE' ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )? 'STATUS' notificationtype_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.notificationtype_macro_return notificationtype_macro() // throws RecognitionException [1]
    {   
        SmiParser.notificationtype_macro_return retval = new SmiParser.notificationtype_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal386 = null;
        IToken string_literal387 = null;
        IToken L_BRACE388 = null;
        IToken COMMA390 = null;
        IToken R_BRACE392 = null;
        IToken string_literal393 = null;
        IToken string_literal395 = null;
        IToken C_STRING396 = null;
        IToken string_literal397 = null;
        IToken C_STRING398 = null;
        SmiParser.value_return value389 = default(SmiParser.value_return);

        SmiParser.value_return value391 = default(SmiParser.value_return);

        SmiParser.notificationtype_macro_status_return notificationtype_macro_status394 = default(SmiParser.notificationtype_macro_status_return);


        CommonTree string_literal386_tree=null;
        CommonTree string_literal387_tree=null;
        CommonTree L_BRACE388_tree=null;
        CommonTree COMMA390_tree=null;
        CommonTree R_BRACE392_tree=null;
        CommonTree string_literal393_tree=null;
        CommonTree string_literal395_tree=null;
        CommonTree C_STRING396_tree=null;
        CommonTree string_literal397_tree=null;
        CommonTree C_STRING398_tree=null;

        try 
    	{
            // Smi.g:878:25: ( 'NOTIFICATION-TYPE' ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )? 'STATUS' notificationtype_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:878:25: 'NOTIFICATION-TYPE' ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )? 'STATUS' notificationtype_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal386=(IToken)Match(input,162,FOLLOW_162_in_notificationtype_macro5393); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal386_tree = (CommonTree)adaptor.Create(string_literal386);
            		adaptor.AddChild(root_0, string_literal386_tree);
            	}
            	// Smi.g:878:45: ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt92 = 2;
            	int LA92_0 = input.LA(1);

            	if ( (LA92_0 == 165) )
            	{
            	    alt92 = 1;
            	}
            	switch (alt92) 
            	{
            	    case 1 :
            	        // Smi.g:878:46: 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal387=(IToken)Match(input,165,FOLLOW_165_in_notificationtype_macro5396); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal387_tree = (CommonTree)adaptor.Create(string_literal387);
            	        		adaptor.AddChild(root_0, string_literal387_tree);
            	        	}
            	        	L_BRACE388=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_notificationtype_macro5398); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE388_tree = (CommonTree)adaptor.Create(L_BRACE388);
            	        		adaptor.AddChild(root_0, L_BRACE388_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_notificationtype_macro5400);
            	        	value389 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value389.Tree);
            	        	// Smi.g:878:70: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt91 = 2;
            	        	    int LA91_0 = input.LA(1);

            	        	    if ( (LA91_0 == COMMA) )
            	        	    {
            	        	        alt91 = 1;
            	        	    }


            	        	    switch (alt91) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:878:71: COMMA value
            	        			    {
            	        			    	COMMA390=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_notificationtype_macro5403); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA390_tree = (CommonTree)adaptor.Create(COMMA390);
            	        			    		adaptor.AddChild(root_0, COMMA390_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_notificationtype_macro5405);
            	        			    	value391 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value391.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop91;
            	        	    }
            	        	} while (true);

            	        	loop91:
            	        		;	// Stops C# compiler whining that label 'loop91' has no statements

            	        	R_BRACE392=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_notificationtype_macro5409); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE392_tree = (CommonTree)adaptor.Create(R_BRACE392);
            	        		adaptor.AddChild(root_0, R_BRACE392_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal393=(IToken)Match(input,184,FOLLOW_184_in_notificationtype_macro5458); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal393_tree = (CommonTree)adaptor.Create(string_literal393);
            		adaptor.AddChild(root_0, string_literal393_tree);
            	}
            	PushFollow(FOLLOW_notificationtype_macro_status_in_notificationtype_macro5460);
            	notificationtype_macro_status394 = notificationtype_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationtype_macro_status394.Tree);
            	string_literal395=(IToken)Match(input,141,FOLLOW_141_in_notificationtype_macro5462); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal395_tree = (CommonTree)adaptor.Create(string_literal395);
            		adaptor.AddChild(root_0, string_literal395_tree);
            	}
            	C_STRING396=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationtype_macro5464); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING396_tree = (CommonTree)adaptor.Create(C_STRING396);
            		adaptor.AddChild(root_0, C_STRING396_tree);
            	}
            	// Smi.g:879:107: ( 'REFERENCE' C_STRING )?
            	int alt93 = 2;
            	int LA93_0 = input.LA(1);

            	if ( (LA93_0 == 177) )
            	{
            	    alt93 = 1;
            	}
            	switch (alt93) 
            	{
            	    case 1 :
            	        // Smi.g:879:108: 'REFERENCE' C_STRING
            	        {
            	        	string_literal397=(IToken)Match(input,177,FOLLOW_177_in_notificationtype_macro5467); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal397_tree = (CommonTree)adaptor.Create(string_literal397);
            	        		adaptor.AddChild(root_0, string_literal397_tree);
            	        	}
            	        	C_STRING398=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationtype_macro5469); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING398_tree = (CommonTree)adaptor.Create(C_STRING398);
            	        		adaptor.AddChild(root_0, C_STRING398_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationtype_macro"

    public class notificationtype_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notificationtype_macro_status"
    // Smi.g:880:0: protected notificationtype_macro_status : l= LOWER ;
    public SmiParser.notificationtype_macro_status_return notificationtype_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.notificationtype_macro_status_return retval = new SmiParser.notificationtype_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:880:42: (l= LOWER )
            // Smi.g:880:42: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_notificationtype_macro_status5482); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationtype_macro_status"

    public class textualconvention_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "textualconvention_macro"
    // Smi.g:887:0: textualconvention_macro : 'TEXTUAL-CONVENTION' ( 'DISPLAY-HINT' C_STRING )? 'STATUS' textualconvention_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? 'SYNTAX' (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type ) ;
    public SmiParser.textualconvention_macro_return textualconvention_macro() // throws RecognitionException [1]
    {   
        SmiParser.textualconvention_macro_return retval = new SmiParser.textualconvention_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal399 = null;
        IToken string_literal400 = null;
        IToken C_STRING401 = null;
        IToken string_literal402 = null;
        IToken string_literal404 = null;
        IToken C_STRING405 = null;
        IToken string_literal406 = null;
        IToken C_STRING407 = null;
        IToken string_literal408 = null;
        IToken L_BRACE410 = null;
        IToken COMMA412 = null;
        IToken R_BRACE414 = null;
        SmiParser.textualconvention_macro_status_return textualconvention_macro_status403 = default(SmiParser.textualconvention_macro_status_return);

        SmiParser.smi_type_return smi_type409 = default(SmiParser.smi_type_return);

        SmiParser.textualconvention_macro_namedbit_return textualconvention_macro_namedbit411 = default(SmiParser.textualconvention_macro_namedbit_return);

        SmiParser.textualconvention_macro_namedbit_return textualconvention_macro_namedbit413 = default(SmiParser.textualconvention_macro_namedbit_return);

        SmiParser.type_return type415 = default(SmiParser.type_return);


        CommonTree string_literal399_tree=null;
        CommonTree string_literal400_tree=null;
        CommonTree C_STRING401_tree=null;
        CommonTree string_literal402_tree=null;
        CommonTree string_literal404_tree=null;
        CommonTree C_STRING405_tree=null;
        CommonTree string_literal406_tree=null;
        CommonTree C_STRING407_tree=null;
        CommonTree string_literal408_tree=null;
        CommonTree L_BRACE410_tree=null;
        CommonTree COMMA412_tree=null;
        CommonTree R_BRACE414_tree=null;

        try 
    	{
            // Smi.g:887:26: ( 'TEXTUAL-CONVENTION' ( 'DISPLAY-HINT' C_STRING )? 'STATUS' textualconvention_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? 'SYNTAX' (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type ) )
            // Smi.g:887:26: 'TEXTUAL-CONVENTION' ( 'DISPLAY-HINT' C_STRING )? 'STATUS' textualconvention_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? 'SYNTAX' (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal399=(IToken)Match(input,188,FOLLOW_188_in_textualconvention_macro5534); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal399_tree = (CommonTree)adaptor.Create(string_literal399);
            		adaptor.AddChild(root_0, string_literal399_tree);
            	}
            	// Smi.g:887:47: ( 'DISPLAY-HINT' C_STRING )?
            	int alt94 = 2;
            	int LA94_0 = input.LA(1);

            	if ( (LA94_0 == 142) )
            	{
            	    alt94 = 1;
            	}
            	switch (alt94) 
            	{
            	    case 1 :
            	        // Smi.g:887:48: 'DISPLAY-HINT' C_STRING
            	        {
            	        	string_literal400=(IToken)Match(input,142,FOLLOW_142_in_textualconvention_macro5537); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal400_tree = (CommonTree)adaptor.Create(string_literal400);
            	        		adaptor.AddChild(root_0, string_literal400_tree);
            	        	}
            	        	C_STRING401=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_textualconvention_macro5539); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING401_tree = (CommonTree)adaptor.Create(C_STRING401);
            	        		adaptor.AddChild(root_0, C_STRING401_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal402=(IToken)Match(input,184,FOLLOW_184_in_textualconvention_macro5572); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal402_tree = (CommonTree)adaptor.Create(string_literal402);
            		adaptor.AddChild(root_0, string_literal402_tree);
            	}
            	PushFollow(FOLLOW_textualconvention_macro_status_in_textualconvention_macro5574);
            	textualconvention_macro_status403 = textualconvention_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro_status403.Tree);
            	string_literal404=(IToken)Match(input,141,FOLLOW_141_in_textualconvention_macro5605); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal404_tree = (CommonTree)adaptor.Create(string_literal404);
            		adaptor.AddChild(root_0, string_literal404_tree);
            	}
            	C_STRING405=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_textualconvention_macro5607); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING405_tree = (CommonTree)adaptor.Create(C_STRING405);
            		adaptor.AddChild(root_0, C_STRING405_tree);
            	}
            	// Smi.g:890:29: ( 'REFERENCE' C_STRING )?
            	int alt95 = 2;
            	int LA95_0 = input.LA(1);

            	if ( (LA95_0 == 177) )
            	{
            	    alt95 = 1;
            	}
            	switch (alt95) 
            	{
            	    case 1 :
            	        // Smi.g:890:30: 'REFERENCE' C_STRING
            	        {
            	        	string_literal406=(IToken)Match(input,177,FOLLOW_177_in_textualconvention_macro5639); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal406_tree = (CommonTree)adaptor.Create(string_literal406);
            	        		adaptor.AddChild(root_0, string_literal406_tree);
            	        	}
            	        	C_STRING407=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_textualconvention_macro5641); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING407_tree = (CommonTree)adaptor.Create(C_STRING407);
            	        		adaptor.AddChild(root_0, C_STRING407_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal408=(IToken)Match(input,187,FOLLOW_187_in_textualconvention_macro5674); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal408_tree = (CommonTree)adaptor.Create(string_literal408);
            		adaptor.AddChild(root_0, string_literal408_tree);
            	}
            	// Smi.g:891:38: (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type )
            	int alt97 = 2;
            	alt97 = dfa97.Predict(input);
            	switch (alt97) 
            	{
            	    case 1 :
            	        // Smi.g:891:40: => smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE
            	        {

            	        	PushFollow(FOLLOW_smi_type_in_textualconvention_macro5686);
            	        	smi_type409 = smi_type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type409.Tree);
            	        	L_BRACE410=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_textualconvention_macro5688); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE410_tree = (CommonTree)adaptor.Create(L_BRACE410);
            	        		adaptor.AddChild(root_0, L_BRACE410_tree);
            	        	}
            	        	PushFollow(FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5690);
            	        	textualconvention_macro_namedbit411 = textualconvention_macro_namedbit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro_namedbit411.Tree);
            	        	// Smi.g:892:37: ( COMMA textualconvention_macro_namedbit )*
            	        	do 
            	        	{
            	        	    int alt96 = 2;
            	        	    int LA96_0 = input.LA(1);

            	        	    if ( (LA96_0 == COMMA) )
            	        	    {
            	        	        alt96 = 1;
            	        	    }


            	        	    switch (alt96) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:892:38: COMMA textualconvention_macro_namedbit
            	        			    {
            	        			    	COMMA412=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_textualconvention_macro5730); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA412_tree = (CommonTree)adaptor.Create(COMMA412);
            	        			    		adaptor.AddChild(root_0, COMMA412_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5732);
            	        			    	textualconvention_macro_namedbit413 = textualconvention_macro_namedbit();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro_namedbit413.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop96;
            	        	    }
            	        	} while (true);

            	        	loop96:
            	        		;	// Stops C# compiler whining that label 'loop96' has no statements

            	        	R_BRACE414=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_textualconvention_macro5736); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE414_tree = (CommonTree)adaptor.Create(R_BRACE414);
            	        		adaptor.AddChild(root_0, R_BRACE414_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:892:89: type
            	        {
            	        	PushFollow(FOLLOW_type_in_textualconvention_macro5740);
            	        	type415 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type415.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "textualconvention_macro"

    public class textualconvention_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "textualconvention_macro_status"
    // Smi.g:893:0: fragment textualconvention_macro_status : l= LOWER ;
    public SmiParser.textualconvention_macro_status_return textualconvention_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.textualconvention_macro_status_return retval = new SmiParser.textualconvention_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:893:42: (l= LOWER )
            // Smi.g:893:42: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_textualconvention_macro_status5751); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "textualconvention_macro_status"

    public class textualconvention_macro_namedbit_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "textualconvention_macro_namedbit"
    // Smi.g:898:0: textualconvention_macro_namedbit : LOWER L_PAREN ( MINUS )? NUMBER R_PAREN ;
    public SmiParser.textualconvention_macro_namedbit_return textualconvention_macro_namedbit() // throws RecognitionException [1]
    {   
        SmiParser.textualconvention_macro_namedbit_return retval = new SmiParser.textualconvention_macro_namedbit_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER416 = null;
        IToken L_PAREN417 = null;
        IToken MINUS418 = null;
        IToken NUMBER419 = null;
        IToken R_PAREN420 = null;

        CommonTree LOWER416_tree=null;
        CommonTree L_PAREN417_tree=null;
        CommonTree MINUS418_tree=null;
        CommonTree NUMBER419_tree=null;
        CommonTree R_PAREN420_tree=null;

        try 
    	{
            // Smi.g:898:35: ( LOWER L_PAREN ( MINUS )? NUMBER R_PAREN )
            // Smi.g:898:35: LOWER L_PAREN ( MINUS )? NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER416=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_textualconvention_macro_namedbit5800); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER416_tree = (CommonTree)adaptor.Create(LOWER416);
            		adaptor.AddChild(root_0, LOWER416_tree);
            	}
            	L_PAREN417=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_textualconvention_macro_namedbit5802); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN417_tree = (CommonTree)adaptor.Create(L_PAREN417);
            		adaptor.AddChild(root_0, L_PAREN417_tree);
            	}
            	// Smi.g:898:49: ( MINUS )?
            	int alt98 = 2;
            	int LA98_0 = input.LA(1);

            	if ( (LA98_0 == MINUS) )
            	{
            	    alt98 = 1;
            	}
            	switch (alt98) 
            	{
            	    case 1 :
            	        // Smi.g:898:50: MINUS
            	        {
            	        	MINUS418=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_textualconvention_macro_namedbit5805); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MINUS418_tree = (CommonTree)adaptor.Create(MINUS418);
            	        		adaptor.AddChild(root_0, MINUS418_tree);
            	        	}

            	        }
            	        break;

            	}

            	NUMBER419=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_textualconvention_macro_namedbit5809); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER419_tree = (CommonTree)adaptor.Create(NUMBER419);
            		adaptor.AddChild(root_0, NUMBER419_tree);
            	}
            	R_PAREN420=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_textualconvention_macro_namedbit5811); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN420_tree = (CommonTree)adaptor.Create(R_PAREN420);
            		adaptor.AddChild(root_0, R_PAREN420_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "textualconvention_macro_namedbit"

    public class objectgroup_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectgroup_macro"
    // Smi.g:901:0: objectgroup_macro : 'OBJECT-GROUP' 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' objectgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.objectgroup_macro_return objectgroup_macro() // throws RecognitionException [1]
    {   
        SmiParser.objectgroup_macro_return retval = new SmiParser.objectgroup_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal421 = null;
        IToken string_literal422 = null;
        IToken L_BRACE423 = null;
        IToken COMMA425 = null;
        IToken R_BRACE427 = null;
        IToken string_literal428 = null;
        IToken string_literal430 = null;
        IToken C_STRING431 = null;
        IToken string_literal432 = null;
        IToken C_STRING433 = null;
        SmiParser.value_return value424 = default(SmiParser.value_return);

        SmiParser.value_return value426 = default(SmiParser.value_return);

        SmiParser.objectgroup_macro_status_return objectgroup_macro_status429 = default(SmiParser.objectgroup_macro_status_return);


        CommonTree string_literal421_tree=null;
        CommonTree string_literal422_tree=null;
        CommonTree L_BRACE423_tree=null;
        CommonTree COMMA425_tree=null;
        CommonTree R_BRACE427_tree=null;
        CommonTree string_literal428_tree=null;
        CommonTree string_literal430_tree=null;
        CommonTree C_STRING431_tree=null;
        CommonTree string_literal432_tree=null;
        CommonTree C_STRING433_tree=null;

        try 
    	{
            // Smi.g:901:20: ( 'OBJECT-GROUP' 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' objectgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:901:20: 'OBJECT-GROUP' 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' objectgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal421=(IToken)Match(input,163,FOLLOW_163_in_objectgroup_macro5820); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal421_tree = (CommonTree)adaptor.Create(string_literal421);
            		adaptor.AddChild(root_0, string_literal421_tree);
            	}
            	string_literal422=(IToken)Match(input,165,FOLLOW_165_in_objectgroup_macro5822); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal422_tree = (CommonTree)adaptor.Create(string_literal422);
            		adaptor.AddChild(root_0, string_literal422_tree);
            	}
            	L_BRACE423=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objectgroup_macro5824); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE423_tree = (CommonTree)adaptor.Create(L_BRACE423);
            		adaptor.AddChild(root_0, L_BRACE423_tree);
            	}
            	PushFollow(FOLLOW_value_in_objectgroup_macro5826);
            	value424 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value424.Tree);
            	// Smi.g:901:59: ( COMMA value )*
            	do 
            	{
            	    int alt99 = 2;
            	    int LA99_0 = input.LA(1);

            	    if ( (LA99_0 == COMMA) )
            	    {
            	        alt99 = 1;
            	    }


            	    switch (alt99) 
            		{
            			case 1 :
            			    // Smi.g:901:60: COMMA value
            			    {
            			    	COMMA425=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objectgroup_macro5829); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA425_tree = (CommonTree)adaptor.Create(COMMA425);
            			    		adaptor.AddChild(root_0, COMMA425_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_objectgroup_macro5831);
            			    	value426 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value426.Tree);

            			    }
            			    break;

            			default:
            			    goto loop99;
            	    }
            	} while (true);

            	loop99:
            		;	// Stops C# compiler whining that label 'loop99' has no statements

            	R_BRACE427=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objectgroup_macro5835); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE427_tree = (CommonTree)adaptor.Create(R_BRACE427);
            		adaptor.AddChild(root_0, R_BRACE427_tree);
            	}
            	string_literal428=(IToken)Match(input,184,FOLLOW_184_in_objectgroup_macro5862); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal428_tree = (CommonTree)adaptor.Create(string_literal428);
            		adaptor.AddChild(root_0, string_literal428_tree);
            	}
            	PushFollow(FOLLOW_objectgroup_macro_status_in_objectgroup_macro5864);
            	objectgroup_macro_status429 = objectgroup_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectgroup_macro_status429.Tree);
            	string_literal430=(IToken)Match(input,141,FOLLOW_141_in_objectgroup_macro5866); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal430_tree = (CommonTree)adaptor.Create(string_literal430);
            		adaptor.AddChild(root_0, string_literal430_tree);
            	}
            	C_STRING431=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectgroup_macro5868); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING431_tree = (CommonTree)adaptor.Create(C_STRING431);
            		adaptor.AddChild(root_0, C_STRING431_tree);
            	}
            	// Smi.g:902:82: ( 'REFERENCE' C_STRING )?
            	int alt100 = 2;
            	int LA100_0 = input.LA(1);

            	if ( (LA100_0 == 177) )
            	{
            	    alt100 = 1;
            	}
            	switch (alt100) 
            	{
            	    case 1 :
            	        // Smi.g:902:83: 'REFERENCE' C_STRING
            	        {
            	        	string_literal432=(IToken)Match(input,177,FOLLOW_177_in_objectgroup_macro5871); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal432_tree = (CommonTree)adaptor.Create(string_literal432);
            	        		adaptor.AddChild(root_0, string_literal432_tree);
            	        	}
            	        	C_STRING433=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectgroup_macro5873); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING433_tree = (CommonTree)adaptor.Create(C_STRING433);
            	        		adaptor.AddChild(root_0, C_STRING433_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectgroup_macro"

    public class objectgroup_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectgroup_macro_status"
    // Smi.g:903:0: objectgroup_macro_status : l= LOWER ;
    public SmiParser.objectgroup_macro_status_return objectgroup_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.objectgroup_macro_status_return retval = new SmiParser.objectgroup_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:903:27: (l= LOWER )
            // Smi.g:903:27: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objectgroup_macro_status5884); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectgroup_macro_status"

    public class notificationgroup_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notificationgroup_macro"
    // Smi.g:910:0: notificationgroup_macro : 'NOTIFICATION-GROUP' 'NOTIFICATIONS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' notificationgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.notificationgroup_macro_return notificationgroup_macro() // throws RecognitionException [1]
    {   
        SmiParser.notificationgroup_macro_return retval = new SmiParser.notificationgroup_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal434 = null;
        IToken string_literal435 = null;
        IToken L_BRACE436 = null;
        IToken COMMA438 = null;
        IToken R_BRACE440 = null;
        IToken string_literal441 = null;
        IToken string_literal443 = null;
        IToken C_STRING444 = null;
        IToken string_literal445 = null;
        IToken C_STRING446 = null;
        SmiParser.value_return value437 = default(SmiParser.value_return);

        SmiParser.value_return value439 = default(SmiParser.value_return);

        SmiParser.notificationgroup_macro_status_return notificationgroup_macro_status442 = default(SmiParser.notificationgroup_macro_status_return);


        CommonTree string_literal434_tree=null;
        CommonTree string_literal435_tree=null;
        CommonTree L_BRACE436_tree=null;
        CommonTree COMMA438_tree=null;
        CommonTree R_BRACE440_tree=null;
        CommonTree string_literal441_tree=null;
        CommonTree string_literal443_tree=null;
        CommonTree C_STRING444_tree=null;
        CommonTree string_literal445_tree=null;
        CommonTree C_STRING446_tree=null;

        try 
    	{
            // Smi.g:910:26: ( 'NOTIFICATION-GROUP' 'NOTIFICATIONS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' notificationgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:910:26: 'NOTIFICATION-GROUP' 'NOTIFICATIONS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' notificationgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal434=(IToken)Match(input,160,FOLLOW_160_in_notificationgroup_macro5936); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal434_tree = (CommonTree)adaptor.Create(string_literal434);
            		adaptor.AddChild(root_0, string_literal434_tree);
            	}
            	string_literal435=(IToken)Match(input,161,FOLLOW_161_in_notificationgroup_macro5938); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal435_tree = (CommonTree)adaptor.Create(string_literal435);
            		adaptor.AddChild(root_0, string_literal435_tree);
            	}
            	L_BRACE436=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_notificationgroup_macro5940); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE436_tree = (CommonTree)adaptor.Create(L_BRACE436);
            		adaptor.AddChild(root_0, L_BRACE436_tree);
            	}
            	PushFollow(FOLLOW_value_in_notificationgroup_macro5942);
            	value437 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value437.Tree);
            	// Smi.g:910:77: ( COMMA value )*
            	do 
            	{
            	    int alt101 = 2;
            	    int LA101_0 = input.LA(1);

            	    if ( (LA101_0 == COMMA) )
            	    {
            	        alt101 = 1;
            	    }


            	    switch (alt101) 
            		{
            			case 1 :
            			    // Smi.g:910:78: COMMA value
            			    {
            			    	COMMA438=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_notificationgroup_macro5945); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA438_tree = (CommonTree)adaptor.Create(COMMA438);
            			    		adaptor.AddChild(root_0, COMMA438_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_notificationgroup_macro5947);
            			    	value439 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value439.Tree);

            			    }
            			    break;

            			default:
            			    goto loop101;
            	    }
            	} while (true);

            	loop101:
            		;	// Stops C# compiler whining that label 'loop101' has no statements

            	R_BRACE440=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_notificationgroup_macro5951); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE440_tree = (CommonTree)adaptor.Create(R_BRACE440);
            		adaptor.AddChild(root_0, R_BRACE440_tree);
            	}
            	string_literal441=(IToken)Match(input,184,FOLLOW_184_in_notificationgroup_macro5978); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal441_tree = (CommonTree)adaptor.Create(string_literal441);
            		adaptor.AddChild(root_0, string_literal441_tree);
            	}
            	PushFollow(FOLLOW_notificationgroup_macro_status_in_notificationgroup_macro5980);
            	notificationgroup_macro_status442 = notificationgroup_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationgroup_macro_status442.Tree);
            	string_literal443=(IToken)Match(input,141,FOLLOW_141_in_notificationgroup_macro5982); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal443_tree = (CommonTree)adaptor.Create(string_literal443);
            		adaptor.AddChild(root_0, string_literal443_tree);
            	}
            	C_STRING444=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationgroup_macro5984); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING444_tree = (CommonTree)adaptor.Create(C_STRING444);
            		adaptor.AddChild(root_0, C_STRING444_tree);
            	}
            	// Smi.g:911:88: ( 'REFERENCE' C_STRING )?
            	int alt102 = 2;
            	int LA102_0 = input.LA(1);

            	if ( (LA102_0 == 177) )
            	{
            	    alt102 = 1;
            	}
            	switch (alt102) 
            	{
            	    case 1 :
            	        // Smi.g:911:89: 'REFERENCE' C_STRING
            	        {
            	        	string_literal445=(IToken)Match(input,177,FOLLOW_177_in_notificationgroup_macro5987); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal445_tree = (CommonTree)adaptor.Create(string_literal445);
            	        		adaptor.AddChild(root_0, string_literal445_tree);
            	        	}
            	        	C_STRING446=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationgroup_macro5989); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING446_tree = (CommonTree)adaptor.Create(C_STRING446);
            	        		adaptor.AddChild(root_0, C_STRING446_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationgroup_macro"

    public class notificationgroup_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notificationgroup_macro_status"
    // Smi.g:912:0: notificationgroup_macro_status : l= LOWER ;
    public SmiParser.notificationgroup_macro_status_return notificationgroup_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.notificationgroup_macro_status_return retval = new SmiParser.notificationgroup_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:912:33: (l= LOWER )
            // Smi.g:912:33: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_notificationgroup_macro_status6000); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationgroup_macro_status"

    public class modulecompliance_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro"
    // Smi.g:919:0: modulecompliance_macro : 'MODULE-COMPLIANCE' 'STATUS' modulecompliance_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( modulecompliance_macro_module )+ ;
    public SmiParser.modulecompliance_macro_return modulecompliance_macro() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_return retval = new SmiParser.modulecompliance_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal447 = null;
        IToken string_literal448 = null;
        IToken string_literal450 = null;
        IToken C_STRING451 = null;
        IToken string_literal452 = null;
        IToken C_STRING453 = null;
        SmiParser.modulecompliance_macro_status_return modulecompliance_macro_status449 = default(SmiParser.modulecompliance_macro_status_return);

        SmiParser.modulecompliance_macro_module_return modulecompliance_macro_module454 = default(SmiParser.modulecompliance_macro_module_return);


        CommonTree string_literal447_tree=null;
        CommonTree string_literal448_tree=null;
        CommonTree string_literal450_tree=null;
        CommonTree C_STRING451_tree=null;
        CommonTree string_literal452_tree=null;
        CommonTree C_STRING453_tree=null;

        try 
    	{
            // Smi.g:919:25: ( 'MODULE-COMPLIANCE' 'STATUS' modulecompliance_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( modulecompliance_macro_module )+ )
            // Smi.g:919:25: 'MODULE-COMPLIANCE' 'STATUS' modulecompliance_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( modulecompliance_macro_module )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal447=(IToken)Match(input,158,FOLLOW_158_in_modulecompliance_macro6052); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal447_tree = (CommonTree)adaptor.Create(string_literal447);
            		adaptor.AddChild(root_0, string_literal447_tree);
            	}
            	string_literal448=(IToken)Match(input,184,FOLLOW_184_in_modulecompliance_macro6054); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal448_tree = (CommonTree)adaptor.Create(string_literal448);
            		adaptor.AddChild(root_0, string_literal448_tree);
            	}
            	PushFollow(FOLLOW_modulecompliance_macro_status_in_modulecompliance_macro6056);
            	modulecompliance_macro_status449 = modulecompliance_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_status449.Tree);
            	string_literal450=(IToken)Match(input,141,FOLLOW_141_in_modulecompliance_macro6082); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal450_tree = (CommonTree)adaptor.Create(string_literal450);
            		adaptor.AddChild(root_0, string_literal450_tree);
            	}
            	C_STRING451=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro6084); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING451_tree = (CommonTree)adaptor.Create(C_STRING451);
            		adaptor.AddChild(root_0, C_STRING451_tree);
            	}
            	// Smi.g:920:48: ( 'REFERENCE' C_STRING )?
            	int alt103 = 2;
            	int LA103_0 = input.LA(1);

            	if ( (LA103_0 == 177) )
            	{
            	    alt103 = 1;
            	}
            	switch (alt103) 
            	{
            	    case 1 :
            	        // Smi.g:920:49: 'REFERENCE' C_STRING
            	        {
            	        	string_literal452=(IToken)Match(input,177,FOLLOW_177_in_modulecompliance_macro6087); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal452_tree = (CommonTree)adaptor.Create(string_literal452);
            	        		adaptor.AddChild(root_0, string_literal452_tree);
            	        	}
            	        	C_STRING453=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro6089); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING453_tree = (CommonTree)adaptor.Create(C_STRING453);
            	        		adaptor.AddChild(root_0, C_STRING453_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:920:72: ( modulecompliance_macro_module )+
            	int cnt104 = 0;
            	do 
            	{
            	    int alt104 = 2;
            	    int LA104_0 = input.LA(1);

            	    if ( (LA104_0 == 157) )
            	    {
            	        alt104 = 1;
            	    }


            	    switch (alt104) 
            		{
            			case 1 :
            			    // Smi.g:920:73: modulecompliance_macro_module
            			    {
            			    	PushFollow(FOLLOW_modulecompliance_macro_module_in_modulecompliance_macro6094);
            			    	modulecompliance_macro_module454 = modulecompliance_macro_module();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_module454.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt104 >= 1 ) goto loop104;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee104 =
            		                new EarlyExitException(104, input);
            		            throw eee104;
            	    }
            	    cnt104++;
            	} while (true);

            	loop104:
            		;	// Stops C# compiler whining that label 'loop104' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro"

    public class modulecompliance_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_status"
    // Smi.g:921:0: modulecompliance_macro_status : l= LOWER ;
    public SmiParser.modulecompliance_macro_status_return modulecompliance_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_status_return retval = new SmiParser.modulecompliance_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:921:32: (l= LOWER )
            // Smi.g:921:32: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_status6105); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_status"

    public class modulecompliance_macro_module_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_module"
    // Smi.g:926:0: modulecompliance_macro_module : 'MODULE' (=> UPPER (=> value )? )? ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )? ( modulecompliance_macro_compliance )* ;
    public SmiParser.modulecompliance_macro_module_return modulecompliance_macro_module() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_module_return retval = new SmiParser.modulecompliance_macro_module_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal455 = null;
        IToken UPPER456 = null;
        IToken string_literal458 = null;
        IToken L_BRACE459 = null;
        IToken COMMA461 = null;
        IToken R_BRACE463 = null;
        SmiParser.value_return value457 = default(SmiParser.value_return);

        SmiParser.value_return value460 = default(SmiParser.value_return);

        SmiParser.value_return value462 = default(SmiParser.value_return);

        SmiParser.modulecompliance_macro_compliance_return modulecompliance_macro_compliance464 = default(SmiParser.modulecompliance_macro_compliance_return);


        CommonTree string_literal455_tree=null;
        CommonTree UPPER456_tree=null;
        CommonTree string_literal458_tree=null;
        CommonTree L_BRACE459_tree=null;
        CommonTree COMMA461_tree=null;
        CommonTree R_BRACE463_tree=null;

        try 
    	{
            // Smi.g:926:32: ( 'MODULE' (=> UPPER (=> value )? )? ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )? ( modulecompliance_macro_compliance )* )
            // Smi.g:926:32: 'MODULE' (=> UPPER (=> value )? )? ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )? ( modulecompliance_macro_compliance )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal455=(IToken)Match(input,157,FOLLOW_157_in_modulecompliance_macro_module6153); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal455_tree = (CommonTree)adaptor.Create(string_literal455);
            		adaptor.AddChild(root_0, string_literal455_tree);
            	}
            	// Smi.g:926:41: (=> UPPER (=> value )? )?
            	int alt106 = 2;
            	alt106 = dfa106.Predict(input);
            	switch (alt106) 
            	{
            	    case 1 :
            	        // Smi.g:926:42: => UPPER (=> value )?
            	        {

            	        	UPPER456=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_modulecompliance_macro_module6162); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UPPER456_tree = (CommonTree)adaptor.Create(UPPER456);
            	        		adaptor.AddChild(root_0, UPPER456_tree);
            	        	}
            	        	// Smi.g:926:59: (=> value )?
            	        	int alt105 = 2;
            	        	alt105 = dfa105.Predict(input);
            	        	switch (alt105) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:926:60: => value
            	        	        {

            	        	        	PushFollow(FOLLOW_value_in_modulecompliance_macro_module6171);
            	        	        	value457 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value457.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// Smi.g:927:33: ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt108 = 2;
            	int LA108_0 = input.LA(1);

            	if ( (LA108_0 == 154) )
            	{
            	    alt108 = 1;
            	}
            	switch (alt108) 
            	{
            	    case 1 :
            	        // Smi.g:927:34: 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal458=(IToken)Match(input,154,FOLLOW_154_in_modulecompliance_macro_module6212); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal458_tree = (CommonTree)adaptor.Create(string_literal458);
            	        		adaptor.AddChild(root_0, string_literal458_tree);
            	        	}
            	        	L_BRACE459=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_modulecompliance_macro_module6214); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE459_tree = (CommonTree)adaptor.Create(L_BRACE459);
            	        		adaptor.AddChild(root_0, L_BRACE459_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_modulecompliance_macro_module6216);
            	        	value460 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value460.Tree);
            	        	// Smi.g:927:67: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt107 = 2;
            	        	    int LA107_0 = input.LA(1);

            	        	    if ( (LA107_0 == COMMA) )
            	        	    {
            	        	        alt107 = 1;
            	        	    }


            	        	    switch (alt107) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:927:68: COMMA value
            	        			    {
            	        			    	COMMA461=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_modulecompliance_macro_module6219); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA461_tree = (CommonTree)adaptor.Create(COMMA461);
            	        			    		adaptor.AddChild(root_0, COMMA461_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_modulecompliance_macro_module6221);
            	        			    	value462 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value462.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop107;
            	        	    }
            	        	} while (true);

            	        	loop107:
            	        		;	// Stops C# compiler whining that label 'loop107' has no statements

            	        	R_BRACE463=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_modulecompliance_macro_module6225); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE463_tree = (CommonTree)adaptor.Create(R_BRACE463);
            	        		adaptor.AddChild(root_0, R_BRACE463_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:928:33: ( modulecompliance_macro_compliance )*
            	do 
            	{
            	    int alt109 = 2;
            	    int LA109_0 = input.LA(1);

            	    if ( (LA109_0 == OBJECT_KW) )
            	    {
            	        int LA109_2 = input.LA(2);

            	        if ( (LA109_2 == B_STRING || LA109_2 == C_STRING || LA109_2 == FALSE_KW || LA109_2 == H_STRING || LA109_2 == L_BRACE || LA109_2 == LOWER || (LA109_2 >= MINUS && LA109_2 <= NUMBER) || LA109_2 == PLUS_INFINITY_KW || LA109_2 == TRUE_KW || LA109_2 == UPPER) )
            	        {
            	            alt109 = 1;
            	        }


            	    }
            	    else if ( (LA109_0 == 149) )
            	    {
            	        alt109 = 1;
            	    }


            	    switch (alt109) 
            		{
            			case 1 :
            			    // Smi.g:928:34: modulecompliance_macro_compliance
            			    {
            			    	PushFollow(FOLLOW_modulecompliance_macro_compliance_in_modulecompliance_macro_module6262);
            			    	modulecompliance_macro_compliance464 = modulecompliance_macro_compliance();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_compliance464.Tree);

            			    }
            			    break;

            			default:
            			    goto loop109;
            	    }
            	} while (true);

            	loop109:
            		;	// Stops C# compiler whining that label 'loop109' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_module"

    public class modulecompliance_macro_compliance_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_compliance"
    // Smi.g:929:0: modulecompliance_macro_compliance : ( 'GROUP' value 'DESCRIPTION' C_STRING | 'OBJECT' value ( 'SYNTAX' modulecompliance_macro_syntax )? ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )? ( 'MIN-ACCESS' modulecompliance_macro_access )? ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )? 'DESCRIPTION' C_STRING );
    public SmiParser.modulecompliance_macro_compliance_return modulecompliance_macro_compliance() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_compliance_return retval = new SmiParser.modulecompliance_macro_compliance_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal465 = null;
        IToken string_literal467 = null;
        IToken C_STRING468 = null;
        IToken string_literal469 = null;
        IToken string_literal471 = null;
        IToken string_literal473 = null;
        IToken string_literal475 = null;
        IToken string_literal477 = null;
        IToken string_literal479 = null;
        IToken C_STRING480 = null;
        SmiParser.value_return value466 = default(SmiParser.value_return);

        SmiParser.value_return value470 = default(SmiParser.value_return);

        SmiParser.modulecompliance_macro_syntax_return modulecompliance_macro_syntax472 = default(SmiParser.modulecompliance_macro_syntax_return);

        SmiParser.modulecompliance_macro_syntax_return modulecompliance_macro_syntax474 = default(SmiParser.modulecompliance_macro_syntax_return);

        SmiParser.modulecompliance_macro_access_return modulecompliance_macro_access476 = default(SmiParser.modulecompliance_macro_access_return);

        SmiParser.modulecompliance_macro_pibaccess_return modulecompliance_macro_pibaccess478 = default(SmiParser.modulecompliance_macro_pibaccess_return);


        CommonTree string_literal465_tree=null;
        CommonTree string_literal467_tree=null;
        CommonTree C_STRING468_tree=null;
        CommonTree string_literal469_tree=null;
        CommonTree string_literal471_tree=null;
        CommonTree string_literal473_tree=null;
        CommonTree string_literal475_tree=null;
        CommonTree string_literal477_tree=null;
        CommonTree string_literal479_tree=null;
        CommonTree C_STRING480_tree=null;

        try 
    	{
            // Smi.g:929:36: ( 'GROUP' value 'DESCRIPTION' C_STRING | 'OBJECT' value ( 'SYNTAX' modulecompliance_macro_syntax )? ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )? ( 'MIN-ACCESS' modulecompliance_macro_access )? ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )? 'DESCRIPTION' C_STRING )
            int alt114 = 2;
            int LA114_0 = input.LA(1);

            if ( (LA114_0 == 149) )
            {
                alt114 = 1;
            }
            else if ( (LA114_0 == OBJECT_KW) )
            {
                alt114 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d114s0 =
                    new NoViableAltException("", 114, 0, input);

                throw nvae_d114s0;
            }
            switch (alt114) 
            {
                case 1 :
                    // Smi.g:929:36: 'GROUP' value 'DESCRIPTION' C_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal465=(IToken)Match(input,149,FOLLOW_149_in_modulecompliance_macro_compliance6271); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal465_tree = (CommonTree)adaptor.Create(string_literal465);
                    		adaptor.AddChild(root_0, string_literal465_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_modulecompliance_macro_compliance6273);
                    	value466 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value466.Tree);
                    	string_literal467=(IToken)Match(input,141,FOLLOW_141_in_modulecompliance_macro_compliance6275); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal467_tree = (CommonTree)adaptor.Create(string_literal467);
                    		adaptor.AddChild(root_0, string_literal467_tree);
                    	}
                    	C_STRING468=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro_compliance6277); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING468_tree = (CommonTree)adaptor.Create(C_STRING468);
                    		adaptor.AddChild(root_0, C_STRING468_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:930:36: 'OBJECT' value ( 'SYNTAX' modulecompliance_macro_syntax )? ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )? ( 'MIN-ACCESS' modulecompliance_macro_access )? ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )? 'DESCRIPTION' C_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal469=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_modulecompliance_macro_compliance6314); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal469_tree = (CommonTree)adaptor.Create(string_literal469);
                    		adaptor.AddChild(root_0, string_literal469_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_modulecompliance_macro_compliance6316);
                    	value470 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value470.Tree);
                    	// Smi.g:931:37: ( 'SYNTAX' modulecompliance_macro_syntax )?
                    	int alt110 = 2;
                    	int LA110_0 = input.LA(1);

                    	if ( (LA110_0 == 187) )
                    	{
                    	    alt110 = 1;
                    	}
                    	switch (alt110) 
                    	{
                    	    case 1 :
                    	        // Smi.g:931:38: 'SYNTAX' modulecompliance_macro_syntax
                    	        {
                    	        	string_literal471=(IToken)Match(input,187,FOLLOW_187_in_modulecompliance_macro_compliance6356); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal471_tree = (CommonTree)adaptor.Create(string_literal471);
                    	        		adaptor.AddChild(root_0, string_literal471_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6358);
                    	        	modulecompliance_macro_syntax472 = modulecompliance_macro_syntax();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_syntax472.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:932:37: ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )?
                    	int alt111 = 2;
                    	int LA111_0 = input.LA(1);

                    	if ( (LA111_0 == 197) )
                    	{
                    	    alt111 = 1;
                    	}
                    	switch (alt111) 
                    	{
                    	    case 1 :
                    	        // Smi.g:932:38: 'WRITE-SYNTAX' modulecompliance_macro_syntax
                    	        {
                    	        	string_literal473=(IToken)Match(input,197,FOLLOW_197_in_modulecompliance_macro_compliance6400); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal473_tree = (CommonTree)adaptor.Create(string_literal473);
                    	        		adaptor.AddChild(root_0, string_literal473_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6402);
                    	        	modulecompliance_macro_syntax474 = modulecompliance_macro_syntax();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_syntax474.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:933:37: ( 'MIN-ACCESS' modulecompliance_macro_access )?
                    	int alt112 = 2;
                    	int LA112_0 = input.LA(1);

                    	if ( (LA112_0 == 156) )
                    	{
                    	    alt112 = 1;
                    	}
                    	switch (alt112) 
                    	{
                    	    case 1 :
                    	        // Smi.g:933:38: 'MIN-ACCESS' modulecompliance_macro_access
                    	        {
                    	        	string_literal475=(IToken)Match(input,156,FOLLOW_156_in_modulecompliance_macro_compliance6449); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal475_tree = (CommonTree)adaptor.Create(string_literal475);
                    	        		adaptor.AddChild(root_0, string_literal475_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_access_in_modulecompliance_macro_compliance6451);
                    	        	modulecompliance_macro_access476 = modulecompliance_macro_access();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_access476.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:934:37: ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )?
                    	int alt113 = 2;
                    	int LA113_0 = input.LA(1);

                    	if ( (LA113_0 == 171) )
                    	{
                    	    alt113 = 1;
                    	}
                    	switch (alt113) 
                    	{
                    	    case 1 :
                    	        // Smi.g:934:38: 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess
                    	        {
                    	        	string_literal477=(IToken)Match(input,171,FOLLOW_171_in_modulecompliance_macro_compliance6493); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal477_tree = (CommonTree)adaptor.Create(string_literal477);
                    	        		adaptor.AddChild(root_0, string_literal477_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_pibaccess_in_modulecompliance_macro_compliance6495);
                    	        	modulecompliance_macro_pibaccess478 = modulecompliance_macro_pibaccess();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_pibaccess478.Tree);

                    	        }
                    	        break;

                    	}

                    	string_literal479=(IToken)Match(input,141,FOLLOW_141_in_modulecompliance_macro_compliance6540); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal479_tree = (CommonTree)adaptor.Create(string_literal479);
                    		adaptor.AddChild(root_0, string_literal479_tree);
                    	}
                    	C_STRING480=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro_compliance6542); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING480_tree = (CommonTree)adaptor.Create(C_STRING480);
                    		adaptor.AddChild(root_0, C_STRING480_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_compliance"

    public class modulecompliance_macro_syntax_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_syntax"
    // Smi.g:936:0: modulecompliance_macro_syntax : (=> smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );
    public SmiParser.modulecompliance_macro_syntax_return modulecompliance_macro_syntax() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_syntax_return retval = new SmiParser.modulecompliance_macro_syntax_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE482 = null;
        IToken COMMA484 = null;
        IToken R_BRACE486 = null;
        SmiParser.smi_type_return smi_type481 = default(SmiParser.smi_type_return);

        SmiParser.modulecompliance_macro_namedbit_return modulecompliance_macro_namedbit483 = default(SmiParser.modulecompliance_macro_namedbit_return);

        SmiParser.modulecompliance_macro_namedbit_return modulecompliance_macro_namedbit485 = default(SmiParser.modulecompliance_macro_namedbit_return);

        SmiParser.smi_type_return smi_type487 = default(SmiParser.smi_type_return);

        SmiParser.smi_subtyping_return smi_subtyping488 = default(SmiParser.smi_subtyping_return);

        SmiParser.type_return type489 = default(SmiParser.type_return);


        CommonTree L_BRACE482_tree=null;
        CommonTree COMMA484_tree=null;
        CommonTree R_BRACE486_tree=null;

        try 
    	{
            // Smi.g:936:32: (=> smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type )
            int alt117 = 3;
            alt117 = dfa117.Predict(input);
            switch (alt117) 
            {
                case 1 :
                    // Smi.g:936:32: => smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_modulecompliance_macro_syntax6556);
                    	smi_type481 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type481.Tree);
                    	L_BRACE482=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_modulecompliance_macro_syntax6558); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE482_tree = (CommonTree)adaptor.Create(L_BRACE482);
                    		adaptor.AddChild(root_0, L_BRACE482_tree);
                    	}
                    	PushFollow(FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6560);
                    	modulecompliance_macro_namedbit483 = modulecompliance_macro_namedbit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_namedbit483.Tree);
                    	// Smi.g:936:103: ( COMMA modulecompliance_macro_namedbit )*
                    	do 
                    	{
                    	    int alt115 = 2;
                    	    int LA115_0 = input.LA(1);

                    	    if ( (LA115_0 == COMMA) )
                    	    {
                    	        alt115 = 1;
                    	    }


                    	    switch (alt115) 
                    		{
                    			case 1 :
                    			    // Smi.g:936:104: COMMA modulecompliance_macro_namedbit
                    			    {
                    			    	COMMA484=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_modulecompliance_macro_syntax6563); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{COMMA484_tree = (CommonTree)adaptor.Create(COMMA484);
                    			    		adaptor.AddChild(root_0, COMMA484_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6565);
                    			    	modulecompliance_macro_namedbit485 = modulecompliance_macro_namedbit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_namedbit485.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop115;
                    	    }
                    	} while (true);

                    	loop115:
                    		;	// Stops C# compiler whining that label 'loop115' has no statements

                    	R_BRACE486=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_modulecompliance_macro_syntax6569); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE486_tree = (CommonTree)adaptor.Create(R_BRACE486);
                    		adaptor.AddChild(root_0, R_BRACE486_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:937:32: => smi_type ( smi_subtyping )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_modulecompliance_macro_syntax6608);
                    	smi_type487 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type487.Tree);
                    	// Smi.g:937:55: ( smi_subtyping )?
                    	int alt116 = 2;
                    	int LA116_0 = input.LA(1);

                    	if ( (LA116_0 == L_PAREN) )
                    	{
                    	    alt116 = 1;
                    	}
                    	switch (alt116) 
                    	{
                    	    case 1 :
                    	        // Smi.g:937:56: smi_subtyping
                    	        {
                    	        	PushFollow(FOLLOW_smi_subtyping_in_modulecompliance_macro_syntax6611);
                    	        	smi_subtyping488 = smi_subtyping();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_subtyping488.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // Smi.g:938:32: type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_type_in_modulecompliance_macro_syntax6646);
                    	type489 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type489.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_syntax"

    public class modulecompliance_macro_namedbit_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_namedbit"
    // Smi.g:939:0: modulecompliance_macro_namedbit : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.modulecompliance_macro_namedbit_return modulecompliance_macro_namedbit() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_namedbit_return retval = new SmiParser.modulecompliance_macro_namedbit_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER490 = null;
        IToken L_PAREN491 = null;
        IToken NUMBER492 = null;
        IToken R_PAREN493 = null;

        CommonTree LOWER490_tree=null;
        CommonTree L_PAREN491_tree=null;
        CommonTree NUMBER492_tree=null;
        CommonTree R_PAREN493_tree=null;

        try 
    	{
            // Smi.g:939:34: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:939:34: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER490=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_namedbit6652); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER490_tree = (CommonTree)adaptor.Create(LOWER490);
            		adaptor.AddChild(root_0, LOWER490_tree);
            	}
            	L_PAREN491=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_modulecompliance_macro_namedbit6654); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN491_tree = (CommonTree)adaptor.Create(L_PAREN491);
            		adaptor.AddChild(root_0, L_PAREN491_tree);
            	}
            	NUMBER492=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_modulecompliance_macro_namedbit6656); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER492_tree = (CommonTree)adaptor.Create(NUMBER492);
            		adaptor.AddChild(root_0, NUMBER492_tree);
            	}
            	R_PAREN493=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_modulecompliance_macro_namedbit6658); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN493_tree = (CommonTree)adaptor.Create(R_PAREN493);
            		adaptor.AddChild(root_0, R_PAREN493_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_namedbit"

    public class modulecompliance_macro_access_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_access"
    // Smi.g:940:0: modulecompliance_macro_access : l= LOWER ;
    public SmiParser.modulecompliance_macro_access_return modulecompliance_macro_access() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_access_return retval = new SmiParser.modulecompliance_macro_access_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:940:32: (l= LOWER )
            // Smi.g:940:32: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_access6666); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("not-accessible") 
            	                                                  || l.Text == ("accessible-for-notify") 
            	                                                  || l.Text == ("read-only")
            	                                                  || l.Text == ("read-write")
            	                                                  || l.Text == ("read-create"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_access"

    public class modulecompliance_macro_pibaccess_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_pibaccess"
    // Smi.g:947:0: modulecompliance_macro_pibaccess : l= LOWER ;
    public SmiParser.modulecompliance_macro_pibaccess_return modulecompliance_macro_pibaccess() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_pibaccess_return retval = new SmiParser.modulecompliance_macro_pibaccess_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:947:35: (l= LOWER )
            // Smi.g:947:35: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_pibaccess6716); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("not-accessible") 
            	                                                  || l.Text == ("install") 
            	                                                  || l.Text == ("notify")
            	                                                  || l.Text == ("install-notify")
            	                                                  || l.Text == ("report-only"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_pibaccess"

    public class agentcapabilities_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro"
    // Smi.g:956:0: agentcapabilities_macro : 'AGENT-CAPABILITIES' 'PRODUCT-RELEASE' C_STRING 'STATUS' agentcapabilities_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( agentcapabilities_macro_module )* ;
    public SmiParser.agentcapabilities_macro_return agentcapabilities_macro() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_return retval = new SmiParser.agentcapabilities_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal494 = null;
        IToken string_literal495 = null;
        IToken C_STRING496 = null;
        IToken string_literal497 = null;
        IToken string_literal499 = null;
        IToken C_STRING500 = null;
        IToken string_literal501 = null;
        IToken C_STRING502 = null;
        SmiParser.agentcapabilities_macro_status_return agentcapabilities_macro_status498 = default(SmiParser.agentcapabilities_macro_status_return);

        SmiParser.agentcapabilities_macro_module_return agentcapabilities_macro_module503 = default(SmiParser.agentcapabilities_macro_module_return);


        CommonTree string_literal494_tree=null;
        CommonTree string_literal495_tree=null;
        CommonTree C_STRING496_tree=null;
        CommonTree string_literal497_tree=null;
        CommonTree string_literal499_tree=null;
        CommonTree C_STRING500_tree=null;
        CommonTree string_literal501_tree=null;
        CommonTree C_STRING502_tree=null;

        try 
    	{
            // Smi.g:956:26: ( 'AGENT-CAPABILITIES' 'PRODUCT-RELEASE' C_STRING 'STATUS' agentcapabilities_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( agentcapabilities_macro_module )* )
            // Smi.g:956:26: 'AGENT-CAPABILITIES' 'PRODUCT-RELEASE' C_STRING 'STATUS' agentcapabilities_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( agentcapabilities_macro_module )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal494=(IToken)Match(input,131,FOLLOW_131_in_agentcapabilities_macro6767); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal494_tree = (CommonTree)adaptor.Create(string_literal494);
            		adaptor.AddChild(root_0, string_literal494_tree);
            	}
            	string_literal495=(IToken)Match(input,175,FOLLOW_175_in_agentcapabilities_macro6769); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal495_tree = (CommonTree)adaptor.Create(string_literal495);
            		adaptor.AddChild(root_0, string_literal495_tree);
            	}
            	C_STRING496=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro6771); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING496_tree = (CommonTree)adaptor.Create(C_STRING496);
            		adaptor.AddChild(root_0, C_STRING496_tree);
            	}
            	string_literal497=(IToken)Match(input,184,FOLLOW_184_in_agentcapabilities_macro6773); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal497_tree = (CommonTree)adaptor.Create(string_literal497);
            		adaptor.AddChild(root_0, string_literal497_tree);
            	}
            	PushFollow(FOLLOW_agentcapabilities_macro_status_in_agentcapabilities_macro6775);
            	agentcapabilities_macro_status498 = agentcapabilities_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_status498.Tree);
            	string_literal499=(IToken)Match(input,141,FOLLOW_141_in_agentcapabilities_macro6802); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal499_tree = (CommonTree)adaptor.Create(string_literal499);
            		adaptor.AddChild(root_0, string_literal499_tree);
            	}
            	C_STRING500=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro6804); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING500_tree = (CommonTree)adaptor.Create(C_STRING500);
            		adaptor.AddChild(root_0, C_STRING500_tree);
            	}
            	// Smi.g:957:49: ( 'REFERENCE' C_STRING )?
            	int alt118 = 2;
            	int LA118_0 = input.LA(1);

            	if ( (LA118_0 == 177) )
            	{
            	    alt118 = 1;
            	}
            	switch (alt118) 
            	{
            	    case 1 :
            	        // Smi.g:957:50: 'REFERENCE' C_STRING
            	        {
            	        	string_literal501=(IToken)Match(input,177,FOLLOW_177_in_agentcapabilities_macro6807); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal501_tree = (CommonTree)adaptor.Create(string_literal501);
            	        		adaptor.AddChild(root_0, string_literal501_tree);
            	        	}
            	        	C_STRING502=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro6809); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING502_tree = (CommonTree)adaptor.Create(C_STRING502);
            	        		adaptor.AddChild(root_0, C_STRING502_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:957:73: ( agentcapabilities_macro_module )*
            	do 
            	{
            	    int alt119 = 2;
            	    int LA119_0 = input.LA(1);

            	    if ( (LA119_0 == 186) )
            	    {
            	        alt119 = 1;
            	    }


            	    switch (alt119) 
            		{
            			case 1 :
            			    // Smi.g:957:74: agentcapabilities_macro_module
            			    {
            			    	PushFollow(FOLLOW_agentcapabilities_macro_module_in_agentcapabilities_macro6814);
            			    	agentcapabilities_macro_module503 = agentcapabilities_macro_module();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_module503.Tree);

            			    }
            			    break;

            			default:
            			    goto loop119;
            	    }
            	} while (true);

            	loop119:
            		;	// Stops C# compiler whining that label 'loop119' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro"

    public class agentcapabilities_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_status"
    // Smi.g:958:0: agentcapabilities_macro_status : l= LOWER ;
    public SmiParser.agentcapabilities_macro_status_return agentcapabilities_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_status_return retval = new SmiParser.agentcapabilities_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:958:33: (l= LOWER )
            // Smi.g:958:33: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_status6824); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_status"

    public class agentcapabilities_macro_module_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_module"
    // Smi.g:962:0: agentcapabilities_macro_module : 'SUPPORTS' LOWER ( value )? 'INCLUDES' L_BRACE value ( COMMA value )* R_BRACE ( agentcapabilities_macro_variation )* ;
    public SmiParser.agentcapabilities_macro_module_return agentcapabilities_macro_module() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_module_return retval = new SmiParser.agentcapabilities_macro_module_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal504 = null;
        IToken LOWER505 = null;
        IToken string_literal507 = null;
        IToken L_BRACE508 = null;
        IToken COMMA510 = null;
        IToken R_BRACE512 = null;
        SmiParser.value_return value506 = default(SmiParser.value_return);

        SmiParser.value_return value509 = default(SmiParser.value_return);

        SmiParser.value_return value511 = default(SmiParser.value_return);

        SmiParser.agentcapabilities_macro_variation_return agentcapabilities_macro_variation513 = default(SmiParser.agentcapabilities_macro_variation_return);


        CommonTree string_literal504_tree=null;
        CommonTree LOWER505_tree=null;
        CommonTree string_literal507_tree=null;
        CommonTree L_BRACE508_tree=null;
        CommonTree COMMA510_tree=null;
        CommonTree R_BRACE512_tree=null;

        try 
    	{
            // Smi.g:962:33: ( 'SUPPORTS' LOWER ( value )? 'INCLUDES' L_BRACE value ( COMMA value )* R_BRACE ( agentcapabilities_macro_variation )* )
            // Smi.g:962:33: 'SUPPORTS' LOWER ( value )? 'INCLUDES' L_BRACE value ( COMMA value )* R_BRACE ( agentcapabilities_macro_variation )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal504=(IToken)Match(input,186,FOLLOW_186_in_agentcapabilities_macro_module6872); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal504_tree = (CommonTree)adaptor.Create(string_literal504);
            		adaptor.AddChild(root_0, string_literal504_tree);
            	}
            	LOWER505=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_module6874); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER505_tree = (CommonTree)adaptor.Create(LOWER505);
            		adaptor.AddChild(root_0, LOWER505_tree);
            	}
            	// Smi.g:962:50: ( value )?
            	int alt120 = 2;
            	int LA120_0 = input.LA(1);

            	if ( (LA120_0 == B_STRING || LA120_0 == C_STRING || LA120_0 == FALSE_KW || LA120_0 == H_STRING || LA120_0 == L_BRACE || LA120_0 == LOWER || (LA120_0 >= MINUS && LA120_0 <= NUMBER) || LA120_0 == PLUS_INFINITY_KW || LA120_0 == TRUE_KW || LA120_0 == UPPER) )
            	{
            	    alt120 = 1;
            	}
            	switch (alt120) 
            	{
            	    case 1 :
            	        // Smi.g:962:51: value
            	        {
            	        	PushFollow(FOLLOW_value_in_agentcapabilities_macro_module6877);
            	        	value506 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value506.Tree);

            	        }
            	        break;

            	}

            	string_literal507=(IToken)Match(input,INCLUDES_KW,FOLLOW_INCLUDES_KW_in_agentcapabilities_macro_module6914); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal507_tree = (CommonTree)adaptor.Create(string_literal507);
            		adaptor.AddChild(root_0, string_literal507_tree);
            	}
            	L_BRACE508=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_module6916); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE508_tree = (CommonTree)adaptor.Create(L_BRACE508);
            		adaptor.AddChild(root_0, L_BRACE508_tree);
            	}
            	PushFollow(FOLLOW_value_in_agentcapabilities_macro_module6918);
            	value509 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value509.Tree);
            	// Smi.g:963:58: ( COMMA value )*
            	do 
            	{
            	    int alt121 = 2;
            	    int LA121_0 = input.LA(1);

            	    if ( (LA121_0 == COMMA) )
            	    {
            	        alt121 = 1;
            	    }


            	    switch (alt121) 
            		{
            			case 1 :
            			    // Smi.g:963:59: COMMA value
            			    {
            			    	COMMA510=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_module6921); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA510_tree = (CommonTree)adaptor.Create(COMMA510);
            			    		adaptor.AddChild(root_0, COMMA510_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_agentcapabilities_macro_module6923);
            			    	value511 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value511.Tree);

            			    }
            			    break;

            			default:
            			    goto loop121;
            	    }
            	} while (true);

            	loop121:
            		;	// Stops C# compiler whining that label 'loop121' has no statements

            	R_BRACE512=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_module6927); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE512_tree = (CommonTree)adaptor.Create(R_BRACE512);
            		adaptor.AddChild(root_0, R_BRACE512_tree);
            	}
            	// Smi.g:964:33: ( agentcapabilities_macro_variation )*
            	do 
            	{
            	    int alt122 = 2;
            	    int LA122_0 = input.LA(1);

            	    if ( (LA122_0 == 196) )
            	    {
            	        alt122 = 1;
            	    }


            	    switch (alt122) 
            		{
            			case 1 :
            			    // Smi.g:964:34: agentcapabilities_macro_variation
            			    {
            			    	PushFollow(FOLLOW_agentcapabilities_macro_variation_in_agentcapabilities_macro_module6963);
            			    	agentcapabilities_macro_variation513 = agentcapabilities_macro_variation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_variation513.Tree);

            			    }
            			    break;

            			default:
            			    goto loop122;
            	    }
            	} while (true);

            	loop122:
            		;	// Stops C# compiler whining that label 'loop122' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_module"

    public class agentcapabilities_macro_variation_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_variation"
    // Smi.g:965:0: agentcapabilities_macro_variation : 'VARIATION' value ( 'SYNTAX' agentcapabilities_macro_syntax )? ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )? ( 'ACCESS' agentcapabilities_macro_access )? ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )? ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )? 'DESCRIPTION' C_STRING ;
    public SmiParser.agentcapabilities_macro_variation_return agentcapabilities_macro_variation() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_variation_return retval = new SmiParser.agentcapabilities_macro_variation_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal514 = null;
        IToken string_literal516 = null;
        IToken string_literal518 = null;
        IToken string_literal520 = null;
        IToken string_literal522 = null;
        IToken L_BRACE523 = null;
        IToken COMMA525 = null;
        IToken R_BRACE527 = null;
        IToken string_literal528 = null;
        IToken L_BRACE529 = null;
        IToken L_BRACE530 = null;
        IToken LOWER531 = null;
        IToken COMMA532 = null;
        IToken LOWER533 = null;
        IToken R_BRACE534 = null;
        IToken string_literal536 = null;
        IToken C_STRING537 = null;
        SmiParser.value_return value515 = default(SmiParser.value_return);

        SmiParser.agentcapabilities_macro_syntax_return agentcapabilities_macro_syntax517 = default(SmiParser.agentcapabilities_macro_syntax_return);

        SmiParser.agentcapabilities_macro_syntax_return agentcapabilities_macro_syntax519 = default(SmiParser.agentcapabilities_macro_syntax_return);

        SmiParser.agentcapabilities_macro_access_return agentcapabilities_macro_access521 = default(SmiParser.agentcapabilities_macro_access_return);

        SmiParser.value_return value524 = default(SmiParser.value_return);

        SmiParser.value_return value526 = default(SmiParser.value_return);

        SmiParser.value_return value535 = default(SmiParser.value_return);


        CommonTree string_literal514_tree=null;
        CommonTree string_literal516_tree=null;
        CommonTree string_literal518_tree=null;
        CommonTree string_literal520_tree=null;
        CommonTree string_literal522_tree=null;
        CommonTree L_BRACE523_tree=null;
        CommonTree COMMA525_tree=null;
        CommonTree R_BRACE527_tree=null;
        CommonTree string_literal528_tree=null;
        CommonTree L_BRACE529_tree=null;
        CommonTree L_BRACE530_tree=null;
        CommonTree LOWER531_tree=null;
        CommonTree COMMA532_tree=null;
        CommonTree LOWER533_tree=null;
        CommonTree R_BRACE534_tree=null;
        CommonTree string_literal536_tree=null;
        CommonTree C_STRING537_tree=null;

        try 
    	{
            // Smi.g:965:36: ( 'VARIATION' value ( 'SYNTAX' agentcapabilities_macro_syntax )? ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )? ( 'ACCESS' agentcapabilities_macro_access )? ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )? ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )? 'DESCRIPTION' C_STRING )
            // Smi.g:965:36: 'VARIATION' value ( 'SYNTAX' agentcapabilities_macro_syntax )? ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )? ( 'ACCESS' agentcapabilities_macro_access )? ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )? ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )? 'DESCRIPTION' C_STRING
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal514=(IToken)Match(input,196,FOLLOW_196_in_agentcapabilities_macro_variation6971); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal514_tree = (CommonTree)adaptor.Create(string_literal514);
            		adaptor.AddChild(root_0, string_literal514_tree);
            	}
            	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation6973);
            	value515 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value515.Tree);
            	// Smi.g:965:54: ( 'SYNTAX' agentcapabilities_macro_syntax )?
            	int alt123 = 2;
            	int LA123_0 = input.LA(1);

            	if ( (LA123_0 == 187) )
            	{
            	    alt123 = 1;
            	}
            	switch (alt123) 
            	{
            	    case 1 :
            	        // Smi.g:965:55: 'SYNTAX' agentcapabilities_macro_syntax
            	        {
            	        	string_literal516=(IToken)Match(input,187,FOLLOW_187_in_agentcapabilities_macro_variation6976); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal516_tree = (CommonTree)adaptor.Create(string_literal516);
            	        		adaptor.AddChild(root_0, string_literal516_tree);
            	        	}
            	        	PushFollow(FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6978);
            	        	agentcapabilities_macro_syntax517 = agentcapabilities_macro_syntax();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_syntax517.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:965:97: ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )?
            	int alt124 = 2;
            	int LA124_0 = input.LA(1);

            	if ( (LA124_0 == 197) )
            	{
            	    alt124 = 1;
            	}
            	switch (alt124) 
            	{
            	    case 1 :
            	        // Smi.g:965:98: 'WRITE-SYNTAX' agentcapabilities_macro_syntax
            	        {
            	        	string_literal518=(IToken)Match(input,197,FOLLOW_197_in_agentcapabilities_macro_variation6983); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal518_tree = (CommonTree)adaptor.Create(string_literal518);
            	        		adaptor.AddChild(root_0, string_literal518_tree);
            	        	}
            	        	PushFollow(FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6985);
            	        	agentcapabilities_macro_syntax519 = agentcapabilities_macro_syntax();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_syntax519.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:965:146: ( 'ACCESS' agentcapabilities_macro_access )?
            	int alt125 = 2;
            	int LA125_0 = input.LA(1);

            	if ( (LA125_0 == 130) )
            	{
            	    alt125 = 1;
            	}
            	switch (alt125) 
            	{
            	    case 1 :
            	        // Smi.g:965:147: 'ACCESS' agentcapabilities_macro_access
            	        {
            	        	string_literal520=(IToken)Match(input,130,FOLLOW_130_in_agentcapabilities_macro_variation6990); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal520_tree = (CommonTree)adaptor.Create(string_literal520);
            	        		adaptor.AddChild(root_0, string_literal520_tree);
            	        	}
            	        	PushFollow(FOLLOW_agentcapabilities_macro_access_in_agentcapabilities_macro_variation6992);
            	        	agentcapabilities_macro_access521 = agentcapabilities_macro_access();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_access521.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:966:37: ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt127 = 2;
            	int LA127_0 = input.LA(1);

            	if ( (LA127_0 == 139) )
            	{
            	    alt127 = 1;
            	}
            	switch (alt127) 
            	{
            	    case 1 :
            	        // Smi.g:966:38: 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal522=(IToken)Match(input,139,FOLLOW_139_in_agentcapabilities_macro_variation7034); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal522_tree = (CommonTree)adaptor.Create(string_literal522);
            	        		adaptor.AddChild(root_0, string_literal522_tree);
            	        	}
            	        	L_BRACE523=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7036); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE523_tree = (CommonTree)adaptor.Create(L_BRACE523);
            	        		adaptor.AddChild(root_0, L_BRACE523_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation7038);
            	        	value524 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value524.Tree);
            	        	// Smi.g:966:72: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt126 = 2;
            	        	    int LA126_0 = input.LA(1);

            	        	    if ( (LA126_0 == COMMA) )
            	        	    {
            	        	        alt126 = 1;
            	        	    }


            	        	    switch (alt126) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:966:73: COMMA value
            	        			    {
            	        			    	COMMA525=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_variation7041); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA525_tree = (CommonTree)adaptor.Create(COMMA525);
            	        			    		adaptor.AddChild(root_0, COMMA525_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation7043);
            	        			    	value526 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value526.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop126;
            	        	    }
            	        	} while (true);

            	        	loop126:
            	        		;	// Stops C# compiler whining that label 'loop126' has no statements

            	        	R_BRACE527=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7047); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE527_tree = (CommonTree)adaptor.Create(R_BRACE527);
            	        		adaptor.AddChild(root_0, R_BRACE527_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:967:37: ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )?
            	int alt131 = 2;
            	int LA131_0 = input.LA(1);

            	if ( (LA131_0 == 140) )
            	{
            	    alt131 = 1;
            	}
            	switch (alt131) 
            	{
            	    case 1 :
            	        // Smi.g:967:38: 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value )
            	        {
            	        	string_literal528=(IToken)Match(input,140,FOLLOW_140_in_agentcapabilities_macro_variation7089); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal528_tree = (CommonTree)adaptor.Create(string_literal528);
            	        		adaptor.AddChild(root_0, string_literal528_tree);
            	        	}
            	        	L_BRACE529=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7091); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE529_tree = (CommonTree)adaptor.Create(L_BRACE529);
            	        		adaptor.AddChild(root_0, L_BRACE529_tree);
            	        	}
            	        	// Smi.g:967:55: (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value )
            	        	int alt130 = 2;
            	        	alt130 = dfa130.Predict(input);
            	        	switch (alt130) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:967:56: => L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE
            	        	        {

            	        	        	L_BRACE530=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7112); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{L_BRACE530_tree = (CommonTree)adaptor.Create(L_BRACE530);
            	        	        		adaptor.AddChild(root_0, L_BRACE530_tree);
            	        	        	}
            	        	        	// Smi.g:967:103: ( LOWER )?
            	        	        	int alt128 = 2;
            	        	        	int LA128_0 = input.LA(1);

            	        	        	if ( (LA128_0 == LOWER) )
            	        	        	{
            	        	        	    alt128 = 1;
            	        	        	}
            	        	        	switch (alt128) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // Smi.g:967:104: LOWER
            	        	        	        {
            	        	        	        	LOWER531=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_variation7115); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{LOWER531_tree = (CommonTree)adaptor.Create(LOWER531);
            	        	        	        		adaptor.AddChild(root_0, LOWER531_tree);
            	        	        	        	}

            	        	        	        }
            	        	        	        break;

            	        	        	}

            	        	        	// Smi.g:967:112: ( COMMA LOWER )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt129 = 2;
            	        	        	    int LA129_0 = input.LA(1);

            	        	        	    if ( (LA129_0 == COMMA) )
            	        	        	    {
            	        	        	        alt129 = 1;
            	        	        	    }


            	        	        	    switch (alt129) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // Smi.g:967:113: COMMA LOWER
            	        	        			    {
            	        	        			    	COMMA532=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_variation7120); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{COMMA532_tree = (CommonTree)adaptor.Create(COMMA532);
            	        	        			    		adaptor.AddChild(root_0, COMMA532_tree);
            	        	        			    	}
            	        	        			    	LOWER533=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_variation7122); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{LOWER533_tree = (CommonTree)adaptor.Create(LOWER533);
            	        	        			    		adaptor.AddChild(root_0, LOWER533_tree);
            	        	        			    	}

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop129;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop129:
            	        	        		;	// Stops C# compiler whining that label 'loop129' has no statements

            	        	        	R_BRACE534=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7126); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{R_BRACE534_tree = (CommonTree)adaptor.Create(R_BRACE534);
            	        	        		adaptor.AddChild(root_0, R_BRACE534_tree);
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Smi.g:967:137: value
            	        	        {
            	        	        	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation7130);
            	        	        	value535 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value535.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	string_literal536=(IToken)Match(input,141,FOLLOW_141_in_agentcapabilities_macro_variation7173); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal536_tree = (CommonTree)adaptor.Create(string_literal536);
            		adaptor.AddChild(root_0, string_literal536_tree);
            	}
            	C_STRING537=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro_variation7175); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING537_tree = (CommonTree)adaptor.Create(C_STRING537);
            		adaptor.AddChild(root_0, C_STRING537_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_variation"

    public class agentcapabilities_macro_syntax_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_syntax"
    // Smi.g:969:0: agentcapabilities_macro_syntax : (=> smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );
    public SmiParser.agentcapabilities_macro_syntax_return agentcapabilities_macro_syntax() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_syntax_return retval = new SmiParser.agentcapabilities_macro_syntax_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE539 = null;
        IToken COMMA541 = null;
        IToken R_BRACE543 = null;
        SmiParser.smi_type_return smi_type538 = default(SmiParser.smi_type_return);

        SmiParser.agentcapabilities_macro_namedbit_return agentcapabilities_macro_namedbit540 = default(SmiParser.agentcapabilities_macro_namedbit_return);

        SmiParser.agentcapabilities_macro_namedbit_return agentcapabilities_macro_namedbit542 = default(SmiParser.agentcapabilities_macro_namedbit_return);

        SmiParser.smi_type_return smi_type544 = default(SmiParser.smi_type_return);

        SmiParser.smi_subtyping_return smi_subtyping545 = default(SmiParser.smi_subtyping_return);

        SmiParser.type_return type546 = default(SmiParser.type_return);


        CommonTree L_BRACE539_tree=null;
        CommonTree COMMA541_tree=null;
        CommonTree R_BRACE543_tree=null;

        try 
    	{
            // Smi.g:969:33: (=> smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type )
            int alt134 = 3;
            alt134 = dfa134.Predict(input);
            switch (alt134) 
            {
                case 1 :
                    // Smi.g:969:33: => smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_agentcapabilities_macro_syntax7226);
                    	smi_type538 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type538.Tree);
                    	L_BRACE539=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_syntax7228); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE539_tree = (CommonTree)adaptor.Create(L_BRACE539);
                    		adaptor.AddChild(root_0, L_BRACE539_tree);
                    	}
                    	PushFollow(FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7230);
                    	agentcapabilities_macro_namedbit540 = agentcapabilities_macro_namedbit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_namedbit540.Tree);
                    	// Smi.g:970:87: ( COMMA agentcapabilities_macro_namedbit )*
                    	do 
                    	{
                    	    int alt132 = 2;
                    	    int LA132_0 = input.LA(1);

                    	    if ( (LA132_0 == COMMA) )
                    	    {
                    	        alt132 = 1;
                    	    }


                    	    switch (alt132) 
                    		{
                    			case 1 :
                    			    // Smi.g:970:88: COMMA agentcapabilities_macro_namedbit
                    			    {
                    			    	COMMA541=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_syntax7233); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{COMMA541_tree = (CommonTree)adaptor.Create(COMMA541);
                    			    		adaptor.AddChild(root_0, COMMA541_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7235);
                    			    	agentcapabilities_macro_namedbit542 = agentcapabilities_macro_namedbit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_namedbit542.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop132;
                    	    }
                    	} while (true);

                    	loop132:
                    		;	// Stops C# compiler whining that label 'loop132' has no statements

                    	R_BRACE543=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_syntax7239); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE543_tree = (CommonTree)adaptor.Create(R_BRACE543);
                    		adaptor.AddChild(root_0, R_BRACE543_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:971:33: => smi_type ( smi_subtyping )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_agentcapabilities_macro_syntax7279);
                    	smi_type544 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type544.Tree);
                    	// Smi.g:971:56: ( smi_subtyping )?
                    	int alt133 = 2;
                    	int LA133_0 = input.LA(1);

                    	if ( (LA133_0 == L_PAREN) )
                    	{
                    	    alt133 = 1;
                    	}
                    	switch (alt133) 
                    	{
                    	    case 1 :
                    	        // Smi.g:971:57: smi_subtyping
                    	        {
                    	        	PushFollow(FOLLOW_smi_subtyping_in_agentcapabilities_macro_syntax7282);
                    	        	smi_subtyping545 = smi_subtyping();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_subtyping545.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // Smi.g:972:33: type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_type_in_agentcapabilities_macro_syntax7318);
                    	type546 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type546.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_syntax"

    public class agentcapabilities_macro_access_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_access"
    // Smi.g:973:0: agentcapabilities_macro_access : l= LOWER ;
    public SmiParser.agentcapabilities_macro_access_return agentcapabilities_macro_access() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_access_return retval = new SmiParser.agentcapabilities_macro_access_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:973:33: (l= LOWER )
            // Smi.g:973:33: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_access7327); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("not-implemented") 
            	                                                  || l.Text == ("accessible-for-notify") 
            	                                                  || l.Text == ("read-only")
            	                                                  || l.Text == ("read-write")
            	                                                  || l.Text == ("read-create")
            	                                                  || l.Text == ("write-only"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_access"

    public class agentcapabilities_macro_namedbit_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_namedbit"
    // Smi.g:981:0: agentcapabilities_macro_namedbit : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.agentcapabilities_macro_namedbit_return agentcapabilities_macro_namedbit() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_namedbit_return retval = new SmiParser.agentcapabilities_macro_namedbit_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER547 = null;
        IToken L_PAREN548 = null;
        IToken NUMBER549 = null;
        IToken R_PAREN550 = null;

        CommonTree LOWER547_tree=null;
        CommonTree L_PAREN548_tree=null;
        CommonTree NUMBER549_tree=null;
        CommonTree R_PAREN550_tree=null;

        try 
    	{
            // Smi.g:981:35: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:981:35: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER547=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_namedbit7375); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER547_tree = (CommonTree)adaptor.Create(LOWER547);
            		adaptor.AddChild(root_0, LOWER547_tree);
            	}
            	L_PAREN548=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_agentcapabilities_macro_namedbit7377); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN548_tree = (CommonTree)adaptor.Create(L_PAREN548);
            		adaptor.AddChild(root_0, L_PAREN548_tree);
            	}
            	NUMBER549=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_agentcapabilities_macro_namedbit7379); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER549_tree = (CommonTree)adaptor.Create(NUMBER549);
            		adaptor.AddChild(root_0, NUMBER549_tree);
            	}
            	R_PAREN550=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_agentcapabilities_macro_namedbit7381); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN550_tree = (CommonTree)adaptor.Create(R_PAREN550);
            		adaptor.AddChild(root_0, R_PAREN550_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_namedbit"

    public class traptype_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "traptype_macro"
    // Smi.g:985:0: traptype_macro : 'TRAP-TYPE' 'ENTERPRISE' value ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )? (=> 'DESCRIPTION' value )? ( 'REFERENCE' value )? ;
    public SmiParser.traptype_macro_return traptype_macro() // throws RecognitionException [1]
    {   
        SmiParser.traptype_macro_return retval = new SmiParser.traptype_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal551 = null;
        IToken string_literal552 = null;
        IToken string_literal554 = null;
        IToken L_BRACE555 = null;
        IToken COMMA557 = null;
        IToken R_BRACE559 = null;
        IToken string_literal560 = null;
        IToken string_literal562 = null;
        SmiParser.value_return value553 = default(SmiParser.value_return);

        SmiParser.value_return value556 = default(SmiParser.value_return);

        SmiParser.value_return value558 = default(SmiParser.value_return);

        SmiParser.value_return value561 = default(SmiParser.value_return);

        SmiParser.value_return value563 = default(SmiParser.value_return);


        CommonTree string_literal551_tree=null;
        CommonTree string_literal552_tree=null;
        CommonTree string_literal554_tree=null;
        CommonTree L_BRACE555_tree=null;
        CommonTree COMMA557_tree=null;
        CommonTree R_BRACE559_tree=null;
        CommonTree string_literal560_tree=null;
        CommonTree string_literal562_tree=null;

        try 
    	{
            // Smi.g:985:17: ( 'TRAP-TYPE' 'ENTERPRISE' value ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )? (=> 'DESCRIPTION' value )? ( 'REFERENCE' value )? )
            // Smi.g:985:17: 'TRAP-TYPE' 'ENTERPRISE' value ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )? (=> 'DESCRIPTION' value )? ( 'REFERENCE' value )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal551=(IToken)Match(input,191,FOLLOW_191_in_traptype_macro7391); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal551_tree = (CommonTree)adaptor.Create(string_literal551);
            		adaptor.AddChild(root_0, string_literal551_tree);
            	}
            	string_literal552=(IToken)Match(input,144,FOLLOW_144_in_traptype_macro7393); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal552_tree = (CommonTree)adaptor.Create(string_literal552);
            		adaptor.AddChild(root_0, string_literal552_tree);
            	}
            	PushFollow(FOLLOW_value_in_traptype_macro7395);
            	value553 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value553.Tree);
            	// Smi.g:985:48: ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt136 = 2;
            	int LA136_0 = input.LA(1);

            	if ( (LA136_0 == 195) )
            	{
            	    alt136 = 1;
            	}
            	switch (alt136) 
            	{
            	    case 1 :
            	        // Smi.g:985:49: 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal554=(IToken)Match(input,195,FOLLOW_195_in_traptype_macro7398); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal554_tree = (CommonTree)adaptor.Create(string_literal554);
            	        		adaptor.AddChild(root_0, string_literal554_tree);
            	        	}
            	        	L_BRACE555=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_traptype_macro7400); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE555_tree = (CommonTree)adaptor.Create(L_BRACE555);
            	        		adaptor.AddChild(root_0, L_BRACE555_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_traptype_macro7402);
            	        	value556 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value556.Tree);
            	        	// Smi.g:985:75: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt135 = 2;
            	        	    int LA135_0 = input.LA(1);

            	        	    if ( (LA135_0 == COMMA) )
            	        	    {
            	        	        alt135 = 1;
            	        	    }


            	        	    switch (alt135) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:985:76: COMMA value
            	        			    {
            	        			    	COMMA557=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_traptype_macro7405); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA557_tree = (CommonTree)adaptor.Create(COMMA557);
            	        			    		adaptor.AddChild(root_0, COMMA557_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_traptype_macro7407);
            	        			    	value558 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value558.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop135;
            	        	    }
            	        	} while (true);

            	        	loop135:
            	        		;	// Stops C# compiler whining that label 'loop135' has no statements

            	        	R_BRACE559=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_traptype_macro7411); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE559_tree = (CommonTree)adaptor.Create(R_BRACE559);
            	        		adaptor.AddChild(root_0, R_BRACE559_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:986:21: (=> 'DESCRIPTION' value )?
            	int alt137 = 2;
            	alt137 = dfa137.Predict(input);
            	switch (alt137) 
            	{
            	    case 1 :
            	        // Smi.g:986:22: => 'DESCRIPTION' value
            	        {

            	        	string_literal560=(IToken)Match(input,141,FOLLOW_141_in_traptype_macro7443); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal560_tree = (CommonTree)adaptor.Create(string_literal560);
            	        		adaptor.AddChild(root_0, string_literal560_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_traptype_macro7445);
            	        	value561 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value561.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:986:63: ( 'REFERENCE' value )?
            	int alt138 = 2;
            	int LA138_0 = input.LA(1);

            	if ( (LA138_0 == 177) )
            	{
            	    alt138 = 1;
            	}
            	switch (alt138) 
            	{
            	    case 1 :
            	        // Smi.g:986:64: 'REFERENCE' value
            	        {
            	        	string_literal562=(IToken)Match(input,177,FOLLOW_177_in_traptype_macro7450); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal562_tree = (CommonTree)adaptor.Create(string_literal562);
            	        		adaptor.AddChild(root_0, string_literal562_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_traptype_macro7452);
            	        	value563 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value563.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "traptype_macro"

    public class operation_errorlist_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "operation_errorlist"
    // Smi.g:988:0: operation_errorlist : typeorvalue ( COMMA typeorvalue )* ;
    public SmiParser.operation_errorlist_return operation_errorlist() // throws RecognitionException [1]
    {   
        SmiParser.operation_errorlist_return retval = new SmiParser.operation_errorlist_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA565 = null;
        SmiParser.typeorvalue_return typeorvalue564 = default(SmiParser.typeorvalue_return);

        SmiParser.typeorvalue_return typeorvalue566 = default(SmiParser.typeorvalue_return);


        CommonTree COMMA565_tree=null;

        try 
    	{
            // Smi.g:988:22: ( typeorvalue ( COMMA typeorvalue )* )
            // Smi.g:988:22: typeorvalue ( COMMA typeorvalue )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_typeorvalue_in_operation_errorlist7462);
            	typeorvalue564 = typeorvalue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue564.Tree);
            	// Smi.g:988:34: ( COMMA typeorvalue )*
            	do 
            	{
            	    int alt139 = 2;
            	    int LA139_0 = input.LA(1);

            	    if ( (LA139_0 == COMMA) )
            	    {
            	        alt139 = 1;
            	    }


            	    switch (alt139) 
            		{
            			case 1 :
            			    // Smi.g:988:35: COMMA typeorvalue
            			    {
            			    	COMMA565=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_operation_errorlist7465); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA565_tree = (CommonTree)adaptor.Create(COMMA565);
            			    		adaptor.AddChild(root_0, COMMA565_tree);
            			    	}
            			    	PushFollow(FOLLOW_typeorvalue_in_operation_errorlist7467);
            			    	typeorvalue566 = typeorvalue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue566.Tree);

            			    }
            			    break;

            			default:
            			    goto loop139;
            	    }
            	} while (true);

            	loop139:
            		;	// Stops C# compiler whining that label 'loop139' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "operation_errorlist"

    public class linkedOp_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "linkedOp_list"
    // Smi.g:990:0: linkedOp_list : typeorvalue ( COMMA typeorvalue )* ;
    public SmiParser.linkedOp_list_return linkedOp_list() // throws RecognitionException [1]
    {   
        SmiParser.linkedOp_list_return retval = new SmiParser.linkedOp_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA568 = null;
        SmiParser.typeorvalue_return typeorvalue567 = default(SmiParser.typeorvalue_return);

        SmiParser.typeorvalue_return typeorvalue569 = default(SmiParser.typeorvalue_return);


        CommonTree COMMA568_tree=null;

        try 
    	{
            // Smi.g:990:16: ( typeorvalue ( COMMA typeorvalue )* )
            // Smi.g:990:16: typeorvalue ( COMMA typeorvalue )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_typeorvalue_in_linkedOp_list7477);
            	typeorvalue567 = typeorvalue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue567.Tree);
            	// Smi.g:990:28: ( COMMA typeorvalue )*
            	do 
            	{
            	    int alt140 = 2;
            	    int LA140_0 = input.LA(1);

            	    if ( (LA140_0 == COMMA) )
            	    {
            	        alt140 = 1;
            	    }


            	    switch (alt140) 
            		{
            			case 1 :
            			    // Smi.g:990:29: COMMA typeorvalue
            			    {
            			    	COMMA568=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_linkedOp_list7480); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA568_tree = (CommonTree)adaptor.Create(COMMA568);
            			    		adaptor.AddChild(root_0, COMMA568_tree);
            			    	}
            			    	PushFollow(FOLLOW_typeorvalue_in_linkedOp_list7482);
            			    	typeorvalue569 = typeorvalue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue569.Tree);

            			    }
            			    break;

            			default:
            			    goto loop140;
            	    }
            	} while (true);

            	loop140:
            		;	// Stops C# compiler whining that label 'loop140' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "linkedOp_list"

    public class typeorvalue_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typeorvalue"
    // Smi.g:992:0: typeorvalue : (=> type | value );
    public SmiParser.typeorvalue_return typeorvalue() // throws RecognitionException [1]
    {   
        SmiParser.typeorvalue_return retval = new SmiParser.typeorvalue_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.type_return type570 = default(SmiParser.type_return);

        SmiParser.value_return value571 = default(SmiParser.value_return);



        try 
    	{
            // Smi.g:992:14: (=> type | value )
            int alt141 = 2;
            alt141 = dfa141.Predict(input);
            switch (alt141) 
            {
                case 1 :
                    // Smi.g:992:14: => type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_type_in_typeorvalue7498);
                    	type570 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type570.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:992:31: value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_typeorvalue7502);
                    	value571 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value571.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "typeorvalue"

    public class typeorvaluelist_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typeorvaluelist"
    // Smi.g:995:0: typeorvaluelist : typeorvalue ( COMMA typeorvalue )* ;
    public SmiParser.typeorvaluelist_return typeorvaluelist() // throws RecognitionException [1]
    {   
        SmiParser.typeorvaluelist_return retval = new SmiParser.typeorvaluelist_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA573 = null;
        SmiParser.typeorvalue_return typeorvalue572 = default(SmiParser.typeorvalue_return);

        SmiParser.typeorvalue_return typeorvalue574 = default(SmiParser.typeorvalue_return);


        CommonTree COMMA573_tree=null;

        try 
    	{
            // Smi.g:995:18: ( typeorvalue ( COMMA typeorvalue )* )
            // Smi.g:995:18: typeorvalue ( COMMA typeorvalue )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_typeorvalue_in_typeorvaluelist7510);
            	typeorvalue572 = typeorvalue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue572.Tree);
            	// Smi.g:995:30: ( COMMA typeorvalue )*
            	do 
            	{
            	    int alt142 = 2;
            	    int LA142_0 = input.LA(1);

            	    if ( (LA142_0 == COMMA) )
            	    {
            	        alt142 = 1;
            	    }


            	    switch (alt142) 
            		{
            			case 1 :
            			    // Smi.g:995:31: COMMA typeorvalue
            			    {
            			    	COMMA573=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_typeorvaluelist7513); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA573_tree = (CommonTree)adaptor.Create(COMMA573);
            			    		adaptor.AddChild(root_0, COMMA573_tree);
            			    	}
            			    	PushFollow(FOLLOW_typeorvalue_in_typeorvaluelist7515);
            			    	typeorvalue574 = typeorvalue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue574.Tree);

            			    }
            			    break;

            			default:
            			    goto loop142;
            	    }
            	} while (true);

            	loop142:
            		;	// Stops C# compiler whining that label 'loop142' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "typeorvaluelist"

    public class elementType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "elementType"
    // Smi.g:998:0: elementType : ( LOWER (=> tag )? ( tag_default )? type ( OPTIONAL_KW | DEFAULT_KW value )? | COMPONENTS_KW OF_KW type );
    public SmiParser.elementType_return elementType() // throws RecognitionException [1]
    {   
        SmiParser.elementType_return retval = new SmiParser.elementType_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER575 = null;
        IToken OPTIONAL_KW579 = null;
        IToken DEFAULT_KW580 = null;
        IToken COMPONENTS_KW582 = null;
        IToken OF_KW583 = null;
        SmiParser.tag_return tag576 = default(SmiParser.tag_return);

        SmiParser.tag_default_return tag_default577 = default(SmiParser.tag_default_return);

        SmiParser.type_return type578 = default(SmiParser.type_return);

        SmiParser.value_return value581 = default(SmiParser.value_return);

        SmiParser.type_return type584 = default(SmiParser.type_return);


        CommonTree LOWER575_tree=null;
        CommonTree OPTIONAL_KW579_tree=null;
        CommonTree DEFAULT_KW580_tree=null;
        CommonTree COMPONENTS_KW582_tree=null;
        CommonTree OF_KW583_tree=null;

        try 
    	{
            // Smi.g:998:14: ( LOWER (=> tag )? ( tag_default )? type ( OPTIONAL_KW | DEFAULT_KW value )? | COMPONENTS_KW OF_KW type )
            int alt146 = 2;
            int LA146_0 = input.LA(1);

            if ( (LA146_0 == LOWER) )
            {
                alt146 = 1;
            }
            else if ( (LA146_0 == COMPONENTS_KW) )
            {
                alt146 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d146s0 =
                    new NoViableAltException("", 146, 0, input);

                throw nvae_d146s0;
            }
            switch (alt146) 
            {
                case 1 :
                    // Smi.g:998:14: LOWER (=> tag )? ( tag_default )? type ( OPTIONAL_KW | DEFAULT_KW value )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LOWER575=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_elementType7527); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER575_tree = (CommonTree)adaptor.Create(LOWER575);
                    		adaptor.AddChild(root_0, LOWER575_tree);
                    	}
                    	// Smi.g:998:21: (=> tag )?
                    	int alt143 = 2;
                    	alt143 = dfa143.Predict(input);
                    	switch (alt143) 
                    	{
                    	    case 1 :
                    	        // Smi.g:998:22: => tag
                    	        {

                    	        	PushFollow(FOLLOW_tag_in_elementType7545);
                    	        	tag576 = tag();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag576.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:999:21: ( tag_default )?
                    	int alt144 = 2;
                    	int LA144_0 = input.LA(1);

                    	if ( (LA144_0 == AUTOMATIC_KW || LA144_0 == EXPLICIT_KW || LA144_0 == IMPLICIT_KW) )
                    	{
                    	    alt144 = 1;
                    	}
                    	switch (alt144) 
                    	{
                    	    case 1 :
                    	        // Smi.g:999:22: tag_default
                    	        {
                    	        	PushFollow(FOLLOW_tag_default_in_elementType7571);
                    	        	tag_default577 = tag_default();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag_default577.Tree);

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_type_in_elementType7575);
                    	type578 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type578.Tree);
                    	// Smi.g:999:41: ( OPTIONAL_KW | DEFAULT_KW value )?
                    	int alt145 = 3;
                    	int LA145_0 = input.LA(1);

                    	if ( (LA145_0 == OPTIONAL_KW) )
                    	{
                    	    alt145 = 1;
                    	}
                    	else if ( (LA145_0 == DEFAULT_KW) )
                    	{
                    	    alt145 = 2;
                    	}
                    	switch (alt145) 
                    	{
                    	    case 1 :
                    	        // Smi.g:999:42: OPTIONAL_KW
                    	        {
                    	        	OPTIONAL_KW579=(IToken)Match(input,OPTIONAL_KW,FOLLOW_OPTIONAL_KW_in_elementType7578); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{OPTIONAL_KW579_tree = (CommonTree)adaptor.Create(OPTIONAL_KW579);
                    	        		adaptor.AddChild(root_0, OPTIONAL_KW579_tree);
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:999:56: DEFAULT_KW value
                    	        {
                    	        	DEFAULT_KW580=(IToken)Match(input,DEFAULT_KW,FOLLOW_DEFAULT_KW_in_elementType7582); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{DEFAULT_KW580_tree = (CommonTree)adaptor.Create(DEFAULT_KW580);
                    	        		adaptor.AddChild(root_0, DEFAULT_KW580_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_value_in_elementType7584);
                    	        	value581 = value();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value581.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // Smi.g:1000:14: COMPONENTS_KW OF_KW type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	COMPONENTS_KW582=(IToken)Match(input,COMPONENTS_KW,FOLLOW_COMPONENTS_KW_in_elementType7602); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMPONENTS_KW582_tree = (CommonTree)adaptor.Create(COMPONENTS_KW582);
                    		adaptor.AddChild(root_0, COMPONENTS_KW582_tree);
                    	}
                    	OF_KW583=(IToken)Match(input,OF_KW,FOLLOW_OF_KW_in_elementType7604); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OF_KW583_tree = (CommonTree)adaptor.Create(OF_KW583);
                    		adaptor.AddChild(root_0, OF_KW583_tree);
                    	}
                    	PushFollow(FOLLOW_type_in_elementType7606);
                    	type584 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type584.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elementType"

    public class namedNumber_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "namedNumber"
    // Smi.g:1004:0: namedNumber : LOWER L_PAREN ( signed_number | defined_value ) R_PAREN ;
    public SmiParser.namedNumber_return namedNumber() // throws RecognitionException [1]
    {   
        SmiParser.namedNumber_return retval = new SmiParser.namedNumber_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER585 = null;
        IToken L_PAREN586 = null;
        IToken R_PAREN589 = null;
        SmiParser.signed_number_return signed_number587 = default(SmiParser.signed_number_return);

        SmiParser.defined_value_return defined_value588 = default(SmiParser.defined_value_return);


        CommonTree LOWER585_tree=null;
        CommonTree L_PAREN586_tree=null;
        CommonTree R_PAREN589_tree=null;

        try 
    	{
            // Smi.g:1004:14: ( LOWER L_PAREN ( signed_number | defined_value ) R_PAREN )
            // Smi.g:1004:14: LOWER L_PAREN ( signed_number | defined_value ) R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER585=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_namedNumber7615); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER585_tree = (CommonTree)adaptor.Create(LOWER585);
            		adaptor.AddChild(root_0, LOWER585_tree);
            	}
            	L_PAREN586=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_namedNumber7617); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN586_tree = (CommonTree)adaptor.Create(L_PAREN586);
            		adaptor.AddChild(root_0, L_PAREN586_tree);
            	}
            	// Smi.g:1004:28: ( signed_number | defined_value )
            	int alt147 = 2;
            	int LA147_0 = input.LA(1);

            	if ( (LA147_0 == MINUS || LA147_0 == NUMBER) )
            	{
            	    alt147 = 1;
            	}
            	else if ( (LA147_0 == LOWER || LA147_0 == UPPER) )
            	{
            	    alt147 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d147s0 =
            	        new NoViableAltException("", 147, 0, input);

            	    throw nvae_d147s0;
            	}
            	switch (alt147) 
            	{
            	    case 1 :
            	        // Smi.g:1004:29: signed_number
            	        {
            	        	PushFollow(FOLLOW_signed_number_in_namedNumber7620);
            	        	signed_number587 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number587.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1004:45: defined_value
            	        {
            	        	PushFollow(FOLLOW_defined_value_in_namedNumber7624);
            	        	defined_value588 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value588.Tree);

            	        }
            	        break;

            	}

            	R_PAREN589=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_namedNumber7627); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN589_tree = (CommonTree)adaptor.Create(R_PAREN589);
            		adaptor.AddChild(root_0, R_PAREN589_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "namedNumber"

    public class signed_number_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "signed_number"
    // Smi.g:1006:0: signed_number : ( MINUS )? NUMBER ;
    public SmiParser.signed_number_return signed_number() // throws RecognitionException [1]
    {   
        SmiParser.signed_number_return retval = new SmiParser.signed_number_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS590 = null;
        IToken NUMBER591 = null;

        CommonTree MINUS590_tree=null;
        CommonTree NUMBER591_tree=null;

        try 
    	{
            // Smi.g:1006:16: ( ( MINUS )? NUMBER )
            // Smi.g:1006:16: ( MINUS )? NUMBER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:1006:16: ( MINUS )?
            	int alt148 = 2;
            	int LA148_0 = input.LA(1);

            	if ( (LA148_0 == MINUS) )
            	{
            	    alt148 = 1;
            	}
            	switch (alt148) 
            	{
            	    case 1 :
            	        // Smi.g:1006:17: MINUS
            	        {
            	        	MINUS590=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_signed_number7635); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MINUS590_tree = (CommonTree)adaptor.Create(MINUS590);
            	        		adaptor.AddChild(root_0, MINUS590_tree);
            	        	}

            	        }
            	        break;

            	}

            	NUMBER591=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_signed_number7639); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER591_tree = (CommonTree)adaptor.Create(NUMBER591);
            		adaptor.AddChild(root_0, NUMBER591_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "signed_number"

    public class element_set_specs_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "element_set_specs"
    // Smi.g:1008:0: element_set_specs : element_set_spec ( COMMA DOTDOTDOT )? ( COMMA element_set_spec )? ;
    public SmiParser.element_set_specs_return element_set_specs() // throws RecognitionException [1]
    {   
        SmiParser.element_set_specs_return retval = new SmiParser.element_set_specs_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA593 = null;
        IToken DOTDOTDOT594 = null;
        IToken COMMA595 = null;
        SmiParser.element_set_spec_return element_set_spec592 = default(SmiParser.element_set_spec_return);

        SmiParser.element_set_spec_return element_set_spec596 = default(SmiParser.element_set_spec_return);


        CommonTree COMMA593_tree=null;
        CommonTree DOTDOTDOT594_tree=null;
        CommonTree COMMA595_tree=null;

        try 
    	{
            // Smi.g:1008:20: ( element_set_spec ( COMMA DOTDOTDOT )? ( COMMA element_set_spec )? )
            // Smi.g:1008:20: element_set_spec ( COMMA DOTDOTDOT )? ( COMMA element_set_spec )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_element_set_spec_in_element_set_specs7646);
            	element_set_spec592 = element_set_spec();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_spec592.Tree);
            	// Smi.g:1008:37: ( COMMA DOTDOTDOT )?
            	int alt149 = 2;
            	int LA149_0 = input.LA(1);

            	if ( (LA149_0 == COMMA) )
            	{
            	    int LA149_1 = input.LA(2);

            	    if ( (LA149_1 == DOTDOTDOT) )
            	    {
            	        alt149 = 1;
            	    }
            	}
            	switch (alt149) 
            	{
            	    case 1 :
            	        // Smi.g:1008:38: COMMA DOTDOTDOT
            	        {
            	        	COMMA593=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_element_set_specs7649); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA593_tree = (CommonTree)adaptor.Create(COMMA593);
            	        		adaptor.AddChild(root_0, COMMA593_tree);
            	        	}
            	        	DOTDOTDOT594=(IToken)Match(input,DOTDOTDOT,FOLLOW_DOTDOTDOT_in_element_set_specs7651); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOTDOTDOT594_tree = (CommonTree)adaptor.Create(DOTDOTDOT594);
            	        		adaptor.AddChild(root_0, DOTDOTDOT594_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:1008:56: ( COMMA element_set_spec )?
            	int alt150 = 2;
            	int LA150_0 = input.LA(1);

            	if ( (LA150_0 == COMMA) )
            	{
            	    alt150 = 1;
            	}
            	switch (alt150) 
            	{
            	    case 1 :
            	        // Smi.g:1008:57: COMMA element_set_spec
            	        {
            	        	COMMA595=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_element_set_specs7656); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA595_tree = (CommonTree)adaptor.Create(COMMA595);
            	        		adaptor.AddChild(root_0, COMMA595_tree);
            	        	}
            	        	PushFollow(FOLLOW_element_set_spec_in_element_set_specs7658);
            	        	element_set_spec596 = element_set_spec();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_spec596.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "element_set_specs"

    public class exception_spec_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "exception_spec"
    // Smi.g:1010:0: exception_spec : EXCLAMATION (=> signed_number |=> defined_value | type COLON value ) ;
    public SmiParser.exception_spec_return exception_spec() // throws RecognitionException [1]
    {   
        SmiParser.exception_spec_return retval = new SmiParser.exception_spec_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EXCLAMATION597 = null;
        IToken COLON601 = null;
        SmiParser.signed_number_return signed_number598 = default(SmiParser.signed_number_return);

        SmiParser.defined_value_return defined_value599 = default(SmiParser.defined_value_return);

        SmiParser.type_return type600 = default(SmiParser.type_return);

        SmiParser.value_return value602 = default(SmiParser.value_return);


        CommonTree EXCLAMATION597_tree=null;
        CommonTree COLON601_tree=null;

        try 
    	{
            // Smi.g:1010:17: ( EXCLAMATION (=> signed_number |=> defined_value | type COLON value ) )
            // Smi.g:1010:17: EXCLAMATION (=> signed_number |=> defined_value | type COLON value )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	EXCLAMATION597=(IToken)Match(input,EXCLAMATION,FOLLOW_EXCLAMATION_in_exception_spec7668); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXCLAMATION597_tree = (CommonTree)adaptor.Create(EXCLAMATION597);
            		adaptor.AddChild(root_0, EXCLAMATION597_tree);
            	}
            	// Smi.g:1011:17: (=> signed_number |=> defined_value | type COLON value )
            	int alt151 = 3;
            	int LA151_0 = input.LA(1);

            	if ( (LA151_0 == MINUS) && (synpred42_Smi()) )
            	{
            	    alt151 = 1;
            	}
            	else if ( (LA151_0 == NUMBER) && (synpred42_Smi()) )
            	{
            	    alt151 = 1;
            	}
            	else if ( (LA151_0 == UPPER) )
            	{
            	    int LA151_3 = input.LA(2);

            	    if ( (LA151_3 == DOT) )
            	    {
            	        int LA151_6 = input.LA(3);

            	        if ( (LA151_6 == LOWER) && (synpred43_Smi()) )
            	        {
            	            alt151 = 2;
            	        }
            	        else if ( (LA151_6 == UPPER) )
            	        {
            	            alt151 = 3;
            	        }
            	        else 
            	        {
            	            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	            NoViableAltException nvae_d151s6 =
            	                new NoViableAltException("", 151, 6, input);

            	            throw nvae_d151s6;
            	        }
            	    }
            	    else if ( (LA151_3 == COLON || LA151_3 == L_PAREN) )
            	    {
            	        alt151 = 3;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d151s3 =
            	            new NoViableAltException("", 151, 3, input);

            	        throw nvae_d151s3;
            	    }
            	}
            	else if ( (LA151_0 == LOWER) )
            	{
            	    int LA151_4 = input.LA(2);

            	    if ( (LA151_4 == LESS) )
            	    {
            	        alt151 = 3;
            	    }
            	    else if ( (LA151_4 == R_PAREN) && (synpred43_Smi()) )
            	    {
            	        alt151 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d151s4 =
            	            new NoViableAltException("", 151, 4, input);

            	        throw nvae_d151s4;
            	    }
            	}
            	else if ( (LA151_0 == ANY_KW || (LA151_0 >= BIT_KW && LA151_0 <= BOOLEAN_KW) || LA151_0 == CHARACTER_KW || LA151_0 == CHOICE_KW || LA151_0 == EMBEDDED_KW || (LA151_0 >= ENUMERATED_KW && LA151_0 <= ERROR_KW) || LA151_0 == EXTERNAL_KW || (LA151_0 >= GENERAL_STR_KW && LA151_0 <= GRAPHIC_STR_KW) || LA151_0 == IA5_STRING_KW || LA151_0 == INTEGER_KW || LA151_0 == ISO646_STR_KW || LA151_0 == L_BRACKET || LA151_0 == NULL_KW || LA151_0 == NUMERIC_STR_KW || (LA151_0 >= OBJECT_KW && LA151_0 <= OCTET_KW) || LA151_0 == OPERATION_KW || LA151_0 == PRINTABLE_STR_KW || LA151_0 == REAL_KW || (LA151_0 >= SEQUENCE_KW && LA151_0 <= SET_KW) || LA151_0 == T61_STR_KW || LA151_0 == TELETEX_STR_KW || LA151_0 == UNIVERSAL_STR_KW || (LA151_0 >= UTC_TIME_KW && LA151_0 <= VISIBLE_STR_KW) || LA151_0 == 131 || LA151_0 == 137 || (LA151_0 >= 158 && LA151_0 <= 160) || (LA151_0 >= 162 && LA151_0 <= 164) || LA151_0 == 166 || LA151_0 == 179 || LA151_0 == 188 || LA151_0 == 191) )
            	{
            	    alt151 = 3;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d151s0 =
            	        new NoViableAltException("", 151, 0, input);

            	    throw nvae_d151s0;
            	}
            	switch (alt151) 
            	{
            	    case 1 :
            	        // Smi.g:1011:19: => signed_number
            	        {

            	        	PushFollow(FOLLOW_signed_number_in_exception_spec7695);
            	        	signed_number598 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number598.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1012:21: => defined_value
            	        {

            	        	PushFollow(FOLLOW_defined_value_in_exception_spec7724);
            	        	defined_value599 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value599.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // Smi.g:1013:21: type COLON value
            	        {
            	        	PushFollow(FOLLOW_type_in_exception_spec7747);
            	        	type600 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type600.Tree);
            	        	COLON601=(IToken)Match(input,COLON,FOLLOW_COLON_in_exception_spec7749); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COLON601_tree = (CommonTree)adaptor.Create(COLON601);
            	        		adaptor.AddChild(root_0, COLON601_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_exception_spec7751);
            	        	value602 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value602.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exception_spec"

    public class element_set_spec_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "element_set_spec"
    // Smi.g:1016:0: element_set_spec : ( intersections ( ( BAR | UNION_KW ) intersections )* | ALL_KW EXCEPT_KW constraint_elements );
    public SmiParser.element_set_spec_return element_set_spec() // throws RecognitionException [1]
    {   
        SmiParser.element_set_spec_return retval = new SmiParser.element_set_spec_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set604 = null;
        IToken ALL_KW606 = null;
        IToken EXCEPT_KW607 = null;
        SmiParser.intersections_return intersections603 = default(SmiParser.intersections_return);

        SmiParser.intersections_return intersections605 = default(SmiParser.intersections_return);

        SmiParser.constraint_elements_return constraint_elements608 = default(SmiParser.constraint_elements_return);


        CommonTree set604_tree=null;
        CommonTree ALL_KW606_tree=null;
        CommonTree EXCEPT_KW607_tree=null;

        try 
    	{
            // Smi.g:1016:19: ( intersections ( ( BAR | UNION_KW ) intersections )* | ALL_KW EXCEPT_KW constraint_elements )
            int alt153 = 2;
            int LA153_0 = input.LA(1);

            if ( (LA153_0 == ANY_KW || LA153_0 == B_STRING || (LA153_0 >= BIT_KW && LA153_0 <= BOOLEAN_KW) || (LA153_0 >= C_STRING && LA153_0 <= CHARACTER_KW) || LA153_0 == CHOICE_KW || LA153_0 == EMBEDDED_KW || (LA153_0 >= ENUMERATED_KW && LA153_0 <= ERROR_KW) || (LA153_0 >= EXTERNAL_KW && LA153_0 <= H_STRING) || LA153_0 == IA5_STRING_KW || LA153_0 == INCLUDES_KW || LA153_0 == INTEGER_KW || (LA153_0 >= ISO646_STR_KW && LA153_0 <= L_PAREN) || LA153_0 == LOWER || (LA153_0 >= MIN_KW && LA153_0 <= NUMERIC_STR_KW) || (LA153_0 >= OBJECT_KW && LA153_0 <= OCTET_KW) || LA153_0 == OPERATION_KW || LA153_0 == PATTERN_KW || LA153_0 == PLUS_INFINITY_KW || LA153_0 == PRINTABLE_STR_KW || LA153_0 == REAL_KW || (LA153_0 >= SEQUENCE_KW && LA153_0 <= SET_KW) || LA153_0 == SIZE_KW || LA153_0 == T61_STR_KW || (LA153_0 >= TELETEX_STR_KW && LA153_0 <= TRUE_KW) || (LA153_0 >= UNIVERSAL_STR_KW && LA153_0 <= WITH_KW) || LA153_0 == 131 || LA153_0 == 137 || (LA153_0 >= 158 && LA153_0 <= 160) || (LA153_0 >= 162 && LA153_0 <= 164) || LA153_0 == 166 || LA153_0 == 179 || LA153_0 == 188 || LA153_0 == 191) )
            {
                alt153 = 1;
            }
            else if ( (LA153_0 == ALL_KW) )
            {
                alt153 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d153s0 =
                    new NoViableAltException("", 153, 0, input);

                throw nvae_d153s0;
            }
            switch (alt153) 
            {
                case 1 :
                    // Smi.g:1016:19: intersections ( ( BAR | UNION_KW ) intersections )*
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_intersections_in_element_set_spec7776);
                    	intersections603 = intersections();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intersections603.Tree);
                    	// Smi.g:1016:33: ( ( BAR | UNION_KW ) intersections )*
                    	do 
                    	{
                    	    int alt152 = 2;
                    	    int LA152_0 = input.LA(1);

                    	    if ( (LA152_0 == BAR || LA152_0 == UNION_KW) )
                    	    {
                    	        alt152 = 1;
                    	    }


                    	    switch (alt152) 
                    		{
                    			case 1 :
                    			    // Smi.g:1016:35: ( BAR | UNION_KW ) intersections
                    			    {
                    			    	set604 = (IToken)input.LT(1);
                    			    	if ( input.LA(1) == BAR || input.LA(1) == UNION_KW ) 
                    			    	{
                    			    	    input.Consume();
                    			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set604));
                    			    	    state.errorRecovery = false;state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    throw mse;
                    			    	}

                    			    	PushFollow(FOLLOW_intersections_in_element_set_spec7788);
                    			    	intersections605 = intersections();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intersections605.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop152;
                    	    }
                    	} while (true);

                    	loop152:
                    		;	// Stops C# compiler whining that label 'loop152' has no statements


                    }
                    break;
                case 2 :
                    // Smi.g:1017:19: ALL_KW EXCEPT_KW constraint_elements
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ALL_KW606=(IToken)Match(input,ALL_KW,FOLLOW_ALL_KW_in_element_set_spec7812); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ALL_KW606_tree = (CommonTree)adaptor.Create(ALL_KW606);
                    		adaptor.AddChild(root_0, ALL_KW606_tree);
                    	}
                    	EXCEPT_KW607=(IToken)Match(input,EXCEPT_KW,FOLLOW_EXCEPT_KW_in_element_set_spec7814); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{EXCEPT_KW607_tree = (CommonTree)adaptor.Create(EXCEPT_KW607);
                    		adaptor.AddChild(root_0, EXCEPT_KW607_tree);
                    	}
                    	PushFollow(FOLLOW_constraint_elements_in_element_set_spec7816);
                    	constraint_elements608 = constraint_elements();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements608.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "element_set_spec"

    public class intersections_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "intersections"
    // Smi.g:1019:0: intersections : constraint_elements ( EXCEPT_KW constraint_elements )? ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )* ;
    public SmiParser.intersections_return intersections() // throws RecognitionException [1]
    {   
        SmiParser.intersections_return retval = new SmiParser.intersections_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EXCEPT_KW610 = null;
        IToken set612 = null;
        IToken EXCEPT_KW614 = null;
        SmiParser.constraint_elements_return constraint_elements609 = default(SmiParser.constraint_elements_return);

        SmiParser.constraint_elements_return constraint_elements611 = default(SmiParser.constraint_elements_return);

        SmiParser.constraint_elements_return constraint_elements613 = default(SmiParser.constraint_elements_return);

        SmiParser.constraint_elements_return constraint_elements615 = default(SmiParser.constraint_elements_return);


        CommonTree EXCEPT_KW610_tree=null;
        CommonTree set612_tree=null;
        CommonTree EXCEPT_KW614_tree=null;

        try 
    	{
            // Smi.g:1019:16: ( constraint_elements ( EXCEPT_KW constraint_elements )? ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )* )
            // Smi.g:1019:16: constraint_elements ( EXCEPT_KW constraint_elements )? ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_constraint_elements_in_intersections7823);
            	constraint_elements609 = constraint_elements();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements609.Tree);
            	// Smi.g:1019:36: ( EXCEPT_KW constraint_elements )?
            	int alt154 = 2;
            	int LA154_0 = input.LA(1);

            	if ( (LA154_0 == EXCEPT_KW) )
            	{
            	    alt154 = 1;
            	}
            	switch (alt154) 
            	{
            	    case 1 :
            	        // Smi.g:1019:37: EXCEPT_KW constraint_elements
            	        {
            	        	EXCEPT_KW610=(IToken)Match(input,EXCEPT_KW,FOLLOW_EXCEPT_KW_in_intersections7826); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{EXCEPT_KW610_tree = (CommonTree)adaptor.Create(EXCEPT_KW610);
            	        		adaptor.AddChild(root_0, EXCEPT_KW610_tree);
            	        	}
            	        	PushFollow(FOLLOW_constraint_elements_in_intersections7828);
            	        	constraint_elements611 = constraint_elements();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements611.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1020:17: ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )*
            	do 
            	{
            	    int alt156 = 2;
            	    int LA156_0 = input.LA(1);

            	    if ( ((LA156_0 >= INTERSECTION && LA156_0 <= INTERSECTION_KW)) )
            	    {
            	        alt156 = 1;
            	    }


            	    switch (alt156) 
            		{
            			case 1 :
            			    // Smi.g:1020:19: ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )?
            			    {
            			    	set612 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= INTERSECTION && input.LA(1) <= INTERSECTION_KW) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set612));
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_constraint_elements_in_intersections7859);
            			    	constraint_elements613 = constraint_elements();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements613.Tree);
            			    	// Smi.g:1020:72: ( EXCEPT_KW constraint_elements )?
            			    	int alt155 = 2;
            			    	int LA155_0 = input.LA(1);

            			    	if ( (LA155_0 == EXCEPT_KW) )
            			    	{
            			    	    alt155 = 1;
            			    	}
            			    	switch (alt155) 
            			    	{
            			    	    case 1 :
            			    	        // Smi.g:1020:73: EXCEPT_KW constraint_elements
            			    	        {
            			    	        	EXCEPT_KW614=(IToken)Match(input,EXCEPT_KW,FOLLOW_EXCEPT_KW_in_intersections7862); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{EXCEPT_KW614_tree = (CommonTree)adaptor.Create(EXCEPT_KW614);
            			    	        		adaptor.AddChild(root_0, EXCEPT_KW614_tree);
            			    	        	}
            			    	        	PushFollow(FOLLOW_constraint_elements_in_intersections7864);
            			    	        	constraint_elements615 = constraint_elements();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements615.Tree);

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop156;
            	    }
            	} while (true);

            	loop156:
            		;	// Stops C# compiler whining that label 'loop156' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "intersections"

    public class constraint_elements_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constraint_elements"
    // Smi.g:1022:0: constraint_elements : (=> value_range |=> value | SIZE_KW constraint | FROM_KW constraint | L_PAREN element_set_spec R_PAREN | ( INCLUDES_KW )? type | PATTERN_KW value | WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE ) );
    public SmiParser.constraint_elements_return constraint_elements() // throws RecognitionException [1]
    {   
        SmiParser.constraint_elements_return retval = new SmiParser.constraint_elements_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SIZE_KW618 = null;
        IToken FROM_KW620 = null;
        IToken L_PAREN622 = null;
        IToken R_PAREN624 = null;
        IToken INCLUDES_KW625 = null;
        IToken PATTERN_KW627 = null;
        IToken WITH_KW629 = null;
        IToken COMPONENT_KW630 = null;
        IToken COMPONENTS_KW632 = null;
        IToken L_BRACE633 = null;
        IToken DOTDOTDOT634 = null;
        IToken COMMA635 = null;
        IToken R_BRACE637 = null;
        SmiParser.value_range_return value_range616 = default(SmiParser.value_range_return);

        SmiParser.value_return value617 = default(SmiParser.value_return);

        SmiParser.constraint_return constraint619 = default(SmiParser.constraint_return);

        SmiParser.constraint_return constraint621 = default(SmiParser.constraint_return);

        SmiParser.element_set_spec_return element_set_spec623 = default(SmiParser.element_set_spec_return);

        SmiParser.type_return type626 = default(SmiParser.type_return);

        SmiParser.value_return value628 = default(SmiParser.value_return);

        SmiParser.constraint_return constraint631 = default(SmiParser.constraint_return);

        SmiParser.type_constraint_list_return type_constraint_list636 = default(SmiParser.type_constraint_list_return);


        CommonTree SIZE_KW618_tree=null;
        CommonTree FROM_KW620_tree=null;
        CommonTree L_PAREN622_tree=null;
        CommonTree R_PAREN624_tree=null;
        CommonTree INCLUDES_KW625_tree=null;
        CommonTree PATTERN_KW627_tree=null;
        CommonTree WITH_KW629_tree=null;
        CommonTree COMPONENT_KW630_tree=null;
        CommonTree COMPONENTS_KW632_tree=null;
        CommonTree L_BRACE633_tree=null;
        CommonTree DOTDOTDOT634_tree=null;
        CommonTree COMMA635_tree=null;
        CommonTree R_BRACE637_tree=null;

        try 
    	{
            // Smi.g:1022:22: (=> value_range |=> value | SIZE_KW constraint | FROM_KW constraint | L_PAREN element_set_spec R_PAREN | ( INCLUDES_KW )? type | PATTERN_KW value | WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE ) )
            int alt160 = 8;
            alt160 = dfa160.Predict(input);
            switch (alt160) 
            {
                case 1 :
                    // Smi.g:1022:22: => value_range
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_value_range_in_constraint_elements7883);
                    	value_range616 = value_range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value_range616.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:1023:22: => value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_value_in_constraint_elements7912);
                    	value617 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value617.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:1024:22: SIZE_KW constraint
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	SIZE_KW618=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_constraint_elements7936); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{SIZE_KW618_tree = (CommonTree)adaptor.Create(SIZE_KW618);
                    		adaptor.AddChild(root_0, SIZE_KW618_tree);
                    	}
                    	PushFollow(FOLLOW_constraint_in_constraint_elements7938);
                    	constraint619 = constraint();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint619.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:1025:22: FROM_KW constraint
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	FROM_KW620=(IToken)Match(input,FROM_KW,FOLLOW_FROM_KW_in_constraint_elements7962); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FROM_KW620_tree = (CommonTree)adaptor.Create(FROM_KW620);
                    		adaptor.AddChild(root_0, FROM_KW620_tree);
                    	}
                    	PushFollow(FOLLOW_constraint_in_constraint_elements7964);
                    	constraint621 = constraint();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint621.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:1026:22: L_PAREN element_set_spec R_PAREN
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_PAREN622=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_constraint_elements7988); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN622_tree = (CommonTree)adaptor.Create(L_PAREN622);
                    		adaptor.AddChild(root_0, L_PAREN622_tree);
                    	}
                    	PushFollow(FOLLOW_element_set_spec_in_constraint_elements7990);
                    	element_set_spec623 = element_set_spec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_spec623.Tree);
                    	R_PAREN624=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_constraint_elements7992); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN624_tree = (CommonTree)adaptor.Create(R_PAREN624);
                    		adaptor.AddChild(root_0, R_PAREN624_tree);
                    	}

                    }
                    break;
                case 6 :
                    // Smi.g:1027:22: ( INCLUDES_KW )? type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// Smi.g:1027:22: ( INCLUDES_KW )?
                    	int alt157 = 2;
                    	int LA157_0 = input.LA(1);

                    	if ( (LA157_0 == INCLUDES_KW) )
                    	{
                    	    alt157 = 1;
                    	}
                    	switch (alt157) 
                    	{
                    	    case 1 :
                    	        // Smi.g:1027:23: INCLUDES_KW
                    	        {
                    	        	INCLUDES_KW625=(IToken)Match(input,INCLUDES_KW,FOLLOW_INCLUDES_KW_in_constraint_elements8017); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{INCLUDES_KW625_tree = (CommonTree)adaptor.Create(INCLUDES_KW625);
                    	        		adaptor.AddChild(root_0, INCLUDES_KW625_tree);
                    	        	}

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_type_in_constraint_elements8021);
                    	type626 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type626.Tree);

                    }
                    break;
                case 7 :
                    // Smi.g:1028:22: PATTERN_KW value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PATTERN_KW627=(IToken)Match(input,PATTERN_KW,FOLLOW_PATTERN_KW_in_constraint_elements8045); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PATTERN_KW627_tree = (CommonTree)adaptor.Create(PATTERN_KW627);
                    		adaptor.AddChild(root_0, PATTERN_KW627_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_constraint_elements8047);
                    	value628 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value628.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:1029:22: WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	WITH_KW629=(IToken)Match(input,WITH_KW,FOLLOW_WITH_KW_in_constraint_elements8071); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WITH_KW629_tree = (CommonTree)adaptor.Create(WITH_KW629);
                    		adaptor.AddChild(root_0, WITH_KW629_tree);
                    	}
                    	// Smi.g:1029:30: ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE )
                    	int alt159 = 2;
                    	int LA159_0 = input.LA(1);

                    	if ( (LA159_0 == COMPONENT_KW) )
                    	{
                    	    alt159 = 1;
                    	}
                    	else if ( (LA159_0 == COMPONENTS_KW) )
                    	{
                    	    alt159 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d159s0 =
                    	        new NoViableAltException("", 159, 0, input);

                    	    throw nvae_d159s0;
                    	}
                    	switch (alt159) 
                    	{
                    	    case 1 :
                    	        // Smi.g:1029:31: COMPONENT_KW constraint
                    	        {
                    	        	COMPONENT_KW630=(IToken)Match(input,COMPONENT_KW,FOLLOW_COMPONENT_KW_in_constraint_elements8074); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{COMPONENT_KW630_tree = (CommonTree)adaptor.Create(COMPONENT_KW630);
                    	        		adaptor.AddChild(root_0, COMPONENT_KW630_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_constraint_in_constraint_elements8076);
                    	        	constraint631 = constraint();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint631.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:1030:33: COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE
                    	        {
                    	        	COMPONENTS_KW632=(IToken)Match(input,COMPONENTS_KW,FOLLOW_COMPONENTS_KW_in_constraint_elements8111); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{COMPONENTS_KW632_tree = (CommonTree)adaptor.Create(COMPONENTS_KW632);
                    	        		adaptor.AddChild(root_0, COMPONENTS_KW632_tree);
                    	        	}
                    	        	L_BRACE633=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_constraint_elements8113); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{L_BRACE633_tree = (CommonTree)adaptor.Create(L_BRACE633);
                    	        		adaptor.AddChild(root_0, L_BRACE633_tree);
                    	        	}
                    	        	// Smi.g:1030:55: ( DOTDOTDOT COMMA )?
                    	        	int alt158 = 2;
                    	        	int LA158_0 = input.LA(1);

                    	        	if ( (LA158_0 == DOTDOTDOT) )
                    	        	{
                    	        	    alt158 = 1;
                    	        	}
                    	        	switch (alt158) 
                    	        	{
                    	        	    case 1 :
                    	        	        // Smi.g:1030:56: DOTDOTDOT COMMA
                    	        	        {
                    	        	        	DOTDOTDOT634=(IToken)Match(input,DOTDOTDOT,FOLLOW_DOTDOTDOT_in_constraint_elements8116); if (state.failed) return retval;
                    	        	        	if ( state.backtracking == 0 )
                    	        	        	{DOTDOTDOT634_tree = (CommonTree)adaptor.Create(DOTDOTDOT634);
                    	        	        		adaptor.AddChild(root_0, DOTDOTDOT634_tree);
                    	        	        	}
                    	        	        	COMMA635=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_constraint_elements8118); if (state.failed) return retval;
                    	        	        	if ( state.backtracking == 0 )
                    	        	        	{COMMA635_tree = (CommonTree)adaptor.Create(COMMA635);
                    	        	        		adaptor.AddChild(root_0, COMMA635_tree);
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	PushFollow(FOLLOW_type_constraint_list_in_constraint_elements8155);
                    	        	type_constraint_list636 = type_constraint_list();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_constraint_list636.Tree);
                    	        	R_BRACE637=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_constraint_elements8157); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{R_BRACE637_tree = (CommonTree)adaptor.Create(R_BRACE637);
                    	        		adaptor.AddChild(root_0, R_BRACE637_tree);
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constraint_elements"

    public class value_range_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "value_range"
    // Smi.g:1033:0: value_range : ( value | MIN_KW ) ( LESS )? DOTDOT ( LESS )? ( value | MAX_KW ) ;
    public SmiParser.value_range_return value_range() // throws RecognitionException [1]
    {   
        SmiParser.value_range_return retval = new SmiParser.value_range_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MIN_KW639 = null;
        IToken LESS640 = null;
        IToken DOTDOT641 = null;
        IToken LESS642 = null;
        IToken MAX_KW644 = null;
        SmiParser.value_return value638 = default(SmiParser.value_return);

        SmiParser.value_return value643 = default(SmiParser.value_return);


        CommonTree MIN_KW639_tree=null;
        CommonTree LESS640_tree=null;
        CommonTree DOTDOT641_tree=null;
        CommonTree LESS642_tree=null;
        CommonTree MAX_KW644_tree=null;

        try 
    	{
            // Smi.g:1033:14: ( ( value | MIN_KW ) ( LESS )? DOTDOT ( LESS )? ( value | MAX_KW ) )
            // Smi.g:1033:14: ( value | MIN_KW ) ( LESS )? DOTDOT ( LESS )? ( value | MAX_KW )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:1033:14: ( value | MIN_KW )
            	int alt161 = 2;
            	int LA161_0 = input.LA(1);

            	if ( (LA161_0 == B_STRING || LA161_0 == C_STRING || LA161_0 == FALSE_KW || LA161_0 == H_STRING || LA161_0 == L_BRACE || LA161_0 == LOWER || (LA161_0 >= MINUS && LA161_0 <= NUMBER) || LA161_0 == PLUS_INFINITY_KW || LA161_0 == TRUE_KW || LA161_0 == UPPER) )
            	{
            	    alt161 = 1;
            	}
            	else if ( (LA161_0 == MIN_KW) )
            	{
            	    alt161 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d161s0 =
            	        new NoViableAltException("", 161, 0, input);

            	    throw nvae_d161s0;
            	}
            	switch (alt161) 
            	{
            	    case 1 :
            	        // Smi.g:1033:15: value
            	        {
            	        	PushFollow(FOLLOW_value_in_value_range8166);
            	        	value638 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value638.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1033:23: MIN_KW
            	        {
            	        	MIN_KW639=(IToken)Match(input,MIN_KW,FOLLOW_MIN_KW_in_value_range8170); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MIN_KW639_tree = (CommonTree)adaptor.Create(MIN_KW639);
            	        		adaptor.AddChild(root_0, MIN_KW639_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:1033:31: ( LESS )?
            	int alt162 = 2;
            	int LA162_0 = input.LA(1);

            	if ( (LA162_0 == LESS) )
            	{
            	    alt162 = 1;
            	}
            	switch (alt162) 
            	{
            	    case 1 :
            	        // Smi.g:1033:32: LESS
            	        {
            	        	LESS640=(IToken)Match(input,LESS,FOLLOW_LESS_in_value_range8174); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LESS640_tree = (CommonTree)adaptor.Create(LESS640);
            	        		adaptor.AddChild(root_0, LESS640_tree);
            	        	}

            	        }
            	        break;

            	}

            	DOTDOT641=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_value_range8178); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{DOTDOT641_tree = (CommonTree)adaptor.Create(DOTDOT641);
            		adaptor.AddChild(root_0, DOTDOT641_tree);
            	}
            	// Smi.g:1033:46: ( LESS )?
            	int alt163 = 2;
            	int LA163_0 = input.LA(1);

            	if ( (LA163_0 == LESS) )
            	{
            	    alt163 = 1;
            	}
            	switch (alt163) 
            	{
            	    case 1 :
            	        // Smi.g:1033:47: LESS
            	        {
            	        	LESS642=(IToken)Match(input,LESS,FOLLOW_LESS_in_value_range8181); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LESS642_tree = (CommonTree)adaptor.Create(LESS642);
            	        		adaptor.AddChild(root_0, LESS642_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:1033:54: ( value | MAX_KW )
            	int alt164 = 2;
            	int LA164_0 = input.LA(1);

            	if ( (LA164_0 == B_STRING || LA164_0 == C_STRING || LA164_0 == FALSE_KW || LA164_0 == H_STRING || LA164_0 == L_BRACE || LA164_0 == LOWER || (LA164_0 >= MINUS && LA164_0 <= NUMBER) || LA164_0 == PLUS_INFINITY_KW || LA164_0 == TRUE_KW || LA164_0 == UPPER) )
            	{
            	    alt164 = 1;
            	}
            	else if ( (LA164_0 == MAX_KW) )
            	{
            	    alt164 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d164s0 =
            	        new NoViableAltException("", 164, 0, input);

            	    throw nvae_d164s0;
            	}
            	switch (alt164) 
            	{
            	    case 1 :
            	        // Smi.g:1033:55: value
            	        {
            	        	PushFollow(FOLLOW_value_in_value_range8186);
            	        	value643 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value643.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1033:63: MAX_KW
            	        {
            	        	MAX_KW644=(IToken)Match(input,MAX_KW,FOLLOW_MAX_KW_in_value_range8190); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MAX_KW644_tree = (CommonTree)adaptor.Create(MAX_KW644);
            	        		adaptor.AddChild(root_0, MAX_KW644_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value_range"

    public class type_constraint_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "type_constraint_list"
    // Smi.g:1035:0: type_constraint_list : named_constraint ( COMMA named_constraint )* ;
    public SmiParser.type_constraint_list_return type_constraint_list() // throws RecognitionException [1]
    {   
        SmiParser.type_constraint_list_return retval = new SmiParser.type_constraint_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA646 = null;
        SmiParser.named_constraint_return named_constraint645 = default(SmiParser.named_constraint_return);

        SmiParser.named_constraint_return named_constraint647 = default(SmiParser.named_constraint_return);


        CommonTree COMMA646_tree=null;

        try 
    	{
            // Smi.g:1035:23: ( named_constraint ( COMMA named_constraint )* )
            // Smi.g:1035:23: named_constraint ( COMMA named_constraint )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_named_constraint_in_type_constraint_list8199);
            	named_constraint645 = named_constraint();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_constraint645.Tree);
            	// Smi.g:1035:40: ( COMMA named_constraint )*
            	do 
            	{
            	    int alt165 = 2;
            	    int LA165_0 = input.LA(1);

            	    if ( (LA165_0 == COMMA) )
            	    {
            	        alt165 = 1;
            	    }


            	    switch (alt165) 
            		{
            			case 1 :
            			    // Smi.g:1035:41: COMMA named_constraint
            			    {
            			    	COMMA646=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_type_constraint_list8202); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA646_tree = (CommonTree)adaptor.Create(COMMA646);
            			    		adaptor.AddChild(root_0, COMMA646_tree);
            			    	}
            			    	PushFollow(FOLLOW_named_constraint_in_type_constraint_list8204);
            			    	named_constraint647 = named_constraint();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_constraint647.Tree);

            			    }
            			    break;

            			default:
            			    goto loop165;
            	    }
            	} while (true);

            	loop165:
            		;	// Stops C# compiler whining that label 'loop165' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type_constraint_list"

    public class named_constraint_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "named_constraint"
    // Smi.g:1037:0: named_constraint : LOWER ( constraint )? ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )? ;
    public SmiParser.named_constraint_return named_constraint() // throws RecognitionException [1]
    {   
        SmiParser.named_constraint_return retval = new SmiParser.named_constraint_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER648 = null;
        IToken set650 = null;
        SmiParser.constraint_return constraint649 = default(SmiParser.constraint_return);


        CommonTree LOWER648_tree=null;
        CommonTree set650_tree=null;

        try 
    	{
            // Smi.g:1037:19: ( LOWER ( constraint )? ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )? )
            // Smi.g:1037:19: LOWER ( constraint )? ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER648=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_named_constraint8214); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER648_tree = (CommonTree)adaptor.Create(LOWER648);
            		adaptor.AddChild(root_0, LOWER648_tree);
            	}
            	// Smi.g:1037:25: ( constraint )?
            	int alt166 = 2;
            	int LA166_0 = input.LA(1);

            	if ( (LA166_0 == L_PAREN) )
            	{
            	    alt166 = 1;
            	}
            	switch (alt166) 
            	{
            	    case 1 :
            	        // Smi.g:1037:26: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_named_constraint8217);
            	        	constraint649 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint649.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1037:39: ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )?
            	int alt167 = 2;
            	int LA167_0 = input.LA(1);

            	if ( (LA167_0 == ABSENT_KW || LA167_0 == OPTIONAL_KW || LA167_0 == PRESENT_KW) )
            	{
            	    alt167 = 1;
            	}
            	switch (alt167) 
            	{
            	    case 1 :
            	        // Smi.g:
            	        {
            	        	set650 = (IToken)input.LT(1);
            	        	if ( input.LA(1) == ABSENT_KW || input.LA(1) == OPTIONAL_KW || input.LA(1) == PRESENT_KW ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set650));
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "named_constraint"

    public class choice_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "choice_value"
    // Smi.g:1039:0: choice_value : LOWER ( COLON )? value ;
    public SmiParser.choice_value_return choice_value() // throws RecognitionException [1]
    {   
        SmiParser.choice_value_return retval = new SmiParser.choice_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER651 = null;
        IToken COLON652 = null;
        SmiParser.value_return value653 = default(SmiParser.value_return);


        CommonTree LOWER651_tree=null;
        CommonTree COLON652_tree=null;

        try 
    	{
            // Smi.g:1039:15: ( LOWER ( COLON )? value )
            // Smi.g:1039:15: LOWER ( COLON )? value
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER651=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_choice_value8240); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER651_tree = (CommonTree)adaptor.Create(LOWER651);
            		adaptor.AddChild(root_0, LOWER651_tree);
            	}
            	// Smi.g:1039:21: ( COLON )?
            	int alt168 = 2;
            	int LA168_0 = input.LA(1);

            	if ( (LA168_0 == COLON) )
            	{
            	    alt168 = 1;
            	}
            	switch (alt168) 
            	{
            	    case 1 :
            	        // Smi.g:1039:22: COLON
            	        {
            	        	COLON652=(IToken)Match(input,COLON,FOLLOW_COLON_in_choice_value8243); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COLON652_tree = (CommonTree)adaptor.Create(COLON652);
            	        		adaptor.AddChild(root_0, COLON652_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_value_in_choice_value8247);
            	value653 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value653.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "choice_value"

    public class sequence_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "sequence_value"
    // Smi.g:1041:0: sequence_value : L_BRACE ( named_value )? ( COMMA named_value )* R_BRACE ;
    public SmiParser.sequence_value_return sequence_value() // throws RecognitionException [1]
    {   
        SmiParser.sequence_value_return retval = new SmiParser.sequence_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE654 = null;
        IToken COMMA656 = null;
        IToken R_BRACE658 = null;
        SmiParser.named_value_return named_value655 = default(SmiParser.named_value_return);

        SmiParser.named_value_return named_value657 = default(SmiParser.named_value_return);


        CommonTree L_BRACE654_tree=null;
        CommonTree COMMA656_tree=null;
        CommonTree R_BRACE658_tree=null;

        try 
    	{
            // Smi.g:1041:17: ( L_BRACE ( named_value )? ( COMMA named_value )* R_BRACE )
            // Smi.g:1041:17: L_BRACE ( named_value )? ( COMMA named_value )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE654=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_sequence_value8254); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE654_tree = (CommonTree)adaptor.Create(L_BRACE654);
            		adaptor.AddChild(root_0, L_BRACE654_tree);
            	}
            	// Smi.g:1041:25: ( named_value )?
            	int alt169 = 2;
            	int LA169_0 = input.LA(1);

            	if ( (LA169_0 == LOWER) )
            	{
            	    alt169 = 1;
            	}
            	switch (alt169) 
            	{
            	    case 1 :
            	        // Smi.g:1041:26: named_value
            	        {
            	        	PushFollow(FOLLOW_named_value_in_sequence_value8257);
            	        	named_value655 = named_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_value655.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1041:40: ( COMMA named_value )*
            	do 
            	{
            	    int alt170 = 2;
            	    int LA170_0 = input.LA(1);

            	    if ( (LA170_0 == COMMA) )
            	    {
            	        alt170 = 1;
            	    }


            	    switch (alt170) 
            		{
            			case 1 :
            			    // Smi.g:1041:41: COMMA named_value
            			    {
            			    	COMMA656=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_sequence_value8262); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA656_tree = (CommonTree)adaptor.Create(COMMA656);
            			    		adaptor.AddChild(root_0, COMMA656_tree);
            			    	}
            			    	PushFollow(FOLLOW_named_value_in_sequence_value8264);
            			    	named_value657 = named_value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_value657.Tree);

            			    }
            			    break;

            			default:
            			    goto loop170;
            	    }
            	} while (true);

            	loop170:
            		;	// Stops C# compiler whining that label 'loop170' has no statements

            	R_BRACE658=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_sequence_value8268); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE658_tree = (CommonTree)adaptor.Create(R_BRACE658);
            		adaptor.AddChild(root_0, R_BRACE658_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequence_value"

    public class sequenceof_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "sequenceof_value"
    // Smi.g:1043:0: sequenceof_value : L_BRACE ( value )? ( COMMA value )* R_BRACE ;
    public SmiParser.sequenceof_value_return sequenceof_value() // throws RecognitionException [1]
    {   
        SmiParser.sequenceof_value_return retval = new SmiParser.sequenceof_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE659 = null;
        IToken COMMA661 = null;
        IToken R_BRACE663 = null;
        SmiParser.value_return value660 = default(SmiParser.value_return);

        SmiParser.value_return value662 = default(SmiParser.value_return);


        CommonTree L_BRACE659_tree=null;
        CommonTree COMMA661_tree=null;
        CommonTree R_BRACE663_tree=null;

        try 
    	{
            // Smi.g:1043:19: ( L_BRACE ( value )? ( COMMA value )* R_BRACE )
            // Smi.g:1043:19: L_BRACE ( value )? ( COMMA value )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE659=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_sequenceof_value8275); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE659_tree = (CommonTree)adaptor.Create(L_BRACE659);
            		adaptor.AddChild(root_0, L_BRACE659_tree);
            	}
            	// Smi.g:1043:27: ( value )?
            	int alt171 = 2;
            	int LA171_0 = input.LA(1);

            	if ( (LA171_0 == B_STRING || LA171_0 == C_STRING || LA171_0 == FALSE_KW || LA171_0 == H_STRING || LA171_0 == L_BRACE || LA171_0 == LOWER || (LA171_0 >= MINUS && LA171_0 <= NUMBER) || LA171_0 == PLUS_INFINITY_KW || LA171_0 == TRUE_KW || LA171_0 == UPPER) )
            	{
            	    alt171 = 1;
            	}
            	switch (alt171) 
            	{
            	    case 1 :
            	        // Smi.g:1043:28: value
            	        {
            	        	PushFollow(FOLLOW_value_in_sequenceof_value8278);
            	        	value660 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value660.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1043:36: ( COMMA value )*
            	do 
            	{
            	    int alt172 = 2;
            	    int LA172_0 = input.LA(1);

            	    if ( (LA172_0 == COMMA) )
            	    {
            	        alt172 = 1;
            	    }


            	    switch (alt172) 
            		{
            			case 1 :
            			    // Smi.g:1043:37: COMMA value
            			    {
            			    	COMMA661=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_sequenceof_value8283); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA661_tree = (CommonTree)adaptor.Create(COMMA661);
            			    		adaptor.AddChild(root_0, COMMA661_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_sequenceof_value8285);
            			    	value662 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value662.Tree);

            			    }
            			    break;

            			default:
            			    goto loop172;
            	    }
            	} while (true);

            	loop172:
            		;	// Stops C# compiler whining that label 'loop172' has no statements

            	R_BRACE663=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_sequenceof_value8289); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE663_tree = (CommonTree)adaptor.Create(R_BRACE663);
            		adaptor.AddChild(root_0, R_BRACE663_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequenceof_value"

    public class cstr_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "cstr_value"
    // Smi.g:1045:0: cstr_value : (=> H_STRING |=> B_STRING | L_BRACE (=> id_list |=> char_defs_list | tuple_or_quad ) R_BRACE );
    public SmiParser.cstr_value_return cstr_value() // throws RecognitionException [1]
    {   
        SmiParser.cstr_value_return retval = new SmiParser.cstr_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken H_STRING664 = null;
        IToken B_STRING665 = null;
        IToken L_BRACE666 = null;
        IToken R_BRACE670 = null;
        SmiParser.id_list_return id_list667 = default(SmiParser.id_list_return);

        SmiParser.char_defs_list_return char_defs_list668 = default(SmiParser.char_defs_list_return);

        SmiParser.tuple_or_quad_return tuple_or_quad669 = default(SmiParser.tuple_or_quad_return);


        CommonTree H_STRING664_tree=null;
        CommonTree B_STRING665_tree=null;
        CommonTree L_BRACE666_tree=null;
        CommonTree R_BRACE670_tree=null;

        try 
    	{
            // Smi.g:1045:13: (=> H_STRING |=> B_STRING | L_BRACE (=> id_list |=> char_defs_list | tuple_or_quad ) R_BRACE )
            int alt174 = 3;
            int LA174_0 = input.LA(1);

            if ( (LA174_0 == H_STRING) && (synpred46_Smi()) )
            {
                alt174 = 1;
            }
            else if ( (LA174_0 == B_STRING) && (synpred47_Smi()) )
            {
                alt174 = 2;
            }
            else if ( (LA174_0 == L_BRACE) )
            {
                alt174 = 3;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d174s0 =
                    new NoViableAltException("", 174, 0, input);

                throw nvae_d174s0;
            }
            switch (alt174) 
            {
                case 1 :
                    // Smi.g:1045:13: => H_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	H_STRING664=(IToken)Match(input,H_STRING,FOLLOW_H_STRING_in_cstr_value8302); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{H_STRING664_tree = (CommonTree)adaptor.Create(H_STRING664);
                    		adaptor.AddChild(root_0, H_STRING664_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:1046:13: => B_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	B_STRING665=(IToken)Match(input,B_STRING,FOLLOW_B_STRING_in_cstr_value8323); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{B_STRING665_tree = (CommonTree)adaptor.Create(B_STRING665);
                    		adaptor.AddChild(root_0, B_STRING665_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:1047:13: L_BRACE (=> id_list |=> char_defs_list | tuple_or_quad ) R_BRACE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_BRACE666=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_cstr_value8338); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE666_tree = (CommonTree)adaptor.Create(L_BRACE666);
                    		adaptor.AddChild(root_0, L_BRACE666_tree);
                    	}
                    	// Smi.g:1048:13: (=> id_list |=> char_defs_list | tuple_or_quad )
                    	int alt173 = 3;
                    	int LA173_0 = input.LA(1);

                    	if ( (LA173_0 == LOWER) )
                    	{
                    	    int LA173_1 = input.LA(2);

                    	    if ( (synpred48_Smi()) )
                    	    {
                    	        alt173 = 1;
                    	    }
                    	    else if ( (synpred49_Smi()) )
                    	    {
                    	        alt173 = 2;
                    	    }
                    	    else 
                    	    {
                    	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	        NoViableAltException nvae_d173s1 =
                    	            new NoViableAltException("", 173, 1, input);

                    	        throw nvae_d173s1;
                    	    }
                    	}
                    	else if ( (LA173_0 == C_STRING) && (synpred49_Smi()) )
                    	{
                    	    alt173 = 2;
                    	}
                    	else if ( (LA173_0 == L_BRACE) && (synpred49_Smi()) )
                    	{
                    	    alt173 = 2;
                    	}
                    	else if ( (LA173_0 == UPPER) && (synpred49_Smi()) )
                    	{
                    	    alt173 = 2;
                    	}
                    	else if ( (LA173_0 == MINUS || LA173_0 == NUMBER) )
                    	{
                    	    alt173 = 3;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d173s0 =
                    	        new NoViableAltException("", 173, 0, input);

                    	    throw nvae_d173s0;
                    	}
                    	switch (alt173) 
                    	{
                    	    case 1 :
                    	        // Smi.g:1048:15: => id_list
                    	        {

                    	        	PushFollow(FOLLOW_id_list_in_cstr_value8361);
                    	        	id_list667 = id_list();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, id_list667.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:1049:17: => char_defs_list
                    	        {

                    	        	PushFollow(FOLLOW_char_defs_list_in_cstr_value8386);
                    	        	char_defs_list668 = char_defs_list();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_defs_list668.Tree);

                    	        }
                    	        break;
                    	    case 3 :
                    	        // Smi.g:1050:17: tuple_or_quad
                    	        {
                    	        	PushFollow(FOLLOW_tuple_or_quad_in_cstr_value8405);
                    	        	tuple_or_quad669 = tuple_or_quad();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tuple_or_quad669.Tree);

                    	        }
                    	        break;

                    	}

                    	R_BRACE670=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_cstr_value8421); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE670_tree = (CommonTree)adaptor.Create(R_BRACE670);
                    		adaptor.AddChild(root_0, R_BRACE670_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cstr_value"

    public class id_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "id_list"
    // Smi.g:1053:0: id_list : LOWER ( COMMA LOWER )* ;
    public SmiParser.id_list_return id_list() // throws RecognitionException [1]
    {   
        SmiParser.id_list_return retval = new SmiParser.id_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER671 = null;
        IToken COMMA672 = null;
        IToken LOWER673 = null;

        CommonTree LOWER671_tree=null;
        CommonTree COMMA672_tree=null;
        CommonTree LOWER673_tree=null;

        try 
    	{
            // Smi.g:1053:10: ( LOWER ( COMMA LOWER )* )
            // Smi.g:1053:10: LOWER ( COMMA LOWER )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER671=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_id_list8428); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER671_tree = (CommonTree)adaptor.Create(LOWER671);
            		adaptor.AddChild(root_0, LOWER671_tree);
            	}
            	// Smi.g:1053:16: ( COMMA LOWER )*
            	do 
            	{
            	    int alt175 = 2;
            	    int LA175_0 = input.LA(1);

            	    if ( (LA175_0 == COMMA) )
            	    {
            	        alt175 = 1;
            	    }


            	    switch (alt175) 
            		{
            			case 1 :
            			    // Smi.g:1053:17: COMMA LOWER
            			    {
            			    	COMMA672=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_id_list8431); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA672_tree = (CommonTree)adaptor.Create(COMMA672);
            			    		adaptor.AddChild(root_0, COMMA672_tree);
            			    	}
            			    	LOWER673=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_id_list8433); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LOWER673_tree = (CommonTree)adaptor.Create(LOWER673);
            			    		adaptor.AddChild(root_0, LOWER673_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop175;
            	    }
            	} while (true);

            	loop175:
            		;	// Stops C# compiler whining that label 'loop175' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "id_list"

    public class char_defs_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "char_defs_list"
    // Smi.g:1055:0: char_defs_list : char_defs ( COMMA char_defs )* ;
    public SmiParser.char_defs_list_return char_defs_list() // throws RecognitionException [1]
    {   
        SmiParser.char_defs_list_return retval = new SmiParser.char_defs_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA675 = null;
        SmiParser.char_defs_return char_defs674 = default(SmiParser.char_defs_return);

        SmiParser.char_defs_return char_defs676 = default(SmiParser.char_defs_return);


        CommonTree COMMA675_tree=null;

        try 
    	{
            // Smi.g:1055:17: ( char_defs ( COMMA char_defs )* )
            // Smi.g:1055:17: char_defs ( COMMA char_defs )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_char_defs_in_char_defs_list8443);
            	char_defs674 = char_defs();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_defs674.Tree);
            	// Smi.g:1055:27: ( COMMA char_defs )*
            	do 
            	{
            	    int alt176 = 2;
            	    int LA176_0 = input.LA(1);

            	    if ( (LA176_0 == COMMA) )
            	    {
            	        alt176 = 1;
            	    }


            	    switch (alt176) 
            		{
            			case 1 :
            			    // Smi.g:1055:28: COMMA char_defs
            			    {
            			    	COMMA675=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_char_defs_list8446); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA675_tree = (CommonTree)adaptor.Create(COMMA675);
            			    		adaptor.AddChild(root_0, COMMA675_tree);
            			    	}
            			    	PushFollow(FOLLOW_char_defs_in_char_defs_list8448);
            			    	char_defs676 = char_defs();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_defs676.Tree);

            			    }
            			    break;

            			default:
            			    goto loop176;
            	    }
            	} while (true);

            	loop176:
            		;	// Stops C# compiler whining that label 'loop176' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "char_defs_list"

    public class tuple_or_quad_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tuple_or_quad"
    // Smi.g:1058:0: tuple_or_quad : signed_number COMMA signed_number ( COMMA signed_number COMMA signed_number )? ;
    public SmiParser.tuple_or_quad_return tuple_or_quad() // throws RecognitionException [1]
    {   
        SmiParser.tuple_or_quad_return retval = new SmiParser.tuple_or_quad_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA678 = null;
        IToken COMMA680 = null;
        IToken COMMA682 = null;
        SmiParser.signed_number_return signed_number677 = default(SmiParser.signed_number_return);

        SmiParser.signed_number_return signed_number679 = default(SmiParser.signed_number_return);

        SmiParser.signed_number_return signed_number681 = default(SmiParser.signed_number_return);

        SmiParser.signed_number_return signed_number683 = default(SmiParser.signed_number_return);


        CommonTree COMMA678_tree=null;
        CommonTree COMMA680_tree=null;
        CommonTree COMMA682_tree=null;

        try 
    	{
            // Smi.g:1058:16: ( signed_number COMMA signed_number ( COMMA signed_number COMMA signed_number )? )
            // Smi.g:1058:16: signed_number COMMA signed_number ( COMMA signed_number COMMA signed_number )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8459);
            	signed_number677 = signed_number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number677.Tree);
            	COMMA678=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_tuple_or_quad8461); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{COMMA678_tree = (CommonTree)adaptor.Create(COMMA678);
            		adaptor.AddChild(root_0, COMMA678_tree);
            	}
            	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8463);
            	signed_number679 = signed_number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number679.Tree);
            	// Smi.g:1058:50: ( COMMA signed_number COMMA signed_number )?
            	int alt177 = 2;
            	int LA177_0 = input.LA(1);

            	if ( (LA177_0 == COMMA) )
            	{
            	    alt177 = 1;
            	}
            	switch (alt177) 
            	{
            	    case 1 :
            	        // Smi.g:1058:51: COMMA signed_number COMMA signed_number
            	        {
            	        	COMMA680=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_tuple_or_quad8466); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA680_tree = (CommonTree)adaptor.Create(COMMA680);
            	        		adaptor.AddChild(root_0, COMMA680_tree);
            	        	}
            	        	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8468);
            	        	signed_number681 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number681.Tree);
            	        	COMMA682=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_tuple_or_quad8470); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA682_tree = (CommonTree)adaptor.Create(COMMA682);
            	        		adaptor.AddChild(root_0, COMMA682_tree);
            	        	}
            	        	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8472);
            	        	signed_number683 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number683.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tuple_or_quad"

    public class char_defs_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "char_defs"
    // Smi.g:1061:0: char_defs : ( C_STRING | L_BRACE tuple_or_quad R_BRACE | defined_value );
    public SmiParser.char_defs_return char_defs() // throws RecognitionException [1]
    {   
        SmiParser.char_defs_return retval = new SmiParser.char_defs_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken C_STRING684 = null;
        IToken L_BRACE685 = null;
        IToken R_BRACE687 = null;
        SmiParser.tuple_or_quad_return tuple_or_quad686 = default(SmiParser.tuple_or_quad_return);

        SmiParser.defined_value_return defined_value688 = default(SmiParser.defined_value_return);


        CommonTree C_STRING684_tree=null;
        CommonTree L_BRACE685_tree=null;
        CommonTree R_BRACE687_tree=null;

        try 
    	{
            // Smi.g:1061:12: ( C_STRING | L_BRACE tuple_or_quad R_BRACE | defined_value )
            int alt178 = 3;
            switch ( input.LA(1) ) 
            {
            case C_STRING:
            	{
                alt178 = 1;
                }
                break;
            case L_BRACE:
            	{
                alt178 = 2;
                }
                break;
            case LOWER:
            case UPPER:
            	{
                alt178 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d178s0 =
            	        new NoViableAltException("", 178, 0, input);

            	    throw nvae_d178s0;
            }

            switch (alt178) 
            {
                case 1 :
                    // Smi.g:1061:12: C_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	C_STRING684=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_char_defs8483); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING684_tree = (CommonTree)adaptor.Create(C_STRING684);
                    		adaptor.AddChild(root_0, C_STRING684_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:1062:12: L_BRACE tuple_or_quad R_BRACE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_BRACE685=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_char_defs8497); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE685_tree = (CommonTree)adaptor.Create(L_BRACE685);
                    		adaptor.AddChild(root_0, L_BRACE685_tree);
                    	}
                    	PushFollow(FOLLOW_tuple_or_quad_in_char_defs8499);
                    	tuple_or_quad686 = tuple_or_quad();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tuple_or_quad686.Tree);
                    	R_BRACE687=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_char_defs8501); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE687_tree = (CommonTree)adaptor.Create(R_BRACE687);
                    		adaptor.AddChild(root_0, R_BRACE687_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:1063:12: defined_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defined_value_in_char_defs8514);
                    	defined_value688 = defined_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value688.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "char_defs"

    public class named_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "named_value"
    // Smi.g:1068:0: named_value : LOWER value ;
    public SmiParser.named_value_return named_value() // throws RecognitionException [1]
    {   
        SmiParser.named_value_return retval = new SmiParser.named_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER689 = null;
        SmiParser.value_return value690 = default(SmiParser.value_return);


        CommonTree LOWER689_tree=null;

        try 
    	{
            // Smi.g:1068:14: ( LOWER value )
            // Smi.g:1068:14: LOWER value
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER689=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_named_value8524); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER689_tree = (CommonTree)adaptor.Create(LOWER689);
            		adaptor.AddChild(root_0, LOWER689_tree);
            	}
            	PushFollow(FOLLOW_value_in_named_value8526);
            	value690 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value690.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "named_value"

    // $ANTLR start "synpred1_Smi"
    public void synpred1_Smi_fragment() {
        // Smi.g:610:27: ( LOWER ( LOWER | NUMBER ) )
        // Smi.g:610:28: LOWER ( LOWER | NUMBER )
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred1_Smi1976); if (state.failed) return ;
        	if ( input.LA(1) == LOWER || input.LA(1) == NUMBER ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred1_Smi"

    // $ANTLR start "synpred10_Smi"
    public void synpred10_Smi_fragment() {
        // Smi.g:666:8: ( sequence_value )
        // Smi.g:666:9: sequence_value
        {
        	PushFollow(FOLLOW_sequence_value_in_synpred10_Smi2602);
        	sequence_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_Smi"

    // $ANTLR start "synpred11_Smi"
    public void synpred11_Smi_fragment() {
        // Smi.g:667:8: ( sequenceof_value )
        // Smi.g:667:9: sequenceof_value
        {
        	PushFollow(FOLLOW_sequenceof_value_in_synpred11_Smi2618);
        	sequenceof_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_Smi"

    // $ANTLR start "synpred12_Smi"
    public void synpred12_Smi_fragment() {
        // Smi.g:668:8: ( cstr_value )
        // Smi.g:668:9: cstr_value
        {
        	PushFollow(FOLLOW_cstr_value_in_synpred12_Smi2634);
        	cstr_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_Smi"

    // $ANTLR start "synpred13_Smi"
    public void synpred13_Smi_fragment() {
        // Smi.g:669:8: ( obj_id_comp_lst )
        // Smi.g:669:9: obj_id_comp_lst
        {
        	PushFollow(FOLLOW_obj_id_comp_lst_in_synpred13_Smi2650);
        	obj_id_comp_lst();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred13_Smi"

    // $ANTLR start "synpred14_Smi"
    public void synpred14_Smi_fragment() {
        // Smi.g:670:8: ( PLUS_INFINITY_KW )
        // Smi.g:670:9: PLUS_INFINITY_KW
        {
        	Match(input,PLUS_INFINITY_KW,FOLLOW_PLUS_INFINITY_KW_in_synpred14_Smi2666); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_Smi"

    // $ANTLR start "synpred15_Smi"
    public void synpred15_Smi_fragment() {
        // Smi.g:671:8: ( MINUS_INFINITY_KW )
        // Smi.g:671:9: MINUS_INFINITY_KW
        {
        	Match(input,MINUS_INFINITY_KW,FOLLOW_MINUS_INFINITY_KW_in_synpred15_Smi2682); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_Smi"

    // $ANTLR start "synpred16_Smi"
    public void synpred16_Smi_fragment() {
        // Smi.g:700:36: ( L_BRACE namedNumber )
        // Smi.g:700:37: L_BRACE namedNumber
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred16_Smi2995); if (state.failed) return ;
        	PushFollow(FOLLOW_namedNumber_in_synpred16_Smi2997);
        	namedNumber();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred16_Smi"

    // $ANTLR start "synpred17_Smi"
    public void synpred17_Smi_fragment() {
        // Smi.g:716:27: ( L_BRACE namedNumber )
        // Smi.g:716:28: L_BRACE namedNumber
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred17_Smi3088); if (state.failed) return ;
        	PushFollow(FOLLOW_namedNumber_in_synpred17_Smi3090);
        	namedNumber();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_Smi"

    // $ANTLR start "synpred18_Smi"
    public void synpred18_Smi_fragment() {
        // Smi.g:760:44: ( LOWER )
        // Smi.g:760:45: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred18_Smi3448); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred18_Smi"

    // $ANTLR start "synpred19_Smi"
    public void synpred19_Smi_fragment() {
        // Smi.g:761:23: ( RESULT_KW )
        // Smi.g:761:24: RESULT_KW
        {
        	Match(input,RESULT_KW,FOLLOW_RESULT_KW_in_synpred19_Smi3486); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_Smi"

    // $ANTLR start "synpred2_Smi"
    public void synpred2_Smi_fragment() {
        // Smi.g:644:29: ( defined_value )
        // Smi.g:644:30: defined_value
        {
        	PushFollow(FOLLOW_defined_value_in_synpred2_Smi2274);
        	defined_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_Smi"

    // $ANTLR start "synpred20_Smi"
    public void synpred20_Smi_fragment() {
        // Smi.g:762:26: ( LOWER )
        // Smi.g:762:27: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred20_Smi3520); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred20_Smi"

    // $ANTLR start "synpred21_Smi"
    public void synpred21_Smi_fragment() {
        // Smi.g:762:38: ( LOWER )
        // Smi.g:762:39: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred21_Smi3527); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred21_Smi"

    // $ANTLR start "synpred22_Smi"
    public void synpred22_Smi_fragment() {
        // Smi.g:764:23: ( ERRORS_KW )
        // Smi.g:764:24: ERRORS_KW
        {
        	Match(input,ERRORS_KW,FOLLOW_ERRORS_KW_in_synpred22_Smi3573); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred22_Smi"

    // $ANTLR start "synpred23_Smi"
    public void synpred23_Smi_fragment() {
        // Smi.g:765:23: ( LINKED_KW )
        // Smi.g:765:24: LINKED_KW
        {
        	Match(input,LINKED_KW,FOLLOW_LINKED_KW_in_synpred23_Smi3616); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred23_Smi"

    // $ANTLR start "synpred24_Smi"
    public void synpred24_Smi_fragment() {
        // Smi.g:775:39: ( LOWER )
        // Smi.g:775:40: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred24_Smi3658); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred24_Smi"

    // $ANTLR start "synpred25_Smi"
    public void synpred25_Smi_fragment() {
        // Smi.g:806:23: ( smi_type L_BRACE )
        // Smi.g:806:24: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred25_Smi3988);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred25_Smi3990); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred25_Smi"

    // $ANTLR start "synpred26_Smi"
    public void synpred26_Smi_fragment() {
        // Smi.g:807:24: ( smi_type )
        // Smi.g:807:25: smi_type
        {
        	PushFollow(FOLLOW_smi_type_in_synpred26_Smi4024);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred26_Smi"

    // $ANTLR start "synpred27_Smi"
    public void synpred27_Smi_fragment() {
        // Smi.g:816:21: ( 'DESCRIPTION' )
        // Smi.g:816:22: 'DESCRIPTION'
        {
        	Match(input,141,FOLLOW_141_in_synpred27_Smi4328); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred27_Smi"

    // $ANTLR start "synpred28_Smi"
    public void synpred28_Smi_fragment() {
        // Smi.g:819:7: (~ ( 'PIB-INDEX' ) )
        // Smi.g:
        {
        	if ( (input.LA(1) >= ABSENT_KW && input.LA(1) <= 169) || (input.LA(1) >= 171 && input.LA(1) <= 197) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred28_Smi"

    // $ANTLR start "synpred29_Smi"
    public void synpred29_Smi_fragment() {
        // Smi.g:826:7: ( 'DEFVAL' )
        // Smi.g:826:8: 'DEFVAL'
        {
        	Match(input,140,FOLLOW_140_in_synpred29_Smi4724); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred29_Smi"

    // $ANTLR start "synpred3_Smi"
    public void synpred3_Smi_fragment() {
        // Smi.g:659:8: ( TRUE_KW )
        // Smi.g:659:9: TRUE_KW
        {
        	Match(input,TRUE_KW,FOLLOW_TRUE_KW_in_synpred3_Smi2490); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_Smi"

    // $ANTLR start "synpred30_Smi"
    public void synpred30_Smi_fragment() {
        // Smi.g:827:23: ( L_BRACE LOWER ( COMMA | R_BRACE ) )
        // Smi.g:827:24: L_BRACE LOWER ( COMMA | R_BRACE )
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred30_Smi4757); if (state.failed) return ;
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred30_Smi4759); if (state.failed) return ;
        	if ( input.LA(1) == COMMA || input.LA(1) == R_BRACE ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred30_Smi"

    // $ANTLR start "synpred31_Smi"
    public void synpred31_Smi_fragment() {
        // Smi.g:891:40: ( smi_type L_BRACE )
        // Smi.g:891:41: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred31_Smi5679);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred31_Smi5681); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_Smi"

    // $ANTLR start "synpred32_Smi"
    public void synpred32_Smi_fragment() {
        // Smi.g:926:42: ( UPPER )
        // Smi.g:926:43: UPPER
        {
        	Match(input,UPPER,FOLLOW_UPPER_in_synpred32_Smi6157); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_Smi"

    // $ANTLR start "synpred33_Smi"
    public void synpred33_Smi_fragment() {
        // Smi.g:926:60: ( value )
        // Smi.g:926:61: value
        {
        	PushFollow(FOLLOW_value_in_synpred33_Smi6166);
        	value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_Smi"

    // $ANTLR start "synpred34_Smi"
    public void synpred34_Smi_fragment() {
        // Smi.g:936:32: ( smi_type L_BRACE )
        // Smi.g:936:33: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred34_Smi6549);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred34_Smi6551); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_Smi"

    // $ANTLR start "synpred35_Smi"
    public void synpred35_Smi_fragment() {
        // Smi.g:937:32: ( smi_type )
        // Smi.g:937:33: smi_type
        {
        	PushFollow(FOLLOW_smi_type_in_synpred35_Smi6603);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred35_Smi"

    // $ANTLR start "synpred36_Smi"
    public void synpred36_Smi_fragment() {
        // Smi.g:967:56: ( L_BRACE ( LOWER | COMMA | R_BRACE ) )
        // Smi.g:967:57: L_BRACE ( LOWER | COMMA | R_BRACE )
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred36_Smi7095); if (state.failed) return ;
        	if ( input.LA(1) == COMMA || input.LA(1) == LOWER || input.LA(1) == R_BRACE ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred36_Smi"

    // $ANTLR start "synpred37_Smi"
    public void synpred37_Smi_fragment() {
        // Smi.g:969:33: ( smi_type L_BRACE )
        // Smi.g:969:34: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred37_Smi7182);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred37_Smi7184); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred37_Smi"

    // $ANTLR start "synpred38_Smi"
    public void synpred38_Smi_fragment() {
        // Smi.g:971:33: ( smi_type )
        // Smi.g:971:34: smi_type
        {
        	PushFollow(FOLLOW_smi_type_in_synpred38_Smi7274);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_Smi"

    // $ANTLR start "synpred39_Smi"
    public void synpred39_Smi_fragment() {
        // Smi.g:986:22: ( 'DESCRIPTION' )
        // Smi.g:986:23: 'DESCRIPTION'
        {
        	Match(input,141,FOLLOW_141_in_synpred39_Smi7438); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred39_Smi"

    // $ANTLR start "synpred4_Smi"
    public void synpred4_Smi_fragment() {
        // Smi.g:660:8: ( FALSE_KW )
        // Smi.g:660:9: FALSE_KW
        {
        	Match(input,FALSE_KW,FOLLOW_FALSE_KW_in_synpred4_Smi2506); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_Smi"

    // $ANTLR start "synpred40_Smi"
    public void synpred40_Smi_fragment() {
        // Smi.g:992:14: ( type )
        // Smi.g:992:15: type
        {
        	PushFollow(FOLLOW_type_in_synpred40_Smi7493);
        	type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred40_Smi"

    // $ANTLR start "synpred41_Smi"
    public void synpred41_Smi_fragment() {
        // Smi.g:998:22: ( L_BRACKET ( NUMBER | UPPER | LOWER ) )
        // Smi.g:998:23: L_BRACKET ( NUMBER | UPPER | LOWER )
        {
        	Match(input,L_BRACKET,FOLLOW_L_BRACKET_in_synpred41_Smi7532); if (state.failed) return ;
        	if ( input.LA(1) == LOWER || input.LA(1) == NUMBER || input.LA(1) == UPPER ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred41_Smi"

    // $ANTLR start "synpred42_Smi"
    public void synpred42_Smi_fragment() {
        // Smi.g:1011:19: ( signed_number )
        // Smi.g:1011:20: signed_number
        {
        	PushFollow(FOLLOW_signed_number_in_synpred42_Smi7690);
        	signed_number();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred42_Smi"

    // $ANTLR start "synpred43_Smi"
    public void synpred43_Smi_fragment() {
        // Smi.g:1012:21: ( defined_value )
        // Smi.g:1012:22: defined_value
        {
        	PushFollow(FOLLOW_defined_value_in_synpred43_Smi7719);
        	defined_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred43_Smi"

    // $ANTLR start "synpred44_Smi"
    public void synpred44_Smi_fragment() {
        // Smi.g:1022:22: ( value_range )
        // Smi.g:1022:23: value_range
        {
        	PushFollow(FOLLOW_value_range_in_synpred44_Smi7878);
        	value_range();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred44_Smi"

    // $ANTLR start "synpred45_Smi"
    public void synpred45_Smi_fragment() {
        // Smi.g:1023:22: ( value )
        // Smi.g:1023:23: value
        {
        	PushFollow(FOLLOW_value_in_synpred45_Smi7907);
        	value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred45_Smi"

    // $ANTLR start "synpred46_Smi"
    public void synpred46_Smi_fragment() {
        // Smi.g:1045:13: ( H_STRING )
        // Smi.g:1045:14: H_STRING
        {
        	Match(input,H_STRING,FOLLOW_H_STRING_in_synpred46_Smi8297); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred46_Smi"

    // $ANTLR start "synpred47_Smi"
    public void synpred47_Smi_fragment() {
        // Smi.g:1046:13: ( B_STRING )
        // Smi.g:1046:14: B_STRING
        {
        	Match(input,B_STRING,FOLLOW_B_STRING_in_synpred47_Smi8318); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred47_Smi"

    // $ANTLR start "synpred48_Smi"
    public void synpred48_Smi_fragment() {
        // Smi.g:1048:15: ( id_list )
        // Smi.g:1048:16: id_list
        {
        	PushFollow(FOLLOW_id_list_in_synpred48_Smi8356);
        	id_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred48_Smi"

    // $ANTLR start "synpred49_Smi"
    public void synpred49_Smi_fragment() {
        // Smi.g:1049:17: ( char_defs_list )
        // Smi.g:1049:18: char_defs_list
        {
        	PushFollow(FOLLOW_char_defs_list_in_synpred49_Smi8381);
        	char_defs_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_Smi"

    // $ANTLR start "synpred5_Smi"
    public void synpred5_Smi_fragment() {
        // Smi.g:661:8: ( NULL_KW )
        // Smi.g:661:9: NULL_KW
        {
        	Match(input,NULL_KW,FOLLOW_NULL_KW_in_synpred5_Smi2522); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_Smi"

    // $ANTLR start "synpred6_Smi"
    public void synpred6_Smi_fragment() {
        // Smi.g:662:8: ( C_STRING )
        // Smi.g:662:9: C_STRING
        {
        	Match(input,C_STRING,FOLLOW_C_STRING_in_synpred6_Smi2539); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_Smi"

    // $ANTLR start "synpred7_Smi"
    public void synpred7_Smi_fragment() {
        // Smi.g:663:8: ( defined_value )
        // Smi.g:663:9: defined_value
        {
        	PushFollow(FOLLOW_defined_value_in_synpred7_Smi2555);
        	defined_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_Smi"

    // $ANTLR start "synpred8_Smi"
    public void synpred8_Smi_fragment() {
        // Smi.g:664:8: ( signed_number )
        // Smi.g:664:9: signed_number
        {
        	PushFollow(FOLLOW_signed_number_in_synpred8_Smi2571);
        	signed_number();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_Smi"

    // $ANTLR start "synpred9_Smi"
    public void synpred9_Smi_fragment() {
        // Smi.g:665:8: ( choice_value )
        // Smi.g:665:9: choice_value
        {
        	PushFollow(FOLLOW_choice_value_in_synpred9_Smi2586);
        	choice_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_Smi"

    // Delegated rules

   	public bool synpred1_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred2_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred7_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred9_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred10_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred11_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred11_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred12_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred13_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred13_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred3_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred4_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred5_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred6_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred8_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred14_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred14_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred15_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred16_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred16_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred17_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred18_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred18_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred21_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred21_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred20_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred20_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred19_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred19_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred22_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred22_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred23_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred23_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred24_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred24_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred26_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred26_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred25_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred25_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred27_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred27_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred28_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred28_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred30_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred30_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred29_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred29_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred31_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred31_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred33_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred33_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred32_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred32_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred35_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred35_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred34_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred34_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred36_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred36_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred38_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred38_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred37_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred37_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred39_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred39_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred40_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred40_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred41_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred41_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred42_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred42_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred43_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred43_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred45_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred45_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred44_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred44_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred48_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred48_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred49_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred49_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred46_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred46_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred47_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred47_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA20 dfa20;
   	protected DFA23 dfa23;
   	protected DFA24 dfa24;
   	protected DFA25 dfa25;
   	protected DFA46 dfa46;
   	protected DFA49 dfa49;
   	protected DFA48 dfa48;
   	protected DFA55 dfa55;
   	protected DFA66 dfa66;
   	protected DFA75 dfa75;
   	protected DFA81 dfa81;
   	protected DFA80 dfa80;
   	protected DFA97 dfa97;
   	protected DFA106 dfa106;
   	protected DFA105 dfa105;
   	protected DFA117 dfa117;
   	protected DFA130 dfa130;
   	protected DFA134 dfa134;
   	protected DFA137 dfa137;
   	protected DFA141 dfa141;
   	protected DFA143 dfa143;
   	protected DFA160 dfa160;
	private void InitializeCyclicDFAs()
	{
    	this.dfa20 = new DFA20(this);
    	this.dfa23 = new DFA23(this);
    	this.dfa24 = new DFA24(this);
    	this.dfa25 = new DFA25(this);
    	this.dfa46 = new DFA46(this);
    	this.dfa49 = new DFA49(this);
    	this.dfa48 = new DFA48(this);
    	this.dfa55 = new DFA55(this);
    	this.dfa66 = new DFA66(this);
    	this.dfa75 = new DFA75(this);
    	this.dfa81 = new DFA81(this);
    	this.dfa80 = new DFA80(this);
    	this.dfa97 = new DFA97(this);
    	this.dfa106 = new DFA106(this);
    	this.dfa105 = new DFA105(this);
    	this.dfa117 = new DFA117(this);
    	this.dfa130 = new DFA130(this);
    	this.dfa134 = new DFA134(this);
    	this.dfa137 = new DFA137(this);
    	this.dfa141 = new DFA141(this);
    	this.dfa143 = new DFA143(this);
    	this.dfa160 = new DFA160(this);
	    this.dfa20.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA20_SpecialStateTransition);

	    this.dfa24.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA24_SpecialStateTransition);

	    this.dfa46.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA46_SpecialStateTransition);
	    this.dfa49.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA49_SpecialStateTransition);
	    this.dfa48.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA48_SpecialStateTransition);
	    this.dfa55.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA55_SpecialStateTransition);
	    this.dfa66.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA66_SpecialStateTransition);
	    this.dfa75.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA75_SpecialStateTransition);
	    this.dfa81.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA81_SpecialStateTransition);
	    this.dfa80.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA80_SpecialStateTransition);
	    this.dfa97.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA97_SpecialStateTransition);
	    this.dfa106.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA106_SpecialStateTransition);
	    this.dfa105.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA105_SpecialStateTransition);
	    this.dfa117.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA117_SpecialStateTransition);
	    this.dfa130.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA130_SpecialStateTransition);
	    this.dfa134.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA134_SpecialStateTransition);
	    this.dfa137.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA137_SpecialStateTransition);
	    this.dfa141.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA141_SpecialStateTransition);
	    this.dfa143.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA143_SpecialStateTransition);
	    this.dfa160.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA160_SpecialStateTransition);
	}

    const string DFA20_eotS =
        "\x22\xFFFF";
    const string DFA20_eofS =
        "\x22\xFFFF";
    const string DFA20_minS =
        "\x1\x2B\x1\xFFFF\x2\x1D\x1E\xFFFF";
    const string DFA20_maxS =
        "\x1\xC0\x1\xFFFF\x1\x34\x1\xC0\x1E\xFFFF";
    const string DFA20_acceptS =
        "\x1\xFFFF\x1\x1\x2\xFFFF\x1\x3\x1D\x2";
    const string DFA20_specialS =
        "\x2\xFFFF\x1\x0\x1\x1\x1E\xFFFF}>";
    static readonly string[] DFA20_transitionS = {
            "\x1\x4\x19\xFFFF\x1\x1\x4\xFFFF\x1\x3\x8\xFFFF\x1\x4\x3\xFFFF"+
            "\x1\x4\xF\xFFFF\x1\x4\xF\xFFFF\x1\x2\x6\xFFFF\x4\x4\x1\xFFFF"+
            "\x4\x4\x1\xFFFF\x1\x4\x6\xFFFF\x1\x4\x2\xFFFF\x3\x4\x9\xFFFF"+
            "\x3\x4\x1\xFFFF\x3\x4\x1\xFFFF\x1\x4\x7\xFFFF\x1\x4\x1\xFFFF"+
            "\x1\x4\x1\xFFFF\x1\x4\x2\xFFFF\x3\x4\x4\xFFFF\x5\x4",
            "",
            "\x1\x4\x7\xFFFF\x1\x5\xE\xFFFF\x1\x4",
            "\x1\x4\xD\xFFFF\x1\xA\x8\xFFFF\x1\x4\x15\xFFFF\x1\x8\x8\xFFFF"+
            "\x1\x15\x3\xFFFF\x1\x9\xF\xFFFF\x1\x6\xF\xFFFF\x1\x7\x6\xFFFF"+
            "\x1\x18\x1\x1B\x1\x1A\x1\x19\x1\xFFFF\x1\x21\x1\x1C\x1\xE\x1"+
            "\xD\x1\xFFFF\x1\xB\x6\xFFFF\x1\x1D\x2\xFFFF\x1\xF\x1\x11\x1"+
            "\x10\x9\xFFFF\x3\x21\x1\xFFFF\x3\x21\x1\xFFFF\x1\x21\x7\xFFFF"+
            "\x1\x16\x1\xFFFF\x1\x20\x1\xFFFF\x1\x17\x2\xFFFF\x1\x14\x1\x1F"+
            "\x1\x1E\x4\xFFFF\x1\x21\x1\x12\x1\x13\x1\x21\x1\xC",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA20_eot = DFA.UnpackEncodedString(DFA20_eotS);
    static readonly short[] DFA20_eof = DFA.UnpackEncodedString(DFA20_eofS);
    static readonly char[] DFA20_min = DFA.UnpackEncodedStringToUnsignedChars(DFA20_minS);
    static readonly char[] DFA20_max = DFA.UnpackEncodedStringToUnsignedChars(DFA20_maxS);
    static readonly short[] DFA20_accept = DFA.UnpackEncodedString(DFA20_acceptS);
    static readonly short[] DFA20_special = DFA.UnpackEncodedString(DFA20_specialS);
    static readonly short[][] DFA20_transition = DFA.UnpackEncodedStringArray(DFA20_transitionS);

    protected class DFA20 : DFA
    {
        public DFA20(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 20;
            this.eot = DFA20_eot;
            this.eof = DFA20_eof;
            this.min = DFA20_min;
            this.max = DFA20_max;
            this.accept = DFA20_accept;
            this.special = DFA20_special;
            this.transition = DFA20_transition;

        }

        override public string Description
        {
            get { return "643:25: ( obj_id_comp_lst |=> defined_value )?"; }
        }

    }


    protected internal int DFA20_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA20_2 = input.LA(1);

                   	 
                   	int index20_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA20_2 == DOT) && (synpred2_Smi()) ) { s = 5; }

                   	else if ( (LA20_2 == COMMA || LA20_2 == FROM_KW) ) { s = 4; }

                   	 
                   	input.Seek(index20_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA20_3 = input.LA(1);

                   	 
                   	int index20_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA20_3 == SEMI) && (synpred2_Smi()) ) { s = 6; }

                   	else if ( (LA20_3 == UPPER) && (synpred2_Smi()) ) { s = 7; }

                   	else if ( (LA20_3 == LOWER) && (synpred2_Smi()) ) { s = 8; }

                   	else if ( (LA20_3 == OPERATION_KW) && (synpred2_Smi()) ) { s = 9; }

                   	else if ( (LA20_3 == ERROR_KW) && (synpred2_Smi()) ) { s = 10; }

                   	else if ( (LA20_3 == 136) && (synpred2_Smi()) ) { s = 11; }

                   	else if ( (LA20_3 == 192) && (synpred2_Smi()) ) { s = 12; }

                   	else if ( (LA20_3 == 134) && (synpred2_Smi()) ) { s = 13; }

                   	else if ( (LA20_3 == 133) && (synpred2_Smi()) ) { s = 14; }

                   	else if ( (LA20_3 == 146) && (synpred2_Smi()) ) { s = 15; }

                   	else if ( (LA20_3 == 148) && (synpred2_Smi()) ) { s = 16; }

                   	else if ( (LA20_3 == 147) && (synpred2_Smi()) ) { s = 17; }

                   	else if ( (LA20_3 == 189) && (synpred2_Smi()) ) { s = 18; }

                   	else if ( (LA20_3 == 190) && (synpred2_Smi()) ) { s = 19; }

                   	else if ( (LA20_3 == 181) && (synpred2_Smi()) ) { s = 20; }

                   	else if ( (LA20_3 == OBJECT_KW) && (synpred2_Smi()) ) { s = 21; }

                   	else if ( (LA20_3 == 174) && (synpred2_Smi()) ) { s = 22; }

                   	else if ( (LA20_3 == 178) && (synpred2_Smi()) ) { s = 23; }

                   	else if ( (LA20_3 == 126) && (synpred2_Smi()) ) { s = 24; }

                   	else if ( (LA20_3 == 129) && (synpred2_Smi()) ) { s = 25; }

                   	else if ( (LA20_3 == 128) && (synpred2_Smi()) ) { s = 26; }

                   	else if ( (LA20_3 == 127) && (synpred2_Smi()) ) { s = 27; }

                   	else if ( (LA20_3 == 132) && (synpred2_Smi()) ) { s = 28; }

                   	else if ( (LA20_3 == 143) && (synpred2_Smi()) ) { s = 29; }

                   	else if ( (LA20_3 == 183) && (synpred2_Smi()) ) { s = 30; }

                   	else if ( (LA20_3 == 182) && (synpred2_Smi()) ) { s = 31; }

                   	else if ( (LA20_3 == 176) && (synpred2_Smi()) ) { s = 32; }

                   	else if ( (LA20_3 == 131 || (LA20_3 >= 158 && LA20_3 <= 160) || (LA20_3 >= 162 && LA20_3 <= 164) || LA20_3 == 166 || LA20_3 == 188 || LA20_3 == 191) && (synpred2_Smi()) ) { s = 33; }

                   	else if ( (LA20_3 == COMMA || LA20_3 == FROM_KW) ) { s = 4; }

                   	 
                   	input.Seek(index20_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae20 =
            new NoViableAltException(dfa.Description, 20, _s, input);
        dfa.Error(nvae20);
        throw nvae20;
    }
    const string DFA23_eotS =
        "\xB\xFFFF";
    const string DFA23_eofS =
        "\xB\xFFFF";
    const string DFA23_minS =
        "\x1\x7\x2\xFFFF\x1\x3B\x1\x6D\x6\xFFFF";
    const string DFA23_maxS =
        "\x1\xBF\x2\xFFFF\x1\x3B\x1\x6D\x6\xFFFF";
    const string DFA23_acceptS =
        "\x1\xFFFF\x2\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x1\x5\x2\x1";
    const string DFA23_specialS =
        "\xB\xFFFF}>";
    static readonly string[] DFA23_transitionS = {
            "\x1\x1\xA\xFFFF\x3\x1\x2\xFFFF\x1\x1\x2\xFFFF\x1\x1\xD\xFFFF"+
            "\x1\x1\x1\xFFFF\x1\x1\x1\x7\x6\xFFFF\x1\x1\x2\xFFFF\x3\x1\x2"+
            "\xFFFF\x1\x1\x6\xFFFF\x1\x2\x2\xFFFF\x1\x1\x1\xFFFF\x1\x2\x3"+
            "\xFFFF\x1\x6\x4\xFFFF\x1\x2\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1"+
            "\x4\x2\xFFFF\x1\x7\x7\xFFFF\x1\x1\x4\xFFFF\x1\x2\x3\xFFFF\x2"+
            "\x2\x4\xFFFF\x1\x1\x1\xFFFF\x1\x1\x5\xFFFF\x1\x1\x1\x5\x4\x1"+
            "\x7\xFFFF\x1\x7\x5\xFFFF\x1\x8\x14\xFFFF\x3\x7\x1\xFFFF\x3\x7"+
            "\x1\xFFFF\x1\x7\xC\xFFFF\x1\x2\x8\xFFFF\x1\x7\x2\xFFFF\x1\x7",
            "",
            "",
            "\x1\x9",
            "\x1\xA",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA23_eot = DFA.UnpackEncodedString(DFA23_eotS);
    static readonly short[] DFA23_eof = DFA.UnpackEncodedString(DFA23_eofS);
    static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars(DFA23_minS);
    static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars(DFA23_maxS);
    static readonly short[] DFA23_accept = DFA.UnpackEncodedString(DFA23_acceptS);
    static readonly short[] DFA23_special = DFA.UnpackEncodedString(DFA23_specialS);
    static readonly short[][] DFA23_transition = DFA.UnpackEncodedStringArray(DFA23_transitionS);

    protected class DFA23 : DFA
    {
        public DFA23(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;

        }

        override public string Description
        {
            get { return "657:0: type : ( built_in_type | defined_type | selection_type | macros_type | smi_type );"; }
        }

    }

    const string DFA24_eotS =
        "\x12\xFFFF";
    const string DFA24_eofS =
        "\x12\xFFFF";
    const string DFA24_minS =
        "\x1\xD\x5\xFFFF\x1\x0\x2\xFFFF\x1\x0\x8\xFFFF";
    const string DFA24_maxS =
        "\x1\x77\x5\xFFFF\x1\x0\x2\xFFFF\x1\x0\x8\xFFFF";
    const string DFA24_acceptS =
        "\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\xFFFF\x2\x6\x1\xFFFF"+
        "\x2\xA\x1\xC\x1\xD\x1\x7\x1\x8\x1\x9\x1\xB";
    const string DFA24_specialS =
        "\x1\x0\x5\xFFFF\x1\x1\x2\xFFFF\x1\x2\x8\xFFFF}>";
    static readonly string[] DFA24_transitionS = {
            "\x1\xB\x8\xFFFF\x1\x4\x1C\xFFFF\x1\x2\x4\xFFFF\x1\xA\xC\xFFFF"+
            "\x1\x9\x4\xFFFF\x1\x6\x2\xFFFF\x1\x7\x1\xD\x1\x3\x1\x8\xC\xFFFF"+
            "\x1\xC\x13\xFFFF\x1\x1\x5\xFFFF\x1\x5",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA24_eot = DFA.UnpackEncodedString(DFA24_eotS);
    static readonly short[] DFA24_eof = DFA.UnpackEncodedString(DFA24_eofS);
    static readonly char[] DFA24_min = DFA.UnpackEncodedStringToUnsignedChars(DFA24_minS);
    static readonly char[] DFA24_max = DFA.UnpackEncodedStringToUnsignedChars(DFA24_maxS);
    static readonly short[] DFA24_accept = DFA.UnpackEncodedString(DFA24_acceptS);
    static readonly short[] DFA24_special = DFA.UnpackEncodedString(DFA24_specialS);
    static readonly short[][] DFA24_transition = DFA.UnpackEncodedStringArray(DFA24_transitionS);

    protected class DFA24 : DFA
    {
        public DFA24(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 24;
            this.eot = DFA24_eot;
            this.eof = DFA24_eof;
            this.min = DFA24_min;
            this.max = DFA24_max;
            this.accept = DFA24_accept;
            this.special = DFA24_special;
            this.transition = DFA24_transition;

        }

        override public string Description
        {
            get { return "659:0: value : (=> TRUE_KW |=> FALSE_KW |=> NULL_KW |=> C_STRING |=> defined_value |=> signed_number |=> choice_value |=> sequence_value |=> sequenceof_value |=> cstr_value |=> obj_id_comp_lst |=> PLUS_INFINITY_KW |=> MINUS_INFINITY_KW );"; }
        }

    }


    protected internal int DFA24_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA24_0 = input.LA(1);

                   	 
                   	int index24_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_0 == TRUE_KW) && (synpred3_Smi()) ) { s = 1; }

                   	else if ( (LA24_0 == FALSE_KW) && (synpred4_Smi()) ) { s = 2; }

                   	else if ( (LA24_0 == NULL_KW) && (synpred5_Smi()) ) { s = 3; }

                   	else if ( (LA24_0 == C_STRING) && (synpred6_Smi()) ) { s = 4; }

                   	else if ( (LA24_0 == UPPER) && (synpred7_Smi()) ) { s = 5; }

                   	else if ( (LA24_0 == LOWER) ) { s = 6; }

                   	else if ( (LA24_0 == MINUS) && (synpred8_Smi()) ) { s = 7; }

                   	else if ( (LA24_0 == NUMBER) && (synpred8_Smi()) ) { s = 8; }

                   	else if ( (LA24_0 == L_BRACE) ) { s = 9; }

                   	else if ( (LA24_0 == H_STRING) && (synpred12_Smi()) ) { s = 10; }

                   	else if ( (LA24_0 == B_STRING) && (synpred12_Smi()) ) { s = 11; }

                   	else if ( (LA24_0 == PLUS_INFINITY_KW) && (synpred14_Smi()) ) { s = 12; }

                   	else if ( (LA24_0 == MINUS_INFINITY_KW) && (synpred15_Smi()) ) { s = 13; }

                   	 
                   	input.Seek(index24_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA24_6 = input.LA(1);

                   	 
                   	int index24_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Smi()) ) { s = 5; }

                   	else if ( (synpred9_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index24_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA24_9 = input.LA(1);

                   	 
                   	int index24_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Smi()) ) { s = 15; }

                   	else if ( (synpred11_Smi()) ) { s = 16; }

                   	else if ( (synpred12_Smi()) ) { s = 11; }

                   	else if ( (synpred13_Smi()) ) { s = 17; }

                   	 
                   	input.Seek(index24_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae24 =
            new NoViableAltException(dfa.Description, 24, _s, input);
        dfa.Error(nvae24);
        throw nvae24;
    }
    const string DFA25_eotS =
        "\x16\xFFFF";
    const string DFA25_eofS =
        "\x16\xFFFF";
    const string DFA25_minS =
        "\x1\x7\xE\xFFFF\x2\x45\x5\xFFFF";
    const string DFA25_maxS =
        "\x1\xB3\xE\xFFFF\x2\x6B\x5\xFFFF";
    const string DFA25_acceptS =
        "\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
        "\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x2\xFFFF\x1\x13\x1\xF\x1\x10\x1\x11"+
        "\x1\x12";
    const string DFA25_specialS =
        "\x16\xFFFF}>";
    static readonly string[] DFA25_transitionS = {
            "\x1\x1\xA\xFFFF\x1\x2\x1\x4\x1\x3\x2\xFFFF\x1\x4\x2\xFFFF\x1"+
            "\x5\xD\xFFFF\x1\x6\x1\xFFFF\x1\x7\x7\xFFFF\x1\x8\x2\xFFFF\x3"+
            "\x4\x2\xFFFF\x1\x4\x6\xFFFF\x1\x9\x2\xFFFF\x1\x4\x1\xFFFF\x1"+
            "\x11\x8\xFFFF\x1\xA\x1\xFFFF\x1\x4\x1\xFFFF\x1\xB\x1\xC\xA\xFFFF"+
            "\x1\x4\x4\xFFFF\x1\xD\x3\xFFFF\x1\xF\x1\x10\x4\xFFFF\x1\x4\x1"+
            "\xFFFF\x1\x4\x5\xFFFF\x1\x4\x1\xFFFF\x4\x4\x37\xFFFF\x1\xE",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x12\xF\xFFFF\x1\x13\x15\xFFFF\x1\x13",
            "\x1\x14\xF\xFFFF\x1\x15\x15\xFFFF\x1\x15",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA25_eot = DFA.UnpackEncodedString(DFA25_eotS);
    static readonly short[] DFA25_eof = DFA.UnpackEncodedString(DFA25_eofS);
    static readonly char[] DFA25_min = DFA.UnpackEncodedStringToUnsignedChars(DFA25_minS);
    static readonly char[] DFA25_max = DFA.UnpackEncodedStringToUnsignedChars(DFA25_maxS);
    static readonly short[] DFA25_accept = DFA.UnpackEncodedString(DFA25_acceptS);
    static readonly short[] DFA25_special = DFA.UnpackEncodedString(DFA25_specialS);
    static readonly short[][] DFA25_transition = DFA.UnpackEncodedStringArray(DFA25_transitionS);

    protected class DFA25 : DFA
    {
        public DFA25(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 25;
            this.eot = DFA25_eot;
            this.eof = DFA25_eof;
            this.min = DFA25_min;
            this.max = DFA25_max;
            this.accept = DFA25_accept;
            this.special = DFA25_special;
            this.transition = DFA25_transition;

        }

        override public string Description
        {
            get { return "673:0: built_in_type : ( any_type | bit_string_type | boolean_type | character_str_type | choice_type | embedded_type EMBEDDED_KW PDV_KW | enum_type | external_type | integer_type | null_type | object_identifier_type | octetString_type | real_type | relativeOid_type | sequence_type | sequenceof_type | set_type | setof_type | tagged_type );"; }
        }

    }

    const string DFA46_eotS =
        "\x24\xFFFF";
    const string DFA46_eofS =
        "\x24\xFFFF";
    const string DFA46_minS =
        "\x2\x7\x22\xFFFF";
    const string DFA46_maxS =
        "\x2\xBF\x22\xFFFF";
    const string DFA46_acceptS =
        "\x2\xFFFF\x1\x2\x21\x1";
    const string DFA46_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA46_transitionS = {
            "\x1\x2\xA\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\xD\xFFFF"+
            "\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF"+
            "\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x3\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF"+
            "\x1\x2\x7\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF"+
            "\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\xA\xFFFF\x1\x4\x1\x7\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1"+
            "\x8\xD\xFFFF\x1\x9\x1\xFFFF\x1\xA\x1\x18\x6\xFFFF\x1\xB\x2\xFFFF"+
            "\x3\x7\x2\xFFFF\x1\x7\x6\xFFFF\x1\xC\x2\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x14\x1\xFFFF\x1\x2\x1\xFFFF\x1\x16\x4\xFFFF\x1\xD\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\xE\x1\xF\x2\xFFFF\x1\x17\x7\xFFFF\x1\x7\x4"+
            "\xFFFF\x1\x10\x3\xFFFF\x1\x12\x1\x13\x4\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x7\x5\xFFFF\x1\x7\x1\x15\x4\x7\x7\xFFFF\x1\x21\x5\xFFFF"+
            "\x1\x23\x14\xFFFF\x1\x20\x1\x1A\x1\x1F\x1\xFFFF\x1\x1C\x1\x1E"+
            "\x1\x1B\x1\xFFFF\x1\x19\xC\xFFFF\x1\x11\x8\xFFFF\x1\x1D\x2\xFFFF"+
            "\x1\x22",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA46_eot = DFA.UnpackEncodedString(DFA46_eotS);
    static readonly short[] DFA46_eof = DFA.UnpackEncodedString(DFA46_eofS);
    static readonly char[] DFA46_min = DFA.UnpackEncodedStringToUnsignedChars(DFA46_minS);
    static readonly char[] DFA46_max = DFA.UnpackEncodedStringToUnsignedChars(DFA46_maxS);
    static readonly short[] DFA46_accept = DFA.UnpackEncodedString(DFA46_acceptS);
    static readonly short[] DFA46_special = DFA.UnpackEncodedString(DFA46_specialS);
    static readonly short[][] DFA46_transition = DFA.UnpackEncodedStringArray(DFA46_transitionS);

    protected class DFA46 : DFA
    {
        public DFA46(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 46;
            this.eot = DFA46_eot;
            this.eof = DFA46_eof;
            this.min = DFA46_min;
            this.max = DFA46_max;
            this.accept = DFA46_accept;
            this.special = DFA46_special;
            this.transition = DFA46_transition;

        }

        override public string Description
        {
            get { return "760:43: (=> LOWER )?"; }
        }

    }


    protected internal int DFA46_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA46_1 = input.LA(1);

                   	 
                   	int index46_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA46_1 == LESS) ) { s = 2; }

                   	else if ( (LA46_1 == ANY_KW) && (synpred18_Smi()) ) { s = 3; }

                   	else if ( (LA46_1 == BIT_KW) && (synpred18_Smi()) ) { s = 4; }

                   	else if ( (LA46_1 == BOOLEAN_KW) && (synpred18_Smi()) ) { s = 5; }

                   	else if ( (LA46_1 == CHARACTER_KW) && (synpred18_Smi()) ) { s = 6; }

                   	else if ( (LA46_1 == BMP_STR_KW || (LA46_1 >= GENERAL_STR_KW && LA46_1 <= GRAPHIC_STR_KW) || LA46_1 == IA5_STRING_KW || LA46_1 == ISO646_STR_KW || LA46_1 == NUMERIC_STR_KW || LA46_1 == PRINTABLE_STR_KW || LA46_1 == T61_STR_KW || LA46_1 == TELETEX_STR_KW || LA46_1 == UNIVERSAL_STR_KW || (LA46_1 >= UTC_TIME_KW && LA46_1 <= VISIBLE_STR_KW)) && (synpred18_Smi()) ) { s = 7; }

                   	else if ( (LA46_1 == CHOICE_KW) && (synpred18_Smi()) ) { s = 8; }

                   	else if ( (LA46_1 == EMBEDDED_KW) && (synpred18_Smi()) ) { s = 9; }

                   	else if ( (LA46_1 == ENUMERATED_KW) && (synpred18_Smi()) ) { s = 10; }

                   	else if ( (LA46_1 == EXTERNAL_KW) && (synpred18_Smi()) ) { s = 11; }

                   	else if ( (LA46_1 == INTEGER_KW) && (synpred18_Smi()) ) { s = 12; }

                   	else if ( (LA46_1 == NULL_KW) && (synpred18_Smi()) ) { s = 13; }

                   	else if ( (LA46_1 == OBJECT_KW) && (synpred18_Smi()) ) { s = 14; }

                   	else if ( (LA46_1 == OCTET_KW) && (synpred18_Smi()) ) { s = 15; }

                   	else if ( (LA46_1 == REAL_KW) && (synpred18_Smi()) ) { s = 16; }

                   	else if ( (LA46_1 == 179) && (synpred18_Smi()) ) { s = 17; }

                   	else if ( (LA46_1 == SEQUENCE_KW) && (synpred18_Smi()) ) { s = 18; }

                   	else if ( (LA46_1 == SET_KW) && (synpred18_Smi()) ) { s = 19; }

                   	else if ( (LA46_1 == L_BRACKET) && (synpred18_Smi()) ) { s = 20; }

                   	else if ( (LA46_1 == UPPER) && (synpred18_Smi()) ) { s = 21; }

                   	else if ( (LA46_1 == LOWER) && (synpred18_Smi()) ) { s = 22; }

                   	else if ( (LA46_1 == OPERATION_KW) && (synpred18_Smi()) ) { s = 23; }

                   	else if ( (LA46_1 == ERROR_KW) && (synpred18_Smi()) ) { s = 24; }

                   	else if ( (LA46_1 == 166) && (synpred18_Smi()) ) { s = 25; }

                   	else if ( (LA46_1 == 159) && (synpred18_Smi()) ) { s = 26; }

                   	else if ( (LA46_1 == 164) && (synpred18_Smi()) ) { s = 27; }

                   	else if ( (LA46_1 == 162) && (synpred18_Smi()) ) { s = 28; }

                   	else if ( (LA46_1 == 188) && (synpred18_Smi()) ) { s = 29; }

                   	else if ( (LA46_1 == 163) && (synpred18_Smi()) ) { s = 30; }

                   	else if ( (LA46_1 == 160) && (synpred18_Smi()) ) { s = 31; }

                   	else if ( (LA46_1 == 158) && (synpred18_Smi()) ) { s = 32; }

                   	else if ( (LA46_1 == 131) && (synpred18_Smi()) ) { s = 33; }

                   	else if ( (LA46_1 == 191) && (synpred18_Smi()) ) { s = 34; }

                   	else if ( (LA46_1 == 137) && (synpred18_Smi()) ) { s = 35; }

                   	 
                   	input.Seek(index46_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae46 =
            new NoViableAltException(dfa.Description, 46, _s, input);
        dfa.Error(nvae46);
        throw nvae46;
    }
    const string DFA49_eotS =
        "\x54\xFFFF";
    const string DFA49_eofS =
        "\x1\x22\x53\xFFFF";
    const string DFA49_minS =
        "\x1\x7\x1\x0\xB\xFFFF\x1\x0\x6\xFFFF\xD\x0\x33\xFFFF";
    const string DFA49_maxS =
        "\x1\xC5\x1\x0\xB\xFFFF\x1\x0\x6\xFFFF\xD\x0\x33\xFFFF";
    const string DFA49_acceptS =
        "\x2\xFFFF\xB\x1\x1\xFFFF\x6\x1\xD\xFFFF\x1\x1\x1\x2\x31\xFFFF";
    const string DFA49_specialS =
        "\x1\x0\x1\x1\xB\xFFFF\x1\x2\x6\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1"+
        "\x7\x1\x8\x1\x9\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x33\xFFFF}>";
    static readonly string[] DFA49_transitionS = {
            "\x1\x2\x2\xFFFF\x1\x22\x3\xFFFF\x1\x22\x3\xFFFF\x1\x3\x1\x6"+
            "\x1\x4\x2\xFFFF\x1\x5\x2\xFFFF\x1\x7\x1\xFFFF\x2\x22\x4\xFFFF"+
            "\x1\x22\x5\xFFFF\x1\x8\x1\x22\x1\x9\x1\x16\x3\x22\x3\xFFFF\x1"+
            "\xA\x2\xFFFF\x3\x6\x2\xFFFF\x1\x6\x6\xFFFF\x1\xB\x2\x22\x1\x6"+
            "\x1\xFFFF\x1\x13\x2\xFFFF\x1\x22\x1\x1\x4\xFFFF\x1\xC\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\xD\x1\xE\x2\xFFFF\x1\x15\x1\x22\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x22\x1\xFFFF\x1\x22\x1\xF\x1\xFFFF\x1\x22"+
            "\x1\xFFFF\x1\x11\x1\x12\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x22\x2\xFFFF\x1\x6\x1\x14\x4\x6\x2\xFFFF\x5\x22\x1\x1F\x3"+
            "\x22\x1\xFFFF\x1\x22\x1\x21\x1\xFFFF\x3\x22\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x3\x22\x6\xFFFF\x2\x22\x1\xFFFF\x1\x1E\x1\x18\x1\x1D"+
            "\x1\xFFFF\x1\x1A\x1\x1C\x1\x19\x1\xFFFF\x1\x17\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x4\x22\x1\xFFFF\x1\x22\x1\xFFFF\x1\x22\x1\x10\x1\xFFFF"+
            "\x4\x22\x3\xFFFF\x1\x1B\x2\x22\x1\x20\x1\x22\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x1\x22",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA49_eot = DFA.UnpackEncodedString(DFA49_eotS);
    static readonly short[] DFA49_eof = DFA.UnpackEncodedString(DFA49_eofS);
    static readonly char[] DFA49_min = DFA.UnpackEncodedStringToUnsignedChars(DFA49_minS);
    static readonly char[] DFA49_max = DFA.UnpackEncodedStringToUnsignedChars(DFA49_maxS);
    static readonly short[] DFA49_accept = DFA.UnpackEncodedString(DFA49_acceptS);
    static readonly short[] DFA49_special = DFA.UnpackEncodedString(DFA49_specialS);
    static readonly short[][] DFA49_transition = DFA.UnpackEncodedStringArray(DFA49_transitionS);

    protected class DFA49 : DFA
    {
        public DFA49(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 49;
            this.eot = DFA49_eot;
            this.eof = DFA49_eof;
            this.min = DFA49_min;
            this.max = DFA49_max;
            this.accept = DFA49_accept;
            this.special = DFA49_special;
            this.transition = DFA49_transition;

        }

        override public string Description
        {
            get { return "762:25: (=> (=> LOWER )? type )?"; }
        }

    }


    protected internal int DFA49_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA49_0 = input.LA(1);

                   	 
                   	int index49_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA49_0 == LOWER) ) { s = 1; }

                   	else if ( (LA49_0 == ANY_KW) && (synpred20_Smi()) ) { s = 2; }

                   	else if ( (LA49_0 == BIT_KW) && (synpred20_Smi()) ) { s = 3; }

                   	else if ( (LA49_0 == BOOLEAN_KW) && (synpred20_Smi()) ) { s = 4; }

                   	else if ( (LA49_0 == CHARACTER_KW) && (synpred20_Smi()) ) { s = 5; }

                   	else if ( (LA49_0 == BMP_STR_KW || (LA49_0 >= GENERAL_STR_KW && LA49_0 <= GRAPHIC_STR_KW) || LA49_0 == IA5_STRING_KW || LA49_0 == ISO646_STR_KW || LA49_0 == NUMERIC_STR_KW || LA49_0 == PRINTABLE_STR_KW || LA49_0 == T61_STR_KW || LA49_0 == TELETEX_STR_KW || LA49_0 == UNIVERSAL_STR_KW || (LA49_0 >= UTC_TIME_KW && LA49_0 <= VISIBLE_STR_KW)) && (synpred20_Smi()) ) { s = 6; }

                   	else if ( (LA49_0 == CHOICE_KW) && (synpred20_Smi()) ) { s = 7; }

                   	else if ( (LA49_0 == EMBEDDED_KW) && (synpred20_Smi()) ) { s = 8; }

                   	else if ( (LA49_0 == ENUMERATED_KW) && (synpred20_Smi()) ) { s = 9; }

                   	else if ( (LA49_0 == EXTERNAL_KW) && (synpred20_Smi()) ) { s = 10; }

                   	else if ( (LA49_0 == INTEGER_KW) && (synpred20_Smi()) ) { s = 11; }

                   	else if ( (LA49_0 == NULL_KW) && (synpred20_Smi()) ) { s = 12; }

                   	else if ( (LA49_0 == OBJECT_KW) ) { s = 13; }

                   	else if ( (LA49_0 == OCTET_KW) && (synpred20_Smi()) ) { s = 14; }

                   	else if ( (LA49_0 == REAL_KW) && (synpred20_Smi()) ) { s = 15; }

                   	else if ( (LA49_0 == 179) && (synpred20_Smi()) ) { s = 16; }

                   	else if ( (LA49_0 == SEQUENCE_KW) && (synpred20_Smi()) ) { s = 17; }

                   	else if ( (LA49_0 == SET_KW) && (synpred20_Smi()) ) { s = 18; }

                   	else if ( (LA49_0 == L_BRACKET) && (synpred20_Smi()) ) { s = 19; }

                   	else if ( (LA49_0 == UPPER) ) { s = 20; }

                   	else if ( (LA49_0 == OPERATION_KW) ) { s = 21; }

                   	else if ( (LA49_0 == ERROR_KW) ) { s = 22; }

                   	else if ( (LA49_0 == 166) ) { s = 23; }

                   	else if ( (LA49_0 == 159) ) { s = 24; }

                   	else if ( (LA49_0 == 164) ) { s = 25; }

                   	else if ( (LA49_0 == 162) ) { s = 26; }

                   	else if ( (LA49_0 == 188) ) { s = 27; }

                   	else if ( (LA49_0 == 163) ) { s = 28; }

                   	else if ( (LA49_0 == 160) ) { s = 29; }

                   	else if ( (LA49_0 == 158) ) { s = 30; }

                   	else if ( (LA49_0 == 131) ) { s = 31; }

                   	else if ( (LA49_0 == 191) ) { s = 32; }

                   	else if ( (LA49_0 == 137) && (synpred20_Smi()) ) { s = 33; }

                   	else if ( (LA49_0 == EOF || LA49_0 == ASSIGN_OP || LA49_0 == BAR || (LA49_0 >= COLON && LA49_0 <= COMMA) || LA49_0 == DEFAULT_KW || LA49_0 == END_KW || (LA49_0 >= ERRORS_KW && LA49_0 <= EXCLAMATION) || (LA49_0 >= INTERSECTION && LA49_0 <= INTERSECTION_KW) || LA49_0 == LINKED_KW || LA49_0 == OPTIONAL_KW || LA49_0 == R_BRACE || LA49_0 == R_PAREN || LA49_0 == RESULT_KW || LA49_0 == UNION_KW || (LA49_0 >= 126 && LA49_0 <= 130) || (LA49_0 >= 132 && LA49_0 <= 134) || LA49_0 == 136 || (LA49_0 >= 139 && LA49_0 <= 141) || LA49_0 == 143 || (LA49_0 >= 146 && LA49_0 <= 148) || (LA49_0 >= 155 && LA49_0 <= 156) || LA49_0 == 168 || (LA49_0 >= 171 && LA49_0 <= 174) || LA49_0 == 176 || LA49_0 == 178 || (LA49_0 >= 181 && LA49_0 <= 184) || (LA49_0 >= 189 && LA49_0 <= 190) || LA49_0 == 192 || LA49_0 == 194 || LA49_0 == 197) ) { s = 34; }

                   	 
                   	input.Seek(index49_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA49_1 = input.LA(1);

                   	 
                   	int index49_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA49_13 = input.LA(1);

                   	 
                   	int index49_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA49_20 = input.LA(1);

                   	 
                   	int index49_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA49_21 = input.LA(1);

                   	 
                   	int index49_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA49_22 = input.LA(1);

                   	 
                   	int index49_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA49_23 = input.LA(1);

                   	 
                   	int index49_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA49_24 = input.LA(1);

                   	 
                   	int index49_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA49_25 = input.LA(1);

                   	 
                   	int index49_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA49_26 = input.LA(1);

                   	 
                   	int index49_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA49_27 = input.LA(1);

                   	 
                   	int index49_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA49_28 = input.LA(1);

                   	 
                   	int index49_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA49_29 = input.LA(1);

                   	 
                   	int index49_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA49_30 = input.LA(1);

                   	 
                   	int index49_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA49_31 = input.LA(1);

                   	 
                   	int index49_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA49_32 = input.LA(1);

                   	 
                   	int index49_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index49_32);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae49 =
            new NoViableAltException(dfa.Description, 49, _s, input);
        dfa.Error(nvae49);
        throw nvae49;
    }
    const string DFA48_eotS =
        "\x24\xFFFF";
    const string DFA48_eofS =
        "\x24\xFFFF";
    const string DFA48_minS =
        "\x2\x7\x22\xFFFF";
    const string DFA48_maxS =
        "\x2\xBF\x22\xFFFF";
    const string DFA48_acceptS =
        "\x2\xFFFF\x1\x2\x21\x1";
    const string DFA48_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA48_transitionS = {
            "\x1\x2\xA\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\xD\xFFFF"+
            "\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF"+
            "\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x3\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF"+
            "\x1\x2\x7\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF"+
            "\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\xA\xFFFF\x1\x4\x1\x7\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1"+
            "\x8\xD\xFFFF\x1\x9\x1\xFFFF\x1\xA\x1\x18\x6\xFFFF\x1\xB\x2\xFFFF"+
            "\x3\x7\x2\xFFFF\x1\x7\x6\xFFFF\x1\xC\x2\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x14\x1\xFFFF\x1\x2\x1\xFFFF\x1\x16\x4\xFFFF\x1\xD\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\xE\x1\xF\x2\xFFFF\x1\x17\x7\xFFFF\x1\x7\x4"+
            "\xFFFF\x1\x10\x3\xFFFF\x1\x12\x1\x13\x4\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x7\x5\xFFFF\x1\x7\x1\x15\x4\x7\x7\xFFFF\x1\x21\x5\xFFFF"+
            "\x1\x23\x14\xFFFF\x1\x20\x1\x1A\x1\x1F\x1\xFFFF\x1\x1C\x1\x1E"+
            "\x1\x1B\x1\xFFFF\x1\x19\xC\xFFFF\x1\x11\x8\xFFFF\x1\x1D\x2\xFFFF"+
            "\x1\x22",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA48_eot = DFA.UnpackEncodedString(DFA48_eotS);
    static readonly short[] DFA48_eof = DFA.UnpackEncodedString(DFA48_eofS);
    static readonly char[] DFA48_min = DFA.UnpackEncodedStringToUnsignedChars(DFA48_minS);
    static readonly char[] DFA48_max = DFA.UnpackEncodedStringToUnsignedChars(DFA48_maxS);
    static readonly short[] DFA48_accept = DFA.UnpackEncodedString(DFA48_acceptS);
    static readonly short[] DFA48_special = DFA.UnpackEncodedString(DFA48_specialS);
    static readonly short[][] DFA48_transition = DFA.UnpackEncodedStringArray(DFA48_transitionS);

    protected class DFA48 : DFA
    {
        public DFA48(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 48;
            this.eot = DFA48_eot;
            this.eof = DFA48_eof;
            this.min = DFA48_min;
            this.max = DFA48_max;
            this.accept = DFA48_accept;
            this.special = DFA48_special;
            this.transition = DFA48_transition;

        }

        override public string Description
        {
            get { return "762:37: (=> LOWER )?"; }
        }

    }


    protected internal int DFA48_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA48_1 = input.LA(1);

                   	 
                   	int index48_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA48_1 == LESS) ) { s = 2; }

                   	else if ( (LA48_1 == ANY_KW) && (synpred21_Smi()) ) { s = 3; }

                   	else if ( (LA48_1 == BIT_KW) && (synpred21_Smi()) ) { s = 4; }

                   	else if ( (LA48_1 == BOOLEAN_KW) && (synpred21_Smi()) ) { s = 5; }

                   	else if ( (LA48_1 == CHARACTER_KW) && (synpred21_Smi()) ) { s = 6; }

                   	else if ( (LA48_1 == BMP_STR_KW || (LA48_1 >= GENERAL_STR_KW && LA48_1 <= GRAPHIC_STR_KW) || LA48_1 == IA5_STRING_KW || LA48_1 == ISO646_STR_KW || LA48_1 == NUMERIC_STR_KW || LA48_1 == PRINTABLE_STR_KW || LA48_1 == T61_STR_KW || LA48_1 == TELETEX_STR_KW || LA48_1 == UNIVERSAL_STR_KW || (LA48_1 >= UTC_TIME_KW && LA48_1 <= VISIBLE_STR_KW)) && (synpred21_Smi()) ) { s = 7; }

                   	else if ( (LA48_1 == CHOICE_KW) && (synpred21_Smi()) ) { s = 8; }

                   	else if ( (LA48_1 == EMBEDDED_KW) && (synpred21_Smi()) ) { s = 9; }

                   	else if ( (LA48_1 == ENUMERATED_KW) && (synpred21_Smi()) ) { s = 10; }

                   	else if ( (LA48_1 == EXTERNAL_KW) && (synpred21_Smi()) ) { s = 11; }

                   	else if ( (LA48_1 == INTEGER_KW) && (synpred21_Smi()) ) { s = 12; }

                   	else if ( (LA48_1 == NULL_KW) && (synpred21_Smi()) ) { s = 13; }

                   	else if ( (LA48_1 == OBJECT_KW) && (synpred21_Smi()) ) { s = 14; }

                   	else if ( (LA48_1 == OCTET_KW) && (synpred21_Smi()) ) { s = 15; }

                   	else if ( (LA48_1 == REAL_KW) && (synpred21_Smi()) ) { s = 16; }

                   	else if ( (LA48_1 == 179) && (synpred21_Smi()) ) { s = 17; }

                   	else if ( (LA48_1 == SEQUENCE_KW) && (synpred21_Smi()) ) { s = 18; }

                   	else if ( (LA48_1 == SET_KW) && (synpred21_Smi()) ) { s = 19; }

                   	else if ( (LA48_1 == L_BRACKET) && (synpred21_Smi()) ) { s = 20; }

                   	else if ( (LA48_1 == UPPER) && (synpred21_Smi()) ) { s = 21; }

                   	else if ( (LA48_1 == LOWER) && (synpred21_Smi()) ) { s = 22; }

                   	else if ( (LA48_1 == OPERATION_KW) && (synpred21_Smi()) ) { s = 23; }

                   	else if ( (LA48_1 == ERROR_KW) && (synpred21_Smi()) ) { s = 24; }

                   	else if ( (LA48_1 == 166) && (synpred21_Smi()) ) { s = 25; }

                   	else if ( (LA48_1 == 159) && (synpred21_Smi()) ) { s = 26; }

                   	else if ( (LA48_1 == 164) && (synpred21_Smi()) ) { s = 27; }

                   	else if ( (LA48_1 == 162) && (synpred21_Smi()) ) { s = 28; }

                   	else if ( (LA48_1 == 188) && (synpred21_Smi()) ) { s = 29; }

                   	else if ( (LA48_1 == 163) && (synpred21_Smi()) ) { s = 30; }

                   	else if ( (LA48_1 == 160) && (synpred21_Smi()) ) { s = 31; }

                   	else if ( (LA48_1 == 158) && (synpred21_Smi()) ) { s = 32; }

                   	else if ( (LA48_1 == 131) && (synpred21_Smi()) ) { s = 33; }

                   	else if ( (LA48_1 == 191) && (synpred21_Smi()) ) { s = 34; }

                   	else if ( (LA48_1 == 137) && (synpred21_Smi()) ) { s = 35; }

                   	 
                   	input.Seek(index48_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae48 =
            new NoViableAltException(dfa.Description, 48, _s, input);
        dfa.Error(nvae48);
        throw nvae48;
    }
    const string DFA55_eotS =
        "\x24\xFFFF";
    const string DFA55_eofS =
        "\x24\xFFFF";
    const string DFA55_minS =
        "\x2\x7\x22\xFFFF";
    const string DFA55_maxS =
        "\x2\xBF\x22\xFFFF";
    const string DFA55_acceptS =
        "\x2\xFFFF\x1\x2\x21\x1";
    const string DFA55_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA55_transitionS = {
            "\x1\x2\xA\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\xD\xFFFF"+
            "\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF"+
            "\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x3\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF"+
            "\x1\x2\x7\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF"+
            "\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\xA\xFFFF\x1\x4\x1\x7\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1"+
            "\x8\xD\xFFFF\x1\x9\x1\xFFFF\x1\xA\x1\x18\x6\xFFFF\x1\xB\x2\xFFFF"+
            "\x3\x7\x2\xFFFF\x1\x7\x6\xFFFF\x1\xC\x2\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x14\x1\xFFFF\x1\x2\x1\xFFFF\x1\x16\x4\xFFFF\x1\xD\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\xE\x1\xF\x2\xFFFF\x1\x17\x7\xFFFF\x1\x7\x4"+
            "\xFFFF\x1\x10\x3\xFFFF\x1\x12\x1\x13\x4\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x7\x5\xFFFF\x1\x7\x1\x15\x4\x7\x7\xFFFF\x1\x21\x5\xFFFF"+
            "\x1\x23\x14\xFFFF\x1\x20\x1\x1A\x1\x1F\x1\xFFFF\x1\x1C\x1\x1E"+
            "\x1\x1B\x1\xFFFF\x1\x19\xC\xFFFF\x1\x11\x8\xFFFF\x1\x1D\x2\xFFFF"+
            "\x1\x22",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA55_eot = DFA.UnpackEncodedString(DFA55_eotS);
    static readonly short[] DFA55_eof = DFA.UnpackEncodedString(DFA55_eofS);
    static readonly char[] DFA55_min = DFA.UnpackEncodedStringToUnsignedChars(DFA55_minS);
    static readonly char[] DFA55_max = DFA.UnpackEncodedStringToUnsignedChars(DFA55_maxS);
    static readonly short[] DFA55_accept = DFA.UnpackEncodedString(DFA55_acceptS);
    static readonly short[] DFA55_special = DFA.UnpackEncodedString(DFA55_specialS);
    static readonly short[][] DFA55_transition = DFA.UnpackEncodedStringArray(DFA55_transitionS);

    protected class DFA55 : DFA
    {
        public DFA55(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 55;
            this.eot = DFA55_eot;
            this.eof = DFA55_eof;
            this.min = DFA55_min;
            this.max = DFA55_max;
            this.accept = DFA55_accept;
            this.special = DFA55_special;
            this.transition = DFA55_transition;

        }

        override public string Description
        {
            get { return "775:38: (=> LOWER )?"; }
        }

    }


    protected internal int DFA55_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA55_1 = input.LA(1);

                   	 
                   	int index55_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA55_1 == LESS) ) { s = 2; }

                   	else if ( (LA55_1 == ANY_KW) && (synpred24_Smi()) ) { s = 3; }

                   	else if ( (LA55_1 == BIT_KW) && (synpred24_Smi()) ) { s = 4; }

                   	else if ( (LA55_1 == BOOLEAN_KW) && (synpred24_Smi()) ) { s = 5; }

                   	else if ( (LA55_1 == CHARACTER_KW) && (synpred24_Smi()) ) { s = 6; }

                   	else if ( (LA55_1 == BMP_STR_KW || (LA55_1 >= GENERAL_STR_KW && LA55_1 <= GRAPHIC_STR_KW) || LA55_1 == IA5_STRING_KW || LA55_1 == ISO646_STR_KW || LA55_1 == NUMERIC_STR_KW || LA55_1 == PRINTABLE_STR_KW || LA55_1 == T61_STR_KW || LA55_1 == TELETEX_STR_KW || LA55_1 == UNIVERSAL_STR_KW || (LA55_1 >= UTC_TIME_KW && LA55_1 <= VISIBLE_STR_KW)) && (synpred24_Smi()) ) { s = 7; }

                   	else if ( (LA55_1 == CHOICE_KW) && (synpred24_Smi()) ) { s = 8; }

                   	else if ( (LA55_1 == EMBEDDED_KW) && (synpred24_Smi()) ) { s = 9; }

                   	else if ( (LA55_1 == ENUMERATED_KW) && (synpred24_Smi()) ) { s = 10; }

                   	else if ( (LA55_1 == EXTERNAL_KW) && (synpred24_Smi()) ) { s = 11; }

                   	else if ( (LA55_1 == INTEGER_KW) && (synpred24_Smi()) ) { s = 12; }

                   	else if ( (LA55_1 == NULL_KW) && (synpred24_Smi()) ) { s = 13; }

                   	else if ( (LA55_1 == OBJECT_KW) && (synpred24_Smi()) ) { s = 14; }

                   	else if ( (LA55_1 == OCTET_KW) && (synpred24_Smi()) ) { s = 15; }

                   	else if ( (LA55_1 == REAL_KW) && (synpred24_Smi()) ) { s = 16; }

                   	else if ( (LA55_1 == 179) && (synpred24_Smi()) ) { s = 17; }

                   	else if ( (LA55_1 == SEQUENCE_KW) && (synpred24_Smi()) ) { s = 18; }

                   	else if ( (LA55_1 == SET_KW) && (synpred24_Smi()) ) { s = 19; }

                   	else if ( (LA55_1 == L_BRACKET) && (synpred24_Smi()) ) { s = 20; }

                   	else if ( (LA55_1 == UPPER) && (synpred24_Smi()) ) { s = 21; }

                   	else if ( (LA55_1 == LOWER) && (synpred24_Smi()) ) { s = 22; }

                   	else if ( (LA55_1 == OPERATION_KW) && (synpred24_Smi()) ) { s = 23; }

                   	else if ( (LA55_1 == ERROR_KW) && (synpred24_Smi()) ) { s = 24; }

                   	else if ( (LA55_1 == 166) && (synpred24_Smi()) ) { s = 25; }

                   	else if ( (LA55_1 == 159) && (synpred24_Smi()) ) { s = 26; }

                   	else if ( (LA55_1 == 164) && (synpred24_Smi()) ) { s = 27; }

                   	else if ( (LA55_1 == 162) && (synpred24_Smi()) ) { s = 28; }

                   	else if ( (LA55_1 == 188) && (synpred24_Smi()) ) { s = 29; }

                   	else if ( (LA55_1 == 163) && (synpred24_Smi()) ) { s = 30; }

                   	else if ( (LA55_1 == 160) && (synpred24_Smi()) ) { s = 31; }

                   	else if ( (LA55_1 == 158) && (synpred24_Smi()) ) { s = 32; }

                   	else if ( (LA55_1 == 131) && (synpred24_Smi()) ) { s = 33; }

                   	else if ( (LA55_1 == 191) && (synpred24_Smi()) ) { s = 34; }

                   	else if ( (LA55_1 == 137) && (synpred24_Smi()) ) { s = 35; }

                   	 
                   	input.Seek(index55_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae55 =
            new NoViableAltException(dfa.Description, 55, _s, input);
        dfa.Error(nvae55);
        throw nvae55;
    }
    const string DFA66_eotS =
        "\xB\xFFFF";
    const string DFA66_eofS =
        "\xB\xFFFF";
    const string DFA66_minS =
        "\x1\x7\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA66_maxS =
        "\x1\xBF\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA66_acceptS =
        "\x6\xFFFF\x1\x3\x1\x1\x1\x2\x2\xFFFF";
    const string DFA66_specialS =
        "\x1\xFFFF\x1\x0\x1\x1\x2\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4}>";
    static readonly string[] DFA66_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x7",
            "\x1\x7",
            "\x1\x9",
            "\x1\xA",
            "\x1\x7",
            "",
            "",
            "",
            "\x1\x7",
            "\x1\x7"
    };

    static readonly short[] DFA66_eot = DFA.UnpackEncodedString(DFA66_eotS);
    static readonly short[] DFA66_eof = DFA.UnpackEncodedString(DFA66_eofS);
    static readonly char[] DFA66_min = DFA.UnpackEncodedStringToUnsignedChars(DFA66_minS);
    static readonly char[] DFA66_max = DFA.UnpackEncodedStringToUnsignedChars(DFA66_maxS);
    static readonly short[] DFA66_accept = DFA.UnpackEncodedString(DFA66_acceptS);
    static readonly short[] DFA66_special = DFA.UnpackEncodedString(DFA66_specialS);
    static readonly short[][] DFA66_transition = DFA.UnpackEncodedStringArray(DFA66_transitionS);

    protected class DFA66 : DFA
    {
        public DFA66(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 66;
            this.eot = DFA66_eot;
            this.eof = DFA66_eof;
            this.min = DFA66_min;
            this.max = DFA66_max;
            this.accept = DFA66_accept;
            this.special = DFA66_special;
            this.transition = DFA66_transition;

        }

        override public string Description
        {
            get { return "806:21: (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type )"; }
        }

    }


    protected internal int DFA66_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA66_1 = input.LA(1);

                   	 
                   	int index66_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA66_1 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index66_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA66_2 = input.LA(1);

                   	 
                   	int index66_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA66_2 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index66_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA66_5 = input.LA(1);

                   	 
                   	int index66_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA66_5 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index66_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA66_9 = input.LA(1);

                   	 
                   	int index66_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA66_9 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index66_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA66_10 = input.LA(1);

                   	 
                   	int index66_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA66_10 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index66_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae66 =
            new NoViableAltException(dfa.Description, 66, _s, input);
        dfa.Error(nvae66);
        throw nvae66;
    }
    const string DFA75_eotS =
        "\x3F\xFFFF";
    const string DFA75_eofS =
        "\x1\x5\x3E\xFFFF";
    const string DFA75_minS =
        "\x1\xA\x1\x0\x3D\xFFFF";
    const string DFA75_maxS =
        "\x1\xC5\x1\x0\x3D\xFFFF";
    const string DFA75_acceptS =
        "\x2\xFFFF\x1\x2\x1\x3\x1\x4\x1\x5\x38\xFFFF\x1\x1";
    const string DFA75_specialS =
        "\x1\xFFFF\x1\x0\x3D\xFFFF}>";
    static readonly string[] DFA75_transitionS = {
            "\x1\x5\x3\xFFFF\x1\x5\xD\xFFFF\x2\x5\x4\xFFFF\x1\x5\x6\xFFFF"+
            "\x1\x5\x1\xFFFF\x4\x5\x13\xFFFF\x2\x5\x5\xFFFF\x2\x5\x8\xFFFF"+
            "\x1\x5\x3\xFFFF\x2\x5\x8\xFFFF\x1\x5\x1\xFFFF\x1\x5\x2\xFFFF"+
            "\x1\x5\xC\xFFFF\x1\x5\x3\xFFFF\x1\x5\x6\xFFFF\x9\x5\x1\x2\x1"+
            "\x5\x2\xFFFF\x3\x5\x1\xFFFF\x1\x5\x1\xFFFF\x1\x4\x3\x5\x1\xFFFF"+
            "\x1\x1\x4\xFFFF\x2\x5\x1\xFFFF\x3\x5\x1\xFFFF\x3\x5\x1\xFFFF"+
            "\x1\x5\x1\xFFFF\x1\x5\x1\xFFFF\x1\x3\x4\x5\x1\xFFFF\x1\x5\x1"+
            "\xFFFF\x1\x5\x2\xFFFF\x4\x5\x3\xFFFF\x7\x5\x2\xFFFF\x1\x5",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA75_eot = DFA.UnpackEncodedString(DFA75_eotS);
    static readonly short[] DFA75_eof = DFA.UnpackEncodedString(DFA75_eofS);
    static readonly char[] DFA75_min = DFA.UnpackEncodedStringToUnsignedChars(DFA75_minS);
    static readonly char[] DFA75_max = DFA.UnpackEncodedStringToUnsignedChars(DFA75_maxS);
    static readonly short[] DFA75_accept = DFA.UnpackEncodedString(DFA75_acceptS);
    static readonly short[] DFA75_special = DFA.UnpackEncodedString(DFA75_specialS);
    static readonly short[][] DFA75_transition = DFA.UnpackEncodedStringArray(DFA75_transitionS);

    protected class DFA75 : DFA
    {
        public DFA75(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 75;
            this.eot = DFA75_eot;
            this.eof = DFA75_eof;
            this.min = DFA75_min;
            this.max = DFA75_max;
            this.accept = DFA75_accept;
            this.special = DFA75_special;
            this.transition = DFA75_transition;

        }

        override public string Description
        {
            get { return "819:5: (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )?"; }
        }

    }


    protected internal int DFA75_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA75_1 = input.LA(1);

                   	 
                   	int index75_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred28_Smi()) ) { s = 62; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index75_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae75 =
            new NoViableAltException(dfa.Description, 75, _s, input);
        dfa.Error(nvae75);
        throw nvae75;
    }
    const string DFA81_eotS =
        "\x3A\xFFFF";
    const string DFA81_eofS =
        "\x1\x2\x39\xFFFF";
    const string DFA81_minS =
        "\x1\xA\x1\x0\x38\xFFFF";
    const string DFA81_maxS =
        "\x1\xC5\x1\x0\x38\xFFFF";
    const string DFA81_acceptS =
        "\x2\xFFFF\x1\x2\x36\xFFFF\x1\x1";
    const string DFA81_specialS =
        "\x1\xFFFF\x1\x0\x38\xFFFF}>";
    static readonly string[] DFA81_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\xD\xFFFF\x2\x2\x4\xFFFF\x1\x2\x6\xFFFF"+
            "\x1\x2\x1\xFFFF\x4\x2\x13\xFFFF\x2\x2\x5\xFFFF\x2\x2\x8\xFFFF"+
            "\x1\x2\x3\xFFFF\x2\x2\x8\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x2\x6\xFFFF\x9\x2\x1\xFFFF"+
            "\x1\x2\x2\xFFFF\x1\x2\x1\x1\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x3"+
            "\x2\x6\xFFFF\x2\x2\x1\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1"+
            "\x2\x1\xFFFF\x1\x2\x2\xFFFF\x4\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1"+
            "\x2\x2\xFFFF\x4\x2\x3\xFFFF\x5\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1"+
            "\x2",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA81_eot = DFA.UnpackEncodedString(DFA81_eotS);
    static readonly short[] DFA81_eof = DFA.UnpackEncodedString(DFA81_eofS);
    static readonly char[] DFA81_min = DFA.UnpackEncodedStringToUnsignedChars(DFA81_minS);
    static readonly char[] DFA81_max = DFA.UnpackEncodedStringToUnsignedChars(DFA81_maxS);
    static readonly short[] DFA81_accept = DFA.UnpackEncodedString(DFA81_acceptS);
    static readonly short[] DFA81_special = DFA.UnpackEncodedString(DFA81_specialS);
    static readonly short[][] DFA81_transition = DFA.UnpackEncodedStringArray(DFA81_transitionS);

    protected class DFA81 : DFA
    {
        public DFA81(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 81;
            this.eot = DFA81_eot;
            this.eof = DFA81_eof;
            this.min = DFA81_min;
            this.max = DFA81_max;
            this.accept = DFA81_accept;
            this.special = DFA81_special;
            this.transition = DFA81_transition;

        }

        override public string Description
        {
            get { return "826:5: (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )?"; }
        }

    }


    protected internal int DFA81_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA81_1 = input.LA(1);

                   	 
                   	int index81_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred29_Smi()) ) { s = 57; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index81_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae81 =
            new NoViableAltException(dfa.Description, 81, _s, input);
        dfa.Error(nvae81);
        throw nvae81;
    }
    const string DFA80_eotS =
        "\xA\xFFFF";
    const string DFA80_eofS =
        "\xA\xFFFF";
    const string DFA80_minS =
        "\x2\xD\x1\xFFFF\x2\xD\x1\x0\x1\xD\x1\xFFFF\x1\x0\x1\xD";
    const string DFA80_maxS =
        "\x2\x77\x1\xFFFF\x2\x77\x1\x0\x1\x77\x1\xFFFF\x1\x0\x1\x77";
    const string DFA80_acceptS =
        "\x2\xFFFF\x1\x2\x4\xFFFF\x1\x1\x2\xFFFF";
    const string DFA80_specialS =
        "\x5\xFFFF\x1\x0\x2\xFFFF\x1\x1\x1\xFFFF}>";
    static readonly string[] DFA80_transitionS = {
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x6\xFFFF\x1\x2\x15\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x3\x2\xFFFF\x4\x2\xC\xFFFF"+
            "\x1\x2\x3\xFFFF\x1\x2\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\x4\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2\x2"+
            "\xFFFF\x4\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x5\xF\xFFFF\x1\x2\x5"+
            "\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x6\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\x9\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\x8\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x6\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2"
    };

    static readonly short[] DFA80_eot = DFA.UnpackEncodedString(DFA80_eotS);
    static readonly short[] DFA80_eof = DFA.UnpackEncodedString(DFA80_eofS);
    static readonly char[] DFA80_min = DFA.UnpackEncodedStringToUnsignedChars(DFA80_minS);
    static readonly char[] DFA80_max = DFA.UnpackEncodedStringToUnsignedChars(DFA80_maxS);
    static readonly short[] DFA80_accept = DFA.UnpackEncodedString(DFA80_acceptS);
    static readonly short[] DFA80_special = DFA.UnpackEncodedString(DFA80_specialS);
    static readonly short[][] DFA80_transition = DFA.UnpackEncodedStringArray(DFA80_transitionS);

    protected class DFA80 : DFA
    {
        public DFA80(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 80;
            this.eot = DFA80_eot;
            this.eof = DFA80_eof;
            this.min = DFA80_min;
            this.max = DFA80_max;
            this.accept = DFA80_accept;
            this.special = DFA80_special;
            this.transition = DFA80_transition;

        }

        override public string Description
        {
            get { return "827:21: (=> objecttype_macro_bitsvalue | value )"; }
        }

    }


    protected internal int DFA80_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA80_5 = input.LA(1);

                   	 
                   	int index80_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred30_Smi()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index80_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA80_8 = input.LA(1);

                   	 
                   	int index80_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred30_Smi()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index80_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae80 =
            new NoViableAltException(dfa.Description, 80, _s, input);
        dfa.Error(nvae80);
        throw nvae80;
    }
    const string DFA97_eotS =
        "\x17\xFFFF";
    const string DFA97_eofS =
        "\x1\xFFFF\x2\x6\x2\xFFFF\x1\x6\x3\xFFFF\x2\x6\xC\xFFFF";
    const string DFA97_minS =
        "\x1\x7\x2\xA\x1\x6D\x1\x3B\x1\xA\x2\xFFFF\x1\x4A\x2\xA\x1\x47\x1"+
        "\x4A\x1\x50\x1\x63\x1\x1D\x1\x4A\x1\x0\x1\x47\x1\x4A\x1\x50\x1\x63"+
        "\x1\x1D";
    const string DFA97_maxS =
        "\x1\xBF\x2\xC5\x1\x6D\x1\x3B\x1\xC5\x2\xFFFF\x1\x4A\x2\xC5\x1\x47"+
        "\x1\x77\x1\x50\x1\x63\x1\x61\x1\x4A\x1\x0\x1\x47\x1\x77\x1\x50\x1"+
        "\x63\x1\x61";
    const string DFA97_acceptS =
        "\x6\xFFFF\x1\x2\x1\x1\xF\xFFFF";
    const string DFA97_specialS =
        "\x1\xFFFF\x1\x0\x3\xFFFF\x1\x1\x3\xFFFF\x1\x2\x1\x3\x6\xFFFF\x1"+
        "\x4\x5\xFFFF}>";
    static readonly string[] DFA97_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x7\x3\xFFFF"+
            "\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF\x1\x6\x6\xFFFF"+
            "\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x6",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x8\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x6\xFFFF\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x3\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x9",
            "\x1\xA",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x6\x3\xFFFF\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\x6\x1\xFFFF\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF"+
            "\x2\x6\x8\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF"+
            "\x1\x6\x3\xFFFF\x1\x6\x6\xFFFF\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x3\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF"+
            "\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x4\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF"+
            "\x5\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "",
            "",
            "\x1\xB",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x6\xFFFF\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x3\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x7\x3\xFFFF"+
            "\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF\x1\x6\x6\xFFFF"+
            "\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x6",
            "\x1\xC",
            "\x1\x6\x2\xFFFF\x1\xD\x2\xFFFF\x1\xE\x26\xFFFF\x1\x6",
            "\x1\xE",
            "\x1\xF",
            "\x1\x10\x43\xFFFF\x1\x11",
            "\x1\x12",
            "\x1\xFFFF",
            "\x1\x13",
            "\x1\x6\x2\xFFFF\x1\x14\x2\xFFFF\x1\x15\x26\xFFFF\x1\x6",
            "\x1\x15",
            "\x1\x16",
            "\x1\x10\x43\xFFFF\x1\x11"
    };

    static readonly short[] DFA97_eot = DFA.UnpackEncodedString(DFA97_eotS);
    static readonly short[] DFA97_eof = DFA.UnpackEncodedString(DFA97_eofS);
    static readonly char[] DFA97_min = DFA.UnpackEncodedStringToUnsignedChars(DFA97_minS);
    static readonly char[] DFA97_max = DFA.UnpackEncodedStringToUnsignedChars(DFA97_maxS);
    static readonly short[] DFA97_accept = DFA.UnpackEncodedString(DFA97_acceptS);
    static readonly short[] DFA97_special = DFA.UnpackEncodedString(DFA97_specialS);
    static readonly short[][] DFA97_transition = DFA.UnpackEncodedStringArray(DFA97_transitionS);

    protected class DFA97 : DFA
    {
        public DFA97(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 97;
            this.eot = DFA97_eot;
            this.eof = DFA97_eof;
            this.min = DFA97_min;
            this.max = DFA97_max;
            this.accept = DFA97_accept;
            this.special = DFA97_special;
            this.transition = DFA97_transition;

        }

        override public string Description
        {
            get { return "891:38: (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type )"; }
        }

    }


    protected internal int DFA97_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA97_1 = input.LA(1);

                   	 
                   	int index97_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA97_1 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	else if ( (LA97_1 == EOF || LA97_1 == ASSIGN_OP || LA97_1 == BAR || (LA97_1 >= COLON && LA97_1 <= COMMA) || LA97_1 == DEFAULT_KW || LA97_1 == END_KW || (LA97_1 >= ERROR_KW && LA97_1 <= EXCLAMATION) || (LA97_1 >= INTERSECTION && LA97_1 <= INTERSECTION_KW) || (LA97_1 >= LINKED_KW && LA97_1 <= LOWER) || LA97_1 == OBJECT_KW || (LA97_1 >= OPERATION_KW && LA97_1 <= OPTIONAL_KW) || LA97_1 == R_BRACE || LA97_1 == R_PAREN || LA97_1 == RESULT_KW || LA97_1 == UNION_KW || LA97_1 == UPPER || (LA97_1 >= 126 && LA97_1 <= 134) || LA97_1 == 136 || (LA97_1 >= 139 && LA97_1 <= 141) || LA97_1 == 143 || (LA97_1 >= 146 && LA97_1 <= 148) || (LA97_1 >= 155 && LA97_1 <= 156) || (LA97_1 >= 158 && LA97_1 <= 160) || (LA97_1 >= 162 && LA97_1 <= 164) || LA97_1 == 166 || LA97_1 == 168 || (LA97_1 >= 171 && LA97_1 <= 174) || LA97_1 == 176 || LA97_1 == 178 || (LA97_1 >= 181 && LA97_1 <= 184) || (LA97_1 >= 188 && LA97_1 <= 192) || LA97_1 == 194 || LA97_1 == 197) ) { s = 6; }

                   	 
                   	input.Seek(index97_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA97_5 = input.LA(1);

                   	 
                   	int index97_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA97_5 == EOF || LA97_5 == ASSIGN_OP || LA97_5 == BAR || (LA97_5 >= COLON && LA97_5 <= COMMA) || LA97_5 == DEFAULT_KW || LA97_5 == DOT || LA97_5 == END_KW || (LA97_5 >= ERROR_KW && LA97_5 <= EXCLAMATION) || (LA97_5 >= INTERSECTION && LA97_5 <= INTERSECTION_KW) || LA97_5 == L_PAREN || (LA97_5 >= LINKED_KW && LA97_5 <= LOWER) || LA97_5 == OBJECT_KW || (LA97_5 >= OPERATION_KW && LA97_5 <= OPTIONAL_KW) || LA97_5 == R_BRACE || LA97_5 == R_PAREN || LA97_5 == RESULT_KW || LA97_5 == UNION_KW || LA97_5 == UPPER || (LA97_5 >= 126 && LA97_5 <= 134) || LA97_5 == 136 || (LA97_5 >= 139 && LA97_5 <= 141) || LA97_5 == 143 || (LA97_5 >= 146 && LA97_5 <= 148) || (LA97_5 >= 155 && LA97_5 <= 156) || (LA97_5 >= 158 && LA97_5 <= 160) || (LA97_5 >= 162 && LA97_5 <= 164) || LA97_5 == 166 || LA97_5 == 168 || (LA97_5 >= 171 && LA97_5 <= 174) || LA97_5 == 176 || LA97_5 == 178 || (LA97_5 >= 181 && LA97_5 <= 184) || (LA97_5 >= 188 && LA97_5 <= 192) || LA97_5 == 194 || LA97_5 == 197) ) { s = 6; }

                   	else if ( (LA97_5 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	 
                   	input.Seek(index97_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA97_9 = input.LA(1);

                   	 
                   	int index97_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA97_9 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	else if ( (LA97_9 == EOF || LA97_9 == ASSIGN_OP || LA97_9 == BAR || (LA97_9 >= COLON && LA97_9 <= COMMA) || LA97_9 == DEFAULT_KW || LA97_9 == END_KW || (LA97_9 >= ERROR_KW && LA97_9 <= EXCLAMATION) || (LA97_9 >= INTERSECTION && LA97_9 <= INTERSECTION_KW) || LA97_9 == L_PAREN || (LA97_9 >= LINKED_KW && LA97_9 <= LOWER) || LA97_9 == OBJECT_KW || (LA97_9 >= OPERATION_KW && LA97_9 <= OPTIONAL_KW) || LA97_9 == R_BRACE || LA97_9 == R_PAREN || LA97_9 == RESULT_KW || LA97_9 == UNION_KW || LA97_9 == UPPER || (LA97_9 >= 126 && LA97_9 <= 134) || LA97_9 == 136 || (LA97_9 >= 139 && LA97_9 <= 141) || LA97_9 == 143 || (LA97_9 >= 146 && LA97_9 <= 148) || (LA97_9 >= 155 && LA97_9 <= 156) || (LA97_9 >= 158 && LA97_9 <= 160) || (LA97_9 >= 162 && LA97_9 <= 164) || LA97_9 == 166 || LA97_9 == 168 || (LA97_9 >= 171 && LA97_9 <= 174) || LA97_9 == 176 || LA97_9 == 178 || (LA97_9 >= 181 && LA97_9 <= 184) || (LA97_9 >= 188 && LA97_9 <= 192) || LA97_9 == 194 || LA97_9 == 197) ) { s = 6; }

                   	 
                   	input.Seek(index97_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA97_10 = input.LA(1);

                   	 
                   	int index97_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA97_10 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	else if ( (LA97_10 == EOF || LA97_10 == ASSIGN_OP || LA97_10 == BAR || (LA97_10 >= COLON && LA97_10 <= COMMA) || LA97_10 == DEFAULT_KW || LA97_10 == END_KW || (LA97_10 >= ERROR_KW && LA97_10 <= EXCLAMATION) || (LA97_10 >= INTERSECTION && LA97_10 <= INTERSECTION_KW) || (LA97_10 >= LINKED_KW && LA97_10 <= LOWER) || LA97_10 == OBJECT_KW || (LA97_10 >= OPERATION_KW && LA97_10 <= OPTIONAL_KW) || LA97_10 == R_BRACE || LA97_10 == R_PAREN || LA97_10 == RESULT_KW || LA97_10 == UNION_KW || LA97_10 == UPPER || (LA97_10 >= 126 && LA97_10 <= 134) || LA97_10 == 136 || (LA97_10 >= 139 && LA97_10 <= 141) || LA97_10 == 143 || (LA97_10 >= 146 && LA97_10 <= 148) || (LA97_10 >= 155 && LA97_10 <= 156) || (LA97_10 >= 158 && LA97_10 <= 160) || (LA97_10 >= 162 && LA97_10 <= 164) || LA97_10 == 166 || LA97_10 == 168 || (LA97_10 >= 171 && LA97_10 <= 174) || LA97_10 == 176 || LA97_10 == 178 || (LA97_10 >= 181 && LA97_10 <= 184) || (LA97_10 >= 188 && LA97_10 <= 192) || LA97_10 == 194 || LA97_10 == 197) ) { s = 6; }

                   	 
                   	input.Seek(index97_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA97_17 = input.LA(1);

                   	 
                   	int index97_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred31_Smi()) ) { s = 7; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index97_17);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae97 =
            new NoViableAltException(dfa.Description, 97, _s, input);
        dfa.Error(nvae97);
        throw nvae97;
    }
    const string DFA106_eotS =
        "\x67\xFFFF";
    const string DFA106_eofS =
        "\x1\x2\x1\x3F\x65\xFFFF";
    const string DFA106_minS =
        "\x2\xA\x1\xFFFF\x1\x7\x45\xFFFF\x1\x0\x1\x25\x1\xD\xA\xFFFF\x1\x4A"+
        "\x10\xFFFF";
    const string DFA106_maxS =
        "\x2\xC5\x1\xFFFF\x1\xBF\x45\xFFFF\x1\x0\x2\xC0\xA\xFFFF\x1\x77\x10"+
        "\xFFFF";
    const string DFA106_acceptS =
        "\x2\xFFFF\x1\x2\x1\xFFFF\x45\x1\x3\xFFFF\xA\x1\x1\xFFFF\x10\x1";
    const string DFA106_specialS =
        "\x1\xFFFF\x1\x0\x1\xFFFF\x1\x1\x45\xFFFF\x1\x2\x1\xFFFF\x1\x3\xA"+
        "\xFFFF\x1\x4\x10\xFFFF}>";
    static readonly string[] DFA106_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\xD\xFFFF\x2\x2\x4\xFFFF\x1\x2\x6\xFFFF"+
            "\x1\x2\x1\xFFFF\x4\x2\x13\xFFFF\x2\x2\x5\xFFFF\x2\x2\x8\xFFFF"+
            "\x1\x2\x3\xFFFF\x2\x2\x8\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x1\x6\xFFFF\x9\x2\x1\xFFFF"+
            "\x1\x2\x2\xFFFF\x3\x2\x1\xFFFF\x1\x2\x2\xFFFF\x4\x2\x4\xFFFF"+
            "\x7\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x4\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x4\x2\x3\xFFFF"+
            "\x5\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\x2\xFFFF\x1\xE\x1\x47\x7\xFFFF\x1\x7\x5\xFFFF\x1\x42"+
            "\x1\x3D\x4\xFFFF\x1\x41\x6\xFFFF\x1\x14\x1\xFFFF\x1\x16\x1\x2E"+
            "\x1\x45\x1\x43\x4\xFFFF\x1\x5\x4\xFFFF\x1\xD\x9\xFFFF\x2\x46"+
            "\x1\xFFFF\x1\xC\x3\xFFFF\x1\x2F\x1\x9\x2\xFFFF\x1\xA\x1\x10"+
            "\x1\x6\x1\xB\x2\xFFFF\x1\x13\x3\xFFFF\x1\x15\x1\x40\x4\xFFFF"+
            "\x1\xF\x3\xFFFF\x1\x3E\x1\xFFFF\x1\x44\x2\xFFFF\x1\x2D\xA\xFFFF"+
            "\x1\x4\x1\xFFFF\x1\x47\x3\xFFFF\x1\x8\x6\xFFFF\x1\x23\x1\x26"+
            "\x1\x25\x1\x24\x1\x31\x1\x2C\x1\x27\x1\x1A\x1\x19\x1\xFFFF\x1"+
            "\x17\x2\xFFFF\x1\x3B\x1\x3C\x1\x39\x1\xFFFF\x1\x28\x2\xFFFF"+
            "\x1\x1B\x1\x1D\x1\x1C\x1\x12\x3\xFFFF\x1\x2\x1\x11\x1\x3A\x1"+
            "\x37\x1\x48\x3\x2C\x1\xFFFF\x3\x2C\x1\xFFFF\x1\x2C\x1\xFFFF"+
            "\x1\x32\x2\xFFFF\x1\x38\x1\x33\x1\x34\x1\x21\x1\xFFFF\x1\x2B"+
            "\x1\xFFFF\x1\x22\x2\xFFFF\x1\x20\x1\x2A\x1\x29\x1\x35\x3\xFFFF"+
            "\x1\x2C\x1\x1E\x1\x1F\x1\x2C\x1\x18\x1\xFFFF\x1\x30\x2\xFFFF"+
            "\x1\x36",
            "",
            "\x1\x2\x5\xFFFF\x1\x53\x4\xFFFF\x3\x2\x1\xFFFF\x1\x4E\x1\x2"+
            "\x2\xFFFF\x1\x2\xD\xFFFF\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2"+
            "\x1\x4D\x1\xFFFF\x3\x2\x1\x52\x1\xFFFF\x1\x2\x6\xFFFF\x1\x2"+
            "\x2\xFFFF\x1\x2\x1\x51\x1\x2\x3\xFFFF\x1\x4B\x2\xFFFF\x1\x4F"+
            "\x1\x55\x1\x49\x1\x50\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF\x1\x2\x5"+
            "\xFFFF\x1\x54\x1\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4"+
            "\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x4C\x4\xFFFF\x1\x2\x1\x4A\x4"+
            "\x2\x7\xFFFF\x1\x2\x5\xFFFF\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3"+
            "\x2\x1\xFFFF\x1\x2\xC\xFFFF\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1"+
            "\x2",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "\x1\x56\x3\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1B\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x3\xFFFF\x1\x2\x1F\xFFFF\x1\x2\x6\xFFFF"+
            "\x4\x2\x1\xFFFF\x4\x2\x1\xFFFF\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF"+
            "\x3\x2\x9\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x7\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x3\x2\x4\xFFFF"+
            "\x5\x2",
            "\x1\x63\x8\xFFFF\x1\x5E\x5\xFFFF\x1\x5A\xC\xFFFF\x1\x14\x1\xFFFF"+
            "\x1\x16\x7\xFFFF\x1\x5C\x4\xFFFF\x1\x62\xC\xFFFF\x1\x61\x2\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x58\x2\xFFFF\x1\x5F\x1\x65\x1\x5D\x1\x60"+
            "\x2\xFFFF\x1\x59\x3\xFFFF\x1\x15\x5\xFFFF\x1\x64\x13\xFFFF\x1"+
            "\x5B\x5\xFFFF\x1\x57\x6\xFFFF\x1\x23\x1\x26\x1\x25\x1\x24\x1"+
            "\xFFFF\x1\x2C\x1\x27\x1\x1A\x1\x19\x1\xFFFF\x1\x17\x6\xFFFF"+
            "\x1\x28\x2\xFFFF\x1\x1B\x1\x1D\x1\x1C\x9\xFFFF\x3\x2C\x1\xFFFF"+
            "\x3\x2C\x1\xFFFF\x1\x2C\x7\xFFFF\x1\x21\x1\xFFFF\x1\x2B\x1\xFFFF"+
            "\x1\x22\x2\xFFFF\x1\x20\x1\x2A\x1\x29\x4\xFFFF\x1\x2C\x1\x1E"+
            "\x1\x1F\x1\x2C\x1\x18",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x66\x2C\xFFFF\x1\x2",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA106_eot = DFA.UnpackEncodedString(DFA106_eotS);
    static readonly short[] DFA106_eof = DFA.UnpackEncodedString(DFA106_eofS);
    static readonly char[] DFA106_min = DFA.UnpackEncodedStringToUnsignedChars(DFA106_minS);
    static readonly char[] DFA106_max = DFA.UnpackEncodedStringToUnsignedChars(DFA106_maxS);
    static readonly short[] DFA106_accept = DFA.UnpackEncodedString(DFA106_acceptS);
    static readonly short[] DFA106_special = DFA.UnpackEncodedString(DFA106_specialS);
    static readonly short[][] DFA106_transition = DFA.UnpackEncodedStringArray(DFA106_transitionS);

    protected class DFA106 : DFA
    {
        public DFA106(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 106;
            this.eot = DFA106_eot;
            this.eof = DFA106_eof;
            this.min = DFA106_min;
            this.max = DFA106_max;
            this.accept = DFA106_accept;
            this.special = DFA106_special;
            this.transition = DFA106_transition;

        }

        override public string Description
        {
            get { return "926:41: (=> UPPER (=> value )? )?"; }
        }

    }


    protected internal int DFA106_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA106_1 = input.LA(1);

                   	 
                   	int index106_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA106_1 == ASSIGN_OP) ) { s = 3; }

                   	else if ( (LA106_1 == TRUE_KW) && (synpred32_Smi()) ) { s = 4; }

                   	else if ( (LA106_1 == FALSE_KW) && (synpred32_Smi()) ) { s = 5; }

                   	else if ( (LA106_1 == NULL_KW) && (synpred32_Smi()) ) { s = 6; }

                   	else if ( (LA106_1 == C_STRING) && (synpred32_Smi()) ) { s = 7; }

                   	else if ( (LA106_1 == UPPER) && (synpred32_Smi()) ) { s = 8; }

                   	else if ( (LA106_1 == LOWER) && (synpred32_Smi()) ) { s = 9; }

                   	else if ( (LA106_1 == MINUS) && (synpred32_Smi()) ) { s = 10; }

                   	else if ( (LA106_1 == NUMBER) && (synpred32_Smi()) ) { s = 11; }

                   	else if ( (LA106_1 == L_BRACE) && (synpred32_Smi()) ) { s = 12; }

                   	else if ( (LA106_1 == H_STRING) && (synpred32_Smi()) ) { s = 13; }

                   	else if ( (LA106_1 == B_STRING) && (synpred32_Smi()) ) { s = 14; }

                   	else if ( (LA106_1 == PLUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 15; }

                   	else if ( (LA106_1 == MINUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 16; }

                   	else if ( (LA106_1 == 154) && (synpred32_Smi()) ) { s = 17; }

                   	else if ( (LA106_1 == 149) && (synpred32_Smi()) ) { s = 18; }

                   	else if ( (LA106_1 == OBJECT_KW) && (synpred32_Smi()) ) { s = 19; }

                   	else if ( (LA106_1 == END_KW) && (synpred32_Smi()) ) { s = 20; }

                   	else if ( (LA106_1 == OPERATION_KW) && (synpred32_Smi()) ) { s = 21; }

                   	else if ( (LA106_1 == ERROR_KW) && (synpred32_Smi()) ) { s = 22; }

                   	else if ( (LA106_1 == 136) && (synpred32_Smi()) ) { s = 23; }

                   	else if ( (LA106_1 == 192) && (synpred32_Smi()) ) { s = 24; }

                   	else if ( (LA106_1 == 134) && (synpred32_Smi()) ) { s = 25; }

                   	else if ( (LA106_1 == 133) && (synpred32_Smi()) ) { s = 26; }

                   	else if ( (LA106_1 == 146) && (synpred32_Smi()) ) { s = 27; }

                   	else if ( (LA106_1 == 148) && (synpred32_Smi()) ) { s = 28; }

                   	else if ( (LA106_1 == 147) && (synpred32_Smi()) ) { s = 29; }

                   	else if ( (LA106_1 == 189) && (synpred32_Smi()) ) { s = 30; }

                   	else if ( (LA106_1 == 190) && (synpred32_Smi()) ) { s = 31; }

                   	else if ( (LA106_1 == 181) && (synpred32_Smi()) ) { s = 32; }

                   	else if ( (LA106_1 == 174) && (synpred32_Smi()) ) { s = 33; }

                   	else if ( (LA106_1 == 178) && (synpred32_Smi()) ) { s = 34; }

                   	else if ( (LA106_1 == 126) && (synpred32_Smi()) ) { s = 35; }

                   	else if ( (LA106_1 == 129) && (synpred32_Smi()) ) { s = 36; }

                   	else if ( (LA106_1 == 128) && (synpred32_Smi()) ) { s = 37; }

                   	else if ( (LA106_1 == 127) && (synpred32_Smi()) ) { s = 38; }

                   	else if ( (LA106_1 == 132) && (synpred32_Smi()) ) { s = 39; }

                   	else if ( (LA106_1 == 143) && (synpred32_Smi()) ) { s = 40; }

                   	else if ( (LA106_1 == 183) && (synpred32_Smi()) ) { s = 41; }

                   	else if ( (LA106_1 == 182) && (synpred32_Smi()) ) { s = 42; }

                   	else if ( (LA106_1 == 176) && (synpred32_Smi()) ) { s = 43; }

                   	else if ( (LA106_1 == 131 || (LA106_1 >= 158 && LA106_1 <= 160) || (LA106_1 >= 162 && LA106_1 <= 164) || LA106_1 == 166 || LA106_1 == 188 || LA106_1 == 191) && (synpred32_Smi()) ) { s = 44; }

                   	else if ( (LA106_1 == RESULT_KW) && (synpred32_Smi()) ) { s = 45; }

                   	else if ( (LA106_1 == ERRORS_KW) && (synpred32_Smi()) ) { s = 46; }

                   	else if ( (LA106_1 == LINKED_KW) && (synpred32_Smi()) ) { s = 47; }

                   	else if ( (LA106_1 == 194) && (synpred32_Smi()) ) { s = 48; }

                   	else if ( (LA106_1 == 130) && (synpred32_Smi()) ) { s = 49; }

                   	else if ( (LA106_1 == 168) && (synpred32_Smi()) ) { s = 50; }

                   	else if ( (LA106_1 == 172) && (synpred32_Smi()) ) { s = 51; }

                   	else if ( (LA106_1 == 173) && (synpred32_Smi()) ) { s = 52; }

                   	else if ( (LA106_1 == 184) && (synpred32_Smi()) ) { s = 53; }

                   	else if ( (LA106_1 == 197) && (synpred32_Smi()) ) { s = 54; }

                   	else if ( (LA106_1 == 156) && (synpred32_Smi()) ) { s = 55; }

                   	else if ( (LA106_1 == 171) && (synpred32_Smi()) ) { s = 56; }

                   	else if ( (LA106_1 == 141) && (synpred32_Smi()) ) { s = 57; }

                   	else if ( (LA106_1 == 155) && (synpred32_Smi()) ) { s = 58; }

                   	else if ( (LA106_1 == 139) && (synpred32_Smi()) ) { s = 59; }

                   	else if ( (LA106_1 == 140) && (synpred32_Smi()) ) { s = 60; }

                   	else if ( (LA106_1 == COMMA) && (synpred32_Smi()) ) { s = 61; }

                   	else if ( (LA106_1 == R_BRACE) && (synpred32_Smi()) ) { s = 62; }

                   	else if ( (LA106_1 == EOF) && (synpred32_Smi()) ) { s = 63; }

                   	else if ( (LA106_1 == OPTIONAL_KW) && (synpred32_Smi()) ) { s = 64; }

                   	else if ( (LA106_1 == DEFAULT_KW) && (synpred32_Smi()) ) { s = 65; }

                   	else if ( (LA106_1 == COLON) && (synpred32_Smi()) ) { s = 66; }

                   	else if ( (LA106_1 == EXCLAMATION) && (synpred32_Smi()) ) { s = 67; }

                   	else if ( (LA106_1 == R_PAREN) && (synpred32_Smi()) ) { s = 68; }

                   	else if ( (LA106_1 == EXCEPT_KW) && (synpred32_Smi()) ) { s = 69; }

                   	else if ( ((LA106_1 >= INTERSECTION && LA106_1 <= INTERSECTION_KW)) && (synpred32_Smi()) ) { s = 70; }

                   	else if ( (LA106_1 == BAR || LA106_1 == UNION_KW) && (synpred32_Smi()) ) { s = 71; }

                   	else if ( (LA106_1 == 157) && (synpred32_Smi()) ) { s = 72; }

                   	else if ( (LA106_1 == 153) ) { s = 2; }

                   	 
                   	input.Seek(index106_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA106_3 = input.LA(1);

                   	 
                   	int index106_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA106_3 == ANY_KW || (LA106_3 >= BIT_KW && LA106_3 <= BOOLEAN_KW) || LA106_3 == CHARACTER_KW || LA106_3 == CHOICE_KW || LA106_3 == EMBEDDED_KW || (LA106_3 >= ENUMERATED_KW && LA106_3 <= ERROR_KW) || LA106_3 == EXTERNAL_KW || (LA106_3 >= GENERAL_STR_KW && LA106_3 <= GRAPHIC_STR_KW) || LA106_3 == IA5_STRING_KW || LA106_3 == INTEGER_KW || LA106_3 == ISO646_STR_KW || LA106_3 == L_BRACKET || LA106_3 == NUMERIC_STR_KW || (LA106_3 >= OBJECT_KW && LA106_3 <= OCTET_KW) || LA106_3 == OPERATION_KW || LA106_3 == PRINTABLE_STR_KW || LA106_3 == REAL_KW || (LA106_3 >= SEQUENCE_KW && LA106_3 <= SET_KW) || LA106_3 == T61_STR_KW || LA106_3 == TELETEX_STR_KW || LA106_3 == UNIVERSAL_STR_KW || (LA106_3 >= UTC_TIME_KW && LA106_3 <= VISIBLE_STR_KW) || LA106_3 == 131 || LA106_3 == 137 || (LA106_3 >= 158 && LA106_3 <= 160) || (LA106_3 >= 162 && LA106_3 <= 164) || LA106_3 == 166 || LA106_3 == 179 || LA106_3 == 188 || LA106_3 == 191) ) { s = 2; }

                   	else if ( (LA106_3 == NULL_KW) ) { s = 73; }

                   	else if ( (LA106_3 == UPPER) ) { s = 74; }

                   	else if ( (LA106_3 == LOWER) ) { s = 75; }

                   	else if ( (LA106_3 == TRUE_KW) && (synpred32_Smi()) ) { s = 76; }

                   	else if ( (LA106_3 == FALSE_KW) && (synpred32_Smi()) ) { s = 77; }

                   	else if ( (LA106_3 == C_STRING) && (synpred32_Smi()) ) { s = 78; }

                   	else if ( (LA106_3 == MINUS) && (synpred32_Smi()) ) { s = 79; }

                   	else if ( (LA106_3 == NUMBER) && (synpred32_Smi()) ) { s = 80; }

                   	else if ( (LA106_3 == L_BRACE) && (synpred32_Smi()) ) { s = 81; }

                   	else if ( (LA106_3 == H_STRING) && (synpred32_Smi()) ) { s = 82; }

                   	else if ( (LA106_3 == B_STRING) && (synpred32_Smi()) ) { s = 83; }

                   	else if ( (LA106_3 == PLUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 84; }

                   	else if ( (LA106_3 == MINUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 85; }

                   	 
                   	input.Seek(index106_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA106_73 = input.LA(1);

                   	 
                   	int index106_73 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Smi()) ) { s = 85; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index106_73);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA106_75 = input.LA(1);

                   	 
                   	int index106_75 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA106_75 == LESS) ) { s = 2; }

                   	else if ( (LA106_75 == END_KW) && (synpred32_Smi()) ) { s = 20; }

                   	else if ( (LA106_75 == UPPER) && (synpred32_Smi()) ) { s = 87; }

                   	else if ( (LA106_75 == LOWER) && (synpred32_Smi()) ) { s = 88; }

                   	else if ( (LA106_75 == OPERATION_KW) && (synpred32_Smi()) ) { s = 21; }

                   	else if ( (LA106_75 == ERROR_KW) && (synpred32_Smi()) ) { s = 22; }

                   	else if ( (LA106_75 == 136) && (synpred32_Smi()) ) { s = 23; }

                   	else if ( (LA106_75 == 192) && (synpred32_Smi()) ) { s = 24; }

                   	else if ( (LA106_75 == 134) && (synpred32_Smi()) ) { s = 25; }

                   	else if ( (LA106_75 == 133) && (synpred32_Smi()) ) { s = 26; }

                   	else if ( (LA106_75 == 146) && (synpred32_Smi()) ) { s = 27; }

                   	else if ( (LA106_75 == 148) && (synpred32_Smi()) ) { s = 28; }

                   	else if ( (LA106_75 == 147) && (synpred32_Smi()) ) { s = 29; }

                   	else if ( (LA106_75 == 189) && (synpred32_Smi()) ) { s = 30; }

                   	else if ( (LA106_75 == 190) && (synpred32_Smi()) ) { s = 31; }

                   	else if ( (LA106_75 == 181) && (synpred32_Smi()) ) { s = 32; }

                   	else if ( (LA106_75 == OBJECT_KW) && (synpred32_Smi()) ) { s = 89; }

                   	else if ( (LA106_75 == 174) && (synpred32_Smi()) ) { s = 33; }

                   	else if ( (LA106_75 == 178) && (synpred32_Smi()) ) { s = 34; }

                   	else if ( (LA106_75 == 126) && (synpred32_Smi()) ) { s = 35; }

                   	else if ( (LA106_75 == 129) && (synpred32_Smi()) ) { s = 36; }

                   	else if ( (LA106_75 == 128) && (synpred32_Smi()) ) { s = 37; }

                   	else if ( (LA106_75 == 127) && (synpred32_Smi()) ) { s = 38; }

                   	else if ( (LA106_75 == 132) && (synpred32_Smi()) ) { s = 39; }

                   	else if ( (LA106_75 == 143) && (synpred32_Smi()) ) { s = 40; }

                   	else if ( (LA106_75 == 183) && (synpred32_Smi()) ) { s = 41; }

                   	else if ( (LA106_75 == 182) && (synpred32_Smi()) ) { s = 42; }

                   	else if ( (LA106_75 == 176) && (synpred32_Smi()) ) { s = 43; }

                   	else if ( (LA106_75 == 131 || (LA106_75 >= 158 && LA106_75 <= 160) || (LA106_75 >= 162 && LA106_75 <= 164) || LA106_75 == 166 || LA106_75 == 188 || LA106_75 == 191) && (synpred32_Smi()) ) { s = 44; }

                   	else if ( (LA106_75 == COLON) && (synpred32_Smi()) ) { s = 90; }

                   	else if ( (LA106_75 == TRUE_KW) && (synpred32_Smi()) ) { s = 91; }

                   	else if ( (LA106_75 == FALSE_KW) && (synpred32_Smi()) ) { s = 92; }

                   	else if ( (LA106_75 == NULL_KW) && (synpred32_Smi()) ) { s = 93; }

                   	else if ( (LA106_75 == C_STRING) && (synpred32_Smi()) ) { s = 94; }

                   	else if ( (LA106_75 == MINUS) && (synpred32_Smi()) ) { s = 95; }

                   	else if ( (LA106_75 == NUMBER) && (synpred32_Smi()) ) { s = 96; }

                   	else if ( (LA106_75 == L_BRACE) && (synpred32_Smi()) ) { s = 97; }

                   	else if ( (LA106_75 == H_STRING) && (synpred32_Smi()) ) { s = 98; }

                   	else if ( (LA106_75 == B_STRING) && (synpred32_Smi()) ) { s = 99; }

                   	else if ( (LA106_75 == PLUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 100; }

                   	else if ( (LA106_75 == MINUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 101; }

                   	 
                   	input.Seek(index106_75);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA106_86 = input.LA(1);

                   	 
                   	int index106_86 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA106_86 == UPPER) ) { s = 2; }

                   	else if ( (LA106_86 == LOWER) && (synpred32_Smi()) ) { s = 102; }

                   	 
                   	input.Seek(index106_86);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae106 =
            new NoViableAltException(dfa.Description, 106, _s, input);
        dfa.Error(nvae106);
        throw nvae106;
    }
    const string DFA105_eotS =
        "\x47\xFFFF";
    const string DFA105_eofS =
        "\x1\xE\x46\xFFFF";
    const string DFA105_minS =
        "\x1\xA\x4\xFFFF\x2\x0\x40\xFFFF";
    const string DFA105_maxS =
        "\x1\xC5\x4\xFFFF\x2\x0\x40\xFFFF";
    const string DFA105_acceptS =
        "\x1\xFFFF\x4\x1\x2\xFFFF\x7\x1\x1\x2\x38\xFFFF";
    const string DFA105_specialS =
        "\x1\x0\x4\xFFFF\x1\x1\x1\x2\x40\xFFFF}>";
    static readonly string[] DFA105_transitionS = {
            "\x1\xE\x2\xFFFF\x1\xB\x1\xE\x7\xFFFF\x1\x4\x5\xFFFF\x2\xE\x4"+
            "\xFFFF\x1\xE\x6\xFFFF\x1\xE\x1\xFFFF\x4\xE\x4\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\xA\x9\xFFFF\x2\xE\x1\xFFFF\x1\x9\x3\xFFFF\x1\xE\x1"+
            "\x6\x2\xFFFF\x1\x7\x1\xD\x1\x3\x1\x8\x2\xFFFF\x1\xE\x3\xFFFF"+
            "\x2\xE\x4\xFFFF\x1\xC\x3\xFFFF\x1\xE\x1\xFFFF\x1\xE\x2\xFFFF"+
            "\x1\xE\xA\xFFFF\x1\x1\x1\xFFFF\x1\xE\x3\xFFFF\x1\x5\x6\xFFFF"+
            "\x9\xE\x1\xFFFF\x1\xE\x2\xFFFF\x3\xE\x1\xFFFF\x1\xE\x2\xFFFF"+
            "\x4\xE\x4\xFFFF\x7\xE\x1\xFFFF\x3\xE\x1\xFFFF\x1\xE\x1\xFFFF"+
            "\x1\xE\x2\xFFFF\x4\xE\x1\xFFFF\x1\xE\x1\xFFFF\x1\xE\x2\xFFFF"+
            "\x4\xE\x3\xFFFF\x5\xE\x1\xFFFF\x1\xE\x2\xFFFF\x1\xE",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA105_eot = DFA.UnpackEncodedString(DFA105_eotS);
    static readonly short[] DFA105_eof = DFA.UnpackEncodedString(DFA105_eofS);
    static readonly char[] DFA105_min = DFA.UnpackEncodedStringToUnsignedChars(DFA105_minS);
    static readonly char[] DFA105_max = DFA.UnpackEncodedStringToUnsignedChars(DFA105_maxS);
    static readonly short[] DFA105_accept = DFA.UnpackEncodedString(DFA105_acceptS);
    static readonly short[] DFA105_special = DFA.UnpackEncodedString(DFA105_specialS);
    static readonly short[][] DFA105_transition = DFA.UnpackEncodedStringArray(DFA105_transitionS);

    protected class DFA105 : DFA
    {
        public DFA105(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 105;
            this.eot = DFA105_eot;
            this.eof = DFA105_eof;
            this.min = DFA105_min;
            this.max = DFA105_max;
            this.accept = DFA105_accept;
            this.special = DFA105_special;
            this.transition = DFA105_transition;

        }

        override public string Description
        {
            get { return "926:59: (=> value )?"; }
        }

    }


    protected internal int DFA105_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA105_0 = input.LA(1);

                   	 
                   	int index105_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA105_0 == TRUE_KW) && (synpred33_Smi()) ) { s = 1; }

                   	else if ( (LA105_0 == FALSE_KW) && (synpred33_Smi()) ) { s = 2; }

                   	else if ( (LA105_0 == NULL_KW) && (synpred33_Smi()) ) { s = 3; }

                   	else if ( (LA105_0 == C_STRING) && (synpred33_Smi()) ) { s = 4; }

                   	else if ( (LA105_0 == UPPER) ) { s = 5; }

                   	else if ( (LA105_0 == LOWER) ) { s = 6; }

                   	else if ( (LA105_0 == MINUS) && (synpred33_Smi()) ) { s = 7; }

                   	else if ( (LA105_0 == NUMBER) && (synpred33_Smi()) ) { s = 8; }

                   	else if ( (LA105_0 == L_BRACE) && (synpred33_Smi()) ) { s = 9; }

                   	else if ( (LA105_0 == H_STRING) && (synpred33_Smi()) ) { s = 10; }

                   	else if ( (LA105_0 == B_STRING) && (synpred33_Smi()) ) { s = 11; }

                   	else if ( (LA105_0 == PLUS_INFINITY_KW) && (synpred33_Smi()) ) { s = 12; }

                   	else if ( (LA105_0 == MINUS_INFINITY_KW) && (synpred33_Smi()) ) { s = 13; }

                   	else if ( (LA105_0 == EOF || LA105_0 == ASSIGN_OP || LA105_0 == BAR || (LA105_0 >= COLON && LA105_0 <= COMMA) || LA105_0 == DEFAULT_KW || LA105_0 == END_KW || (LA105_0 >= ERROR_KW && LA105_0 <= EXCLAMATION) || (LA105_0 >= INTERSECTION && LA105_0 <= INTERSECTION_KW) || LA105_0 == LINKED_KW || LA105_0 == OBJECT_KW || (LA105_0 >= OPERATION_KW && LA105_0 <= OPTIONAL_KW) || LA105_0 == R_BRACE || LA105_0 == R_PAREN || LA105_0 == RESULT_KW || LA105_0 == UNION_KW || (LA105_0 >= 126 && LA105_0 <= 134) || LA105_0 == 136 || (LA105_0 >= 139 && LA105_0 <= 141) || LA105_0 == 143 || (LA105_0 >= 146 && LA105_0 <= 149) || (LA105_0 >= 154 && LA105_0 <= 160) || (LA105_0 >= 162 && LA105_0 <= 164) || LA105_0 == 166 || LA105_0 == 168 || (LA105_0 >= 171 && LA105_0 <= 174) || LA105_0 == 176 || LA105_0 == 178 || (LA105_0 >= 181 && LA105_0 <= 184) || (LA105_0 >= 188 && LA105_0 <= 192) || LA105_0 == 194 || LA105_0 == 197) ) { s = 14; }

                   	 
                   	input.Seek(index105_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA105_5 = input.LA(1);

                   	 
                   	int index105_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_Smi()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index105_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA105_6 = input.LA(1);

                   	 
                   	int index105_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_Smi()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index105_6);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae105 =
            new NoViableAltException(dfa.Description, 105, _s, input);
        dfa.Error(nvae105);
        throw nvae105;
    }
    const string DFA117_eotS =
        "\xB\xFFFF";
    const string DFA117_eofS =
        "\xB\xFFFF";
    const string DFA117_minS =
        "\x1\x7\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA117_maxS =
        "\x1\xBF\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA117_acceptS =
        "\x6\xFFFF\x1\x3\x1\x1\x1\x2\x2\xFFFF";
    const string DFA117_specialS =
        "\x1\xFFFF\x1\x0\x1\x1\x2\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4}>";
    static readonly string[] DFA117_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x7",
            "\x1\x7",
            "\x1\x9",
            "\x1\xA",
            "\x1\x7",
            "",
            "",
            "",
            "\x1\x7",
            "\x1\x7"
    };

    static readonly short[] DFA117_eot = DFA.UnpackEncodedString(DFA117_eotS);
    static readonly short[] DFA117_eof = DFA.UnpackEncodedString(DFA117_eofS);
    static readonly char[] DFA117_min = DFA.UnpackEncodedStringToUnsignedChars(DFA117_minS);
    static readonly char[] DFA117_max = DFA.UnpackEncodedStringToUnsignedChars(DFA117_maxS);
    static readonly short[] DFA117_accept = DFA.UnpackEncodedString(DFA117_acceptS);
    static readonly short[] DFA117_special = DFA.UnpackEncodedString(DFA117_specialS);
    static readonly short[][] DFA117_transition = DFA.UnpackEncodedStringArray(DFA117_transitionS);

    protected class DFA117 : DFA
    {
        public DFA117(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 117;
            this.eot = DFA117_eot;
            this.eof = DFA117_eof;
            this.min = DFA117_min;
            this.max = DFA117_max;
            this.accept = DFA117_accept;
            this.special = DFA117_special;
            this.transition = DFA117_transition;

        }

        override public string Description
        {
            get { return "936:0: modulecompliance_macro_syntax : (=> smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );"; }
        }

    }


    protected internal int DFA117_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA117_1 = input.LA(1);

                   	 
                   	int index117_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA117_1 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index117_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA117_2 = input.LA(1);

                   	 
                   	int index117_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA117_2 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index117_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA117_5 = input.LA(1);

                   	 
                   	int index117_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA117_5 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index117_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA117_9 = input.LA(1);

                   	 
                   	int index117_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA117_9 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index117_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA117_10 = input.LA(1);

                   	 
                   	int index117_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA117_10 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index117_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae117 =
            new NoViableAltException(dfa.Description, 117, _s, input);
        dfa.Error(nvae117);
        throw nvae117;
    }
    const string DFA130_eotS =
        "\x10\xFFFF";
    const string DFA130_eofS =
        "\x10\xFFFF";
    const string DFA130_minS =
        "\x2\xD\x1\xFFFF\x2\xD\x1\x0\x1\xD\x1\x0\x1\xD\x1\xFFFF\x1\xD\x1"+
        "\x0\x1\xD\x1\x0\x2\xD";
    const string DFA130_maxS =
        "\x2\x77\x1\xFFFF\x2\x77\x1\x0\x1\x77\x1\x0\x1\x77\x1\xFFFF\x1\x77"+
        "\x1\x0\x1\x77\x1\x0\x2\x77";
    const string DFA130_acceptS =
        "\x2\xFFFF\x1\x2\x6\xFFFF\x1\x1\x6\xFFFF";
    const string DFA130_specialS =
        "\x5\xFFFF\x1\x0\x1\xFFFF\x1\x1\x3\xFFFF\x1\x2\x1\xFFFF\x1\x3\x2"+
        "\xFFFF}>";
    static readonly string[] DFA130_transitionS = {
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x6\xFFFF\x1\x4\x15\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x3\x2\xFFFF\x4\x2\xC\xFFFF"+
            "\x1\x2\x3\xFFFF\x1\x5\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\x6\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2\x2"+
            "\xFFFF\x4\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x7\xF\xFFFF\x1\x2\x5"+
            "\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x8\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\xA\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\xC\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\xB\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\xE\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\xD\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\xF\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\xA\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\xC\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\xB\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2"
    };

    static readonly short[] DFA130_eot = DFA.UnpackEncodedString(DFA130_eotS);
    static readonly short[] DFA130_eof = DFA.UnpackEncodedString(DFA130_eofS);
    static readonly char[] DFA130_min = DFA.UnpackEncodedStringToUnsignedChars(DFA130_minS);
    static readonly char[] DFA130_max = DFA.UnpackEncodedStringToUnsignedChars(DFA130_maxS);
    static readonly short[] DFA130_accept = DFA.UnpackEncodedString(DFA130_acceptS);
    static readonly short[] DFA130_special = DFA.UnpackEncodedString(DFA130_specialS);
    static readonly short[][] DFA130_transition = DFA.UnpackEncodedStringArray(DFA130_transitionS);

    protected class DFA130 : DFA
    {
        public DFA130(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 130;
            this.eot = DFA130_eot;
            this.eof = DFA130_eof;
            this.min = DFA130_min;
            this.max = DFA130_max;
            this.accept = DFA130_accept;
            this.special = DFA130_special;
            this.transition = DFA130_transition;

        }

        override public string Description
        {
            get { return "967:55: (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value )"; }
        }

    }


    protected internal int DFA130_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA130_5 = input.LA(1);

                   	 
                   	int index130_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index130_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA130_7 = input.LA(1);

                   	 
                   	int index130_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index130_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA130_11 = input.LA(1);

                   	 
                   	int index130_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index130_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA130_13 = input.LA(1);

                   	 
                   	int index130_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index130_13);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae130 =
            new NoViableAltException(dfa.Description, 130, _s, input);
        dfa.Error(nvae130);
        throw nvae130;
    }
    const string DFA134_eotS =
        "\xB\xFFFF";
    const string DFA134_eofS =
        "\xB\xFFFF";
    const string DFA134_minS =
        "\x1\x7\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA134_maxS =
        "\x1\xBF\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA134_acceptS =
        "\x6\xFFFF\x1\x3\x1\x1\x1\x2\x2\xFFFF";
    const string DFA134_specialS =
        "\x1\xFFFF\x1\x0\x1\x1\x2\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4}>";
    static readonly string[] DFA134_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x7",
            "\x1\x7",
            "\x1\x9",
            "\x1\xA",
            "\x1\x7",
            "",
            "",
            "",
            "\x1\x7",
            "\x1\x7"
    };

    static readonly short[] DFA134_eot = DFA.UnpackEncodedString(DFA134_eotS);
    static readonly short[] DFA134_eof = DFA.UnpackEncodedString(DFA134_eofS);
    static readonly char[] DFA134_min = DFA.UnpackEncodedStringToUnsignedChars(DFA134_minS);
    static readonly char[] DFA134_max = DFA.UnpackEncodedStringToUnsignedChars(DFA134_maxS);
    static readonly short[] DFA134_accept = DFA.UnpackEncodedString(DFA134_acceptS);
    static readonly short[] DFA134_special = DFA.UnpackEncodedString(DFA134_specialS);
    static readonly short[][] DFA134_transition = DFA.UnpackEncodedStringArray(DFA134_transitionS);

    protected class DFA134 : DFA
    {
        public DFA134(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 134;
            this.eot = DFA134_eot;
            this.eof = DFA134_eof;
            this.min = DFA134_min;
            this.max = DFA134_max;
            this.accept = DFA134_accept;
            this.special = DFA134_special;
            this.transition = DFA134_transition;

        }

        override public string Description
        {
            get { return "969:0: agentcapabilities_macro_syntax : (=> smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );"; }
        }

    }


    protected internal int DFA134_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA134_1 = input.LA(1);

                   	 
                   	int index134_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA134_1 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index134_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA134_2 = input.LA(1);

                   	 
                   	int index134_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA134_2 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index134_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA134_5 = input.LA(1);

                   	 
                   	int index134_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA134_5 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index134_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA134_9 = input.LA(1);

                   	 
                   	int index134_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA134_9 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index134_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA134_10 = input.LA(1);

                   	 
                   	int index134_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA134_10 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index134_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae134 =
            new NoViableAltException(dfa.Description, 134, _s, input);
        dfa.Error(nvae134);
        throw nvae134;
    }
    const string DFA137_eotS =
        "\x10\xFFFF";
    const string DFA137_eofS =
        "\x1\x2\xF\xFFFF";
    const string DFA137_minS =
        "\x1\xA\x1\xD\x1\xFFFF\x1\x0\xC\xFFFF";
    const string DFA137_maxS =
        "\x1\xC5\x1\x77\x1\xFFFF\x1\x0\xC\xFFFF";
    const string DFA137_acceptS =
        "\x2\xFFFF\x1\x2\x1\xFFFF\xC\x1";
    const string DFA137_specialS =
        "\x1\xFFFF\x1\x0\x1\xFFFF\x1\x1\xC\xFFFF}>";
    static readonly string[] DFA137_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\xD\xFFFF\x2\x2\x4\xFFFF\x1\x2\x6\xFFFF"+
            "\x1\x2\x1\xFFFF\x4\x2\x13\xFFFF\x2\x2\x5\xFFFF\x2\x2\x8\xFFFF"+
            "\x1\x2\x3\xFFFF\x2\x2\x8\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x2\x6\xFFFF\x9\x2\x1\xFFFF"+
            "\x1\x2\x2\xFFFF\x2\x2\x1\x1\x1\xFFFF\x1\x2\x2\xFFFF\x3\x2\x6"+
            "\xFFFF\x2\x2\x1\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x1"+
            "\xFFFF\x1\x2\x2\xFFFF\x4\x2\x1\xFFFF\x3\x2\x2\xFFFF\x4\x2\x3"+
            "\xFFFF\x5\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\xD\x8\xFFFF\x1\x3\x1C\xFFFF\x1\x5\x4\xFFFF\x1\xC\xC\xFFFF"+
            "\x1\xB\x4\xFFFF\x1\x8\x2\xFFFF\x1\x9\x1\xF\x1\x6\x1\xA\xC\xFFFF"+
            "\x1\xE\x13\xFFFF\x1\x4\x5\xFFFF\x1\x7",
            "",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA137_eot = DFA.UnpackEncodedString(DFA137_eotS);
    static readonly short[] DFA137_eof = DFA.UnpackEncodedString(DFA137_eofS);
    static readonly char[] DFA137_min = DFA.UnpackEncodedStringToUnsignedChars(DFA137_minS);
    static readonly char[] DFA137_max = DFA.UnpackEncodedStringToUnsignedChars(DFA137_maxS);
    static readonly short[] DFA137_accept = DFA.UnpackEncodedString(DFA137_acceptS);
    static readonly short[] DFA137_special = DFA.UnpackEncodedString(DFA137_specialS);
    static readonly short[][] DFA137_transition = DFA.UnpackEncodedStringArray(DFA137_transitionS);

    protected class DFA137 : DFA
    {
        public DFA137(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 137;
            this.eot = DFA137_eot;
            this.eof = DFA137_eof;
            this.min = DFA137_min;
            this.max = DFA137_max;
            this.accept = DFA137_accept;
            this.special = DFA137_special;
            this.transition = DFA137_transition;

        }

        override public string Description
        {
            get { return "986:21: (=> 'DESCRIPTION' value )?"; }
        }

    }


    protected internal int DFA137_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA137_1 = input.LA(1);

                   	 
                   	int index137_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA137_1 == C_STRING) ) { s = 3; }

                   	else if ( (LA137_1 == TRUE_KW) && (synpred39_Smi()) ) { s = 4; }

                   	else if ( (LA137_1 == FALSE_KW) && (synpred39_Smi()) ) { s = 5; }

                   	else if ( (LA137_1 == NULL_KW) && (synpred39_Smi()) ) { s = 6; }

                   	else if ( (LA137_1 == UPPER) && (synpred39_Smi()) ) { s = 7; }

                   	else if ( (LA137_1 == LOWER) && (synpred39_Smi()) ) { s = 8; }

                   	else if ( (LA137_1 == MINUS) && (synpred39_Smi()) ) { s = 9; }

                   	else if ( (LA137_1 == NUMBER) && (synpred39_Smi()) ) { s = 10; }

                   	else if ( (LA137_1 == L_BRACE) && (synpred39_Smi()) ) { s = 11; }

                   	else if ( (LA137_1 == H_STRING) && (synpred39_Smi()) ) { s = 12; }

                   	else if ( (LA137_1 == B_STRING) && (synpred39_Smi()) ) { s = 13; }

                   	else if ( (LA137_1 == PLUS_INFINITY_KW) && (synpred39_Smi()) ) { s = 14; }

                   	else if ( (LA137_1 == MINUS_INFINITY_KW) && (synpred39_Smi()) ) { s = 15; }

                   	 
                   	input.Seek(index137_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA137_3 = input.LA(1);

                   	 
                   	int index137_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred39_Smi()) ) { s = 15; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index137_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae137 =
            new NoViableAltException(dfa.Description, 137, _s, input);
        dfa.Error(nvae137);
        throw nvae137;
    }
    const string DFA141_eotS =
        "\x2A\xFFFF";
    const string DFA141_eofS =
        "\x13\xFFFF\x1\x27\x1\x22\x15\xFFFF";
    const string DFA141_minS =
        "\x1\x7\xA\xFFFF\x1\x0\x7\xFFFF\x1\x1D\x1\xD\xE\xFFFF\x1\x4A\x6\xFFFF";
    const string DFA141_maxS =
        "\x1\xBF\xA\xFFFF\x1\x0\x7\xFFFF\x1\x61\x1\x77\xE\xFFFF\x1\x77\x6"+
        "\xFFFF";
    const string DFA141_acceptS =
        "\x1\xFFFF\xA\x1\x1\xFFFF\x7\x1\x2\xFFFF\xD\x1\x1\x2\x1\xFFFF\x6"+
        "\x1";
    const string DFA141_specialS =
        "\x1\x0\xA\xFFFF\x1\x1\x7\xFFFF\x1\x2\x1\x3\xE\xFFFF\x1\x4\x6\xFFFF}>";
    static readonly string[] DFA141_transitionS = {
            "\x1\x1\x5\xFFFF\x1\x22\x4\xFFFF\x1\x2\x1\x5\x1\x3\x1\xFFFF\x1"+
            "\x22\x1\x4\x2\xFFFF\x1\x6\xD\xFFFF\x1\x7\x1\xFFFF\x1\x8\x1\x16"+
            "\x6\xFFFF\x1\x9\x1\x22\x1\xFFFF\x3\x5\x1\x22\x1\xFFFF\x1\x5"+
            "\x6\xFFFF\x1\xA\x2\xFFFF\x1\x5\x1\x22\x1\x12\x3\xFFFF\x1\x14"+
            "\x2\xFFFF\x2\x22\x1\xB\x1\x22\x1\x5\x1\xFFFF\x1\xC\x1\xD\x2"+
            "\xFFFF\x1\x15\x5\xFFFF\x1\x22\x1\xFFFF\x1\x5\x4\xFFFF\x1\xE"+
            "\x3\xFFFF\x1\x10\x1\x11\x4\xFFFF\x1\x5\x1\xFFFF\x1\x5\x1\x22"+
            "\x4\xFFFF\x1\x5\x1\x13\x4\x5\x7\xFFFF\x1\x1F\x5\xFFFF\x1\x21"+
            "\x14\xFFFF\x1\x1E\x1\x18\x1\x1D\x1\xFFFF\x1\x1A\x1\x1C\x1\x19"+
            "\x1\xFFFF\x1\x17\xC\xFFFF\x1\xF\x8\xFFFF\x1\x1B\x2\xFFFF\x1"+
            "\x20",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x25\x7\xFFFF\x1\x23\x21\xFFFF\x1\x24\x19\xFFFF\x1\x26",
            "\x1\x22\x8\xFFFF\x1\x22\x5\xFFFF\x2\x22\x15\xFFFF\x1\x22\x4"+
            "\xFFFF\x1\x22\xC\xFFFF\x1\x22\x2\xFFFF\x1\x28\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x4\x22\xC\xFFFF\x1\x22\x3\xFFFF\x1\x22\xF\xFFFF\x1"+
            "\x22\x5\xFFFF\x1\x22",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x22\x2C\xFFFF\x1\x29",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA141_eot = DFA.UnpackEncodedString(DFA141_eotS);
    static readonly short[] DFA141_eof = DFA.UnpackEncodedString(DFA141_eofS);
    static readonly char[] DFA141_min = DFA.UnpackEncodedStringToUnsignedChars(DFA141_minS);
    static readonly char[] DFA141_max = DFA.UnpackEncodedStringToUnsignedChars(DFA141_maxS);
    static readonly short[] DFA141_accept = DFA.UnpackEncodedString(DFA141_acceptS);
    static readonly short[] DFA141_special = DFA.UnpackEncodedString(DFA141_specialS);
    static readonly short[][] DFA141_transition = DFA.UnpackEncodedStringArray(DFA141_transitionS);

    protected class DFA141 : DFA
    {
        public DFA141(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 141;
            this.eot = DFA141_eot;
            this.eof = DFA141_eof;
            this.min = DFA141_min;
            this.max = DFA141_max;
            this.accept = DFA141_accept;
            this.special = DFA141_special;
            this.transition = DFA141_transition;

        }

        override public string Description
        {
            get { return "992:0: typeorvalue : (=> type | value );"; }
        }

    }


    protected internal int DFA141_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA141_0 = input.LA(1);

                   	 
                   	int index141_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA141_0 == ANY_KW) && (synpred40_Smi()) ) { s = 1; }

                   	else if ( (LA141_0 == BIT_KW) && (synpred40_Smi()) ) { s = 2; }

                   	else if ( (LA141_0 == BOOLEAN_KW) && (synpred40_Smi()) ) { s = 3; }

                   	else if ( (LA141_0 == CHARACTER_KW) && (synpred40_Smi()) ) { s = 4; }

                   	else if ( (LA141_0 == BMP_STR_KW || (LA141_0 >= GENERAL_STR_KW && LA141_0 <= GRAPHIC_STR_KW) || LA141_0 == IA5_STRING_KW || LA141_0 == ISO646_STR_KW || LA141_0 == NUMERIC_STR_KW || LA141_0 == PRINTABLE_STR_KW || LA141_0 == T61_STR_KW || LA141_0 == TELETEX_STR_KW || LA141_0 == UNIVERSAL_STR_KW || (LA141_0 >= UTC_TIME_KW && LA141_0 <= VISIBLE_STR_KW)) && (synpred40_Smi()) ) { s = 5; }

                   	else if ( (LA141_0 == CHOICE_KW) && (synpred40_Smi()) ) { s = 6; }

                   	else if ( (LA141_0 == EMBEDDED_KW) && (synpred40_Smi()) ) { s = 7; }

                   	else if ( (LA141_0 == ENUMERATED_KW) && (synpred40_Smi()) ) { s = 8; }

                   	else if ( (LA141_0 == EXTERNAL_KW) && (synpred40_Smi()) ) { s = 9; }

                   	else if ( (LA141_0 == INTEGER_KW) && (synpred40_Smi()) ) { s = 10; }

                   	else if ( (LA141_0 == NULL_KW) ) { s = 11; }

                   	else if ( (LA141_0 == OBJECT_KW) && (synpred40_Smi()) ) { s = 12; }

                   	else if ( (LA141_0 == OCTET_KW) && (synpred40_Smi()) ) { s = 13; }

                   	else if ( (LA141_0 == REAL_KW) && (synpred40_Smi()) ) { s = 14; }

                   	else if ( (LA141_0 == 179) && (synpred40_Smi()) ) { s = 15; }

                   	else if ( (LA141_0 == SEQUENCE_KW) && (synpred40_Smi()) ) { s = 16; }

                   	else if ( (LA141_0 == SET_KW) && (synpred40_Smi()) ) { s = 17; }

                   	else if ( (LA141_0 == L_BRACKET) && (synpred40_Smi()) ) { s = 18; }

                   	else if ( (LA141_0 == UPPER) ) { s = 19; }

                   	else if ( (LA141_0 == LOWER) ) { s = 20; }

                   	else if ( (LA141_0 == OPERATION_KW) && (synpred40_Smi()) ) { s = 21; }

                   	else if ( (LA141_0 == ERROR_KW) && (synpred40_Smi()) ) { s = 22; }

                   	else if ( (LA141_0 == 166) && (synpred40_Smi()) ) { s = 23; }

                   	else if ( (LA141_0 == 159) && (synpred40_Smi()) ) { s = 24; }

                   	else if ( (LA141_0 == 164) && (synpred40_Smi()) ) { s = 25; }

                   	else if ( (LA141_0 == 162) && (synpred40_Smi()) ) { s = 26; }

                   	else if ( (LA141_0 == 188) && (synpred40_Smi()) ) { s = 27; }

                   	else if ( (LA141_0 == 163) && (synpred40_Smi()) ) { s = 28; }

                   	else if ( (LA141_0 == 160) && (synpred40_Smi()) ) { s = 29; }

                   	else if ( (LA141_0 == 158) && (synpred40_Smi()) ) { s = 30; }

                   	else if ( (LA141_0 == 131) && (synpred40_Smi()) ) { s = 31; }

                   	else if ( (LA141_0 == 191) && (synpred40_Smi()) ) { s = 32; }

                   	else if ( (LA141_0 == 137) && (synpred40_Smi()) ) { s = 33; }

                   	else if ( (LA141_0 == B_STRING || LA141_0 == C_STRING || LA141_0 == FALSE_KW || LA141_0 == H_STRING || LA141_0 == L_BRACE || (LA141_0 >= MINUS && LA141_0 <= MINUS_INFINITY_KW) || LA141_0 == NUMBER || LA141_0 == PLUS_INFINITY_KW || LA141_0 == TRUE_KW) ) { s = 34; }

                   	 
                   	input.Seek(index141_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA141_11 = input.LA(1);

                   	 
                   	int index141_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred40_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index141_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA141_19 = input.LA(1);

                   	 
                   	int index141_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA141_19 == DOT) ) { s = 35; }

                   	else if ( (LA141_19 == L_PAREN) && (synpred40_Smi()) ) { s = 36; }

                   	else if ( (LA141_19 == COMMA) && (synpred40_Smi()) ) { s = 37; }

                   	else if ( (LA141_19 == R_BRACE) && (synpred40_Smi()) ) { s = 38; }

                   	else if ( (LA141_19 == EOF) && (synpred40_Smi()) ) { s = 39; }

                   	 
                   	input.Seek(index141_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA141_20 = input.LA(1);

                   	 
                   	int index141_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA141_20 == LESS) && (synpred40_Smi()) ) { s = 40; }

                   	else if ( (LA141_20 == EOF || LA141_20 == B_STRING || LA141_20 == C_STRING || (LA141_20 >= COLON && LA141_20 <= COMMA) || LA141_20 == FALSE_KW || LA141_20 == H_STRING || LA141_20 == L_BRACE || LA141_20 == LOWER || (LA141_20 >= MINUS && LA141_20 <= NUMBER) || LA141_20 == PLUS_INFINITY_KW || LA141_20 == R_BRACE || LA141_20 == TRUE_KW || LA141_20 == UPPER) ) { s = 34; }

                   	 
                   	input.Seek(index141_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA141_35 = input.LA(1);

                   	 
                   	int index141_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA141_35 == UPPER) && (synpred40_Smi()) ) { s = 41; }

                   	else if ( (LA141_35 == LOWER) ) { s = 34; }

                   	 
                   	input.Seek(index141_35);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae141 =
            new NoViableAltException(dfa.Description, 141, _s, input);
        dfa.Error(nvae141);
        throw nvae141;
    }
    const string DFA143_eotS =
        "\x24\xFFFF";
    const string DFA143_eofS =
        "\x24\xFFFF";
    const string DFA143_minS =
        "\x1\x7\x1\x0\x22\xFFFF";
    const string DFA143_maxS =
        "\x1\xBF\x1\x0\x22\xFFFF";
    const string DFA143_acceptS =
        "\x2\xFFFF\x1\x2\x20\xFFFF\x1\x1";
    const string DFA143_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA143_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\x6\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xD\xFFFF\x1\x2\x1\xFFFF\x2\x2\x3\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x3\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF\x1\x2\x7\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF\x1\x2\x1\xFFFF"+
            "\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF\x1\x2\x14\xFFFF"+
            "\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF\x1\x2\x8\xFFFF"+
            "\x1\x2\x2\xFFFF\x1\x2",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA143_eot = DFA.UnpackEncodedString(DFA143_eotS);
    static readonly short[] DFA143_eof = DFA.UnpackEncodedString(DFA143_eofS);
    static readonly char[] DFA143_min = DFA.UnpackEncodedStringToUnsignedChars(DFA143_minS);
    static readonly char[] DFA143_max = DFA.UnpackEncodedStringToUnsignedChars(DFA143_maxS);
    static readonly short[] DFA143_accept = DFA.UnpackEncodedString(DFA143_acceptS);
    static readonly short[] DFA143_special = DFA.UnpackEncodedString(DFA143_specialS);
    static readonly short[][] DFA143_transition = DFA.UnpackEncodedStringArray(DFA143_transitionS);

    protected class DFA143 : DFA
    {
        public DFA143(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 143;
            this.eot = DFA143_eot;
            this.eof = DFA143_eof;
            this.min = DFA143_min;
            this.max = DFA143_max;
            this.accept = DFA143_accept;
            this.special = DFA143_special;
            this.transition = DFA143_transition;

        }

        override public string Description
        {
            get { return "998:21: (=> tag )?"; }
        }

    }


    protected internal int DFA143_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA143_1 = input.LA(1);

                   	 
                   	int index143_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred41_Smi()) ) { s = 35; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index143_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae143 =
            new NoViableAltException(dfa.Description, 143, _s, input);
        dfa.Error(nvae143);
        throw nvae143;
    }
    const string DFA160_eotS =
        "\x34\xFFFF";
    const string DFA160_eofS =
        "\x34\xFFFF";
    const string DFA160_minS =
        "\x1\x7\xD\x0\x26\xFFFF";
    const string DFA160_maxS =
        "\x1\xBF\xD\x0\x26\xFFFF";
    const string DFA160_acceptS =
        "\xE\xFFFF\x1\x1\x1\x3\x1\x4\x1\x5\x1\x6\x1E\xFFFF\x1\x7\x1\x8\x1"+
        "\x2";
    const string DFA160_specialS =
        "\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9\x1"+
        "\xA\x1\xB\x1\xC\x1\xD\x26\xFFFF}>";
    static readonly string[] DFA160_transitionS = {
            "\x1\x12\x5\xFFFF\x1\xB\x4\xFFFF\x3\x12\x1\xFFFF\x1\x4\x1\x12"+
            "\x2\xFFFF\x1\x12\xD\xFFFF\x1\x12\x1\xFFFF\x2\x12\x6\xFFFF\x1"+
            "\x12\x1\x2\x1\x10\x3\x12\x1\xA\x1\xFFFF\x1\x12\x4\xFFFF\x1\x12"+
            "\x1\xFFFF\x1\x12\x2\xFFFF\x1\x12\x1\x9\x1\x12\x1\x11\x2\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\xE\x1\x7\x1\xD\x1\x3\x1\x8\x1\x12\x1\xFFFF"+
            "\x2\x12\x2\xFFFF\x1\x12\x2\xFFFF\x1\x31\x2\xFFFF\x1\xC\x1\xFFFF"+
            "\x1\x12\x4\xFFFF\x1\x12\x3\xFFFF\x2\x12\x1\xFFFF\x1\xF\x2\xFFFF"+
            "\x1\x12\x1\xFFFF\x1\x12\x1\x1\x4\xFFFF\x1\x12\x1\x5\x4\x12\x1"+
            "\x32\x6\xFFFF\x1\x12\x5\xFFFF\x1\x12\x14\xFFFF\x3\x12\x1\xFFFF"+
            "\x3\x12\x1\xFFFF\x1\x12\xC\xFFFF\x1\x12\x8\xFFFF\x1\x12\x2\xFFFF"+
            "\x1\x12",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA160_eot = DFA.UnpackEncodedString(DFA160_eotS);
    static readonly short[] DFA160_eof = DFA.UnpackEncodedString(DFA160_eofS);
    static readonly char[] DFA160_min = DFA.UnpackEncodedStringToUnsignedChars(DFA160_minS);
    static readonly char[] DFA160_max = DFA.UnpackEncodedStringToUnsignedChars(DFA160_maxS);
    static readonly short[] DFA160_accept = DFA.UnpackEncodedString(DFA160_acceptS);
    static readonly short[] DFA160_special = DFA.UnpackEncodedString(DFA160_specialS);
    static readonly short[][] DFA160_transition = DFA.UnpackEncodedStringArray(DFA160_transitionS);

    protected class DFA160 : DFA
    {
        public DFA160(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 160;
            this.eot = DFA160_eot;
            this.eof = DFA160_eof;
            this.min = DFA160_min;
            this.max = DFA160_max;
            this.accept = DFA160_accept;
            this.special = DFA160_special;
            this.transition = DFA160_transition;

        }

        override public string Description
        {
            get { return "1022:0: constraint_elements : (=> value_range |=> value | SIZE_KW constraint | FROM_KW constraint | L_PAREN element_set_spec R_PAREN | ( INCLUDES_KW )? type | PATTERN_KW value | WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE ) );"; }
        }

    }


    protected internal int DFA160_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA160_0 = input.LA(1);

                   	 
                   	int index160_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA160_0 == TRUE_KW) ) { s = 1; }

                   	else if ( (LA160_0 == FALSE_KW) ) { s = 2; }

                   	else if ( (LA160_0 == NULL_KW) ) { s = 3; }

                   	else if ( (LA160_0 == C_STRING) ) { s = 4; }

                   	else if ( (LA160_0 == UPPER) ) { s = 5; }

                   	else if ( (LA160_0 == LOWER) ) { s = 6; }

                   	else if ( (LA160_0 == MINUS) ) { s = 7; }

                   	else if ( (LA160_0 == NUMBER) ) { s = 8; }

                   	else if ( (LA160_0 == L_BRACE) ) { s = 9; }

                   	else if ( (LA160_0 == H_STRING) ) { s = 10; }

                   	else if ( (LA160_0 == B_STRING) ) { s = 11; }

                   	else if ( (LA160_0 == PLUS_INFINITY_KW) ) { s = 12; }

                   	else if ( (LA160_0 == MINUS_INFINITY_KW) ) { s = 13; }

                   	else if ( (LA160_0 == MIN_KW) && (synpred44_Smi()) ) { s = 14; }

                   	else if ( (LA160_0 == SIZE_KW) ) { s = 15; }

                   	else if ( (LA160_0 == FROM_KW) ) { s = 16; }

                   	else if ( (LA160_0 == L_PAREN) ) { s = 17; }

                   	else if ( (LA160_0 == ANY_KW || (LA160_0 >= BIT_KW && LA160_0 <= BOOLEAN_KW) || LA160_0 == CHARACTER_KW || LA160_0 == CHOICE_KW || LA160_0 == EMBEDDED_KW || (LA160_0 >= ENUMERATED_KW && LA160_0 <= ERROR_KW) || LA160_0 == EXTERNAL_KW || (LA160_0 >= GENERAL_STR_KW && LA160_0 <= GRAPHIC_STR_KW) || LA160_0 == IA5_STRING_KW || LA160_0 == INCLUDES_KW || LA160_0 == INTEGER_KW || LA160_0 == ISO646_STR_KW || LA160_0 == L_BRACKET || LA160_0 == NUMERIC_STR_KW || (LA160_0 >= OBJECT_KW && LA160_0 <= OCTET_KW) || LA160_0 == OPERATION_KW || LA160_0 == PRINTABLE_STR_KW || LA160_0 == REAL_KW || (LA160_0 >= SEQUENCE_KW && LA160_0 <= SET_KW) || LA160_0 == T61_STR_KW || LA160_0 == TELETEX_STR_KW || LA160_0 == UNIVERSAL_STR_KW || (LA160_0 >= UTC_TIME_KW && LA160_0 <= VISIBLE_STR_KW) || LA160_0 == 131 || LA160_0 == 137 || (LA160_0 >= 158 && LA160_0 <= 160) || (LA160_0 >= 162 && LA160_0 <= 164) || LA160_0 == 166 || LA160_0 == 179 || LA160_0 == 188 || LA160_0 == 191) ) { s = 18; }

                   	else if ( (LA160_0 == PATTERN_KW) ) { s = 49; }

                   	else if ( (LA160_0 == WITH_KW) ) { s = 50; }

                   	 
                   	input.Seek(index160_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA160_1 = input.LA(1);

                   	 
                   	int index160_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA160_2 = input.LA(1);

                   	 
                   	int index160_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA160_3 = input.LA(1);

                   	 
                   	int index160_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	else if ( (true) ) { s = 18; }

                   	 
                   	input.Seek(index160_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA160_4 = input.LA(1);

                   	 
                   	int index160_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA160_5 = input.LA(1);

                   	 
                   	int index160_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	else if ( (true) ) { s = 18; }

                   	 
                   	input.Seek(index160_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA160_6 = input.LA(1);

                   	 
                   	int index160_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	else if ( (true) ) { s = 18; }

                   	 
                   	input.Seek(index160_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA160_7 = input.LA(1);

                   	 
                   	int index160_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA160_8 = input.LA(1);

                   	 
                   	int index160_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA160_9 = input.LA(1);

                   	 
                   	int index160_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA160_10 = input.LA(1);

                   	 
                   	int index160_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA160_11 = input.LA(1);

                   	 
                   	int index160_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA160_12 = input.LA(1);

                   	 
                   	int index160_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA160_13 = input.LA(1);

                   	 
                   	int index160_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 14; }

                   	else if ( (synpred45_Smi()) ) { s = 51; }

                   	 
                   	input.Seek(index160_13);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae160 =
            new NoViableAltException(dfa.Description, 160, _s, input);
        dfa.Error(nvae160);
        throw nvae160;
    }
 

    public static readonly BitSet FOLLOW_module_definition_in_statement1862 = new BitSet(new ulong[]{0x0000000000000002UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_module_identifier_in_module_definition1879 = new BitSet(new ulong[]{0x0000001000000000UL,0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_set_in_module_definition1881 = new BitSet(new ulong[]{0x1002800000000C00UL});
    public static readonly BitSet FOLLOW_set_in_module_definition1894 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_TAGS_KW_in_module_definition1906 = new BitSet(new ulong[]{0x0002000000000400UL});
    public static readonly BitSet FOLLOW_EXTENSIBILITY_KW_in_module_definition1915 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_IMPLIED_KW_in_module_definition1917 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_module_definition1923 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_BEGIN_KW_in_module_definition1925 = new BitSet(new ulong[]{0x40010A0000000000UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_module_body_in_module_definition1927 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_END_KW_in_module_definition1929 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_module_identifier1936 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_module_identifier1939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exports_in_module_body1950 = new BitSet(new ulong[]{0x4000080000000002UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_imports_in_module_body1955 = new BitSet(new ulong[]{0x0000080000000002UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_assignment_in_module_body1960 = new BitSet(new ulong[]{0x0000080000000002UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_obj_id_comp_lst1972 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000010400UL});
    public static readonly BitSet FOLLOW_defined_value_in_obj_id_comp_lst1987 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000010400UL});
    public static readonly BitSet FOLLOW_obj_id_component_in_obj_id_comp_lst1992 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000200010400UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_obj_id_comp_lst1996 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_defined_value2007 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_DOT_in_defined_value2009 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_defined_value2013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_obj_id_component2023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_obj_id_component2044 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_obj_id_component2047 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_obj_id_component2049 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_obj_id_component2051 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_tag_default2064 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXPORTS_KW_in_exports2079 = new BitSet(new ulong[]{0x0000080000000040UL,0xC080008000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_symbol_list_in_exports2084 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ALL_KW_in_exports2090 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_SEMI_in_exports2094 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IMPORTS_KW_in_imports2101 = new BitSet(new ulong[]{0x0000080000000000UL,0xC080008000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_symbols_from_module_in_imports2104 = new BitSet(new ulong[]{0x0000080000000000UL,0xC080008000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_SEMI_in_imports2108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_assignment2118 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_assignment2120 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_assignment2122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_assignment2137 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_assignment2139 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_assignment2141 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_assignment2143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_assignment2159 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_macroName_in_assignment2163 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_153_in_assignment2166 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_assignment2168 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_BEGIN_KW_in_assignment2170 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0xFFFFFFFFFFFFFFFFUL,0xFFFFFFFFFFFFFFFFUL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_set_in_assignment2172 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0xFFFFFFFFFFFFFFFFUL,0xFFFFFFFFFFFFFFFFUL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_END_KW_in_assignment2180 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_symbol_in_symbol_list2194 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_symbol_list2197 = new BitSet(new ulong[]{0x0000080000000000UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_symbol_in_symbol_list2199 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_symbol_list_in_symbols_from_module2209 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_FROM_KW_in_symbols_from_module2211 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_UPPER_in_symbols_from_module2213 = new BitSet(new ulong[]{0x0000000000000002UL,0x0080000000000420UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_symbols_from_module2242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_symbols_from_module2279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_symbol2315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_symbol2319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_macroName_in_symbol2323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPERATION_KW_in_macroName2330 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ERROR_KW_in_macroName2334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_136_in_macroName2339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_192_in_macroName2343 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_134_in_macroName2357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_133_in_macroName2361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_146_in_macroName2365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_macroName2379 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_147_in_macroName2383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_189_in_macroName2387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_190_in_macroName2391 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_181_in_macroName2398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_macroName2402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_174_in_macroName2406 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_178_in_macroName2410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_126_in_macroName2414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_129_in_macroName2421 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_128_in_macroName2425 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_127_in_macroName2429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_132_in_macroName2436 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_macroName2440 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_183_in_macroName2444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_182_in_macroName2448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_176_in_macroName2452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_macros_in_macroName2459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_built_in_type_in_type2466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_type_in_type2470 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selection_type_in_type2474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_macros_type_in_type2478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_type2482 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_KW_in_value2495 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_KW_in_value2511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_KW_in_value2527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_C_STRING_in_value2544 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_value2560 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_value2576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_choice_value_in_value2591 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequence_value_in_value2607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequenceof_value_in_value2623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cstr_value_in_value2639 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_value2655 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_INFINITY_KW_in_value2671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_INFINITY_KW_in_value2687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_any_type_in_built_in_type2694 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bit_string_type_in_built_in_type2712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_boolean_type_in_built_in_type2730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_character_str_type_in_built_in_type2748 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_choice_type_in_built_in_type2766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_embedded_type_in_built_in_type2783 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_EMBEDDED_KW_in_built_in_type2785 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_PDV_KW_in_built_in_type2787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_enum_type_in_built_in_type2805 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_external_type_in_built_in_type2822 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_type_in_built_in_type2832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_null_type_in_built_in_type2842 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_object_identifier_type_in_built_in_type2852 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_octetString_type_in_built_in_type2862 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_real_type_in_built_in_type2872 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_relativeOid_type_in_built_in_type2882 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequence_type_in_built_in_type2892 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequenceof_type_in_built_in_type2902 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_type_in_built_in_type2912 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setof_type_in_built_in_type2922 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tagged_type_in_built_in_type2932 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_defined_type2940 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_DOT_in_defined_type2942 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_UPPER_in_defined_type2946 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_defined_type2949 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_selection_type2959 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LESS_in_selection_type2961 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_selection_type2963 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ANY_KW_in_any_type2970 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_DEFINED_KW_in_any_type2973 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_BY_KW_in_any_type2975 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_any_type2977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIT_KW_in_bit_string_type2989 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_bit_string_type2991 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000000A0UL});
    public static readonly BitSet FOLLOW_namedNumber_list_in_bit_string_type3002 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_bit_string_type3007 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOLEAN_KW_in_boolean_type3018 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHARACTER_KW_in_character_str_type3025 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_character_str_type3027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_character_set_in_character_str_type3031 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_character_str_type3034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHOICE_KW_in_choice_type3044 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_choice_type3046 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_elementType_list_in_choice_type3048 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_choice_type3050 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EMBEDDED_KW_in_embedded_type3057 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_PDV_KW_in_embedded_type3059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENUMERATED_KW_in_enum_type3066 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_namedNumber_list_in_enum_type3068 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXTERNAL_KW_in_external_type3075 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_KW_in_integer_type3084 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000000A0UL});
    public static readonly BitSet FOLLOW_namedNumber_list_in_integer_type3095 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constraint_in_integer_type3099 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_KW_in_null_type3110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_object_identifier_type3117 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_KW_in_object_identifier_type3119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OCTET_KW_in_octetString_type3126 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_octetString_type3128 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_octetString_type3131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REAL_KW_in_real_type3141 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_179_in_relativeOid_type3150 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEQUENCE_KW_in_sequence_type3158 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_sequence_type3160 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_elementType_list_in_sequence_type3163 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_sequence_type3167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEQUENCE_KW_in_sequenceof_type3175 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000080000200000UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_sequenceof_type3178 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_sequenceof_type3180 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_OF_KW_in_sequenceof_type3184 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_sequenceof_type3186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_KW_in_set_type3193 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_set_type3195 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_elementType_list_in_set_type3198 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_set_type3202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_KW_in_setof_type3209 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000080000200000UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_setof_type3212 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_setof_type3214 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_OF_KW_in_setof_type3218 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_setof_type3220 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tag_in_tagged_type3227 = new BitSet(new ulong[]{0x14E48D00049C0880UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_tag_default_in_tagged_type3230 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_tagged_type3234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_namedNumber_list3241 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_namedNumber_list3243 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_namedNumber_list3246 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_namedNumber_list3248 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_namedNumber_list3252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_constraint3259 = new BitSet(new ulong[]{0x85FC4D0004DC20C0UL,0x1FC34B18A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_element_set_specs_in_constraint3262 = new BitSet(new ulong[]{0x0000400000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_exception_spec_in_constraint3267 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_constraint3271 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_character_set3278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elementType_in_elementType_list3380 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_elementType_list3383 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_elementType_in_elementType_list3385 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_L_BRACKET_in_tag3395 = new BitSet(new ulong[]{0x0000000000000100UL,0x00A0000100010400UL});
    public static readonly BitSet FOLLOW_clazz_in_tag3398 = new BitSet(new ulong[]{0x0000000000000100UL,0x00A0000100010400UL});
    public static readonly BitSet FOLLOW_class_NUMBER_in_tag3402 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_R_BRACKET_in_tag3404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_clazz3411 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_class_NUMBER3428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_class_NUMBER3432 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPERATION_KW_in_operation_macro3441 = new BitSet(new ulong[]{0x0000100000000202UL,0x0000004000000200UL});
    public static readonly BitSet FOLLOW_ARGUMENT_KW_in_operation_macro3444 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_LOWER_in_operation_macro3453 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_operation_macro3457 = new BitSet(new ulong[]{0x0000100000000002UL,0x0000004000000200UL});
    public static readonly BitSet FOLLOW_RESULT_KW_in_operation_macro3491 = new BitSet(new ulong[]{0x04E41D00049C0082UL,0x0FC14310809A8652UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_LOWER_in_operation_macro3532 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_operation_macro3536 = new BitSet(new ulong[]{0x0000100000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_ERRORS_KW_in_operation_macro3578 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_operation_macro3580 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34312A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_operation_errorlist_in_operation_macro3583 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_operation_macro3587 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_LINKED_KW_in_operation_macro3621 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_operation_macro3623 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34312A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_linkedOp_list_in_operation_macro3626 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_operation_macro3630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ERROR_KW_in_error_macro3650 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_PARAMETER_KW_in_error_macro3654 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_LOWER_in_error_macro3663 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_error_macro3667 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operation_macro_in_macros_type3685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_error_macro_in_macros_type3689 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objecttype_macro_in_macros_type3693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_in_macros_type3697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectidentity_macro_in_macros_type3713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_notificationtype_macro_in_macros_type3717 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_in_macros_type3721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectgroup_macro_in_macros_type3737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_notificationgroup_macro_in_macros_type3741 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_in_macros_type3745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_in_macros_type3761 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_traptype_macro_in_macros_type3765 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_smi_macros3772 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_137_in_smi_type3839 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_KW_in_smi_type3843 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OCTET_KW_in_smi_type3847 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_smi_type3849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_smi_type3853 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_KW_in_smi_type3855 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_smi_type3859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_smi_subtyping3873 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3875 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_BAR_in_smi_subtyping3878 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3880 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_smi_subtyping3884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_smi_subtyping3901 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000080000000000UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_smi_subtyping3903 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_smi_subtyping3905 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3907 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_BAR_in_smi_subtyping3910 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3912 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_smi_subtyping3916 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_smi_subtyping3918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_subtype_value_in_subtype_range3924 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_subtype_range3927 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_value_in_subtype_range3929 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_subtype_value3939 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_subtype_value3943 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_B_STRING_in_subtype_value3947 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_H_STRING_in_subtype_value3951 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_166_in_objecttype_macro3960 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL});
    public static readonly BitSet FOLLOW_187_in_objecttype_macro3962 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_smi_type_in_objecttype_macro3995 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_namedbits_in_objecttype_macro3997 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_smi_type_in_objecttype_macro4029 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_smi_subtyping_in_objecttype_macro4032 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_type_in_objecttype_macro4059 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_194_in_objecttype_macro4103 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objecttype_macro4105 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL});
    public static readonly BitSet FOLLOW_set_in_objecttype_macro4130 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_accesstypes_in_objecttype_macro4138 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100300000000000UL});
    public static readonly BitSet FOLLOW_168_in_objecttype_macro4162 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_pibaccess_in_objecttype_macro4164 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100300000000000UL});
    public static readonly BitSet FOLLOW_172_in_objecttype_macro4202 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4204 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4206 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4208 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100200000000000UL});
    public static readonly BitSet FOLLOW_173_in_objecttype_macro4249 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4251 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4253 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4255 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_objecttype_macro4302 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_statustypes_in_objecttype_macro4304 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002040000C23080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_141_in_objecttype_macro4333 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objecttype_macro4335 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002040000C21080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_151_in_objecttype_macro4391 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4393 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_error_in_objecttype_macro4395 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro4398 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_error_in_objecttype_macro4400 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4404 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002040000421080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_177_in_objecttype_macro4419 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objecttype_macro4421 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000040000421080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_150_in_objecttype_macro4442 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_index_in_objecttype_macro4444 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_135_in_objecttype_macro4469 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_augments_in_objecttype_macro4471 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_170_in_objecttype_macro4496 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4498 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4500 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4502 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_145_in_objecttype_macro4548 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4550 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4552 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4554 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_150_in_objecttype_macro4622 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_index_in_objecttype_macro4624 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000001000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_193_in_objecttype_macro4673 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4675 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200022001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4678 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro4681 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4683 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4690 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_140_in_objecttype_macro4729 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4731 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_objecttype_macro_bitsvalue_in_objecttype_macro4772 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4799 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4823 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_accesstypes4837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_pibaccess4890 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_statustypes4943 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_index4993 = new BitSet(new ulong[]{0x2108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index4995 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro_index4998 = new BitSet(new ulong[]{0x2108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index5000 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_index5004 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IMPLIED_KW_in_objecttype_macro_indextype5018 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro_indextype5022 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_augments5028 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro_augments5030 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_augments5032 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_namedbits5042 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_namedbits5045 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_objecttype_macro_namedbits5048 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_objecttype_macro_namedbits5050 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_objecttype_macro_namedbits5052 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro_namedbits5055 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_namedbits5058 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_objecttype_macro_namedbits5061 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_objecttype_macro_namedbits5063 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_objecttype_macro_namedbits5065 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_namedbits5069 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_bitsvalue5080 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_bitsvalue5082 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro_bitsvalue5085 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_bitsvalue5087 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_bitsvalue5091 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_error5102 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_objecttype_macro_error5104 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_objecttype_macro_error5106 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_objecttype_macro_error5108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_159_in_moduleidentity_macro5117 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0200000001000000UL});
    public static readonly BitSet FOLLOW_185_in_moduleidentity_macro5145 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_moduleidentity_macro5147 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_categories_in_moduleidentity_macro5149 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_moduleidentity_macro5151 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_moduleidentity_macro5181 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5183 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_167_in_moduleidentity_macro5185 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5187 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_138_in_moduleidentity_macro5189 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5191 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_moduleidentity_macro5218 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5220 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0010000000000000UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_revision_in_moduleidentity_macro5223 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0010000000000000UL});
    public static readonly BitSet FOLLOW_180_in_moduleidentity_macro_revision5232 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro_revision5234 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_moduleidentity_macro_revision5236 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro_revision5238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_moduleidentity_macro_categories5247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5285 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_moduleidentity_macro_categories5288 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5290 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_moduleidentity_macro_categoryid5298 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_moduleidentity_macro_categoryid5300 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_moduleidentity_macro_categoryid5302 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_moduleidentity_macro_categoryid5304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_164_in_objectidentity_macro5314 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_objectidentity_macro5316 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objectidentity_macro_statustypes_in_objectidentity_macro5318 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_objectidentity_macro5320 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectidentity_macro5322 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_objectidentity_macro5325 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectidentity_macro5327 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objectidentity_macro_statustypes5340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_162_in_notificationtype_macro5393 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100002000000000UL});
    public static readonly BitSet FOLLOW_165_in_notificationtype_macro5396 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_notificationtype_macro5398 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationtype_macro5400 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_notificationtype_macro5403 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationtype_macro5405 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_notificationtype_macro5409 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_notificationtype_macro5458 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_notificationtype_macro_status_in_notificationtype_macro5460 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_notificationtype_macro5462 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationtype_macro5464 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_notificationtype_macro5467 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationtype_macro5469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_notificationtype_macro_status5482 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_188_in_textualconvention_macro5534 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000004000UL});
    public static readonly BitSet FOLLOW_142_in_textualconvention_macro5537 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_textualconvention_macro5539 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_textualconvention_macro5572 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_status_in_textualconvention_macro5574 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_textualconvention_macro5605 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_textualconvention_macro5607 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0802000000000000UL});
    public static readonly BitSet FOLLOW_177_in_textualconvention_macro5639 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_textualconvention_macro5641 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL});
    public static readonly BitSet FOLLOW_187_in_textualconvention_macro5674 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_smi_type_in_textualconvention_macro5686 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_textualconvention_macro5688 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5690 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_textualconvention_macro5730 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5732 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_textualconvention_macro5736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_textualconvention_macro5740 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_textualconvention_macro_status5751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_textualconvention_macro_namedbit5800 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_textualconvention_macro_namedbit5802 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_MINUS_in_textualconvention_macro_namedbit5805 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_textualconvention_macro_namedbit5809 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_textualconvention_macro_namedbit5811 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_163_in_objectgroup_macro5820 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_165_in_objectgroup_macro5822 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objectgroup_macro5824 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objectgroup_macro5826 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objectgroup_macro5829 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objectgroup_macro5831 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objectgroup_macro5835 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_objectgroup_macro5862 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objectgroup_macro_status_in_objectgroup_macro5864 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_objectgroup_macro5866 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectgroup_macro5868 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_objectgroup_macro5871 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectgroup_macro5873 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objectgroup_macro_status5884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_160_in_notificationgroup_macro5936 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_161_in_notificationgroup_macro5938 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_notificationgroup_macro5940 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationgroup_macro5942 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_notificationgroup_macro5945 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationgroup_macro5947 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_notificationgroup_macro5951 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_notificationgroup_macro5978 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_notificationgroup_macro_status_in_notificationgroup_macro5980 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_notificationgroup_macro5982 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationgroup_macro5984 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_notificationgroup_macro5987 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationgroup_macro5989 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_notificationgroup_macro_status6000 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_158_in_modulecompliance_macro6052 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_modulecompliance_macro6054 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_status_in_modulecompliance_macro6056 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_modulecompliance_macro6082 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro6084 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0002000020000000UL});
    public static readonly BitSet FOLLOW_177_in_modulecompliance_macro6087 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro6089 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0002000020000000UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_module_in_modulecompliance_macro6094 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000020000000UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_status6105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_157_in_modulecompliance_macro_module6153 = new BitSet(new ulong[]{0x0000000000000002UL,0x0080000000080000UL,0x0000000004200000UL});
    public static readonly BitSet FOLLOW_UPPER_in_modulecompliance_macro_module6162 = new BitSet(new ulong[]{0x0108000000402002UL,0x008200002009E420UL,0x0000000004200000UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_module6171 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL,0x0000000004200000UL});
    public static readonly BitSet FOLLOW_154_in_modulecompliance_macro_module6212 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_modulecompliance_macro_module6214 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_module6216 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_modulecompliance_macro_module6219 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_module6221 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_modulecompliance_macro_module6225 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_compliance_in_modulecompliance_macro_module6262 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_modulecompliance_macro_compliance6271 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_compliance6273 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_modulecompliance_macro_compliance6275 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro_compliance6277 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_modulecompliance_macro_compliance6314 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_compliance6316 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800080010002000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_187_in_modulecompliance_macro_compliance6356 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6358 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080010002000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_197_in_modulecompliance_macro_compliance6400 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6402 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080010002000UL});
    public static readonly BitSet FOLLOW_156_in_modulecompliance_macro_compliance6449 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_access_in_modulecompliance_macro_compliance6451 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080000002000UL});
    public static readonly BitSet FOLLOW_171_in_modulecompliance_macro_compliance6493 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_pibaccess_in_modulecompliance_macro_compliance6495 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_modulecompliance_macro_compliance6540 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro_compliance6542 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_modulecompliance_macro_syntax6556 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_modulecompliance_macro_syntax6558 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6560 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_modulecompliance_macro_syntax6563 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6565 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_modulecompliance_macro_syntax6569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_modulecompliance_macro_syntax6608 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_smi_subtyping_in_modulecompliance_macro_syntax6611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_modulecompliance_macro_syntax6646 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_namedbit6652 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_modulecompliance_macro_namedbit6654 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_modulecompliance_macro_namedbit6656 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_modulecompliance_macro_namedbit6658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_access6666 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_pibaccess6716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_131_in_agentcapabilities_macro6767 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_175_in_agentcapabilities_macro6769 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro6771 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_agentcapabilities_macro6773 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_status_in_agentcapabilities_macro6775 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_agentcapabilities_macro6802 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro6804 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0402000000000000UL});
    public static readonly BitSet FOLLOW_177_in_agentcapabilities_macro6807 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro6809 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0400000000000000UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_module_in_agentcapabilities_macro6814 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0400000000000000UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_status6824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_186_in_agentcapabilities_macro_module6872 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_module6874 = new BitSet(new ulong[]{0x8108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_module6877 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_INCLUDES_KW_in_agentcapabilities_macro_module6914 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_module6916 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_module6918 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_module6921 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_module6923 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_module6927 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_variation_in_agentcapabilities_macro_module6963 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_196_in_agentcapabilities_macro_variation6971 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation6973 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000003804UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_187_in_agentcapabilities_macro_variation6976 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6978 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003804UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_197_in_agentcapabilities_macro_variation6983 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6985 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003804UL});
    public static readonly BitSet FOLLOW_130_in_agentcapabilities_macro_variation6990 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_access_in_agentcapabilities_macro_variation6992 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003800UL});
    public static readonly BitSet FOLLOW_139_in_agentcapabilities_macro_variation7034 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7036 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation7038 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_variation7041 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation7043 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7047 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003000UL});
    public static readonly BitSet FOLLOW_140_in_agentcapabilities_macro_variation7089 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7091 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7112 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_variation7115 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_variation7120 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_variation7122 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7126 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation7130 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_agentcapabilities_macro_variation7173 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro_variation7175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_agentcapabilities_macro_syntax7226 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_syntax7228 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7230 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_syntax7233 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7235 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_syntax7239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_agentcapabilities_macro_syntax7279 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_smi_subtyping_in_agentcapabilities_macro_syntax7282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_agentcapabilities_macro_syntax7318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_access7327 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_namedbit7375 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_agentcapabilities_macro_namedbit7377 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_agentcapabilities_macro_namedbit7379 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_agentcapabilities_macro_namedbit7381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_191_in_traptype_macro7391 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_traptype_macro7393 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7395 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000002000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_195_in_traptype_macro7398 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_traptype_macro7400 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7402 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_traptype_macro7405 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7407 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_traptype_macro7411 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000002000UL});
    public static readonly BitSet FOLLOW_141_in_traptype_macro7443 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7445 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_traptype_macro7450 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_operation_errorlist7462 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_operation_errorlist7465 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34310A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_operation_errorlist7467 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_linkedOp_list7477 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_linkedOp_list7480 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34310A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_linkedOp_list7482 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_type_in_typeorvalue7498 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_typeorvalue7502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_typeorvaluelist7510 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_typeorvaluelist7513 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34310A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_typeorvaluelist7515 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_elementType7527 = new BitSet(new ulong[]{0x14E48D00049C0880UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_tag_in_elementType7545 = new BitSet(new ulong[]{0x14E48D00049C0880UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_tag_default_in_elementType7571 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_elementType7575 = new BitSet(new ulong[]{0x0000000400000002UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_OPTIONAL_KW_in_elementType7578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DEFAULT_KW_in_elementType7582 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_elementType7584 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMPONENTS_KW_in_elementType7602 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_OF_KW_in_elementType7604 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_elementType7606 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_namedNumber7615 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_namedNumber7617 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000012400UL});
    public static readonly BitSet FOLLOW_signed_number_in_namedNumber7620 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_defined_value_in_namedNumber7624 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_namedNumber7627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_signed_number7635 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_signed_number7639 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_element_set_spec_in_element_set_specs7646 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_element_set_specs7649 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_DOTDOTDOT_in_element_set_specs7651 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_element_set_specs7656 = new BitSet(new ulong[]{0x85FC0D0004DC20C0UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_element_set_spec_in_element_set_specs7658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXCLAMATION_in_exception_spec7668 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809BA452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_signed_number_in_exception_spec7695 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_exception_spec7724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_exception_spec7747 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_COLON_in_exception_spec7749 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_exception_spec7751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_intersections_in_element_set_spec7776 = new BitSet(new ulong[]{0x0000000000004002UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_set_in_element_set_spec7780 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_intersections_in_element_set_spec7788 = new BitSet(new ulong[]{0x0000000000004002UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_ALL_KW_in_element_set_spec7812 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_EXCEPT_KW_in_element_set_spec7814 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_element_set_spec7816 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7823 = new BitSet(new ulong[]{0x0000200000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_EXCEPT_KW_in_intersections7826 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7828 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_set_in_intersections7851 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7859 = new BitSet(new ulong[]{0x0000200000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_EXCEPT_KW_in_intersections7862 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7864 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_value_range_in_constraint_elements7883 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_constraint_elements7912 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_constraint_elements7936 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_constraint_elements7938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FROM_KW_in_constraint_elements7962 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_constraint_elements7964 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_constraint_elements7988 = new BitSet(new ulong[]{0x85FC0D0004DC20C0UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_element_set_spec_in_constraint_elements7990 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_constraint_elements7992 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCLUDES_KW_in_constraint_elements8017 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_constraint_elements8021 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PATTERN_KW_in_constraint_elements8045 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_constraint_elements8047 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WITH_KW_in_constraint_elements8071 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_COMPONENT_KW_in_constraint_elements8074 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_constraint_elements8076 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMPONENTS_KW_in_constraint_elements8111 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_constraint_elements8113 = new BitSet(new ulong[]{0x0000008000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_DOTDOTDOT_in_constraint_elements8116 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_constraint_elements8118 = new BitSet(new ulong[]{0x0000008000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_type_constraint_list_in_constraint_elements8155 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_constraint_elements8157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_value_range8166 = new BitSet(new ulong[]{0x0000004000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_MIN_KW_in_value_range8170 = new BitSet(new ulong[]{0x0000004000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LESS_in_value_range8174 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_value_range8178 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001ED20UL});
    public static readonly BitSet FOLLOW_LESS_in_value_range8181 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001EC20UL});
    public static readonly BitSet FOLLOW_value_in_value_range8186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MAX_KW_in_value_range8190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_named_constraint_in_type_constraint_list8199 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_type_constraint_list8202 = new BitSet(new ulong[]{0x0000008000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_named_constraint_in_type_constraint_list8204 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_named_constraint8214 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000041000080UL});
    public static readonly BitSet FOLLOW_constraint_in_named_constraint8217 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000041000000UL});
    public static readonly BitSet FOLLOW_set_in_named_constraint8221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_choice_value8240 = new BitSet(new ulong[]{0x0108000010402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_COLON_in_choice_value8243 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_choice_value8247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_sequence_value8254 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_named_value_in_sequence_value8257 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_sequence_value8262 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_named_value_in_sequence_value8264 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_sequence_value8268 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_sequenceof_value8275 = new BitSet(new ulong[]{0x0108000020402000UL,0x008200022001E420UL});
    public static readonly BitSet FOLLOW_value_in_sequenceof_value8278 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_sequenceof_value8283 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_sequenceof_value8285 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_sequenceof_value8289 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_H_STRING_in_cstr_value8302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_B_STRING_in_cstr_value8323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_cstr_value8338 = new BitSet(new ulong[]{0x0000000000400000UL,0x0080000000012420UL});
    public static readonly BitSet FOLLOW_id_list_in_cstr_value8361 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_char_defs_list_in_cstr_value8386 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_tuple_or_quad_in_cstr_value8405 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_cstr_value8421 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_id_list8428 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_id_list8431 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_id_list8433 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_char_defs_in_char_defs_list8443 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_char_defs_list8446 = new BitSet(new ulong[]{0x0000000000400000UL,0x0080000000000420UL});
    public static readonly BitSet FOLLOW_char_defs_in_char_defs_list8448 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8459 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_tuple_or_quad8461 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8463 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_tuple_or_quad8466 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8468 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_tuple_or_quad8470 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_C_STRING_in_char_defs8483 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_char_defs8497 = new BitSet(new ulong[]{0x0000000000400000UL,0x0080000000012420UL});
    public static readonly BitSet FOLLOW_tuple_or_quad_in_char_defs8499 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_char_defs8501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_char_defs8514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_named_value8524 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_named_value8526 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred1_Smi1976 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_set_in_synpred1_Smi1978 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequence_value_in_synpred10_Smi2602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequenceof_value_in_synpred11_Smi2618 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cstr_value_in_synpred12_Smi2634 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_synpred13_Smi2650 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_INFINITY_KW_in_synpred14_Smi2666 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_INFINITY_KW_in_synpred15_Smi2682 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred16_Smi2995 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_synpred16_Smi2997 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred17_Smi3088 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_synpred17_Smi3090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred18_Smi3448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RESULT_KW_in_synpred19_Smi3486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_synpred2_Smi2274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred20_Smi3520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred21_Smi3527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ERRORS_KW_in_synpred22_Smi3573 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LINKED_KW_in_synpred23_Smi3616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred24_Smi3658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred25_Smi3988 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred25_Smi3990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred26_Smi4024 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_141_in_synpred27_Smi4328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred28_Smi4433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_140_in_synpred29_Smi4724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_KW_in_synpred3_Smi2490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred30_Smi4757 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred30_Smi4759 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_set_in_synpred30_Smi4761 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred31_Smi5679 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred31_Smi5681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_synpred32_Smi6157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_synpred33_Smi6166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred34_Smi6549 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred34_Smi6551 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred35_Smi6603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred36_Smi7095 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_set_in_synpred36_Smi7097 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred37_Smi7182 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred37_Smi7184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred38_Smi7274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_141_in_synpred39_Smi7438 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_KW_in_synpred4_Smi2506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_synpred40_Smi7493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACKET_in_synpred41_Smi7532 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000010400UL});
    public static readonly BitSet FOLLOW_set_in_synpred41_Smi7534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_synpred42_Smi7690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_synpred43_Smi7719 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_range_in_synpred44_Smi7878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_synpred45_Smi7907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_H_STRING_in_synpred46_Smi8297 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_B_STRING_in_synpred47_Smi8318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_id_list_in_synpred48_Smi8356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_char_defs_list_in_synpred49_Smi8381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_KW_in_synpred5_Smi2522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_C_STRING_in_synpred6_Smi2539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_synpred7_Smi2555 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_synpred8_Smi2571 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_choice_value_in_synpred9_Smi2586 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}