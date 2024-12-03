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
    public partial class ServiceEditPage : Form
    {
        private int id;
        private string defaultName;
        private ServicesPage servicesPage;
        public ServiceEditPage(int id, ServicesPage servicesPage)
        {
            this.id = id;
            InitializeComponent();
            this.servicesPage = servicesPage;
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseFormButton_MouseEnter(object sender, EventArgs e)
        {
            this.CloseFormButton.ForeColor = Color.Gray;
        }

        private void CloseFormButton_MouseLeave(object sender, EventArgs e)
        {
            this.CloseFormButton.ForeColor = Color.Black;
        }

        private async void AcceptEditButton_Click(object sender, EventArgs e)
        {
            string text = this.EditPriceService.Text;
            if (this.EditNameService.Text == "")
                MessageBox.Show("Введите название услуги");
            else if (this.EditPriceService.Text == "")
                MessageBox.Show("Укажите цену");
            else if (!string.IsNullOrEmpty(text) && text[text.Length - 1] == '.')
                MessageBox.Show($"Цена не может заканчиваться на '.' ");
            else
            {
            int id = this.id;
            string name=this.EditNameService.Text;
            float price=Convert.ToSingle(this.EditPriceService.Text);
            await ServiceApiHandler.UpdateServiceAsync(id,name, price);
            this.Close();
            servicesPage.updateService();
            }

        }

        private void DeleteServiceButton_Click(object sender, EventArgs e)
        {
            int id = this.id;
            string name = this.defaultName;
            ServiceDeletePage deletePage = new ServiceDeletePage(id, name,this, servicesPage);
            deletePage.ShowDialog();

        }

        private void EditServicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if (string.IsNullOrEmpty(EditPriceService.Text))
                {
                    e.Handled = true;
                    return;
                }
                if (EditPriceService.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
