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

        private async void ServicesLabel_Click(object sender, EventArgs e)
        {
            List<Service> services = await ServiceApiHandler.GetServicesAsync();
            // Заполняем лейблы данными
            if (services != null && services.Count > 0)
            {
                NameService.Text = services[0].Name;
                PriceService.Text = Convert.ToString(services[0].Price);
                // Если есть больше услуг
                if (services.Count > 1)
                {
                    label1.Text = services[1].Name;
                    label2.Text = Convert.ToString(services[1].Price);
                }
            }
        }
    }

}
