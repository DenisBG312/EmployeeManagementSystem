using EmployeeManagementSystem.Data.Models;
using EmployeeManagementSystem.Data.Models.Enum;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeManagementDbContext : DbContext
    {
        public EmployeeManagementDbContext()
        {

        }

        public EmployeeManagementDbContext(DbContextOptions options) 
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasData(new Employee
                    {
                        Id = 2,
                        FirstName = "Jane",
                        LastName = "Smith",
                        DateOfBirth = new DateTime(1990, 3, 22),
                        DateOfHire = new DateTime(2015, 8, 12),
                        PhoneNumber = "555-234-5678",
                        Role = Role.Technician
                    },
                    new Employee
                    {
                        Id = 3,
                        FirstName = "Michael",
                        LastName = "Johnson",
                        DateOfBirth = new DateTime(1982, 7, 8),
                        DateOfHire = new DateTime(2008, 2, 15),
                        PhoneNumber = "555-345-6789",
                        Role = Role.Driver
                    },
                    new Employee
                    {
                        Id = 4,
                        FirstName = "Emily",
                        LastName = "Davis",
                        DateOfBirth = new DateTime(1993, 11, 19),
                        DateOfHire = new DateTime(2017, 4, 25),
                        PhoneNumber = "555-456-7890",
                        Role = Role.ITSupport
                    },
                    new Employee
                    {
                        Id = 5,
                        FirstName = "Christopher",
                        LastName = "Lee",
                        DateOfBirth = new DateTime(1978, 12, 2),
                        DateOfHire = new DateTime(2003, 11, 10),
                        PhoneNumber = "555-567-8901",
                        Role = Role.Technician
                    });
        }
    }
}
