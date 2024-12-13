using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace CodeSense
{
    public partial class LanguageSelect : Form, IThemable
    {
        public LanguageSelect()
        {
            InitializeComponent();
            ApplyTheme();
            ThemeManager.OnThemeChanged += OnThemeChanged;
        }

        public void ApplyTheme()
        {
            FormManager.ApplyTheme(this); 
        }

        private void OnThemeChanged(ThemeManager.Mode mode)
        {
            ApplyTheme(); 
        }

        private void Pythonselect_Click(object sender, EventArgs e)
        {
            IStatementAnalyzer analyzer = new PythonStatementAnalyzer();
            AnalyzePage analyzePage = new AnalyzePage(analyzer);
            analyzePage.Show();
            this.Close();
        }

        private void Csselect_Click(object sender, EventArgs e)
        {
            IStatementAnalyzer analyzer = new CSharpStatementAnalyzer();
            AnalyzePage analyzePage = new AnalyzePage(analyzer);
            analyzePage.Show();
            this.Close();
        }

        private void Cppselect_Click(object sender, EventArgs e)
        {
            IStatementAnalyzer analyzer = new CppStatementAnalyzer();
            AnalyzePage analyzePage = new AnalyzePage(analyzer);
            analyzePage.Show();
            this.Close();
        }

        private void LangBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ThemeManager.OnThemeChanged -= OnThemeChanged;
            base.OnFormClosed(e);
        }
    }
}

