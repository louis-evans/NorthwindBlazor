using Microsoft.EntityFrameworkCore;
using Northwind.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Data.Services
{
    public interface IEmployeeService
    {
        IQueryable<Employees> GetAll();
        Task<Employees> GetByIdAsync(int id);
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly NorthwindContext _db;

        public EmployeeService(NorthwindContext db)
        {
            _db = db;
        }

        public IQueryable<Employees> GetAll()
        {
            return _db.Employees;
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
