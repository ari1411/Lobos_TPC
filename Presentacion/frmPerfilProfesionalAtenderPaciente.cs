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
    public partial class frmPerfilProfesionalAtenderPaciente : Form
    {
        Turno turn = new Turno();
        IList<Evolucion> lista = new List<Evolucion>();
        TurnoNegocio turnNeg = new TurnoNegocio();
        EvolucionNegocio evNeg = new EvolucionNegocio();
        

        public frmPerfilProfesionalAtenderPaciente(Turno X)
        {
            InitializeComponent();
            turn = X;
        }

        private void frmAtencionPaciente_Load(object sender, EventArgs e)
        {
            lblPaciente.Text += turn.Paciente;
            lblDni.Text += turn.DNI;
            lblRazonSocial.Text += turn.RazonSocial_Plan;
            lblMotivoHC.Text += turn.MotivoHC;
            lblFechaHrTurno.Text += turn.FechaHoraTurno;
            lblprofesional.Text += turn.Profesional;
            lblEspecialidad.Text += turn.Especialidad;
            lblObservaciones.Text += turn.Observaciones;
            lblFechaHrAsignado.Text += turn.FechaHoraAsignado.ToString("dd/MM/yyyy");
            lblUsuarioAsigna.Text += turn.UsuarioAsigna;
            lblUsuarioAdmin.Text += turn.UsuarioAdmitio;

            cargar();
        }
        private void cargar()
        {
            lista = evNeg.Buscar(1, 1, turn.IdPaciente, 0, 0, 0, 0);
            dgvEvoluciones.DataSource=lista;

            dgvEvoluciones.Columns["IdEvolucion"].Visible = false;
            dgvEvoluciones.Columns["IdPaciente"].Visible = false;
            dgvEvoluciones.Columns["IdAdministrativo"].Visible = false;
            dgvEvoluciones.Columns["Administrativo"].Visible = false;
            dgvEvoluciones.Columns["IdProfesional"].Visible = false;
            dgvEvoluciones.Columns["IdEspecialidad"].Visible = false;
            dgvEvoluciones.Columns["IdHC"].Visible = false;
            dgvEvoluciones.Columns["IdTurno"].Visible = false;
            dgvEvoluciones.Columns["FechaHrModif"].Visible = false;
            dgvEvoluciones.Columns["IdAdminModif"].Visible = false;
            dgvEvoluciones.Columns["AdminModif"].Visible = false;
            dgvEvoluciones.Columns["FechaHrBaja"].Visible = false;
            dgvEvoluciones.Columns["IdAdminBaja"].Visible = false;
            dgvEvoluciones.Columns["AdminBaja"].Visible = false;
            dgvEvoluciones.AutoResizeColumns();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Evolucion ev = new Evolucion();
                ev.IdPaciente = turn.IdPaciente;
                ev.IdAdministrativo = 0;
                ev.IdProfesional = turn.IdProfesional;
                ev.IdEspecialidad = turn.IdEspecialidad;
                ev.IdHC = turn.IdHC;
                ev.IdTurno = turn.IdTurno;
                ev.evolucion = txtEvolucion.Text;

                evNeg.GrabarEvolucion(ev);
                turnNeg.realizado(turn.IdTurno);
                MessageBox.Show("Se grabo correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
