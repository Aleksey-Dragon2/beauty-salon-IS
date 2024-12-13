using System;
using System.Windows.Forms;

namespace salon_interface
{
    public class Header : System.Windows.Forms.UserControl
    {
        public TableLayoutPanel HeaderTable;
        public Label ServicesLabel;
        public Label CoefficientsLabel;
        public Label VisitsLabel;
        public Label MastersLabel;

        private ServicesPage ServicesPage;
        private MasterPage MasterPage;
        private VisitsPage VisitsPage;
        private PriceCoefficientPage PriceCoefficientPage;

        private int lastWidth = 0;  // Переменная для хранения последнего размера ширины
        private int lastHeight = 0; // Переменная для хранения последнего размера высоты

        public Header()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.HeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.CoefficientsLabel = new System.Windows.Forms.Label();
            this.VisitsLabel = new System.Windows.Forms.Label();
            this.ServicesLabel = new System.Windows.Forms.Label();
            this.MastersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // ... (тот же код инициализации, что и раньше)

            // Обработчики событий для меток (клик)
            this.ServicesLabel.Click += new EventHandler(this.ServicesLabel_Click);
            this.MastersLabel.Click += new EventHandler(this.MastersLabel_Click);
            this.VisitsLabel.Click += new EventHandler(this.VisitsLabel_Click);
            this.CoefficientsLabel.Click += new EventHandler(this.CoefficientsLabel_Click);

            this.ResumeLayout(false);
        }

        private void ServicesLabel_Click(object sender, EventArgs e)
        {
            OpenForm(ref ServicesPage, new ServicesPage());
        }

        private void MastersLabel_Click(object sender, EventArgs e)
        {
            OpenForm(ref MasterPage, new MasterPage());
        }

        private void VisitsLabel_Click(object sender, EventArgs e)
        {
            OpenForm(ref VisitsPage, new VisitsPage());
        }

        private void CoefficientsLabel_Click(object sender, EventArgs e)
        {
            OpenForm(ref PriceCoefficientPage, new PriceCoefficientPage());
        }

        // Универсальный метод для проверки, создана ли уже форма
        private void OpenForm<T>(ref T page, T newPage) where T : Form
        {
            if (page == null || page.IsDisposed) // Проверяем, если форма пустая или была закрыта
            {
                page = newPage; // Создаём новый экземпляр формы
                page.TopLevel = false; // Убедитесь, что форма дочерняя
                this.Parent.Controls.Add(page); // Добавляем форму в родительский контейнер
                page.Show(); // Показываем форму

                // Сохраняем размеры текущей формы
                lastWidth = page.Width;
                lastHeight = page.Height;
            }
            else
            {
                page.BringToFront(); // Если форма уже открыта, просто выводим её на передний план
            }

            // Устанавливаем размер новой формы на основе последнего размера
            page.Width = lastWidth;
            page.Height = lastHeight;
        }
    }
}
