using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_Abbeveratorio
{
    public partial class sinottico : Form
    {
        int numPostazioni;
        public sinottico(int numPostazioni)
        {
            this.numPostazioni = numPostazioni;
            InitializeComponent();
        }

        private void sinottico_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            int startX = 200;
            int startY = 100;
            int spacingX = 100;
            int spacingY = 50;

            for (int i = 0; i < numPostazioni; i++)
            {
                Label labelPostazione = new Label();
                labelPostazione.Text = "Postazione " + (i + 1);
                labelPostazione.Name = "labelPostazione_" + (i + 1);
                labelPostazione.Location = new Point(startX - 70, startY + i * spacingY + 5);
                labelPostazione.Font = new Font("Yu Gothic", 9, FontStyle.Regular);
                Controls.Add(labelPostazione);
                startY += 50;

                PictureBox preallarmeCibo = new PictureBox();
                preallarmeCibo.Image = Properties.Resources.preallarme; // Immagine del preallarme cibo
                preallarmeCibo.SizeMode = PictureBoxSizeMode.StretchImage;
                preallarmeCibo.Name = "preallarme_cibo_" + (i + 1);
                preallarmeCibo.Location = new Point(startX, startY + i * spacingY);
                Controls.Add(preallarmeCibo);
                preallarmeCibo.Visible = false;

                PictureBox allarmeCibo = new PictureBox();
                allarmeCibo.Image = Properties.Resources.allarme; // Immagine dell'allarme cibo
                allarmeCibo.SizeMode = PictureBoxSizeMode.StretchImage;
                allarmeCibo.Name = "allarme_cibo_" + (i + 1);
                allarmeCibo.Location = new Point(startX + spacingX, startY + i * spacingY);
                Controls.Add(allarmeCibo);
                allarmeCibo.Visible = true;

                PictureBox preallarmeAcqua = new PictureBox();
                preallarmeAcqua.Image = Properties.Resources.preallarme; // Immagine del preallarme acqua
                preallarmeAcqua.SizeMode = PictureBoxSizeMode.StretchImage;
                preallarmeAcqua.Name = "preallarme_acqua_" + (i + 1);
                preallarmeAcqua.Location = new Point(startX + spacingX * 2, startY + i * spacingY);
                Controls.Add(preallarmeAcqua);
                preallarmeAcqua.Visible = true;

                PictureBox allarmeAcqua = new PictureBox();
                allarmeAcqua.Image = Properties.Resources.allarme; // Immagine dell'allarme acqua
                allarmeAcqua.SizeMode = PictureBoxSizeMode.StretchImage;
                allarmeAcqua.Name = "allarme_acqua_" + (i + 1);
                allarmeAcqua.Location = new Point(startX + spacingX * 3, startY + i * spacingY);
                Controls.Add(allarmeAcqua);
                allarmeAcqua.Visible = false;


                PictureBox keepalive = new PictureBox();
                keepalive.Image = Properties.Resources.keepalive;
                keepalive.SizeMode = PictureBoxSizeMode.StretchImage;
                keepalive.Name = "keepalive_" + (i + 1);
                keepalive.Location = new Point(startX + spacingX * 4, startY + i * spacingY);
                Controls.Add(keepalive);
                keepalive.Visible = true;

            }
        }

        private void btn__Click(object sender, EventArgs e)
        {
            Server s1 = new Server("1");
            string[] result1 = new string[3];
            result1 = s1.GetPostazioneMessages();


            // Codice per result1[1]
            if (result1[1].Contains("preallarme cibo"))
            {
                // Se il messaggio contiene "preallarme cibo", imposta il tipo di allarme
                result1[1] = "preallarme cibo";
            }
            else if (result1[1].Contains("allarme cibo"))
            {
                // Se il messaggio contiene "allarme cibo", imposta il tipo di allarme
                result1[1] = "allarme cibo";
            }
            else if (result1[1].Contains("preallarme acqua"))
            {
                // Se il messaggio contiene "preallarme acqua", imposta il tipo di allarme
                result1[1] = "preallarme acqua";
            }
            else if (result1[1].Contains("allarme acqua"))
            {
                // Se il messaggio contiene "allarme acqua", imposta il tipo di allarme
                result1[1] = "allarme acqua";
            }
            else
            {
                // Se nessun tipo di allarme è rilevato, imposta un valore predefinito
                result1[1] = "nessun allarme";
            }

            // Codice per result1[2]
            if (result1[2].Contains("preallarme cibo"))
            {
                // Se il messaggio contiene "preallarme cibo", imposta il tipo di allarme
                result1[2] = "preallarme cibo";
            }
            else if (result1[2].Contains("allarme cibo"))
            {
                // Se il messaggio contiene "allarme cibo", imposta il tipo di allarme
                result1[2] = "allarme cibo";
            }
            else if (result1[2].Contains("preallarme acqua"))
            {
                // Se il messaggio contiene "preallarme acqua", imposta il tipo di allarme
                result1[2] = "preallarme acqua";
            }
            else if (result1[2].Contains("allarme acqua"))
            {
                // Se il messaggio contiene "allarme acqua", imposta il tipo di allarme
                result1[2] = "allarme acqua";
            }
            else
            {
                // Se nessun tipo di allarme è rilevato, imposta un valore predefinito
                result1[2] = "nessun allarme";
            }


            ActivateAlarmImages(result1[1], 1); // Attiva visivamente le immagini per il messaggio 1
            ActivateAlarmImages(result1[2], 2); // Attiva visivamente le immagini per il messaggio 2

            string messageToShow = $"Tipo di allarme (Messaggio 1): {result1[1]}\nTipo di allarme (Messaggio 2): {result1[2]}";
            
        }

        private void ActivateAlarmImages(string messaggio, int numeroMessaggio)
        {
            int postazione = 1; // Sostituisci con l'indice della postazione

            // Determina il tipo di allarme per il messaggio
            string tipoAllarme = (messaggio);

            // Attiva visivamente le immagini in base al tipo di allarme per il messaggio
            if (tipoAllarme == "preallarme cibo")
            {
                if (numeroMessaggio == 1)
                {
                    ActivatePictureBox("preallarme_cibo", postazione);
                }
                else if (numeroMessaggio == 2)
                {
                    ActivatePictureBox("preallarme_cibo", postazione + 1); // Modifica l'indice della postazione se necessario
                }
            }
            else if(tipoAllarme == "allarme cibo")
            {
                if (numeroMessaggio == 1)
                {
                    ActivatePictureBox("allarme_cibo", postazione);
                }
                else if (numeroMessaggio == 2)
                {
                    ActivatePictureBox("allarme_cibo", postazione + 1); // Modifica l'indice della postazione se necessario
                }
            }
             else if (tipoAllarme == "preallarme acqua")
            {
                if (numeroMessaggio == 1)
                {
                    ActivatePictureBox("preallarme_acqua", postazione);
                }
                else if (numeroMessaggio == 2)
                {
                    ActivatePictureBox("preallarme_acqua", postazione + 1); // Modifica l'indice della postazione se necessario
                }
            }
            else if (tipoAllarme == "allarme acqua")
            {
                if (numeroMessaggio == 1)
                {
                    ActivatePictureBox("allarme_acqua", postazione);
                }
                else if (numeroMessaggio == 2)
                {
                    ActivatePictureBox("allarme_acqua", postazione + 1); // Modifica l'indice della postazione se necessario
                }
            }
            else
            {
                MessageBox.Show("error"); 
            }
        }

        private void ActivatePictureBox(string pictureBoxName, int postazione)
        {
            PictureBox pictureBox = Controls.Find(pictureBoxName + "_" + postazione, false).FirstOrDefault() as PictureBox;
            if (pictureBox != null)
            {
             
                pictureBox.Visible = true;
            }
            else
            {
                MessageBox.Show($"{pictureBoxName} non trovato per la postazione {postazione}.");
            }
        }



    }
}
