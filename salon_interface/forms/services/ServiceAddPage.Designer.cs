using salon_interface.Models;
using ProjectName.api;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace salon_interface
{
    partial class ServiceAddPage
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

        public async void loadSpecialization()
        {
            List<Master> masters = await MasterApiHandler.GetMastersAsync();
            var specializations = new HashSet<string>();

            foreach (Master master in masters)
            {
                specializations.Add(master.Specialization);
                this.masters.Add(master);
            }

            this.ChoiseMasterSpezialization.Items.AddRange(specializations.ToArray());
            this.ChoiseMasterSpezialization.SelectedIndex = 0;
            this.ChoseMaster.Enabled = false;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleAddService = new System.Windows.Forms.Label();
            this.TableAddService = new System.Windows.Forms.TableLayoutPanel();
            this.AddPriceService = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddNameService = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChoseMaster = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ChoiseMasterSpezialization = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TableTitle = new System.Windows.Forms.TableLayoutPanel();
            this.TitlePriceService = new System.Windows.Forms.Label();
            this.TitleNameService = new System.Windows.Forms.Label();
            this.TitleMasterService = new System.Windows.Forms.Label();
            this.CancelAddServiceButton = new Guna.UI2.WinForms.Guna2Button();
            this.AcceptAddButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.TableAddService.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TableTitle.SuspendLayout();
            this.tableButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleAddService
            // 
            this.TitleAddService.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleAddService.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleAddService.Location = new System.Drawing.Point(0, 0);
            this.TitleAddService.Name = "TitleAddService";
            this.TitleAddService.Size = new System.Drawing.Size(870, 44);
            this.TitleAddService.TabIndex = 1;
            this.TitleAddService.Text = "Новая услуга";
            this.TitleAddService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableAddService
            // 
            this.TableAddService.ColumnCount = 3;
            this.TableAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.78571F));
            this.TableAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.09524F));
            this.TableAddService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableAddService.Controls.Add(this.AddPriceService, 2, 0);
            this.TableAddService.Controls.Add(this.AddNameService, 1, 0);
            this.TableAddService.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TableAddService.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableAddService.Location = new System.Drawing.Point(0, 92);
            this.TableAddService.Name = "TableAddService";
            this.TableAddService.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TableAddService.RowCount = 1;
            this.TableAddService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.TableAddService.Size = new System.Drawing.Size(870, 110);
            this.TableAddService.TabIndex = 3;
            // 
            // AddPriceService
            // 
            this.AddPriceService.Animated = true;
            this.AddPriceService.BorderColor = System.Drawing.Color.Black;
            this.AddPriceService.BorderRadius = 7;
            this.AddPriceService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddPriceService.DefaultText = "";
            this.AddPriceService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddPriceService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddPriceService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddPriceService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddPriceService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPriceService.Enabled = false;
            this.AddPriceService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddPriceService.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AddPriceService.ForeColor = System.Drawing.Color.Black;
            this.AddPriceService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddPriceService.Location = new System.Drawing.Point(738, 35);
            this.AddPriceService.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.AddPriceService.MaxLength = 5;
            this.AddPriceService.Name = "AddPriceService";
            this.AddPriceService.PasswordChar = '\0';
            this.AddPriceService.PlaceholderText = "";
            this.AddPriceService.SelectedText = "";
            this.AddPriceService.Size = new System.Drawing.Size(107, 40);
            this.AddPriceService.TabIndex = 1;
            this.AddPriceService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddServicePrice_KeyPress);
            // 
            // AddNameService
            // 
            this.AddNameService.Animated = true;
            this.AddNameService.BorderColor = System.Drawing.Color.Black;
            this.AddNameService.BorderRadius = 7;
            this.AddNameService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddNameService.DefaultText = "";
            this.AddNameService.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddNameService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddNameService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddNameService.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddNameService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNameService.Enabled = false;
            this.AddNameService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddNameService.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AddNameService.ForeColor = System.Drawing.Color.Black;
            this.AddNameService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddNameService.Location = new System.Drawing.Point(344, 35);
            this.AddNameService.Margin = new System.Windows.Forms.Padding(20, 30, 20, 30);
            this.AddNameService.MaxLength = 254;
            this.AddNameService.Name = "AddNameService";
            this.AddNameService.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.AddNameService.PasswordChar = '\0';
            this.AddNameService.PlaceholderText = "";
            this.AddNameService.SelectedText = "";
            this.AddNameService.Size = new System.Drawing.Size(364, 40);
            this.AddNameService.TabIndex = 0;
            this.AddNameService.TextChanged += new System.EventHandler(this.AddNameService_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ChoseMaster, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChoiseMasterSpezialization, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 94);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ChoseMaster
            // 
            this.ChoseMaster.BackColor = System.Drawing.Color.Transparent;
            this.ChoseMaster.BorderColor = System.Drawing.Color.Black;
            this.ChoseMaster.BorderRadius = 8;
            this.ChoseMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChoseMaster.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChoseMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoseMaster.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChoseMaster.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChoseMaster.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ChoseMaster.ForeColor = System.Drawing.Color.Black;
            this.ChoseMaster.ItemHeight = 30;
            this.ChoseMaster.Location = new System.Drawing.Point(3, 50);
            this.ChoseMaster.Name = "ChoseMaster";
            this.ChoseMaster.Size = new System.Drawing.Size(297, 36);
            this.ChoseMaster.TabIndex = 3;
            this.ChoseMaster.SelectedIndexChanged += new System.EventHandler(this.ChoseMaster_SelectedIndexChanged);
            // 
            // ChoiseMasterSpezialization
            // 
            this.ChoiseMasterSpezialization.BackColor = System.Drawing.Color.Transparent;
            this.ChoiseMasterSpezialization.BorderColor = System.Drawing.Color.Black;
            this.ChoiseMasterSpezialization.BorderRadius = 8;
            this.ChoiseMasterSpezialization.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChoiseMasterSpezialization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChoiseMasterSpezialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoiseMasterSpezialization.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChoiseMasterSpezialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChoiseMasterSpezialization.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ChoiseMasterSpezialization.ForeColor = System.Drawing.Color.Black;
            this.ChoiseMasterSpezialization.ItemHeight = 30;
            this.ChoiseMasterSpezialization.Items.AddRange(new object[] {
            "Специализация"});
            this.ChoiseMasterSpezialization.Location = new System.Drawing.Point(3, 3);
            this.ChoiseMasterSpezialization.Name = "ChoiseMasterSpezialization";
            this.ChoiseMasterSpezialization.Size = new System.Drawing.Size(297, 36);
            this.ChoiseMasterSpezialization.TabIndex = 2;
            this.ChoiseMasterSpezialization.SelectedIndexChanged += new System.EventHandler(this.ChoiseMasterSpezialization_SelectedIndexChanged);
            // 
            // TableTitle
            // 
            this.TableTitle.ColumnCount = 3;
            this.TableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.02104F));
            this.TableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.97896F));
            this.TableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.TableTitle.Controls.Add(this.TitlePriceService, 2, 0);
            this.TableTitle.Controls.Add(this.TitleNameService, 1, 0);
            this.TableTitle.Controls.Add(this.TitleMasterService, 0, 0);
            this.TableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableTitle.Location = new System.Drawing.Point(0, 44);
            this.TableTitle.Name = "TableTitle";
            this.TableTitle.RowCount = 1;
            this.TableTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableTitle.Size = new System.Drawing.Size(870, 48);
            this.TableTitle.TabIndex = 4;
            // 
            // TitlePriceService
            // 
            this.TitlePriceService.AutoSize = true;
            this.TitlePriceService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitlePriceService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitlePriceService.Location = new System.Drawing.Point(702, 0);
            this.TitlePriceService.Name = "TitlePriceService";
            this.TitlePriceService.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TitlePriceService.Size = new System.Drawing.Size(165, 48);
            this.TitlePriceService.TabIndex = 3;
            this.TitlePriceService.Text = "Цена";
            this.TitlePriceService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TitleNameService
            // 
            this.TitleNameService.AutoSize = true;
            this.TitleNameService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleNameService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleNameService.Location = new System.Drawing.Point(318, 0);
            this.TitleNameService.Name = "TitleNameService";
            this.TitleNameService.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TitleNameService.Size = new System.Drawing.Size(378, 48);
            this.TitleNameService.TabIndex = 2;
            this.TitleNameService.Text = "Название услуги";
            this.TitleNameService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TitleMasterService
            // 
            this.TitleMasterService.AutoSize = true;
            this.TitleMasterService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleMasterService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleMasterService.Location = new System.Drawing.Point(3, 0);
            this.TitleMasterService.Name = "TitleMasterService";
            this.TitleMasterService.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TitleMasterService.Size = new System.Drawing.Size(309, 48);
            this.TitleMasterService.TabIndex = 0;
            this.TitleMasterService.Text = "Выбор мастера";
            this.TitleMasterService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CancelAddServiceButton
            // 
            this.CancelAddServiceButton.BorderRadius = 8;
            this.CancelAddServiceButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelAddServiceButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelAddServiceButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelAddServiceButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelAddServiceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelAddServiceButton.FillColor = System.Drawing.Color.LightGray;
            this.CancelAddServiceButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CancelAddServiceButton.ForeColor = System.Drawing.Color.Black;
            this.CancelAddServiceButton.Location = new System.Drawing.Point(103, 13);
            this.CancelAddServiceButton.Name = "CancelAddServiceButton";
            this.CancelAddServiceButton.Size = new System.Drawing.Size(217, 45);
            this.CancelAddServiceButton.TabIndex = 6;
            this.CancelAddServiceButton.Text = "Отменить";
            this.CancelAddServiceButton.Click += new System.EventHandler(this.CancelAddServiceButton_Click);
            // 
            // AcceptAddButton
            // 
            this.AcceptAddButton.BorderRadius = 8;
            this.AcceptAddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AcceptAddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AcceptAddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptAddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AcceptAddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AcceptAddButton.FillColor = System.Drawing.Color.LightGray;
            this.AcceptAddButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AcceptAddButton.ForeColor = System.Drawing.Color.Black;
            this.AcceptAddButton.Location = new System.Drawing.Point(549, 13);
            this.AcceptAddButton.Name = "AcceptAddButton";
            this.AcceptAddButton.Size = new System.Drawing.Size(218, 45);
            this.AcceptAddButton.TabIndex = 5;
            this.AcceptAddButton.Text = "Применить";
            this.AcceptAddButton.Click += new System.EventHandler(this.AcceptAddButton_Click);
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 3;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableButtons.Controls.Add(this.CancelAddServiceButton, 0, 0);
            this.tableButtons.Controls.Add(this.AcceptAddButton, 2, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableButtons.Location = new System.Drawing.Point(0, 202);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.Padding = new System.Windows.Forms.Padding(100, 10, 100, 0);
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.Size = new System.Drawing.Size(870, 75);
            this.tableButtons.TabIndex = 7;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // errorLabel
            // 
            this.errorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(0, 277);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(870, 45);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // ServiceAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 362);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.tableButtons);
            this.Controls.Add(this.TableAddService);
            this.Controls.Add(this.TableTitle);
            this.Controls.Add(this.TitleAddService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServiceAddPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ServiceAddPage";
            this.TableAddService.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TableTitle.ResumeLayout(false);
            this.TableTitle.PerformLayout();
            this.tableButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleAddService;
        private System.Windows.Forms.TableLayoutPanel TableAddService;
        private Guna.UI2.WinForms.Guna2TextBox AddPriceService;
        private Guna.UI2.WinForms.Guna2TextBox AddNameService;
        private Guna.UI2.WinForms.Guna2ComboBox ChoiseMasterSpezialization;
        private System.Windows.Forms.TableLayoutPanel TableTitle;
        private System.Windows.Forms.Label TitlePriceService;
        private System.Windows.Forms.Label TitleNameService;
        private System.Windows.Forms.Label TitleMasterService;
        private Guna.UI2.WinForms.Guna2Button CancelAddServiceButton;
        private Guna.UI2.WinForms.Guna2Button AcceptAddButton;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox ChoseMaster;
        private ErrorProvider ErrorProvider;
        private Label errorLabel;
    }
}