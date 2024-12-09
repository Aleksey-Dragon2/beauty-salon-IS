using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace salon_interface
{
    public class VisitInfoPanel : System.Windows.Forms.UserControl
    {
        public Guna2Panel MasterPanel;
        public Label NameLabel;
        public Label Status;
        private Guna2Button guna2Button1;
        public Label DataTimeLabel;
        public VisitInfoPanel(int id, string name, string datatime, string status)
        {
            InitializeComponent();
            this.NameLabel.Text = $"{name}";
            this.DataTimeLabel.Text = $"{datatime}";
            this.Status.Text = $"{status}";
            this.Tag = id;
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.MasterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasterPanel
            // 
            this.MasterPanel.BorderRadius = 18;
            this.MasterPanel.BorderThickness = 1;
            this.MasterPanel.Controls.Add(this.guna2Button1);
            this.MasterPanel.Controls.Add(this.Status);
            this.MasterPanel.Controls.Add(this.DataTimeLabel);
            this.MasterPanel.Controls.Add(this.NameLabel);
            this.MasterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterPanel.FillColor = System.Drawing.Color.Silver;
            this.MasterPanel.Location = new System.Drawing.Point(0, 0);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(473, 132);
            this.MasterPanel.TabIndex = 0;
            this.MasterPanel.Click += new System.EventHandler(this.OnPanel_MouseClick);
            this.MasterPanel.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.MasterPanel.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(19, 72);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(67, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "Статус";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataTimeLabel
            // 
            this.DataTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTimeLabel.AutoSize = true;
            this.DataTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.DataTimeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataTimeLabel.Location = new System.Drawing.Point(19, 43);
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
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(19, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(120, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя клиента";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameLabel.Click += new System.EventHandler(this.OnPanel_MouseClick);
            this.NameLabel.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.NameLabel.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Lime;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(23, 97);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(117, 22);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Завершить";
            // 
            // VisitInfoPanel
            // 
            this.Controls.Add(this.MasterPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "VisitInfoPanel";
            this.Size = new System.Drawing.Size(473, 132);
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
            //int id = Convert.ToInt32(PanelService.Name.Split('_')[1]);
            //ServiceEditPage serviceAddPage = new ServiceEditPage(id, loadServices);
            //serviceAddPage.FillEditData(this.NameService.Text, this.PriceService.Text);
            //serviceAddPage.ShowDialog();
            MessageBox.Show(this.Tag.ToString());

        }

        private void OnControlMouseEnter(object sender, EventArgs e)
        {

            MasterPanel.BorderColor = Color.Red;

        }

        private void OnControlMouseLeave(object sender, EventArgs e)
        {
            MasterPanel.BorderColor = Color.Transparent;

        }
    }
}
