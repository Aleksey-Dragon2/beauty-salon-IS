using Guna.UI2.WinForms;
using System.Windows.Forms;

public class ServicePanelContainer
{
    public Guna2Panel PanelService { get; private set; }
    public Label NameService { get; private set; }
    public Label PriceService { get; private set; }

    public ServicePanelContainer(string serviceName, string servicePrice)
    {
        // Создание панели и настройка свойств
        PanelService = new Guna2Panel
        {
            AutoRoundedCorners = true,
            BackColor = System.Drawing.Color.Transparent,
            BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
            BorderRadius = 18,
            Dock = System.Windows.Forms.DockStyle.Top,
            FillColor = System.Drawing.Color.LightGray,
            Location = new System.Drawing.Point(0, 0),
            Name = "PanelService",
            Size = new System.Drawing.Size(682, 39),
            TabIndex = 0
        };

        // Создание метки для имени услуги
        NameService = new Label
        {
            BackColor = System.Drawing.Color.Transparent,
            Dock = System.Windows.Forms.DockStyle.Left,
            Font = new System.Drawing.Font("Times New Roman", 12F),
            Location = new System.Drawing.Point(0, 0),
            Name = "NameService",
            Padding = new System.Windows.Forms.Padding(20, 0, 0, 0),
            Size = new System.Drawing.Size(578, 39),  // Левый блок занимает 578px
            TabIndex = 0,
            Text = serviceName,
            TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        };

        // Создание метки для цены услуги
        PriceService = new Label
        {
            BackColor = System.Drawing.Color.Transparent,
            Dock = System.Windows.Forms.DockStyle.Right,  // Устанавливаем цену справа
            Font = new System.Drawing.Font("Times New Roman", 12F),
            Location = new System.Drawing.Point(578, 0),  // Располагаем справа от NameService
            Name = "PriceService",
            Padding = new System.Windows.Forms.Padding(0, 0, 15, 0),
            Size = new System.Drawing.Size(104, 39),  // Правый блок (цена) занимает 104px
            TabIndex = 1,
            Text = servicePrice,
            TextAlign = System.Drawing.ContentAlignment.MiddleRight
        };

        // Добавление меток в панель
        PanelService.Controls.Add(NameService);
        PanelService.Controls.Add(PriceService);
    }
}
