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
    public partial class frmVerHistoriaClinicaEvoluciones : Form
    {
        HC HistClin;
        Paciente aux = new Paciente();
        EvolucionNegocio evolNeg = new EvolucionNegocio();
        IList<Evolucion> lista = new List<Evolucion>();

        public frmVerHistoriaClinicaEvoluciones(Paciente paciente, HC HistoriaClinica)
        {
            InitializeComponent();
            HistClin = HistoriaClinica;
            aux = paciente;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVerHistoriaClinicaEvoluciones_Load(object sender, EventArgs e)
        {
            lblDatosPaciente.Text = aux.Apellido + ", " + aux.Nombre + " - DNI: " + aux.Dni + " - Fecha de Nacimiento: " + aux.FechaNacimiento.ToString("dd/MM/yyyy");
            lblHC.Text = HistClin.RazonSocial;
            cargar();
        }

        private void cargar()
        {
            lista = evolNeg.Buscar(1, 2, 0, HistClin.IdHC, 0, 0, 0);
            dgvEvoluciones.DataSource = lista;

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
    }
}
