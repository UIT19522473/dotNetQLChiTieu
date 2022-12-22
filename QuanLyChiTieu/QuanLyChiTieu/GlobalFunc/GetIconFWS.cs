using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChiTieu.GlobalFunc
{
    public class GetIconFWS
    {
        private IconChar Icon;
        public IconChar icon
        {
            get { return Icon; }    
            set { Icon = value; }
        }
        
        public void setIcon(string nameIcon)
        {
            this.Icon = new IconChar();
            this.Icon = FontAwesome.Sharp.IconChar.House;

            switch (nameIcon)
            {
                case "House":
                    this.Icon = FontAwesome.Sharp.IconChar.House;
                    break;
                
                case "MoneyBill":
                    this.Icon = FontAwesome.Sharp.IconChar.MoneyBill;
                    break;
                case "Wrench":
                    this.Icon = FontAwesome.Sharp.IconChar.Wrench;
                    break;
                case "PiggyBank":
                    this.Icon = FontAwesome.Sharp.IconChar.PiggyBank;
                    break;
                case "IceCream":
                    this.Icon = FontAwesome.Sharp.IconChar.IceCream;
                    break;
                case "Baby":
                    this.Icon = FontAwesome.Sharp.IconChar.Baby;
                    break;
                case "Bolt":
                    this.Icon = FontAwesome.Sharp.IconChar.Bolt;
                    break;
                case "BuildingColumns":
                    this.Icon = FontAwesome.Sharp.IconChar.BuildingColumns;
                    break;
                case "Car":
                    this.Icon = FontAwesome.Sharp.IconChar.Car;
                    break;
                case "GasPump":
                    this.Icon = FontAwesome.Sharp.IconChar.GasPump;
                    break;
                case "Shirt":
                    this.Icon = FontAwesome.Sharp.IconChar.Shirt;
                    break;
                case "Gift":
                    this.Icon = FontAwesome.Sharp.IconChar.Gift;
                    break;
                case "CartShopping":
                    this.Icon = FontAwesome.Sharp.IconChar.CartShopping;
                    break;
                case "Briefcase":
                    this.Icon = FontAwesome.Sharp.IconChar.Briefcase;
                    break;
                case "PersonSwimming":
                    this.Icon = FontAwesome.Sharp.IconChar.PersonSwimming;
                    break;
                case "Gamepad":
                    this.Icon = FontAwesome.Sharp.IconChar.Gamepad;
                    break;
                case "Heart":
                    this.Icon = FontAwesome.Sharp.IconChar.Heart;
                    break;
                case "NotesMedical":
                    this.Icon = FontAwesome.Sharp.IconChar.NotesMedical;
                    break;
                case "Utensils":
                    this.Icon = FontAwesome.Sharp.IconChar.Utensils;
                    break;
                case "SackDollar":
                    this.Icon = FontAwesome.Sharp.IconChar.SackDollar;
                    break;
                case "PaintRoller":
                    this.Icon = FontAwesome.Sharp.IconChar.PaintRoller;
                    break;
                case "Droplet":
                    this.Icon = FontAwesome.Sharp.IconChar.Droplet;
                    break;
                case "UserAlt":
                    this.Icon = FontAwesome.Sharp.IconChar.UserAlt;
                    break;
                default:
                    this.Icon = FontAwesome.Sharp.IconChar.House;
                    break;
            }
         
        }
    }
    
}
