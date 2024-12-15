namespace salon_interface
{
    partial class MasterData
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
            this.MasterName = new System.Windows.Forms.Label();
            this.Specialization = new System.Windows.Forms.Label();
            this.ServicesProvided = new System.Windows.Forms.Label();
            this.PopularService = new System.Windows.Forms.Label();
            this.AveragePriceServices = new System.Windows.Forms.Label();
            this.DeleteMasterButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddServiceMasterButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // MasterName
            // 
            this.MasterName.Dock = System.Windows.Forms.DockStyle.Top;
            this.MasterName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasterName.Location = new System.Drawing.Point(0, 0);
            this.MasterName.Name = "MasterName";
            this.MasterName.Size = new System.Drawing.Size(547, 37);
            this.MasterName.TabIndex = 0;
            this.MasterName.Text = "Имя мастера";
            this.MasterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Specialization
            // 
            this.Specialization.Dock = System.Windows.Forms.DockStyle.Top;
            this.Specialization.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Specialization.Location = new System.Drawing.Point(0, 37);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(547, 37);
            this.Specialization.TabIndex = 1;
            this.Specialization.Text = "Специализация: ";
            this.Specialization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesProvided
            // 
            this.ServicesProvided.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServicesProvided.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicesProvided.Location = new System.Drawing.Point(0, 74);
            this.ServicesProvided.Name = "ServicesProvided";
            this.ServicesProvided.Size = new System.Drawing.Size(547, 37);
            this.ServicesProvided.TabIndex = 2;
            this.ServicesProvided.Text = "Услуг оказано: ";
            this.ServicesProvided.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopularService
            // 
            this.PopularService.Dock = System.Windows.Forms.DockStyle.Top;
            this.PopularService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopularService.Location = new System.Drawing.Point(0, 111);
            this.PopularService.Name = "PopularService";
            this.PopularService.Size = new System.Drawing.Size(547, 37);
            this.PopularService.TabIndex = 3;
            this.PopularService.Text = "Популярная услуга: ";
            this.PopularService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AveragePriceServices
            // 
            this.AveragePriceServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.AveragePriceServices.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AveragePriceServices.Location = new System.Drawing.Point(0, 148);
            this.AveragePriceServices.Name = "AveragePriceServices";
            this.AveragePriceServices.Size = new System.Drawing.Size(547, 37);
            this.AveragePriceServices.TabIndex = 4;
            this.AveragePriceServices.Text = "Средняя стоимость услуг: ";
            this.AveragePriceServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteMasterButton
            // 
            this.DeleteMasterButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteMasterButton.BorderRadius = 8;
            this.DeleteMasterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMasterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteMasterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteMasterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteMasterButton.FillColor = System.Drawing.Color.LightGray;
            this.DeleteMasterButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DeleteMasterButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteMasterButton.Location = new System.Drawing.Point(30, 275);
            this.DeleteMasterButton.Name = "DeleteMasterButton";
            this.DeleteMasterButton.Size = new System.Drawing.Size(215, 45);
            this.DeleteMasterButton.TabIndex = 6;
            this.DeleteMasterButton.Text = "Удалить мастера";
            this.DeleteMasterButton.Click += new System.EventHandler(this.DeleteMasterButton_Click);
            // 
            // AddServiceMasterButton
            // 
            this.AddServiceMasterButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddServiceMasterButton.BorderRadius = 8;
            this.AddServiceMasterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddServiceMasterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddServiceMasterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddServiceMasterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddServiceMasterButton.FillColor = System.Drawing.Color.LightGray;
            this.AddServiceMasterButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AddServiceMasterButton.ForeColor = System.Drawing.Color.Black;
            this.AddServiceMasterButton.Location = new System.Drawing.Point(297, 275);
            this.AddServiceMasterButton.Name = "AddServiceMasterButton";
            this.AddServiceMasterButton.Size = new System.Drawing.Size(217, 45);
            this.AddServiceMasterButton.TabIndex = 7;
            this.AddServiceMasterButton.Text = "Добавить услугу";
            this.AddServiceMasterButton.Click += new System.EventHandler(this.AddServiceMasterButton_Click);
            // 
            // MasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 359);
            this.Controls.Add(this.AddServiceMasterButton);
            this.Controls.Add(this.DeleteMasterButton);
            this.Controls.Add(this.AveragePriceServices);
            this.Controls.Add(this.PopularService);
            this.Controls.Add(this.ServicesProvided);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.MasterName);
            this.Name = "MasterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MasterData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MasterName;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.Label ServicesProvided;
        private System.Windows.Forms.Label PopularService;
        private System.Windows.Forms.Label AveragePriceServices;
        private Guna.UI2.WinForms.Guna2Button DeleteMasterButton;
        private Guna.UI2.WinForms.Guna2Button AddServiceMasterButton;
    }
}