using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;
using System;
using System.Linq;
using System.Globalization;
using Accounting.Utility.Convertor;
namespace Accounting.Business
{
    public class Account
    {
        public static ReportVeiwModel ReportFormMain()
        {
            ReportVeiwModel rp = new ReportVeiwModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime startDate;
                DateTime endDate;
                if (DateTime.Now.Day >= 21)
                {
                    startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 21, 00, 00, 00);
                    endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 20, 12, 59, 59);
                }
                else
                {
                    startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 21, 00, 00, 00);
                    endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 20, 12, 59, 59);
                }
                
                var recive = db.AccountingRepositoirey.Get(a => a.TypeID == 1 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a=> a.Amount).ToList();
                var pay = db.AccountingRepositoirey.Get(a => a.TypeID == 2 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a=> a.Amount).ToList();

                rp.Recive = recive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountBalance = (recive.Sum() - pay.Sum());
            }
            return rp;
        }
        public static ReportVeiwModel ReportFormMainAll()
        {
            ReportVeiwModel rp = new ReportVeiwModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                PersianCalendar pr = new PersianCalendar();
                DateTime Year = new DateTime(pr.GetYear(DateTime.Now),01,01);
                DateTime AfterYear = new DateTime(pr.GetYear(DateTime.Now) + 1,01,01);
                DateTime startDate = Convertor.ToMiladi(Year);
                DateTime endDate = Convertor.ToMiladi(AfterYear);

                var recive = db.AccountingRepositoirey.Get(a => a.TypeID == 1 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a => a.Amount).ToList();
                var pay = db.AccountingRepositoirey.Get(a => a.TypeID == 2 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a => a.Amount).ToList();

                rp.Recive = recive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountBalance = (recive.Sum() - pay.Sum());
            }
            return rp;
        }
        public static ReportVeiwModel ReportFormMain(DateTime start, DateTime end)
        {
            ReportVeiwModel rp = new ReportVeiwModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                
                var recive = db.AccountingRepositoirey.Get(a => a.TypeID == 1 && a.DateTime >= start && a.DateTime <= end).Select(a => a.Amount).ToList();
                var pay = db.AccountingRepositoirey.Get(a => a.TypeID == 2 && a.DateTime >= start && a.DateTime <= end).Select(a => a.Amount).ToList();

                rp.Recive = recive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountBalance = (recive.Sum() - pay.Sum());
            }
            return rp;
        }
    }
}
