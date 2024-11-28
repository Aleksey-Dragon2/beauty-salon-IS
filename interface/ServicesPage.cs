using MyWindowsFormsApp.Services;
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

namespace @interface
{
    public partial class ServicesPage : Form
    {
        private readonly ApiService _apiService;
        public ServicesPage()
        {
            InitializeComponent();
            var httpClientService = new HttpClientService();
            _apiService = new ApiService(httpClientService);
        }

        private void ServicesLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Service service = _apiService.GetService(); // Доделать вывод услуг

                NameService.Text = service.Name;
                PriceService.Text = Convert.ToString(service.Price);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }

}
