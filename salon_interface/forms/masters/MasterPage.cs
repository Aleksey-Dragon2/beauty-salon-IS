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
using ShowServiceForm = salon_interface.ServicesPage.ShowServiceForm;

namespace salon_interface
{
    public partial class MasterPage : Form
    {
        private ShowServiceForm showServiceForm;
        public delegate void loadMasters();
        public delegate void updateMasters(List<Master> masters);
        public MasterPage(ShowServiceForm showServiceForm)
        {
            InitializeComponent();
            LoadMasters();
            this.showServiceForm = showServiceForm;
        }
        public MasterPage()
        {
            InitializeComponent();
            LoadMasters();
            LoadFilters();
        }

        public async void LoadMasters()
        {
            this.customFlowLayoutPanel1.Controls.Clear();
            List<Master> masters = await MasterApiHandler.GetMastersAsync();
            foreach (var master in masters)
            {
                MasterInfoPanel masterPanel = new MasterInfoPanel(master.Id, master.Name, master.Surname, master.Specialization);
                this.customFlowLayoutPanel1.Controls.Add(masterPanel);
            }
        }

        public void LoadMasters(List<Master> masters)
        {
            this.customFlowLayoutPanel1.Controls.Clear();
            foreach (var master in masters)
            {
                MasterInfoPanel masterPanel = new MasterInfoPanel(master.Id, master.Name, master.Surname, master.Specialization);
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

        private void MastersLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateMaster_Click(object sender, EventArgs e)
        {
            CreateMasterPage createMasterPage= new CreateMasterPage(LoadMasters);
            createMasterPage.ShowDialog();
        }

        private void MasterPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ServicesLabel_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

            }
            showServiceForm(this.Location);
            this.Hide();
        }
    }
}
