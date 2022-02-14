using Declarations;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class DogRepository : RepositoryBase<Dog>, IDogRepository
    {
        public DogRepository(ApplicationContext appContext) : base(appContext)
        {

        }
        public IEnumerable<Dog> GetAllDogs(bool trackChanges)
        {
            return FindEntities(trackChanges).OrderBy(x => x.Name).ToList();            
        }
    }
}
