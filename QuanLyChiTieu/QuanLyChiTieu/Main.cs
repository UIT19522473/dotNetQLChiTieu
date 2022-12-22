using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using QuanLyChiTieu.Screens;
using Color = System.Drawing.Color;

namespace QuanLyChiTieu
{
    public partial class Main : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Main()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60); 
            panelMenu.Controls.Add(leftBorderBtn);

            defaultScreen();

        }
        //structs
        private struct RGBColors
        {
            public static Color Color1 = Color.FromArgb(172, 126, 241);
            public static Color Color2 = Color.FromArgb(249, 118, 176);
            public static Color Color3 = Color.FromArgb(253, 138, 114);
            public static Color Color4 = Color.FromArgb(95, 77, 221);
            public static Color Color5 = Color.FromArgb(249, 88, 155);
            public static Color Color6 = Color.FromArgb(24, 161, 251);
            
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;

                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon current child

                IconCurrentChild.IconChar = currentBtn.IconChar;
                IconCurrentChild.IconColor = color;
               
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(7, 5, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;

                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelChildForm.Text = currentBtn.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color1);
            OpenChildForm(new Home());


        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color2);
            OpenChildForm(new Transfer());
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color3);
            OpenChildForm(new Analyze());
        }



        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color5);
            OpenChildForm(new Setting());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color6);
            OpenChildForm(new Categories());
        }
        private void btnWallet_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color4);
            OpenChildForm(new Wallet());
        }
        private void defaultScreen()
        {
            ActivateButton(btnHome, RGBColors.Color1);
            OpenChildForm(new Home());
        }

        private void test1_Load(object sender, EventArgs e)
        {

        }


    }
}
