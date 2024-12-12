using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeSense
{
    public class CSharpStatementAnalyzer : IStatementAnalyzer
    {
        public string AnalyzeStatement(string statement)
        {
            statement = statement.Trim();

            if (statement.StartsWith("\"") && statement.EndsWith("\""))
                return $"{statement} is a string";

            if (statement.StartsWith("//") || statement.StartsWith("/"))
                return $"{statement} is a comment";

            if (IsMathExpression(statement))
                return $"{statement} is a mathematical expression";

            if (Regex.IsMatch(statement, @"^\s*if\s*\(.*\)\s*$"))
                return $"{statement} is a conditional statement";

            if (Regex.IsMatch(statement, @"^\s*else\s+if\s*\(.*\)\s*$"))
                return $"{statement} is a conditional statement";

            if (Regex.IsMatch(statement, @"^\s*else\s+if\s*$"))
                return $"{statement} is a keyword";

            if (Regex.IsMatch(statement, @"^\s*(if|else\s+if)\s+.*$"))
                return $"{statement} is an invalid conditional statement";

            if (Regex.IsMatch(statement, @"^\s*using\s+\w+(\.\w+)*\s*$"))
                return $"{statement} is an invalid directive (;)";

            if (Regex.IsMatch(statement, @"^\s*using\s+[a-zA-Z_][a-zA-Z0-9_]*(\.[a-zA-Z_][a-zA-Z0-9_]*)*\s*;\s*$"))
                return $"{statement} is a directive";

            if (Regex.IsMatch(statement, @"^\s*\w+\s*\=\s*.*$"))
            {
                if (!statement.EndsWith(";"))
                {
                    return $"{statement} is an invalid assignment (missing semicolon)";
                }
                return $"{statement} is an assignment";
            }

            if (Array.Exists(new[] { "int", "string", "bool", "float", "double", "char", "decimal", "long", "short", "byte", "sbyte", "uint", "ulong", "ushort", "object", "var" }, type => type == statement))
                return $"{statement} is a data type";

            return AnalyzeTokens(statement);
        }

        private bool IsMathExpression(string statement)
        {
            return Regex.IsMatch(statement, @"\+|\-|\*|\/|\%");
        }

        private string AnalyzeTokens(string statement)
        {
            var tokens = Tokenize(statement);
            StringBuilder result = new StringBuilder();

            foreach (var token in tokens)
            {
               
                if (Array.Exists(new[] { "false", "true", "void", "int", "string", "if", "else", "for", "while", "return", "class", "namespace", "public", "private", "protected", "internal", "static", "readonly", "const", "new", "try", "catch", "finally", "throw", "await", "async", "delegate", "event", "this", "base", "using", "virtual", "override", "abstract", "interface", "enum", "struct", "in", "out", "ref" }, keyword => keyword == token))
                    result.AppendLine($"{token} is a keyword");

           
                else if (Array.Exists(new[] { "Console.WriteLine", "Console.ReadLine", "Console.Read", "Convert.ToString", "Convert.ToInt32", "Convert.ToDouble", "Math.Abs", "Math.Sqrt", "Math.Pow", "Math.Ceiling", "Math.Floor", "Math.Round", "Math.Log", "Math.Exp", "Math.Sin", "Math.Cos", "Math.Tan", "Math.Asin", "Math.Acos", "Math.Atan", "Array.Sort", "Array.Reverse", "List<T>.Add", "List<T>.Remove", "Dictionary<TKey, TValue>.Add", "Dictionary<TKey, TValue>.Remove", "Task.Delay", "Task.WhenAll", "Task.WhenAny", "async", "await", "string.Concat", "string.Join", "string.Split", "string.Replace", "string.ToLower", "string.ToUpper", "string.Contains", "string.IndexOf", "string.Substring", "string.Trim", "File.Exists", "File.ReadAllText", "Directory.Exists", "Path.Combine", "Path.GetDirectoryName", "Guid.NewGuid", "DateTime.Now", "DateTime.Parse" }, op => op == token))
                    result.AppendLine($"{token} is a built-in function or method");

               
                else if (Array.Exists(new[] { "+", "-", "*", "/", "%", "==", "<", ">", "<=", ">=", "&&", "||", "!", "=", "+=", "-=", "*=", "/=", "%=" }, op => op == token))
                    result.AppendLine($"{token} is an operator");

              
                else if (Array.Exists(new[] { "int", "string", "bool", "float", "double", "char", "decimal", "long", "short", "byte", "sbyte", "uint", "ulong", "ushort", "object", "var" }, type => type == token))
                    result.AppendLine($"{token} is a data type");

                else if (Regex.IsMatch(token, @"^[a-zA-Z_][a-zA-Z0-9_]*$"))
                    result.AppendLine($"{token} is an identifier");

               
                else if (double.TryParse(token, out _))
                    result.AppendLine($"{token} is a number");

                
                else
                    result.AppendLine($"{token} is a variable");
            }

            return result.ToString();
        }

        private string[] Tokenize(string statement)
        {
          
            var tokens = Regex.Split(statement, @"([^\w\.]+)").Where(token => !string.IsNullOrEmpty(token)).ToArray();
            return tokens;
        }
    }
}
