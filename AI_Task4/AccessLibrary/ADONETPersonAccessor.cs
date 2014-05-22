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

        public string GetAll()
        {
            string query = "SELECT * FROM Person";
            connection.Open();
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
            connection.Open();
            SqlCeCommand command = new SqlCeCommand(query, connection);
            SqlCeDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                str = str + read["NAME"].ToString() + "=" + read["VALUE"].ToString() + "\n";
            }
            connection.Close();
            return str;
        }

        public string Update(string nm, string vl)
        {
            connection.Open();
            string query = @"UPDATE Person SET Value = '" + vl + "' WHERE Name='" + nm + "'";
            SqlCeCommand command = new SqlCeCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            str = "Значение перезаписано";
            return str;
        }

        public string Delete(string nm)
        {
            connection.Open();
            string query = @"DELETE FROM Person WHERE Name='" + nm + "'";
            SqlCeCommand command = new SqlCeCommand(query, connection);
            command.ExecuteNonQuery();
            str = "Значение удалено";
            connection.Close();
            return str;
        }

        public string Add(string nm, string vl)
        {
            connection.Open();
            string query = @"INSERT INTO Person (Name, Value) VALUES ('" + nm + "', '" + vl + "')";
            SqlCeCommand command = new SqlCeCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            str = "Значение добавлено";
            return str;
        }
    }
}
