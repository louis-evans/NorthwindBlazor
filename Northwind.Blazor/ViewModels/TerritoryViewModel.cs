using Northwind.Data.Models;

namespace Northwind.Blazor.ViewModels
{
    public class TerritoryViewModel
    {
        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        public virtual RegionViewModel Region { get; set; }
    }
}
