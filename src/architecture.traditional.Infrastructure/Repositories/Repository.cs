using architecture.traditional.Infrastructure.Context;
using architecture.traditional.Infrastructure.Interfaces;

namespace architecture.traditional.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private PersonDbContext _context;
        public Repository(PersonDbContext context)
        {
            _context = context;
        }

        public Task Delete(T model)
        {
            Console.WriteLine($"delete repository");
            return Task.CompletedTask;
        }

        public Task<object> Get(object id)
        {
            Console.WriteLine($"get repository id : {id}");
            return Task.FromResult<object>(null);
        }

        public Task<IEnumerable<T>> GetAll()
        {
            Console.WriteLine($"getAll repository");
            return null;
        }

        public Task Save(T model)
        {
            Console.WriteLine("save repository");
            return Task.CompletedTask;
        }

        public Task Update(T model)
        {
            Console.WriteLine("save repository");
            return Task.CompletedTask;
        }
    }
}