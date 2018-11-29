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
    public partial class frmConsultaTurnosResultado : Form
    {
        IList<Turno> listaTurno = new List<Turno>();
        DateTime inicial;
        DateTime final;
        int profesional;
        int especialidad;
        int seleccion;

        public frmConsultaTurnosResultado(DateTime ini, DateTime fin, int prof, int esp, int selec)
        {
            InitializeComponent();
            inicial = ini;
            final = fin;
            profesional = prof;
            especialidad = esp;
            seleccion = selec;
        }

        private void frmConsultaTurnosResultado_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            TurnoNegocio neg = new TurnoNegocio();
            try
            {
                listaTurno = neg.buscar(inicial, final, profesional, especialidad, seleccion);
                dgvTurnos.DataSource = listaTurno;

                dgvTurnos.Columns["IdTurno"].Visible = false;
                dgvTurnos.Columns["IdProfesional"].Visible = false;
                dgvTurnos.Columns["IdEspecialidad"].Visible = false;
                dgvTurnos.Columns["IdPaciente"].Visible = false;
                dgvTurnos.Columns["IdHC"].Visible = false;
                dgvTurnos.Columns["IdUsuarioAsigna"].Visible = false;
                dgvTurnos.Columns["IdUsuarioAdmitio"].Visible = false;
                dgvTurnos.Columns["IdUsuarioLibera"].Visible = false;
                dgvTurnos.Columns["IdUsuarioCancela"].Visible = false;
                dgvTurnos.Columns["IdEstado"].Visible = false;
                dgvTurnos.AutoResizeColumns();
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
