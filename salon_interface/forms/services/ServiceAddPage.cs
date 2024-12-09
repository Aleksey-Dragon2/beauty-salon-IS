using Guna.UI2.WinForms;
using salon_interface.Models;
using ProjectName.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string text=this.AddPriceService.Text;
            if (this.AddNameService.Text == "" || this.AddNameService.Text == "Специализация")
                MessageBox.Show("Введите название услуги");
            else if (this.AddPriceService.Text == "")
                MessageBox.Show("Укажите цену");
            else if (!string.IsNullOrEmpty(text) && text[text.Length - 1] == '.')
                MessageBox.Show($"Цена не может заканчиваться на '.' ");
            else if (!this.AddNameService.Enabled || !this.AddPriceService.Enabled)
            {
                MessageBox.Show("Выберите специализацию и мастера");
            }

            else
            {

            string serviceName = this.AddNameService.Text;
            float serivcePrice = Convert.ToSingle(this.AddPriceService.Text);
            string masterSurname = this.ChoseMaster.Text.Split(' ')[0];
            string specialization = this.ChoiseMasterSpezialization.Text;
            int master_id = Find_Id_Masters(masterSurname, specialization);
                try
                {
                    await ServiceApiHandler.CreateServiceAsync(serviceName, serivcePrice, master_id);
                    this.servicesPage.updateService();
                    this.Close();
                }
                catch (Exception ex)
                {
                    this.errorLabel.Text = ex.Message;
                    this.errorLabel.Visible = true;
                }


            }
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
            else
            {
                this.ChoseMaster.Enabled = false;
            }
        }

        private void CancelAddServiceButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddServicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if (string.IsNullOrEmpty(AddPriceService.Text))
                {
                    e.Handled = true;
                    return;
                }
                if (AddPriceService.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void ChoseMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ChoseMaster.Text!=""&&this.ChoseMaster.Text!="Мастер")
            {
                this.AddNameService.Enabled= true;
                this.AddPriceService.Enabled= true;
            }
            else
            {
                this.AddNameService.Enabled = false;
                this.AddPriceService.Enabled = false;
            }
        }

        private void AddNameService_TextChanged(object sender, EventArgs e)
        {
            this.errorLabel.Visible= false;
        }
    }
}
