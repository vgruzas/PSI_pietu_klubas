using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psi_2uzduotis
{
    interface IDBOperatable
    {
        string Insert();
        string Update();
        string Delete();
        string Read();
    }
}
