using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace SecretUI
{
    public class conMysql
    {
        private MySqlConnection ConMysql;
        private string server;
        private string database;
        private string uid;
        private string password;
        string[] zero = { "Null" };

        //Constructor
        public conMysql()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "secret_db";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Database=" + database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
            ConMysql = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                ConMysql.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                ConMysql.Close();
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
                insert = ConMysql.CreateCommand();
                insert.CommandText = query;
                insert.Parameters.AddWithValue("@secretNoid", secretNoid);
                insert.Parameters.AddWithValue("@Description", Description);
                insert.Parameters.AddWithValue("@Stock", Stock);
                insert.Parameters.AddWithValue("@Location", Location);

                //Execute command
                insert.ExecuteNonQuery();
                MessageBox.Show("Behasil");

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string secretNoid, string Description, string Stock, string Location)
        {
            string query = "UPDATE `secret_tb` SET `Description`=@Description,`Stock`=@Stock,`Location`=@Location WHERE `secretNoid`=@secretNoid";

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand update;
                update = ConMysql.CreateCommand();
                update.CommandText = query;
                update.Parameters.AddWithValue("@secretNoid", secretNoid);
                update.Parameters.AddWithValue("@Description", Description);
                update.Parameters.AddWithValue("@Stock", Stock);
                update.Parameters.AddWithValue("@Location", Location);

                //Execute query
                update.ExecuteNonQuery();
                MessageBox.Show("Behasil");

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
                delete = ConMysql.CreateCommand();
                delete.CommandText = query;
                delete.Parameters.AddWithValue("@secretNoid", secretNoid);
                delete.ExecuteNonQuery();
                MessageBox.Show("Behasil");

                //close connection
                this.CloseConnection();
            }
        }

        public void UpdateOpt(bool con, string nilai, string secretnoid)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand Opt;
                Opt = ConMysql.CreateCommand();
                if (con == true) Opt.CommandText = "UPDATE `secret_tb` SET `Stock` = `Stock` + @nilai WHERE `secretNoid` = @secretNoid";
                else Opt.CommandText = "UPDATE `secret_tb` SET `Stock` = `Stock` - @nilai WHERE `secretNoid` = @secretNoid";
                Opt.Parameters.AddWithValue("@nilai", nilai);
                Opt.Parameters.AddWithValue("@secretNoid", secretnoid);
                Opt.ExecuteNonQuery();
                MessageBox.Show("Behasil");

                //close connection
                this.CloseConnection();
            }
        }

        public DataSet Search(string Tseacrh)
        {
            DataSet ds = new DataSet();

            if (this.OpenConnection() == true)
            {
                MySqlCommand Search;
                Search = ConMysql.CreateCommand();
                Search.CommandText = "SELECT * FROM `secret_tb` WHERE secretNoid =@secretNoid";
                Search.Parameters.AddWithValue("@secretNoid", Tseacrh);
                MySqlDataAdapter adapter = new MySqlDataAdapter(Search);
                adapter.Fill(ds);

                this.CloseConnection();
            }
            else ds.Tables.Add();
            return ds;
        }

        public DataSet ViewData()
        {
            DataSet ds = new DataSet();

            if (this.OpenConnection() == true)
            {
                MySqlCommand viewdata;
                viewdata = ConMysql.CreateCommand();
                viewdata.CommandText = "select * from secret_tb";
                MySqlDataAdapter adapter = new MySqlDataAdapter(viewdata);
                adapter.Fill(ds);

                this.CloseConnection();
            }
            else ds.Tables.Add();
            return ds;
        }

        public DataSet SelectSingle(string secretnoid, string target)
        {
            DataSet ds = new DataSet();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmdLoc;
                cmdLoc = ConMysql.CreateCommand();
                cmdLoc.CommandText = "SELECT " + target + " FROM `secret_tb` WHERE `secretNoid` = @secretnoid";
                cmdLoc.Parameters.AddWithValue("@secretNoid", secretnoid);
                cmdLoc.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdLoc);
                adapter.Fill(ds);

                this.CloseConnection();
            }
            else ds.Tables.Add();
            return ds;
        }
    }
}
