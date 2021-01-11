using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;


namespace SecretUI
{
    public partial class Quick : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        conMysql ConMysql;
        conArd ConArd;
        bool isConnected = false;
        int input;
        int input2;
        int loc;
        private MySqlCommand perintah1;
        private MySqlDataReader baca1;
        private MySqlCommand perintah2;
        private MySqlDataReader baca2;
        public Quick()
        {
            InitializeComponent();
            ConMysql = new conMysql();
            disable();
        }

        //===============================BACA=============================================================================
        private void btnCheck_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM secret_db.secret_tb WHERE secretNoid =" + int.Parse(textNoid.Text);
            perintah1 = new MySqlCommand(selectQuery, connection);
            baca2 =  perintah1.ExecuteReader();

            if (baca2.Read())
            {
                textDescription.Text = baca2.GetString("Description");
                labelStock.Text = baca2.GetString("Stock");
            }
            else
            {
                textDescription.Text = "";
                labelStock.Text = "";
                MessageBox.Show("Tidak Ada Data ID Ini");
            }

            connection.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void radioPut_CheckedChanged(object sender, EventArgs e)
        {
            textJumlah.Enabled = true;
        }

        private void radioTake_CheckedChanged(object sender, EventArgs e)
        {
            textJumlah.Enabled = true;
        }

        private void textJumlah_TextChanged(object sender, EventArgs e)
        {
            btnAccept.Enabled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            accbtn();
        }

        void disable()
        {

            btnAccept.Enabled = false;
            textJumlah.Enabled = false;
            radioPut.Checked = false;
            radioTake.Checked = false;
            textJumlah.Enabled = false;
        }

        private void reset()
        {
            textNoid.Clear();
            textDescription.Clear();
            textJumlah.Clear();
            label_location.Text = "None";
            labelStock.Text = "None";
            radioPut.Checked = false;
            radioTake.Checked = false;
            btnCheck.Enabled = false;
            btnAccept.Enabled = false;
            textJumlah.Enabled = false;
        }

        private void Quick_VisibleChanged(object sender, EventArgs e)
        {
            if (isConnected == true) isConnected = false;
        }

        private void writeport(string nilai)
        {
            ConArd.SendData(nilai);
        }

        public void viewdata()
        {
            dataGridView1.DataSource = ConMysql.ViewData();
        }
        private void accbtn()
        {
            input = Convert.ToInt32(labelStock.Text);
            input2 = Convert.ToInt32(textJumlah.Text);
            label_location.Text = loc.ToString();

            if (radioPut.Checked == true) input += input2;
            else if  (radioTake.Checked == true) input -= input2;
            {
                labelStock.Text = input.ToString();
                backgroundWorker1.RunWorkerAsync();
                ConMysql.Update(textNoid.Text, textDescription.Text, labelStock.Text, label_location.Text);
              /*  viewdata();
                    string select = "SELECT * FROM secret_db.secret_tb WHERE secretNoid =" + int.Parse(label_location.Text);
                    perintah2 = new MySqlCommand(select, connection);
                    baca2 = perintah2.ExecuteReader();
                    if (baca2.Read())
                    {
                        label_location.Text = baca2.GetString("Location");
                        //  textJumlah.Text = baca2.GetString("Stock");
                    }
                    else
                    {
                        label_location.Text = "";
                        //  textJumlah.Text = "";
                        MessageBox.Show("Tidak Ada Data ID Ini");
                    }*/
               // disable();
              //  reset();
           //     ConArd.SendData(loc.ToString());
                }
            }
        }

    }


    

