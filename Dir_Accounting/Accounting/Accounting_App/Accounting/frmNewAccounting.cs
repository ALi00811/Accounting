using Accounting.DataLayer.Context;
using System;
using Accounting.Utility;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer.Services;
using Accounting_App.Notification;
using Accounting.Utility.Convertor;

namespace Accounting_App
{

    public partial class frmNewAccounting : Form
    {
        UnitOfWork db;
        public int AccountID = 0;
        public frmNewAccounting()
        {
            InitializeComponent();
        }

        private void frmNewAccounting_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers();
            if (AccountID != 0)
            {
                var account = db.AccountingRepositoirey.GetById(AccountID);
                txtAmount.Value = account.Amount;
                txtDiscription.Text = account.Description;
                txtName.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                if (account.TypeID == 1)
                {
                    rbRecive.Checked = true;
                }
                else
                {
                    rbPay.Checked = true;
                }
                this.Text = "ویرایش";
                btnSave.Text = "ثبت ویرایش";
                db.Dispose();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers(txtFilter.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text != "" && rbPay.Checked || rbRecive.Checked && txtAmount.Value != 0)
            {
                db = new UnitOfWork();
                Accounting.DataLayer.Accounting accounting = new Accounting.DataLayer.Accounting()
                {
                    Amount = int.Parse(txtAmount.Value.ToString()),
                    CustomerID = db.CustomerRepository.GetCustomerIdByName(txtName.Text),
                    TypeID = (rbRecive.Checked) ? 1 : 2,
                    DateTime = DateTime.Now,
                    Description = txtDiscription.Text
                };
                if (AccountID == 0)
                {
                    db.AccountingRepositoirey.Insert(accounting);
                }
                else
                {
                    accounting.ID = AccountID;
                    db.AccountingRepositoirey.Update(accounting);
                }

                db.Save();
                DialogResult = DialogResult.OK;
                if (rbRecive.Checked)
                {
                    SendNotification nofit = new SendNotification("دریافت ثبت شد", $"دریافت بابت : {txtDiscription.Text}\r\n تاریخ ثبت : {Convertor.ToShamsi(DateTime.Now)}");
                }
                else
                {
                    SendNotification nofit = new SendNotification("پرداخت ثبت شد", $"پرداخت بابت : {txtDiscription.Text}\r\n تاریخ ثبت : {Convertor.ToShamsi(DateTime.Now)}");
                }




            }
            else
            {
                RtlMessageBox.Show("لطفا مقادیر را کامل کنید");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
