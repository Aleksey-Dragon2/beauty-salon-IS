namespace salon_interface
{
    partial class ServiceDeletePage
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NameServiceLabel = new System.Windows.Forms.Label();
            this.CantCancelLabel = new System.Windows.Forms.Label();
            this.AcceptDeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeniedDeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(800, 54);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Вы собираетесь удалить услугу:";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameServiceLabel
            // 
            this.NameServiceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameServiceLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameServiceLabel.Location = new System.Drawing.Point(0, 54);
            this.NameServiceLabel.Name = "NameServiceLabel";
            this.NameServiceLabel.Size = new System.Drawing.Size(800, 48);
            this.NameServiceLabel.TabIndex = 1;
            this.NameServiceLabel.Text = "\"Название услуги\"";
            this.NameServiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CantCancelLabel
            // 
            this.CantCancelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CantCancelLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CantCancelLabel.ForeColor = System.Drawing.Color.Red;
            this.CantCancelLabel.Location = new System.Drawing.Point(0, 102);
            this.CantCancelLabel.Name = "CantCancelLabel";
            this.CantCancelLabel.Size = new System.Drawing.Size(800, 23);
            this.CantCancelLabel.TabIndex = 2;
            this.CantCancelLabel.Text = "Это действие нельзя будет отменить!";
            this.CantCancelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AcceptDeleteButton
            // 
            this.AcceptDeleteButton.BorderRadius = 8;
            this.AcceptDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AcceptDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AcceptDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AcceptDeleteButton.FillColor = System.Drawing.Color.LightGray;
            this.AcceptDeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AcceptDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.AcceptDeleteButton.Location = new System.Drawing.Point(536, 145);
            this.AcceptDeleteButton.Name = "AcceptDeleteButton";
            this.AcceptDeleteButton.Size = new System.Drawing.Size(180, 45);
            this.AcceptDeleteButton.TabIndex = 4;
            this.AcceptDeleteButton.Text = "Удалить";
            this.AcceptDeleteButton.Click += new System.EventHandler(this.AcceptDeleteButton_Click);
            // 
            // DeniedDeleteButton
            // 
            this.DeniedDeleteButton.BorderRadius = 8;
            this.DeniedDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeniedDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeniedDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeniedDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeniedDeleteButton.FillColor = System.Drawing.Color.LightGray;
            this.DeniedDeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DeniedDeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeniedDeleteButton.Location = new System.Drawing.Point(121, 145);
            this.DeniedDeleteButton.Name = "DeniedDeleteButton";
            this.DeniedDeleteButton.Size = new System.Drawing.Size(180, 45);
            this.DeniedDeleteButton.TabIndex = 5;
            this.DeniedDeleteButton.Text = "Отменить";
            this.DeniedDeleteButton.Click += new System.EventHandler(this.DeniedDeleteButton_Click);
            // 
            // ServiceDeletePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 256);
            this.ControlBox = false;
            this.Controls.Add(this.DeniedDeleteButton);
            this.Controls.Add(this.AcceptDeleteButton);
            this.Controls.Add(this.CantCancelLabel);
            this.Controls.Add(this.NameServiceLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServiceDeletePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ServiceDeletePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NameServiceLabel;
        private System.Windows.Forms.Label CantCancelLabel;
        private Guna.UI2.WinForms.Guna2Button AcceptDeleteButton;
        private Guna.UI2.WinForms.Guna2Button DeniedDeleteButton;
    }
}