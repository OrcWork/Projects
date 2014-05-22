using AccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task4Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        AccessLibrary.DBPersonAccessor corm = new AccessLibrary.DBPersonAccessor();
        AccessLibrary.ADONETPersonAccessor anpa = new AccessLibrary.ADONETPersonAccessor();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Получить все значения
        protected void GetAllButton_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue == "Memory")
            {
                AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                Resultlbl.Text = mpa.GetAll();
            }
            if (RadioButtonList1.SelectedValue == "File")
            {
                AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                Resultlbl.Text = mpa.GetAll();
            }
            if (RadioButtonList1.SelectedValue == "DataBase")
            {
                Resultlbl.Text = anpa.GetAll();
            }
            if (RadioButtonList1.SelectedValue == "CustomORM")
            {
                Resultlbl.Text = corm.GetAll(typeof(Person));

            }
        }

        // Поиск значения по имени
        protected void GetByNameButton_Click(object sender, EventArgs e)
        {
            string nm2 = Name.Text;
            if (RadioButtonList1.SelectedValue == "Memory")
            {
                AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                Resultlbl.Text = mpa.GetByName(nm2);
            }
            if (RadioButtonList1.SelectedValue == "File")
            {
                AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                Resultlbl.Text = mpa.GetByName(nm2);
            }
            if (RadioButtonList1.SelectedValue == "DataBase")
            {
                Resultlbl.Text = anpa.GetByName(nm2);
            }
            if (RadioButtonList1.SelectedValue == "CustomORM")
            {
                Resultlbl.Text = corm.GetByName(typeof(Person).GetField("name"), typeof(Person), nm2);
            }
        }

        //Пререзапись значения
        protected void UpdateButton_Click(object sender, EventArgs e)
        {

            string nm3 = Name.Text;
            string vl3 = Value.Text;
            if (RadioButtonList1.SelectedValue == "Memory")
            {
                AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                Resultlbl.Text = mpa.Update(nm3, vl3);
            }
            if (RadioButtonList1.SelectedValue == "File")
            {
                AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                mpa.parseFile();
                Resultlbl.Text = mpa.Update(nm3, vl3);
            }
            if (RadioButtonList1.SelectedValue == "DataBase")
            {
                Resultlbl.Text = anpa.Update(nm3, vl3);
            }
            if (RadioButtonList1.SelectedValue == "CustomORM")
            {
                Resultlbl.Text = corm.Update(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm3, vl3);
            }
        }

        // Удаление значения
        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            string nm4 = Name.Text;
            if (RadioButtonList1.SelectedValue == "Memory")
            {
                AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                Resultlbl.Text = mpa.Delete(nm4);
            }
            if (RadioButtonList1.SelectedValue == "File")
            {
                AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                mpa.parseFile();
                Resultlbl.Text = mpa.Delete(nm4);
            }
            if (RadioButtonList1.SelectedValue == "DataBase")
            {
                Resultlbl.Text = anpa.Delete(nm4);
            }
            if (RadioButtonList1.SelectedValue == "CustomORM")
            {
                Resultlbl.Text = corm.Delete(typeof(Person).GetField("name"), typeof(Person), nm4);
            }
        }

        // Добавление нового значения
        protected void AddButton_Click(object sender, EventArgs e)
        {
            string nm5 = Name.Text;
            string vl5 = Value.Text;
            if (RadioButtonList1.SelectedValue == "Memory")
            {
                AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                Resultlbl.Text = mpa.Add(nm5, vl5);
            }
            if (RadioButtonList1.SelectedValue == "File")
            {
                AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                mpa.parseFile();
                Resultlbl.Text = mpa.Add(nm5, vl5);
            }
            if (RadioButtonList1.SelectedValue == "DataBase")
            {
                Resultlbl.Text = anpa.Add(nm5, vl5);
            }
            if (RadioButtonList1.SelectedValue == "CustomORM")
            {
                Resultlbl.Text = corm.Add(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm5, vl5);
            }
        }
    }
}