using System;
using System.Linq;

namespace Declarations
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindEntities(bool trackChanges);
        void Create(T Entity);
    }
}
