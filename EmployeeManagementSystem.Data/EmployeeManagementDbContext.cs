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
        }
    }
}
