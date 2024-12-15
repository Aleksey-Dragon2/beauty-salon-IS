using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using ProjectName.api;
using salon_interface.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace salon_interface
{
    public class AddServiceMaster : System.Windows.Forms.UserControl
    {
        private CheckedListBox choiseServicesList;
        private Guna2Button AcceptAddButton;
        private Label titleLabel;

        private int id;

        public AddServiceMaster(int id)
        {
            InitializeComponent();
            loadServicesList();
            this.id = id;
        }
        public AddServiceMaster()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.choiseServicesList = new System.Windows.Forms.CheckedListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.AcceptAddButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // choiseServicesList
            // 
            this.choiseServicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseServicesList.FormattingEnabled = true;
            this.choiseServicesList.Location = new System.Drawing.Point(25, 69);
            this.choiseServicesList.Name = "choiseServicesList";
            this.choiseServicesList.Size = new System.Drawing.Size(473, 229);
            this.choiseServicesList.TabIndex = 8;
            this.choiseServicesList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(21, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(273, 22);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Выберите услуги для мастера: ";
            // 
            // AcceptAddButton
            // 
            this.AcceptAddButton.BorderRadius = 8;
            this.AcceptAddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AcceptAddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AcceptAddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptAddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AcceptAddButton.FillColor = System.Drawing.Color.LightGray;
            this.AcceptAddButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AcceptAddButton.ForeColor = System.Drawing.Color.Black;
            this.AcceptAddButton.Location = new System.Drawing.Point(170, 320);
            this.AcceptAddButton.Name = "AcceptAddButton";
            this.AcceptAddButton.Size = new System.Drawing.Size(180, 45);
            this.AcceptAddButton.TabIndex = 10;
            this.AcceptAddButton.Text = "Добавить";
            this.AcceptAddButton.Click += new System.EventHandler(this.AcceptAddButton_Click);
            // 
            // AddServiceMaster
            // 
            this.Controls.Add(this.AcceptAddButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.choiseServicesList);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "AddServiceMaster";
            this.Size = new System.Drawing.Size(515, 402);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = choiseServicesList.SelectedIndex;

            if (selectedIndex != -1)
            {
                choiseServicesList.SetItemChecked(selectedIndex, !choiseServicesList.GetItemChecked(selectedIndex));
                choiseServicesList.ClearSelected();
            }
        }
        private async void loadServicesList()
        {
            List<Service> services = await ServiceApiHandler.GetServicesAsync();
            foreach (Service service in services)
            {
                this.choiseServicesList.Items.AddRange(new object[] { $"{service.Name}" });
            }
        }

        private async void AcceptAddButton_Click(object sender, EventArgs e)
        {
            List<string> services = new List<string>();
            foreach (var item in this.choiseServicesList.CheckedItems)
            {
                services.Add(item.ToString());
            };
            await MasterApiHandler.AddMasterServices(this.id, services);
            this.Size = new Size(1, 1);
        }
    }
}
