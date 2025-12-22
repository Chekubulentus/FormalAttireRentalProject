using AutoMapper;
using FormalAttireRentalBackend.Application.Common.Models;
using FormalAttireRentalBackend.Domain.DTOs.EmployeeDTOs;
using FormalAttireRentalBackend.Domain.Interfaces;
using FormalAttireRentalBackend.Infrastracture.DataContext;
using MediatR;

namespace FormalAttireRentalBackend.Application.Employees.Queries.GetAllEmployees
{
    public class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, Result<List<EmployeeDTO>>>
    {
        private readonly IEmployeeRepository _employeeRepo;
        private readonly IMapper _mapper;
        public GetAllEmployeesQueryHandler(
            IEmployeeRepository employeeRepo,
            IMapper mapper
            )
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
        }
        public async Task<Result<List<EmployeeDTO>>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _employeeRepo.GetAllEmployeesAsync();
            if (!employees.Any() || employees.Count() == 0)
                return Result<List<EmployeeDTO>>.Failure("No employees currently found.");

            var employeeDtos = _mapper.Map<List<EmployeeDTO>>(employees);

            return Result<List<EmployeeDTO>>.SuccessWithData(employeeDtos);
        }
    }
}
