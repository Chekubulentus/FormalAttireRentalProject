using FormalAttireRentalBackend.Domain.Entities;
using FormalAttireRentalBackend.Domain.Interfaces;
using FormalAttireRentalBackend.Infrastracture.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FormalAttireRentalBackend.Infrastracture.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AttireRentalContext _context;
        public EmployeeRepository(AttireRentalContext context)
        {
            _context = context;
        }

        public Task<bool> ArchiveEmployeeWithUserAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateNewEmployeeUserAsync(Employee request, User user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.AsNoTracking()
                .ToListAsync();
        }

        public Task<Employee> GetEmployeeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEmployeeAsync(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
