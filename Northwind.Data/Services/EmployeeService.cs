using Microsoft.EntityFrameworkCore;
using Northwind.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Data.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employees>> GetAllAsync();
        Task<Employees> GetByIdAsync(int id);
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly NorthwindContext _db;

        public EmployeeService(NorthwindContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Employees>> GetAllAsync()
        {
            return await QueryBase().ToListAsync();
        }

        public Task<Employees> GetByIdAsync(int id)
        {
            return QueryBase().FirstAsync(e => e.EmployeeId == id);
        }

        private IQueryable<Employees> QueryBase()
        {
            return _db.Employees
                .Include(x => x.Orders)
                .Include(x => x.EmployeeTerritories)
                .Include(x => x.InverseReportsToNavigation);
        }
    }
}
