namespace NorthBee.Desktop.Forms
{
    partial class HistoryForm
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
            this.turchaninov_andrey_northbeeDataSet = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSet();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.HistoryTableAdapter();
            this.tableAdapterManager = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.TableAdapterManager();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.checkInDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hotelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.checkInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTableAdapter = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.RoomTableAdapter();
            this.hotelTableAdapter = new NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.HotelTableAdapter();
            this.roomIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainBackground)).BeginInit();
            this.splitContainerMainBackground.Panel1.SuspendLayout();
            this.splitContainerMainBackground.Panel2.SuspendLayout();
            this.splitContainerMainBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turchaninov_andrey_northbeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonActionAccentBackground
            // 
            this.buttonActionAccentBackground.Text = "Закрыть";
            this.buttonActionAccentBackground.Click += new System.EventHandler(this.buttonActionAccentBackground_Click);
            // 
            // splitContainerMainBackground
            // 
            // 
            // splitContainerMainBackground.Panel2
            // 
            this.splitContainerMainBackground.Panel2.AutoScroll = true;
            this.splitContainerMainBackground.Panel2.Controls.Add(this.historyDataGridView);
            this.splitContainerMainBackground.Size = new System.Drawing.Size(800, 450);
            // 
            // turchaninov_andrey_northbeeDataSet
            // 
            this.turchaninov_andrey_northbeeDataSet.DataSetName = "turchaninov_andrey_northbeeDataSet";
            this.turchaninov_andrey_northbeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.turchaninov_andrey_northbeeDataSet;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = null;
            this.tableAdapterManager.HistoryTableAdapter = this.historyTableAdapter;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NorthBee.Desktop.turchaninov_andrey_northbeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.AutoGenerateColumns = false;
            this.historyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn1,
            this.HotelName,
            this.checkInDataGridViewTextBoxColumn2,
            this.checkOutDataGridViewTextBoxColumn2,
            this.commentDataGridViewTextBoxColumn2});
            this.historyDataGridView.DataSource = this.historyBindingSource;
            this.historyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.ReadOnly = true;
            this.historyDataGridView.Size = new System.Drawing.Size(800, 366);
            this.historyDataGridView.TabIndex = 0;
            // 
            // checkInDataGridViewTextBoxColumn1
            // 
            this.checkInDataGridViewTextBoxColumn1.DataPropertyName = "CheckIn";
            this.checkInDataGridViewTextBoxColumn1.HeaderText = "Когда заселился";
            this.checkInDataGridViewTextBoxColumn1.Name = "checkInDataGridViewTextBoxColumn1";
            this.checkInDataGridViewTextBoxColumn1.Width = 151;
            // 
            // checkOutDataGridViewTextBoxColumn1
            // 
            this.checkOutDataGridViewTextBoxColumn1.DataPropertyName = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn1.HeaderText = "Когда уехал";
            this.checkOutDataGridViewTextBoxColumn1.Name = "checkOutDataGridViewTextBoxColumn1";
            this.checkOutDataGridViewTextBoxColumn1.Width = 152;
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            this.commentDataGridViewTextBoxColumn1.Width = 152;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            this.roomIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.roomIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roomIdDataGridViewTextBoxColumn.Width = 151;
            // 
            // hotelNameDataGridViewTextBoxColumn
            // 
            this.hotelNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.hotelNameDataGridViewTextBoxColumn.HeaderText = "Отель";
            this.hotelNameDataGridViewTextBoxColumn.Name = "hotelNameDataGridViewTextBoxColumn";
            this.hotelNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hotelNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hotelNameDataGridViewTextBoxColumn.Width = 151;
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            this.checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            this.checkInDataGridViewTextBoxColumn.HeaderText = "Когда заселился";
            this.checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            this.checkInDataGridViewTextBoxColumn.Width = 151;
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            this.checkOutDataGridViewTextBoxColumn.DataPropertyName = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn.HeaderText = "Когда выезжал";
            this.checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            this.checkOutDataGridViewTextBoxColumn.Width = 152;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 152;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoomId";
            this.dataGridViewTextBoxColumn3.DataSource = this.roomBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Number";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Комната";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IdRoom";
            this.dataGridViewTextBoxColumn3.Width = 189;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.turchaninov_andrey_northbeeDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CheckIn";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата бронирования";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 189;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CheckOut";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата окончания";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 189;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn6.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 190;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // roomIdDataGridViewTextBoxColumn1
            // 
            this.roomIdDataGridViewTextBoxColumn1.DataPropertyName = "RoomName";
            this.roomIdDataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.roomIdDataGridViewTextBoxColumn1.Name = "roomIdDataGridViewTextBoxColumn1";
            this.roomIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // HotelName
            // 
            this.HotelName.DataPropertyName = "HotelName";
            this.HotelName.HeaderText = "Отель";
            this.HotelName.Name = "HotelName";
            this.HotelName.ReadOnly = true;
            // 
            // checkInDataGridViewTextBoxColumn2
            // 
            this.checkInDataGridViewTextBoxColumn2.DataPropertyName = "CheckIn";
            this.checkInDataGridViewTextBoxColumn2.HeaderText = "Когда забронировал";
            this.checkInDataGridViewTextBoxColumn2.Name = "checkInDataGridViewTextBoxColumn2";
            this.checkInDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // checkOutDataGridViewTextBoxColumn2
            // 
            this.checkOutDataGridViewTextBoxColumn2.DataPropertyName = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn2.HeaderText = "Когда уехал";
            this.checkOutDataGridViewTextBoxColumn2.Name = "checkOutDataGridViewTextBoxColumn2";
            this.checkOutDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn2
            // 
            this.commentDataGridViewTextBoxColumn2.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn2.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn2.Name = "commentDataGridViewTextBoxColumn2";
            this.commentDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.splitContainerMainBackground.Panel1.ResumeLayout(false);
            this.splitContainerMainBackground.Panel1.PerformLayout();
            this.splitContainerMainBackground.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainBackground)).EndInit();
            this.splitContainerMainBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.turchaninov_andrey_northbeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private turchaninov_andrey_northbeeDataSet turchaninov_andrey_northbeeDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private turchaninov_andrey_northbeeDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private turchaninov_andrey_northbeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private turchaninov_andrey_northbeeDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private turchaninov_andrey_northbeeDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn hotelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn2;
    }
}

