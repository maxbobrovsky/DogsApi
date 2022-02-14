using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Declarations
{
    public interface IDogRepository
    {
        IEnumerable<Dog> GetAllDogs(bool trackChanges);
    }
}
