using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmAtencionPaciente : Form
    {
        Turno turn = new Turno();

        public frmAtencionPaciente(Turno X)
        {
            InitializeComponent();
            turn = X;
        }

        private void frmAtencionPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
