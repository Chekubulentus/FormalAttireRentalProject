using AutoMapper;
using FormalAttireRentalBackend.Domain.DTOs.EmployeeDTOs;
using FormalAttireRentalBackend.Domain.Entities;

namespace FormalAttireRentalBackend.Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>();
        }
    }
}
