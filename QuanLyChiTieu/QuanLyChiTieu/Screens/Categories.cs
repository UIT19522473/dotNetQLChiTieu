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
    public partial class Categories : Form
    {
        MasterMoneyEntities1 context;
        bool modeTab = true;
        public Categories()
        {
            context = new MasterMoneyEntities1();
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {

            LoadDataFromDB();


        }

       private void LoadDataFromDB()
        {
            pnItems.Controls.Clear();
            var ctr = context.MyCategories
                       .SqlQuery("Select * from MyCategory")
                       .ToList<MyCategory>();

            for (int i = 0; i < ctr.Count; i++)
            {
                
                if (modeTab)
                {
                    CategoriesItem x = new CategoriesItem();
                    if (ctr[i].Type == "In")
                    {
                        x.NameCategory = ctr[i].Name;
                        x.IconCategory = ctr[i].Icon;
                        x.BackGroundCategory = ctr[i].Color;
                        
                        pnItems.Controls.Add(x);
                    }

                }
                else
                {
                    CategoriesItem x = new CategoriesItem();
                    if (ctr[i].Type == "Out")
                    {
                        x.NameCategory = ctr[i].Name;
                        x.IconCategory = ctr[i].Icon;
                        x.BackGroundCategory = ctr[i].Color;
                        pnItems.Controls.Add(x);
                    }
                }
               
              
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //IconDialog iconDialog = new IconDialog();
            //iconDialog.ShowDialog();
            
           
            AddCategoryDialog addCategoryDialog = new AddCategoryDialog();
            addCategoryDialog.ShowDialog();
        }
        public void loadData(bool check)
        {
            if (check)
            {
                //MessageBox.Show("Nhận đc r");
                LoadDataFromDB();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryDialog addCategoryDl = new AddCategoryDialog();
            addCategoryDl.sendData = new AddCategoryDialog.sendDataForCategory(loadData);

            addCategoryDl.ShowDialog();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            modeTab = true;
            btnExpense.FillColor = Color.Silver;
            btnIncome.FillColor = Color.FromArgb(7, 5, 68);
            LoadDataFromDB();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            modeTab= false;
            btnIncome.FillColor = Color.Silver;
            btnExpense.FillColor = Color.FromArgb(7, 5, 68);
            LoadDataFromDB();
        }
    }
}
