using FormalAttireRentalBackend.Domain.Common;

namespace FormalAttireRentalBackend.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string RolePosition { get; set; } = "";

        //Nav Prop
        public List<Employee> Employees { get; set; } = null!;
    }
}
