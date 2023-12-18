using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_Abbeveratorio
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }
        SerialPort serialPort;
        private void FormServer_Load(object sender, EventArgs e)
        {
            // Imposta la configurazione della porta seriale
            try
            {
                serialPort = new SerialPort("COM4", 9600);
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
            }
            catch
            {
                MessageBox.Show("Errore dal server");
            }

        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receivedData = serialPort.ReadExisting();
            var sms = ParseReceivedSMS(receivedData);
            if (sms != null)
            {
                if (sms.SenderNumber == "+393517221757")
                {
                    // Inserisci sms nel database della postazione 1
                    Server s1 = new Server("1");
                    s1.UpdateDatabase(sms.SenderNumber, sms.MessageText);


                }
                else if (sms.SenderNumber == "+393405030840")
                {
                    // Inserisci sms nel database della postazione 2
                    Server s2 = new Server("2");
                    s2.UpdateDatabase(sms.SenderNumber, sms.MessageText);
                }
                else if (sms.SenderNumber == "+393337728453")
                {
                    // Inserisci sms nel database della postazione 3
                    Server s3 = new Server("3");
                    s3.UpdateDatabase(sms.SenderNumber, sms.MessageText);
                }

                if (sms != null)
                {
                    PrintSMSInformation(sms);
                }
            }
        }

        private void PrintSMSInformation(SMS sms)
        {
            if (sms != null)
            {
                string senderNumber = sms.SenderNumber;
                string messageText = sms.MessageText;
                DateTime timestamp = sms.Timestamp;

                Console.WriteLine("Nuovo SMS da: " + senderNumber);
                Console.WriteLine("Testo: " + messageText);
                Console.WriteLine("Timestamp: " + timestamp);
            }
        }


        // Si suppone che ParseReceivedSMS sia implementato per analizzare la stringa ricevuta e restituire un oggetto SMS.
        private SMS ParseReceivedSMS(string data)
        {
            // Utilizzo di espressioni regolari per estrarre informazioni dall'SMS
            Regex regex = new Regex(@"Num (\+\d{12}) :(.+) (\d{2}/\d{2}/\d{4} \d{2}:\d{2}:\d{2})");
            Match match = regex.Match(data);

            if (match.Success)
            {
                SMS sms = new SMS
                {
                    SenderNumber = match.Groups[1].Value,
                    MessageText = match.Groups[2].Value,
                    Timestamp = DateTime.ParseExact(match.Groups[3].Value, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                };
                return sms;
            }
            else
            {
                // Restituisci null se i dati ricevuti non corrispondono al formato atteso
                return null;
            }
        }


        // Definizione della classe SMS (da sostituire con la implementazione effettiva)
        public class SMS
        {
            public string SenderNumber { get; set; } = "+393517221757";
            public string MessageText { get; set; } = "Num +393517221757 :preallarme cibo 12/12/2023 09:47:35";
            public DateTime Timestamp { get; set; } = DateTime.Now;
        }
        private DateTime GetLastKeepaliveTime(string stationId)
        {
            // ottenere l'orario dell'ultimo keepalive dal database per la postazione specificata
            // Ad esempio:
            if (stationId == "1")
            {
                // ottenere l'orario dell'ultimo keepalive per la postazione 1
                return DateTime.Now.AddHours(-10); // Simulazione: ritorna un orario che supera le 12 ore per attivare la notifica
            }
            else if (stationId == "2")
            {
                //ottenere l'orario dell'ultimo keepalive per la postazione 2
                return DateTime.Now.AddHours(-11); // Simulazione: ritorna un orario che supera le 12 ore per attivare la notifica
            }
            else if (stationId == "3")
            {
                //  ottenere l'orario dell'ultimo keepalive per la postazione 3
                return DateTime.Now.AddHours(-9); // Simulazione: ritorna un orario che supera le 12 ore per attivare la notifica
            }
            else
            {
                // Gestione di situazioni non previste
                return DateTime.Now;
            }
        }

        // Metodo fittizio per notificare un problema di keepalive per una specifica postazione
        private void NotifyKeepaliveIssue(string stationId)
        {
            // Sostituisci con la tua logica per notificare l'errore di connettività per la postazione specificata
            // Ad esempio:
            Console.WriteLine($"Attenzione: Problema di connettività per la postazione {stationId}");
            // Aggiungi la logica per inviare una notifica agli operatori o gestire l'errore di connettività
        }

        private void CheckKeepalive()
        {
            while (true)
            {
                // Ottieni l'orario dell'ultimo keepalive per ogni postazione dal database
                DateTime lastKeepaliveStation1 = GetLastKeepaliveTime("1");
                DateTime lastKeepaliveStation2 = GetLastKeepaliveTime("2");
                DateTime lastKeepaliveStation3 = GetLastKeepaliveTime("3");

                // Calcola la differenza di tempo tra l'ultimo keepalive e l'orario corrente
                TimeSpan differenceStation1 = DateTime.Now - lastKeepaliveStation1;
                TimeSpan differenceStation2 = DateTime.Now - lastKeepaliveStation2;
                TimeSpan differenceStation3 = DateTime.Now - lastKeepaliveStation3;

                // Verifica se la differenza per ciascuna postazione supera le 12 ore
                if (differenceStation1.TotalHours > 12)
                {
                    NotifyKeepaliveIssue("1");
                }
                if (differenceStation2.TotalHours > 12)
                {
                    NotifyKeepaliveIssue("2");
                }
                if (differenceStation3.TotalHours > 12)
                {
                    NotifyKeepaliveIssue("3");
                }

                // Attendi un intervallo di tempo prima di controllare di nuovo
                System.Threading.Thread.Sleep(60000); // Controlla ogni minuto, puoi regolare l'intervallo come desideri
            }
        }

    }
   

}
