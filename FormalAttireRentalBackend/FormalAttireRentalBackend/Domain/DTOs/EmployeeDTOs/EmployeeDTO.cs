using FormalAttireRentalBackend.Domain.Entities;

namespace FormalAttireRentalBackend.Domain.DTOs.EmployeeDTOs
{
    public class EmployeeDTO
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
        public string FullName
        {
            get { return $"{LastName}, {FirstName}"; }
        }
    }
}
