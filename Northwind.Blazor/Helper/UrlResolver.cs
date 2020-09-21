using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Blazor.Helper
{
    public class UrlResolver
    {
        public string CustomerView(string id)
        {
            return $"Customers/View/{id}";
        }

        public string EmployeeView(int id)
        {
            return $"Employees/View/{id}";
        }

        public string OrderView(int id)
        {
            return $"Orders/View/{id}";
        }
    }
}
