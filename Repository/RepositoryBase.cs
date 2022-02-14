using Declarations;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationContext appContext;
        public RepositoryBase(ApplicationContext _appContext)
        {
            appContext = _appContext;
        }

        public void Create(T Entity)
        {
            appContext.Set<T>().Add(Entity);
        }

        public IQueryable<T> FindEntities(bool trackChanges)
        {
            if(!trackChanges)
            {
                return appContext.Set<T>().AsNoTracking();
            }
            return appContext.Set<T>();
        }
    }
}
