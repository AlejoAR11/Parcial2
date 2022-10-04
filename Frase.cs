using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_parcial
{
    public partial class Frase : Form
    {
        public Frase(int puntaje)
        {
            InitializeComponent();
            this.puntaje = puntaje;
        }
        int puntaje = 0;
        string soda = "No quiero soñar mil veces las mismas cosas ni contemplarlas sabiamente";
        string bunny = "Hoy sí o sí yo me quedo en un cuarto que no es mío";
        string eminem = "Now this looks like a job for me";
        private void Frase_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(puntaje);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void txtSoda_TextChanged(object sender, EventArgs e)
        {

         

        }

        private void txtEminem_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (txtBadBunny.Text == bunny) { puntaje += 25; } else { puntaje -= 11; }
            if (txtEminem.Text == eminem) { puntaje += 25; } else { puntaje -= 11; }
            if (txtSoda.Text == soda) { puntaje += 25; } else { puntaje -= 11; }



            Final lvl4 = new Final(puntaje);
            this.Hide();
            lvl4.Show();
        }
    }
}
