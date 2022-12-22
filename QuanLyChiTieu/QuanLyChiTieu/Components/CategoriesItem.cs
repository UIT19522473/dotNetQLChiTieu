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
    public partial class CategoriesItem : UserControl
    {
        public delegate void sendCategory(string name, int id);
        public sendCategory sendData;
        public CategoriesItem()
        {
            InitializeComponent();
        }
        public int idCategory;
        public string NameCategory
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }

        public int IdCategory
        {
            get { return this.idCategory; }
            set { this.idCategory = value; }
        }

        public string IconCategory
        {
            
            get { return btnIcon.IconChar.ToString(); }
            set {
                GetIconFWS getIcon = new GetIconFWS();
                getIcon.setIcon(value);

                btnIcon.IconChar = getIcon.icon;
                /*
                switch (value)
                {
                    case "House":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.House;
                        break;
                    case "MoneyBill":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
                        break;
                    case "Wrench":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Wrench;
                        break;
                    case "PiggyBank":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
                        break;
                    case "IceCream":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.IceCream;
                        break;
                    case "Baby":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Baby;
                        break;
                    case "Bolt":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Bolt;
                        break;
                    case "BuildingColumns":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.BuildingColumns;
                        break;
                    case "Car":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Car;
                        break;
                    case "GasPump":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.GasPump;
                        break;
                    case "Shirt":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Shirt;
                        break;
                    case "Gift":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Gift;
                        break;
                    case "CartShopping":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
                        break;
                    case "Briefcase":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
                        break;
                    case "PersonSwimming":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.PersonSwimming;
                        break;
                    case "Gamepad":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
                        break;
                    case "Heart":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Heart;
                        break;
                    case "NotesMedical":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
                        break;
                    case "Utensils":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Utensils;
                        break;
                    case "SackDollar":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
                        break;
                    case "PaintRoller":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.PaintRoller;
                        break;
                    case "Droplet":
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.Droplet;
                        break;
                    default:
                        btnIcon.IconChar = FontAwesome.Sharp.IconChar.House;
                        break;
                }*/
            }
        }

        public string BackGroundCategory
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

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void pnBackGround_MouseClick(object sender, MouseEventArgs e)
        {
            int id = this.IdCategory;
            //MessageBox.Show("click Category"+ id);
            sendData(this.NameCategory, this.IdCategory);
        }
    }
}
