using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.Data.Models.Enum;

using static ModelConstraints.ValidationConstraints;

namespace EmployeeManagementSystem.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(EmployeeNameMaxLength)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(EmployeeNameMaxLength)]
        public string LastName { get; set; } = null!;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime DateOfHire { get; set; }
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        public Role Role { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
