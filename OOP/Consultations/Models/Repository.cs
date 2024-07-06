using Microsoft.EntityFrameworkCore;

namespace Consultations.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Context _context;
        private DbSet<T> _entities;

        public Repository(Context context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _entities.Add(entity);
        }
        public void Update(T entity)
        {
            try
            {
                _entities.Attach(entity);
            }
            catch { }
            _entities.Update(entity);
        }
        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }
        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public IEnumerable<T> GetAllWithInclude(params string[] navigationProperties)
        {
            IQueryable<T> query = _entities;
            foreach (string navigationProperty in navigationProperties)
            {
                query = query.Include(navigationProperty);
            }
            return query.ToList();
        }


        public T GetById(Guid id)
        {
            return _entities.Find(id);
        }
    }
}
