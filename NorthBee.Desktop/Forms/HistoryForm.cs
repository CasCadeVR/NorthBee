using System.Linq;
using NorthBee.Desktop.Models;
using NorthBee.Desktop.Services;

namespace NorthBee.Desktop.Forms
{
    /// <summary>
    /// PKGH
    /// Главная форма приложения
    /// </summary>
    public partial class HistoryForm : BaseForm
    {
        private readonly Guest guest;

        /// <summary>
        /// PKGH
        /// Инициализирует новый экземпляр <see cref="MainForm"/>
        /// </summary>
        public HistoryForm(Guest guest) : base()
        {
            InitializeComponent();
            this.guest = guest;
            UserExperienceService.SetTitle(this, $"История гостя {guest.FullName}");
        }

        private void HistoryForm_Load(object sender, System.EventArgs e)
        {
            this.roomTableAdapter.Fill(this.turchaninov_andrey_northbeeDataSet.Room);
            this.historyTableAdapter.Fill(this.turchaninov_andrey_northbeeDataSet.History);

            historyBindingSource.DataSource = Program.Context.History
                .Where(x => x.GuestId == guest.IdGuest)
                .Select(h => new
                {
                    RoomName = h.Room.Number,
                    HotelName = h.Room.Hotel.HotelName,
                    h.CheckIn,
                    h.CheckOut,
                    h.Comment,
                })
                .OrderByDescending(x => x.CheckOut).ToList();
        }

        private void buttonActionAccentBackground_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
