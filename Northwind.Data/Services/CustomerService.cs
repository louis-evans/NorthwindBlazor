using Microsoft.EntityFrameworkCore;
using Northwind.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Data.Services
{
    public interface ICustomerService
    {
        IQueryable<Customers> GetAll();
        Task<Customers> GetByIdAsync(string id);
    }

    public class CustomerService : ICustomerService
    {
        private readonly NorthwindContext _db;

        public CustomerService(NorthwindContext db)
        {
            _db = db;
        }

        public IQueryable<Customers> GetAll()
        {
            return _db.Customers;
        }

        public Task<Customers> GetByIdAsync(string id)
        {
            return _db.Customers.FirstAsync(x => x.CustomerId == id);
        }
    }
}
