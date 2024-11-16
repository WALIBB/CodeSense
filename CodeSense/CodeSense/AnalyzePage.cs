using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CodeSense
{
    public partial class AnalyzePage : Form
    {
        private string selectedLanguage;

        public AnalyzePage(string language)
        {
            InitializeComponent();
            selectedLanguage = language;
            lblLanguage.Text = "Selected Language: " + selectedLanguage;
            lblLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLanguage.Location = new Point((ClientSize.Width - lblLanguage.Width) / 2, textBox1.Location.Y - lblLanguage.Height - 10);
        }

        // Tokenize input statement
        private List<string> Tokenize(string statement)
        {
            List<string> tokens = new List<string>();

            
            string[] multiWordKeywords = new[] { "else if", "if elif", "if else", "elif else" };

            
            foreach (var keyword in multiWordKeywords)
            {
                if (statement.Contains(keyword))
                {
                    tokens.Add(keyword);
                    statement = statement.Replace(keyword, ""); 
                }
            }

            
            if (statement.StartsWith("\"") && statement.EndsWith("\""))
            {
                tokens.Add(statement);
                return tokens;
            }

            string pattern = @"\b(?:False|True|None|and|or|not|if|elif|else|else if|return|class|def|while|for|do|break|continue|switch|case|default|\d+\.\d+|\d+|[+\-*/%=\(\)\[\]{}<>!&|,.;]+|\w+)\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(statement);
            foreach (Match match in matches)
            {
                tokens.Add(match.Value);
            }

            return tokens;
        }

        
        private bool IsMathExpression(string statement)
        {
            string pattern = @"^\s*\d+(\s*[\+\-\*/%]\s*\d+)+\s*$";
            return Regex.IsMatch(statement, pattern);
        }

        
        private string AnalyzeStatement(string statement)
        {
            statement = statement.Trim();

            // Check if it's a string
            if (statement.StartsWith("\"") && statement.EndsWith("\""))
            {
                return $"{statement} is a string";
            }

            // Check if it's a mathematical expression
            if (IsMathExpression(statement))
            {
                return $"{statement} is a mathematical expression";
            }

            // Check for C# and Python-specific logic
            if (selectedLanguage == "Python")
            {
                // Python check conditionals (if, elif, else)
                if (Regex.IsMatch(statement, @"^\s*(if|elif|else)\s+.*\s*[<>=!]=?\s*.*$"))
                {
                    return $"{statement} is a conditional statement";
                }

                // Check for Python assignment
                if (Regex.IsMatch(statement, @"^\w+\s*\=\s*.*$"))
                {
                    return $"{statement} is an assignment";
                }

                // Python data types
                if (Array.Exists(new[] { "int", "str", "bool", "float", "list", "dict" }, type => type == statement))
                {
                    return $"{statement} is a data type";
                }
            }
            else if (selectedLanguage == "C#")
            {
                // C# conditionals
                if (Regex.IsMatch(statement, @"^\s*if\s*\(.*\)\s*$"))
                {
                    return $"{statement} is a conditional statement";
                }
                if (Regex.IsMatch(statement, @"^\s*else\s+if\s*\(.*\)\s*$"))
                {
                    return $"{statement} is a conditional statement";
                }

                // C# assignment
                if (Regex.IsMatch(statement, @"^\s*\w+\s+\w+\s*=\s*.*;$"))
                {
                    return $"{statement} is an assignment";
                }

                // C# data types
                if (Array.Exists(new[] { "int", "string", "bool", "float", "double", "char" }, type => type == statement))
                {
                    return $"{statement} is a data type";
                }
            }

            List<string> tokens = Tokenize(statement);
            StringBuilder result = new StringBuilder();

            foreach (var token in tokens)
            {
                // for Python keywords and data types
                if (selectedLanguage == "Python" && Array.Exists(new[] { "False", "True", "None", "and", "or", "not", "if", "elif", "else", "return", "class", "def" }, keyword => keyword == token))
                {
                    result.AppendLine($"{token} is a keyword");
                }
                // for keywords
                else if (selectedLanguage == "C#" && Array.Exists(new[] { "false", "true", "void", "int", "string", "if", "else", "else if", "for", "while", "return", "public", "private", "class", "static" }, keyword => keyword == token))
                {
                    result.AppendLine($"{token} is a keyword");
                }
                // for operators
                else if (Array.Exists(new[] { "+", "-", "*", "/", "%", "==", "<", ">", "<=", ">=", "&&", "||", "!", "&", "|" }, op => op == token))
                {
                    result.AppendLine($"{token} is an operator");
                }
                // for integers and floating numbers
                else if (double.TryParse(token, out double number) && token.Contains("."))
                {
                    result.AppendLine($"{token} is a floating number");
                }
                else if (int.TryParse(token, out _))
                {
                    result.AppendLine($"{token} is an integer");
                }
                // foe built in functions
                else if (Array.Exists(new[] { "print", "len", "type", "range", "input" }, func => func == token))
                {
                    result.AppendLine($"{token} is a built-in function");
                }
                // for data types
                else if (Array.Exists(new[] { "int", "string", "bool", "float", "list", "dict", "set", "tuple" }, dataType => dataType == token))
                {
                    result.AppendLine($"{token} is a data type");
                }
                else
                {
                    result.AppendLine($"{token} is a variable");
                }
            }

            return result.ToString();
        }

        
        private string AnalyzeMultipleStatements(string input)
        {
            string[] statements = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            foreach (var statement in statements)
            {
                string trimmedStatement = statement.Trim();
                if (!string.IsNullOrEmpty(trimmedStatement))
                {
                    result.AppendLine(AnalyzeStatement(trimmedStatement));
                }
            }

            return result.ToString();
        }

        private void DetectButton_Click(object sender, EventArgs e)
        {
            string inputStatement = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(inputStatement))
            {
                FinalResult.Text = "Please enter a statement.";
                return;
            }

            string result = AnalyzeMultipleStatements(inputStatement);
            FinalResult.Text = result;
            FinalResult.Location = new Point((ClientSize.Width - FinalResult.Width) / 2, label2.Location.Y + label2.Height + 10);
        }

        private void AnalyzeBack_Click(object sender, EventArgs e)
        {
            LanguageSelect languageSelectPage = new LanguageSelect();
            languageSelectPage.Show();
            this.Hide();
        }
    }
}


