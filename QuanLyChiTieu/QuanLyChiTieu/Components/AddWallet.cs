using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu.Components
{
    public partial class AddWallet : Form
    {
        public delegate void sendDataForWallet(bool mode);
        public sendDataForWallet sendData;

        MasterMoneyEntities1 context;

        public AddWallet()
        {
            context = new MasterMoneyEntities1();
            InitializeComponent();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnPickColor.FillColor = colorDialog1.Color;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var colorBtnA = Int32.Parse(btnPickColor.FillColor.A.ToString());
            var colorBtnR = Int32.Parse(btnPickColor.FillColor.R.ToString());
            var colorBtnG = Int32.Parse(btnPickColor.FillColor.G.ToString());
            var colorBtnB = Int32.Parse(btnPickColor.FillColor.B.ToString());

            // MessageBox.Show(btnChooseIcon.IconChar.ToString() + "-" + btnPickColor.FillColor.ToString() + "-" + cmbType.Text.ToString());
            // btnTest.FillColor = Color.FromArgb(colorBtnA,colorBtnR, colorBtnG,colorBtnB);

            var wallet = new MyWallet()
            {
               Id = 1,
               Name = txtName.Text,
               Color = colorBtnA + "-" + colorBtnR + "-" + colorBtnG + "-" + colorBtnB,
            };
            context.MyWallets.Add(wallet);

            context.SaveChanges();
            sendData(true);
            this.Close();
        }
    }
}
