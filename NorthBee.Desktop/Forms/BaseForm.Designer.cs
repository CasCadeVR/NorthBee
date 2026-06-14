namespace NorthBee.Desktop.Forms
{
    partial class BaseForm
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
            this.splitContainerMainBackground = new System.Windows.Forms.SplitContainer();
            this.buttonActionAccentBackground = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainBackground)).BeginInit();
            this.splitContainerMainBackground.Panel1.SuspendLayout();
            this.splitContainerMainBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMainBackground
            // 
            this.splitContainerMainBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainBackground.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMainBackground.IsSplitterFixed = true;
            this.splitContainerMainBackground.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMainBackground.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerMainBackground.Name = "splitContainerMainBackground";
            this.splitContainerMainBackground.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMainBackground.Panel1
            // 
            this.splitContainerMainBackground.Panel1.Controls.Add(this.buttonActionAccentBackground);
            this.splitContainerMainBackground.Panel1.Controls.Add(this.titleLabel);
            this.splitContainerMainBackground.Panel1.Controls.Add(this.logoPicture);
            this.splitContainerMainBackground.Size = new System.Drawing.Size(784, 561);
            this.splitContainerMainBackground.SplitterDistance = 80;
            this.splitContainerMainBackground.TabIndex = 0;
            // 
            // buttonActionAccentBackground
            // 
            this.buttonActionAccentBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonActionAccentBackground.Location = new System.Drawing.Point(83, 38);
            this.buttonActionAccentBackground.Name = "buttonActionAccentBackground";
            this.buttonActionAccentBackground.Size = new System.Drawing.Size(173, 23);
            this.buttonActionAccentBackground.TabIndex = 2;
            this.buttonActionAccentBackground.Text = "Действие";
            this.buttonActionAccentBackground.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(79, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(177, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Название страницы";
            // 
            // logoPicture
            // 
            this.logoPicture.Image = global::NorthBee.Desktop.Properties.Resources.bee;
            this.logoPicture.Location = new System.Drawing.Point(12, 12);
            this.logoPicture.Margin = new System.Windows.Forms.Padding(0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(50, 50);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainerMainBackground);
            this.MinimumSize = new System.Drawing.Size(375, 316);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.splitContainerMainBackground.Panel1.ResumeLayout(false);
            this.splitContainerMainBackground.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainBackground)).EndInit();
            this.splitContainerMainBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logoPicture;
        protected System.Windows.Forms.Label titleLabel;
        protected System.Windows.Forms.Button buttonActionAccentBackground;
        protected System.Windows.Forms.SplitContainer splitContainerMainBackground;
    }
}

