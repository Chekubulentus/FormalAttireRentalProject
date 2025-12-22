using FormalAttireRentalBackend.Domain.Entities;

namespace FormalAttireRentalBackend.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetAllEmployeesAsync();
        public Task<Employee> GetEmployeeByIdAsync(int id);
        public Task<int> CreateNewEmployeeUserAsync(Employee request, User user);
        public Task<bool> ArchiveEmployeeWithUserAsync(int employeeId);
        public Task<bool> UpdateEmployeeAsync(int employeeId);
    }
}
