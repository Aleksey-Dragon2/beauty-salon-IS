using salon_interface.Models;
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
    public partial class MasterPage : Form
    {
        private FormManager formManager;

        public delegate void loadMasters();
        public delegate void updateMasters(List<Master> masters);
        public MasterPage(FormManager formManager)
        {
            InitializeComponent();
            LoadMasters();
            LoadFilters();
            this.formManager = formManager;

            this.FormClosing += MastersPage_FormClosing;
        }

        public async void LoadMasters()
        {
            this.customFlowLayoutPanel1.Controls.Clear();
            List<Master> masters = await MasterApiHandler.GetMastersAsync();
            foreach (var master in masters)
            {
                MasterInfoPanel masterPanel = new MasterInfoPanel(master.Id, master.Name, master.Surname, master.Specialization, LoadMasters);
                this.customFlowLayoutPanel1.Controls.Add(masterPanel);
            }
        }

        public void LoadMasters(List<Master> masters)
        {
            this.customFlowLayoutPanel1.Controls.Clear();
            foreach (var master in masters)
            {
                MasterInfoPanel masterPanel = new MasterInfoPanel(master.Id, master.Name, master.Surname, master.Specialization, LoadMasters);
                this.customFlowLayoutPanel1.Controls.Add(masterPanel);
            }
        }
        public async void LoadFilters()
        {
            MasterFilterItem filterItem = new MasterFilterItem("Все", LoadMasters);
            filterItem.Width = filterItem.ItemText.Width + 20;
            filterItem.ItemText.AutoSize = false;
            filterItem.ItemText.Dock = DockStyle.Fill;
            this.FilterPanel.Controls.Add(filterItem);

            List<string> specializations = await MasterApiHandler.GetSpecizlizationAsync();
            foreach (string item in specializations)
            {
                MasterFilterItem masterFilter = new MasterFilterItem(item, LoadMasters);
                masterFilter.Width = masterFilter.ItemText.Width + 20;
                masterFilter.ItemText.AutoSize = false;
                masterFilter.ItemText.Dock = DockStyle.Fill;
                this.FilterPanel.Controls.Add(masterFilter);
            }
        }

        private void CreateMaster_Click(object sender, EventArgs e)
        {
            CreateMasterPage createMasterPage= new CreateMasterPage(LoadMasters);
            createMasterPage.ShowDialog();
        }

        private void ServicesLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("ServicesPage");
        }

        private void VisitsLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("VisitsPage");
        }

        private void CoefficientsLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("PriceCoefficientPage");
        }
        private void MastersPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
