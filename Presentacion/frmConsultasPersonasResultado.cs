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
    public partial class frmConsultasPersonasResultado : Form
    {
        private List<Persona> listaPersonas;
        Persona aux;
        string dni { set; get; }
        string apellido { set; get; }
        string nombre { set; get; }

        public frmConsultasPersonasResultado(string DNI, string APELLIDO, string NOMBRE)
        {
            InitializeComponent();
            dni = DNI;
            apellido = APELLIDO;
            nombre = NOMBRE;
        }

        private void btnVolverPers_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConsultasPersonasResultado_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            PersonaNegocio neg = new PersonaNegocio();
            try
            {
                listaPersonas = (List<Persona>)neg.Buscar(dni, apellido, nombre);
                dgvConsultasPersonas.DataSource = listaPersonas;

                dgvConsultasPersonas.Columns["Id"].Visible = false;
                dgvConsultasPersonas.Columns["IdSexo"].Visible = false;
                dgvConsultasPersonas.Columns["IdMunicipio"].Visible = false;
                dgvConsultasPersonas.Columns["IdNacionalidad"].Visible = false;
                dgvConsultasPersonas.Columns["FechaAlta"].Visible = false;
                dgvConsultasPersonas.Columns["IdUsuarioAlta"].Visible = false;
                dgvConsultasPersonas.Columns["FechaModif"].Visible = false;
                dgvConsultasPersonas.Columns["IdUsuarioModif"].Visible = false;
                dgvConsultasPersonas.Columns["FechaBaja"].Visible = false;
                dgvConsultasPersonas.Columns["IdUsuarioBaja"].Visible = false;
                dgvConsultasPersonas.Columns["Estado"].Visible = false;
                dgvConsultasPersonas.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAñadirFuncion_Click(object sender, EventArgs e)
        {
            aux = (Persona)dgvConsultasPersonas.CurrentRow.DataBoundItem;
            frmAnadirFuncionPersona funciones = new frmAnadirFuncionPersona(aux);
            funciones.ShowDialog();
        }

        private void btnEditarPers_Click(object sender, EventArgs e)
        {
            aux = (Persona)dgvConsultasPersonas.CurrentRow.DataBoundItem;
            frmModificarPaciente modif = new frmModificarPaciente(aux);
            modif.ShowDialog();
            cargar();
        }

        private void btnEliminarPers_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Eliminar la persona?", "Eliminar", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    aux = (Persona)dgvConsultasPersonas.CurrentRow.DataBoundItem;
                    PersonaNegocio neg = new PersonaNegocio();
                    neg.Eliminar(aux.Id, 1);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        
    }
}
