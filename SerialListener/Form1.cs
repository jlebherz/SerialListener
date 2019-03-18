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
using System.IO;

namespace SerialListener
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            serialPort1 = new SerialPort();
            serialPort2 = new SerialPort();
            this.lable_connected_com1.BackColor = Color.Red;
            this.lable_connected_com2.BackColor = Color.Red;
        }

        SerialPort serialPort1;
        SerialPort serialPort2;
        delegate void InvokeLB1(string Data1);
        InvokeLB1 lbRecievedDelegate1;
        delegate void InvokeLB2(string Data2);
        InvokeLB2 lbRecievedDelegate2;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in SerialPort.GetPortNames())
            {
                cbPort1.Items.Add(item);
                cbPort2.Items.Add(item);
            }
            cbPort1.Text = cbPort1.Items[0].ToString();
            cbPort2.Text = cbPort2.Items[0].ToString();

            rbCR.Select();

            cbBaudRate1.Items.Add("110");
            cbBaudRate1.Items.Add("300");
            cbBaudRate1.Items.Add("600");
            cbBaudRate1.Items.Add("1200");
            cbBaudRate1.Items.Add("2400");
            cbBaudRate1.Items.Add("4800");
            cbBaudRate1.Items.Add("9600");
            cbBaudRate1.Items.Add("14400");
            cbBaudRate1.Items.Add("19200");
            cbBaudRate1.Items.Add("28800");
            cbBaudRate1.Items.Add("38400");
            cbBaudRate1.Items.Add("56000");
            cbBaudRate1.Items.Add("57600");
            cbBaudRate1.Items.Add("115200");
            cbBaudRate1.Text = cbBaudRate1.Items[10].ToString();

            cbBaudRate2.Items.Add("110");
            cbBaudRate2.Items.Add("300");
            cbBaudRate2.Items.Add("600");
            cbBaudRate2.Items.Add("1200");
            cbBaudRate2.Items.Add("2400");
            cbBaudRate2.Items.Add("4800");
            cbBaudRate2.Items.Add("9600");
            cbBaudRate2.Items.Add("14400");
            cbBaudRate2.Items.Add("19200");
            cbBaudRate2.Items.Add("28800");
            cbBaudRate2.Items.Add("38400");
            cbBaudRate2.Items.Add("56000");
            cbBaudRate2.Items.Add("57600");
            cbBaudRate2.Items.Add("115200");
            cbBaudRate2.Text = cbBaudRate1.Items[10].ToString();
        }

        private void bPort1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = cbPort1.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBaudRate1.Text);
                if(rbR.Checked)serialPort1.NewLine = "\n";
                if (rbCR.Checked) serialPort1.NewLine = "\r";
                serialPort1.Open();
                lbRecievedDelegate1 = new InvokeLB1(InvokeLBRecieved1);
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived1); //DataRecieved Event abonnieren
                this.bPort1.Text = "Close";
                this.lable_connected_com1.Text = "Connected";
                this.lable_connected_com1.BackColor = Color.Green;
                goto ende_create;
            }
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.Dispose();
                this.lable_connected_com1.Text = "Closed";
                this.lable_connected_com1.BackColor = Color.Red;
                this.bPort1.Text = "Open";
            }
            ende_create:
            bPort1.Show();
        }

        void serialPort_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DoUpdate1));
        }

        void DoUpdate1(object s, EventArgs e)
        {
            string RecievedLine = " ";
            RecievedLine = serialPort1.ReadLine();
            tbResult.Invoke(lbRecievedDelegate1, new object[] { RecievedLine });
        }
        void InvokeLBRecieved1(string Data)
        {
            if(use_porttrenner.Checked)tbResult.Items.Add("Port1___________________________________________________________");
            tbResult.Items.Add(Data);
        }

        private void bPort2_Click(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen)
            {
                serialPort2.PortName = cbPort2.Text;
                serialPort2.BaudRate = Convert.ToInt32(cbBaudRate2.Text);
                //serialPort2.NewLine = cbZeilenende.Text;
                if (rbR.Checked) serialPort2.NewLine = "\n";
                if (rbCR.Checked) serialPort2.NewLine = "\r";
                serialPort2.Open();
                lbRecievedDelegate2 = new InvokeLB2(InvokeLBRecieved2);
                serialPort2.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived2); //DataRecieved Event abonnieren
                this.bPort2.Text = "Close";
                this.lable_connected_com2.Text = "Connected";
                this.lable_connected_com2.BackColor = Color.Green;
                goto ende_create2;
            }
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
                serialPort2.Dispose();
                this.lable_connected_com2.Text = "Closed";
                this.lable_connected_com2.BackColor = Color.Red;
                this.bPort2.Text = "Open";
            }
            ende_create2:
            bPort2.Show();
        }
        void serialPort_DataReceived2(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DoUpdate2));
        }

        void DoUpdate2(object s, EventArgs e)
        {
            string RecievedLine = " ";
            RecievedLine = serialPort2.ReadLine();
            tbResult.Invoke(lbRecievedDelegate2, new object[] { RecievedLine });
        }
        void InvokeLBRecieved2(string Data)
        {
            if (use_porttrenner.Checked)tbResult.Items.Add("Port2___________________________________________________________");
            tbResult.Items.Add(Data);
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.systemhaus-lebherz.de");
        }

        private void dateiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort2.Close();
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show(this);
        }

        private void bClearSent_Click(object sender, EventArgs e)
        {
            tbResult.Items.Clear();
        }

    }
}
