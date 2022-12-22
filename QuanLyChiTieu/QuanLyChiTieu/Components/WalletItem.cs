using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace QuanLyChiTieu.Components
{
    public partial class WalletItem : UserControl
    {
        public WalletItem()
        {
            InitializeComponent();
        }

        public string NameWallet {
            get { return lbName.Text; }
            set { lbName.Text = value; } 
        }

        public string pnColorWallet
        {
            get { return pnColor.BackColor.ToString(); }
            set { 
                //pnColor.BackColor;

                string[] arrColor = value.Split('-');
                int a = Int32.Parse(arrColor[0]);
                int r = Int32.Parse(arrColor[1]);
                int g = Int32.Parse(arrColor[2]);
                int b = Int32.Parse(arrColor[3]);
           
                pnColor.BackColor = Color.FromArgb(a, r, g, b);
                //pnBackGround.FillColor = Color.FromArgb(a, r, g, b);
            }
        }

    }
}
