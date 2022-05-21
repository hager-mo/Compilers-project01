using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Compiler
    {


        public static Scanner TinyScanner = new Scanner();
        //public static Parser TinyParser = new Parser();

        public static List<int> Lines = new List<int>();
        public static List<string> Lexemes = new List<string>();
        public static List<Token> TokenStream = new List<Token>();
       // public static Node treeroot;

        /// <summary>
        /// Start compiling source code, pass it to a Scanner, Parser and Semantic Analysis.
        /// </summary>
        /// <param name="sourceCode">Source code to compile as a string</param>
        public static void StartCompiling(string sourceCode)
        {
            // Scanner
            TinyScanner.StartScanning(sourceCode);
            
            List<KeyValuePair<int, KeyValuePair<string, string>>> tokens =
                new List<KeyValuePair<int, KeyValuePair<string, string>>>();
            for (int i = 0; i < TokenStream.Count; ++i)
            {
                int line = Lines[i];
                string lexeme =Lexemes[i];
                string tokenDesc =TokenStream[i].description;
                tokens.Add(new KeyValuePair<int, KeyValuePair<string, string>>(line,
                           new KeyValuePair<string, string>(lexeme, tokenDesc)));
            }
            // Parser
            //  treeroot = TinyParser.StartParsing(TokenStream);
            // Semantic Analysis
        }

    }
}
