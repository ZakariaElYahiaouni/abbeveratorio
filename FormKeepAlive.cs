using System;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace WA_Abbeveratorio
{
    public partial class FormKeepAlive : Form
    {
        string postazioneinvio; 
        public FormKeepAlive(string postazioneinvio)
        {
            this.BackColor = Color.White;
            this.postazioneinvio = postazioneinvio;
            
            InitializeComponent();
        }

        private void btn_keepAlive_Click(object sender, EventArgs e)
        {
        

            

            try
            {
                Server serv = new Server(postazioneinvio);
                serv.UpdateKeepAlive();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore durante l'invio del messaggio keep alive: " + ex.Message);
            }
        }

        private void lbl_header_Click(object sender, EventArgs e)
        {

        }

        private void FormKeepAlive_Load(object sender, EventArgs e)
        {
            lbl_header.Text = "postazione" + this.postazioneinvio;
            btn_back.BackColor = Color.Red;
            btn_back.ForeColor = Color.White;
            btn_back.FlatAppearance.BorderColor = Color.Red; 
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        int count = 0; 
        private void timerInvio_Tick(object sender, EventArgs e)
        {
            count++; 
            if(count >= 2)
            {
                //
                Server serv = new Server(postazioneinvio);
                serv.UpdateKeepAlive(); 
            }
        }
    }
}