using AccessLibrary;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        IocClass ic = new IocClass();
        
        //var container = new UnityContainer();

       private readonly IBisnessLogic _bisnessLogic;
       // String param = ConfigurationManager.AppSettings["Source"];

      /*  public WebForm1(IBisnessLogic bisnessLogic)
        {
            _bisnessLogic = bisnessLogic;
        }*/


        protected void Page_Load(object sender, EventArgs e)
        {
            ic.Ioc();
            var container = new UnityContainer();
            //container.RegisterType<IMenu, Menu>();
            container.RegisterType<IBisnessLogic, BisnessLogic>();
            //String param = ConfigurationManager.AppSettings["Source"];
            if (RadioButtonList1.SelectedValue == "Memory")
            {
                container.RegisterType<IPersonAccessor, MemoryPersonAccessor>();
            }
            if (RadioButtonList1.SelectedValue == "File")
            {
                container.RegisterType<IPersonAccessor, FilePersonAccessor>();
            }
            if (RadioButtonList1.SelectedValue == "DataBase")
            {
                container.RegisterType<IPersonAccessor, ADONETPersonAccessor>();
            }
            if (RadioButtonList1.SelectedValue == "CustomORM")
            {
                container.RegisterType<IPersonAccessor, DBPersonAccessor>();
            }
            var bisness = container.Resolve<IBisnessLogic>().GetAll();//.BisnessLogic(); //Resolve<IMenu>().MainMenu();
          
        }
        // Получить все значения
        protected void GetAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioButtonList1.SelectedValue == "Memory")
                {
                    /*AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                    Resultlbl.Text = mpa.GetAll();*/
                   // bisness.GetAll();
                    Resultlbl.Text = _bisnessLogic.GetAll();
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
                    Resultlbl.Text = corm.GetAllORM(typeof(Person));

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        // Поиск значения по имени
        protected void GetByNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nm2 = Name.Text;
            /*    if (RadioButtonList1.SelectedValue == "Memory")
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
                    Resultlbl.Text = corm.GetByNameORM(typeof(Person).GetField("name"), typeof(Person), nm2);
                }*/
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //Пререзапись значения
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nm3 = Name.Text;
                string vl3 = Value.Text;
             /*   if (RadioButtonList1.SelectedValue == "Memory")
                {
                    AccessLibrary.MemoryPersonAccessor mpa = new AccessLibrary.MemoryPersonAccessor();
                    Resultlbl.Text = mpa.Update(nm3, vl3);
                }
                if (RadioButtonList1.SelectedValue == "File")
                {
                    AccessLibrary.FilePersonAccessor mpa = new AccessLibrary.FilePersonAccessor();
                    mpa.ParseFile();
                    Resultlbl.Text = mpa.Update(nm3, vl3);
                }
                if (RadioButtonList1.SelectedValue == "DataBase")
                {
                    Resultlbl.Text = anpa.Update(nm3, vl3);
                }
                if (RadioButtonList1.SelectedValue == "CustomORM")
                {
                    Resultlbl.Text = corm.UpdateORM(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm3, vl3);
                }*/
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        // Удаление значения
        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nm4 = Name.Text;
              /*  if (RadioButtonList1.SelectedValue == "Memory")
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
                    Resultlbl.Text = corm.DeleteORM(typeof(Person).GetField("name"), typeof(Person), nm4);
                }*/
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        // Добавление нового значения
        protected void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nm5 = Name.Text;
                string vl5 = Value.Text;
         /*       if (RadioButtonList1.SelectedValue == "Memory")
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
                    Resultlbl.Text = corm.AddORM(typeof(Person).GetField("name"), typeof(Person), typeof(Person).GetField("value"), nm5, vl5);
                }*/
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}