using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSense
{
    public class PythonStatementAnalyzer : StatementAnalyzer
    {
        public override string AnalyzeStatement(string statement)
        {
            statement = statement.Trim();

            if (statement.StartsWith("\"") && statement.EndsWith("\""))
                return $"{statement} is a string";

            if (IsMathExpression(statement))
                return $"{statement} is a mathematical expression";

            if (Regex.IsMatch(statement, @"^\s*(if|elif|else)\s+.*\s*[<>=!]=?\s*.*$"))
                return $"{statement} is a conditional statement";

            if (Regex.IsMatch(statement, @"^\w+\s*\=\s*.*$"))
                return $"{statement} is an assignment";

            if (Array.Exists(new[] { "int", "str", "bool", "float", "list", "dict" }, type => type == statement))
                return $"{statement} is a data type";

            return AnalyzeTokens(statement);
        }

        private string AnalyzeTokens(string statement)
        {
            var tokens = Tokenize(statement);
            StringBuilder result = new StringBuilder();

            foreach (var token in tokens)
            {
                if (Array.Exists(new[] { "False", "True", "None", "and", "or", "not", "if", "elif", "else", "return", "class", "def" }, keyword => keyword == token))
                    result.AppendLine($"{token} is a keyword");
                else if (Array.Exists(new[] { "+", "-", "*", "/", "%", "==", "<", ">", "<=", ">=", "&&", "||", "!" }, op => op == token))
                    result.AppendLine($"{token} is an operator");
                else if (double.TryParse(token, out _))
                    result.AppendLine($"{token} is a number");
                else
                    result.AppendLine($"{token} is a variable");
            }

            return result.ToString();
        }
    }
}
