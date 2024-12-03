using ProjectName.api;
using salon_interface;
using System;
using System.Drawing;
using System.Windows.Forms;
using static salon_interface.ServicesPage;
using LoadServises = salon_interface.ServicesPage.LoadServices;

namespace salon_interface
{
    public partial class ServiceEditPage : Form
    {
        private int id;
        private string defaultName;
        private LoadServises loadServices;
        public delegate void CloseEditForm();
        public ServiceEditPage(int id, LoadServises loadServices)
        {
            this.id = id;
            InitializeComponent();
            this.loadServices = loadServices;
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
                loadServices();
            }

        }

        private void DeleteServiceButton_Click(object sender, EventArgs e)
        {
            int id = this.id;
            string name = this.defaultName;
            CloseEditForm closeEditForm = this.Close;
            ServiceDeletePage deletePage = new ServiceDeletePage(id, name, closeEditForm, loadServices);
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
