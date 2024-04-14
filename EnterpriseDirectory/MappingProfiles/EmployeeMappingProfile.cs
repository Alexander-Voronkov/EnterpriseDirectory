using AutoMapper;
using Domain;
using EnterpriseDirectory.Models;
using EnterpriseDirectory.ViewModels.AddEmployees;
using EnterpriseDirectory.ViewModels.ModifyEmployees;

namespace EnterpriseDirectory.MappingProfiles;

public class EmployeeMappingProfile : Profile
{
    public EmployeeMappingProfile()
    {
        CreateMap<Employee, EmployeeDto>().ReverseMap();
        CreateMap<AddEmployeeViewModel, Employee>().ReverseMap();
        CreateMap<ModifyEmployeeViewModel, Employee>().ReverseMap();
        CreateMap<ModifyEmployeeViewModel, EmployeeDto>().ReverseMap();
    }
}