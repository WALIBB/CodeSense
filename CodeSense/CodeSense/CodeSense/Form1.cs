using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace CodeSense
{
    public partial class HomePage : Form, IThemable
    {
        public HomePage()
        {
            InitializeComponent();
            StartButton.Click += new EventHandler(StartButton_Click);
            btnDarkMode.Click += new EventHandler(BtnDarkMode_Click);

            ApplyTheme();
            ThemeManager.OnThemeChanged += OnThemeChanged;
        }

        public void ApplyTheme()
        {
            FormManager.ApplyTheme(this); // Apply theme to the form using FormManager

            switch (ThemeManager.CurrentMode)
            {
                case ThemeManager.Mode.Default:
                    btnDarkMode.Text = "Light Mode";
                    break;
                case ThemeManager.Mode.Light:
                    btnDarkMode.Text = "Dark Mode";
                    break;
                case ThemeManager.Mode.Dark:
                    btnDarkMode.Text = "Default Mode";
                    break;
            }
        }

        private void BtnDarkMode_Click(object sender, EventArgs e)
        {
            switch (ThemeManager.CurrentMode)
            {
                case ThemeManager.Mode.Default:
                    ThemeManager.SetTheme(ThemeManager.Mode.Light);
                    break;
                case ThemeManager.Mode.Light:
                    ThemeManager.SetTheme(ThemeManager.Mode.Dark);
                    break;
                case ThemeManager.Mode.Dark:
                    ThemeManager.SetTheme(ThemeManager.Mode.Default);
                    break;
            }
        }

        private void OnThemeChanged(ThemeManager.Mode mode)
        {
            ApplyTheme(); // Reapply the theme when it changes
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            LanguageSelect languageSelectForm = new LanguageSelect();
            languageSelectForm.Show();
            this.Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ThemeManager.OnThemeChanged -= OnThemeChanged;
            base.OnFormClosed(e);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
    

