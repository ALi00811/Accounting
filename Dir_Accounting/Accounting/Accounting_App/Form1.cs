using System;
using System.Windows.Forms;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Accounting;
using Accounting.Business;
using System.Globalization;
using System.Data;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repozitories;
using System.Collections.Generic;
using Accounting.DataLayer;
using System.Linq;

namespace Accounting_App
{
    public partial class Main : Form
    {
        public SettingPreView Setting;
        private DateTime lastActivity = DateTime.Now;
        public int TimeLuck = 1;


        public Main()
        {
            InitializeComponent();
            Font = Properties.Settings.Default.Font;
            
        }

        public void FormLoad()
        {

            using (frmLogin frmlogin = new frmLogin())
            {
                this.Hide();
                frmlogin.txtPassword.PasswordChar = '*';
                if (frmlogin.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    lblDate.Text = DateTime.Now.ToShamsi();
                    lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
                    Clock.Value = System.DateTime.Now;
                    Report();
                    PersianCalendar pc = new PersianCalendar();
                    DateTime today = DateTime.Now;
                    switch (pc.GetDayOfWeek(today).ToString())
                    {
                        case "Saturday":
                            {
                                lblDay.Text = "(( شنیه ))";
                                break;
                            }
                        case "Sunday":
                            {
                                lblDay.Text = "(( یکشنبه ))";
                                break;
                            }
                        case "Monday":
                            {
                                lblDay.Text = "(( دوشنیه ))";
                                break;
                            }
                        case "Tuesday":
                            {
                                lblDay.Text = "(( سه شنیه ))";
                                break;
                            }
                        case "Wednesday":
                            {
                                lblDay.Text = "(( چهارشنبه ))";
                                break;
                            }
                        case "Thursday":
                            {
                                lblDay.Text = "(( پنج شنیه ))";
                                break;
                            }
                        case "Friday":
                            {
                                lblDay.Text = "(( جمعه ))";
                                break;
                            }

                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        public void Report()
        {
            ReportVeiwModel report = Account.ReportFormMain();
            ReportVeiwModel reporatAll =  Account.ReportFormMainAll();
            lblPay.Text = report.Pay.ToString("#,0");
            lblRecive.Text = report.Recive.ToString("#,0");
            lblAccountBalance.Text = report.AccountBalance.ToString("#,0");

            lblPayAll.Text = reporatAll.Pay.ToString("#,0");
            lblReciveAll.Text = reporatAll.Recive.ToString("#,0");
            lblAccountBalanceAll.Text = reporatAll.AccountBalance.ToString("#,0");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Value = System.DateTime.Now;
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            //UpdateIdleTime();
        }

        private void BtnCustomers_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            new FrmCustomers().ShowDialog();
        }

        private void btnExit_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (RtlMessageBox.Show("تنهامون میذاری؟", "خروج", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnReportRecive_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmReportPay frmreportpay = new frmReportPay();
            frmreportpay.TypeId = 1;
            if (frmreportpay.ShowDialog() == DialogResult.Cancel)
            {
                Report();
            }
        }

        private void btnReportPay_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmReportPay frmreportpay = new frmReportPay();
            frmreportpay.TypeId = 2;
            if (frmreportpay.ShowDialog() == DialogResult.Cancel)
            {
                Report();
            }
        }

        private void btnReport_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmNewAccounting frmNewAccounting = new frmNewAccounting();
            if (frmNewAccounting.ShowDialog() == DialogResult.OK)
            {
                Report();
            }
        }

        private void tnRefreshReport_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Report();
        }


        private void btnChart_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            new frmChart().ShowDialog();
        }

        private void btnEditLogin_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.IsEdit = true;
            frmlogin.ShowDialog();
        }
        

        private void btnLuck_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            FormLoad();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //lastActivity = DateTime.Now;
            //checkTime = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //lastActivity = DateTime.Now;
            //checkTime = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //lastActivity = DateTime.Now;
            //checkTime = true;

        }
        bool checkTime = true;
        private void UpdateIdleTime()
        {
            if (checkTime)
            {
                TimeSpan timeSinceLastActivity = DateTime.Now - lastActivity;

                // If one minute has elapsed since the last user activity, lock the computer.
                if (timeSinceLastActivity.TotalMinutes >= TimeLuck)
                {
                    checkTime = false;
                    FormLoad();
                }
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            lastActivity = DateTime.Now;
            checkTime = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            lastActivity = DateTime.Now;
            checkTime = true;
        }

        private void btnLoan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }
    }
}
