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
    public partial class frmVerHistoriaClinica : Form
    {
        private Paciente aux;
        private IList<HC> listaHC;

        public frmVerHistoriaClinica(Paciente paciente)
        {
            InitializeComponent();
            aux = paciente;
        }

        private void frmVerHistoriaClinica_Load(object sender, EventArgs e)
        {
            lblDatosPaciente.Text = aux.Apellido + ", " + aux.Nombre + " - DNI: "+ aux.Dni + " - Fecha de Nacimiento: " + aux.FechaNacimiento.ToString("dd/MM/yyyy");
            cargar();

        }

        private void cargar()
        {
            HCnegocio neg = new HCnegocio();
            try
            {
                listaHC= (List<HC>) neg.cargar(aux.IdPaciente);
                dgvVerHistoriasClinicas.DataSource = listaHC;

                dgvVerHistoriasClinicas.Columns["IdHC"].Visible = false;
                dgvVerHistoriasClinicas.Columns["IdRazonSocial"].Visible = false;
                dgvVerHistoriasClinicas.Columns["IdPaciente"].Visible = false;
                dgvVerHistoriasClinicas.Columns["FechaHrAlta"].Visible = false;
                dgvVerHistoriasClinicas.Columns["IdAdminAlta"].Visible = false;
                dgvVerHistoriasClinicas.Columns["FechaHrModif"].Visible = false;
                dgvVerHistoriasClinicas.Columns["IdAdminModif"].Visible = false;
                dgvVerHistoriasClinicas.Columns["FechaHrBaja"].Visible = false;
                dgvVerHistoriasClinicas.Columns["IdAdminBaja"].Visible = false;
                dgvVerHistoriasClinicas.Columns["Estado"].Visible = false;
                dgvVerHistoriasClinicas.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnVolverHC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearHC_Click(object sender, EventArgs e)
        {
            frmCrearHistoriaClinica crear = new frmCrearHistoriaClinica(aux.IdPaciente);
            crear.ShowDialog();
            cargar();
        }

        private void btnVerHC_Click(object sender, EventArgs e)
        {
            HC seleccion = (HC)dgvVerHistoriasClinicas.CurrentRow.DataBoundItem;
            frmVerHistoriaClinicaEvoluciones evol = new frmVerHistoriaClinicaEvoluciones(aux, seleccion);
            evol.ShowDialog();
        }

        private void btnEditarHC_Click(object sender, EventArgs e)
        {
            HC seleccion = (HC)dgvVerHistoriasClinicas.CurrentRow.DataBoundItem;
            frmModificarHistoriaClinica editar = new frmModificarHistoriaClinica(aux.IdPaciente,seleccion);
            editar.ShowDialog();
            cargar();
        }

        private void btnEliminarHC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar la historia clinica seleccionada?", "Eliminar", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                HC seleccion = (HC)dgvVerHistoriasClinicas.CurrentRow.DataBoundItem;
                HCnegocio neg = new HCnegocio();
                neg.eliminar(seleccion.IdHC, 1);
                cargar();
            }
        }
    }
}
