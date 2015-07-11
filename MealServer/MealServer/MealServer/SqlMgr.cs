using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Data.Services;

namespace MealServer
{
    class SqlMgr
    {
        string dbHost = "129.0.0.1";//資料庫位址
        string dbUser = "root";//資料庫使用者帳號
        string dbPass = "bedbmysql";//資料庫使用者密碼
        string dbName = "mealorder";//資料庫名稱

        #region InsetTest
        //public void InsertTest()
        //{

        //    string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
        //    MySqlConnection conn = new MySqlConnection(connStr);
        //    MySqlCommand command = conn.CreateCommand();
        //    conn.Open();

        //    String Name;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Name = "group" + i.ToString();
        //        command.CommandText = "Insert into group(Name) values('" + Name + ")";
        //        command.ExecuteNonQuery();
        //    }
        //    Console.ReadLine();
        //    conn.Close();
        //}
        #endregion


        MealOrderEntities mEntities = new MealOrderEntities();
        public BaseService<bloc> BlocMgr;

        public SqlMgr()
        {
            BlocMgr = new BaseService<bloc>(mEntities);

        }

        public void AddBloc(bloc iData)
        {
            BlocMgr.Add(iData);    
        }

        //public void AddBloc(string iBlocName)
        //{
        //    MealOrderEntities aEntities = new MealOrderEntities();
        //    bloc abloc = new bloc();
        //    abloc.Name = iBlocName;
        //    aEntities.bloc.Add(abloc);
        //    aEntities.SaveChanges();
        //}

        //public void UpdateBloc(int ID,string iBlocName)
        //{
        //    MealOrderEntities aEntities = new MealOrderEntities();
        //    var aResult = (from bloc in aEntities.bloc where bloc.ID == ID select bloc).First();
        //    aResult.Name = iBlocName;
        //    aEntities.SaveChanges();
        //}

        //public void DeleteBloc(int ID)
        //{
        //    MealOrderEntities aEntities = new MealOrderEntities();
        //    var aResult = (from bloc in aEntities.bloc where bloc.ID == ID select bloc).First();
        //    aEntities.bloc.Remove(aResult);
        //    aEntities.SaveChanges();
        //}

        //public void 
    }
}
