namespace salon_interface
{
    partial class PriceCoefficientPage
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.CoefficientValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateCoefficient = new Guna.UI2.WinForms.Guna2Button();
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.coefficientHistory1 = new salon_interface.CoefficientHistory();
            this.HeaderTable.SuspendLayout();
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
            this.HeaderTable.TabIndex = 2;
            // 
            // CoefficientsLabel
            // 
            this.CoefficientsLabel.AutoSize = true;
            this.CoefficientsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoefficientsLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.VisitsLabel.Click += new System.EventHandler(this.VisitsLabel_Click);
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
            this.ServicesLabel.Click += new System.EventHandler(this.ServicesLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(51, 77);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(634, 45);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Управление коэффициентами цен";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(53, 130);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(786, 31);
            this.Description.TabIndex = 4;
            this.Description.Text = "Установите коэффициенты для изменения цен на все услуги салона";
            // 
            // CoefficientValue
            // 
            this.CoefficientValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CoefficientValue.BorderRadius = 8;
            this.CoefficientValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CoefficientValue.DefaultText = "";
            this.CoefficientValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CoefficientValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CoefficientValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CoefficientValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CoefficientValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CoefficientValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CoefficientValue.ForeColor = System.Drawing.Color.Black;
            this.CoefficientValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CoefficientValue.Location = new System.Drawing.Point(62, 217);
            this.CoefficientValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoefficientValue.Name = "CoefficientValue";
            this.CoefficientValue.PasswordChar = '\0';
            this.CoefficientValue.PlaceholderText = "";
            this.CoefficientValue.SelectedText = "";
            this.CoefficientValue.Size = new System.Drawing.Size(289, 38);
            this.CoefficientValue.TabIndex = 5;
            this.CoefficientValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddServicePrice_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Значение коэффициента";
            // 
            // CreateCoefficient
            // 
            this.CreateCoefficient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateCoefficient.BorderRadius = 10;
            this.CreateCoefficient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateCoefficient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateCoefficient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateCoefficient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateCoefficient.FillColor = System.Drawing.Color.LightGray;
            this.CreateCoefficient.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.CreateCoefficient.ForeColor = System.Drawing.Color.Black;
            this.CreateCoefficient.Location = new System.Drawing.Point(390, 217);
            this.CreateCoefficient.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.CreateCoefficient.Name = "CreateCoefficient";
            this.CreateCoefficient.Size = new System.Drawing.Size(316, 38);
            this.CreateCoefficient.TabIndex = 9;
            this.CreateCoefficient.Text = "Добавить коэффициент";
            this.CreateCoefficient.Click += new System.EventHandler(this.CreateCoefficient_Click);
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HistoryPanel.Location = new System.Drawing.Point(61, 376);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(606, 250);
            this.HistoryPanel.TabIndex = 10;
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.HistoryLabel.Location = new System.Drawing.Point(81, 286);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(236, 23);
            this.HistoryLabel.TabIndex = 11;
            this.HistoryLabel.Text = "История коэффициентов";
            // 
            // coefficientHistory1
            // 
            this.coefficientHistory1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coefficientHistory1.BackColor = System.Drawing.SystemColors.Control;
            this.coefficientHistory1.Location = new System.Drawing.Point(59, 316);
            this.coefficientHistory1.Name = "coefficientHistory1";
            this.coefficientHistory1.Size = new System.Drawing.Size(608, 60);
            this.coefficientHistory1.TabIndex = 12;
            // 
            // PriceCoefficientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1169, 667);
            this.Controls.Add(this.coefficientHistory1);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.HistoryPanel);
            this.Controls.Add(this.CreateCoefficient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoefficientValue);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.HeaderTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PriceCoefficientPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PriceCoefficientPage";
            this.HeaderTable.ResumeLayout(false);
            this.HeaderTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        private System.Windows.Forms.Label CoefficientsLabel;
        private System.Windows.Forms.Label VisitsLabel;
        private System.Windows.Forms.Label MastersLabel;
        private System.Windows.Forms.Label ServicesLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Description;
        private Guna.UI2.WinForms.Guna2TextBox CoefficientValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button CreateCoefficient;
        private System.Windows.Forms.Panel HistoryPanel;
        private System.Windows.Forms.Label HistoryLabel;
        private CoefficientHistory coefficientHistory1;
    }
}