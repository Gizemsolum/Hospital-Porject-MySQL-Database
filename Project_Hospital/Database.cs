using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_Hospital
{
    class Database
    {

        public MySqlConnection Connection(){

            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=root;database=hospital");
            connection.Open();
            return connection;  

        }//end of Connection

    }//end of class
}
