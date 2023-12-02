using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_App
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DgvCustomers.AutoGenerateColumns = false;
                DgvCustomers.DataSource = db.CustomerRepository.GetAllCustomres();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TxtFilter.Text = "";
            BindGrid();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DgvCustomers.DataSource = db.CustomerRepository.GetCusstomersByFilter(TxtFilter.Text);
            }
        }

        private void BtndeleteCustomer_Click(object sender, EventArgs e)
        {
            if (DgvCustomers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = DgvCustomers.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int customerId = int.Parse(DgvCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(customerId);
                        try
                        {
                            db.Save();
                        }
                        catch (Exception)
                        {
                            if (MessageBox.Show("مشتری دارای مقادیر خرید و فروش میباشد\rآیا از حذف تمامی داده های کاربر اطمینان دارید ؟", "!! توجه !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                DeleteAll dl = new DeleteAll(customerId);
                                db.CustomerRepository.DeleteCustomer(customerId);
                                MessageBox.Show("حذف با موفقیت انجام شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                db.Save();


                            }
                        }

                        System.IO.File.Delete(Application.StartupPath + "/Images/" + DgvCustomers.CurrentRow.Cells[5].Value.ToString());
                        BindGrid();
                    }

                }
            }
            else
            {
                RtlMessageBox.Show("یک سطر را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            FrmAddOrEditCustomer FrmAdd = new FrmAddOrEditCustomer();
            if (FrmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            if (DgvCustomers.CurrentRow != null)
            {
                int customerId = int.Parse(DgvCustomers.CurrentRow.Cells[0].Value.ToString());
                FrmAddOrEditCustomer frmAddOrEdit = new FrmAddOrEditCustomer();
                frmAddOrEdit.customerId = customerId;
                if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
