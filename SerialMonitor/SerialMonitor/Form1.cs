using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SerialMonitor
{
    public partial class Form1 : Form
    {
        public delegate void del(string s);
        Thread hilo;
        public volatile bool continua;
        public SerialPort Port;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPorts();

        }

        public void listPorts()
        {
            ReceiveBox.Text = "";
            ReceiveBox.Text = "Puertos COM disponibles" + Environment.NewLine;
            foreach(string s in SerialPort.GetPortNames())
            {
                ReceiveBox.Text += s + Environment.NewLine;
            }

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (SendBox.Text == "")
                {
                    Port = new SerialPort("COM4");
                    Port.BaudRate = 9600;
                }
                else
                {
                    Port = new SerialPort(SendBox.Text);
                    Port.BaudRate = 9600;
                }

                ThreadStart PS = new ThreadStart(read);
                hilo = new Thread(PS);
                continua = true;
                Port.Open();
                hilo.Start();


             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void read()
        {
            try
            {
                while (continua)
                {
                    string line = Port.ReadLine();
                    setRecievedText(line);
                }
                Port.Close();
            }
            catch (TimeoutException)
            {
                //nada
            }
        }

        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                continua = false;
            }
        }

        private void setRecievedText(string s)
        {
            if (ReceiveBox.InvokeRequired)
            {
                del delegado = new del(setRecievedText);
                ReceiveBox.Invoke(delegado, new object[] { s });
            }
            else
            {
                ReceiveBox.Text = s + Environment.NewLine;
            }
        }
    }
}
