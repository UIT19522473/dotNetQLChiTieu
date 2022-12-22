using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu.Components
{
    public partial class LegendChart : UserControl
    {
        public LegendChart()
        {
            InitializeComponent();
        }
        public string NameLegendChart
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        public string ColorLegendChart
        {
            get { return btnColor.FillColor.ToString(); }
            set {
                string[] arrCl = value.Split('-');
                int A = Int32.Parse(arrCl[0]);
                int R = Int32.Parse(arrCl[1]);
                int G = Int32.Parse(arrCl[2]);
                int B = Int32.Parse(arrCl[3]);
                btnColor.FillColor = Color.FromArgb(A, R, G, B);
                    
            }
        }
    }
}
