using AutoMapper;
using Northwind.Blazor.ViewModels;
using Northwind.Data.Models;

namespace Northwind.Blazor.Profiles
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<Categories, CategoryViewModel>();

            CreateMap<Customers, CustomerViewModel>();

            CreateMap<Employees, EmployeeViewModel>()
                .ForMember(x => x.Territories, opts => opts.MapFrom(src => src.EmployeeTerritories))
                .ForMember(x => x.LineManager, opts => opts.MapFrom(src => src.ReportsToNavigation));

            CreateMap<Orders, OrderViewModel>()
                .ForMember(x => x.Shipper, opts => opts.MapFrom(src => src.ShipViaNavigation));

            CreateMap<OrderDetails, OrderDetailViewModel>();

            CreateMap<Products, ProductViewModel>();

            CreateMap<Shippers, ShipperViewModel>();

            CreateMap<Suppliers, SupplierViewModel>();
        }
    }
}
