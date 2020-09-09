using AutoMapper;
using Northwind.Blazor.ViewModels;
using Northwind.Data.Models;

namespace Northwind.Blazor.Profiles
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<Employees, EmployeeViewModel>();
        }
    }
}
