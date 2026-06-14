namespace NorthBee.Desktop.Forms
{
    partial class MainForm
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainBackground)).BeginInit();
            this.splitContainerMainBackground.Panel1.SuspendLayout();
            this.splitContainerMainBackground.Panel2.SuspendLayout();
            this.splitContainerMainBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonActionAccentBackground
            // 
            this.buttonActionAccentBackground.Text = "Добавить гостя";
            this.buttonActionAccentBackground.Click += new System.EventHandler(this.buttonActionAccentBackground_Click);
            // 
            // splitContainerMainBackground
            // 
            // 
            // splitContainerMainBackground.Panel2
            // 
            this.splitContainerMainBackground.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainerMainBackground.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.splitContainerMainBackground.Size = new System.Drawing.Size(800, 450);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(20, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(760, 346);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.splitContainerMainBackground.Panel1.ResumeLayout(false);
            this.splitContainerMainBackground.Panel1.PerformLayout();
            this.splitContainerMainBackground.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainBackground)).EndInit();
            this.splitContainerMainBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}

