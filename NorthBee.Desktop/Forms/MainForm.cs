using System.Linq;
using System.Windows.Forms;
using NorthBee.Desktop.CustomControls;
using NorthBee.Desktop.Models;
using NorthBee.Desktop.Services;

namespace NorthBee.Desktop.Forms
{
    /// <summary>
    /// PKGH
    /// Главная форма приложения
    /// </summary>
    public partial class MainForm : BaseForm
    {
        /// <summary>
        /// PKGH
        /// Инициализирует новый экземпляр <see cref="MainForm"/>
        /// </summary>
        public MainForm() : base()
        {
            InitializeComponent();
            UserExperienceService.SetTitle(this, "Главная страница");
            ShowAllGuests();
        }

        private void ShowAllGuests()
        {
            flowLayoutPanel.Controls.Clear();
            var guests = Program.Context.Guest.OrderBy(p => p.FullName).ToList();
            foreach (var guest in guests)
            {
                var card = new GuestCard(guest);
                card.OnClick += () => ShowGuestEditForm(guest);
                flowLayoutPanel.Controls.Add(card);
            }
        }

        private void ShowGuestCreateForm()
        {
            if (new CreateGuestForm().ShowDialog() == DialogResult.OK)
            {
                ShowAllGuests();
            }
        }

        private void ShowGuestEditForm(Guest guest)
        {
            if (new CreateGuestForm(guest).ShowDialog() == DialogResult.OK)
            {
                ShowAllGuests();
            }
        }

        private void buttonActionAccentBackground_Click(object sender, System.EventArgs e)
        {
            ShowGuestCreateForm();
        }
    }
}
