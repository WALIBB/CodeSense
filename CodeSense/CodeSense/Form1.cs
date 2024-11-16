using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace CodeSense
{
    public partial class HomePage : Form
    {
        public HomePage() 
        {
            InitializeComponent();
            StartButton.Click += new EventHandler(StartButton_Click); 
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            LanguageSelect languageSelectForm = new LanguageSelect();
           
            languageSelectForm.Show();
            
            this.Hide();
        }
    }
}
