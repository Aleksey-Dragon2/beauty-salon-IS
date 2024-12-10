using ProjectName.api;
using salon_interface.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpdateVisitInfo = salon_interface.VisitsPage.UpdateVisitsInfo;

namespace salon_interface
{
    public partial class CreateVisitPage : Form
    {
        UpdateVisitInfo UpdateVisitInfo;
        public CreateVisitPage(UpdateVisitInfo updateVisitInfo)
        {
            InitializeComponent();
            loadServicesList();
            this.UpdateVisitInfo = updateVisitInfo;
        }
        private async void CreateVisit_Click(object sender, EventArgs e)
        {
            List<string> services = new List<string>();
            foreach (var item in this.choiseServicesList.CheckedItems)
            {
                services.Add(item.ToString());
            };

            string name = this.ClientName.Text;
            string date = this.dateTimePicker1.Text.Replace('.', '-');
            DateTime dateTime = Convert.ToDateTime(this.dateTimePicker1.Text);
            string status = "Запланирован";

            await VisitApiHandler.CreateVisitAsync(name, date, status, services);
            this.UpdateVisitInfo();
            this.Close();
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
                this.choiseServicesList.Items.AddRange(new object[] { $"{service.Name}" });
            }
        }
    }
}
