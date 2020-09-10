using AutoMapper;
using Northwind.Blazor.ViewModels;
using Northwind.Data.Models;

namespace Northwind.Blazor.Profiles
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<Employees, EmployeeViewModel>()
                .ForMember(x => x.Territories, opts => opts.MapFrom(src => src.EmployeeTerritories))
                .ForMember(x => x.LineManager, opts => opts.MapFrom(src => src.ReportsToNavigation));

            CreateMap<Orders, OrderViewModel>();

            CreateMap<OrderDetails, OrderDetailViewModel>();
        }
    }
}
