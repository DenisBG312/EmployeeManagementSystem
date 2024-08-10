using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.Data.Models.Enum;
using static ModelConstraints.ValidationConstraints;

namespace EmployeeManagementSystem.Web.ViewModels.Employee
{
    public class AddEmployeeFormModel
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
        [RegularExpression(EmployeeEmailRegex, ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = null!;
        [Required]
        [RegularExpression(EmployeePhoneRegex, ErrorMessage = "Please enter a valid phone number.")]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        public Role Role { get; set; }
    }
}
