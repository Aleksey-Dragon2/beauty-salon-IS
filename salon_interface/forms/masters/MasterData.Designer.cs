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
            this.MostPopular = new System.Windows.Forms.Label();
            this.AcceptEditButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // MasterName
            // 
            this.MasterName.Dock = System.Windows.Forms.DockStyle.Top;
            this.MasterName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasterName.Location = new System.Drawing.Point(0, 0);
            this.MasterName.Name = "MasterName";
            this.MasterName.Size = new System.Drawing.Size(513, 37);
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
            this.Specialization.Size = new System.Drawing.Size(513, 37);
            this.Specialization.TabIndex = 1;
            this.Specialization.Text = "Специализация";
            this.Specialization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesProvided
            // 
            this.ServicesProvided.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServicesProvided.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicesProvided.Location = new System.Drawing.Point(0, 74);
            this.ServicesProvided.Name = "ServicesProvided";
            this.ServicesProvided.Size = new System.Drawing.Size(513, 37);
            this.ServicesProvided.TabIndex = 2;
            this.ServicesProvided.Text = "Услуг оказано";
            this.ServicesProvided.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopularService
            // 
            this.PopularService.Dock = System.Windows.Forms.DockStyle.Top;
            this.PopularService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopularService.Location = new System.Drawing.Point(0, 111);
            this.PopularService.Name = "PopularService";
            this.PopularService.Size = new System.Drawing.Size(513, 37);
            this.PopularService.TabIndex = 3;
            this.PopularService.Text = "Популярная услуга:";
            this.PopularService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AveragePriceServices
            // 
            this.AveragePriceServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.AveragePriceServices.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AveragePriceServices.Location = new System.Drawing.Point(0, 148);
            this.AveragePriceServices.Name = "AveragePriceServices";
            this.AveragePriceServices.Size = new System.Drawing.Size(513, 37);
            this.AveragePriceServices.TabIndex = 4;
            this.AveragePriceServices.Text = "Средняя стоимость услуг:";
            this.AveragePriceServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MostPopular
            // 
            this.MostPopular.Dock = System.Windows.Forms.DockStyle.Top;
            this.MostPopular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MostPopular.Location = new System.Drawing.Point(0, 185);
            this.MostPopular.Name = "MostPopular";
            this.MostPopular.Size = new System.Drawing.Size(513, 37);
            this.MostPopular.TabIndex = 5;
            this.MostPopular.Text = "Самый популярный x раз за год";
            this.MostPopular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcceptEditButton
            // 
            this.AcceptEditButton.BorderRadius = 8;
            this.AcceptEditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AcceptEditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AcceptEditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptEditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AcceptEditButton.FillColor = System.Drawing.Color.LightGray;
            this.AcceptEditButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AcceptEditButton.ForeColor = System.Drawing.Color.Black;
            this.AcceptEditButton.Location = new System.Drawing.Point(39, 275);
            this.AcceptEditButton.Name = "AcceptEditButton";
            this.AcceptEditButton.Size = new System.Drawing.Size(180, 45);
            this.AcceptEditButton.TabIndex = 6;
            this.AcceptEditButton.Text = "Удалить мастера";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(306, 275);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Добавить услугу";
            // 
            // MasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 359);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.AcceptEditButton);
            this.Controls.Add(this.MostPopular);
            this.Controls.Add(this.AveragePriceServices);
            this.Controls.Add(this.PopularService);
            this.Controls.Add(this.ServicesProvided);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.MasterName);
            this.Name = "MasterData";
            this.Text = "MasterData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MasterName;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.Label ServicesProvided;
        private System.Windows.Forms.Label PopularService;
        private System.Windows.Forms.Label AveragePriceServices;
        private System.Windows.Forms.Label MostPopular;
        private Guna.UI2.WinForms.Guna2Button AcceptEditButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}