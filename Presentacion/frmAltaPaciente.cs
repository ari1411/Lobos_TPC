using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAltaPaciente : Form
    {
        public frmAltaPaciente()
        {
            InitializeComponent();
        }

        private void frmAltaPaciente_Load(object sender, EventArgs e)
        {
            
        }

        private void lblTelMovil_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡¡¡Felicidades, no hace nada :D!!!");
            Close();
        }
    }
}
