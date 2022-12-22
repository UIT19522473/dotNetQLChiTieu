namespace QuanLyChiTieu.Components
{
    partial class CategoriesItem
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
            this.lbName = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnBackGround = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnIcon = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1.SuspendLayout();
            this.pnBackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Location = new System.Drawing.Point(100, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(3, 100, 0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(102, 26);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Quần áo";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lbName);
            this.guna2Panel1.Location = new System.Drawing.Point(179, 32);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(202, 34);
            this.guna2Panel1.TabIndex = 3;
            // 
            // pnBackGround
            // 
            this.pnBackGround.BackColor = System.Drawing.Color.Transparent;
            this.pnBackGround.Controls.Add(this.guna2Panel1);
            this.pnBackGround.Controls.Add(this.btnIcon);
            this.pnBackGround.FillColor = System.Drawing.Color.DarkKhaki;
            this.pnBackGround.Location = new System.Drawing.Point(3, 3);
            this.pnBackGround.Name = "pnBackGround";
            this.pnBackGround.Radius = 12;
            this.pnBackGround.ShadowColor = System.Drawing.Color.Black;
            this.pnBackGround.Size = new System.Drawing.Size(396, 92);
            this.pnBackGround.TabIndex = 3;
            this.pnBackGround.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnBackGround_MouseClick);
            // 
            // btnIcon
            // 
            this.btnIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            // CategoriesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnBackGround);
            this.Name = "CategoriesItem";
            this.Size = new System.Drawing.Size(404, 99);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnBackGround.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private FontAwesome.Sharp.IconButton btnIcon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnBackGround;
    }
}
