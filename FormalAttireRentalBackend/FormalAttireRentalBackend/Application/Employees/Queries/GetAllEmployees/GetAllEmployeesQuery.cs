using FormalAttireRentalBackend.Application.Common.Models;
using FormalAttireRentalBackend.Domain.DTOs.EmployeeDTOs;
using MediatR;

namespace FormalAttireRentalBackend.Application.Employees.Queries.GetAllEmployees
{
    public class GetAllEmployeesQuery : IRequest<Result<List<EmployeeDTO>>>
    {

    }
}
