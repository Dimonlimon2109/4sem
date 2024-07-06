namespace Consultations.Models
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();

        IEnumerable<T> GetAllWithInclude(params string[] navigationProperties);
        T GetById(Guid id);
    }
}
