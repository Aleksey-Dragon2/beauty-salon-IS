using Guna.UI2.WinForms.Enums;
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
using loadMasters = salon_interface.MasterPage.loadMasters;

namespace salon_interface
{
    public partial class MasterData : Form
    {
        private int master_id;
        private loadMasters loadMasters;

        public MasterData(int id, loadMasters loadMasters)
        {
            InitializeComponent();
            LoadData(id);
            this.master_id = id;
            this.loadMasters = loadMasters;
        }

        private async void LoadData(int id)
        {
            List<MasterStats> mastersStats = await MasterApiHandler.GetMasterStats(id);
            foreach (MasterStats stats in mastersStats)
            {
                this.MasterName.Text = stats.Master_Name;
                this.Specialization.Text += stats.Specialization;
                this.ServicesProvided.Text += stats.Total_Services.ToString();
                this.PopularService.Text += stats.Popular_Service;
                this.AveragePriceServices.Text += stats.Avg_Service_Price.ToString();

            }
        }

        private async void DeleteMasterButton_Click(object sender, EventArgs e)
        {
            await MasterApiHandler.DeleteMasterAsync(this.master_id);
            this.loadMasters();
            this.Close();
        }

        private void AddServiceMasterButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Size = new System.Drawing.Size(550, 450);
            AddServiceMaster addServiceMaster = new AddServiceMaster(master_id);
            addServiceMaster.SizeChanged += new System.EventHandler(this.close_form);
            this.Controls.Add(addServiceMaster);

        }

        private void close_form(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
