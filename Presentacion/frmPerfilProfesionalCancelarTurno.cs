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
    public partial class frmPerfilProfesionalCancelarTurno : Form
    {
        Turno turn = new Turno();
        TurnoNegocio turnNeg = new TurnoNegocio();

        public frmPerfilProfesionalCancelarTurno(Turno X)
        {
            InitializeComponent();
            turn = X;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                turnNeg.cancelarMed(turn.IdTurno, txtObs.Text);
                MessageBox.Show("Turno cancelado");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmPerfilProfesionalCancelarTurno_Load(object sender, EventArgs e)
        {
            txtObs.Text = turn.Observaciones;
        }
    }
}
