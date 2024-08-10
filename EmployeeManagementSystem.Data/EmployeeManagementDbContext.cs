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
                .HasQueryFilter(e => !e.IsDeleted);
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries()
                .Where(e => e is { Entity: Employee, State: EntityState.Deleted });

            foreach (var entity in entities)
            {
                var employee = (Employee)entity.Entity;
                employee.IsDeleted = true;
                entity.State = EntityState.Modified;
            }

            return base.SaveChanges();
        }
    }
}
