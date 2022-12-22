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
    public partial class ItemExpense : UserControl
    {
        public ItemExpense()
        {
            InitializeComponent();
        }

        public string NameItemExpense
        {
            get { return lbName.Text.ToString(); }
            set { lbName.Text = value; }

        }

        public string MoneyItemExpense
        {
            get { return lbMoney.Text.ToString(); }
            set { lbMoney.Text = value; }

        }
    }
}
