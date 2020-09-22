using System.Collections.Generic;

namespace Northwind.Blazor.ViewModels
{
    public class RegionViewModel
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        public virtual IEnumerable<TerritoryViewModel> Territories { get; set; }
    }
}
