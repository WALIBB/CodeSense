using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodeSense
{
    public enum AppTheme
    {
        DefaultMode,  
        LightMode,    
        DarkMode      
    }

    public static class ThemeManager
    {
        
        public static AppTheme CurrentTheme { get; set; } = AppTheme.DefaultMode;

       
        public static void ApplyTheme(Form form)
        {
            switch (CurrentTheme)
            {
                case AppTheme.DarkMode:
                    ApplyDarkMode(form);
                    break;

                case AppTheme.LightMode:
                    ApplyLightMode(form);
                    break;

                case AppTheme.DefaultMode:
                    ApplyDefaultMode(form);
                    break;
            }
        }

        private static void ApplyDarkMode(Form form)
        {
            form.BackColor = Color.FromArgb(45, 45, 48);
            form.ForeColor = Color.White;

            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.FromArgb(30, 30, 30);
                    control.ForeColor = Color.White;
                }
                else if (control is Label)
                {
                    control.ForeColor = Color.White;
                }
                else if (control is TextBox)
                {
                    control.BackColor = Color.FromArgb(30, 30, 30);
                    control.ForeColor = Color.White;
                }
            }
        }

        private static void ApplyLightMode(Form form)
        {
            form.BackColor = Color.White;
            form.ForeColor = Color.Black;

            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.LightGray;
                    control.ForeColor = Color.Black;
                }
                else if (control is Label)
                {
                    control.ForeColor = Color.Black;
                }
                else if (control is TextBox)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }
            }
        }

        private static void ApplyDefaultMode(Form form)
        {
            form.BackColor = SystemColors.Control;
            form.ForeColor = Color.Black;

            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.Red;  
                    control.ForeColor = Color.Orange;  
                }
                else if (control is Label)
                {
                    control.ForeColor = Color.Black;  
                }
                else if (control is TextBox)
                {
                    control.BackColor = Color.White;  
                    control.ForeColor = Color.Black;  
                }
            }
        }
    }
}
