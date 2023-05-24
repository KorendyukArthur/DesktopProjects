using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRYPK
{
     class DB
    {
        //подключение к базе данных databasenew.auth_user
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=Sneg1123;database=databasenew");
        
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        //закрытие  базе данных 
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        // функция обращения говорит с каким сервером будем работать
        public MySqlConnection getConnection()
        {
            return connection;
        }


    }
}
