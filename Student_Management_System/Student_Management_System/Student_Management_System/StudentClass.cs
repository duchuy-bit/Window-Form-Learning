using Student_Management_System.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Student_Management_System
{
    class StudentClass
    {
        DBConnect connect = new DBConnect();
        // create a function to add new student to the database

        public bool insertStudent(string fName, string lName, DateTime bDate, string phone, string gender, string address, byte[] image )
        {
            MySqlCommand mySqlCommand = new MySqlCommand(
                "INSERT INTO `student`\r\n(`StdFirstName`, `StdLastName`, `BirthDate`, `Gender`, `Phone`, `Address`, `Photo`) \r\nVALUES \r\n(@fn, @ln, @bdate, @gender, @phone, @address, @photo)",
                connect.getConnecttion
            );

            // @fn, @ln, @bdate, @gender, @phone, @address, @photo
            mySqlCommand.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fName;
            mySqlCommand.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lName;
            mySqlCommand.Parameters.Add("@bdate", MySqlDbType.Date).Value = bDate;
            mySqlCommand.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            mySqlCommand.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            mySqlCommand.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            mySqlCommand.Parameters.Add("@photo", MySqlDbType.LongBlob).Value = image;

            connect.openConnection();
            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }
        }

        public DataTable getStudentList()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("Select * from student", connect.getConnecttion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            return dt;
        }

        //execute the count query || (total, male, female)
        public string exeCount(string query)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(query, connect.getConnecttion);
            connect.openConnection();
            string count = mySqlCommand.ExecuteScalar().ToString() ?? "0";
            connect.closeConnection();

            return count;

        }

        public DataTable filterStudentList(string textFind)
        {
            //StdFirstName StdLastName Gender Phone Address
            MySqlCommand mySqlCommand = new MySqlCommand("Select * from student where concat(StdFirstName, StdLastName, Phone, Address) like '%" + textFind + "%'", connect.getConnecttion);
            

            MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            return dt;
        }


        public DataTable deleteStudent(string textFind)
        {
            //StdFirstName StdLastName Gender Phone Address
            MySqlCommand mySqlCommand = new MySqlCommand("Select * from student where concat(StdFirstName, StdLastName, Phone, Address) like '%" + textFind + "%'", connect.getConnecttion);


            MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            return dt;
        }

        public bool updateStudent(int id, string fName, string lName, DateTime bDate, string phone, string gender, string address, byte[] image)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(
               "UPDATE `student` SET `StdFirstName`=@fname,`StdLastName`=@lname,`BirthDate`=@bdate,`Gender`=@gender,`Phone`=@phone,`Address`=@address,`Photo`=@photo WHERE `StdId` = " + id,
               connect.getConnecttion
           );

            // @fn, @ln, @bdate, @gender, @phone, @address, @photo
            mySqlCommand.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fName;
            mySqlCommand.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lName;
            mySqlCommand.Parameters.Add("@bdate", MySqlDbType.Date).Value = bDate;
            mySqlCommand.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            mySqlCommand.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
            mySqlCommand.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            mySqlCommand.Parameters.Add("@photo", MySqlDbType.LongBlob).Value = image;

            connect.openConnection();
            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }
        }
    }
}
