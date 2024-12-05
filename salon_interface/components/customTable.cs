using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Windows.Forms;
using System;

namespace salon_interface
{
    public class CustomFlowLayoutPanel : FlowLayoutPanel
    {
        public int MaxItemsPerRow { get; set; } = 3;

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            int currentRowItems = 0;
            int currentRowTop = 0;
            int currentRowHeight = 0;

            foreach (Control control in Controls)
            {
                if (currentRowItems >= MaxItemsPerRow)
                {
                    // Переход на новую строку
                    currentRowItems = 0;
                    currentRowTop += currentRowHeight;
                    currentRowHeight = 0;
                }

                control.Top = currentRowTop;
                control.Left = currentRowItems * control.Width;

                currentRowHeight = Math.Max(currentRowHeight, control.Height);
                currentRowItems++;
            }
        }
    }
}