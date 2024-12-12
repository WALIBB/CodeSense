using System;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace CodeSense
{
    public partial class AnalyzePage : Form
    {
        private readonly IStatementAnalyzer analyzer;

        public AnalyzePage(IStatementAnalyzer statementAnalyzer)
        {
            InitializeComponent();
            analyzer = statementAnalyzer;

            lblLanguage.Text = $"Selected Language: {analyzer.GetType().Name.Replace("StatementAnalyzer", "")}";
            lblLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLanguage.Size = TextRenderer.MeasureText(lblLanguage.Text, lblLanguage.Font);
            lblLanguage.Location = new Point(
                (ClientSize.Width - lblLanguage.Width) / 2,
                textBox1.Location.Y - lblLanguage.Height - 10
            );

            // Apply the current theme initially
            ApplyTheme();

            // Subscribe to theme change event
            ThemeManager.OnThemeChanged += OnThemeChanged;
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

        private void OnThemeChanged(ThemeManager.Mode mode)
        {
            
            ApplyTheme();
        }

        private void ApplyTheme()
        {
           
            ThemeManager.ApplyTheme(this);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            
            ThemeManager.OnThemeChanged -= OnThemeChanged;
            base.OnFormClosed(e);
        }
    }
}


