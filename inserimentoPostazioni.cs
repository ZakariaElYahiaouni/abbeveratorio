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
    public partial class inserimentoPostazioni : Form
    {
        int numeroPostazioni; 
        public inserimentoPostazioni()
        {
            InitializeComponent();
        }
        private void creazioneDinamicaSinottico()
        {
            sinottico s1 = new sinottico(numeroPostazioni);
            s1.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            numeroPostazioni = Convert.ToInt32(txt_input.Text);
            creazioneDinamicaSinottico();
        }
    }
}
