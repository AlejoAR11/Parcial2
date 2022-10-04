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
    public partial class VerFal : Form
    {
        public VerFal(int puntaje)
        {
            InitializeComponent();
            this.puntaje = puntaje;
        }
        int puntaje = 0;
        private void VerFal_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(puntaje);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlvl1_Click(object sender, EventArgs e)
        {
            if (rbtnF1.Checked == true) { puntaje += 20; } else { puntaje -= 7; }
            if (rbtnV2.Checked == true) { puntaje += 20; } else { puntaje -= 7; }

            MessageBox.Show("Cada frase correcta da 25 puntos y cada erronea restará 11");
            this.Hide();
            Frase lvl3 = new Frase(puntaje);
            lvl3.Show();

        }
    }
}
