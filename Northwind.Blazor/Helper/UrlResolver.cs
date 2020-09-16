using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Blazor.Helper
{
    public class UrlResolver
    {
        public string EmployeeView(int id)
        {
            return $"Employees/View/{id}";
        }
    }
}
