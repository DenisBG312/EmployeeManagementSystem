using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.Data.Models.Enum;
using static ModelConstraints.ValidationConstraints;

namespace EmployeeManagementSystem.Web.ViewModels.Employee
{
    public class EditEmployeeFormModel
    {
        [Required]
        [StringLength(EmployeeNameMaxLength, MinimumLength = EmployeeNameMinLength)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(EmployeeNameMaxLength, MinimumLength = EmployeeNameMinLength)]
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
    }
}