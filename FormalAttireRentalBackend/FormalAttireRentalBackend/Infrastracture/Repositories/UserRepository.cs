using FormalAttireRentalBackend.Domain.Entities;
using FormalAttireRentalBackend.Domain.Interfaces;

namespace FormalAttireRentalBackend.Infrastracture.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool ArchiveUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public User GetUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
