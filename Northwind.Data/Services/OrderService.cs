using Microsoft.EntityFrameworkCore;
using Northwind.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Data.Services
{
    public interface IOrderService
    {
        IQueryable<Orders> GetAll();
        Task<Orders> GetByIdAsync(int orderId);
    }

    public class OrderService : IOrderService
    {
        private readonly NorthwindContext _db;

        public OrderService(NorthwindContext db)
        {
            _db = db;
        }

        public IQueryable<Orders> GetAll()
        {
            return _db.Orders;
        }
        
        public Task<Orders> GetByIdAsync(int orderId)
        {
            return _db.Orders
                .Include(x => x.Employee)
                .Include(x => x.Customer)
                .Include(x => x.ShipViaNavigation)
                .Include(x => x.OrderDetails)
                .FirstAsync(x => x.OrderId == orderId);
        }
    }
}
