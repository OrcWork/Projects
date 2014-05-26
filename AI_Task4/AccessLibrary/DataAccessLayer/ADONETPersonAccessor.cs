using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
    public class ADONETPersonAccessor : IPersonAccessor
    {
        SqlCeConnection connection =
    new SqlCeConnection(@"Data Source=D:\C#\Projects\AI_Task4\AccessLibrary\ADONETPADB.sdf");
        Exception notFoundExcaption = new Exception("Имя не найдено");
        Exception connectDBExcaption = new Exception("Ошибка поключения к базе данных, проверьте указанный путь к базе данных");

        public string GetAll()
        {
            string str = "";
            string query = "SELECT * FROM Person";
            try
            {
                connection.Open();
            }
            catch 
            {
                throw connectDBExcaption;
            }
            SqlCeCommand command = new SqlCeCommand(query, connection);
            SqlCeDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                str = str + read["NAME"].ToString() + "=" + read["VALUE"].ToString() + "\n";
            }
            connection.Close();
            return str;

        }

        public string GetByName(string nm)
        {
            string str = "";
            string query = @"SELECT * FROM Person WHERE Name='" + nm + "'";
            try
            {
                connection.Open();
            }
            catch
            {
                throw connectDBExcaption;
            }
            SqlCeCommand command = new SqlCeCommand(query, connection);
            SqlCeDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                str = str + read["NAME"].ToString() + "=" + read["VALUE"].ToString() + "\n";
            }
            connection.Close();
            if (str == "") throw notFoundExcaption;
            return str;
        }

        public void Update(string nm, string vl)
        {
            GetByName(nm);
            try
            {
                connection.Open();
            }
            catch
            {
                throw connectDBExcaption;
            }
            string query = @"UPDATE Person SET Value = '" + vl + "' WHERE Name='" + nm + "'";
            SqlCeCommand command = new SqlCeCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(string nm)
        {
            GetByName(nm);
            try
            {
                connection.Open();
            }
            catch
            {
                throw connectDBExcaption;
            }
            string query = @"DELETE FROM Person WHERE Name='" + nm + "'";
            SqlCeCommand command = new SqlCeCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Add(string nm, string vl)
        {
            try
            {
                connection.Open();
            }
            catch
            {
                throw connectDBExcaption;
            }
            string query = @"INSERT INTO Person (Name, Value) VALUES ('" + nm + "', '" + vl + "')";
            SqlCeCommand command = new SqlCeCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }



        public string GetAllORM(Type t)
        {
            throw new NotImplementedException();
        }


        public string GetByNameORM(System.Reflection.FieldInfo fieldInfo, Type t, string nm)
        {
            throw new NotImplementedException();
        }

        public void UpdateORM(System.Reflection.FieldInfo fieldInfo, Type t, System.Reflection.FieldInfo fieldInfo2, string nm, string vl)
        {
            throw new NotImplementedException();
        }

        public void DeleteORM(System.Reflection.FieldInfo fieldInfo, Type t, string nm)
        {
            throw new NotImplementedException();
        }

        public void AddORM(System.Reflection.FieldInfo fieldInfo, Type t, System.Reflection.FieldInfo fieldInfo2, string nm, string vl)
        {
            throw new NotImplementedException();
        }
    }
}
