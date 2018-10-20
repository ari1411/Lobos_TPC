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

        public frmConsultasPacientesResultado()
        {
            InitializeComponent();
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
                listaPacientes = (List<Paciente>)neg.Listar();
                dgvConsultasPacientes.DataSource = listaPacientes;
                dgvConsultasPacientes.Columns["idpaciente"].Visible = false;
                dgvConsultasPacientes.Columns["idhc"].Visible = false;
                dgvConsultasPacientes.Columns["id"].Visible = false;
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
    }
}
