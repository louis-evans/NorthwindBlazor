using System.Collections.Generic;

namespace Northwind.Blazor.ViewModels
{
    public class ShipperViewModel
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public IEnumerable<OrderViewModel> Orders { get; set; }
    }
}
