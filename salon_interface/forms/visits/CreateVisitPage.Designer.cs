namespace salon_interface
{
    partial class CreateVisitPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CreateVisit = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.choiseServicesList = new System.Windows.Forms.CheckedListBox();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ClientName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 62);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(742, 97);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата визита";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientName
            // 
            this.ClientName.BorderColor = System.Drawing.Color.Black;
            this.ClientName.BorderRadius = 3;
            this.ClientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientName.DefaultText = "";
            this.ClientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientName.FillColor = System.Drawing.SystemColors.Control;
            this.ClientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ClientName.ForeColor = System.Drawing.Color.Black;
            this.ClientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientName.Location = new System.Drawing.Point(3, 52);
            this.ClientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientName.Name = "ClientName";
            this.ClientName.PasswordChar = '\0';
            this.ClientName.PlaceholderText = "";
            this.ClientName.SelectedText = "";
            this.ClientName.Size = new System.Drawing.Size(314, 41);
            this.ClientName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя клиента";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy.MM.dd HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 38);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // CreateVisit
            // 
            this.CreateVisit.BorderRadius = 8;
            this.CreateVisit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateVisit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateVisit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateVisit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateVisit.FillColor = System.Drawing.Color.LightGray;
            this.CreateVisit.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.CreateVisit.ForeColor = System.Drawing.Color.Black;
            this.CreateVisit.Location = new System.Drawing.Point(551, 395);
            this.CreateVisit.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.CreateVisit.Name = "CreateVisit";
            this.CreateVisit.Size = new System.Drawing.Size(220, 43);
            this.CreateVisit.TabIndex = 6;
            this.CreateVisit.Text = "Добавить";
            this.CreateVisit.Click += new System.EventHandler(this.CreateVisit_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(827, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Создание визита";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choiseServicesList
            // 
            this.choiseServicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseServicesList.FormattingEnabled = true;
            this.choiseServicesList.Location = new System.Drawing.Point(32, 179);
            this.choiseServicesList.Name = "choiseServicesList";
            this.choiseServicesList.Size = new System.Drawing.Size(422, 204);
            this.choiseServicesList.TabIndex = 8;
            this.choiseServicesList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.BorderRadius = 8;
            this.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelButton.FillColor = System.Drawing.Color.LightGray;
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(54, 395);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(220, 43);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Отменить";
            // 
            // CreateVisitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.choiseServicesList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.CreateVisit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateVisitPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateVisitPage";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox ClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button CreateVisit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox choiseServicesList;
        private Guna.UI2.WinForms.Guna2Button CancelButton;
    }
}