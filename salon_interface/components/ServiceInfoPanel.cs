using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salon_interface
{
    public class ServiceInfoPanel : System.Windows.Forms.UserControl
    {
        public Guna2Panel PanelService;
        public Label NameService;
        public Label PriceService;
        private ServicesPage ServicesPage;
        
        //public ServicePanelContainer(string id, string serviceName, string servicePrice)
        public ServiceInfoPanel(string id, ServicesPage servicesPage)
        {
            InitializeComponent();
            this.PanelService.Name = $"ServicePanel_{id}";
            this.NameService.Name = $"ServiceName_{id}";
            this.PriceService.Name = $"ServicePrice_{id}";
            this.ServicesPage = servicesPage ;
        }


        private void InitializeComponent()
        {
            this.PanelService = new Guna.UI2.WinForms.Guna2Panel();
            this.PriceService = new System.Windows.Forms.Label();
            this.NameService = new System.Windows.Forms.Label();
            this.PanelService.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelService
            // 
            this.PanelService.AutoRoundedCorners = true;
            this.PanelService.BackColor = System.Drawing.Color.Transparent;
            this.PanelService.BorderColor = System.Drawing.Color.Transparent;
            this.PanelService.BorderRadius = 14;
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
            this.PanelService.Size = new System.Drawing.Size(635, 30);
            this.PanelService.TabIndex = 0;
            this.PanelService.Click += new System.EventHandler(this.OnPanel_MouseClick);
            this.PanelService.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.PanelService.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            // 
            // PriceService
            // 
            this.PriceService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PriceService.Dock = System.Windows.Forms.DockStyle.Right;
            this.PriceService.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PriceService.Location = new System.Drawing.Point(547, 0);
            this.PriceService.Name = "PriceService";
            this.PriceService.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.PriceService.Size = new System.Drawing.Size(88, 30);
            this.PriceService.TabIndex = 1;
            this.PriceService.Text = "10.0";
            this.PriceService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PriceService.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.PriceService.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            // 
            // NameService
            // 
            this.NameService.BackColor = System.Drawing.Color.Transparent;
            this.NameService.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameService.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NameService.Location = new System.Drawing.Point(0, 0);
            this.NameService.Name = "NameService";
            this.NameService.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.NameService.Size = new System.Drawing.Size(500, 30);
            this.NameService.TabIndex = 0;
            this.NameService.Text = "Маникюр";
            this.NameService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameService.Click += new System.EventHandler(this.OnPanel_MouseClick);
            this.NameService.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.NameService.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            // 
            // ServiceInfoPanel
            // 
            this.Controls.Add(this.PanelService);
            this.Name = "ServiceInfoPanel";
            this.Size = new System.Drawing.Size(635, 39);
            this.MouseEnter += new System.EventHandler(this.OnControlMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnControlMouseLeave);
            this.PanelService.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        //Общий обработчик клика
        private void OnPanel_MouseClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(PanelService.Name.Split('_')[1]);
            ServiceEditPage serviceAddPage = new ServiceEditPage(id, ServicesPage);
            serviceAddPage.FillEditData(this.NameService.Text, this.PriceService.Text);
            serviceAddPage.ShowDialog();

        }

        private void OnControlMouseEnter(object sender, EventArgs e)
        {

            PanelService.BorderColor = Color.Red;

        }

        private void OnControlMouseLeave(object sender, EventArgs e)
        {
            PanelService.BorderColor = Color.Transparent;

        }
    }
}
