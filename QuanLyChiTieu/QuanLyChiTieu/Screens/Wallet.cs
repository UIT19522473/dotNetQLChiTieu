using QuanLyChiTieu.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu.Screens
{
    public partial class Wallet : Form
    {
        MasterMoneyEntities1 context;
        public Wallet()
        {
            context = new MasterMoneyEntities1();
            InitializeComponent();
        }
        public void getModeData(bool check)
        {
            //MessageBox.Show("Đã Nhận rồi nha");
            if (check)
            {
              LoadDataFromDB();
            }
        }

        private void LoadDataFromDB()
        {
            pnItems.Controls.Clear();
            var wl = context.MyWallets
                       .SqlQuery("Select * from MyWallet")
                       .ToList<MyWallet>();

            for (int i = 0; i < wl.Count; i++)
            {
                    WalletItem x = new WalletItem();
                    x.NameWallet = wl[i].Name;
                    x.pnColorWallet = wl[i].Color;
                    pnItems.Controls.Add(x);
                
            }
        }

        private void btnAddWallet_Click(object sender, EventArgs e)
        {
            AddWallet addWallet = new AddWallet();
            addWallet.sendData = new AddWallet.sendDataForWallet(getModeData);
            addWallet.ShowDialog();
        }

        private void Wallet_Load(object sender, EventArgs e)
        {
            LoadDataFromDB();
        }
    }
}
