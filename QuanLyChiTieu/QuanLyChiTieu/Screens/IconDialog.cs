using FontAwesome.Sharp;
using QuanLyChiTieu.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu.Screens
{
    public partial class IconDialog : Form
    {
        
        public IconDialog()
        {
            InitializeComponent();
        }

        public delegate void sendDataForAddCategody(IconChar text);
        public sendDataForAddCategody sendData;

        public void LoadData (IconChar data)
        {
            //MessageBox.Show(data);
            if(data.ToString()!="")
            {
                sendData(data);
                this.Close();
            }
        }

        string[] arrIcon = {  "House","MoneyBill","Wrench","PiggyBank","IceCream","Baby","Bolt","BuildingColumns","Car",
        "GasPump","Shirt","Gift","CartShopping","Briefcase","PersonSwimming","Gamepad","Heart","NotesMedical",
        "Utensils","SackDollar","PaintRoller","Droplet", };

        private void IconDialog_Load(object sender, EventArgs e)
        {
       
            foreach (string i in arrIcon){
                iconItem x = new iconItem();
                x.sendData = new iconItem.sendDataForAddCategody(LoadData);
                x.NameIcon = i;
                pnIcon.Controls.Add(x);
            }
           

        }
    }
}
