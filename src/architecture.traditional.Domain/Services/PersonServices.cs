using architecture.traditional.Domain.Models;
using architecture.traditional.Domain.Repository;
using architecture.traditional.Infrastructure.Context;
using architecture.traditional.Infrastructure.Data.Entities;
using architecture.traditional.Infrastructure.Repositories;

namespace architecture.traditional.Domain.Services
{
    public class PersonServices : Repository<Person>, IPersonServices
    {
        public PersonServices(PersonDbContext context) : base(context)
        {

        }

        public async Task<PersonModel> Get(Guid personId)
        {
            Person person = (Person)await base.Get(personId);

            PersonModel result = new PersonModel();
            //test
            result.Id = personId;
            result.Name = "Deybson Ferreira";
            result.Created = new DateTime(2022, 12, 29);

            //parse model
            // result.Id = person.Id;
            // result.Name = person.Name;
            // result.Created = person.Created;
            return result;
        }

        public bool Save(PersonModel model)
        {
            Person person = new Person(model.Id, model.Name);
            base.Save(person);

            return true;
        }
    }
}