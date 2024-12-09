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
    public partial class VisitsPage : Form
    {
        public VisitsPage()
        {
            InitializeComponent();
            loadFilters();
            TitleVisits_Click(null, null);
        }

        private async void TitleVisits_Click(object sender, EventArgs e)
        {
            this.VisitsPanel.Controls.Clear();
            List<Visit> visits = await VisitApiHandler.GetVisitAsync();
            foreach (Visit visit in visits)
            {
                VisitInfoPanel visitInfoPanel = new VisitInfoPanel(visit.Id, visit.Client_Name, visit.VisitDate.ToString(), visit.Status);
                visitInfoPanel.Dock = DockStyle.Top;
                this.VisitsPanel.Controls.Add(visitInfoPanel);
            }
        }

        private async void CreateVisit_Click(object sender, EventArgs e)
        {
            string name = this.ClientName.Text;
            string date = this.dateTimePicker1.Text.Replace('.','-');
            string status = "Ожидает";
            await VisitApiHandler.CreateVisitAsync(name, date, status);
        }
    }
}
