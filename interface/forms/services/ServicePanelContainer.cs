using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

public class ServicePanelContainer
{
    public Guna2Panel PanelService { get; private set; }
    public Label NameService { get; private set; }
    public Label PriceService { get; private set; }

    public ServicePanelContainer(string id, string serviceName, string servicePrice)
    {
        // Создание панели и настройка свойств
        PanelService = new Guna2Panel
        {
            AutoRoundedCorners = true,
            BackColor = Color.Transparent,
            BorderColor = Color.Transparent,
            BorderThickness = 1,
            BorderRadius = 18,
            Dock = DockStyle.Top,
            FillColor = Color.LightGray,
            Location = new Point(0, 0),
            Name = $"ServiceInfoPanel_{id}", // Название панели с Id
            Size = new Size(682, 30),
            TabIndex = 0,
            Cursor = Cursors.Hand

        };

        // Создание метки для имени услуги
        NameService = new Label
        {
            BackColor = Color.Transparent,
            Dock = DockStyle.Left,
            Font = new Font("Times New Roman", 12F),
            Location = new Point(0, 0),
            Name = $"ServiceInfoName_{id}", // Название метки имени с Id
            Padding = new Padding(20, 0, 0, 0),
            Size = new Size(578, 39),  // Левый блок занимает 578px
            TabIndex = 0,
            Text = serviceName,
            TextAlign = ContentAlignment.MiddleLeft,
            Cursor = Cursors.Hand
        };

        // Создание метки для цены услуги
        PriceService = new Label
        {
            BackColor = Color.Transparent,
            Dock = DockStyle.Right,  // Устанавливаем цену справа
            Font = new Font("Times New Roman", 12F),
            Location = new Point(578, 0),  // Располагаем справа от NameService
            Name = $"ServiceInfoPrice_{id}", // Название метки цены с Id
            Padding = new Padding(0, 0, 15, 0),
            Size = new Size(104, 39),  // Правый блок (цена) занимает 104px
            TabIndex = 1,
            Text = servicePrice,
            TextAlign = ContentAlignment.MiddleRight,
            Cursor = Cursors.Hand
        };

        // Добавление меток в панель
        PanelService.Controls.Add(PriceService);
        PanelService.Controls.Add(NameService);

        // Подключение общего обработчика клика
        AddClickEvent(PanelService);
        AddClickEvent(NameService);
        AddClickEvent(PriceService);

        // Подключение обработчиков событий для мыши
        AddMouseEvents(PanelService);
        AddMouseEvents(NameService);
        AddMouseEvents(PriceService);
    }

    private void AddClickEvent(Control control)
    {
        // Подписка на событие клика
        control.Click += OnControlClick;
    }

    private void AddMouseEvents(Control control)
    {
        // Подписка на события мыши
        control.MouseEnter += OnControlMouseEnter;
        control.MouseLeave += OnControlMouseLeave;
    }

    // Общий обработчик клика
    private void OnControlClick(object sender, EventArgs e)
    {
        Control clickedControl = (Control)sender;
        //MessageBox.Show($"Клик по элементу: {clickedControl.Name}", "Обработчик клика");
        int id=Convert.ToInt32(clickedControl.Name.Split('_')[1]);
        MessageBox.Show(id.ToString());
    }

    private void OnControlMouseEnter(object sender, EventArgs e)
    {

            PanelService.BorderColor = Color.Red;
        
    }

    private void OnControlMouseLeave(object sender, EventArgs e)
    {
        Control control = (Control)sender;

        if (control is Guna2Panel panel)
        {
            panel.BorderColor = Color.Transparent;
        }
        else
        {
            PanelService.BorderColor = Color.Transparent;
        }
    }
}
