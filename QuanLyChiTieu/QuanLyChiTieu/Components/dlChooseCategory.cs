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

namespace QuanLyChiTieu.Components
{
    public partial class dlChooseCategory : Form
    {
        public delegate void sendCategory(string name, int id);
        public sendCategory sendData;

        MasterMoneyEntities1 context;

        private bool typeCategory;
        public dlChooseCategory()
        {
            context = new MasterMoneyEntities1();
            InitializeComponent();
        }

        public dlChooseCategory(bool type)
        {
            context = new MasterMoneyEntities1();
            InitializeComponent();
            this.typeCategory = type;
        }

        public void getCategory(string name, int id)
        {
            //MessageBox.Show(name+"-"+id);
            sendData(name, id);
            this.Close();
        }

        private void LoadDataFromDB()
        {
            pnCategory.Controls.Clear();
            var ctr = context.MyCategories
                       .SqlQuery("Select * from MyCategory")
                       .ToList<MyCategory>();

            for (int i = 0; i < ctr.Count; i++)
            {
                if (typeCategory)
                {
                    if (ctr[i].Type == "In")
                    {

                    CategoriesItem x = new CategoriesItem();
                    x.sendData = new CategoriesItem.sendCategory(getCategory);
                    x.idCategory = ctr[i].Id;
                    x.NameCategory = ctr[i].Name;
                    x.IconCategory = ctr[i].Icon;
                    x.BackGroundCategory = ctr[i].Color;

                    pnCategory.Controls.Add(x);
                    }
                }
                else
                {
                    if (ctr[i].Type == "Out")
                    {

                        CategoriesItem x = new CategoriesItem();
                        x.sendData = new CategoriesItem.sendCategory(getCategory);
                        x.idCategory = ctr[i].Id;
                        x.NameCategory = ctr[i].Name;
                        x.IconCategory = ctr[i].Icon;
                        x.BackGroundCategory = ctr[i].Color;

                        pnCategory.Controls.Add(x);
                    }
                }
                    
                        

            }
        }

        private void dlChooseCategory_Load(object sender, EventArgs e)
        {
            LoadDataFromDB();
        }
    }
}
