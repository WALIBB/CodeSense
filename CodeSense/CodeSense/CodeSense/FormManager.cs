using CodeSense;
using System.Security.Policy;
using System.Windows.Forms;

namespace CodeSense
{
    public static class FormManager
    {
        
        public static void ApplyTheme(Form form)
        {
           
            ThemeManager.ApplyTheme(form);

           
            foreach (Control control in form.Controls)
            {
                if (control is IThemable themeableControl)
                {
                    themeableControl.ApplyTheme();
                }
            }
        }

     
        public static void SwitchForm(Form currentForm, Form nextForm)
        {
            currentForm.Hide();
            nextForm.Show();
        }
    }
}


