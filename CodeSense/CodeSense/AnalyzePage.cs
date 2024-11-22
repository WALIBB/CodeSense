using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CodeSense
{
    public partial class AnalyzePage : Form
    {
        private readonly StatementAnalyzer analyzer;

        public AnalyzePage(string language)
        {
            InitializeComponent();

           
            lblLanguage.Text = "Selected Language: " + language;
            lblLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

           
            lblLanguage.Size = TextRenderer.MeasureText(lblLanguage.Text, lblLanguage.Font);
            lblLanguage.Location = new Point(
                (ClientSize.Width - lblLanguage.Width) / 2,
                textBox1.Location.Y - lblLanguage.Height - 10
            );

         
            if (language == "Python")
                analyzer = new PythonStatementAnalyzer();
            else if (language == "C#")
                analyzer = new CSharpStatementAnalyzer();
            else
                throw new ArgumentException("Unsupported language");
        }

        private void DetectButton_Click(object sender, EventArgs e)
        {
            string inputStatement = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(inputStatement))
            {
                FinalResult.Text = "Please enter a statement.";
            }
            else
            {
                string[] statements = inputStatement.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder resultBuilder = new StringBuilder();

                foreach (var statement in statements)
                {
                    string analyzed = analyzer.AnalyzeStatement(statement.Trim());
                    resultBuilder.AppendLine(analyzed);
                }

                FinalResult.Text = resultBuilder.ToString();
            }

            
            FinalResult.Size = TextRenderer.MeasureText(FinalResult.Text, FinalResult.Font);
            FinalResult.Location = new Point(
                (ClientSize.Width - FinalResult.Width) / 2,
                label2.Location.Y + label2.Height + 10
            );
        }

        private void AnalyzeBack_Click(object sender, EventArgs e)
        {
            LanguageSelect languageSelectPage = new LanguageSelect();
            languageSelectPage.Show();
            this.Hide();
        }
    }
}
