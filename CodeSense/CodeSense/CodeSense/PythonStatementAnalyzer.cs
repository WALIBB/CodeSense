using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeSense
{
    public class PythonStatementAnalyzer : IStatementAnalyzer
    {
        public string AnalyzeStatement(string statement)
        {
            statement = statement.Trim();

            // Detect conditional statements like 9 > 10
            if (Regex.IsMatch(statement, @"^\s*(\d+)\s*(<=|>=|<|>|==|!=)\s*(\d+)\s*$"))
            {
                return $"{statement} is a conditional statement";
            }
            if (Regex.IsMatch(statement, @"^\"".*\""$"))
            {
                return $"{statement} is a string literal";
            }

               
                if (Regex.IsMatch(statement, @"^\s*if\s+(.*)\s*:\s*$"))
            {
                return AnalyzeIfStatement(statement);
            }

            
            if (Regex.IsMatch(statement, @"^\s*if\s+.*:\s*.*$"))
            {
                return AnalyzeIfStatement(statement);
            }

            
            if (Regex.IsMatch(statement, @"^\s*print\s*\(.*\)\s*$"))
            {
                return AnalyzePrintStatement(statement);
            }

           
            if (Regex.IsMatch(statement, @"^\s*input\s*\(.*\)\s*$"))
            {
                return AnalyzeInputStatement(statement);
            }

            
            if (statement.StartsWith("#"))
            {
                return $"{statement} is a comment";
            }

           
            if (IsMathExpression(statement))
            {
                return $"{statement} is a mathematical expression";
            }

           
            if (Regex.IsMatch(statement, @"^\w+\s*=\s*.*$"))
            {
                return $"{statement} is an assignment";
            }

            
            return AnalyzeTokens(statement);
        }

        private string AnalyzeIfStatement(string statement)
        {
          
            var match = Regex.Match(statement, @"^\s*if\s+(.*)\s*:\s*$");
            if (match.Success)
            {
                string condition = match.Groups[1].Value.Trim();
                bool conditionIsTrue = EvaluateCondition(condition);
                return conditionIsTrue
                    ? $"The condition {condition} is true, but there is no code block following."
                    : $"The condition {condition} is false, so no code will be executed.";
            }

            
            match = Regex.Match(statement, @"^\s*if\s+(.*):\s*(.*)$");
            if (match.Success)
            {
                string condition = match.Groups[1].Value.Trim();
                string block = match.Groups[2].Value.Trim();
                bool conditionIsTrue = EvaluateCondition(condition);

                if (conditionIsTrue)
                {
                    if (block.StartsWith("print"))
                    {
                        return $"The condition is true, {AnalyzePrintStatement(block)}";
                    }
                    else
                    {
                        return $"The condition is true, but block analysis is unsupported: {block}";
                    }
                }
                else
                {
                    return "The condition is false, so no code will be executed.";
                }
            }

            return $"{statement} is an invalid if statement.";
        }

        private bool EvaluateCondition(string condition)
        {
            var match = Regex.Match(condition, @"(\d+)\s*(<=|>=|<|>|==|!=)\s*(\d+)");
            if (match.Success)
            {
                int leftOperand = int.Parse(match.Groups[1].Value);
                string operatorSymbol = match.Groups[2].Value;
                int rightOperand = int.Parse(match.Groups[3].Value);

                return operatorSymbol switch
                {
                    ">" => leftOperand > rightOperand,
                    "<" => leftOperand < rightOperand,
                    "==" => leftOperand == rightOperand,
                    ">=" => leftOperand >= rightOperand,
                    "<=" => leftOperand <= rightOperand,
                    "!=" => leftOperand != rightOperand,
                    _ => false
                };
            }

            return false;
        }

        private string AnalyzePrintStatement(string statement)
        {
            var match = Regex.Match(statement, @"print\s*\((.*)\)\s*");
            if (match.Success)
            {
                string message = match.Groups[1].Value.Trim();
                if (message.StartsWith("\"") && message.EndsWith("\""))
                {
                    return $"This code will print: {message.Trim('\"')}";
                }
                return $"This code will print: {message}";
            }

            return $"{statement} is a print function call";
        }

        private string AnalyzeInputStatement(string statement)
        {
            var match = Regex.Match(statement, @"input\s*\((.*)\)\s*");
            if (match.Success)
            {
                string prompt = match.Groups[1].Value.Trim();
                if (prompt.StartsWith("\"") && prompt.EndsWith("\""))
                {
                    return $"This code will prompt for input with: {prompt.Trim('\"')}";
                }
                return $"This code will prompt for input with a dynamic expression: {prompt}";
            }

            return $"{statement} is an input function call";
        }

        private bool IsMathExpression(string statement)
        {
            return Regex.IsMatch(statement, @"\+|\-|\*|\/|\%|\^");
        }

        private string AnalyzeTokens(string statement)
        {
            var tokens = Tokenize(statement);
            StringBuilder result = new StringBuilder();

            foreach (var token in tokens)
            {
                if (Array.Exists(new[] { "False", "None", "True", "and", "as", "assert", "async", "await", "break", "class", "continue", "def", "del", "elif", "else", "except", "finally", "for", "from", "global", "if", "import", "in", "is", "lambda", "nonlocal", "not", "or", "pass", "raise", "return", "try", "while", "with", "yield" }, keyword => keyword == token))
                {
                    result.AppendLine($"{token} is a keyword");
                }
                else if (Array.Exists(new[] { "+", "-", "*", "/", "%", "==", "<", ">", "<=", ">=", "&&", "||", "!" }, op => op == token))
                {
                    result.AppendLine($"{token} is an operator");
                }
                else if (Array.Exists(new[] { "print", "input", "abs", "len", "range", "int", "str", "float", "list", "dict", "tuple", "set" }, func => func == token))
                {
                    result.AppendLine($"{token} is a built-in function");
                }
                else if (double.TryParse(token, out _))
                {
                    if (token.Contains("."))
                        result.AppendLine($"{token} is a floating number");
                    else
                        result.AppendLine($"{token} is an integer");
                }
                else
                {
                    result.AppendLine($"{token} is a variable");
                }
            }

            return result.ToString();
        }

        private string[] Tokenize(string statement)
        {
            return Regex.Split(statement, @"(\s+|[+\-*/%=();,<>!&|])")
                        .Where(token => !string.IsNullOrWhiteSpace(token))
                        .ToArray();
        }
    }
}