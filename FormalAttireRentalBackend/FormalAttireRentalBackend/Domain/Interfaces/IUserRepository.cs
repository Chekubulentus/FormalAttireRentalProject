using FormalAttireRentalBackend.Domain.Entities;

namespace FormalAttireRentalBackend.Domain.Interfaces
{
    public interface IUserRepository
    {
        public List<User> GetAllUsersAsync();
        public User GetUserByIdAsync(int userId);
        public bool ArchiveUserByIdAsync(int userId);
        public bool UpdateUserAsync(int userId);
    }
}
