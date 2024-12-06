using System;
using System.Windows.Forms;
using System.Drawing;

namespace CodeSense
{
    public partial class HomePage : Form
    {
     
        private enum Mode
        {
            Default,
            Light,
            Dark
        }

        private Mode currentMode = Mode.Default;  

        public HomePage()
        {
            InitializeComponent();
            StartButton.Click += new EventHandler(StartButton_Click);
            btnDarkMode.Click += new EventHandler(BtnDarkMode_Click);
            ApplyDefaultMode();  
        }

       
        private void BtnDarkMode_Click(object sender, EventArgs e)
        {
            switch (currentMode)
            {
                case Mode.Default:
                    ApplyLightMode();  
                    currentMode = Mode.Light;
                    btnDarkMode.Text = "Dark Mode"; 
                    break;
                case Mode.Light:
                    ApplyDarkMode();  
                    currentMode = Mode.Dark;
                    btnDarkMode.Text = "Default Mode"; 
                    break;
                case Mode.Dark:
                    ApplyDefaultMode();  
                    currentMode = Mode.Default;
                    btnDarkMode.Text = "Light Mode"; 
                    break;
            }
        }

        
        private void ApplyDarkMode()
        {
            this.BackColor = Color.FromArgb(18, 18, 18);  
            AppTitle.ForeColor = Color.White; 
            Tagline.ForeColor = Color.White; 
            StartButton.BackColor = Color.DarkSlateGray;
            StartButton.ForeColor = Color.White;
            btnDarkMode.BackColor = Color.DarkSlateGray;
            btnDarkMode.ForeColor = Color.White;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
        }

    
        private void ApplyLightMode()
        {
            this.BackColor = Color.White;  
            AppTitle.ForeColor = Color.Black;  
            Tagline.ForeColor = Color.Black;  
            StartButton.BackColor = Color.Red;
            StartButton.ForeColor = Color.Orange;
            btnDarkMode.BackColor = Color.LightGray;
            btnDarkMode.ForeColor = Color.Black;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
        }

        
        private void ApplyDefaultMode()
        {
            this.BackColor = SystemColors.ActiveBorder;  
            AppTitle.ForeColor = Color.Black;  
            Tagline.ForeColor = Color.Black;  
            StartButton.BackColor = Color.Red;
            StartButton.ForeColor = Color.Orange;
            btnDarkMode.BackColor = Color.LightGray;
            btnDarkMode.ForeColor = Color.Black;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            LanguageSelect languageSelectForm = new LanguageSelect();
            languageSelectForm.Show();
            this.Hide();
        }
    }
}