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
    public partial class Final : Form
    {
        public Final(int puntaje)
        {
            InitializeComponent();
            this.puntaje = puntaje;
        }
        int puntaje = 0;
        private void Final_Load(object sender, EventArgs e)
        {
            label1.Text = "Tu puntaje final fue:" + Convert.ToString(puntaje);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
