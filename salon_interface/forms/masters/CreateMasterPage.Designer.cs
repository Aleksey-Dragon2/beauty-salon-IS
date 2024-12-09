namespace salon_interface
{
    partial class CreateMasterPage
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
            this.TitleMasters = new System.Windows.Forms.Label();
            this.choseSpecialization = new Guna.UI2.WinForms.Guna2ComboBox();
            this.masterSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.masterName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.choiseServicesList = new System.Windows.Forms.CheckedListBox();
            this.AcceptCreateButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeniedCreateButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleMasters
            // 
            this.TitleMasters.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleMasters.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.TitleMasters.Location = new System.Drawing.Point(0, 0);
            this.TitleMasters.Name = "TitleMasters";
            this.TitleMasters.Size = new System.Drawing.Size(813, 46);
            this.TitleMasters.TabIndex = 3;
            this.TitleMasters.Text = "Новый мастер";
            this.TitleMasters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choseSpecialization
            // 
            this.choseSpecialization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.choseSpecialization.BackColor = System.Drawing.Color.Transparent;
            this.choseSpecialization.BorderRadius = 8;
            this.choseSpecialization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.choseSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choseSpecialization.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.choseSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.choseSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choseSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.choseSpecialization.ItemHeight = 30;
            this.choseSpecialization.Location = new System.Drawing.Point(14, 61);
            this.choseSpecialization.Name = "choseSpecialization";
            this.choseSpecialization.Size = new System.Drawing.Size(241, 36);
            this.choseSpecialization.TabIndex = 4;
            // 
            // masterSurname
            // 
            this.masterSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterSurname.BorderRadius = 8;
            this.masterSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.masterSurname.DefaultText = "";
            this.masterSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.masterSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.masterSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.masterSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.masterSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.masterSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.masterSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.masterSurname.Location = new System.Drawing.Point(291, 61);
            this.masterSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.masterSurname.Name = "masterSurname";
            this.masterSurname.PasswordChar = '\0';
            this.masterSurname.PlaceholderText = "";
            this.masterSurname.SelectedText = "";
            this.masterSurname.Size = new System.Drawing.Size(228, 36);
            this.masterSurname.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.masterName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSurname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.masterSurname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.choseSpecialization, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSpecialization, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 106);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // masterName
            // 
            this.masterName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterName.BorderRadius = 8;
            this.masterName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.masterName.DefaultText = "";
            this.masterName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.masterName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.masterName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.masterName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.masterName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.masterName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.masterName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.masterName.Location = new System.Drawing.Point(563, 61);
            this.masterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.masterName.Name = "masterName";
            this.masterName.PasswordChar = '\0';
            this.masterName.PlaceholderText = "";
            this.masterName.SelectedText = "";
            this.masterName.Size = new System.Drawing.Size(228, 36);
            this.masterName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(650, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 26);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(355, 13);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(101, 26);
            this.labelSurname.TabIndex = 7;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecialization.Location = new System.Drawing.Point(55, 13);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(160, 26);
            this.labelSpecialization.TabIndex = 6;
            this.labelSpecialization.Text = "Специализация";
            this.labelSpecialization.Click += new System.EventHandler(this.labelSpecialization_Click);
            // 
            // choiseServicesList
            // 
            this.choiseServicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseServicesList.FormattingEnabled = true;
            this.choiseServicesList.Location = new System.Drawing.Point(14, 169);
            this.choiseServicesList.Name = "choiseServicesList";
            this.choiseServicesList.Size = new System.Drawing.Size(422, 204);
            this.choiseServicesList.TabIndex = 7;
            this.choiseServicesList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // AcceptCreateButton
            // 
            this.AcceptCreateButton.BorderRadius = 8;
            this.AcceptCreateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AcceptCreateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AcceptCreateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptCreateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AcceptCreateButton.FillColor = System.Drawing.Color.LightGray;
            this.AcceptCreateButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.AcceptCreateButton.ForeColor = System.Drawing.Color.Black;
            this.AcceptCreateButton.Location = new System.Drawing.Point(583, 384);
            this.AcceptCreateButton.Name = "AcceptCreateButton";
            this.AcceptCreateButton.Size = new System.Drawing.Size(180, 45);
            this.AcceptCreateButton.TabIndex = 8;
            this.AcceptCreateButton.Text = "Добавить";
            this.AcceptCreateButton.Click += new System.EventHandler(this.AcceptCreateButton_Click);
            // 
            // DeniedCreateButton
            // 
            this.DeniedCreateButton.BorderRadius = 8;
            this.DeniedCreateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeniedCreateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeniedCreateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeniedCreateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeniedCreateButton.FillColor = System.Drawing.Color.LightGray;
            this.DeniedCreateButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DeniedCreateButton.ForeColor = System.Drawing.Color.Black;
            this.DeniedCreateButton.Location = new System.Drawing.Point(75, 384);
            this.DeniedCreateButton.Name = "DeniedCreateButton";
            this.DeniedCreateButton.Size = new System.Drawing.Size(180, 45);
            this.DeniedCreateButton.TabIndex = 9;
            this.DeniedCreateButton.Text = "Отменить";
            this.DeniedCreateButton.Click += new System.EventHandler(this.DeniedCreateButton_Click);
            // 
            // CreateMasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(813, 454);
            this.Controls.Add(this.DeniedCreateButton);
            this.Controls.Add(this.AcceptCreateButton);
            this.Controls.Add(this.choiseServicesList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TitleMasters);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CreateMasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateMasterPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleMasters;
        private Guna.UI2.WinForms.Guna2ComboBox choseSpecialization;
        private Guna.UI2.WinForms.Guna2TextBox masterSurname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelSpecialization;
        private Guna.UI2.WinForms.Guna2TextBox masterName;
        private System.Windows.Forms.CheckedListBox choiseServicesList;
        private Guna.UI2.WinForms.Guna2Button AcceptCreateButton;
        private Guna.UI2.WinForms.Guna2Button DeniedCreateButton;
    }
}