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
    public partial class frmAdmision : Form
    {
        TurnoNegocio turnNeg = new TurnoNegocio();
        IList<Turno> listaTurn = new List<Turno>();

        public frmAdmision()
        {
            InitializeComponent();
        }

        private void frmAdmision_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
            listaTurn = turnNeg.buscar(DateTime.Today, DateTime.Today, 0, 0, 0, 3);
            dgvTurnosAsignados.DataSource = listaTurn;
            dgvTurnosAsignados.Columns["IdTurno"].Visible = false;
            dgvTurnosAsignados.Columns["IdProfesional"].Visible = false;
            dgvTurnosAsignados.Columns["IdEspecialidad"].Visible = false;
            dgvTurnosAsignados.Columns["IdPaciente"].Visible = false;
            dgvTurnosAsignados.Columns["IdHC"].Visible = false;
            dgvTurnosAsignados.Columns["FechaHoraAsignado"].Visible = false;
            dgvTurnosAsignados.Columns["IdUsuarioAsigna"].Visible = false;
            dgvTurnosAsignados.Columns["UsuarioAsigna"].Visible = false;
            dgvTurnosAsignados.Columns["FechaHoraLiberado"].Visible = false;
            dgvTurnosAsignados.Columns["IdUsuarioLibera"].Visible = false;
            dgvTurnosAsignados.Columns["UsuarioLibera"].Visible = false;
            dgvTurnosAsignados.Columns["FechaHoraCancelado"].Visible = false;
            dgvTurnosAsignados.Columns["IdUsuarioCancela"].Visible = false;
            dgvTurnosAsignados.Columns["UsuarioCancela"].Visible = false;
            dgvTurnosAsignados.Columns["IdEstado"].Visible = false;
            dgvTurnosAsignados.Columns["Estado"].Visible = false;
            dgvTurnosAsignados.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
