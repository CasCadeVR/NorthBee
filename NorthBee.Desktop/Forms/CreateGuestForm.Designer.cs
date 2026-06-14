namespace NorthBee.Desktop.Forms
{
    partial class CreateGuestForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderIdLabel;
            System.Windows.Forms.Label statusIdLabel;
            this.turchaninov_andrey_northbeeDataSet = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSet();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestTableAdapter = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.GuestTableAdapter();
            this.tableAdapterManager = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.TableAdapterManager();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveAccentBackground = new System.Windows.Forms.Button();
            this.genderIdComboBox = new System.Windows.Forms.ComboBox();
            this.statusIdComboBox = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.GenderTableAdapter();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.StatusTableAdapter();
            fullNameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            genderIdLabel = new System.Windows.Forms.Label();
            statusIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainBackground)).BeginInit();
            this.splitContainerMainBackground.Panel1.SuspendLayout();
            this.splitContainerMainBackground.Panel2.SuspendLayout();
            this.splitContainerMainBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turchaninov_andrey_northbeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonActionAccentBackground
            // 
            this.buttonActionAccentBackground.Text = "Назад";
            this.buttonActionAccentBackground.Click += new System.EventHandler(this.buttonActionAccentBackground_Click);
            // 
            // splitContainerMainBackground
            // 
            // 
            // splitContainerMainBackground.Panel2
            // 
            this.splitContainerMainBackground.Panel2.AutoScroll = true;
            this.splitContainerMainBackground.Panel2.Controls.Add(statusIdLabel);
            this.splitContainerMainBackground.Panel2.Controls.Add(this.statusIdComboBox);
            this.splitContainerMainBackground.Panel2.Controls.Add(genderIdLabel);
            this.splitContainerMainBackground.Panel2.Controls.Add(this.genderIdComboBox);
            this.splitContainerMainBackground.Panel2.Controls.Add(this.buttonSaveAccentBackground);
            this.splitContainerMainBackground.Panel2.Controls.Add(fullNameLabel);
            this.splitContainerMainBackground.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainerMainBackground.Panel2.Controls.Add(birthdayLabel);
            this.splitContainerMainBackground.Panel2.Controls.Add(this.birthdayDateTimePicker);
            this.splitContainerMainBackground.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.splitContainerMainBackground.Size = new System.Drawing.Size(359, 277);
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fullNameLabel.Location = new System.Drawing.Point(23, 20);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(41, 16);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "ФИО:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            birthdayLabel.Location = new System.Drawing.Point(23, 47);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(109, 16);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Дата рождения:";
            // 
            // turchaninov_andrey_northbeeDataSet
            // 
            this.turchaninov_andrey_northbeeDataSet.DataSetName = "turchaninov_andrey_northbeeDataSet";
            this.turchaninov_andrey_northbeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.turchaninov_andrey_northbeeDataSet;
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = this.guestTableAdapter;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(135, 20);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.guestBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(135, 46);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 3;
            // 
            // buttonSaveAccentBackground
            // 
            this.buttonSaveAccentBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveAccentBackground.Location = new System.Drawing.Point(12, 130);
            this.buttonSaveAccentBackground.Name = "buttonSaveAccentBackground";
            this.buttonSaveAccentBackground.Size = new System.Drawing.Size(323, 51);
            this.buttonSaveAccentBackground.TabIndex = 8;
            this.buttonSaveAccentBackground.Text = "Сохранить";
            this.buttonSaveAccentBackground.UseVisualStyleBackColor = true;
            this.buttonSaveAccentBackground.Click += new System.EventHandler(this.buttonSaveAccentBackground_Click);
            // 
            // genderIdLabel
            // 
            genderIdLabel.AutoSize = true;
            genderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            genderIdLabel.Location = new System.Drawing.Point(23, 72);
            genderIdLabel.Name = "genderIdLabel";
            genderIdLabel.Size = new System.Drawing.Size(36, 16);
            genderIdLabel.TabIndex = 8;
            genderIdLabel.Text = "Пол:";
            // 
            // genderIdComboBox
            // 
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "GenderId", true));
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.guestBindingSource, "GenderId", true));
            this.genderIdComboBox.DataSource = this.genderBindingSource;
            this.genderIdComboBox.DisplayMember = "GenderName";
            this.genderIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderIdComboBox.FormattingEnabled = true;
            this.genderIdComboBox.Location = new System.Drawing.Point(135, 72);
            this.genderIdComboBox.Name = "genderIdComboBox";
            this.genderIdComboBox.Size = new System.Drawing.Size(201, 21);
            this.genderIdComboBox.TabIndex = 9;
            this.genderIdComboBox.ValueMember = "IdGender";
            // 
            // statusIdLabel
            // 
            statusIdLabel.AutoSize = true;
            statusIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            statusIdLabel.Location = new System.Drawing.Point(23, 96);
            statusIdLabel.Name = "statusIdLabel";
            statusIdLabel.Size = new System.Drawing.Size(56, 16);
            statusIdLabel.TabIndex = 9;
            statusIdLabel.Text = "Статус:";
            // 
            // statusIdComboBox
            // 
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "StatusId", true));
            this.statusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.guestBindingSource, "StatusId", true));
            this.statusIdComboBox.DataSource = this.statusBindingSource;
            this.statusIdComboBox.DisplayMember = "StatusName";
            this.statusIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusIdComboBox.FormattingEnabled = true;
            this.statusIdComboBox.Location = new System.Drawing.Point(134, 99);
            this.statusIdComboBox.Name = "statusIdComboBox";
            this.statusIdComboBox.Size = new System.Drawing.Size(201, 21);
            this.statusIdComboBox.TabIndex = 10;
            this.statusIdComboBox.ValueMember = "IdStatus";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.turchaninov_andrey_northbeeDataSet;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.turchaninov_andrey_northbeeDataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // CreateGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 277);
            this.Name = "CreateGuestForm";
            this.Load += new System.EventHandler(this.CreateGuestForm_Load);
            this.splitContainerMainBackground.Panel1.ResumeLayout(false);
            this.splitContainerMainBackground.Panel1.PerformLayout();
            this.splitContainerMainBackground.Panel2.ResumeLayout(false);
            this.splitContainerMainBackground.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainBackground)).EndInit();
            this.splitContainerMainBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.turchaninov_andrey_northbeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private turchaninov_andrey_northbeeDataSet turchaninov_andrey_northbeeDataSet;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private turchaninov_andrey_northbeeDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
        private turchaninov_andrey_northbeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.ComboBox statusIdComboBox;
        private System.Windows.Forms.ComboBox genderIdComboBox;
        private System.Windows.Forms.Button buttonSaveAccentBackground;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private turchaninov_andrey_northbeeDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private turchaninov_andrey_northbeeDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
    }
}

