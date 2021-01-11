using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace SecretUI
{
    public class conArd
    {
        //variable
        string portselected;
        Int32 baudrate;
        Int32 databit;
        bool isConnnected;

        SerialPort port;
        string path = @"C:\conArduino.conf";
        List<string> lines;


        public conArd()
        {
            Initialize();
        }

        private void Initialize()
        {
            lines = File.ReadAllLines(path).ToList();
            portselected = lines[0];
            baudrate = Convert.ToInt32(lines[1]);
            databit = Convert.ToInt32(lines[2]);
            port = new SerialPort(portselected, baudrate, Parity.None, databit, StopBits.One);
            isConnnected = false;
        }

        public bool CheckConnection()
        {
            try
            {
                port.Open();
                port.Write("Checking Connection . . .");
                port.Write("\n");
                port.Close();
                return true;
            }
            catch (Exception)
            {
                //MessageBox.Show("Cant Check Arduino\n\n");
                return false;
            }
        }

        public bool OpenConnection()
        {
            try
            {
                port.Open();
                return true;
            }
            catch (Exception failure)
            {
                MessageBox.Show("Cant Connect To Arduino\n\n" + failure);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                port.Close();
                return true;
            }
            catch (Exception failure)
            {
                MessageBox.Show("Cant Disconnect From Arduino\n\n" + failure);
                return false;
            }
        }

        public void SendData(string data)
        {
            if (OpenConnection() == true)
            {
                port.Write("#" + data + "!");
                port.Write("\n");

                CloseConnection();
            }
        }


    }
}
