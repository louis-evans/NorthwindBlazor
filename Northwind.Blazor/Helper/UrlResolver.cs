namespace Northwind.Blazor.Helper
{
    public class UrlResolver
    {
        public string CategoryView(string id)
        {
            return $"Categories/View/{id}";
        }

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

        public string ProductView(int id)
        {
            return $"Products/View/{id}";
        }

        public string CategoryView(int id)
        {
            return $"Categories/View/{id}";
        }

        public string RegionsView(int id)
        {
            return $"Regions/View/{id}";
        }

        public string ShipperView(int id)
        {
            return $"Shippers/View/{id}";
        }

        public string SupplierView(int id)
        {
            return $"Suppliers/View/{id}";
        }

        public string TerritoriesView(string id)
        {
            return $"Territories/View/{id}";
        }
    }
}
