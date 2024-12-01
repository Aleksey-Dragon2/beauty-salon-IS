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
        private int id;
        public ServiceAddPage(int id)
        {
            this.id = id;
            InitializeComponent();
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
            int id = this.id;
            string name=this.EditNameService.Text;
            float price=Convert.ToSingle(this.EditPriceService.Text);
            await ServiceApiHandler.AddServiceAsync(name, price);
            this.Close();
            ServicesPage.ServicesLabel_Click(null, null);

        }
    }
}
