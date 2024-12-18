﻿using ProjectName.api;
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
        private FormManager formManager;
        public delegate void UpdateVisitsInfo();
        public VisitsPage(FormManager formManager)
        {
            InitializeComponent();
            loadFilters();
            loadVisits();
            this.formManager = formManager;

            this.FormClosing += VisitsPage_FormClosing;
        }

        private void TitleVisits_Click(object sender, EventArgs e)
        {
            loadVisits();
        }

        private async void loadVisits()
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
        private void loadVisits(List<Visit> visits)
        {
            this.VisitsPanel.Controls.Clear();
            foreach (Visit visit in visits)
            {
                VisitInfoPanel visitInfoPanel = new VisitInfoPanel(visit.Id, visit.Client_Name, visit.VisitDate.ToString(), visit.Status);
                visitInfoPanel.Dock = DockStyle.Top;
                this.VisitsPanel.Controls.Add(visitInfoPanel);
            }
        }

        private void CreateVisit_Click(object sender, EventArgs e)
        {
            CreateVisitPage createVisitPage = new CreateVisitPage(this.loadVisits);
            createVisitPage.ShowDialog();
        }

        private void ServicesLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("ServicesPage");
        }

        private void MastersLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("MastersPage");
        }

        private void CoefficientsLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("PriceCoefficientPage");
        }
        private void VisitsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
