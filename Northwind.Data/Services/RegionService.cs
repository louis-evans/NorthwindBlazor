using Northwind.Data.Models;
using System.Linq;

namespace Northwind.Data.Services
{
    public interface IRegionService
    {
        IQueryable<Region> GetAll();
    }

    public class RegionService : IRegionService
    {
        private readonly NorthwindContext _db;

        public RegionService(NorthwindContext db)
        {
            _db = db;
        }

        public IQueryable<Region> GetAll() => _db.Region;
    }
}
