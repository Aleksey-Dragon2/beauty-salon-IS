using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace salon_interface
{
    public class MasterInfoPanel : System.Windows.Forms.UserControl
    {
        public Guna2Panel MasterPanel;
        public Label NameLabel;
        public Label SpecializationLabel;
        public MasterInfoPanel(int id, string name, string surname, string specialization)
        {
            InitializeComponent();
            this.NameLabel.Text = $"{name} {surname}";
            this.SpecializationLabel.Text = $"{specialization}";
            this.Tag = id;
        }
        public MasterInfoPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.MasterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SpecializationLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MasterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasterPanel
            // 
            this.MasterPanel.BorderRadius = 18;
            this.MasterPanel.BorderThickness = 1;
            this.MasterPanel.Controls.Add(this.SpecializationLabel);
            this.MasterPanel.Controls.Add(this.NameLabel);
            this.MasterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterPanel.FillColor = System.Drawing.Color.Silver;
            this.MasterPanel.Location = new System.Drawing.Point(0, 0);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(220, 82);
            this.MasterPanel.TabIndex = 0;
            this.MasterPanel.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.MasterPanel.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.MasterPanel.Click += new System.EventHandler(this.OnPanel_MouseClick);
            // 
            // SpecializationLabel
            // 
            this.SpecializationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecializationLabel.AutoSize = true;
            this.SpecializationLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpecializationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecializationLabel.Location = new System.Drawing.Point(16, 45);
            this.SpecializationLabel.Name = "SpecializationLabel";
            this.SpecializationLabel.Size = new System.Drawing.Size(140, 20);
            this.SpecializationLabel.TabIndex = 1;
            this.SpecializationLabel.Text = "Специализация";
            this.SpecializationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SpecializationLabel.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.SpecializationLabel.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.SpecializationLabel.Click += new System.EventHandler(this.OnPanel_MouseClick);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(16, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "ФИО";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameLabel.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.NameLabel.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.NameLabel.Click += new System.EventHandler(this.OnPanel_MouseClick);
            // 
            // MasterInfoPanel
            // 
            this.Controls.Add(this.MasterPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MasterInfoPanel";
            this.Size = new System.Drawing.Size(220, 82);
            this.AutoSize = false;
            this.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.Click += new System.EventHandler(this.OnPanel_MouseClick);
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
