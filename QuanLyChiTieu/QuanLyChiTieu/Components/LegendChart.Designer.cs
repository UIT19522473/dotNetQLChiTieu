namespace QuanLyChiTieu.Components
{
    partial class LegendChart
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
            this.btnColor = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnColor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(5, 8);
            this.btnColor.Name = "btnColor";
            this.btnColor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnColor.Size = new System.Drawing.Size(18, 18);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "guna2CircleButton1";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 18);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbName);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(31, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 20);
            this.panel1.TabIndex = 2;
            // 
            // LegendChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnColor);
            this.Name = "LegendChart";
            this.Size = new System.Drawing.Size(129, 36);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnColor;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
    }
}
