using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeSense
{
    public class CppStatementAnalyzer : IStatementAnalyzer
    {
        public string AnalyzeStatement(string statement)
        {
            statement = statement.Trim();
                  
           
            if (statement == "cout")
                return "cout is a shorthand for std::cout (used for output).";
            if (statement == "std::cout")
                return "std::cout is used for output in C++.";

            
            if (statement.StartsWith("std::cout"))
                return AnalyzeCout(statement);
            if (statement.StartsWith("if"))
                return AnalyzeIfStatement(statement);

            
            return AnalyzeTokens(statement);
        }


        private string AnalyzeCout(string statement)
        {
            statement = statement.Trim();

        
    
            if (!statement.StartsWith("std::cout") && !statement.StartsWith("cout"))
                return $"{statement} is an invalid output statement (missing cout)";
            if (!statement.Contains("<<"))
                return $"{statement} is an invalid output statement (missing <<)";
            if (!statement.EndsWith(";"))
                return $"{statement} is an invalid output statement (missing semicolon)";
            if (!statement.Contains('"'))
                return $"{statement} is an invalid output statement";

           
            var match = Regex.Match(statement, @"(std::cout|cout)\s*<<\s*(.*);");
            if (match.Success)
            {
                string output = match.Groups[2].Value.Trim();
                return $"This code will print {output}";
            }

            return $"{statement} is an invalid output statement";
        }


        private string AnalyzeCin(string statement)
        {
         
            statement = statement.Trim();

            
            if (!statement.StartsWith("std::cin"))
                return $"{statement} is an invalid input statement (missing std::cin)";
            if (!statement.Contains(">>"))
                return $"{statement} is an invalid input statement (>>)";
            if (!statement.EndsWith(";"))
                return $"{statement} is an invalid input statement (missing semicolon)";

           
            var match = Regex.Match(statement, @"std::cin\s*>>\s*(.*);");
            if (match.Success)
            {
                string inputVariable = match.Groups[1].Value.Trim();
                return $"This code will read input into: {inputVariable}";
            }

            return $"{statement} is an invalid input statement";
        }

        
        private string AnalyzeIfStatement(string statement)
        {
            statement = statement.Trim();

            if (!statement.StartsWith("if"))
                return "Invalid conditional statement (missing 'if')";

            var match = Regex.Match(statement, @"if\s*\(([^)]+)\)\s*(\{.*\}|[^\{]*[^{};]+)?\s*;?");

            if (match.Success)
            {
                string condition = match.Groups[1].Value.Trim();
                string codeInsideBlock = match.Groups[2].Value?.Trim();

                bool conditionIsTrue = EvaluateCondition(condition);

                if (string.IsNullOrEmpty(codeInsideBlock))
                    return $"The condition is {(conditionIsTrue ? "true" : "false")}, but no code inside the block.";

                if (conditionIsTrue)
                {
                    if (codeInsideBlock.StartsWith("{") && codeInsideBlock.EndsWith("}"))
                    {
                        codeInsideBlock = codeInsideBlock[1..^1].Trim(); 
                    }
                    return $"The condition is true, {AnalyzeCout(codeInsideBlock)}";
                }
                else
                {
                    return "The condition is false, no output will be printed.";
                }
            }

            return "Invalid conditional statement (invalid format)";
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

        private string AnalyzeTokens(string statement)
        {
            var tokens = Tokenize(statement);
            StringBuilder result = new StringBuilder();

            foreach (var token in tokens)
            {
              
                if (Array.Exists(new[] { "false", "true", "void", "int", "string", "if", "else", "for", "while", "return", "nullptr" }, keyword => keyword == token))
                    result.AppendLine($"{token} is a keyword");
                else if (Array.Exists(new[] { "std::cout", "std::cin", "std::cerr", "std::clog", "std::getline", "std::string", "std::to_string" }, op => op == token))
                    result.AppendLine($"{token} is a built-in function");
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

        private string[] Tokenize(string statement)
        {
            return Regex.Split(statement, @"(\s+|[+\-*/%=();,<>!&|])").Where(token => !string.IsNullOrWhiteSpace(token)).ToArray();
        }
    }
}


