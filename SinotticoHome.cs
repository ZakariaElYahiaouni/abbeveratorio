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
    public partial class SinotticoHome : Form
    {
        public SinotticoHome()
        {
            InitializeComponent();
        }

        private void btn_inviaPostazioni_Click(object sender, EventArgs e)
        {
            int postazioni;


            try
            {


                postazioni = Convert.ToInt32(txt_postazioni.Text);
                if (postazioni < 4 && postazioni > 0)
                {
                    sinottico s1 = new sinottico(postazioni);
                    s1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Inserimento numerico non valido, Prova di nuovo");
                    txt_postazioni.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Inserimento non valido, Prova di nuovo");
                txt_postazioni.Text = string.Empty; 
            }
        }

        private void SinotticoHome_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
