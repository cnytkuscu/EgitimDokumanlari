using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DataAccess.Contexts;
using ToDoApp.DataAccess.Interfaces;
using ToDoApp.DataAccess.Repositories;

namespace ToDoApp.DataAccess.UnitOfWork
{
    public class UoW : IUoW
    {
        private readonly ToDoContext _context;

        public UoW(ToDoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChanges()
        {
           await _context.SaveChangesAsync();
        }
    }
}
