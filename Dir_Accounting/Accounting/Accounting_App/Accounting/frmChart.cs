using Accounting.DataLayer.Context;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS0105 // The using directive for 'Accounting.Utility.Convertor' appeared previously in this namespace
using Accounting.Utility.Convertor;
#pragma warning restore CS0105 // The using directive for 'Accounting.Utility.Convertor' appeared previously in this namespace
using Accounting.ViewModels;
using Accounting.ViewModels.Accounting;
using Accounting.Business;

namespace Accounting_App
{
    public partial class frmChart : Form
    {

        public System.Windows.Forms.DataVisualization.Charting.SeriesChartType TypeChartRepoet { get; set; } = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        public string TextComboBox { get; set; }
        public int thisMonth { get; set; }
        public int thisYear { get; set; }

        int CheckReport = 0;


        bool check = false;
        int CheckNum = 0;
        bool checkedClick = true;
        public int Months { get; set; }


        public frmChart()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void checking()
        {
            if (CheckNum == 0)
            {
                bcRecive.Checked = true;
                bcPay.Checked = false;
                check = true;
            }
            else
            {
                bcPay.Checked = true;
                bcRecive.Checked = false;
                check = false;
            }
        }
        private void bcRecive_OnChange(object sender, EventArgs e)
        {
            if (checkedClick && !check)
            {
                chartRecive.Visible = true;
                chartPay.Visible = false;
                checking();
                CheckNum = 1;
                checkedClick = false;
            }
            else
                bcRecive.Checked = true;
        }

        private void bcPay_OnChange(object sender, EventArgs e)
        {
            if (!checkedClick && check)
            {
                chartPay.Visible = true;
                chartRecive.Visible = false;
                checking();
                CheckNum = 0;
                checkedClick = true;
            }
            else
                bcPay.Checked = true;
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar pr = new System.Globalization.PersianCalendar();
            int ChooseMonth = pr.GetMonth(DateTime.Now);
            thisMonth = ChooseMonth + 2;
            thisYear = DateTime.Now.Year;
            DateTime dt = DateTime.Now;

            List<string> Months = new List<string>() { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
            List<string> TypeChart = new List<string>() { "میله ای", "حوزه ای", "ستونی", "نقطه ای", "خطی" };

            cbMonth.DataSource = Months;
            cbChartType.DataSource = TypeChart;
            cbMonth.SelectedIndex = ChooseMonth - 1;
            
            for (int i = 1400; i < 1420; i++)
            {
                cbYear.Items.Add(i);
            }
            cbYear.SelectedIndex = thisYear - 2021;


        }

        public void Reportchart()
        {
            if (CheckReport == 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    SetSeries();
                    DateTime time = DateTime.Now;
                    DateTime Start;
                    DateTime End;

                    Start = new DateTime(time.Year, time.Month , 21, 01, 00, 00);
                    End = new DateTime(time.Year, time.Month + 1, 21, 12, 59, 59);

                    List<Accounting.DataLayer.Accounting> Pay = new List<Accounting.DataLayer.Accounting>();
                    List<Accounting.DataLayer.Accounting> Recive = new List<Accounting.DataLayer.Accounting>();


                    Recive.AddRange(db.AccountingRepositoirey.Get(a => a.TypeID == 1 && a.DateTime >= Start && a.DateTime <= End));
                    Pay.AddRange(db.AccountingRepositoirey.Get(a => a.TypeID == 2 && a.DateTime >= Start && a.DateTime <= End));

                    foreach (var item in Pay)
                    {
                        chartPay.Series[0].Points.AddXY(item.DateTime.ToShamsi(), item.Amount);
                    }

                    foreach (var item in Recive)
                    {
                        chartRecive.Series[0].Points.AddXY(item.DateTime.ToShamsi(), item.Amount);
                    }
                    ReportVeiwModel report = Account.ReportFormMain(Start , End);
                    lblBalance.Text = report.AccountBalance.ToString("#,0");
                    lblRecive.Text = report.Recive.ToString("#,0");
                    lblPay.Text = report.Pay.ToString("#,0");

                    CheckReport = 1;
                }
            }
        }
        public void SetSeries()
        {
            chartPay.Series.Clear();
            chartRecive.Series.Clear();

            chartPay.Series.Add("پرداختی ها");
            chartPay.Series[0].ChartType = TypeChartRepoet;

            chartRecive.Series.Add("دریافتی ها");
            chartRecive.Series[0].ChartType = TypeChartRepoet;

        }

        private void cbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbChartType.SelectedIndex)
            {
                case 0:
                    TypeChartRepoet = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    break;
                case 1:
                    TypeChartRepoet = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    break;
                case 2:
                    TypeChartRepoet = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 3:
                    TypeChartRepoet = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case 4:
                    TypeChartRepoet = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    break;
                default:
                    break;
            }
            CheckReport = 0;
            Reportchart();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckReport = 0;
            if (cbMonth.SelectedIndex <= 4)
            {
                thisMonth = cbMonth.SelectedIndex + 3;
            }
            else
            {
                thisMonth = cbMonth.SelectedIndex - 9;
            }

            Reportchart();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckReport = 0;
            thisYear = cbYear.SelectedIndex + 2021;
            Reportchart();
        }
    }
}
