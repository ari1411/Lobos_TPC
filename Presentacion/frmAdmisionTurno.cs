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
    public partial class frmAdmisionTurno : Form
    {
        Turno turno = new Turno();
        TurnoNegocio turnoNeg = new TurnoNegocio();
        int Accion = 0;

        public frmAdmisionTurno(Turno turn, int tipoAccion) // 1) ADMITIR  2) CANCELAR  3) LIBERAR
        {
            InitializeComponent();
            turno = turn;
            Accion = tipoAccion;
        }

        private void frmAdmisionTurno_Load(object sender, EventArgs e)
        {
            if (Accion == 1) lblPregunta.Text = "Estas por admisionar el turno " + turno.IdTurno + " , ¿Los datos son correctos?";
            if (Accion == 2) lblPregunta.Text = "Estas por cancelar el turno " + turno.IdTurno + " , ¿Los datos son correctos?";
            if (Accion == 2) lblPregunta.Text = "Estas por liberar el turno " + turno.IdTurno + " , ¿Los datos son correctos?";
            txtDNI.Text = turno.DNI;
            txtApellidoNombre.Text = turno.Paciente;
            txtRazonSocial.Text = turno.RazonSocial_Plan;
            txtHistoriaClinica.Text = turno.MotivoHC;
            txtProfesional.Text = turno.Profesional;
            txtEspecialidad.Text = turno.Especialidad;
            txtHrTurno.Text = turno.FechaHoraTurno.ToString("HH:mm") + " HS";
            txtObservaciones.Text = turno.Observaciones;
            if (Accion != 1) lblIngresoObservacion.Text = "Agrega el motivo por el cual no es admisionado:";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion >= 1 & Accion <= 3)
                {
                    if (Accion == 1) turnoNeg.admisionar(turno.IdTurno, txtObservaciones.Text, 1);
                    if (Accion == 2) turnoNeg.cancelar(turno.IdTurno, txtObservaciones.Text, 1);
                    if (Accion == 3) turnoNeg.liberar(turno.IdTurno, txtObservaciones.Text, 1);
                    Close();
                }
                else MessageBox.Show("hay un error, no se realizo ninguna accion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
