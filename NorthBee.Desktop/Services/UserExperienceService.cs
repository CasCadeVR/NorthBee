using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NorthBee.Desktop.Constants;

namespace NorthBee.Desktop.Services
{
    /// <summary>
    /// PKGH
    /// Настройка форм и элементов управления.
    /// </summary>
    public static class UserExperienceService
    {
        /// <summary>
        /// PKGH
        /// Задать заголовок окна
        /// </summary>
        public static void SetTitle(Form form, string text)
        {
            Label label = form.Controls.Find("titleLabel", true).FirstOrDefault() as Label;
            label.Text = text.ToUpper();
            form.Text = text;
        }

        /// <summary>
        /// PKGH
        /// Задать цвет элементов
        /// </summary>
        public static void CustomizeControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Name.EndsWith("MainBackground"))
                {
                    control.BackColor = ColorTranslator.FromHtml(ColorScheme.MainBackgroundColor);
                }
                if (control.Name.EndsWith("AccentBackground"))
                {
                    control.BackColor = ColorTranslator.FromHtml(ColorScheme.AccentColor);
                    control.ForeColor = ColorTranslator.FromHtml(ColorScheme.MainBackgroundColor);
                }
                if (control.Name.EndsWith("ExtraBackground"))
                {
                    control.BackColor = ColorTranslator.FromHtml(ColorScheme.ExtraColor);
                }
            }
        }
    }
}
