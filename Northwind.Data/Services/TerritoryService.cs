using Microsoft.EntityFrameworkCore;
using Northwind.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Data.Services
{
    public interface ITerritoryService
    {
        IQueryable<Territories> GetAll();
        Task<Territories> GetByIdAsync(string id);
        Task<string> GetNameAsync(string id);
    }

    public class TerritoryService : ITerritoryService
    {
        private readonly NorthwindContext _db;

        public TerritoryService(NorthwindContext db)
        {
            _db = db;
        }

        public IQueryable<Territories> GetAll()
        {
            return _db.Territories;
        }

        public Task<Territories> GetByIdAsync(string id)
        {
            return _db.Territories.FirstAsync(t => t.TerritoryId == id);
        }

        public async Task<string> GetNameAsync(string id)
        {
            return await _db.Territories.Where(t => t.TerritoryId == id).Select(t => t.TerritoryDescription).FirstAsync();
        }
    }
}
