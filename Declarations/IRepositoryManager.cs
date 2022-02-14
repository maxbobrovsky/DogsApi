using System;
using System.Collections.Generic;
using System.Text;

namespace Declarations
{
    public interface IRepositoryManager
    {
        IDogRepository Dog { get; }
        void Save();
    }
}
