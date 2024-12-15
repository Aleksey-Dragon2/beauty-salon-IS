using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace salon_interface
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var formManager = new FormManager();

            // Создаем формы
            var ServicesPage = new ServicesPage(formManager);
            var MasterPage = new MasterPage(formManager);
            var VisitsPage = new VisitsPage(formManager);
            var PriceCoefficientPage = new PriceCoefficientPage(formManager);

            // Регистрируем формы в менеджере
            formManager.RegisterForm("ServicesPage", ServicesPage);
            formManager.RegisterForm("MastersPage", MasterPage);
            formManager.RegisterForm("VisitsPage", VisitsPage);
            formManager.RegisterForm("PriceCoefficientPage", PriceCoefficientPage);

            // Показываем начальную форму
            formManager.ShowForm("ServicesPage");

            // Запускаем приложение
            Application.Run();
        }
    }
}
