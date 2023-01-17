using AutoMapper;
using Domain.Models;
using Shared.DataTransferObjects;

namespace API;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Company, CompanyDto>()
            .ForMember(c => c.FullAddress,
            opt => opt.MapFrom(x => string.Join(" ", x.Address, x.Country))).ReverseMap();

        CreateMap<Employee, EmployeeDto>().ReverseMap();

        CreateMap<CompanyForCreationDto, Company>().ReverseMap();
        CreateMap<CompanyForUpdateDto, Company>().ReverseMap();

        CreateMap<EmployeeForCreationDto, Employee>().ReverseMap();
        CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();
        CreateMap<UserForRegistrationDto, User>();
    }
}
