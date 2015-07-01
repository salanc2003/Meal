using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MealServer
{
    class SqlMgr
    {
        string dbHost = "129.0.0.1";//資料庫位址
        string dbUser = "root";//資料庫使用者帳號
        string dbPass = "bedbmysql";//資料庫使用者密碼
        string dbName = "mealorder";//資料庫名稱

        public void InsertTest()
        {

            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();

            String Name;
            for (int i = 0; i < 10; i++)
            {
                Name = "group" + i.ToString();
                command.CommandText = "Insert into group(Name) values('" + Name + ")";
                command.ExecuteNonQuery();
            }
            Console.ReadLine();
            conn.Close();
        }
    }
}
