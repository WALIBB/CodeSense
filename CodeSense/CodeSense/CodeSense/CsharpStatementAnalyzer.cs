using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Security.Policy;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace CodeSense
{
    public class CSharpStatementAnalyzer : IStatementAnalyzer
    {
        public string AnalyzeStatement(string statement)
        {
            statement = statement.Trim();
            StringBuilder result = new StringBuilder();

           
            if (Regex.IsMatch(statement, @"^\s*//.*$"))
            {
                result.AppendLine($"{statement} is a comment");
            }
            if (Regex.IsMatch(statement, @"^\"".*\""$"))
            {
                return $"{statement} is a string literal";
            }
            if (IsMathExpression(statement))
            {
                return $"{statement} is a mathematical expression";
            }
            else if (Regex.IsMatch(statement, @"^\s*if\s*(\d+)\s*(<=|>=|<|>|==|!=)\s*(\d+)\s*$"))
            {
                result.AppendLine($"{statement} is a conditional statement");
            }
            else if (Regex.IsMatch(statement, @"^\s*Console\.(WriteLine|ReadLine)\s*\(.*\)\s*;?$"))
            {
                if (statement.Contains("WriteLine"))
                    result.AppendLine(AnalyzeConsoleWriteLine(statement));
                if (statement.Contains("ReadLine"))
                    result.AppendLine(AnalyzeReadLine(statement));
            }
            else if (Regex.IsMatch(statement, @"^\s*if\s*\(.*\)\s*(\{[^}]*\}|;)?\s*$"))
            {
                result.AppendLine(AnalyzeIfStatement(statement));
            }
            else if (Regex.IsMatch(statement, @"^\s*else\s*\{?.*\}\s*$"))
            {
                result.AppendLine($"{statement} is an else block");
            }
            else if (Regex.IsMatch(statement, @"^\s*\w+\s*=\s*.*;$"))
            {
                result.AppendLine($"{statement} is an assignment");
            }
            else
            {
                result.AppendLine(AnalyzeTokens(statement));
            }

            return result.ToString().Trim();
        }

        private string AnalyzeConsoleWriteLine(string statement)
        {
            var match = Regex.Match(statement, @"Console\.WriteLine\s*\((.*)\);");
            if (match.Success)
            {
                string message = match.Groups[1].Value.Trim();
                if (string.IsNullOrEmpty(message))
                    return $"{statement} is an invalid Console.WriteLine statement (no content).";
                return $"This code will print: {message}";
            }
            return $"This is an invalid Console.WriteLine statement";
        }

        private string AnalyzeReadLine(string statement)
        {
            var match = Regex.Match(statement, @"Console\.ReadLine\s*\((.*)\);");
            if (match.Success)
            {
                string argument = match.Groups[1].Value.Trim();
                if (string.IsNullOrEmpty(argument))
                    return $"{statement} is an invalid Console.ReadLine statement (no argument).";
                return $"This code will read input into: {argument}";
            }
            return $"{statement} an invalid Console.ReadLine statement";
        }

        private string AnalyzeIfStatement(string statement)
        {
            
            var match = Regex.Match(statement, @"^\s*if\s*\(([^)]*)\)\s*(\{[^}]*\}|;)?$");

            if (match.Success)
            {
                string condition = match.Groups[1].Value.Trim();
                string block = match.Groups[2].Value.Trim(); 

                bool conditionIsTrue = EvaluateCondition(condition); 

                
                if (string.IsNullOrEmpty(block) || block == ";")
                {
                    return conditionIsTrue
                        ? $"{statement} is a conditional statement, and the condition evaluates to true."
                        : $"{statement} is a conditional statement, but the condition evaluates to false.";
                }

                
                if (block.StartsWith("{") && block.EndsWith("}"))
                {
                    block = block[1..^1].Trim(); 
                    return conditionIsTrue
                        ? $"The condition is true, {AnalyzeConsoleWriteLine(block)}"
                        : "The condition is false, so no code will be executed.";
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
                if (Array.Exists(new[] { "false", "true", "void", "int", "string", "bool", "if", "else", "for", "while", "return", "class", "public", "private", "null", "try", "catch", "var" }, keyword => keyword == token))
                    result.AppendLine($"{token} is a keyword");
                else if (Array.Exists(new[] { "Console.WriteLine", "Console.ReadLine" }, op => op == token))
                    result.AppendLine($"{token} is a built-in function");
                else if (Array.Exists(new[] { "+", "-", "*", "/", "%", "==", "<", ">", "<=", ">=", "&&", "||", "!" }, op => op == token))
                    result.AppendLine($"{token} is an operator");
                else if (double.TryParse(token, out _))
                    result.AppendLine($"{token} is a number");
                else
                    result.AppendLine($"{token} is a variable");
            }

            return result.ToString();
        }

        private string[] Tokenize(string statement)
        {
            
            string pattern = @"(\b(?:if|else|for|while|return|int|string|public|private|void|Console\.WriteLine|Console\.ReadLine|null|bool|try|catch|var)\b|""[^""]*"")|([+\-*/%=();,<>!&|])|\b\w+\b|\([^)]*\)";

            
            return Regex.Matches(statement, pattern)
                .Cast<Match>()
                .Select(m => m.Value)
                .Where(token => !string.IsNullOrWhiteSpace(token))
                .ToArray();
        }
    }
}
