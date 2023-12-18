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


namespace WA_Abbeveratorio
{
    public partial class Form1 : Form
    {


        SerialPort _serialPort;
        bool flag_preallarme_acqua;
        bool flag_preallarme_cibo;
        bool flag_allarme_acqua;
        bool flag_allarme_cibo;
        string postazioneInvio = string.Empty;

        public Form1()
        {

            InitializeComponent();
            this.BackColor = Color.White;
            flag_preallarme_acqua = false;
            flag_preallarme_cibo = false;
            flag_allarme_acqua = false;
            flag_allarme_cibo = false;
            _serialPort = new SerialPort("COM4");
            _serialPort.BaudRate = 9600;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Parity = Parity.None;
            _serialPort.Handshake = Handshake.None;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rb_sim1.Checked)
            {
              
                postazioneInvio = "1";
            
            }
            else if (rb_sim2.Checked)
            {
               
                postazioneInvio = "2";
            
            }
            else if (rb_sim3.Checked)
            {
              
                postazioneInvio = "3";
              
            }
            else
            {
              
                postazioneInvio = "1";
           
            }




            FormKeepAlive f1 = new FormKeepAlive(postazioneInvio);
            f1.ShowDialog();
            



        }

        void SendSMS(string phoneNumber, string message)
        {
            try
            {
                _serialPort.Open();

                _serialPort.WriteLine("AT+CMGF=1"); // Set SMS text mode
                System.Threading.Thread.Sleep(1000);
                MessageBox.Show(phoneNumber);
                _serialPort.WriteLine("AT+CMGS=\"" + phoneNumber + "\""); // Replace with the recipient's phone number
                System.Threading.Thread.Sleep(1000);

                _serialPort.WriteLine(message + char.ConvertFromUtf32(26)); // Send the message content
                System.Threading.Thread.Sleep(1000);
                timer_notifica.Enabled = true;
                lbl_notifica.Visible = true;
                _serialPort.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to send SMS to phone number..");
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_sms_Click(object sender, EventArgs e)
        {
            string phoneNumber;

            if (rb_sim1.Checked)
            {
                phoneNumber = rb_sim1.Text;
                postazioneInvio = "1";
                MessageBox.Show("Sim selezionata " + phoneNumber);
            }
            else if (rb_sim2.Checked)
            {
                phoneNumber = rb_sim2.Text;
                postazioneInvio = "2";
                MessageBox.Show("Sim selezionata " + phoneNumber);
            }
            else if (rb_sim3.Checked)
            {
                phoneNumber = rb_sim3.Text;
                postazioneInvio = "3";
                MessageBox.Show("Sim selezionata " + phoneNumber);
            }
            else
            {
                phoneNumber = "+393517221757";
                postazioneInvio = "1";
                MessageBox.Show("Sim predefinita " + phoneNumber);
            }


            string allarmType = string.Empty;
            DateTime dataOra = DateTime.Now;
            if (flag_preallarme_cibo)
            {
                allarmType = "Num " + phoneNumber + " :" + "preallarme cibo " + dataOra.ToString();
            }
            if (flag_allarme_cibo)
            {
                allarmType = "Num " + phoneNumber + " :" + "allarme cibo " + dataOra.ToString();
            }
            if (flag_preallarme_acqua)
            {
                allarmType = "Num " + phoneNumber + " :" + "preallarme acqua " + dataOra.ToString();
            }
            if (flag_allarme_acqua)
            {
                allarmType = "Num " + phoneNumber + " :" + "allarme acqua " + dataOra.ToString();
            }

            SendSMS(phoneNumber, allarmType);

            //update sinottico
                

        }



        private void btn_pre1_Click(object sender, EventArgs e)
        {

            if (!flag_preallarme_cibo)
            {
                flag_preallarme_cibo = true;
                btn_preallarme_cibo.BackColor = Color.Orange;

            }
            else if (flag_preallarme_cibo)
            {
                flag_preallarme_cibo = false;
                btn_preallarme_cibo.BackColor = Color.Transparent;
            }
        }

        private void btn_allarme_Click(object sender, EventArgs e)
        {
            if (!flag_allarme_cibo)
            {
                flag_allarme_cibo = true;
                btn_allarme_cibo.BackColor = Color.Red;
            }
            else if (flag_allarme_cibo)

            {
                flag_allarme_cibo = false;
                btn_allarme_cibo.BackColor = Color.Transparent;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!flag_preallarme_acqua)
            {
                flag_preallarme_acqua = true;
                btn_preallarme_acqua.BackColor = Color.Orange;

            }
            else if (flag_preallarme_acqua)
            {
                flag_preallarme_acqua = false;
                btn_preallarme_acqua.BackColor = Color.Transparent;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!flag_allarme_acqua)
            {
                flag_allarme_acqua = true;
                btn_allarme_acqua.BackColor = Color.Red;

            }
            else if (flag_allarme_acqua)
            {
                flag_allarme_acqua = false;
                btn_allarme_acqua.BackColor = Color.Transparent;

            }
        }
        int count = 0;
        private void timer_notifica_Tick(object sender, EventArgs e)
        {
            count++;
            if (count >= 100)
            {
                timer_notifica.Enabled = false;
                lbl_notifica.Visible = false;
                if (flag_allarme_acqua)
                {
                    flag_allarme_acqua = false;
                    btn_allarme_acqua.BackColor = Color.Transparent;
                }
                if (flag_allarme_cibo)
                {
                    flag_allarme_cibo = false;
                    btn_allarme_cibo.BackColor = Color.Transparent;
                }
                if (flag_preallarme_acqua)
                {
                    flag_preallarme_acqua = false;
                    btn_preallarme_acqua.BackColor = Color.Transparent;
                }
                if (flag_preallarme_cibo)
                {
                    flag_preallarme_cibo = false;
                    btn_preallarme_cibo.BackColor = Color.Transparent;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
