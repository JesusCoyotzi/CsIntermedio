using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace MonitorSerial
{
    public partial class Form1 : Form
    {
        SerialPort Port;
        public delegate void del(string msg);
        volatile private Boolean continua=false;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AvaliblePorts();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceiveBox.Text = "";
            try
            {
                if (SendBox.Text != "")
                {
                    Port.PortName = SendBox.Text;
                }
                else
                {
                    Port.PortName = "COM3";
                }
                if (!Port.IsOpen)
                {
                    ThreadStart PS = new ThreadStart(Read);
                    Thread hiloLectura = new Thread(PS);
                    Port.Open();
                    continua = true;
                    hiloLectura.Start();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void AvaliblePorts()
        {
            ReceiveBox.Text = "";
            ReceiveBox.Text = "Puertos Disponibles:" + Environment.NewLine;
            foreach (string s in SerialPort.GetPortNames())
            {
                ReceiveBox.Text = ReceiveBox.Text + s + Environment.NewLine;
            }
            Port = new SerialPort();

        }

        private void listarPuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaliblePorts();
        }

        private void SetReceivedText(string s)
        {
              if (ReceiveBox.InvokeRequired)
            {
                del delegado = new del(SetReceivedText);
                ReceiveBox.Invoke(delegado, new object[] {s});
            }
              else
              {
                  ReceiveBox.Text += s;
                  ReceiveBox.Text += Environment.NewLine;
              }
        }

        public void Read()
        {
            while (continua)
            {
                try
                {
                    string line = Port.ReadLine();
                    SetReceivedText(line);
                }
                catch (TimeoutException) { }
            }
            Port.Close();
        }

        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            continua = false;
            System.Diagnostics.Debug.Print("{0}",continua);
            SendBox.Text = continua.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            continua = false;
            if (Port.IsOpen)
            {
                Port.Close();
            }
        }

        private void Mandar_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                Port.Write(SendBox.Text);
            }
            else
            {
                SendBox.Text = "Sin conexión";
            }
            SendBox.Text = "";
        }
    }


}
