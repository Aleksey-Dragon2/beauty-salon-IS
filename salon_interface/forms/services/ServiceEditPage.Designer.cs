using System.Runtime.CompilerServices;

namespace salon_interface
{
    partial class ServiceEditPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void FillEditData(string name, string price)
        {
            this.defaultName = name;
            this.EditNameService.Text= name;
            this.EditPriceService.Text= price;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleEditService = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.CloseFormButton = new System.Windows.Forms.Label();
            this.DeleteServiceButton = new Guna.UI2.WinForms.Guna2Button();
            this.AcceptEditButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EditPriceService = new Guna.UI2.WinForms.Guna2TextBox();
            this.EditNameService = new Guna.UI2.WinForms.Guna2TextBox();
            this.TitlePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleEditService
            // 
            this.TitleEditService.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleEditService.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleEditService.Location = new System.Drawing.Point(0, 0);
            this.TitleEditService.Name = "TitleEditService";
            this.TitleEditService.Size = new System.Drawing.Size(745, 44);
            this.TitleEditService.TabIndex = 0;
            this.TitleEditService.Text = "Редактирование услуги";
            this.TitleEditService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitlePanel
            // 
            this.TitlePanel.AutoSize = true;
            this.TitlePanel.Controls.Add(this.CloseFormButton);
            this.TitlePanel.Controls.Add(this.TitleEditService);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(745, 44);
            this.TitlePanel.TabIndex = 1;
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormButton.AutoSize = true;
            this.CloseFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseFormButton.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFormButton.Location = new System.Drawing.Point(707, 9);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(26, 26);
            this.CloseFormButton.TabIndex = 1;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            this.CloseFormButton.MouseEnter += new System.EventHandler(this.CloseFormButton_MouseEnter);
            this.CloseFormButton.MouseLeave += new System.EventHandler(this.CloseFormButton_MouseLeave);
            // 
            // DeleteServiceButton
            // 
            this.DeleteServiceButton.BorderRadius = 8;
            this.DeleteServiceButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteServiceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteServiceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteServiceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteServiceButton.FillColor = System.Drawing.Color.LightGray;
            this.DeleteServiceButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DeleteServiceButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteServiceButton.Location = new System.Drawing.Point(86, 186);
            this.DeleteServiceButton.Name = "DeleteServiceButton";
            this.DeleteServiceButton.Size = new System.Drawing.Size(180, 45);
            this.DeleteServiceButton.TabIndex = 4;
            this.DeleteServiceButton.Text = "Удалить";
            this.DeleteServiceButton.Click += new System.EventHandler(this.DeleteServiceButton_Click);
            // 
            // AcceptEditButton
            // 
            this.AcceptEditButton.BorderRadius = 8;
            this.AcceptEditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AcceptEditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AcceptEditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptEditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AcceptEditButton.FillColor = System.Drawing.Color.LightGray;
            this.AcceptEditButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AcceptEditButton.ForeColor = System.Drawing.Color.Black;
            this.AcceptEditButton.Location = new System.Drawing.Point(479, 186);
            this.AcceptEditButton.Name = "AcceptEditButton";
            this.AcceptEditButton.Size = new System.Drawing.Size(180, 45);
            this.AcceptEditButton.TabIndex = 3;
            this.AcceptEditButton.Text = "Применить";
            this.AcceptEditButton.Click += new System.EventHandler(this.AcceptEditButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.EditPriceService, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditNameService, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 95);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // EditPriceService
            // 
            this.EditPriceService.Animated = true;
            this.EditPriceService.BorderColor = System.Drawing.Color.Black;
            this.EditPriceService.BorderRadius = 7;
            this.EditPriceService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditPriceService.DefaultText = "";
            this.EditPriceService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EditPriceService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EditPriceService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EditPriceService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EditPriceService.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditPriceService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditPriceService.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditPriceService.ForeColor = System.Drawing.Color.Black;
            this.EditPriceService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditPriceService.Location = new System.Drawing.Point(580, 24);
            this.EditPriceService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditPriceService.MaxLength = 5;
            this.EditPriceService.Name = "EditPriceService";
            this.EditPriceService.PasswordChar = '\0';
            this.EditPriceService.PlaceholderText = "";
            this.EditPriceService.SelectedText = "";
            this.EditPriceService.Size = new System.Drawing.Size(132, 42);
            this.EditPriceService.TabIndex = 1;
            this.EditPriceService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditServicePrice_KeyPress);
            // 
            // EditNameService
            // 
            this.EditNameService.Animated = true;
            this.EditNameService.BorderColor = System.Drawing.Color.Black;
            this.EditNameService.BorderRadius = 7;
            this.EditNameService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditNameService.DefaultText = "";
            this.EditNameService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EditNameService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EditNameService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EditNameService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EditNameService.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditNameService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditNameService.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.EditNameService.ForeColor = System.Drawing.Color.Black;
            this.EditNameService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EditNameService.Location = new System.Drawing.Point(33, 24);
            this.EditNameService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditNameService.MaxLength = 254;
            this.EditNameService.Name = "EditNameService";
            this.EditNameService.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.EditNameService.PasswordChar = '\0';
            this.EditNameService.PlaceholderText = "";
            this.EditNameService.SelectedText = "";
            this.EditNameService.Size = new System.Drawing.Size(507, 42);
            this.EditNameService.TabIndex = 0;
            // 
            // ServiceEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(745, 303);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteServiceButton);
            this.Controls.Add(this.AcceptEditButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServiceEditPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ServiceAddPage";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleEditService;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label CloseFormButton;
        private Guna.UI2.WinForms.Guna2Button DeleteServiceButton;
        private Guna.UI2.WinForms.Guna2Button AcceptEditButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox EditPriceService;
        private Guna.UI2.WinForms.Guna2TextBox EditNameService;
    }
}