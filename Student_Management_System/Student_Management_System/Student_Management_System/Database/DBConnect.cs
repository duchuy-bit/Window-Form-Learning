using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Student_Management_System.Database
{
    internal class DBConnect
    {

        //to create connection
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=student_manage");

        //to get connection
        public MySqlConnection getConnecttion 
        {
             get
             {
                    return connect;
                
             }

        }

        //create a function to Open connection
        public void openConnection()
        {
            if(connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        //create a function to Close connection
        public void closeConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }


    }
}
