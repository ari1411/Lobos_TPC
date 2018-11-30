using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmPerfilProfesionalAtender : Form
    {
        int idProf;
        Turno turn = new Turno();
        IList<Turno> lista = new List<Turno>();
        TurnoNegocio turnNeg = new TurnoNegocio();

        public frmPerfilProfesionalAtender(int IdProf)
        {
            InitializeComponent();
            idProf = IdProf;
        }

        private void frmPerfilProfesionalAtender_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            lista = turnNeg.buscar(DateTime.Today, DateTime.Today, idProf, 1, 2, 6);
            dgvPacientesAdmitidos.DataSource = lista;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            turn = (Turno)dgvPacientesAdmitidos.CurrentRow.DataBoundItem;
            frmPerfilProfesionalAtenderPaciente atencion = new frmPerfilProfesionalAtenderPaciente(turn);
            atencion.ShowDialog();
            cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPerfilProfesionalCancelarTurno cancelar = new frmPerfilProfesionalCancelarTurno(turn);
            cancelar.ShowDialog();
            cargar();
        }
    }
}
