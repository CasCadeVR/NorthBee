using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NorthBee.Desktop.Constants;
using NorthBee.Desktop.Forms;
using NorthBee.Desktop.Models;
using NorthBee.Desktop.Services;

namespace NorthBee.Desktop.CustomControls
{
    /// <summary>
    /// PKGH
    /// Карточка гостя
    /// </summary>
    public partial class GuestCard : UserControl
    {
        private readonly Guest guest;

        /// <summary>
        /// PKGH
        /// Событие по нажатию на карточку
        /// </summary>
        public Action OnClick;

        /// <summary>
        /// PKGH
        /// Инициализирует новый экземпляр <see cref="GuestCard"/>
        /// </summary>
        public GuestCard(Guest guest)
        {
            InitializeComponent();
            this.guest = guest;
            FillFields();
            UserExperienceService.CustomizeControls(Controls);
        }

        private void FillFields()
        {
            labelFullName.Text = $"ФИО: {guest.FullName}";
            labelGender.Text = $"Пол: {guest.Gender.GenderName}";
            labelBirthDay.Text = $"Дата рождения: {guest.Birthday.ToShortDateString()}";
            labelArriveCount.Text = $"Сколько останавливался : {guest.History.Count()}";
            labelStatus.Text = $"Статус: {guest.Status.StatusName}";
        }

        private void GuestCard_Click(object sender, System.EventArgs e)
        {
            OnClick.Invoke();
        }

        private void buttonHistoryAccentBackground_Click(object sender, System.EventArgs e)
        {
            new HistoryForm(guest).ShowDialog();
        }

        private void GuestCard_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                ColorTranslator.FromHtml(ColorScheme.ExtraColor), ButtonBorderStyle.Solid);
        }
    }
}
