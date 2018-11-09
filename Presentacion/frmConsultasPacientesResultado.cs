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
    public partial class frmConsultasPacientesResultado : Form
    {
        private List<Paciente> listaPacientes;
        Paciente aux;
        public string dni { set; get; }
        public string apellido { set; get; }
        public string nombre { set; get; }

        public frmConsultasPacientesResultado(string DNI, string APELLIDO, string NOMBRE)
        {
            InitializeComponent();
            dni = DNI;
            apellido = APELLIDO;
            nombre = NOMBRE;
        }

        private void frmConsultasPacientesResultado_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PacienteNegocio neg = new PacienteNegocio();
            try
            {
                listaPacientes = (List<Paciente>)neg.Buscar(dni, apellido, nombre);
                dgvConsultasPacientes.DataSource = listaPacientes;

                dgvConsultasPacientes.Columns["Idpaciente"].Visible = false;
                dgvConsultasPacientes.Columns["Idhc"].Visible = false;
                dgvConsultasPacientes.Columns["Id"].Visible = false;
                dgvConsultasPacientes.Columns["IdSexo"].Visible = false;
                dgvConsultasPacientes.Columns["IdMunicipio"].Visible = false;
                dgvConsultasPacientes.Columns["IdNacionalidad"].Visible = false;
                dgvConsultasPacientes.Columns["FechaAlta"].Visible = false;
                dgvConsultasPacientes.Columns["IdUsuarioAlta"].Visible = false;
                dgvConsultasPacientes.Columns["FechaModif"].Visible = false;
                dgvConsultasPacientes.Columns["IdUsuarioModif"].Visible = false;
                dgvConsultasPacientes.Columns["FechaBaja"].Visible = false;
                dgvConsultasPacientes.Columns["IdUsuarioBaja"].Visible = false;
                dgvConsultasPacientes.Columns["Estado"].Visible = false;
                dgvConsultasPacientes.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnBuscarPteVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditarPte_Click(object sender, EventArgs e)
        {
            aux = (Paciente)dgvConsultasPacientes.CurrentRow.DataBoundItem;
            frmModificarPaciente modif = new frmModificarPaciente(aux);
            modif.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                aux = (Paciente)dgvConsultasPacientes.CurrentRow.DataBoundItem;
                PacienteNegocio neg = new PacienteNegocio();
                neg.Eliminar(aux.Id, 1);
                cargar();
            }
        }

        private void btnVerHC_Click(object sender, EventArgs e)
        {
            aux = (Paciente)dgvConsultasPacientes.CurrentRow.DataBoundItem;
            frmVerHistoriaClinica VerHC = new frmVerHistoriaClinica(aux);
            VerHC.ShowDialog();
            cargar();
        }
    }
}
