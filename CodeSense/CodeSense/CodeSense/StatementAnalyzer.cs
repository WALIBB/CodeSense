using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeSense
{
    public abstract class StatementAnalyzer
    {
        public abstract string AnalyzeStatement(string statement);

        protected List<string> Tokenize(string statement)
        {
            List<string> tokens = new List<string>();
            string[] multiWordKeywords = { "else if", "if elif", "if else", "elif else" };

            foreach (var keyword in multiWordKeywords)
            {
                if (statement.Contains(keyword))
                {
                    tokens.Add(keyword);
                    statement = statement.Replace(keyword, "");
                }
            }

            string pattern = @"\b(?:False|True|None|and|or|not|if|elif|else|else if|return|class|def|while|for|do|break|continue|switch|case|default|\d+\.\d+|\d+|[+\-*/%=\(\)\[\]{}<>!&|,.;]+|\w+)\b";
            Regex regex = new Regex(pattern);
            foreach (Match match in regex.Matches(statement))
            {
                tokens.Add(match.Value);
            }

            return tokens;
        }

        protected bool IsMathExpression(string statement)
        {
            string pattern = @"^\s*\d+(\s*[\+\-\*/%]\s*\d+)+\s*$";
            return Regex.IsMatch(statement, pattern);
        }
    }
}
