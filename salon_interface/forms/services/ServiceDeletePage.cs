using ProjectName.api;
using System;
using System.Windows.Forms;
using LoadServises = salon_interface.ServicesPage.LoadServices;
using CloseEditForm = salon_interface.ServiceEditPage.CloseEditForm;

namespace salon_interface
{
    public partial class ServiceDeletePage : Form
    {
        private int id;
        private CloseEditForm closeEditForm;
        private LoadServises loadServices;
        public ServiceDeletePage(int id, string name, CloseEditForm closeEditForm, LoadServises loadServices)
        {
            InitializeComponent();
            this.id = id;
            this.NameServiceLabel.Text = name;
            this.closeEditForm = closeEditForm;
            this.loadServices = loadServices;
        }

        private void DeniedDeleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AcceptDeleteButton_Click(object sender, EventArgs e)
        {
            await ServiceApiHandler.DeleteServiceAsync(this.id);
            this.Close();
            this.closeEditForm();
            this.loadServices();
        }
    }
}
