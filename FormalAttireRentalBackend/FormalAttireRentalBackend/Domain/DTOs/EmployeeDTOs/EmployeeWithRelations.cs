using FormalAttireRentalBackend.Domain.DTOs.RoleDTOs;
using FormalAttireRentalBackend.Domain.DTOs.UserDTOs;
using FormalAttireRentalBackend.Domain.Entities;

namespace FormalAttireRentalBackend.Domain.DTOs.EmployeeDTOs
{
    public class EmployeeWithRelations : EmployeeDTO
    {
        public UserDTO User { get; set; } = null!;
        public RoleDTO Role { get; set; } = null!;
    }
}
