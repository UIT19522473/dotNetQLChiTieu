namespace QuanLyChiTieu.Screens
{
    partial class IconDialog
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
            this.pnIcon = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnIcon
            // 
            this.pnIcon.AutoScroll = true;
            this.pnIcon.Location = new System.Drawing.Point(4, 12);
            this.pnIcon.Name = "pnIcon";
            this.pnIcon.Size = new System.Drawing.Size(856, 638);
            this.pnIcon.TabIndex = 0;
            // 
            // IconDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 653);
            this.Controls.Add(this.pnIcon);
            this.Name = "IconDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IconDialog";
            this.Load += new System.EventHandler(this.IconDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnIcon;
    }
}