using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_App
{
    public class DeleteAll : IDisposable
    {
        public DeleteAll(int customerId)
        {
            Delete dll;
            using (UnitOfWork db = new UnitOfWork())
            {
                dll = new Delete();

                var Data = db.AccountingRepositoirey.Get(a => a.CustomerID == customerId).ToList();
                foreach (var item in Data)
                {
                    dll.Trash(item.ID);

                }
                
            }
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
