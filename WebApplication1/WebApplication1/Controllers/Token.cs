using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public enum TokenType
    {
        Constant, Repeat, Ipok, Sipok, Craf, Sequence, Ipokf, Sipokf, Valueless, Rational, Type, Infer, Respondwith, If, Else, Integer, SInteger,
        Character, String, Float, SFloat, Void, Boolean, Break, However, When,
        Return, Struct, Scan, Conditionof, Main, Until, Elseif, End, Endl, Then, StartSymbols, EndSymbols, Semicolon, Comma, LParanthesis,
        RParanthesis, LBraces, RBraces, EqualOp, LessThanOp, GreaterThanOp, NotEqualOp, PlusOp, MinusOp,
        MultiplyOp, DivideOp, AndOp, OrOp, Idenifier, Assignment, Comment
    }

    public class Token
    {
        public string lexeme;
        public TokenType tokenType;
        public string description;
        public static Dictionary<TokenType, string> tokenDescription
                                = new Dictionary<TokenType, string>();
        public static void addDescription()
        {
            tokenDescription.Add(TokenType.Constant, "Constant Number");
            tokenDescription.Add(TokenType.Repeat, "Constant Number");
            tokenDescription.Add(TokenType.Ipok, "Integer");
            tokenDescription.Add(TokenType.Sipok, "SInteger");
            tokenDescription.Add(TokenType.Craf, "Character");
            tokenDescription.Add(TokenType.Sequence, "String");
            tokenDescription.Add(TokenType.Ipokf, "Float");
            tokenDescription.Add(TokenType.Sipokf, "SFloat");
            tokenDescription.Add(TokenType.Valueless, "Void");
            tokenDescription.Add(TokenType.Rational, "Bolean");
            tokenDescription.Add(TokenType.Type, "Class");
            tokenDescription.Add(TokenType.Infer, "Inheritance");
            tokenDescription.Add(TokenType.Respondwith, "Condition");
            tokenDescription.Add(TokenType.If, "Condition");
            tokenDescription.Add(TokenType.Else, "Condition");
            tokenDescription.Add(TokenType.Integer, "Integer");
            tokenDescription.Add(TokenType.SInteger, "SInteger");
            tokenDescription.Add(TokenType.Character, "Character");

            tokenDescription.Add(TokenType.String, "String");
            tokenDescription.Add(TokenType.Float, "Float");
            tokenDescription.Add(TokenType.SFloat, "SFloat");
            tokenDescription.Add(TokenType.Void, "Void");
            tokenDescription.Add(TokenType.Boolean, "Boolean");
            tokenDescription.Add(TokenType.Break, "Break");
            tokenDescription.Add(TokenType.However, "Loop");
            tokenDescription.Add(TokenType.When, "Loop");
            tokenDescription.Add(TokenType.Return, "Return");
            tokenDescription.Add(TokenType.Struct, "Struct");
            tokenDescription.Add(TokenType.Scan, "Switch");
            tokenDescription.Add(TokenType.Conditionof, "Condition");
            tokenDescription.Add(TokenType.Main, "Main");
            tokenDescription.Add(TokenType.Until, "Reserved until");
            tokenDescription.Add(TokenType.Elseif, "Reserved elseif");
            tokenDescription.Add(TokenType.End, "Reserved end");
            tokenDescription.Add(TokenType.Endl, "Reserved endl");
            tokenDescription.Add(TokenType.Then, "Reserved then");

            tokenDescription.Add(TokenType.StartSymbols, "StartSymbols");
            tokenDescription.Add(TokenType.EndSymbols, "EndSymbols");
            tokenDescription.Add(TokenType.Semicolon, "Semicolon");
            tokenDescription.Add(TokenType.Comma, "Comma");
            tokenDescription.Add(TokenType.LParanthesis, "Left Parentheses");
            tokenDescription.Add(TokenType.RParanthesis, "Right Parentheses");
            tokenDescription.Add(TokenType.LBraces, "Left Braces");
            tokenDescription.Add(TokenType.RBraces, "Right Braces");
            tokenDescription.Add(TokenType.EqualOp, "Condition Operator (Equal)");
            tokenDescription.Add(TokenType.LessThanOp, "Condition Operator (Less Than)");
            tokenDescription.Add(TokenType.GreaterThanOp, "Condition Operator (Greater Than)");
            tokenDescription.Add(TokenType.NotEqualOp, "Condition Operator (Not Equal)");
            tokenDescription.Add(TokenType.PlusOp, "Arithmatic Operator (Plus)");
            tokenDescription.Add(TokenType.MinusOp, "Arithmatic Operator (Minus)");
            tokenDescription.Add(TokenType.MultiplyOp, "Arithmatic Operator (Multiply)");
            tokenDescription.Add(TokenType.DivideOp, "Arithmatic Operator (Divide)");
            tokenDescription.Add(TokenType.AndOp, "Boolean Operator (And)");
            tokenDescription.Add(TokenType.OrOp, "Boolean Operator (Or)");
            tokenDescription.Add(TokenType.Idenifier, "Identifier");
            tokenDescription.Add(TokenType.Assignment, "Assignment");
            tokenDescription.Add(TokenType.Comment, "Comment Statement");
        }
    }
}
