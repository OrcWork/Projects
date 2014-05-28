using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
    public class BisnessLogic : IBisnessLogic
    {
        private readonly IPersonAccessor _allPersonAccessor;


        public BisnessLogic(IPersonAccessor allPersonAccessor)
        {
            _allPersonAccessor = allPersonAccessor;
        }
        public string GetAll()
        {
            return _allPersonAccessor.GetAll();
        }

        public string GetByName(string nm)
        {
            return _allPersonAccessor.GetByName(nm);
        }

        public void Update(string nm, string vl)
        {
            _allPersonAccessor.Update(nm, vl);
        }

        public void Delete(string nm)
        {
            _allPersonAccessor.Delete(nm);
        }

        public void Add(string nm, string vl)
        {
            _allPersonAccessor.Add(nm, vl);
        }


        public string GetAllORM(Type t)
        {
            return _allPersonAccessor.GetAllORM(t);
        }

     public string GetByNameORM(System.Reflection.FieldInfo fieldInfo, Type t, string nm)
        {
            return _allPersonAccessor.GetByNameORM(fieldInfo, t, nm);
        }

        public void UpdateORM(System.Reflection.FieldInfo fieldInfo, Type t, System.Reflection.FieldInfo fieldInfo2, string nm, string vl)
        {
            _allPersonAccessor.UpdateORM(fieldInfo, t, fieldInfo2, nm, vl);
        }

        public void DeleteORM(System.Reflection.FieldInfo fieldInfo, Type t, string nm)
        {
            _allPersonAccessor.DeleteORM(fieldInfo, t, nm);
        }

        public void AddORM(System.Reflection.FieldInfo fieldInfo, Type t, System.Reflection.FieldInfo fieldInfo2, string nm, string vl)
        {
            _allPersonAccessor.AddORM(fieldInfo, t, fieldInfo2, nm, vl);
        }
    }
}
