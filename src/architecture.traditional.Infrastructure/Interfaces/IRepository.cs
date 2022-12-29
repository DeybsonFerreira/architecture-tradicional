namespace architecture.traditional.Infrastructure.Interfaces
{
    public interface IRepository<T>
    {
        Task Save(T model);
        Task<object> Get(object id);
        Task<IEnumerable<T>> GetAll();
        Task Delete(T model);
        Task Update(T model);
    }
}