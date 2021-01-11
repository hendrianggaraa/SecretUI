using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.Management;
//using System.Runtime.InteropServices;



namespace SecretUI
{
    public partial class Form1 : Form

//==================Membuat Form Tidak Persegi Tapi Bulat di setiap sisi & shadow===============
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
            home1.BringToFront();
            //hiden();
            //overviewSub1.Visible = true;

        }
    

//================================Shadow Rounded Form==========================================
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
//===========================Cek & Koneksi Database=======================================

        MySqlConnection koneksi = new MySqlConnection("Server=localhost;Database=secret_db;Uid=root;Pwd=;");

       // bool isConnected = false;
       // String[] ports;
       // SerialPort port;

//==================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            Cek_Koneksimysql();
            string portNum = "";
            string port = "";
            string pesan1 = "PORT ARDUINO NOT AVAILABLE, CLOSE & COBA LAGI";
            serialPort1.Close();
            foreach (string ports in SerialPort.GetPortNames())
            {
                portNum = ports.ToString();
                textBox1.Text = portNum;
                port = textBox1.Text;
            }

            try {
                serialPort1.PortName = (port);
                serialPort1.BaudRate = 115200;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.Encoding = System.Text.Encoding.Default;
                labelArduino.Text = "Connected";
                labelArduino.ForeColor = ColorTranslator.FromHtml("#1ABC9C");
            }
            catch
            {
                labelArduino.Text = "Disconnect";
                labelArduino.ForeColor = ColorTranslator.FromHtml("#F44336");
                MessageBox.Show (pesan1);
            }
        }

 //====================================================================================

        private void Cek_Koneksimysql()
        {
            string pesan2 = "PORT MYSQL NOT AVAILABLE, CLOSE & COBA LAGI";
            try
            {
                koneksi.Open();
                koneksi.Close();
                labelMysql.Text = "Connected";
                labelMysql.ForeColor = ColorTranslator.FromHtml("#1ABC9C");
            }

            catch (Exception)
            {
                labelMysql.Text = "Disconnect";
                labelMysql.ForeColor = ColorTranslator.FromHtml("#F44336");
                MessageBox.Show(pesan2);
            }
        }
//=============================================================================================


//=============================SidePanel===============================================
        
        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
            home1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            quick1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button3.Height;
            Sidepanel.Top = button3.Top;
            advance1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button4.Height;
            Sidepanel.Top = button4.Top;
            administrator1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button5.Height;
            Sidepanel.Top = button5.Top;
            about1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button8.Height;
            Sidepanel.Top = button8.Top;
            bantuan1.BringToFront();
        }

        //======================================================================================


        /* int mouseX = 0, mouseY = 0;
         bool mouseDown;

         private void Form1_MouseDown(object sender, MouseEventArgs e)
         {
             mouseDown = true;
         }

         private void Form1_MouseMove(object sender, MouseEventArgs e)
         {
             if (mouseDown)
             {
                 mouseX = MousePosition.X -200;
                 mouseY = MousePosition.Y -40;

                 this.SetDesktopLocation(mouseX, mouseY);
             }
         }

         private void Form1_MouseUp(object sender, MouseEventArgs e)
         {
             mouseDown = false;
         }

         */

        //==============================================MOUSE MOVE FORM & CLOSE====================================

        bool drag;
        int mouseX , mouseY ;

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            drag = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //=================================================================================================


        public string pesan2 { get; set; }

        private void bantuan1_Load(object sender, EventArgs e)
        {

        }

        private void about1_Load(object sender, EventArgs e)
        {

        }
    }
}

        
