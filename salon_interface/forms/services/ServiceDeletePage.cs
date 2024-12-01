using ProjectName.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salon_interface
{
    public partial class ServiceDeletePage : Form
    {
        private int id;
        private ServiceEditPage editPage;
        private ServicesPage servicesPage;

        public ServiceDeletePage(int id, string name, ServiceEditPage editPage, ServicesPage servicesPage)
        {
            InitializeComponent();
            this.id = id;
            this.NameServiceLabel.Text = name;
            this.editPage = editPage;
            this.servicesPage = servicesPage;
        }

        private void DeniedDeleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AcceptDeleteButton_Click(object sender, EventArgs e)
        {
            await ServiceApiHandler.DeleteServiceAsync(this.id);
            this.Close();
            this.editPage.Close();
            servicesPage.updateService();
        }
    }
}
