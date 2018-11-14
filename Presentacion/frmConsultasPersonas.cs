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
    public partial class frmConsultasPersonas : Form
    {
        public frmConsultasPersonas()
        {
            InitializeComponent();
        }

        private void btnBuscarBPers_Click(object sender, EventArgs e)
        {
            string dni = txtDniBPers.Text;
            string apellido = txtApellidoBPers.Text;
            string nombre = txtNombreBPers.Text;
            frmConsultasPersonasResultado consPers = new frmConsultasPersonasResultado(dni, apellido, nombre);
            consPers.ShowDialog();
        }

        private void btnVolverBPers_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
