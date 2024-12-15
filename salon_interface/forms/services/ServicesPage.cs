using salon_interface.Models;
using ProjectName.api;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace salon_interface
{
    public partial class ServicesPage : Form
    {
        private FormManager formManager;
        public ServicesPage(FormManager formManager)
        {
            InitializeComponent();
            updateService();
            this.formManager = formManager;

            this.FormClosing += ServicesPage_FormClosing;
        }

        public delegate void LoadServices();

        public async void updateService()
        {
            for (int i = PanelListServices.Controls.Count - 1; i >= 0; i--)
            {
                Control control = PanelListServices.Controls[i];
                PanelListServices.Controls.Remove(control);
            }
            LoadServices loadServices = updateService;

            List<Service> services = await ServiceApiHandler.GetServicesAsync();
            foreach (Service service in services)
            {
                ServiceInfoPanel servicePanel = new ServiceInfoPanel(service.Id.ToString(), loadServices);
                servicePanel.NameService.Text = service.Name;
                servicePanel.PriceService.Text = service.Price.ToString().Replace(',', '.');

                Panel tehnicalPanel = new Panel();
                tehnicalPanel.Dock = DockStyle.Top;
                tehnicalPanel.Size = new System.Drawing.Size(10, 8);

                PanelListServices.Controls.Add(servicePanel.PanelService);
                PanelListServices.Controls.Add(tehnicalPanel);
            }
        }
        private void CreateServiceButton_Click(object sender, EventArgs e)
        {
            ServiceAddPage serviceAddPage = new ServiceAddPage(updateService);
            serviceAddPage.ShowDialog();
        }

        private void MastersLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("MastersPage");
        }

        private void VisitsLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("VisitsPage");
        }

        private void CoefficientsLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("PriceCoefficientPage");
        }
        private void ServicesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
