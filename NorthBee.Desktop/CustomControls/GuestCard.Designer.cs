namespace NorthBee.Desktop.CustomControls
{
    partial class GuestCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelArriveCount = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonHistoryAccentBackground = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(23, 20);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(50, 20);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "ФИО";
            this.labelFullName.Click += new System.EventHandler(this.GuestCard_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(23, 40);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(37, 18);
            this.labelGender.TabIndex = 1;
            this.labelGender.Text = "Пол";
            this.labelGender.Click += new System.EventHandler(this.GuestCard_Click);
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDay.Location = new System.Drawing.Point(23, 58);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(116, 18);
            this.labelBirthDay.TabIndex = 2;
            this.labelBirthDay.Text = "Дата рождения";
            this.labelBirthDay.Click += new System.EventHandler(this.GuestCard_Click);
            // 
            // labelArriveCount
            // 
            this.labelArriveCount.AutoSize = true;
            this.labelArriveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArriveCount.Location = new System.Drawing.Point(24, 112);
            this.labelArriveCount.Name = "labelArriveCount";
            this.labelArriveCount.Size = new System.Drawing.Size(216, 18);
            this.labelArriveCount.TabIndex = 3;
            this.labelArriveCount.Text = "Сколько раз останавливался";
            this.labelArriveCount.Click += new System.EventHandler(this.GuestCard_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(327, 20);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 18);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Статус";
            this.labelStatus.Click += new System.EventHandler(this.GuestCard_Click);
            // 
            // buttonHistoryAccentBackground
            // 
            this.buttonHistoryAccentBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHistoryAccentBackground.Location = new System.Drawing.Point(571, 101);
            this.buttonHistoryAccentBackground.Name = "buttonHistoryAccentBackground";
            this.buttonHistoryAccentBackground.Size = new System.Drawing.Size(131, 26);
            this.buttonHistoryAccentBackground.TabIndex = 5;
            this.buttonHistoryAccentBackground.Text = "История";
            this.buttonHistoryAccentBackground.UseVisualStyleBackColor = true;
            this.buttonHistoryAccentBackground.Click += new System.EventHandler(this.buttonHistoryAccentBackground_Click);
            // 
            // GuestCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHistoryAccentBackground);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelArriveCount);
            this.Controls.Add(this.labelBirthDay);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelFullName);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Name = "GuestCard";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(725, 150);
            this.Click += new System.EventHandler(this.GuestCard_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GuestCard_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelArriveCount;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonHistoryAccentBackground;
    }
}
