using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu.Components
{
    public partial class iconItem : UserControl
    {
        public delegate void sendDataForAddCategody(IconChar text);
        public sendDataForAddCategody sendData;
        public iconItem()
        {
            InitializeComponent();
        }
        public string NameIcon
        {
            
            get { return btnIcon.IconChar.ToString(); }
            set
            {
  
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
                }

                
            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(btnIcon.IconChar.ToString());
            if (sendData != null)
            {
                sendData(btnIcon.IconChar);
            }
        }
    }
}
