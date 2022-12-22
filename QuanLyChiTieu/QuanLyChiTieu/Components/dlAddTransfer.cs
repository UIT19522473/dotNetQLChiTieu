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
    public partial class dlAddTransfer : Form
    {

        MasterMoneyEntities1 context;
        List<MyCategory> Categories;
        List<MyWallet> Wallets;
        bool typeRadio = true;

        int idWallet = 0;
        int idCategory = 0;
        bool openCmb = false;
        public string type = "In";
        public dlAddTransfer()
        {
            context = new MasterMoneyEntities1();

            InitializeComponent();

        }

        public dlAddTransfer(string type)
        {
            context = new MasterMoneyEntities1();

            InitializeComponent();
            this.type = type;
            if(type == "In")
            {
                cbIncome.Checked = true;

            }
            else
            {
                cbExpense.Checked = true;
            }
        }

        public void getCategory(string name,int id)
        {
            btnChooseCategory.Text = name;
            btnChooseCategory.Font = new Font(btnChooseCategory.Font, FontStyle.Bold);
            btnChooseCategory.ForeColor = Color.Black;
           // btnTest.Font = new Font(btnTest.Font, FontStyle.Bold);
            idCategory = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // int indexCategory = Categories.FindIndex(a => a.Name == cmbCategories.Text);
           // int indexWallet = Wallet.FindIndex(a => a.Name == cmbWallet.Text);
            string Type = cbIncome.Checked ? "Income" : "Expense";
            //int Id  = myTypes.Max(t => t.Age);
            // MessageBox.Show(indexCategory.ToString());

            /*
            var trans = new MyTransfer()
            {
                
                Id = 0,
                Type = Type,
                Date = dtpkTime.Value,
                Categories = indexCategory,
                Wallet = indexWallet,
                Amount = Int32.Parse(txtAmount.Text),
                Note = txtNote.Text

            };
            context.MyTransfers.Add(trans);
            context.SaveChanges();
            */
        }

        void LoadCategoriesAndWallet()
        {
            /*
            Categories = context.MyCategories
                        .SqlQuery("Select * from MyCategory")
                        .ToList<MyCategory>();
          //  MessageBox.Show(Categories.Count().ToString());

             Wallets = context.MyWallets
                      .SqlQuery("Select * from MyWallet")
                      .ToList<MyWallet>();

            cmbCategories.Items.Clear();
            cmbWallet.Items.Clear();
            foreach(var i in Categories){
                cmbCategories.Text = (Categories[0].Name);
                cmbCategories.Items.Add(i.Name);
            }
      
            foreach (var j in Wallets)
            {
                cmbWallet.Text = (Wallets[0].Name);
                cmbWallet.Items.Add(j.Name);
            }
            */
        }

        private void dlAddTransfer_Load(object sender, EventArgs e)
        {
            LoadCategoriesAndWallet();
            var myWallet = context.MyWallets
                        .SqlQuery("Select * from MyWallet")
                        .ToList<MyWallet>();

            foreach (MyWallet i in myWallet)
            {
                Panel pnX = createSelectCmbWallet(i);

                if (pnTest.Height < 100)
                {

                    pnTest.Height += 60;
                }

                pnTest.Controls.Add(pnX);
            }

        }

        private Panel createSelectCmbWallet(MyWallet i)
        {
            string[] arrColor = i.Color.Split('-');
            int a = Int32.Parse(arrColor[0]);
            int r = Int32.Parse(arrColor[1]);
            int g = Int32.Parse(arrColor[2]);
            int b = Int32.Parse(arrColor[3]);



            Panel pnColor = new Panel();
            pnColor.Width = 10;
            pnColor.Height = 50;
            pnColor.BackColor = Color.FromArgb(a, r, g, b);
            pnColor.Dock = DockStyle.Right;

            Panel pnItem = new Panel();
            pnItem.Width = 180;
            pnItem.Height = 50;
            pnItem.Controls.Add(pnColor);


            GetIconFWS getIcon = new GetIconFWS();
            getIcon.setIcon("UserAlt");
            IconButton btnTest = new IconButton();
            btnTest.Width = 180;
            btnTest.Height = 50;
            // btnTest.Dock = DockStyle.Top;
            btnTest.IconChar = getIcon.icon;
            btnTest.IconSize = 32;
            btnTest.ImageAlign = ContentAlignment.MiddleLeft;
            btnTest.TextAlign = ContentAlignment.MiddleRight;
            btnTest.Text = i.Name;
            btnTest.Font = new Font(btnTest.Font, FontStyle.Bold);
            btnTest.BackColor = Color.WhiteSmoke;
            btnTest.Click += BtnTest_Click; 
            btnTest.Dock = DockStyle.Right;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.FlatAppearance.BorderSize = 0;

            btnTest.Name = i.Id.ToString() + "/" + i.Color;

            pnItem.Controls.Add(btnTest);
            pnItem.Dock = DockStyle.Top;
            pnItem.Padding = new Padding(1);

            return pnItem;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            openCmb = !openCmb;
            pnTest.Visible = openCmb;

            string[] splString = ((IconButton)sender).Name.ToString().Split('/');
            string idBtn = splString[0];
            string color = splString[1];
            string[] arrColor = color.Split('-');
            int a = Int32.Parse(arrColor[0]);
            int r = Int32.Parse(arrColor[1]);
            int g = Int32.Parse(arrColor[2]);
            int b = Int32.Parse(arrColor[3]);

            btnSelectWallet.Text = ((IconButton)sender).Text.ToString();
            btnColor.BackColor = Color.FromArgb(a, r, g, b);
            idWallet = Int32.Parse(idBtn);
        }

        public delegate void sendSubmitTransfer(bool mode);
        public sendSubmitTransfer sendData;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //int indexCategory = Categories.FindIndex(a => a.Name == cmbCategories.Text);
            //int indexWallet = Wallets.FindIndex(a => a.Name == cmbWallet.Text);
            string Type = cbIncome.Checked ? "In" : "Out";
            //int Id  = myTypes.Max(t => t.Age);
            // MessageBox.Show(indexCategory.ToString());

            
            var trans = new MyTransfer()
            {
                
                Id = 0,
                Type = Type,
                Date = dtpkTime.Value,
                //IdCategory = Categories[indexCategory].Id,
                //IdWallet = Wallets[indexWallet].Id,

                IdCategory = idCategory,
                IdWallet = idWallet,
                Money = Int32.Parse(txtAmount.Text),
                Note = txtNote.Text

            };
            context.MyTransfers.Add(trans);
            context.SaveChanges();
            sendData(true);
            MessageBox.Show("Thêm giao dịch thành công");
            this.Close();
        }

        private void btnSelectWallet_Click(object sender, EventArgs e)
        {
            openCmb = !openCmb;
            pnTest.Visible = openCmb;
        }

        private void btnChooseCategory_Click(object sender, EventArgs e)
        {
            dlChooseCategory dlCtgr = new dlChooseCategory(typeRadio);
            dlCtgr.sendData = new dlChooseCategory.sendCategory(getCategory);
            dlCtgr.ShowDialog();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(idWallet + "--" + idCategory);
            this.Close();
        }

        private void cbIncome_CheckedChanged(object sender, EventArgs e)
        {
        
            btnChooseCategory.Font = new Font(btnChooseCategory.Font, FontStyle.Regular);
            btnChooseCategory.ForeColor = Color.Gray;
            btnChooseCategory.Text = "Chọn loại giao dịch";
            typeRadio = !typeRadio;
        }
    }
}

