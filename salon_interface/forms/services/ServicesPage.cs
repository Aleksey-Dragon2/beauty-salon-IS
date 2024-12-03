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

        private void CreateServiceButton_Click(object sender, EventArgs e)
        {
            ServiceAddPage serviceAddPage = new ServiceAddPage(this);
            serviceAddPage.ShowDialog();
        }
    }

}
