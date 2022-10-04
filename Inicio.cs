using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_parcial
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            label1.Text = ("Juegos de preguntas");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Multiple lvl1 = new Multiple();
            MessageBox.Show("Cada pregunta correcta da 10 puntos y cada erronea restará 5");
            this.Hide();
            lvl1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
