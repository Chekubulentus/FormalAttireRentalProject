using FormalAttireRentalBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FormalAttireRentalBackend.Infrastracture.DataContext
{
    public class AttireRentalContext : DbContext
    {
        public AttireRentalContext(DbContextOptions<AttireRentalContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>(ent =>
            {
                ent.HasKey(e => e.Id);
                ent.Property(e => e.Email).IsRequired().HasMaxLength(255);
                ent.HasIndex(e => e.EmployeeCode).IsUnique();
                ent.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                ent.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                ent.Property(e => e.MiddleName).IsRequired().HasMaxLength(100);

                //User Relationship
                ent.HasOne(e => e.User)
                    .WithOne(u => u.Employee)
                    .HasForeignKey<Employee>(e => e.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

                //Role Relationship
                ent.HasOne(e => e.Role)
                    .WithMany(r => r.Employees)
                    .HasForeignKey(e => e.RoleId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<User>(ent =>
            {
                ent.Property(u => u.Username).IsRequired().HasMaxLength(50);
                ent.Property(u => u.HashedPassword).IsRequired().HasMaxLength(255);
            });

            modelBuilder.Entity<Role>(ent =>
            {
                ent.Property(r => r.RolePosition).IsRequired().HasMaxLength(255);
            });
        }
    }
}
