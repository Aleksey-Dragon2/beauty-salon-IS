namespace salon_interface
{
    partial class DoneVisitPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientName = new System.Windows.Forms.Label();
            this.VisitDate = new System.Windows.Forms.Label();
            this.DoneVisitButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientName
            // 
            this.ClientName.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientName.Location = new System.Drawing.Point(0, 0);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(584, 39);
            this.ClientName.TabIndex = 0;
            this.ClientName.Text = "Имя клиента";
            this.ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisitDate
            // 
            this.VisitDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.VisitDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitDate.Location = new System.Drawing.Point(0, 39);
            this.VisitDate.Name = "VisitDate";
            this.VisitDate.Size = new System.Drawing.Size(584, 39);
            this.VisitDate.TabIndex = 1;
            this.VisitDate.Text = "Дата визита:";
            this.VisitDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoneVisitButton
            // 
            this.DoneVisitButton.BorderRadius = 8;
            this.DoneVisitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DoneVisitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DoneVisitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DoneVisitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DoneVisitButton.FillColor = System.Drawing.Color.LightGray;
            this.DoneVisitButton.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.DoneVisitButton.ForeColor = System.Drawing.Color.Black;
            this.DoneVisitButton.Location = new System.Drawing.Point(176, 370);
            this.DoneVisitButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.DoneVisitButton.Name = "DoneVisitButton";
            this.DoneVisitButton.Size = new System.Drawing.Size(220, 43);
            this.DoneVisitButton.TabIndex = 7;
            this.DoneVisitButton.Text = "Выдать чек";
            this.DoneVisitButton.Click += new System.EventHandler(this.DoneVisitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.totalPriceLabel);
            this.panel1.Location = new System.Drawing.Point(42, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 240);
            this.panel1.TabIndex = 8;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.totalPriceLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceLabel.Location = new System.Drawing.Point(0, 211);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(493, 27);
            this.totalPriceLabel.TabIndex = 0;
            this.totalPriceLabel.Text = "Общая стоимость:";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DoneVisitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DoneVisitButton);
            this.Controls.Add(this.VisitDate);
            this.Controls.Add(this.ClientName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DoneVisitPage";
            this.Text = "DoneVisitPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label VisitDate;
        private Guna.UI2.WinForms.Guna2Button DoneVisitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}