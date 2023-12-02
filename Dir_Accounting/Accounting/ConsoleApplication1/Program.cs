using Accounting.DataLayer.Context;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();

            db.CustomerRepository.GetAllCustomres();

            db.Dispose();
        }
    }
}
