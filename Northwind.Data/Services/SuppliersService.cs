using Northwind.Data.Models;
using System.Linq;

namespace Northwind.Data.Services
{
    public interface ISuppliersService
    {
        IQueryable<Suppliers> GetAll();
    }

    public class SuppliersService : ISuppliersService
    {
        private readonly NorthwindContext _db;

        public SuppliersService(NorthwindContext db)
        {
            _db = db;
        }

        public IQueryable<Suppliers> GetAll() => _db.Suppliers;
    }
}
