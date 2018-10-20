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
    public partial class frmConsultasPacientes : Form
    {
        public frmConsultasPacientes()
        {
            InitializeComponent();
        }

        private void btnBuscarPteVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultasPacientesResultado consPacientes = new frmConsultasPacientesResultado();
            consPacientes.ShowDialog();
        }
    }
}
