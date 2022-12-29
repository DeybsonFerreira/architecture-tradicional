using architecture.traditional.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace architecture.traditional.Infrastructure.Context
{
    public class PersonDbContext : DbContext
    {
        // public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        // {
        //     Database.EnsureCreated();
        // }

        public DbSet<Person> Person { get; set; }
    }
}