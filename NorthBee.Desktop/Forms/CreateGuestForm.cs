using System;
using System.Windows.Forms;
using NorthBee.Desktop.Exceptions;
using NorthBee.Desktop.Models;
using NorthBee.Desktop.Services;

namespace NorthBee.Desktop.Forms
{
    /// <summary>
    /// PKGH
    /// Форма редактирования гостя
    /// </summary>
    public partial class CreateGuestForm : BaseForm
    {
        private readonly Guest guest;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="MainForm"/>
        /// </summary>
        public CreateGuestForm() : base()
        {
            InitializeComponent();
            this.guest = new Guest();
            UserExperienceService.SetTitle(this, "Новый гость");
        }

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="MainForm"/>
        /// </summary>
        public CreateGuestForm(Guest guest) : base()
        {
            InitializeComponent();
            this.guest = guest;
            UserExperienceService.SetTitle(this, $"Редактирования гостя {guest.FullName}");
        }

        private void FillModelFields()
        {
            guest.FullName = fullNameTextBox.Text.Trim();
            guest.GenderId = (int)genderIdComboBox.SelectedValue;
            guest.StatusId = (int)statusIdComboBox.SelectedValue;
            guest.Birthday = birthdayDateTimePicker.Value;
        }

        private void CreateGuestForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'turchaninov_andrey_northbeeDataSet.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.turchaninov_andrey_northbeeDataSet.Status);
            // TODO: This line of code loads data into the 'turchaninov_andrey_northbeeDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.turchaninov_andrey_northbeeDataSet.Gender);
            //this.guestTableAdapter.Fill(this.turchaninov_andrey_northbeeDataSet.Guest);

            if (!guest.IsNew)
            {
                guestBindingSource.DataSource = guest;
            }

            UserExperienceService.CustomizeControls(splitContainerMainBackground.Panel2.Controls);
        }

        private void ValidateFullName()
        {
            if (fullNameTextBox.Text == string.Empty)
            {
                throw new ValidateException("ФИО не должно быть пустым");
            }

            if (fullNameTextBox.Text.Split(' ').Length < 3)
            {
                throw new ValidateException("ФИО должно быть полным");
            }
        }

        private void ValidateBirthDay()
        {
            if (birthdayDateTimePicker.Value > DateTime.UtcNow)
            {
                throw new ValidateException("Дата рождения не может быть в будущем");
            }
        }

        private void buttonActionAccentBackground_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSaveAccentBackground_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateFullName();
                ValidateBirthDay();
            }
            catch (ValidateException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillModelFields();

            if (guest.IsNew)
            {
                Program.Context.Guest.Add(guest);
            }

            DialogResult toBeSaved = MessageBox.Show(
                "Сохранить?",
                "Запрос подтверждения",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (toBeSaved == DialogResult.No)
            {
                return;
            }

            try
            {
                Program.Context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
