using System.ComponentModel.DataAnnotations;

namespace architecture.traditional.Domain.Models
{
    public class PersonModel
    {
        [Required]
        public Guid Id { get; set; }

        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}