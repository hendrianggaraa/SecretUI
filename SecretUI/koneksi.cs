using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace SecretUI
{
    class koneksi
    {
        private MySqlConnection dbconnect;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public koneksi()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "connectcsharptomysql";
            uid = "username";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            dbconnect = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                dbconnect.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                dbconnect.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string secretNoid, string Description, string Stock, string Location)
        {
            string query = "INSERT INTO `secret_tb`(`secretNoid`, `Description`, `Stock`, `Location`) VALUES (@secretNoid,@Description,@Stock,@Location)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand insert;
                insert = dbconnect.CreateCommand();
                insert.CommandText = query;
                insert.Parameters.AddWithValue("@secretNoid", secretNoid);
                insert.Parameters.AddWithValue("@Description", Description);
                insert.Parameters.AddWithValue("@Stock", Stock);
                insert.Parameters.AddWithValue("@Location", Location);

                //Execute command
                insert.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string secretNoid, string Description, string Stock, string Location)
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand update;
                update = dbconnect.CreateCommand();
                update.CommandText = query;
                update.Parameters.AddWithValue("@secretNoid", secretNoid);
                update.Parameters.AddWithValue("@Description", Description);
                update.Parameters.AddWithValue("@Stock", Stock);
                update.Parameters.AddWithValue("@Location", Location);

                //Execute query
                update.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string secretNoid)
        {
            string query = "DELETE FROM `secret_tb` WHERE secretNoid =@secretNoid";

            if (this.OpenConnection() == true)
            {
                MySqlCommand delete;
                delete = dbconnect.CreateCommand();
                delete.CommandText = query;
                delete.Parameters.AddWithValue("@secretNoid", secretNoid);
                delete.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }

}
