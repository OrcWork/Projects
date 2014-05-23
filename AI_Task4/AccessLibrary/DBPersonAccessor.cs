using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccessLibrary
{
    public class DBPersonAccessor
    {
        SqlCeConnection connection =
            new SqlCeConnection(@"Data Source=D:\C#\Projects\AI_Task4\AccessLibrary\ADONETPADB.sdf");//Data Source=(LocalDB)\v11.0;AttachDbFilename="C:\Users\Andrey_Isaev\Documents\Visual Studio 2010\Projects\AI_Task4\AI_Task3\Database1.mdf";Integrated Security=True
        string str = "";
        Exception notFoundExcaption = new Exception("Имя не найдено");
        Exception connectDBExcaption = new Exception("Ошибка поключения к базе данных, проверьте указанный путь к базе данных");

        // Вывод всех значений в базе
        public string GetAll(Type t)
        {
            System.Attribute[] attrs = Attribute.GetCustomAttributes(t);
            try
            {
                connection.Open();
            }
            catch
            {
                throw connectDBExcaption;
            }
            foreach (Attribute attr in attrs)
            {
                if (attr is Attribut)
                {
                    Attribut att = (Attribut)attr;
                    string query = "SELECT * FROM " + att.TableName + "";
                    SqlCeCommand command = new SqlCeCommand(query, connection);
                    SqlCeDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        str = str + read[0].ToString() + "=" + read[1].ToString() + "\n";
                    }
                }
            }
            connection.Close();
            return str;
        }

        //Поиск значения по имени
        public string GetByName(FieldInfo fieldInfo, Type t, string nm)
        {
            Attribute[] attrtable = Attribute.GetCustomAttributes(t);
            try
            {
                connection.Open();
            }
            catch
            {
                throw connectDBExcaption;
            }
            foreach (Attribute attrtab in attrtable)
            {
                if (attrtab is Attribut)
                {
                    Attribut attt = (Attribut)attrtab;
                    Attribute[] attrcolum1 = Attribute.GetCustomAttributes(fieldInfo);
                    foreach (Attribute attrcol1 in attrcolum1)
                    {
                        if (attrcol1 is Attribut)
                        {
                            Attribut attc1 = (Attribut)attrcol1;
                            string query = @"SELECT * FROM " + attt.TableName + " WHERE " + attc1.Colum1 + "='" + nm + "'";
                            SqlCeCommand command = new SqlCeCommand(query, connection);
                            SqlCeDataReader read = command.ExecuteReader();
                            while (read.Read())
                            {
                                str = str + read[0].ToString() + "=" + read[1].ToString() + "\n";
                            }
                        }
                    }
                }
            }
            connection.Close();
            if (str == "") throw notFoundExcaption;
            return str;
        }

        //Перезапись значения в базе
        public string Update(FieldInfo fieldInfo, Type t, FieldInfo fieldInfo2, string nm, string vl)
        {
            GetByName(fieldInfo, t, nm);
            Attribute[] attrtable = Attribute.GetCustomAttributes(t);
            try
            {
                connection.Open();
            }
            catch
            {
                throw connectDBExcaption;
            }
            foreach (Attribute attrtab in attrtable)
            {
                if (attrtab is Attribut)
                {
                    Attribut attt = (Attribut)attrtab;
                    Attribute[] attrcolum1 = Attribute.GetCustomAttributes(fieldInfo);
                    foreach (Attribute attrcol1 in attrcolum1)
                    {
                        if (attrcol1 is Attribut)
                        {
                            Attribut attc1 = (Attribut)attrcol1;
                            Attribute[] attrcolum2 = Attribute.GetCustomAttributes(fieldInfo2);
                            foreach (Attribute attrcol2 in attrcolum2)
                            {
                                if (attrcol1 is Attribut)
                                {
                                    Attribut attc2 = (Attribut)attrcol2;
                                    string query = @"UPDATE " + attt.TableName + " SET " + attc2.Colum2 + " = '" + vl + "' WHERE " + attc1.Colum1 + "='" + nm + "'";
                                    SqlCeCommand command = new SqlCeCommand(query, connection);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
            connection.Close();
            str = "Значение перезаписано";
            return str;
        }

        //Удаление значения из базы
        public string Delete(FieldInfo fieldInfo, Type t, string nm)
        {
            GetByName(fieldInfo, t, nm);
            Attribute[] attrtable = Attribute.GetCustomAttributes(t);
            try
            {
                connection.Open();
            }
            catch
            {
                throw connectDBExcaption;
            }
            foreach (Attribute attrtab in attrtable)
            {
                if (attrtab is Attribut)
                {
                    Attribut attt = (Attribut)attrtab;
                    Attribute[] attrcolum1 = Attribute.GetCustomAttributes(fieldInfo);
                    foreach (Attribute attrcol1 in attrcolum1)
                    {
                        if (attrcol1 is Attribut)
                        {
                            Attribut attc1 = (Attribut)attrcol1;
                            string query = @"DELETE FROM " + attt.TableName + " WHERE " + attc1.Colum1 + "='" + nm + "'";
                            SqlCeCommand command = new SqlCeCommand(query, connection);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            connection.Close();
            str = "Значение удалено";
            return str;
        }

        //Добавление нового значения в базу
        public string Add(FieldInfo fieldInfo, Type t, FieldInfo fieldInfo2, string nm, string vl)
        {
            Attribute[] attrtable = Attribute.GetCustomAttributes(t);
            try
            {
                connection.Open();
            }
            catch
            {
                throw connectDBExcaption;
            }
            foreach (Attribute attrtab in attrtable)
            {
                if (attrtab is Attribut)
                {
                    Attribut attt = (Attribut)attrtab;
                    Attribute[] attrcolum1 = Attribute.GetCustomAttributes(fieldInfo);
                    foreach (Attribute attrcol1 in attrcolum1)
                    {
                        if (attrcol1 is Attribut)
                        {
                            Attribut attc1 = (Attribut)attrcol1;
                            Attribute[] attrcolum2 = Attribute.GetCustomAttributes(fieldInfo2);
                            foreach (Attribute attrcol2 in attrcolum2)
                            {
                                if (attrcol1 is Attribut)
                                {
                                    Attribut attc2 = (Attribut)attrcol2;
                                    string query = @"INSERT INTO " + attt.TableName + " (" + attc1.Colum1 + ", " + attc2.Colum2 + ") VALUES ('" + nm + "', '" + vl + "')";
                                    SqlCeCommand command = new SqlCeCommand(query, connection);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
            connection.Close();
            str = "Значение добавлено";
            return str;
        }
    }
}
