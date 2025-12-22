using FormalAttireRentalBackend.Domain.Entities;

namespace FormalAttireRentalBackend.Domain.Interfaces
{
    public interface IRoleRepository
    {
        public List<Role> GetAllRolesAsync();
        public Role GetRoleByIdAsync(int roleId);
        public bool CreateNewRoleAsync(Role request);
        public bool ArchiveRoleByIdAsync(int roleId);
        public bool UpdateRoleAsync(int roleId);
    }
}
