using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Zara
{
    class podklclss
    {
        public static string DS;
        public static string LOGIN;
        public static string PASSWORD;
        public static string DB;

        public SqlConnection conection = new SqlConnection("Data Source = Empty; Initial Catalog = Empty; " +
            "Persist Security Info = True;User ID = Empty; Password = \"Empty\"");

        public void Register_get()
        {
            try
            {
                RegistryKey connection_setting = Registry.CurrentUser; //создаем con_set для текущих настроек в реестре
                RegistryKey DBCon = connection_setting.CreateSubKey("connetion_setting1");//название папки
                DS = DBCon.GetValue("DS").ToString();//элемент data source
                LOGIN = DBCon.GetValue("LOGIN").ToString();//элемент login
                PASSWORD = DBCon.GetValue("PASSWORD").ToString();//элементы password
                DB = DBCon.GetValue("DB").ToString();//элемент database
                Set_Connection();

            }
            catch
            {
                RegistryKey connection_setting = Registry.CurrentUser;
                RegistryKey DBCon = connection_setting.CreateSubKey("connetion_setting1");
                DBCon.SetValue("DS", "Empty");
                DBCon.SetValue("LOGIN", "Empty");
                DBCon.SetValue("PASSWORD", "Empty");
                DBCon.SetValue("DB", "Empty");

            }
        }

        public void Register_set(string DSvalue, string LOGINvalue, string PASSWORDvalue, string DBvalue)
        {
            RegistryKey connection_setting = Registry.CurrentUser;
            RegistryKey DBCon = connection_setting.CreateSubKey("connetion_setting1");
            DBCon.SetValue("DS", DSvalue);
            DBCon.SetValue("LOGIN", LOGINvalue);
            DBCon.SetValue("PASSWORD", PASSWORDvalue);
            DBCon.SetValue("DB", DBvalue);
            Register_get();

        }

        public void Set_Connection()
        {
            conection.ConnectionString = "Data Source = " + DS + ";Initial Catalog = " + DB + ";Persist Security Info = True;User ID = " + LOGIN + ";Password = \"" + PASSWORD + "\"";
        }
    }
}
