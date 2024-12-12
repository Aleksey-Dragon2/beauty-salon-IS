using ProjectName.api;
using salon_interface.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salon_interface
{
    public partial class DoneVisitPage : Form
    {
        private int visit_id;
        public DoneVisitPage(int visit_id)
        {
            InitializeComponent();
            LoadServiceVisit(visit_id);
            this.visit_id = visit_id;
        }

        private async void LoadServiceVisit(int visit_id)
        {
            List<VisitInfo> visitInfos = await VisitApiHandler.GetVisitById(visit_id);
            this.ClientName.Text = visitInfos[0].Client_Name;
            this.VisitDate.Text = visitInfos[0].visit_date.ToString();
            float totalPrice = 0;
            foreach (VisitInfo visitInfo in visitInfos)
            {
                AddServiceRow(this.panel1, visitInfo.service_name, visitInfo.service_price);
                totalPrice += visitInfo.service_price;
            }
            this.totalPriceLabel.Text += $"{totalPrice} byn";
        }
        
        private void AddServiceRow(Panel panel, string service, float price)
        {
            Label rowLabel = new Label();
            rowLabel.AutoSize = false;
            rowLabel.Width = panel.Width;
            rowLabel.TextAlign = ContentAlignment.MiddleLeft;
            rowLabel.Font = new Font("Times New Roman", 12);
            rowLabel.Dock = DockStyle.Top;

            string formattedText = FormatServiceRow(service, price, rowLabel.Width, rowLabel.Font);
            rowLabel.Text = formattedText;

            panel.Controls.Add(rowLabel);
        }

        private string FormatServiceRow(string service, float price, int labelWidth, Font font)
        {
            string priceText = $"{price} byn";
            string dots = "...";

            using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                float serviceWidth = g.MeasureString(service, font).Width;
                float priceWidth = g.MeasureString(priceText, font).Width;

                float availableWidth = labelWidth - serviceWidth - priceWidth;
                int dotsCount = (int)(availableWidth / g.MeasureString(".", font).Width);

                dots = new string('.', Math.Max(dotsCount, 0));
            }
            return $"{service}{dots}{priceText}";
        }

        private async void DoneVisitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var fileStream = await VisitApiHandler.GetChequeFileAsync(this.visit_id);

                // Сохраняем во временную папку для открытия
                string tempPath = Path.Combine(Path.GetTempPath(), $"cheque_{this.visit_id}.pdf");
                using (var file = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
                {
                    fileStream.CopyTo(file);
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = tempPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
