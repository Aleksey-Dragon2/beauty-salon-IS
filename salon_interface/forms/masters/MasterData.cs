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

namespace salon_interface
{
    public partial class MasterData : Form
    {
        private int master_id;
        public MasterData(int id)
        {
            InitializeComponent();
            LoadData(id);
            this.master_id = id;
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

        private async void AcceptEditButton_Click(object sender, EventArgs e)
        {
            await MasterApiHandler.DeleteMasterAsync(this.master_id);
            this.Close();
        }

        private void CreateMasterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
