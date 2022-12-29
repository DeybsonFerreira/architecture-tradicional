using architecture.traditional.Domain.Models;

namespace architecture.traditional.Domain.Repository
{
    public interface IPersonServices
    {
        bool Save(PersonModel person);
        Task<PersonModel> Get(Guid personId);
    }
}