using Microsoft.EntityFrameworkCore;
using Northwind.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.Services
{
    public interface IProductService
    {
        IQueryable<Products> GetAll();
        Task<Products> GetByIdAsync(int id);
        Task<string> GetNameAsync(int id);
    }

    public class ProductService : IProductService
    {
        private readonly NorthwindContext _db;

        public ProductService(NorthwindContext db)
        {
            _db = db;
        }

        public IQueryable<Products> GetAll()
        {
            return _db.Products;
        }

        public Task<Products> GetByIdAsync(int id)
        {
            return _db.Products.FirstAsync(p => p.ProductId == id);
        }

        public Task<string> GetNameAsync(int id)
        {
            return _db.Products.Where(p => p.ProductId == id).Select(p => p.ProductName).FirstAsync();
        }
    }
}
