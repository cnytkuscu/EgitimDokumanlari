using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.DataAccess.Interfaces;

namespace ToDoApp.DataAccess.UnitOfWork
{
    public interface IUoW
    {
        IRepository<T> GetRepository<T>() where T : class, new();

        Task SaveChanges();

        
    }
}
