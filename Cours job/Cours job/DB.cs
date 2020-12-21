using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours_job
{
    public class DB
    {
        MySqlConnection connecter = new MySqlConnection(@"Data Source=DESKTOP-5QMTKGR\SQLEXPRESS;Initial Catalog=tellcompany;Connect Timeout=30;");

        public void OpenConnection()
        {
            if (connecter.State == System.Data.ConnectionState.Closed)
                connecter.Open();
        }
        public void CloseConnection()
        {
            if (connecter.State == System.Data.ConnectionState.Open)
                connecter.Close();
        }

        public MySqlConnection GetConect()
        {
            return connecter;
        }
    }
}
