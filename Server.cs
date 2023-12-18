using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;

namespace WA_Abbeveratorio
{
    internal class Server
    {
        // Proprietà
        string postazione;
        string connstring;

        public Server(string postazione)
        {
            this.postazione = postazione;
            connstring = "Server=localhost;Database=abbeveratorio;" +
                "Uid=root;Pwd=Admin_123!;";
        }

        public void UpdateKeepAlive()
        {
            using (MySqlConnection connection = new MySqlConnection(connstring))
            {
                connection.Open();

                string messaggio = "keep alive attivo";

                DateTime dataInvio = DateTime.Now;

                string query = "INSERT INTO keepalivepostazione" + postazione + " (messaggio, data_record) VALUES (@messaggio, @dataInvio)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@messaggio", messaggio);

                    command.Parameters.AddWithValue("@dataInvio", dataInvio);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Messaggio keep alive inviato con successo.");
            }
        }
        public void UpdateDatabase(string stato, string messaggio)
        {
            MySqlConnection connection = new MySqlConnection(connstring);

            try
            {
                connection.Open();


                // Query per l'inserimento dei dati
                string query = "INSERT INTO " + postazione + " (stato, messaggio, data_record) " +
                    "VALUES ( @stato, @messaggio, @data_record)";

                MySqlCommand command = new MySqlCommand(query, connection);

                // Parametri per la query
                
                command.Parameters.AddWithValue("@stato", stato);
                command.Parameters.AddWithValue("@messaggio", messaggio);
                command.Parameters.AddWithValue("@data_record", DateTime.Now);

                // Esecuzione della query
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Gestione dell'errore
                MessageBox.Show(ex.ToString());
                
            }
            finally
            {
                // Chiusura della connessione
                connection.Close();
            }
        }
        public void GetMessagesFromAllPostazioni()
        {
            try
            {
                for (int i = 1; i <= 3; i++) // Supponendo che le postazioni vadano da 1 a 3
                {
                    string currentPostazione = $"postazione{i}";

                    using (MySqlConnection connection = new MySqlConnection(connstring))
                    {
                        connection.Open();

                        // Recupera il messaggio per la postazione corrente
                        string queryMessaggio = $"SELECT messaggio FROM {currentPostazione} ORDER BY data_record DESC LIMIT 1";
                        MySqlCommand commandMessaggio = new MySqlCommand(queryMessaggio, connection);

                        object resultMessaggio = commandMessaggio.ExecuteScalar();
                        string messaggio = resultMessaggio != null ? resultMessaggio.ToString() : $"Nessun messaggio trovato per la {currentPostazione}";

                        // Analizza il messaggio per determinare il tipo di preallarme
                        if (messaggio.Contains("preallarme cibo"))
                        {
                            MessageBox.Show($"Il messaggio della {currentPostazione} è un preallarme cibo.");
                        }
                        else if (messaggio.Contains("preallarme acqua"))
                        {
                            MessageBox.Show($"Il messaggio della {currentPostazione} è un preallarme acqua.");
                        }
                        else
                        {
                            MessageBox.Show($"Il messaggio della {currentPostazione} non è riconosciuto come preallarme cibo o preallarme acqua.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestione dell'errore
                MessageBox.Show(ex.ToString());
            }
        }
        public string[] GetPostazioneMessages()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connstring))
                {
                    connection.Open();

                    // Recupera gli ultimi due messaggi per la postazione corrente
                    string queryMessaggi = $"SELECT messaggio FROM postazione{postazione} ORDER BY data_record DESC LIMIT 2";
                    MySqlCommand commandMessaggi = new MySqlCommand(queryMessaggi, connection);

                    using (MySqlDataReader reader = commandMessaggi.ExecuteReader())
                    {
                        List<string> messaggi = new List<string>();

                        while (reader.Read())
                        {
                            messaggi.Add(reader["messaggio"].ToString());
                        }

                        // Analizza i due messaggi per determinare il tipo di allarme
                        if (messaggi.Count >= 2)
                        {
                            if (messaggi[0].Contains("allarme cibo") || messaggi[1].Contains("allarme cibo"))
                            {
                                return new string[] { "allarme cibo", messaggi[0], messaggi[1] };
                            }
                            else if (messaggi[0].Contains("allarme acqua") || messaggi[1].Contains("allarme acqua"))
                            {
                                return new string[] { "allarme acqua", messaggi[0], messaggi[1] };
                            }
                            else
                            {
                                return new string[] { "nessun allarme", messaggi[0], messaggi[1] };
                            }
                        }
                        else if (messaggi.Count == 1)
                        {
                            if (messaggi[0].Contains("allarme cibo"))
                            {
                                return new string[] { "allarme cibo", messaggi[0], "" };
                            }
                            else if (messaggi[0].Contains("allarme acqua"))
                            {
                                return new string[] { "allarme acqua", messaggi[0], "" };
                            }
                            else
                            {
                                return new string[] { "nessun allarme", messaggi[0], "" };
                            }
                        }
                        else
                        {
                            return new string[] { "nessun messaggio", "", "" };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestione dell'errore
                MessageBox.Show(ex.ToString());
                return new string[] { "errore", "", "" };
            }
        }



    }
}