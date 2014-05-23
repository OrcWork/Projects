using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
    public interface IPersonAccessor
    {
        string GetAll();
        string GetByName(string nm);
        string Update(string nm, string vl);
        string Delete(string nm);
        string Add(string nm, string vl);
    }
}
