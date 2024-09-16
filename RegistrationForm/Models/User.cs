using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? State { get; set; }

        [Required]
        public string? City { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }
    }
}
