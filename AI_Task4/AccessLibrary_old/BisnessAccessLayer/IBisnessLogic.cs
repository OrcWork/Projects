using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
    public interface IBisnessLogic
    {
        string GetAll();
        string GetByName(string nm);
        void Update(string nm, string vl);
        void Delete(string nm);
        void Add(string nm, string vl);

        string GetAllORM(Type t);
        string GetByNameORM(FieldInfo fieldInfo, Type t, string nm);
        void UpdateORM(FieldInfo fieldInfo, Type t, FieldInfo fieldInfo2, string nm, string vl);
        void DeleteORM(FieldInfo fieldInfo, Type t, string nm);
        void AddORM(FieldInfo fieldInfo, Type t, FieldInfo fieldInfo2, string nm, string vl);
    }
}
