using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace salon_interface
{
    public class MasterInfoPanel : System.Windows.Forms.UserControl
    {
        public Guna2Panel MasterPanel;
        public TableLayoutPanel MasterLayoutPanel;
        public Label NameLabel;
        public Label SpecializationLabel;
        public MasterInfoPanel(string name, string surname, string specialization)
        {
            InitializeComponent();
            this.NameLabel.Text = $"{name} {surname}";
            this.SpecializationLabel.Text = $"{specialization}";
        }
        public MasterInfoPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.MasterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MasterLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SpecializationLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MasterPanel.SuspendLayout();
            this.MasterLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MasterPanel
            // 
            this.MasterPanel.BorderRadius = 18;
            this.MasterPanel.BorderThickness = 1;
            this.MasterPanel.Controls.Add(this.MasterLayoutPanel);
            this.MasterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterPanel.FillColor = System.Drawing.Color.Silver;
            this.MasterPanel.Location = new System.Drawing.Point(0, 0);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(223, 71);
            this.MasterPanel.TabIndex = 0;
            // 
            // MasterLayoutPanel
            // 
            this.MasterLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.MasterLayoutPanel.ColumnCount = 1;
            this.MasterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MasterLayoutPanel.Controls.Add(this.SpecializationLabel, 0, 1);
            this.MasterLayoutPanel.Controls.Add(this.NameLabel, 0, 0);
            this.MasterLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MasterLayoutPanel.Name = "MasterLayoutPanel";
            this.MasterLayoutPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.MasterLayoutPanel.RowCount = 2;
            this.MasterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MasterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MasterLayoutPanel.Size = new System.Drawing.Size(223, 71);
            this.MasterLayoutPanel.TabIndex = 0;
            // 
            // SpecializationLabel
            // 
            this.SpecializationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecializationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecializationLabel.Location = new System.Drawing.Point(18, 35);
            this.SpecializationLabel.Name = "SpecializationLabel";
            this.SpecializationLabel.Size = new System.Drawing.Size(187, 36);
            this.SpecializationLabel.TabIndex = 1;
            this.SpecializationLabel.Text = "Специализация";
            this.SpecializationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(18, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(187, 35);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "ФИО";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MasterInfoPanel
            // 
            this.Controls.Add(this.MasterPanel);
            this.Name = "MasterInfoPanel";
            this.Size = new System.Drawing.Size(223, 71);
            this.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.MasterPanel.ResumeLayout(false);
            this.MasterLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        //Общий обработчик клика
        private void OnPanel_MouseClick(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(PanelService.Name.Split('_')[1]);
            //ServiceEditPage serviceAddPage = new ServiceEditPage(id, loadServices);
            //serviceAddPage.FillEditData(this.NameService.Text, this.PriceService.Text);
            //serviceAddPage.ShowDialog();

        }

        private void OnControlMouseEnter(object sender, EventArgs e)
        {

            //PanelService.BorderColor = Color.Red;

        }

        private void OnControlMouseLeave(object sender, EventArgs e)
        {
            //PanelService.BorderColor = Color.Transparent;

        }
    }
}
