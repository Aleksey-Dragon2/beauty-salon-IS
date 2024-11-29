using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormsApp.Models;
using ProjectName.Services;
using System.Threading;
using ProjectName.api;
using Guna.UI2.WinForms;

namespace @interface
{
    public partial class ServicesPage : Form
    {
        private readonly ApiService _apiService;
        public ServicesPage()
        {
            InitializeComponent();
            _apiService = new ApiService();

        }

        List<ServicePanelContainer> servicePanelContainers = new List<ServicePanelContainer>();
        private async void ServicesLabel_Click(object sender, EventArgs e)
        {
                for (int i=0; i < servicePanelContainers.Count; i++)
                {
                PanelListServices.Controls.Remove(servicePanelContainers[i].PanelService);
                }


            List<Service> services = await ServiceApiHandler.GetServicesAsync();
            foreach (Service service in services){
                //MessageBox.Show($"{service.Id},{service.Name}, {service.Price}");

                ServicePanelContainer servicePanel = new ServicePanelContainer(service.Id.ToString(), service.Name, service.Price.ToString());
                PanelListServices.Controls.Add(servicePanel.PanelService);
                //PanelListServices.Controls.Remove(servicePanel.PanelService);

                servicePanelContainers.Add(servicePanel);
            }
        }
      
        private void PanelService_Click(object sender, EventArgs e)
        {
            if (sender is Label button)
            {
                MessageBox.Show($"Вы нажали на: {button.Name}");
            }
        }


        private void PanelService_MouseEnter(object sender, EventArgs e)
        {
            this.PanelService.BorderColor = Color.Red;
            
        }

        private void PanelService_MouseLeave(object sender, EventArgs e)
        {
            this.PanelService.BorderColor= Color.Transparent;
        }
    }

}
