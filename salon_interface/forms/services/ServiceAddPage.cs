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
    public partial class ServiceAddPage : Form
    {
        public ServiceAddPage()
        {
            InitializeComponent();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseFormButton_MouseEnter(object sender, EventArgs e)
        {
            this.CloseFormButton.ForeColor = Color.Gray;
        }

        private void CloseFormButton_MouseLeave(object sender, EventArgs e)
        {
            this.CloseFormButton.ForeColor = Color.Black;
        }

    }
}
