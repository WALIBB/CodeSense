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
                if (Array.Exists(new[] { "False", "None", "True", "and", "as", "assert", "async", "await", "break", "class", "continue", "def", "del", "elif", "else", "except", "finally", "for", "from", "global", "if", "import", "in", "is", "lambda", "nonlocal", "not", "or", "pass", "raise", "return", "try", "while", "with", "yield" }, keyword => keyword == token))
                    result.AppendLine($"{token} is a keyword");
                else if (Array.Exists(new[] { "+", "-", "*", "/", "%", "==", "<", ">", "<=", ">=", "&&", "||", "!" }, op => op == token))
                    result.AppendLine($"{token} is an operator");
                else if (Array.Exists(new[] { "abs", "all", "any", "ascii", "bin", "bool", "breakpoint", "bytearray", "bytes", "callable", "chr", "classmethod", "compile", "complex", "delattr", "dict", "dir", "divmod", "enumerate", "eval", "exec", "filter", "float", "format", "frozenset", "getattr", "globals", "hasattr", "hash", "help", "hex", "id", "input", "int", "isinstance", "issubclass", "iter", "len", "list", "locals", "map", "max", "memoryview", "min", "next", "object", "oct", "open", "ord", "pow", "print", "property", "range", "repr", "reversed", "round", "set", "setattr", "slice", "sorted", "staticmethod", "str", "sum", "super", "tuple", "type", "vars", "zip", "__import__" }, op => op == token))
                    result.AppendLine($"{token} is a built-in function");
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
    }
}
