using FontAwesome.Sharp;
using QuanLyChiTieu.Screens;
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
    public partial class AddCategoryDialog : Form

    {

        public delegate void sendDataForCategory(bool mode);
        public sendDataForCategory sendData;
        //MasterMoneyEntities context;
        MasterMoneyEntities1 context;
        public AddCategoryDialog()
        {
            context = new MasterMoneyEntities1();
            InitializeComponent();
        }

        public void LoadDataColor(IconChar data)
        {
           // MessageBox.Show(data);
            btnChooseIcon.IconChar = data;
            //btnIconLast.NameIcon = data;
            //btnIconLast.Visible = true;

           // btnTest.IconChar = data;
        }

        private void btnChooseIcon_Click(object sender, EventArgs e)
        {
            IconDialog iconDialog = new IconDialog();
            iconDialog.sendData = new IconDialog.sendDataForAddCategody(LoadDataColor);
            iconDialog.ShowDialog();
        }

  

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*
            var category = new MyCategory()
            {
                Id = 1,
                Name = "Bill",
                Icon = "Gates",
                Type = "",


            };
            context.Students.Add(std);

            context.SaveChanges();*/

        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnPickColor.FillColor = colorDialog1.Color;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            var colorBtnA = Int32.Parse(btnPickColor.FillColor.A.ToString());
            var colorBtnR = Int32.Parse( btnPickColor.FillColor.R.ToString());
            var colorBtnG = Int32.Parse(btnPickColor.FillColor.G.ToString());
            var colorBtnB = Int32.Parse(btnPickColor.FillColor.B.ToString());
            

            // MessageBox.Show(btnChooseIcon.IconChar.ToString() + "-" + btnPickColor.FillColor.ToString() + "-" + cmbType.Text.ToString());
            // btnTest.FillColor = Color.FromArgb(colorBtnA,colorBtnR, colorBtnG,colorBtnB);

            var ctr = new MyCategory()
            {
                Id = 1,
                Name = txtName.Text,
                Icon = btnChooseIcon.IconChar.ToString(),
                Color = colorBtnA + "-" + colorBtnR + "-" + colorBtnG + "-" + colorBtnB,
                Type = cmbType.Text == "Thu nhập" ? "In" : "Out"

            };
            context.MyCategories.Add(ctr);

            context.SaveChanges();
            MessageBox.Show("thêm loại thành công");
            sendData(true);
            this.Close();
        }

    }
}
