namespace QuanLyChiTieu
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.IconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnWallet = new FontAwesome.Sharp.IconButton();
            this.btnChart = new FontAwesome.Sharp.IconButton();
            this.btnTransfer = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnWallet);
            this.panelMenu.Controls.Add(this.btnChart);
            this.panelMenu.Controls.Add(this.btnTransfer);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(222, 853);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(222, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.labelChildForm);
            this.panel1.Controls.Add(this.IconCurrentChild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(222, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 63);
            this.panel1.TabIndex = 1;
            // 
            // labelChildForm
            // 
            this.labelChildForm.AutoSize = true;
            this.labelChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelChildForm.Location = new System.Drawing.Point(57, 18);
            this.labelChildForm.Name = "labelChildForm";
            this.labelChildForm.Size = new System.Drawing.Size(84, 20);
            this.labelChildForm.TabIndex = 1;
            this.labelChildForm.Text = "Trang chủ";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(222, 63);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1360, 790);
            this.panelDesktop.TabIndex = 2;
            // 
            // IconCurrentChild
            // 
            this.IconCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.IconCurrentChild.ForeColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChild.IconColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChild.Location = new System.Drawing.Point(18, 12);
            this.IconCurrentChild.Name = "IconCurrentChild";
            this.IconCurrentChild.Size = new System.Drawing.Size(33, 32);
            this.IconCurrentChild.TabIndex = 0;
            this.IconCurrentChild.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 793);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(222, 60);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Thiết lập";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWallet.FlatAppearance.BorderSize = 0;
            this.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWallet.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnWallet.IconColor = System.Drawing.Color.Gainsboro;
            this.btnWallet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWallet.IconSize = 32;
            this.btnWallet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWallet.Location = new System.Drawing.Point(0, 320);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnWallet.Size = new System.Drawing.Size(222, 60);
            this.btnWallet.TabIndex = 4;
            this.btnWallet.Text = "Ví của tôi";
            this.btnWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWallet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWallet.UseVisualStyleBackColor = true;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // btnChart
            // 
            this.btnChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChart.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnChart.IconColor = System.Drawing.Color.Gainsboro;
            this.btnChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChart.IconSize = 32;
            this.btnChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChart.Location = new System.Drawing.Point(0, 260);
            this.btnChart.Name = "btnChart";
            this.btnChart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChart.Size = new System.Drawing.Size(222, 60);
            this.btnChart.TabIndex = 3;
            this.btnChart.Text = "Thống kê";
            this.btnChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransfer.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnTransfer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTransfer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransfer.IconSize = 32;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(0, 200);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTransfer.Size = new System.Drawing.Size(222, 60);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Giao dịch";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(222, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnWallet;
        private FontAwesome.Sharp.IconButton btnChart;
        private FontAwesome.Sharp.IconButton btnTransfer;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChild;
        private System.Windows.Forms.Label labelChildForm;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

