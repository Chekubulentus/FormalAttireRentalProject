using FormalAttireRentalBackend.Domain.Common;

namespace FormalAttireRentalBackend.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string EmployeeCode { get; set; } = "";
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public int Age { get; set; }   
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public string? Email { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public string FullName
        {
            get { return $"{LastName}, {FirstName}"; }
        }

        // Nav Prop
        public User User { get; set; } = null!;
        public Role Role { get; set; } = null!;

    }

    public enum Gender
    {
        Male = 1,
        Female = 2,
        Others = 3
    }
}
