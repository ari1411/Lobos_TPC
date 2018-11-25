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
    public partial class frmCrearAgenda : Form
    {
        public frmCrearAgenda()
        {
            InitializeComponent();
        }

        private void frmCrearAgenda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet19.VW_PROFESIONALES' Puede moverla o quitarla según sea necesario.
            this.vW_PROFESIONALESTableAdapter.Fill(this.lOBOS_DBDataSet19.VW_PROFESIONALES);
            mtbHoraHasta.Text = mtbHoraInicio.Text = DateTime.Today.ToString();
            cboProfesionales_SelectedIndexChanged(sender, e);
        }

        private void cboProfesionales_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<Especialidades> lista = new List<Especialidades>();
            EspecialidadesNegocio neg = new EspecialidadesNegocio();

            try
            {
                lista = neg.listarEspecialidades(int.Parse(cboProfesionales.SelectedValue.ToString()));
                dgvEspecialidades.DataSource = lista;

                dgvEspecialidades.Columns["IdEspXProf"].Visible = false;
                dgvEspecialidades.Columns["IdProfesional"].Visible = false;
                dgvEspecialidades.Columns["IdEspecialidad"].Visible = false;
                dgvEspecialidades.Columns["MatriculaNac"].Visible = false;
                dgvEspecialidades.Columns["FechaVtoNac"].Visible = false;
                dgvEspecialidades.Columns["MatriculaProv"].Visible = false;
                dgvEspecialidades.Columns["FechaVtoProv"].Visible = false;
                dgvEspecialidades.Columns["FechaAlta"].Visible = false;
                dgvEspecialidades.Columns["IdUsuarioAlta"].Visible = false;
                dgvEspecialidades.Columns["FechaModif"].Visible = false;
                dgvEspecialidades.Columns["IdUsuarioModif"].Visible = false;
                dgvEspecialidades.Columns["FechaBaja"].Visible = false;
                dgvEspecialidades.Columns["IdUsuarioBaja"].Visible = false;
                dgvEspecialidades.Columns["Estado"].Visible = false;
                dgvEspecialidades.AutoResizeColumns();
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

        private void btnGenerarTurnos_Click(object sender, EventArgs e)
        {
            
            if (mtbHoraInicio.Text != mtbHoraHasta.Text)
            {
                if (dgvEspecialidades.CurrentRow != null)
                {
                    try
                    {
                    DateTime fechaHora = DateTime.Parse(mtbHoraInicio.Text);
                    DateTime hrFin = DateTime.Parse(mtbHoraHasta.Text);
                    TurnoNegocio neg = new TurnoNegocio();
                    int idProf = int.Parse(cboProfesionales.SelectedValue.ToString());
                    Especialidades aux = (Especialidades)dgvEspecialidades.CurrentRow.DataBoundItem;
                    int x = neg.crearAgenda(fechaHora, fechaHora, hrFin, 60, idProf, aux.IdEspecialidad);
                    MessageBox.Show("Se creo correctamente la agenda con " + x + " turno/s");
                    Close();

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("El formato de Fecha y Hora es incorrecto, deben estar bien para poder continuar");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("No hay ninguna especialidad seleccionada");
                }

            }
            else MessageBox.Show("Desde y Hasta tienen los mismos valores, no se pueden crear turnos");
        }
    }
}
