using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSense
{
    public class CppStatementAnalyzer : IStatementAnalyzer
    {
        public string AnalyzeStatement(string statement)
        {
            statement = statement.Trim();

            if (statement.StartsWith("\"") && statement.EndsWith("\""))
                return $"{statement} is a string";

            if (statement.StartsWith("//") || statement.StartsWith("/*"))
                return $"{statement} is a comment";

            if (statement.StartsWith("#"))
                return $"{statement} is a header";

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
                    return $"{statement} is an invalid assignment (;)";
                }
                return $"{statement} is an assignment";
            }

            if (Array.Exists(new[] { "int", "string", "bool", "float", "double", "char" }, type => type == statement))
                return $"{statement} is a data type";

            return AnalyzeTokens(statement);
        }

        private string AnalyzeTokens(string statement)
        {
            var tokens = Tokenize(statement);
            StringBuilder result = new StringBuilder();

            foreach (var token in tokens)
            {
                if (Array.Exists(new[] { "false", "true", "void", "int", "string", "if", "else", "for", "while", "return" }, keyword => keyword == token))
                    result.AppendLine($"{token} is a keyword");
                else if (Array.Exists(new[] { "+", "-", "*", "/", "%", "==", "<", ">", "<=", ">=", "&&", "||", "!" }, op => op == token))
                    result.AppendLine($"{token} is an operator");
                else if (double.TryParse(token, out _))
                {
                    if (token.Contains("."))
                        result.AppendLine($"{token} is a floating number");
                    else
                        result.AppendLine($"{token} is an integer");
                }
                else
                    result.AppendLine($"{token} is a variable");
            }

            return result.ToString();
        }

        private bool IsMathExpression(string statement)
        {
            
            return Regex.IsMatch(statement, @"^\s*[\d+\-*/%().\s]+\s*$");
        }

        private string[] Tokenize(string statement)
        {
           
            return Regex.Split(statement, @"(\s+|[+\-*/%=();,<>!&|])").Where(token => !string.IsNullOrWhiteSpace(token)).ToArray();
        }
    }
}
