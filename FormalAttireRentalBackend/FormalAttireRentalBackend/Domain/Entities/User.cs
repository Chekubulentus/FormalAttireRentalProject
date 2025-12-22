using FormalAttireRentalBackend.Domain.Common;

namespace FormalAttireRentalBackend.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = "";
        public string HashedPassword { get; set; } = "";

        // Nav Prop
        public Employee Employee { get; set; } = null!;
    }
}
