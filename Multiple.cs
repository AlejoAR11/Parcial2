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
    public partial class Multiple : Form
    {
        public Multiple()
        {
            InitializeComponent();
          
        }
        int puntaje=0;
        private void Multiple_Load(object sender, EventArgs e)
        {

        }

        private void btnlvl1_Click(object sender, EventArgs e)
        {
            if (rbtnd2.Checked == true) { puntaje += 10; } else { puntaje -= 5; }
            if (rbtnl1.Checked == true) { puntaje += 10; } else { puntaje -= 5; }
            if (rbtnc4.Checked == true) { puntaje += 10; } else { puntaje -= 5; }
            if (rbtnq2.Checked == true) { puntaje += 10; } else { puntaje -= 5; }

            MessageBox.Show("Cada pregunta correcta da 20 puntos y cada erronea restará 7");
            this.Hide();
            VerFal lvl2 = new VerFal(puntaje);
            lvl2.Show();
        }
    }
}
