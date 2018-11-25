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
    public partial class frmAsignarTurno : Form
    {
        Paciente pte = new Paciente();
        PacienteNegocio pteNeg = new PacienteNegocio();
        IList<Paciente> listaPte = new List<Paciente>();
        HC histClin = new HC();
        HCnegocio histClinNeg = new HCnegocio();
        IList<HC> listaHC = new List<HC>();
        Turno turn = new Turno();
        TurnoNegocio turnNeg = new TurnoNegocio();
        IList<Turno> listaTurn = new List<Turno>();
        int rdbSeleccionado = 0;

        public frmAsignarTurno()
        {
            InitializeComponent();
        }

        private void frmAsignarTurno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet20.VW_ESPECIALIDADES_MEDICAS' Puede moverla o quitarla según sea necesario.
            this.vW_ESPECIALIDADES_MEDICASTableAdapter.Fill(this.lOBOS_DBDataSet20.VW_ESPECIALIDADES_MEDICAS);
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet19.VW_PROFESIONALES' Puede moverla o quitarla según sea necesario.
            this.vW_PROFESIONALESTableAdapter.Fill(this.lOBOS_DBDataSet19.VW_PROFESIONALES);

            dtpFechaTurnoIni.MinDate = dtpFechaTurnoIni.Value = DateTime.Today;
            dtpFechaTurnoFin.MinDate = dtpFechaTurnoFin.Value = DateTime.Today;
        }

        private void rdbProfesional_CheckedChanged(object sender, EventArgs e)
        {
            cboEspecialidades.Visible = false;
            cboProfesionales.Visible = true;
            rdbSeleccionado = 2;
        }

        private void rdbEspecialidad_CheckedChanged(object sender, EventArgs e)
        {
            cboEspecialidades.Visible = true;
            cboProfesionales.Visible = false;
            rdbSeleccionado = 3;
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != (char)Keys.Enter)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscarPte_Click(sender, e);
            }
        }

        private void btnBuscarPte_Click(object sender, EventArgs e)
        {

                try
                {
                    pteNeg = new PacienteNegocio();
                    listaPte = new List<Paciente>();
                    listaPte = pteNeg.Buscar(txtDNI.Text.Trim());
                    pte = listaPte[0];
                    txtApellidoNombre.Text = pte.Apellido + ", " + pte.Nombre;
                    listaHC = new List<HC>();
                    histClinNeg = new HCnegocio();
                    listaHC = histClinNeg.cargarHCactivas(pte.IdPaciente);
                    dgvHistoriasClinicas.DataSource = listaHC;

                    dgvHistoriasClinicas.Columns["IdHC"].Visible = false;
                    dgvHistoriasClinicas.Columns["IdRazonSocial"].Visible = false;
                    dgvHistoriasClinicas.Columns["IdPaciente"].Visible = false;
                    dgvHistoriasClinicas.Columns["IdAdminAlta"].Visible = false;
                    dgvHistoriasClinicas.Columns["FechaHrModif"].Visible = false;
                    dgvHistoriasClinicas.Columns["IdAdminModif"].Visible = false;
                    dgvHistoriasClinicas.Columns["FechaHrBaja"].Visible = false;
                    dgvHistoriasClinicas.Columns["IdAdminBaja"].Visible = false;
                    dgvHistoriasClinicas.Columns["Estado"].Visible = false;
                    dgvHistoriasClinicas.AutoResizeColumns();

                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("DNI no encontrado o se encuentra inactivo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


        }

        private void btnBuscarTurnos_Click(object sender, EventArgs e)
        {
            if (rdbSeleccionado != 0)
            {
                TurnoNegocio turNeg = new TurnoNegocio();

                listaTurn = turNeg.buscar(dtpFechaTurnoIni.Value, dtpFechaTurnoFin.Value, int.Parse(cboProfesionales.SelectedValue.ToString()), int.Parse(cboEspecialidades.SelectedValue.ToString()), rdbSeleccionado, 2);
                dgvTurnosDisponibles.DataSource = listaTurn;

                dgvTurnosDisponibles.Columns["IdTurno"].Visible = false;
                dgvTurnosDisponibles.Columns["IdProfesional"].Visible = false;
                dgvTurnosDisponibles.Columns["IdEspecialidad"].Visible = false;
                dgvTurnosDisponibles.Columns["IdPaciente"].Visible = false;
                dgvTurnosDisponibles.Columns["Paciente"].Visible = false;
                dgvTurnosDisponibles.Columns["IdHC"].Visible = false;
                dgvTurnosDisponibles.Columns["FechaHoraAsignado"].Visible = false;
                dgvTurnosDisponibles.Columns["IdUsuarioAsigna"].Visible = false;
                dgvTurnosDisponibles.Columns["UsuarioAsigna"].Visible = false;
                dgvTurnosDisponibles.Columns["FechaHoraLiberado"].Visible = false;
                dgvTurnosDisponibles.Columns["IdUsuarioLibera"].Visible = false;
                dgvTurnosDisponibles.Columns["UsuarioLibera"].Visible = false;
                dgvTurnosDisponibles.Columns["FechaHoraCancelado"].Visible = false;
                dgvTurnosDisponibles.Columns["IdUsuarioCancela"].Visible = false;
                dgvTurnosDisponibles.Columns["UsuarioCancela"].Visible = false;
                dgvTurnosDisponibles.Columns["IdEstado"].Visible = false;
                dgvTurnosDisponibles.Columns["Estado"].Visible = false;
                dgvTurnosDisponibles.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Primero debes seleccionar el modo de busqueda");
            }
        }

        private void lblHasta_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaTurnoIni_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaTurnoFin.MinDate = dtpFechaTurnoIni.Value;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            turn = (Turno)dgvTurnosDisponibles.CurrentRow.DataBoundItem;
            histClin = (HC)dgvHistoriasClinicas.CurrentRow.DataBoundItem;
            turnNeg.asignarTurno(pte.IdPaciente, histClin.IdHC, turn.IdTurno);
            MessageBox.Show("Se asigno correctamente el turno");
            Close();
        }

        private void dtpFechaTurnoFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaTurnoIni.Value != dtpFechaTurnoFin.Value)
            {
                btnBuscarTurnos_Click(sender, e);
            }
        }
    }
}
