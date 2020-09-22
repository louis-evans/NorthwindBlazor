using Northwind.Data.Models;
using System.Linq;

namespace Northwind.Data.Services
{
    public interface IShipperService
    {
        IQueryable<Shippers> GetAll();
    }

    public class ShipperService : IShipperService
    {
        private readonly NorthwindContext _db;

        public ShipperService(NorthwindContext db)
        {
            _db = db;
        }

        public IQueryable<Shippers> GetAll() => _db.Shippers;
    }
}
