using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ToDoApp.DataAccess.Contexts;
using ToDoApp.DataAccess.Interfaces;

namespace ToDoApp.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {

        private readonly ToDoContext _context;

        public Repository(ToDoContext context)
        {
            _context = context;
        }



        public async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByFilter(Expression<Func<T, bool>> filter, bool asNoTracking = false)
        {
            return asNoTracking ? await _context.Set<T>().SingleOrDefaultAsync(filter) : await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetById(object id)
        {
            return await _context.Set<T>().FindAsync();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
