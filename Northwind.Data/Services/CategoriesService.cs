using Northwind.Data.Models;
using System.Linq;

namespace Northwind.Data.Services
{
    public interface ICategoriesService
    {
        IQueryable<Categories> GetAll();
    }

    public class CategoriesService : ICategoriesService
    {
        private readonly NorthwindContext _db;

        public CategoriesService(NorthwindContext db)
        {
            _db = db;
        }

        public IQueryable<Categories> GetAll() => _db.Categories;
    }
}
