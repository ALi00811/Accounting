using Accounting.DataLayer.Repozitories;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepository _customerrepository;
        
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerrepository == null)
                {
                    _customerrepository = new CustomerRepository(db);
                }

                return _customerrepository;
            }
        }

        private GenericRepository<Accounting> _accountingRepositoriey;
        public GenericRepository<Accounting> AccountingRepositoirey
        {
            get
            {
                if (_accountingRepositoriey == null)
                {
                    _accountingRepositoriey = new GenericRepository<Accounting>(db);
                }
                return _accountingRepositoriey;
            }
        }

        private GenericRepository<Login> _loginRepository;

        public GenericRepository<Login> LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
