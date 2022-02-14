using Declarations;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationContext appContext;
        private IDogRepository dogRepository;

        public RepositoryManager(ApplicationContext _appContext)
        {
            appContext = _appContext;
        }
        public IDogRepository Dog
        {
            get
            {
                if(dogRepository == null)
                {
                    dogRepository = new DogRepository(appContext);
                }
                return dogRepository;
            }
        }

        public void Save()
        {
            appContext.SaveChanges();
        }
    }
}
