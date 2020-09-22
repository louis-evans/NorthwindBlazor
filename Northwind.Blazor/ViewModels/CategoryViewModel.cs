using System.Collections.Generic;

namespace Northwind.Blazor.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}
