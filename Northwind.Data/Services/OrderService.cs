using Microsoft.EntityFrameworkCore;
using Northwind.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Northwind.Data.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Orders>> GetAllAsync();
    }

    public class OrderService : IOrderService
    {
        private readonly NorthwindContext _db;

        public OrderService(NorthwindContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Orders>> GetAllAsync()
        {
            var orders = _db.Orders
                .Include(x => x.Employee)
                .Include(x => x.Customer)
                .Include(x => x.ShipViaNavigation)
                .Include(x => x.OrderDetails);
        
            return await orders.ToListAsync();
        }
    }
}
