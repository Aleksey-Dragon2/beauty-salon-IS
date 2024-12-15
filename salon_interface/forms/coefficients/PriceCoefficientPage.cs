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
    public partial class PriceCoefficientPage : Form
    {
        private FormManager formManager;
        public PriceCoefficientPage(FormManager formManager)
        {
            InitializeComponent();
            loadCoefficients();

            this.formManager = formManager;

            this.FormClosing += CoefficientsPage_FormClosing;
        }
        
        private async void loadCoefficients()
        {
            List<Coefficient> coefficients = await CoefficientApiHandler.GetCoefficientAsync();
            foreach (Coefficient coefficient in coefficients)
            {
                CoefficientHistory coefficientHistory = new CoefficientHistory(coefficient.Application_Date.ToString("dd.MM.yyyy"), coefficient.Value);
                coefficientHistory.Dock = DockStyle.Top;
                this.HistoryPanel.Controls.Add(coefficientHistory);
                Panel panel = new Panel();
                panel.Dock = DockStyle.Top;
                panel.Size = new Size(1, 1);
                panel.BackColor = Color.Gray;
                this.HistoryPanel.Controls.Add(panel);
            }
        }

        private async void CreateCoefficient_Click(object sender, EventArgs e)
        {
            float value = Convert.ToSingle(this.CoefficientValue.Text.Replace('.',','));
            await CoefficientApiHandler.CreateCoefficientAsync(value);
            loadCoefficients();
        }

        private void AddServicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if (string.IsNullOrEmpty(this.CoefficientValue.Text))
                {
                    e.Handled = true;
                    return;
                }
                if (this.CoefficientValue.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void ServicesLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("ServicesPage");
        }

        private void MastersLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("MastersPage");
        }

        private void VisitsLabel_Click(object sender, EventArgs e)
        {
            formManager.ShowForm("VisitsPage");
        }

        private void CoefficientsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
