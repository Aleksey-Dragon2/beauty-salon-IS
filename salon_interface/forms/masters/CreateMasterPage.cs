using salon_interface.Models;
using ProjectName.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loadMasters = salon_interface.MasterPage.loadMasters;
namespace salon_interface
{
    public partial class CreateMasterPage : Form
    {
        private loadMasters LoadMasters;
        public CreateMasterPage(loadMasters loadMasters)
        {
            InitializeComponent();
            loadServicesList();
            this.LoadMasters = loadMasters;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = choiseServicesList.SelectedIndex;

            if (selectedIndex != -1)
            {
                choiseServicesList.SetItemChecked(selectedIndex, !choiseServicesList.GetItemChecked(selectedIndex));
                choiseServicesList.ClearSelected();
            }
        }
        
        private async void loadServicesList()
        {
            List<Service> services = await ServiceApiHandler.GetServicesAsync();
            foreach (Service service in services)
            {
            this.choiseServicesList.Items.AddRange(new object[] {$"{service.Name}"});
            }
            List<string> specializations = await MasterApiHandler.GetSpecizlizationAsync();
            foreach (string item in specializations)
            {
            this.choseSpecialization.Items.AddRange(new object[] {item});
            }
        }

        private void labelSpecialization_Click(object sender, EventArgs e)
        {
            loadServicesList();

        }

        private async void AcceptCreateButton_Click(object sender, EventArgs e)
        {
            List<string> services = new List<string>();
            foreach (var item in this.choiseServicesList.CheckedItems) {
                services.Add(item.ToString());
            };
            string name = this.masterName.Text;
            string surname = this.masterSurname.Text;
            string specialization = this.choseSpecialization.Text;
            await MasterApiHandler.CreateMasterAsync(name, surname, specialization, services);
            this.LoadMasters();
            this.Close();
        }

        private void DeniedCreateButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
