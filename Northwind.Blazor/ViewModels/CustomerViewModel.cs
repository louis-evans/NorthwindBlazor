using Northwind.Data.Models;
using System.Collections.Generic;

namespace Northwind.Blazor.ViewModels
{
    public class CustomerViewModel
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public IEnumerable<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
        public IEnumerable<OrderViewModel> Orders { get; set; }
    }
}
