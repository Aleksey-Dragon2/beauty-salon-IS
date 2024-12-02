using MyWindowsFormsApp.Models;
using ProjectName.api;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
        public async void updateService()
        {
            for (int i = PanelListServices.Controls.Count - 1; i >= 0; i--)
            {
                Control control = PanelListServices.Controls[i];
                PanelListServices.Controls.Remove(control);
            }


            List<Service> services = await ServiceApiHandler.GetServicesAsync();
            foreach (Service service in services)
            {
                ServiceInfoPanel servicePanel = new ServiceInfoPanel(service.Id.ToString(), this);
                servicePanel.NameService.Text = service.Name;
                servicePanel.PriceService.Text = service.Price.ToString();

                Panel tehnicalPanel = new Panel();
                tehnicalPanel.Dock= DockStyle.Top;
                tehnicalPanel.Size = new System.Drawing.Size(10, 8);

                PanelListServices.Controls.Add(servicePanel.PanelService);
                PanelListServices.Controls.Add(tehnicalPanel);

            }

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
            this.PanelButton = new System.Windows.Forms.Panel();
            this.AcceptEditButton = new Guna.UI2.WinForms.Guna2Button();
            this.PanelListServices = new System.Windows.Forms.Panel();
            this.PanelService = new Guna.UI2.WinForms.Guna2Panel();
            this.PriceService = new System.Windows.Forms.Label();
            this.NameService = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeaderTable.SuspendLayout();
            this.PanelTitleServices.SuspendLayout();
            this.PanelServicesList.SuspendLayout();
            this.PanelButton.SuspendLayout();
            this.PanelListServices.SuspendLayout();
            this.PanelService.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            this.HeaderTable.Size = new System.Drawing.Size(1169, 59);
            this.HeaderTable.TabIndex = 0;
            // 
            // CoefficientsLabel
            // 
            this.CoefficientsLabel.AutoSize = true;
            this.CoefficientsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoefficientsLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoefficientsLabel.Location = new System.Drawing.Point(829, 0);
            this.CoefficientsLabel.Name = "CoefficientsLabel";
            this.CoefficientsLabel.Size = new System.Drawing.Size(237, 59);
            this.CoefficientsLabel.TabIndex = 3;
            this.CoefficientsLabel.Text = "Коэффициенты";
            this.CoefficientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisitsLabel
            // 
            this.VisitsLabel.AutoSize = true;
            this.VisitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisitsLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitsLabel.Location = new System.Drawing.Point(587, 0);
            this.VisitsLabel.Name = "VisitsLabel";
            this.VisitsLabel.Size = new System.Drawing.Size(236, 59);
            this.VisitsLabel.TabIndex = 2;
            this.VisitsLabel.Text = "Визиты";
            this.VisitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MastersLabel
            // 
            this.MastersLabel.AutoSize = true;
            this.MastersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MastersLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MastersLabel.Location = new System.Drawing.Point(345, 0);
            this.MastersLabel.Name = "MastersLabel";
            this.MastersLabel.Size = new System.Drawing.Size(236, 59);
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
            this.ServicesLabel.Size = new System.Drawing.Size(236, 59);
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
            this.PanelTitleServices.Size = new System.Drawing.Size(1169, 50);
            this.PanelTitleServices.TabIndex = 1;
            // 
            // TitleServices
            // 
            this.TitleServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleServices.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.TitleServices.Location = new System.Drawing.Point(0, 0);
            this.TitleServices.Name = "TitleServices";
            this.TitleServices.Size = new System.Drawing.Size(1169, 50);
            this.TitleServices.TabIndex = 0;
            this.TitleServices.Text = "Список услуг";
            this.TitleServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelServicesList
            // 
            this.PanelServicesList.Controls.Add(this.PanelButton);
            this.PanelServicesList.Controls.Add(this.PanelListServices);
            this.PanelServicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelServicesList.Location = new System.Drawing.Point(0, 109);
            this.PanelServicesList.Name = "PanelServicesList";
            this.PanelServicesList.Padding = new System.Windows.Forms.Padding(150, 15, 150, 10);
            this.PanelServicesList.Size = new System.Drawing.Size(1169, 558);
            this.PanelServicesList.TabIndex = 3;
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.AcceptEditButton);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButton.Location = new System.Drawing.Point(150, 438);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(869, 110);
            this.PanelButton.TabIndex = 1;
            // 
            // AcceptEditButton
            // 
            this.AcceptEditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AcceptEditButton.BorderRadius = 8;
            this.AcceptEditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AcceptEditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AcceptEditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptEditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AcceptEditButton.FillColor = System.Drawing.Color.LightGray;
            this.AcceptEditButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptEditButton.ForeColor = System.Drawing.Color.Black;
            this.AcceptEditButton.Location = new System.Drawing.Point(296, 33);
            this.AcceptEditButton.Name = "AcceptEditButton";
            this.AcceptEditButton.Size = new System.Drawing.Size(269, 45);
            this.AcceptEditButton.TabIndex = 4;
            this.AcceptEditButton.Text = "Добавить услугу";
            this.AcceptEditButton.Click += new System.EventHandler(this.AcceptEditButton_Click);
            // 
            // PanelListServices
            // 
            this.PanelListServices.AutoScroll = true;
            this.PanelListServices.Controls.Add(this.guna2Panel1);
            this.PanelListServices.Controls.Add(this.PanelService);
            this.PanelListServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListServices.Location = new System.Drawing.Point(150, 15);
            this.PanelListServices.Name = "PanelListServices";
            this.PanelListServices.Size = new System.Drawing.Size(869, 533);
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
            this.PanelService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 50);
            this.PanelService.Name = "PanelService";
            this.PanelService.Size = new System.Drawing.Size(869, 39);
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
            this.PriceService.Location = new System.Drawing.Point(781, 0);
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
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 18;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 39);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 50);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(869, 39);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(781, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "10.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(564, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Маникюр";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServicesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 667);
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
            this.PanelButton.ResumeLayout(false);
            this.PanelListServices.ResumeLayout(false);
            this.PanelService.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Panel PanelService;
        private System.Windows.Forms.Label PriceService;
        private System.Windows.Forms.Label NameService;
        private Panel PanelButton;
        private Panel PanelListServices;
        private Guna.UI2.WinForms.Guna2Button AcceptEditButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Label label2;
    }
}

