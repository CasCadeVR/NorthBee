using System.Windows.Forms;
using NorthBee.Desktop.Services;

namespace NorthBee.Desktop.Forms
{
    /// <summary>
    /// PKGH
    /// Базовая форма приложения
    /// </summary>
    public partial class BaseForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="BaseForm"/>
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();
            UserExperienceService.CustomizeControls(Controls);
            UserExperienceService.CustomizeControls(splitContainerMainBackground.Panel1.Controls);
        }
    }
}
