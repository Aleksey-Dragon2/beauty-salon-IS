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

namespace salon_interface
{
    public partial class ServicesPage : Form
    {
        private readonly ApiService _apiService;
        public ServicesPage()
        {
            InitializeComponent();
            _apiService = new ApiService();
            ServicesLabel_Click(null, null);
        }

        public static async void ServicesLabel_Click(object sender, EventArgs e)
        {
            for (int i = PanelListServices.Controls.Count - 1; i >= 0; i--)
            {
                Control control = PanelListServices.Controls[i];
                PanelListServices.Controls.Remove(control);
            }


            List<Service> services = await ServiceApiHandler.GetServicesAsync();
            foreach (Service service in services){

                ServiceInfoPanel servicePanel = new ServiceInfoPanel(service.Id.ToString());
                servicePanel.NameService.Text=service.Name;
                servicePanel.PriceService.Text = service.Price.ToString();
                

                PanelListServices.Controls.Add(servicePanel.PanelService);
                //servicePanel.NameService.Click+= new System.EventHandler(this.PanelService_Click);
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

        private void Service_Click(object sender, EventArgs e)
        {

        }
    }

}
