using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Models
{
    internal enum EntityState
    {
        Unchanged,
        Added,
        Changed,
        Deleted
    }
}
