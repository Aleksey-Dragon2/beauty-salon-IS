using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using ProjectName.api;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace salon_interface
{
    public class CoefficientHistory : System.Windows.Forms.UserControl
    {
        public Panel CoefficientPanel;
        public Label ValueLabel;
        public Label DateLabel;
        public CoefficientHistory(string date, string value)
        {
            InitializeComponent();
            this.DateLabel.Text = date;
            this.ValueLabel.Text = value;
        }
        public CoefficientHistory()
        {
            InitializeComponent();
            this.CoefficientPanel.BackColor= Color.LightGray;
        }

        private void InitializeComponent()
        {
            this.CoefficientPanel = new System.Windows.Forms.Panel();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CoefficientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValueLabel
            // 
            this.ValueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueLabel.Location = new System.Drawing.Point(303, 0);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(160, 60);
            this.ValueLabel.TabIndex = 1;
            this.ValueLabel.Text = "Значение";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Right;
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(10, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(160, 60);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Дата применения";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Left;
            // 
            // CoefficientPanel
            // 
            this.CoefficientPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CoefficientPanel.Controls.Add(this.ValueLabel);
            this.CoefficientPanel.Controls.Add(this.DateLabel);
            this.CoefficientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoefficientPanel.Location = new System.Drawing.Point(0, 0);
            this.CoefficientPanel.Name = "CoefficientPanel";
            this.CoefficientPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.CoefficientPanel.Size = new System.Drawing.Size(473, 60);
            this.CoefficientPanel.TabIndex = 0;
            // 
            // CoefficientHistory
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.CoefficientPanel);
            this.Name = "CoefficientHistory";
            this.Size = new System.Drawing.Size(473, 60);
            this.CoefficientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
