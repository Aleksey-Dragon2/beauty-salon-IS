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
            updateService();
        }
        private async void ServicesLabel_Click(object sender, EventArgs e)
        {
            this.updateService();
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


        private async void AcceptEditButton_Click(object sender, EventArgs e)
        {
            ServiceAddPage serviceAddPage = new ServiceAddPage(this);
            serviceAddPage.ShowDialog();

        }
    }

}
