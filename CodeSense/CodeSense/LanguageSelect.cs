using System;
using System.Security.Policy;
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
            

            AnalyzePage analyzePage = new AnalyzePage("Python");
            analyzePage.ShowDialog();
            this.Close();
        }

        private void Csselect_Click(object sender, EventArgs e)
        {
           

            AnalyzePage analyzePage = new AnalyzePage("C#");
            analyzePage.ShowDialog();
            this.Close();
        }

        private void LangBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }
    }
}


