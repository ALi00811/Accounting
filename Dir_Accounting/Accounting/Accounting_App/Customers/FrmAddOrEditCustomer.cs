using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer.Context;
using Accounting.DataLayer;
using System.IO;
using Accounting.Utility.Convertor;
using Accounting_App.Notification;
using DevExpress.XtraReports;

namespace Accounting_App
{
    public partial class FrmAddOrEditCustomer : Form
    {
        public string NameImage { get; set; } = Guid.NewGuid().ToString() + ".jpg";

        public int customerId = 0;
        UnitOfWork db = new UnitOfWork();
        public FrmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void FrmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "(( ویرایش شخص ))";
                btnSave.Text = "ثبت ویرایش";
                var customer = db.CustomerRepository.GetCustomerById(customerId);
                txvname.Text = customer.FullName;
                txvmobile.Text = customer.Mobile;
                txvemail.Text = customer.Email;
                txvaddress.Text = customer.Address;
                pcCustommer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txvname.Text != "" && txvmobile.Text != "" && txvemail.Text != "")
            {

                if (customerId != 0)
                {

                    var customer = db.CustomerRepository.GetCustomerById(customerId);
                    NameImage = customer.CustomerImage;
                }
                else
                {
                    NameImage = Guid.NewGuid().ToString() + Path.GetExtension(pcCustommer.ImageLocation) + ".jpg";
                }
                
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustommer.Image.Save(path + NameImage);

                Customers customers = new Customers()
                {
                    Address = txvaddress.Text,
                    Email = txvemail.Text,
                    Mobile = txvmobile.Text,
                    FullName = txvname.Text,
                    CustomerImage = NameImage
                };
                if (customerId == 0)
                {
                    db.CustomerRepository.InsertCustomer(customers);
                }
                else
                {
                    customers.CustomerID = customerId;
                    db.CustomerRepository.UpdateCustomer(customers);
                }
                db.Save();
                DialogResult = DialogResult.OK;
                SendNotification nofit = new SendNotification(" کاربر با موفقیت اضافه شد ", $"خوش آمدید : {txvname.Text}\r\n تاریخ ثبت : {Convertor.ToShamsi(DateTime.Now)}");

            }
            else
            {
                RtlMessageBox.Show("لطفا مقادیر را کامل کنید", "توجه");
            }
        }

        private void btnSelectPhoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                NameImage = openFile.FileName;
                pcCustommer.ImageLocation = openFile.FileName;
            }
        }
    }
}
