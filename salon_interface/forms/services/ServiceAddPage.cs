using MyWindowsFormsApp.Models;
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
    public partial class ServiceAddPage : Form
    {
        private ServicesPage servicesPage = new ServicesPage();
        private List<Master> masters = new List<Master>();
        public ServiceAddPage(ServicesPage servicesPage)
        {
            InitializeComponent();
            this.servicesPage = servicesPage;
            loadSpecialization();
        }
        public ServiceAddPage()
        {
            InitializeComponent();
            loadSpecialization();
        }

        private async void AcceptAddButton_Click(object sender, EventArgs e)
        {
            
            string serviceName = this.AddNameService.Text;
            float serivcePrice =Convert.ToSingle(this.AddPriceService.Text);
            string masterSurname = this.ChoseMaster.Text.Split(' ')[0];
            string specialization = this.ChoiseMasterSpezialization.Text;
            int master_id = Find_Id_Masters(masterSurname, specialization);

            await ServiceApiHandler.CreateServiceAsync(serviceName, serivcePrice, master_id);
            this.servicesPage.updateService();
            this.Close();
        }

        private int Find_Id_Masters(string targetSurname, string targetSpecialization)
        {
            int? masterId = null;
            foreach (Master master in masters)
            {
                if (master.Surname == targetSurname && master.Specialization == targetSpecialization)
                {
                    masterId = master.Id;
                    break;
                }
            }
            return (int)masterId;
        }

        private void ChoiseMasterSpezialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            string specialization = this.ChoiseMasterSpezialization.Text;
            this.ChoseMaster.Items.Clear();
            this.ChoseMaster.Enabled = true;
            if (specialization != "Специализация" && specialization != null)
            {
                this.ChoseMaster.Items.AddRange(new object[] { "Мастер" });
                foreach (Master master in this.masters)
                {
                    if (master.Specialization == specialization)
                    {
                        this.ChoseMaster.Items.AddRange(new object[] { $"{master.Surname} {master.Name}" });
                    }
                }

                this.ChoseMaster.SelectedIndex = 0;
            }
        }

        private void CancelAddServiceButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
