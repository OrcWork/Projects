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
        string str = "";
        Exception notFoundExcaption = new Exception("Имя не найдено");
        Exception connectDBExcaption = new Exception("Ошибка поключения к базе данных, проверьте указанный путь к базе данных");

        public string GetAll()
        {
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

        public string Update(string nm, string vl)
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
            str = "Значение перезаписано";
            return str;
        }

        public string Delete(string nm)
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
            str = "Значение удалено";
            connection.Close();
            return str;
        }

        public string Add(string nm, string vl)
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
            str = "Значение добавлено";
            return str;
        }

    }
}
