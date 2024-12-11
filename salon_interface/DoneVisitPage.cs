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
            // Создаем Label для строки с услугой и ценой
            Label rowLabel = new Label();
            rowLabel.AutoSize = false; // Устанавливаем, чтобы управлять шириной
            rowLabel.Width = panel.Width; // Ширина равна ширине панели
            rowLabel.TextAlign = ContentAlignment.MiddleLeft; // Выравнивание текста
            rowLabel.Font = new Font("Times New Roman", 12); // Шрифт
            rowLabel.Dock = DockStyle.Top;

            // Формируем строку с точками
            string formattedText = FormatServiceRow(service, price, rowLabel.Width, rowLabel.Font);
            rowLabel.Text = formattedText;

            // Добавляем строку на панель
            panel.Controls.Add(rowLabel);
        }

        private string FormatServiceRow(string service, float price, int labelWidth, Font font)
        {
            // Рассчитываем количество точек между услугой и ценой
            string priceText = $"{price} byn";
            int totalDots = 100; // Базовое количество точек
            string dots = "...";

            using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                // Рассчитываем ширину текста услуги и цены
                float serviceWidth = g.MeasureString(service, font).Width;
                float priceWidth = g.MeasureString(priceText, font).Width;

                // Рассчитываем ширину доступного пространства для точек
                float availableWidth = labelWidth - serviceWidth - priceWidth;
                int dotsCount = (int)(availableWidth / g.MeasureString(".", font).Width);

                // Создаем строку с нужным количеством точек
                dots = new string('.', Math.Max(dotsCount, 0));
            }

            // Возвращаем отформатированную строку
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
