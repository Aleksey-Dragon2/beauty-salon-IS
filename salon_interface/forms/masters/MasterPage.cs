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
using ShowServiceForm = salon_interface.ServicesPage.ShowServiceForm;

namespace salon_interface
{
    public partial class MasterPage : Form
    {
        private ShowServiceForm showServiceForm;
        public MasterPage(ShowServiceForm showServiceForm)
        {
            InitializeComponent();
            LoadMasters();
            this.showServiceForm = showServiceForm;
        }

        public async void LoadMasters()
        {
            List<Master> masters = await MasterApiHandler.GetMastersAsync();
            foreach (var master in masters)
            {
                MasterInfoPanel masterPanel = new MasterInfoPanel(master.Id, master.Name, master.Surname, master.Specialization);
                MasterFilterItem masterFilter = new MasterFilterItem(master.Specialization);
                masterFilter.Width = masterFilter.ItemText.Width + 20;
                masterFilter.ItemText.AutoSize = false;
                masterFilter.ItemText.Dock = DockStyle.Fill;


                this.FilterPanel.Controls.Add(masterFilter);
                this.customFlowLayoutPanel1.Controls.Add(masterPanel);
            }
        }

        private void MastersLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateMaster_Click(object sender, EventArgs e)
        {
            CreateMasterPage createMasterPage= new CreateMasterPage();
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
