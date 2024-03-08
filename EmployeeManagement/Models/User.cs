using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace EmployeeManagement.Models
{
    public class User
    {
      
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name{ get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter age")]
        [Range(16,65, ErrorMessage = "Enter age between 16 to 65")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter email")]       
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage ="It is not a valid email address")]
        public string Email { get; set; }= string.Empty;

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }=string.Empty;

    }
}
