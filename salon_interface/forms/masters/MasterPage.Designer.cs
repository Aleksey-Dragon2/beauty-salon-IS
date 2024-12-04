namespace salon_interface
{
    partial class MasterPage
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
            this.HeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.CoefficientsLabel = new System.Windows.Forms.Label();
            this.VisitsLabel = new System.Windows.Forms.Label();
            this.MastersLabel = new System.Windows.Forms.Label();
            this.ServicesLabel = new System.Windows.Forms.Label();
            this.TitleMasters = new System.Windows.Forms.Label();
            this.FilterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateMaster = new Guna.UI2.WinForms.Guna2Button();
            this.filterAll = new salon_interface.MasterFilterItem();
            this.HeaderTable.SuspendLayout();
            this.FilterPanel.SuspendLayout();
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
            this.HeaderTable.TabIndex = 1;
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
            this.MastersLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MastersLabel.Location = new System.Drawing.Point(345, 0);
            this.MastersLabel.Name = "MastersLabel";
            this.MastersLabel.Size = new System.Drawing.Size(236, 59);
            this.MastersLabel.TabIndex = 1;
            this.MastersLabel.Text = "Мастера";
            this.MastersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MastersLabel.Click += new System.EventHandler(this.MastersLabel_Click);
            // 
            // ServicesLabel
            // 
            this.ServicesLabel.AutoSize = true;
            this.ServicesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicesLabel.Location = new System.Drawing.Point(103, 0);
            this.ServicesLabel.Name = "ServicesLabel";
            this.ServicesLabel.Size = new System.Drawing.Size(236, 59);
            this.ServicesLabel.TabIndex = 0;
            this.ServicesLabel.Text = "Услуги";
            this.ServicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleMasters
            // 
            this.TitleMasters.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleMasters.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.TitleMasters.Location = new System.Drawing.Point(0, 59);
            this.TitleMasters.Name = "TitleMasters";
            this.TitleMasters.Size = new System.Drawing.Size(1169, 50);
            this.TitleMasters.TabIndex = 2;
            this.TitleMasters.Text = "Список мастеров";
            this.TitleMasters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterPanel.Controls.Add(this.filterAll);
            this.FilterPanel.Location = new System.Drawing.Point(108, 112);
            this.FilterPanel.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(939, 98);
            this.FilterPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 235);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(939, 347);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // CreateMaster
            // 
            this.CreateMaster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateMaster.BorderRadius = 8;
            this.CreateMaster.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateMaster.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateMaster.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateMaster.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateMaster.FillColor = System.Drawing.Color.LightGray;
            this.CreateMaster.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateMaster.ForeColor = System.Drawing.Color.Black;
            this.CreateMaster.Location = new System.Drawing.Point(410, 610);
            this.CreateMaster.Name = "CreateMaster";
            this.CreateMaster.Size = new System.Drawing.Size(269, 45);
            this.CreateMaster.TabIndex = 5;
            this.CreateMaster.Text = "Добавить услугу";
            // 
            // filterAll
            // 
            this.filterAll.Location = new System.Drawing.Point(3, 3);
            this.filterAll.Name = "filterAll";
            this.filterAll.Size = new System.Drawing.Size(104, 42);
            this.filterAll.TabIndex = 0;
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 667);
            this.Controls.Add(this.CreateMaster);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TitleMasters);
            this.Controls.Add(this.HeaderTable);
            this.Name = "MasterPage";
            this.Text = "MasterPage";
            this.HeaderTable.ResumeLayout(false);
            this.HeaderTable.PerformLayout();
            this.FilterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        private System.Windows.Forms.Label CoefficientsLabel;
        private System.Windows.Forms.Label VisitsLabel;
        private System.Windows.Forms.Label MastersLabel;
        private System.Windows.Forms.Label ServicesLabel;
        private System.Windows.Forms.Label TitleMasters;
        private System.Windows.Forms.FlowLayoutPanel FilterPanel;
        private MasterFilterItem filterAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button CreateMaster;
    }
}