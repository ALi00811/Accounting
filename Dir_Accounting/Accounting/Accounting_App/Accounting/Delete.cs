using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_App
{
    public class Delete 
    {
        
        public void Trash(int ID)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                db.AccountingRepositoirey.Delete(ID);
                db.Save();

            }
        }
        
    }
}
