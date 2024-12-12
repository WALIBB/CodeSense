using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace CodeSense
{
    public static class ThemeManager
    {
        public enum Mode { Default, Light, Dark }

        public static Mode CurrentMode { get; private set; } = Mode.Default;

        
        public static event Action<Mode> OnThemeChanged;

        
        public static void SetTheme(Mode mode)
        {
            if (CurrentMode != mode)
            {
                CurrentMode = mode;
                OnThemeChanged?.Invoke(mode);
            }
        }

       
        public static void ApplyTheme(Form form)
        {
            
            switch (CurrentMode)
            {
                case Mode.Dark:
                    form.BackColor = Color.FromArgb(18, 18, 18); 
                    UpdateControls(form.Controls, Color.White, Color.DarkSlateGray); 
                    break;

                case Mode.Light:
                    form.BackColor = Color.White; 
                    UpdateControls(form.Controls, Color.Black, Color.LightGray); 
                    break;

                default: 
                    form.BackColor = SystemColors.ActiveBorder;
                    UpdateControls(form.Controls, Color.Black, SystemColors.Control); 
                    break;
            }

            
            foreach (Control control in form.Controls)
            {
                if (control is Button button)
                {
                    
                    if (button.Name == "DetectButton")
                    {
                        button.BackColor = Color.Red; 
                        button.ForeColor = Color.Yellow; 
                    }

                    
                    if (button.Name == "StartButton")
                    {
                        button.BackColor = Color.Red; 
                        button.ForeColor = Color.Yellow; 
                    }
                }
            }
        }

      
        private static void UpdateControls(Control.ControlCollection controls, Color textColor, Color backgroundColor)
        {
            foreach (Control control in controls)
            {
                if (control is Label label)
                {
                    label.ForeColor = textColor;
                }
                else if (control is Button button)
                {
                    button.ForeColor = textColor;
                    button.BackColor = backgroundColor;
                }
                else if (control is TextBox textBox)
                {
                    textBox.ForeColor = textColor;
                    textBox.BackColor = backgroundColor;
                }
                else if (control is Panel panel)
                {
                    panel.BackColor = backgroundColor;
                    UpdateControls(panel.Controls, textColor, backgroundColor); 
                }
                else if (control is GroupBox groupBox)
                {
                    groupBox.ForeColor = textColor;
                    UpdateControls(groupBox.Controls, textColor, backgroundColor); 
                }
            }
        }
    }
}
