namespace salon_interface
{
    partial class ServicesPage
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
            this.HeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.CoefficientsLabel = new System.Windows.Forms.Label();
            this.VisitsLabel = new System.Windows.Forms.Label();
            this.MastersLabel = new System.Windows.Forms.Label();
            this.ServicesLabel = new System.Windows.Forms.Label();
            this.PanelTitleServices = new System.Windows.Forms.Panel();
            this.TitleServices = new System.Windows.Forms.Label();
            this.PanelServicesList = new System.Windows.Forms.Panel();
            this.PanelListServices = new System.Windows.Forms.Panel();
            this.PanelService = new Guna.UI2.WinForms.Guna2Panel();
            this.PriceService = new System.Windows.Forms.Label();
            this.NameService = new System.Windows.Forms.Label();
            this.HeaderTable.SuspendLayout();
            this.PanelTitleServices.SuspendLayout();
            this.PanelServicesList.SuspendLayout();
            this.PanelListServices.SuspendLayout();
            this.PanelService.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderTable
            // 
            this.HeaderTable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HeaderTable.ColumnCount = 4;
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderTable.Controls.Add(this.CoefficientsLabel, 3, 0);
            this.HeaderTable.Controls.Add(this.VisitsLabel, 2, 0);
            this.HeaderTable.Controls.Add(this.MastersLabel, 1, 0);
            this.HeaderTable.Controls.Add(this.ServicesLabel, 0, 0);
            this.HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderTable.Location = new System.Drawing.Point(0, 0);
            this.HeaderTable.Name = "HeaderTable";
            this.HeaderTable.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.HeaderTable.RowCount = 1;
            this.HeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderTable.Size = new System.Drawing.Size(982, 59);
            this.HeaderTable.TabIndex = 0;
            // 
            // CoefficientsLabel
            // 
            this.CoefficientsLabel.AutoSize = true;
            this.CoefficientsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoefficientsLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoefficientsLabel.Location = new System.Drawing.Point(688, 0);
            this.CoefficientsLabel.Name = "CoefficientsLabel";
            this.CoefficientsLabel.Size = new System.Drawing.Size(191, 59);
            this.CoefficientsLabel.TabIndex = 3;
            this.CoefficientsLabel.Text = "Коэффициенты";
            this.CoefficientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisitsLabel
            // 
            this.VisitsLabel.AutoSize = true;
            this.VisitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisitsLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitsLabel.Location = new System.Drawing.Point(493, 0);
            this.VisitsLabel.Name = "VisitsLabel";
            this.VisitsLabel.Size = new System.Drawing.Size(189, 59);
            this.VisitsLabel.TabIndex = 2;
            this.VisitsLabel.Text = "Визиты";
            this.VisitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MastersLabel
            // 
            this.MastersLabel.AutoSize = true;
            this.MastersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MastersLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MastersLabel.Location = new System.Drawing.Point(298, 0);
            this.MastersLabel.Name = "MastersLabel";
            this.MastersLabel.Size = new System.Drawing.Size(189, 59);
            this.MastersLabel.TabIndex = 1;
            this.MastersLabel.Text = "Мастера";
            this.MastersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MastersLabel.Click += new System.EventHandler(this.PanelService_Click);
            // 
            // ServicesLabel
            // 
            this.ServicesLabel.AutoSize = true;
            this.ServicesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicesLabel.Location = new System.Drawing.Point(103, 0);
            this.ServicesLabel.Name = "ServicesLabel";
            this.ServicesLabel.Size = new System.Drawing.Size(189, 59);
            this.ServicesLabel.TabIndex = 0;
            this.ServicesLabel.Text = "Услуги";
            this.ServicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ServicesLabel.Click += new System.EventHandler(this.ServicesLabel_Click);
            // 
            // PanelTitleServices
            // 
            this.PanelTitleServices.Controls.Add(this.TitleServices);
            this.PanelTitleServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleServices.Location = new System.Drawing.Point(0, 59);
            this.PanelTitleServices.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.PanelTitleServices.Name = "PanelTitleServices";
            this.PanelTitleServices.Size = new System.Drawing.Size(982, 50);
            this.PanelTitleServices.TabIndex = 1;
            // 
            // TitleServices
            // 
            this.TitleServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleServices.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.TitleServices.Location = new System.Drawing.Point(0, 0);
            this.TitleServices.Name = "TitleServices";
            this.TitleServices.Size = new System.Drawing.Size(982, 50);
            this.TitleServices.TabIndex = 0;
            this.TitleServices.Text = "Список услуг";
            this.TitleServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelServicesList
            // 
            this.PanelServicesList.Controls.Add(this.PanelListServices);
            this.PanelServicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelServicesList.Location = new System.Drawing.Point(0, 109);
            this.PanelServicesList.Name = "PanelServicesList";
            this.PanelServicesList.Padding = new System.Windows.Forms.Padding(150, 15, 150, 10);
            this.PanelServicesList.Size = new System.Drawing.Size(982, 444);
            this.PanelServicesList.TabIndex = 3;
            // 
            // PanelListServices
            // 
            this.PanelListServices.AutoScroll = true;
            this.PanelListServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelListServices.Controls.Add(this.PanelService);
            this.PanelListServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListServices.Location = new System.Drawing.Point(150, 15);
            this.PanelListServices.Name = "PanelListServices";
            this.PanelListServices.Size = new System.Drawing.Size(682, 419);
            this.PanelListServices.TabIndex = 5;
            // 
            // PanelService
            // 
            this.PanelService.AutoRoundedCorners = true;
            this.PanelService.BackColor = System.Drawing.Color.Transparent;
            this.PanelService.BorderColor = System.Drawing.Color.Transparent;
            this.PanelService.BorderRadius = 18;
            this.PanelService.BorderThickness = 1;
            this.PanelService.Controls.Add(this.PriceService);
            this.PanelService.Controls.Add(this.NameService);
            this.PanelService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelService.CustomBorderColor = System.Drawing.Color.Transparent;
            this.PanelService.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelService.FillColor = System.Drawing.Color.LightGray;
            this.PanelService.Location = new System.Drawing.Point(0, 0);
            this.PanelService.Margin = new System.Windows.Forms.Padding(4);
            this.PanelService.Name = "PanelService";
            this.PanelService.Size = new System.Drawing.Size(680, 39);
            this.PanelService.TabIndex = 0;
            this.PanelService.Click += new System.EventHandler(this.PanelService_Click);
            this.PanelService.MouseEnter += new System.EventHandler(this.PanelService_MouseEnter);
            this.PanelService.MouseLeave += new System.EventHandler(this.PanelService_MouseLeave);
            // 
            // PriceService
            // 
            this.PriceService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PriceService.Dock = System.Windows.Forms.DockStyle.Right;
            this.PriceService.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PriceService.Location = new System.Drawing.Point(592, 0);
            this.PriceService.Name = "PriceService";
            this.PriceService.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.PriceService.Size = new System.Drawing.Size(88, 39);
            this.PriceService.TabIndex = 1;
            this.PriceService.Text = "10.0";
            this.PriceService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PriceService.Click += new System.EventHandler(this.PanelService_Click);
            this.PriceService.MouseEnter += new System.EventHandler(this.PanelService_MouseEnter);
            this.PriceService.MouseLeave += new System.EventHandler(this.PanelService_MouseLeave);
            // 
            // NameService
            // 
            this.NameService.BackColor = System.Drawing.Color.Transparent;
            this.NameService.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameService.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NameService.Location = new System.Drawing.Point(0, 0);
            this.NameService.Name = "NameService";
            this.NameService.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.NameService.Size = new System.Drawing.Size(564, 39);
            this.NameService.TabIndex = 0;
            this.NameService.Text = "Маникюр";
            this.NameService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameService.Click += new System.EventHandler(this.PanelService_Click);
            this.NameService.MouseEnter += new System.EventHandler(this.PanelService_MouseEnter);
            this.NameService.MouseLeave += new System.EventHandler(this.PanelService_MouseLeave);
            // 
            // ServicesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.PanelServicesList);
            this.Controls.Add(this.PanelTitleServices);
            this.Controls.Add(this.HeaderTable);
            this.Name = "ServicesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beauty Salon";
            this.HeaderTable.ResumeLayout(false);
            this.HeaderTable.PerformLayout();
            this.PanelTitleServices.ResumeLayout(false);
            this.PanelServicesList.ResumeLayout(false);
            this.PanelListServices.ResumeLayout(false);
            this.PanelService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        private System.Windows.Forms.Label ServicesLabel;
        private System.Windows.Forms.Label MastersLabel;
        private System.Windows.Forms.Label CoefficientsLabel;
        private System.Windows.Forms.Label VisitsLabel;
        private System.Windows.Forms.Panel PanelTitleServices;
        private System.Windows.Forms.Label TitleServices;
        private System.Windows.Forms.Panel PanelServicesList;
        private System.Windows.Forms.Panel PanelListServices;
        private Guna.UI2.WinForms.Guna2Panel PanelService;
        private System.Windows.Forms.Label PriceService;
        private System.Windows.Forms.Label NameService;
    }
}

