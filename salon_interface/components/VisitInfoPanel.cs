using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using ProjectName.api;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace salon_interface
{
    public class VisitInfoPanel : System.Windows.Forms.UserControl
    {
        private Guna2Panel MasterPanel;
        private Label NameLabel;
        private Label Status;
        private Label DataTimeLabel;
        private System.ComponentModel.IContainer components;
        private Guna2Button ControlButton;
        public VisitInfoPanel(int id, string name, string datatime, string status)
        {
            InitializeComponent();
            this.NameLabel.Text = $"{name}";
            this.DataTimeLabel.Text = $"{datatime}";
            this.Status.Text = $"{status}";
            this.Tag = id;
            if (status.ToLower() == "запланирован")
            {
                this.ControlButton.Text = "Начать выполнение";
                this.ControlButton.Width += 50;
                this.ControlButton.FillColor = Color.Yellow;
                this.Size = new System.Drawing.Size(473, 132);
                this.MasterPanel.Size = new System.Drawing.Size(473, 132);
                this.MasterPanel.Controls.Add(this.ControlButton);
            }
            else if (status.ToLower() == "выполняется")
            {
                this.ControlButton.Text = "Завершить";
                this.Size = new System.Drawing.Size(473, 132);
                this.MasterPanel.Size = new System.Drawing.Size(473, 132);
                this.MasterPanel.Controls.Add(this.ControlButton);
            }
        }
        public VisitInfoPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.MasterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Status = new System.Windows.Forms.Label();
            this.DataTimeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ControlButton = new Guna.UI2.WinForms.Guna2Button();
            this.MasterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasterPanel
            // 
            this.MasterPanel.BorderRadius = 18;
            this.MasterPanel.BorderThickness = 1;
            this.MasterPanel.Controls.Add(this.Status);
            this.MasterPanel.Controls.Add(this.DataTimeLabel);
            this.MasterPanel.Controls.Add(this.NameLabel);
            this.MasterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterPanel.FillColor = System.Drawing.Color.Silver;
            this.MasterPanel.Location = new System.Drawing.Point(0, 0);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(473, 96);
            this.MasterPanel.TabIndex = 0;
            this.MasterPanel.Click += new System.EventHandler(this.OnPanel_MouseClick);
            this.MasterPanel.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.MasterPanel.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(18, 67);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(67, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "Статус";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataTimeLabel
            // 
            this.DataTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTimeLabel.AutoSize = true;
            this.DataTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DataTimeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataTimeLabel.Location = new System.Drawing.Point(18, 38);
            this.DataTimeLabel.Name = "DataTimeLabel";
            this.DataTimeLabel.Size = new System.Drawing.Size(112, 22);
            this.DataTimeLabel.TabIndex = 1;
            this.DataTimeLabel.Text = "Дата визита";
            this.DataTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataTimeLabel.Click += new System.EventHandler(this.OnPanel_MouseClick);
            this.DataTimeLabel.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.DataTimeLabel.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(18, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(120, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя клиента";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameLabel.Click += new System.EventHandler(this.OnPanel_MouseClick);
            this.NameLabel.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.NameLabel.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            // 
            // ControlButton
            // 
            this.ControlButton.BackColor = System.Drawing.Color.Transparent;
            this.ControlButton.BorderRadius = 8;
            this.ControlButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ControlButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ControlButton.FillColor = System.Drawing.Color.Lime;
            this.ControlButton.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ControlButton.ForeColor = System.Drawing.Color.Black;
            this.ControlButton.Location = new System.Drawing.Point(23, 97);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(117, 22);
            this.ControlButton.TabIndex = 3;
            this.ControlButton.Click += new System.EventHandler(this.OnControlButton_MouseClick);
            // 
            // VisitInfoPanel
            // 
            this.Controls.Add(this.MasterPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "VisitInfoPanel";
            this.Size = new System.Drawing.Size(473, 96);
            this.Click += new System.EventHandler(this.OnPanel_MouseClick);
            this.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.MasterPanel.ResumeLayout(false);
            this.MasterPanel.PerformLayout();
            this.ResumeLayout(false);

        }



        //Общий обработчик клика
        private void OnPanel_MouseClick(object sender, EventArgs e)
        {

        }

        private async void OnControlButton_MouseClick(object sender, EventArgs e)
        {
            int id = (int)this.Tag;
            string status = "";
            if (this.ControlButton.Text.ToLower() == "начать выполнение")
            {
                status = "Выполняется";
                await VisitApiHandler.UpdateVisitAsync(id, status);

                this.ControlButton.Text = "Завершить";
                this.ControlButton.FillColor = Color.Lime;
                this.ControlButton.Size = new System.Drawing.Size(117, 22);
                this.Status.Text = "Выполняется";
                AnimateChange();
            }
            else
            {
                status = "Завершен";
                await VisitApiHandler.UpdateVisitAsync(id, status);
                this.Status.Text = "Завершен";
                this.MasterPanel.Controls.Remove(this.ControlButton);
                this.MasterPanel.Size = new System.Drawing.Size(473, 96);
                this.Size = new System.Drawing.Size(473, 96);
                AnimateChange();
                DoneVisitPage doneVisitPage = new DoneVisitPage((int)this.Tag);
                doneVisitPage.Show();
            }   
        }
        private void AnimateChange()
        {
            this.Visible = false;
            Thread.Sleep(50);
            this.Visible = true;
        }

        private void OnControlMouseEnter(object sender, EventArgs e)
        {

            //MasterPanel.BorderColor = Color.Red;

        }

        private void OnControlMouseLeave(object sender, EventArgs e)
        {
            //MasterPanel.BorderColor = Color.Transparent;

        }
    }
}
