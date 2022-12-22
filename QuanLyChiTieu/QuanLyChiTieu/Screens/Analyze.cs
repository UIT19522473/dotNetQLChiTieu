using QuanLyChiTieu.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace QuanLyChiTieu.Screens
{
    public partial class Analyze : Form
    {
        private Form currentChildForm;
        public Analyze()
        {
            InitializeComponent();
            //OpenChildForm(new AnalyzeCash());
        }
        /*
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnShow.Controls.Add(childForm);
            pnShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }*/
       

        private void btnCategories_Click(object sender, EventArgs e)
        {
           // OpenChildForm(new AnalyzeCategories());
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
           // OpenChildForm(new AnalyzeCash());
        }

        private void Analyze_Load(object sender, EventArgs e)
        {
           
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent (IntPtr hwc, IntPtr hwp);

        //static extern InPtr SetPar

        private void btnDemo_Click(object sender, EventArgs e)
        {
            OpenFileDialog od  = new OpenFileDialog();
           /*if(od.ShowDialog() == DialogResult.OK)
            {
                //Process proc = Process.Start(od.FileName);
               

                //proc.Refresh();
                while (proc.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(500);
                    proc.Refresh();
                }
                SetParent(proc.MainWindowHandle, this.Handle);
            }*/
       

            Process proc = Process.Start("C:\\Users\\Tuan Nguyen\\Desktop\\PowerBiDemo\\DemoBI.pbix");
            Thread.Sleep(500);
            proc.WaitForInputIdle();
            SetParent(proc.MainWindowHandle, this.Handle);
        }
    }
}
