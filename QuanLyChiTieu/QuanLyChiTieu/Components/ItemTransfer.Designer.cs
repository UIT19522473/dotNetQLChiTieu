namespace QuanLyChiTieu.Components
{
    partial class ItemTransfer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIcon = new FontAwesome.Sharp.IconButton();
            this.pnBackGround = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbMonthYear = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbDay = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbMoney = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pnBackGround.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIcon
            // 
            this.btnIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIcon.IconChar = FontAwesome.Sharp.IconChar.NodeJs;
            this.btnIcon.IconColor = System.Drawing.Color.White;
            this.btnIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIcon.IconSize = 60;
            this.btnIcon.Location = new System.Drawing.Point(22, 10);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(80, 70);
            this.btnIcon.TabIndex = 2;
            this.btnIcon.UseVisualStyleBackColor = false;
            // 
            // pnBackGround
            // 
            this.pnBackGround.BackColor = System.Drawing.Color.Transparent;
            this.pnBackGround.Controls.Add(this.panel1);
            this.pnBackGround.Controls.Add(this.btnIcon);
            this.pnBackGround.FillColor = System.Drawing.Color.DarkKhaki;
            this.pnBackGround.Location = new System.Drawing.Point(3, 3);
            this.pnBackGround.Name = "pnBackGround";
            this.pnBackGround.Radius = 12;
            this.pnBackGround.ShadowColor = System.Drawing.Color.Black;
            this.pnBackGround.Size = new System.Drawing.Size(396, 92);
            this.pnBackGround.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.guna2Panel4);
            this.panel1.Controls.Add(this.guna2Panel3);
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Location = new System.Drawing.Point(104, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 80);
            this.panel1.TabIndex = 3;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.lbMonthYear);
            this.guna2Panel4.Location = new System.Drawing.Point(186, 49);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(94, 26);
            this.guna2Panel4.TabIndex = 9;
            // 
            // lbMonthYear
            // 
            this.lbMonthYear.AutoSize = true;
            this.lbMonthYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonthYear.ForeColor = System.Drawing.Color.Black;
            this.lbMonthYear.Location = new System.Drawing.Point(0, 0);
            this.lbMonthYear.Margin = new System.Windows.Forms.Padding(3, 100, 0, 0);
            this.lbMonthYear.Name = "lbMonthYear";
            this.lbMonthYear.Size = new System.Drawing.Size(86, 20);
            this.lbMonthYear.TabIndex = 1;
            this.lbMonthYear.Text = "12 | 2022";
            this.lbMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lbDay);
            this.guna2Panel3.Location = new System.Drawing.Point(186, 11);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(94, 26);
            this.guna2Panel3.TabIndex = 7;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.ForeColor = System.Drawing.Color.Black;
            this.lbDay.Location = new System.Drawing.Point(0, 0);
            this.lbDay.Margin = new System.Windows.Forms.Padding(3, 100, 0, 0);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(77, 20);
            this.lbDay.TabIndex = 1;
            this.lbDay.Text = "Ngày 19";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lbMoney);
            this.guna2Panel2.Location = new System.Drawing.Point(5, 44);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(170, 34);
            this.guna2Panel2.TabIndex = 8;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.ForeColor = System.Drawing.Color.Black;
            this.lbMoney.Location = new System.Drawing.Point(0, 0);
            this.lbMoney.Margin = new System.Windows.Forms.Padding(3, 100, 0, 0);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(64, 26);
            this.lbMoney.TabIndex = 1;
            this.lbMoney.Text = "1000";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbName);
            this.guna2Panel1.Location = new System.Drawing.Point(5, 8);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(170, 34);
            this.guna2Panel1.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(3, 100, 0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(102, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Quần áo";
            // 
            // ItemTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBackGround);
            this.Name = "ItemTransfer";
            this.Size = new System.Drawing.Size(403, 98);
            this.pnBackGround.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnIcon;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnBackGround;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label lbMonthYear;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lbDay;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lbMoney;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbName;
    }
}
