using System.Windows.Forms;

namespace salon_interface
{
    partial class VisitsPage
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

        private void loadFilters()
        {
            VisitFilterItem visitFilter = new VisitFilterItem("Все");
            visitFilter.Width = visitFilter.ItemText.Width + 20;
            visitFilter.ItemText.AutoSize = false;
            visitFilter.ItemText.Dock = DockStyle.Fill;

            this.tableFilter.Controls.Add(visitFilter);

            visitFilter = new VisitFilterItem("Сегодня");
            visitFilter.Width = visitFilter.ItemText.Width + 20;
            visitFilter.ItemText.AutoSize = false;
            visitFilter.ItemText.Dock = DockStyle.Fill;

            this.tableFilter.Controls.Add(visitFilter);

            visitFilter = new VisitFilterItem("Завтра");
            visitFilter.Width = visitFilter.ItemText.Width + 20;
            visitFilter.ItemText.AutoSize = false;
            visitFilter.ItemText.Dock = DockStyle.Fill;

            this.tableFilter.Controls.Add(visitFilter);
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
            this.TitleVisits = new System.Windows.Forms.Label();
            this.tableFilter = new System.Windows.Forms.TableLayoutPanel();
            this.CreateVisit = new Guna.UI2.WinForms.Guna2Button();
            this.VisitsPanel = new System.Windows.Forms.Panel();
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
            this.VisitsLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // TitleVisits
            // 
            this.TitleVisits.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleVisits.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.TitleVisits.Location = new System.Drawing.Point(0, 59);
            this.TitleVisits.Name = "TitleVisits";
            this.TitleVisits.Size = new System.Drawing.Size(1169, 50);
            this.TitleVisits.TabIndex = 3;
            this.TitleVisits.Text = "Список визитов";
            this.TitleVisits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleVisits.Click += new System.EventHandler(this.TitleVisits_Click);
            // 
            // tableFilter
            // 
            this.tableFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableFilter.ColumnCount = 3;
            this.tableFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.53361F));
            this.tableFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.23319F));
            this.tableFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.23319F));
            this.tableFilter.Location = new System.Drawing.Point(43, 112);
            this.tableFilter.Name = "tableFilter";
            this.tableFilter.RowCount = 1;
            this.tableFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFilter.Size = new System.Drawing.Size(523, 40);
            this.tableFilter.TabIndex = 4;
            // 
            // CreateVisit
            // 
            this.CreateVisit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateVisit.BorderRadius = 8;
            this.CreateVisit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateVisit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateVisit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateVisit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateVisit.FillColor = System.Drawing.Color.LightGray;
            this.CreateVisit.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.CreateVisit.ForeColor = System.Drawing.Color.Black;
            this.CreateVisit.Location = new System.Drawing.Point(426, 602);
            this.CreateVisit.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.CreateVisit.Name = "CreateVisit";
            this.CreateVisit.Size = new System.Drawing.Size(224, 43);
            this.CreateVisit.TabIndex = 6;
            this.CreateVisit.Text = "Добавить визит";
            this.CreateVisit.Click += new System.EventHandler(this.CreateVisit_Click);
            // 
            // VisitsPanel
            // 
            this.VisitsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.VisitsPanel.AutoScroll = true;
            this.VisitsPanel.Location = new System.Drawing.Point(43, 176);
            this.VisitsPanel.Name = "VisitsPanel";
            this.VisitsPanel.Size = new System.Drawing.Size(1023, 412);
            this.VisitsPanel.TabIndex = 6;
            // 
            // VisitsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 667);
            this.Controls.Add(this.VisitsPanel);
            this.Controls.Add(this.tableFilter);
            this.Controls.Add(this.TitleVisits);
            this.Controls.Add(this.CreateVisit);
            this.Controls.Add(this.HeaderTable);
            this.Name = "VisitsPage";
            this.Text = "VisitsPage";
            this.HeaderTable.ResumeLayout(false);
            this.HeaderTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        private System.Windows.Forms.Label CoefficientsLabel;
        private System.Windows.Forms.Label VisitsLabel;
        private System.Windows.Forms.Label MastersLabel;
        private System.Windows.Forms.Label ServicesLabel;
        private System.Windows.Forms.Label TitleVisits;
        private TableLayoutPanel tableFilter;
        private Guna.UI2.WinForms.Guna2Button CreateVisit;
        private Panel VisitsPanel;
    }
}