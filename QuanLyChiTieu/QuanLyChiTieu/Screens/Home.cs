using LiveCharts.Wpf;
using LiveCharts;
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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Resources.ResXFileRef;
using System.Windows.Media;
using Color = System.Drawing.Color;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;
using QuanLyChiTieu.GlobalFunc;
using System.Data.SqlTypes;
using System.Windows.Documents;
using System.Collections;
using System.Reflection;
using System.Globalization;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;
using FontStyle = System.Drawing.FontStyle;

namespace QuanLyChiTieu.Screens
{
    public partial class Home : Form
    {
        int idWallet = 0;
        bool openCmb = false;
        float Expense = 0;
        float Income = 0;
        int week = -1;
        int month = -1;
        int year = -1;
        int modeTime = 0;
        MasterMoneyEntities1 context;
        List<MyTransfer> myTransfer = new List<MyTransfer>();
        List<MyCategory> myCategories = new List<MyCategory>();
        
        public Home()
        {
            context = new MasterMoneyEntities1();
            InitializeComponent();
            //LoadTransfer("all");
            LoadAllCategory();
        }
        public void getSubmitTransfer (bool check)
        {
            if (check)
            {
                loadAllData(idWallet, modeTime);
            }
        }

        public void LoadAllCategory()
        {
            myCategories = context.MyCategories
              .SqlQuery("Select * from MyCategory")
              .ToList<MyCategory>();
        }

        public void loadAllData(int idWallet, int time)
        {
           // LoadPieChartAndExpense(idWallet);
           //LoadExpenseAndIncome(idWallet,time);
            LoadTransfer(idWallet, time);
            loadValueInOut();
            loadDounutAndExpense();
        }

        public void switchButton(string name)
        {
            switch (name)
            {
                case "day":
                    btnDay.FillColor = Color.FromArgb(255, 7, 5, 68);
                    btnWeek.FillColor = Color.Silver;
                    btnMonth.FillColor = Color.Silver;
                    btnYear.FillColor = Color.Silver;
                    week = -1;
                    month = -1;
                    year = -1;
                    modeTime = 0;
                    break;
                case "week":
                    btnDay.FillColor = Color.Silver;
                    btnWeek.FillColor = Color.FromArgb(255, 7, 5, 68);
                    btnMonth.FillColor = Color.Silver;
                    btnYear.FillColor = Color.Silver;

                    CultureInfo myCI = new CultureInfo("en-US");
                    Calendar myCal = myCI.Calendar;
                    CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
                    // DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
                    DayOfWeek myFirstDOW = DayOfWeek.Monday;
                    week = myCal.GetWeekOfYear(dtpkDate.Value, myCWR, myFirstDOW);
                    month = -1;
                    year = -1;
                    modeTime = 1;
                    break;
                case "month":
                    btnDay.FillColor = Color.Silver;
                    btnWeek.FillColor = Color.Silver;
                    btnMonth.FillColor = Color.FromArgb(255, 7, 5, 68);
                    btnYear.FillColor = Color.Silver;
                    week = -1;
                    month = dtpkDate.Value.Month;
                    year = -1;
                    modeTime = 2;
                    
                    break;
                case "year":
                    btnDay.FillColor = Color.Silver;
                    btnWeek.FillColor = Color.Silver;
                    btnMonth.FillColor = Color.Silver;
                    btnYear.FillColor = Color.FromArgb(255, 7, 5, 68);
                    week = -1;
                    month = -1;
                    year = dtpkDate.Value.Year;
                    modeTime = 3;
                    break;
                default:
                    break;
            }
        }



       
        public void LoadTransfer(int IdWallet, int time)
        {
            myTransfer.Clear();
            pnTransfer.Controls.Clear();
            if(time == 0)
            {
                var myCategories = context.MyCategories
               .SqlQuery("Select * from MyCategory")
               .ToList<MyCategory>();

                if (IdWallet == 0)
                {
                    myTransfer = context.MyTransfers
                   .SqlQuery("Select * from MyTransfer where Date = '" + dtpkDate.Value + "'")
                   .ToList<MyTransfer>();
                }
                else
                {
                    myTransfer = context.MyTransfers
                   .SqlQuery("Select * from MyTransfer where IdWallet = " + IdWallet.ToString() + "and Date = '" + dtpkDate.Value + "'")
                   .ToList<MyTransfer>();
                }

                // MessageBox.Show("total my transfer: "+myTransfer.Count.ToString());
                foreach (MyTransfer trans in myTransfer)
                {
                    int index = myCategories.FindIndex(w => w.Id == trans.IdCategory);
                    ItemTransfer x = new ItemTransfer();
                    x.NameItemTrans = trans.Note != "" ? trans.Note : myCategories[index].Name;
                    x.MoneyItemTrans = String.Format("{0:#,##0.##}", trans.Money);
                    x.BackGroundItemTrans = myCategories[index].Color;
                    x.TypeItemTrans = trans.Type;
                    x.IconItemTrans = myCategories[index].Icon;
                    //MessageBox.Show(trans.Date.ToString());

                    x.DateTimeItemTrans = trans.Date.ToString();
                    pnTransfer.Controls.Add(x);
                }
            }
            // week
            else if(time == 1)
            {
                var myCategories = context.MyCategories
               .SqlQuery("Select * from MyCategory")
               .ToList<MyCategory>();

                if (IdWallet == 0)
                {
                    myTransfer = context.MyTransfers
                   .SqlQuery("Select * from MyTransfer where DATEPART(week,Date) = " + week)
                   .ToList<MyTransfer>();
                }
                else
                {
                    myTransfer = context.MyTransfers
                   .SqlQuery("Select * from MyTransfer where IdWallet = " + IdWallet.ToString() + "and DATEPART(week,Date) = " + week)
                   .ToList<MyTransfer>();
                }

                // MessageBox.Show("total my transfer: "+myTransfer.Count.ToString());
                foreach (MyTransfer trans in myTransfer)
                {
                    int index = myCategories.FindIndex(w => w.Id == trans.IdCategory);
                    ItemTransfer x = new ItemTransfer();
                    x.NameItemTrans = trans.Note != "" ? trans.Note : myCategories[index].Name;
                    x.MoneyItemTrans = String.Format("{0:#,##0.##}", trans.Money);
                    x.BackGroundItemTrans = myCategories[index].Color;
                    x.TypeItemTrans = trans.Type;
                    x.IconItemTrans = myCategories[index].Icon;
                    //MessageBox.Show(trans.Date.ToString());

                    x.DateTimeItemTrans = trans.Date.ToString();
                    pnTransfer.Controls.Add(x);
                }
            }

            // month
            else if(time == 2)
            {
                var myCategories = context.MyCategories
               .SqlQuery("Select * from MyCategory")
               .ToList<MyCategory>();

                if (IdWallet == 0)
                {
                    myTransfer = context.MyTransfers
                   .SqlQuery("Select * from MyTransfer where MONTH(Date) = " + month)
                   .ToList<MyTransfer>();
                }
                else
                {
                    myTransfer = context.MyTransfers
                   .SqlQuery("Select * from MyTransfer where IdWallet = " + IdWallet.ToString() + "and MONTH(Date) = " + month)
                   .ToList<MyTransfer>();
                }

                // MessageBox.Show("total my transfer: "+myTransfer.Count.ToString());
                foreach (MyTransfer trans in myTransfer)
                {
                    int index = myCategories.FindIndex(w => w.Id == trans.IdCategory);
                    ItemTransfer x = new ItemTransfer();
                    x.NameItemTrans = trans.Note != "" ? trans.Note : myCategories[index].Name;
                    x.MoneyItemTrans = String.Format("{0:#,##0.##}", trans.Money);
                    x.BackGroundItemTrans = myCategories[index].Color;
                    x.TypeItemTrans = trans.Type;
                    x.IconItemTrans = myCategories[index].Icon;
                    //MessageBox.Show(trans.Date.ToString());

                    x.DateTimeItemTrans = trans.Date.ToString();
                    pnTransfer.Controls.Add(x);
                }
            }

            //year
            else if(time == 3)
            {
                var myCategories = context.MyCategories
               .SqlQuery("Select * from MyCategory")
               .ToList<MyCategory>();

                if (IdWallet == 0)
                {
                    myTransfer = context.MyTransfers
                   .SqlQuery("Select * from MyTransfer where YEAR(Date) = " + year)
                   .ToList<MyTransfer>();
                }
                else
                {
                    myTransfer = context.MyTransfers
                   .SqlQuery("Select * from MyTransfer where IdWallet = " + IdWallet.ToString() + "and YEAR(Date) = " + year)
                   .ToList<MyTransfer>();
                }

                // MessageBox.Show("total my transfer: "+myTransfer.Count.ToString());
                foreach (MyTransfer trans in myTransfer)
                {
                    int index = myCategories.FindIndex(w => w.Id == trans.IdCategory);
                    ItemTransfer x = new ItemTransfer();
                    x.NameItemTrans = trans.Note != "" ? trans.Note : myCategories[index].Name;
                    x.MoneyItemTrans = String.Format("{0:#,##0.##}", trans.Money);
                    x.BackGroundItemTrans = myCategories[index].Color;
                    x.TypeItemTrans = trans.Type;
                    x.IconItemTrans = myCategories[index].Icon;
                    //MessageBox.Show(trans.Date.ToString());

                    x.DateTimeItemTrans = trans.Date.ToString();
                    pnTransfer.Controls.Add(x);
                }
            }

            
        }


        public SolidColorBrush ToSolidColorBrush(string color)
        {

             string[] str = color.Split('-');
             int A = Int32.Parse(str[0]);
              int R = Int32.Parse(str[1]);
              int G = Int32.Parse(str[2]);
              int B = Int32.Parse(str[3]);

            Color myColor = Color.FromArgb(A,R, G, B);
            string hex = myColor.A.ToString("X2")+ myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            // string hexColor = Color.FromArgb
            return (SolidColorBrush)new BrushConverter().ConvertFromString("#"+hex);
           // return new SolidColorBrush(Color.FromArgb(222,222,222,222));

        }

        private Panel createSelectCmbWallet(MyWallet i)
        {
            string[] arrColor = i.Color.Split('-');
            int a = Int32.Parse(arrColor[0]);
            int r = Int32.Parse(arrColor[1]);
            int g = Int32.Parse(arrColor[2]);
            int b = Int32.Parse(arrColor[3]);

        

            Panel pnColor = new Panel();
            pnColor.Width = 20;
            pnColor.Height = 50;
            pnColor.BackColor = Color.FromArgb(a, r, g, b);
            pnColor.Dock = DockStyle.Right;

            Panel pnItem = new Panel();
            pnItem.Width = 200;
            pnItem.Height = 60;
            pnItem.Controls.Add(pnColor);


            GetIconFWS getIcon = new GetIconFWS();
            getIcon.setIcon("UserAlt");
            IconButton btnTest = new IconButton();
            btnTest.Width = 180;
            btnTest.Height = 60;
            // btnTest.Dock = DockStyle.Top;
            btnTest.IconChar = getIcon.icon;
            btnTest.ImageAlign = ContentAlignment.MiddleLeft;
            btnTest.TextAlign = ContentAlignment.MiddleRight;
            btnTest.Text = i.Name;
            btnTest.Font = new Font(btnTest.Font, FontStyle.Bold);
            btnTest.BackColor = Color.WhiteSmoke;
            btnTest.Click += BtnTest_Click;
            btnTest.Dock = DockStyle.Right;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.FlatAppearance.BorderSize = 0;

            btnTest.Name = i.Id.ToString()+"/"+i.Color;

            pnItem.Controls.Add(btnTest);
            pnItem.Dock = DockStyle.Top;
            pnItem.Padding = new Padding(1);

            return pnItem;
        }

        private void LoadCmbWallet()
        {
            var myWallet = context.MyWallets
                        .SqlQuery("Select * from MyWallet")
                        .ToList<MyWallet>();


            foreach (MyWallet i in myWallet )
            {
                Panel pnX = createSelectCmbWallet(i);

                if (pnTest.Height < 200)
                {

                    pnTest.Height += 60;
                }

                pnTest.Controls.Add(pnX);
            }
            Panel pnAll = createSelectCmbWallet(new MyWallet() { Color = "255-52-119-235", Name = "Tất cả ví", Id = 0 });
            pnTest.Controls.Add(pnAll);
        }

        private void loadValueInOut()
        {
            float mnOut = 0;
            float mnIn = 0;
            float mnBlank = 0;
            foreach (MyTransfer myTrans in myTransfer)
            {
                if(myTrans.Type == "Out")
                {
                    mnOut += float.Parse( myTrans.Money.ToString());
                }
                else
                {
                    mnIn += float.Parse(myTrans.Money.ToString());
                }

            }
            lbMoneyIn.Text = String.Format("{0:#,##0.##}", mnIn);
            lbMoneyOut.Text = String.Format("{0:#,##0.##}", mnOut);
            mnBlank = mnIn - mnOut;
            lbBlank.Text = String.Format("{0:#,##0.##}", mnBlank);
            prcMoney.Value = (int)((mnOut / (mnIn + mnOut)) * 100);
        }

        /*
        private void LoadExpenseAndIncome(int idWallet,int time)
        {
            float mnOut = 0;
            float mnIn = 0;
            float mnBlank = 0;
            //get all transfer

            //day
            if(time == 0)
            {

                if (idWallet == 0)
                {
                    var MoneyOut = context.MyTransfers
                       .Where(m => m.Type == "Out" && m.Date == dtpkDate.Value)
                       .GroupBy(p => p.Type)
                       .Select(g => new { Money = g.Sum(c => c.Money) }).ToList();

                    var MoneyIn = context.MyTransfers
                          .Where(m => m.Type == "In" && m.Date == dtpkDate.Value)
                          .GroupBy(p => p.Type)
                          .Select(g => new { Money = g.Sum(c => c.Money) }).ToList();
                    // money out
                    if (MoneyOut.Count > 0)
                    {
                        mnOut = float.Parse(MoneyOut[0].Money.ToString());
                        lbMoneyOut.Text = String.Format("{0:#,##0.##}", MoneyOut[0].Money);
                    }
                    else
                    {
                        lbMoneyOut.Text = "0";
                    }
                    // money in
                    if (MoneyIn.Count > 0)
                    {
                        mnIn = float.Parse(MoneyIn[0].Money.ToString());
                        lbMoneyIn.Text = String.Format("{0:#,##0.##}", MoneyIn[0].Money);
                    }
                    else
                    {
                        lbMoneyIn.Text = "0";
                    }

                    mnBlank = mnIn - mnOut;
                    lbBlank.Text = String.Format("{0:#,##0.##}", mnBlank);
                    prcMoney.Value = (int)((mnOut / (mnIn + mnOut)) * 100);
                }
                //get transfer by id wallet
                else
                {
                    var MoneyOut = context.MyTransfers
                       .Where(m => m.Type == "Out" && m.Date == dtpkDate.Value && m.IdWallet == idWallet)
                       .GroupBy(p => p.Type)
                       .Select(g => new { Money = g.Sum(c => c.Money) }).ToList();

                    var MoneyIn = context.MyTransfers
                          .Where(m => m.Type == "In" && m.Date == dtpkDate.Value && m.IdWallet == idWallet)
                          .GroupBy(p => p.Type)
                          .Select(g => new { Money = g.Sum(c => c.Money) }).ToList();

                    // money out
                    if (MoneyOut.Count > 0)
                    {
                        mnOut = float.Parse(MoneyOut[0].Money.ToString());
                        lbMoneyOut.Text = String.Format("{0:#,##0.##}", MoneyOut[0].Money);
                    }
                    else
                    {
                        lbMoneyOut.Text = "0";
                    }
                    // money in
                    if (MoneyIn.Count > 0)
                    {
                        mnIn = float.Parse(MoneyIn[0].Money.ToString());
                        lbMoneyIn.Text = String.Format("{0:#,##0.##}", MoneyIn[0].Money);
                    }
                    else
                    {
                        lbMoneyIn.Text = "0";
                    }

                    mnBlank = mnIn - mnOut;
                    lbBlank.Text = String.Format("{0:#,##0.##}", mnBlank);
                    prcMoney.Value = (int)((mnOut / (mnIn + mnOut)) * 100);
                }
            }
            //week cần fixx
            else if(time == 1)
            {
                if (idWallet == 0)
                {

                    var MoneyOut = context.MyTransfers
                              .SqlQuery("select *from MyTransfer where Type = 'Out' and DATEPART(week, Date) = " + week)
                              .ToList<MyTransfer>();
              

                    var MoneyIn = context.MyTransfers
                             .SqlQuery("select *from MyTransfer where Type = 'In' and DATEPART(week, Date) = " + week)
                             .ToList<MyTransfer>();

                    // money out
                    if (MoneyOut.Count > 0)
                    {
                        foreach(MyTransfer mon in MoneyOut)
                        {

                             mnOut += float.Parse(mon.Money.ToString());
                        }
                        lbMoneyOut.Text = String.Format("{0:#,##0.##}", mnOut);
                        //MessageBox.Show(String.Format("{0:#,##0.##}", mnOut));
                    }
                    else
                    {
                        lbMoneyOut.Text = "0";
                    }
                    // money in
                    if (MoneyIn.Count > 0)
                    {
                        foreach (MyTransfer min in MoneyIn)
                        {

                            mnIn += float.Parse(min.Money.ToString());
                        }
                        lbMoneyIn.Text = String.Format("{0:#,##0.##}", mnIn);
                    }
                    else
                    {
                        lbMoneyIn.Text = "0";
                    }

                    mnBlank = mnIn - mnOut;
                    lbBlank.Text = String.Format("{0:#,##0.##}", mnBlank);
                    prcMoney.Value = (int)((mnOut / (mnIn + mnOut)) * 100);
                }
                //get transfer by id wallet
                else
                {
                    var MoneyOut = context.MyTransfers
                       .Where(m => m.Type == "Out" && m.Date == dtpkDate.Value && m.IdWallet == idWallet)
                       .GroupBy(p => p.Type)
                       .Select(g => new { Money = g.Sum(c => c.Money) }).ToList();

                    var MoneyIn = context.MyTransfers
                          .Where(m => m.Type == "In" && m.Date == dtpkDate.Value && m.IdWallet == idWallet)
                          .GroupBy(p => p.Type)
                          .Select(g => new { Money = g.Sum(c => c.Money) }).ToList();

                    // money out
                    if (MoneyOut.Count > 0)
                    {
                        mnOut = float.Parse(MoneyOut[0].Money.ToString());
                        lbMoneyOut.Text = String.Format("{0:#,##0.##}", MoneyOut[0].Money);
                    }
                    else
                    {
                        lbMoneyOut.Text = "0";
                    }
                    // money in
                    if (MoneyIn.Count > 0)
                    {
                        mnIn = float.Parse(MoneyIn[0].Money.ToString());
                        lbMoneyIn.Text = String.Format("{0:#,##0.##}", MoneyIn[0].Money);
                    }
                    else
                    {
                        lbMoneyIn.Text = "0";
                    }

                    mnBlank = mnIn - mnOut;
                    lbBlank.Text = String.Format("{0:#,##0.##}", mnBlank);
                    prcMoney.Value = (int)((mnOut / (mnIn + mnOut)) * 100);
                }
            }
            //month
            else if(time == 2)
            {

            }
            //year
            else if (time == 3)
            {

            }
 
        }

        */
        //List<TransferCustom> transferCustoms = new List<TransferCustom>();

        private void loadDounutAndExpense()
        {
            pnChiPhi.Controls.Clear();
            pieChart.Series.Clear();
            pnLegendChart.Controls.Clear();
            List<int> lstCategory = new List<int>();
            foreach(MyTransfer myTrans in myTransfer)
            {
                lstCategory.Add((int)myTrans.IdCategory);
            }
            lstCategory = lstCategory.Distinct().ToList();

            //MessageBox.Show(lstCategory.Count.ToString());
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            foreach (int i in lstCategory)
            {
                int index = myCategories.FindIndex(a => a.Id == i);
                string colorSeries = myCategories[index].Color;
                float money = 0;
                foreach (MyTransfer myTrans in myTransfer)
                {
                    if (myTrans.IdCategory == i && myTrans.Type =="Out")
                    {
                        money += float.Parse(myTrans.Money.ToString());
                    }
                }

                if(myCategories[index].Type == "Out")
                {

                    ItemExpense x = new ItemExpense();
                    x.NameItemExpense = myCategories[index].Name;
                    // x.MoneyItemExpense = String.Format("0:#,##0.##", Double.Parse(trans.Money.ToString()).ToString());
                    x.MoneyItemExpense = String.Format("{0:#,##0.##}", money); // 12,314.23
                                                                               // MessageBox.Show("Money "+ trans.Money.ToString());
                    pnChiPhi.Controls.Add(x);


                    //Dounut chart

                    series.Add(
                            new PieSeries
                            {

                                Title = myCategories[index].Name,
                                Values = new ChartValues<double> { money },
                                DataLabels = true,

                                LabelPoint = labelPoint,

                                // Fill = ToSolidColorBrush("#fc4523")
                                Fill = ToSolidColorBrush(colorSeries)

                            }
                         );
                    //add legend chart

                    LegendChart lgChart = new LegendChart();
                    lgChart.NameLegendChart = myCategories[index].Name;
                    lgChart.ColorLegendChart = colorSeries;
                    pnLegendChart.Controls.Add(lgChart);
                }

            }

            pieChart.Series = series;
            pieChart.InnerRadius = 80;
        }
       
        /*
        private void LoadPieChartAndExpense(int idWallet)
        {
            //pieChart.Series.Clear();
            
            pnChiPhi.Controls.Clear();
            pnLegendChart.Controls.Clear();
            if(idWallet == 0)
            {
                var myData = context.MyTransfers
                 .Where(m => m.Type == "Out" && m.Date == dtpkDate.Value)
                 .GroupBy(p => p.IdCategory)
                 .Select(g => new { Money = g.Sum(c => c.Money), IdCate = g.Select(x => x.IdCategory).FirstOrDefault() }).ToList();

                //MessageBox.Show("lengt piechar = " + myData.Count);

                //int[] x = new int[10]
                LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                foreach (var trans in myData)
                {

                    //  var converter = new System.Windows.Media.BrushConverter();
                    //var brush = (Brush)converter.ConvertFromString("#FFFFFF90");
                    int index = myCategories.FindIndex(a => a.Id == trans.IdCate);
                    string colorSeries = myCategories[index].Color;

                    ItemExpense x = new ItemExpense();
                    x.NameItemExpense = myCategories[index].Name;
                    // x.MoneyItemExpense = String.Format("0:#,##0.##", Double.Parse(trans.Money.ToString()).ToString());
                    x.MoneyItemExpense = String.Format("{0:#,##0.##}", Double.Parse(trans.Money.ToString())); // 12,314.23
                                                                                                              // MessageBox.Show("Money "+ trans.Money.ToString());
                    pnChiPhi.Controls.Add(x);

                    pieChart.Series.Clear();

                    series.Add(
                        new PieSeries
                        {

                            Title = myCategories[index].Name,
                            Values = new ChartValues<double> { Double.Parse(trans.Money.ToString()) },
                            DataLabels = true,

                            LabelPoint = labelPoint,

                            // Fill = ToSolidColorBrush("#fc4523")
                            Fill = ToSolidColorBrush(colorSeries)

                        }
                     );
                    //add legend chart

                    LegendChart lgChart = new LegendChart();
                    lgChart.NameLegendChart = myCategories[index].Name;
                    lgChart.ColorLegendChart = colorSeries;
                    pnLegendChart.Controls.Add(lgChart);
                }

                pieChart.Series = series;
                pieChart.InnerRadius = 80;

            }
            else
            {
                var myData = context.MyTransfers
                 .Where(m => m.Type == "Out" && m.Date == dtpkDate.Value && m.IdWallet == idWallet)
                 .GroupBy(p => p.IdCategory)
                 .Select(g => new { Money = g.Sum(c => c.Money), IdCate = g.Select(x => x.IdCategory).FirstOrDefault() }).ToList();

                //MessageBox.Show("lengt piechar = " + myData.Count);

                //int[] x = new int[10]
                LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                foreach (var trans in myData)
                {

                    //  var converter = new System.Windows.Media.BrushConverter();
                    //var brush = (Brush)converter.ConvertFromString("#FFFFFF90");
                    int index = myCategories.FindIndex(a => a.Id == trans.IdCate);
                    string colorSeries = myCategories[index].Color;

                    ItemExpense x = new ItemExpense();
                    x.NameItemExpense = myCategories[index].Name;
                    // x.MoneyItemExpense = String.Format("0:#,##0.##", Double.Parse(trans.Money.ToString()).ToString());
                    x.MoneyItemExpense = String.Format("{0:#,##0.##}", Double.Parse(trans.Money.ToString())); // 12,314.23
                                                                                                              // MessageBox.Show("Money "+ trans.Money.ToString());
                    pnChiPhi.Controls.Add(x);

                    pieChart.Series.Clear();

                    series.Add(
                        new PieSeries
                        {

                            Title = myCategories[index].Name,
                            Values = new ChartValues<double> { Double.Parse(trans.Money.ToString()) },
                            DataLabels = true,

                            LabelPoint = labelPoint,

                            // Fill = ToSolidColorBrush("#fc4523")
                            Fill = ToSolidColorBrush(colorSeries)

                        }
                     );
                    //add legend chart

                    LegendChart lgChart = new LegendChart();
                    lgChart.NameLegendChart = myCategories[index].Name;
                    lgChart.ColorLegendChart = colorSeries;
                    pnLegendChart.Controls.Add(lgChart);
                }



                /*
                    DefaultLegend customLegend = new DefaultLegend();
                    customLegend.BulletSize = 15;
                    customLegend.Foreground = ToSolidColorBrush("255-255-255-255");
                    customLegend.Orientation = System.Windows.Controls.Orientation.Horizontal;*/


                // customLegend = new DefaultLegend();

                // customLegend.Foreground = System.Windows.Media.Brushes.White;


                // pieChart.DefaultLegend = customLegend;
               // pieChart.Series = series;
               // pieChart.InnerRadius = 80;
                //pieChart.LegendLocation = LegendLocation.Bottom;
           // }
            /* var myPie = context.MyTransfers
                         .SqlQuery("select SUM(Money) as Money,IdCategory as IdCate from MyTransfer group by IdCategory")
                         .ToList<MyTransfer>();*/

            //select IdCategory,sum(Money) from MyTransfer where type = 'In' and Date = '2022-12-21' group by IdCategory


       // }
      


        private void Home_Load(object sender, EventArgs e)
        {
            LoadCmbWallet();

            pnTest.Visible = openCmb;
            loadAllData(idWallet, modeTime);

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((IconButton)sender).Text.ToString()+"--"+((IconButton)sender).Name.ToString());
            openCmb = !openCmb;
            pnTest.Visible = openCmb;

            string[] splString = ((IconButton)sender).Name.ToString().Split('/');
            string id = splString[0];
            string color = splString[1];
            string[] arrColor = color.Split('-');
            int a = Int32.Parse(arrColor[0]);
            int r = Int32.Parse(arrColor[1]);
            int g = Int32.Parse(arrColor[2]);
            int b = Int32.Parse(arrColor[3]);

            btnSelectWallet.Text = ((IconButton)sender).Text.ToString();
            btnColor.BackColor = Color.FromArgb(a, r, g, b);
            idWallet = Int32.Parse(id);
            loadAllData(idWallet,modeTime);
            //LoadExpenseAndIncome(idWallet);
            //LoadTransfer(id);
        }



        private void btnSelectWallet_Click(object sender, EventArgs e)
        {
            openCmb = !openCmb;
            pnTest.Visible = openCmb;
            
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            dlAddTransfer dlTransfer = new dlAddTransfer("Out");
            dlTransfer.sendData = new dlAddTransfer.sendSubmitTransfer(getSubmitTransfer);
            dlTransfer.ShowDialog();
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            //LoadPieChartAndExpense(0);
            // LoadExpenseAndIncome(0);
            
           
                CultureInfo myCI = new CultureInfo("en-US");
                Calendar myCal = myCI.Calendar;
                CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
                // DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
                DayOfWeek myFirstDOW = DayOfWeek.Monday;
                week = myCal.GetWeekOfYear(dtpkDate.Value, myCWR, myFirstDOW);
                month = dtpkDate.Value.Month;
                year = dtpkDate.Value.Year;
           
            loadAllData(idWallet, modeTime);
            //MessageBox.Show(myCal.GetWeekOfYear(dtpkDate.Value, myCWR, myFirstDOW).ToString());
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            dlAddTransfer dlTransfer = new dlAddTransfer("In");
            dlTransfer.sendData = new dlAddTransfer.sendSubmitTransfer(getSubmitTransfer);
            dlTransfer.ShowDialog();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            //week = -1;
            switchButton("day");
            loadAllData(idWallet, modeTime);
        }
        private void btnWeek_Click(object sender, EventArgs e)
        {
            switchButton("week");
            loadAllData(idWallet, modeTime);
        }


        private void btnMonth_Click(object sender, EventArgs e)
        {
            switchButton("month");
            loadAllData(idWallet, modeTime);
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            switchButton("year");
            loadAllData(idWallet, modeTime);
        }
    }
}
