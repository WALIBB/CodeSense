using System;
using System.Windows.Forms;

namespace CodeSense
{
    public partial class LanguageSelect : Form
    {
        public LanguageSelect()
        {
            InitializeComponent();
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
    }
}
