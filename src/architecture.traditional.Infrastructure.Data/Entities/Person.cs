using System.ComponentModel.DataAnnotations;

namespace architecture.traditional.Infrastructure.Data.Entities
{
    public class Person
    {
        public Person(Guid id, string name)
        {
            Id = id;
            Name = name;
            Created = DateTime.Now;
        }

        public Guid Id { get; private set; }

        [StringLength(20, ErrorMessage = "The {0} value cannot exceed {1} characters.")]
        public string Name { get; private set; }
        public DateTime Created { get; private set; }

    }
}