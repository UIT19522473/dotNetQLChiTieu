namespace QuanLyChiTieu.Screens
{
    partial class Home
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
            this.label7 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pnTransfer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTest = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDay = new Guna.UI2.WinForms.Guna2Button();
            this.btnWeek = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnYear = new Guna.UI2.WinForms.Guna2Button();
            this.dtpkDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnLegendChart = new System.Windows.Forms.FlowLayoutPanel();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnChiPhi = new System.Windows.Forms.FlowLayoutPanel();
            this.prcMoney = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnIncome = new Guna.UI2.WinForms.Guna2Button();
            this.btnExpense = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbBlank = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMoneyOut = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMoneyIn = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSelectWallet = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnColor = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(8, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Giao dịch";
            // 
            // panelHeader
            // 
            this.panelHeader.AutoScroll = true;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.panelHeader.Controls.Add(this.pnTransfer);
            this.panelHeader.Controls.Add(this.label7);
            this.panelHeader.Location = new System.Drawing.Point(915, 116);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(444, 673);
            this.panelHeader.TabIndex = 21;
            // 
            // pnTransfer
            // 
            this.pnTransfer.AutoScroll = true;
            this.pnTransfer.Location = new System.Drawing.Point(2, 53);
            this.pnTransfer.Name = "pnTransfer";
            this.pnTransfer.Size = new System.Drawing.Size(434, 612);
            this.pnTransfer.TabIndex = 21;
            // 
            // pnTest
            // 
            this.pnTest.AutoScroll = true;
            this.pnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.pnTest.Location = new System.Drawing.Point(1120, 61);
            this.pnTest.Name = "pnTest";
            this.pnTest.Size = new System.Drawing.Size(224, 51);
            this.pnTest.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDay);
            this.panel3.Controls.Add(this.btnWeek);
            this.panel3.Controls.Add(this.btnMonth);
            this.panel3.Controls.Add(this.btnYear);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(12, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 40);
            this.panel3.TabIndex = 22;
            // 
            // btnDay
            // 
            this.btnDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.btnDay.BorderRadius = 12;
            this.btnDay.BorderThickness = 1;
            this.btnDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.btnDay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.ForeColor = System.Drawing.Color.White;
            this.btnDay.Location = new System.Drawing.Point(383, 0);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(125, 40);
            this.btnDay.TabIndex = 19;
            this.btnDay.Text = "Ngày";
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.btnWeek.BorderRadius = 12;
            this.btnWeek.BorderThickness = 1;
            this.btnWeek.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWeek.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWeek.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWeek.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWeek.FillColor = System.Drawing.Color.Silver;
            this.btnWeek.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeek.ForeColor = System.Drawing.Color.White;
            this.btnWeek.Location = new System.Drawing.Point(514, 0);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(125, 40);
            this.btnWeek.TabIndex = 18;
            this.btnWeek.Text = "Tuần";
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.btnMonth.BorderRadius = 12;
            this.btnMonth.BorderThickness = 1;
            this.btnMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonth.FillColor = System.Drawing.Color.Silver;
            this.btnMonth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.Location = new System.Drawing.Point(645, 0);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(125, 40);
            this.btnMonth.TabIndex = 17;
            this.btnMonth.Text = "Tháng";
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnYear
            // 
            this.btnYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.btnYear.BorderRadius = 12;
            this.btnYear.BorderThickness = 1;
            this.btnYear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYear.FillColor = System.Drawing.Color.Silver;
            this.btnYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(776, 0);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(125, 40);
            this.btnYear.TabIndex = 16;
            this.btnYear.Text = "Năm";
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.BorderRadius = 12;
            this.dtpkDate.Checked = true;
            this.dtpkDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpkDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.dtpkDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkDate.Location = new System.Drawing.Point(0, 0);
            this.dtpkDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(308, 40);
            this.dtpkDate.TabIndex = 15;
            this.dtpkDate.Value = new System.DateTime(2022, 12, 21, 0, 0, 0, 0);
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.pnLegendChart);
            this.panel1.Controls.Add(this.pieChart);
            this.panel1.Location = new System.Drawing.Point(3, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 673);
            this.panel1.TabIndex = 17;
            // 
            // pnLegendChart
            // 
            this.pnLegendChart.AutoScroll = true;
            this.pnLegendChart.Location = new System.Drawing.Point(452, 488);
            this.pnLegendChart.Name = "pnLegendChart";
            this.pnLegendChart.Size = new System.Drawing.Size(457, 177);
            this.pnLegendChart.TabIndex = 1;
            // 
            // pieChart
            // 
            this.pieChart.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pieChart.Location = new System.Drawing.Point(402, 31);
            this.pieChart.Name = "pieChart";
            this.pieChart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.pieChart.Size = new System.Drawing.Size(507, 443);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.pnChiPhi);
            this.panel2.Controls.Add(this.prcMoney);
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Controls.Add(this.btnIncome);
            this.panel2.Controls.Add(this.btnExpense);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 662);
            this.panel2.TabIndex = 9;
            // 
            // pnChiPhi
            // 
            this.pnChiPhi.AutoScroll = true;
            this.pnChiPhi.Location = new System.Drawing.Point(54, 147);
            this.pnChiPhi.Name = "pnChiPhi";
            this.pnChiPhi.Size = new System.Drawing.Size(333, 300);
            this.pnChiPhi.TabIndex = 30;
            // 
            // prcMoney
            // 
            this.prcMoney.BorderRadius = 12;
            this.prcMoney.FillColor = System.Drawing.Color.LimeGreen;
            this.prcMoney.Location = new System.Drawing.Point(22, 18);
            this.prcMoney.Name = "prcMoney";
            this.prcMoney.ProgressColor = System.Drawing.Color.Crimson;
            this.prcMoney.ProgressColor2 = System.Drawing.Color.Crimson;
            this.prcMoney.Size = new System.Drawing.Size(351, 30);
            this.prcMoney.TabIndex = 24;
            this.prcMoney.Text = "guna2ProgressBar1";
            this.prcMoney.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.prcMoney.Value = 60;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 465);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(354, 18);
            this.guna2HtmlLabel1.TabIndex = 29;
            this.guna2HtmlLabel1.Text = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            // 
            // btnIncome
            // 
            this.btnIncome.BorderColor = System.Drawing.Color.White;
            this.btnIncome.BorderRadius = 16;
            this.btnIncome.BorderThickness = 1;
            this.btnIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.btnIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Location = new System.Drawing.Point(206, 573);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(160, 45);
            this.btnIncome.TabIndex = 27;
            this.btnIncome.Text = "+ Thu nhập";
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.BorderColor = System.Drawing.Color.White;
            this.btnExpense.BorderRadius = 16;
            this.btnExpense.BorderThickness = 1;
            this.btnExpense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExpense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExpense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExpense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExpense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.btnExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.ForeColor = System.Drawing.Color.White;
            this.btnExpense.Location = new System.Drawing.Point(17, 573);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(160, 45);
            this.btnExpense.TabIndex = 26;
            this.btnExpense.Text = "+ Chi phí";
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lbBlank);
            this.panel6.Location = new System.Drawing.Point(17, 485);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 29);
            this.panel6.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Còn lại";
            // 
            // lbBlank
            // 
            this.lbBlank.AutoSize = true;
            this.lbBlank.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlank.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbBlank.Location = new System.Drawing.Point(282, 0);
            this.lbBlank.Name = "lbBlank";
            this.lbBlank.Size = new System.Drawing.Size(72, 25);
            this.lbBlank.TabIndex = 11;
            this.lbBlank.Text = "10000";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lbMoneyOut);
            this.panel5.Location = new System.Drawing.Point(22, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(349, 29);
            this.panel5.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chi phí";
            // 
            // lbMoneyOut
            // 
            this.lbMoneyOut.AutoSize = true;
            this.lbMoneyOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMoneyOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyOut.ForeColor = System.Drawing.Color.Crimson;
            this.lbMoneyOut.Location = new System.Drawing.Point(271, 0);
            this.lbMoneyOut.Name = "lbMoneyOut";
            this.lbMoneyOut.Size = new System.Drawing.Size(78, 25);
            this.lbMoneyOut.TabIndex = 11;
            this.lbMoneyOut.Text = "90.000";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbMoneyIn);
            this.panel4.Location = new System.Drawing.Point(22, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 29);
            this.panel4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thu nhập";
            // 
            // lbMoneyIn
            // 
            this.lbMoneyIn.AutoSize = true;
            this.lbMoneyIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMoneyIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyIn.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbMoneyIn.Location = new System.Drawing.Point(259, 0);
            this.lbMoneyIn.Name = "lbMoneyIn";
            this.lbMoneyIn.Size = new System.Drawing.Size(90, 25);
            this.lbMoneyIn.TabIndex = 11;
            this.lbMoneyIn.Text = "100.000";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.btnSelectWallet);
            this.guna2Panel1.Controls.Add(this.iconButton3);
            this.guna2Panel1.Controls.Add(this.btnColor);
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Panel1.Location = new System.Drawing.Point(1120, 9);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(224, 50);
            this.guna2Panel1.TabIndex = 29;
            // 
            // btnSelectWallet
            // 
            this.btnSelectWallet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectWallet.FlatAppearance.BorderSize = 0;
            this.btnSelectWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectWallet.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnSelectWallet.IconColor = System.Drawing.Color.Black;
            this.btnSelectWallet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectWallet.IconSize = 32;
            this.btnSelectWallet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectWallet.Location = new System.Drawing.Point(14, 2);
            this.btnSelectWallet.Name = "btnSelectWallet";
            this.btnSelectWallet.Size = new System.Drawing.Size(188, 46);
            this.btnSelectWallet.TabIndex = 26;
            this.btnSelectWallet.Text = "Tất cả ví";
            this.btnSelectWallet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectWallet.UseVisualStyleBackColor = false;
            this.btnSelectWallet.Click += new System.EventHandler(this.btnSelectWallet_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 24;
            this.iconButton3.Location = new System.Drawing.Point(200, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(22, 46);
            this.iconButton3.TabIndex = 28;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(119)))), ((int)(((byte)(235)))));
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnColor.IconColor = System.Drawing.Color.Black;
            this.btnColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnColor.Location = new System.Drawing.Point(2, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(14, 46);
            this.btnColor.TabIndex = 27;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(512, 278);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(8, 8);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 790);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnTest);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelHeader;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMoneyIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMoneyOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbBlank;
        private Guna.UI2.WinForms.Guna2Button btnIncome;
        private Guna.UI2.WinForms.Guna2Button btnExpense;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkDate;
        private Guna.UI2.WinForms.Guna2Button btnDay;
        private Guna.UI2.WinForms.Guna2Button btnWeek;
        private Guna.UI2.WinForms.Guna2Button btnMonth;
        private Guna.UI2.WinForms.Guna2Button btnYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ProgressBar prcMoney;
        private LiveCharts.WinForms.PieChart pieChart;
        private System.Windows.Forms.Panel pnTest;
        private FontAwesome.Sharp.IconButton btnSelectWallet;
        private FontAwesome.Sharp.IconButton btnColor;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel pnChiPhi;
        private System.Windows.Forms.FlowLayoutPanel pnLegendChart;
        private System.Windows.Forms.FlowLayoutPanel pnTransfer;
    }
}