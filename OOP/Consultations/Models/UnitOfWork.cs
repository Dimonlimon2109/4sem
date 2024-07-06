namespace Consultations.Models
{
    public class UnitOfWork : IDisposable
    {
        private readonly Context _context;
        private bool _disposed;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(Context context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
            _disposed = false;
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return (IRepository<T>)_repositories[typeof(T)];
            }

            var repository = new Repository<T>(_context);
            _repositories.Add(typeof(T), repository);
            return repository;
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex) { }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
