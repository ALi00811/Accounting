using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Repozitories
{
    public interface ICustomerRepository
    {
        List<Customers>GetAllCustomres();
        IEnumerable<Customers>GetCusstomersByFilter(string parameter);
        List<ListCustomersViewModel> GetNameCustomers(string filter = "");
        Customers GetCustomerById(int customerID);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
        int GetCustomerIdByName(string Name);
        string GetCustomerNameById(int CustomerId);
    }
}
