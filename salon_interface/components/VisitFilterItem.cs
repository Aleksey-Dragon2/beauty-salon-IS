using Guna.UI2.WinForms;
using salon_interface.Models;
using ProjectName.api;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace salon_interface
{
    public class VisitFilterItem : System.Windows.Forms.UserControl
    {
        public Guna2Panel BackgroundPanel;
        public Label ItemText;
        private updateVisitsInfo updateVisits;
        private updateVisitsByDate visitsByDate;
        public VisitFilterItem(string nameFilter, updateVisitsInfo updateVisitsInfo, updateVisitsByDate updateVisitsByDate)
        {
            InitializeComponent();
            this.ItemText.Text = nameFilter;
            this.updateVisits = updateVisitsInfo;
            this.visitsByDate = updateVisitsByDate;
        }
        public VisitFilterItem()
        {
            InitializeComponent();
        }

        public delegate void updateVisitsInfo();
        public delegate void updateVisitsByDate(List<Visit> visits);
        private void InitializeComponent()
        {
            this.BackgroundPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ItemText = new System.Windows.Forms.Label();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.AutoRoundedCorners = true;
            this.BackgroundPanel.AutoSize = true;
            this.BackgroundPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundPanel.BorderRadius = 18;
            this.BackgroundPanel.BorderThickness = 1;
            this.BackgroundPanel.Controls.Add(this.ItemText);
            this.BackgroundPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.FillColor = System.Drawing.Color.Silver;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(104, 38);
            this.BackgroundPanel.TabIndex = 4;
            this.BackgroundPanel.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.BackgroundPanel.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.BackgroundPanel.Click += new System.EventHandler(this.OnPanel_MouseClick);
            // 
            // ItemText
            // 
            this.ItemText.AutoSize = true;
            this.ItemText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemText.Location = new System.Drawing.Point(32, 9);
            this.ItemText.Margin = new System.Windows.Forms.Padding(0);
            this.ItemText.Name = "ItemText";
            this.ItemText.Size = new System.Drawing.Size(36, 19);
            this.ItemText.TabIndex = 0;
            this.ItemText.Text = "Все";
            this.ItemText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemText.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.ItemText.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.ItemText.Click += new System.EventHandler(this.OnPanel_MouseClick);
            // 
            // MasterFilterItem
            // 
            this.Controls.Add(this.BackgroundPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MasterFilterItem";
            this.Size = new System.Drawing.Size(104, 32);
            this.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.Click += new System.EventHandler(this.OnPanel_MouseClick);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }



        //Общий обработчик клика
        private async void OnPanel_MouseClick(object sender, EventArgs e)
        {
            string date = "";
            if (this.ItemText.Text == "Сегодня")
            {
                date = DateTime.Today.ToString("yyyy-MM-dd");
                this.visitsByDate(await VisitApiHandler.GetVisitByDateAsync(date));
            }
            else if (this.ItemText.Text == "Завтра")
            {
                date = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                this.visitsByDate(await VisitApiHandler.GetVisitByDateAsync(date));

            }
            else
            {
                this.updateVisits();
            }
        }

        private void OnControlMouseEnter(object sender, EventArgs e)
        {
            this.BackgroundPanel.BorderColor = Color.Black;
        }

        private void OnControlMouseLeave(object sender, EventArgs e)
        {
            this.BackgroundPanel.BorderColor = Color.Transparent;
        }
    }
}
