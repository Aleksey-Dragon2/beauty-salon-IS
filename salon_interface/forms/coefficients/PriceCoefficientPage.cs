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
        public PriceCoefficientPage()
        {
            InitializeComponent();
            loadCoefficients();
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
            float value = Convert.ToSingle(this.CoefficientValue.Text);
            await CoefficientApiHandler.CreateCoefficientAsync(value);
            loadCoefficients();
        }
    }
}
