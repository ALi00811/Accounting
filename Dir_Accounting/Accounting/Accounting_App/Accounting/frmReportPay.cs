using Accounting.DataLayer.Context;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using Accounting_App.Notification;

namespace Accounting_App
{
    public partial class frmReportPay : Form
    {
        public int TypeId = 0;
        public frmReportPay()
        {
            InitializeComponent();
            LoadForm();
        }
        void LoadForm()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomersViewModel> list = new List<ListCustomersViewModel>();
                list.Add(new ListCustomersViewModel()
                {
                    CustomerID = 0,
                    FullName = "تمامی اشخاص"
                });
                list.AddRange(db.CustomerRepository.GetNameCustomers());
                cbCustomers.DataSource = list;
                cbCustomers.DisplayMember = "FullName";
                cbCustomers.ValueMember = "CustomerID";
            }
            if (TypeId == 1) { this.Text = "گزارش دریافتی ها"; }
            else { this.Text = "گزارش پرداختی ها"; }
        }
        private void frmReportPay_Load(object sender, EventArgs e)
        {

        }


        public void Filter()
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                List<Accounting.DataLayer.Accounting> result = new List<Accounting.DataLayer.Accounting>();
                result.Clear();
                int UserID =Convert.ToInt32(cbCustomers.SelectedValue.ToString());

                if (UserID != 0)
                {

                    string Start = dtFromDate.Value.ToString();
                    string End = dtToDate.Value.ToString();
                    DateTime? startDate;
                    DateTime? endDate;

                    if (dtFromDate.Value != null)
                    {
                        startDate = Convert.ToDateTime(Start);
                        result.AddRange(db.AccountingRepositoirey.Get(a => a.DateTime >= startDate.Value && a.CustomerID == UserID && a.TypeID == TypeId).ToList());
                    }


                    if (dtToDate.Value != null)
                    {
                        if ((dtFromDate.Value != null))
                        {
                            startDate = Convert.ToDateTime(Start);
                            endDate = Convert.ToDateTime(End);
                            result.Clear();
                            result.AddRange(db.AccountingRepositoirey.Get(a => a.DateTime <= endDate.Value && a.CustomerID == UserID && a.DateTime >= startDate.Value && a.TypeID == TypeId).ToList());
                        }
                        else
                        {
                            endDate = Convert.ToDateTime(End);

                            result.AddRange(db.AccountingRepositoirey.Get(a => a.DateTime <= endDate.Value && a.CustomerID == UserID && a.TypeID == TypeId).ToList());
                        }

                    }
                    else
                    {
                        result.AddRange(db.AccountingRepositoirey.Get(a => a.TypeID == TypeId && a.CustomerID == UserID).ToList());
                    }
                }
                else
                {
                    result.AddRange(db.AccountingRepositoirey.Get(a => a.TypeID == TypeId).ToList());
                }
                dgReport.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                    dgReport.Rows.Add(accounting.ID, customerName, accounting.Amount, accounting.DateTime.ToShamsi(), accounting.Description);
                    dgReport.Columns[2].DefaultCellStyle.Format = ("#,0");
                }

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آیا از حذف مطمئن هستید ؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Delete dl = new Delete();
                    dl.Trash(id);
                    Filter();
                    SendNotification nofit = new SendNotification("حذف انجام شد", $"موضوع : {dgReport.CurrentRow.Cells[4].Value.ToString()}\r\n تاریخ حذف : {Convertor.ToShamsi(DateTime.Now)}");
                    
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                frmNewAccounting FrmNew = new frmNewAccounting();
                FrmNew.AccountID = id;
                if (FrmNew.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print pint = new Print(dgReport, stiprint);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnExcell_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                if (dgReport.CurrentRow != null)
                {
                    string SheetName;
                    SFD.Filter = "Excel Documents (*.xls)|*.xls";
                    SFD.Title = "ذخیره فایل در...";
                    if (txtSearch.Text != "") { SFD.FileName = txtSearch.Text; SheetName = "گزارش دریافتی ها"; }
                    else if (TypeId == 1) { SFD.FileName = "گزارش دریافتی ها"; SheetName = "گزارش دریافتی ها"; }
                    else { SFD.FileName = "گزارش پرداختی ها"; SheetName = "گزارش پرداختی ها"; }

                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        ToXls Excel = new ToXls(SFD, dgReport, SheetName);
                        MessageBox.Show("Save Compalte :)", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("داده ای برای خروجی یافت نشد", "!!توجه!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            dgReport.Rows.Clear();
            Filter();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                List<Accounting.DataLayer.Accounting> result = new List<Accounting.DataLayer.Accounting>();

                result.AddRange(db.AccountingRepositoirey.Get(a => a.Description.Contains(txtSearch.Text) && a.TypeID == TypeId).ToList());

                dgReport.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                    dgReport.Rows.Add(accounting.ID, customerName, accounting.Amount, accounting.DateTime.ToShamsi(), accounting.Description);
                    dgReport.Columns[2].DefaultCellStyle.Format = ("#,0");
                }

            }
        }
    }
}
