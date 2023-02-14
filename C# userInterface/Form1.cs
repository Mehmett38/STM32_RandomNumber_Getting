using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace modelingTx
{
    public partial class Form1 : Form
    {
        List<char> receiveDataChar;
        List<int> receiveDataInt;
        int counter = 0;
        int sum;
        public Form1()
        {
            InitializeComponent();
            labelConnectionState.Text = "No connection";
            labelConnectionState.BackColor = Color.Red;
            initialSetting();           //Takes the port from user 
            receiveDataChar = new List<char>();
            receiveDataInt = new List<int>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //initialize the comboboxes
        void initialSetting()
        {
            string[] names = SerialPort.GetPortNames();
            foreach (string item in names)
            {
                comboBoxPorts.Items.Add(item);
            }
            int[] baudRates = { 9600, 19200, 38400 };
            foreach (int item in baudRates)
            {
                comboBoxBaudRate.Items.Add(item);
            }
            comboBoxPorts.SelectedIndex = 0;
            comboBoxBaudRate.SelectedIndex = 0;

        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == false)
            {
                serialPort1.BaudRate = (int)comboBoxBaudRate.SelectedItem;
                serialPort1.PortName = (string)comboBoxPorts.SelectedItem;
                serialPort1.Open();
                labelConnectionState.Text = "Connected";
                labelConnectionState.BackColor = Color.Green;
            }
        }
        private void buttonDisConnect_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                labelConnectionState.Text = "No connection";
                labelConnectionState.BackColor = Color.Red;
            }
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            if (radioButtonChar.Checked == true)
            {
                char receiveChar = (char)serialPort1.ReadChar();
                listBoxReceive.Invoke(new printForm(listBoxYaz), receiveChar);
                
            }
            else if(radioButtonUint8.Checked == true)
            {
                //int txMessage = serialPort1.ReadChar();
                //receiveDataInt.Add(txMessage);
                int txI = serialPort1.ReadByte();
                sum += txI << (counter * 8);
                counter++;
                if(counter % 4 ==0)
                {
                    counter = 0;
                    listBoxReceive.Invoke(new printForm(listBoxYaz), sum);
                    sum = 0;
                }

            }
            else
            {

            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxReceive.Items.Clear();
        }
        
        public delegate void printForm(int chr);
        public void listBoxYaz(int chr)
        {
            listBoxReceive.Items.Add(chr);
        }


        private void radioButtonChar_Click(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            radioButtonChar.Checked = false;
            radioButtonUint8.Checked = false;
            radioButtonUint16.Checked = false;
            button.Checked = true;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                int txNumber = Convert.ToInt32(textBoxTransmit.Text);

                byte[] b = BitConverter.GetBytes(txNumber);
                serialPort1.Write(b, 0, 4);
            }
        }

        private void buttonYazdır_Click(object sender, EventArgs e)
        {
            List<int> listBoxData = new List<int>();

            for(int i = 0; i<listBoxReceive.Items.Count;i++)
            {
                listBoxData.Add((int)listBoxReceive.Items[i]);
            }
            string path = @"C:\Users\Mehmet Dincer\Desktop\Kitaplar ve PDFs\3.Sınıf Güz\Matlab\RandomNumberProject\.net.txt";
            //path kısmını kendinize göre ayarlamanız gerekmektedir.
			File.Delete(path);
            FileStream fs =  File.Create(path);
            fs.Close();
            string message;
            for(int i = 0;i<listBoxData.Count;i++)
            {
                message = listBoxData[i].ToString() + "\n";
                File.AppendAllText(path, message);
                
            }
            MessageBox.Show("Kaydetme İşlemi Başarıyla Gerçekleşti", "", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
