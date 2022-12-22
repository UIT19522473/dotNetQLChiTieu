using FontAwesome.Sharp;
using QuanLyChiTieu.GlobalFunc;
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
    public partial class ItemTransfer : UserControl
    {
        public ItemTransfer()
        {
            InitializeComponent();
        }
        public IconChar iconItem;
        public string type = "In";
        public string NameItemTrans
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }
        public string MoneyItemTrans
        {
            get { return lbMoney.Text; }
            set { lbMoney.Text = value; }
        }
        public string DateTimeItemTrans
        {
            
            get { return lbDay.Text + "-" + lbMonthYear.Text; }
            set { string[] Time = value.Split('/',' ');
                    lbDay.Text = "Ngày "+ Time[1];
                    lbMonthYear.Text = Time[0] + " | " + Time[2]; 
            }
        }

        public string BackGroundItemTrans
        {
            get { return pnBackGround.BackColor.ToString(); }
            set
            {
                string[] arrColor = value.Split('-');
                int a = Int32.Parse(arrColor[0]);
                int r = Int32.Parse(arrColor[1]);
                int g = Int32.Parse(arrColor[2]);
                int b = Int32.Parse(arrColor[3]);
                if (a == 255 && r == 255 && g == 255 && b == 255)
                {
                    btnIcon.IconColor = Color.Black;
                    lbName.ForeColor = Color.Black;
                }
                btnIcon.BackColor = Color.FromArgb(a, r, g, b);
                pnBackGround.FillColor = Color.FromArgb(a, r, g, b);
            }
        }

        public string TypeItemTrans
        {
            get { return this.type; }
            set {
                if(value == "In")
                {
                    lbMoney.ForeColor = Color.Green;
                }
                else
                {
                    lbMoney.ForeColor = Color.Crimson;
                }
                this.type = value; 
            }
        }
  
        public string IconItemTrans
        {
            get { return btnIcon.IconChar.ToString(); }
            set
            {
                iconItem = new IconChar();
                GetIconFWS getIcon = new GetIconFWS();
                getIcon.setIcon(value);
                this.iconItem = getIcon.icon;
                btnIcon.IconChar = getIcon.icon;
            }
        }
    }
}
