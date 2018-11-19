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
    public partial class frmEspecialidadesDelProfesional : Form
    {
        Persona persona = new Persona();
        IList<Especialidades> listaEspecialidades = new List<Especialidades>();

        public frmEspecialidadesDelProfesional(Persona pers)
        {
            InitializeComponent();
            persona = pers;
        }

        private void frmEspecialidadesDelProfesional_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            EspecialidadesNegocio neg = new EspecialidadesNegocio();
            try
            {
                listaEspecialidades = neg.listarEspecialidades(persona.Id);
                dgvEspecialidadesProf.DataSource = listaEspecialidades;

                dgvEspecialidadesProf.Columns["IdEspXProf"].Visible = false;
                dgvEspecialidadesProf.Columns["IdProfesional"].Visible = false;
                dgvEspecialidadesProf.Columns["IdEspecialidad"].Visible = false;
                dgvEspecialidadesProf.Columns["MatriculaNac"].Visible = false;
                dgvEspecialidadesProf.Columns["FechaVtoNac"].Visible = false;
                dgvEspecialidadesProf.Columns["MatriculaProv"].Visible = false;
                dgvEspecialidadesProf.Columns["FechaVtoProv"].Visible = false;
                dgvEspecialidadesProf.Columns["FechaAlta"].Visible = false;
                dgvEspecialidadesProf.Columns["IdUsuarioAlta"].Visible = false;
                dgvEspecialidadesProf.Columns["FechaModif"].Visible = false;
                dgvEspecialidadesProf.Columns["IdUsuarioModif"].Visible = false;
                dgvEspecialidadesProf.Columns["FechaBaja"].Visible = false;
                dgvEspecialidadesProf.Columns["IdUsuarioBaja"].Visible = false;
                dgvEspecialidadesProf.AutoResizeColumns();
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

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            frmModificarEspecialidadProfesional agregar = new frmModificarEspecialidadProfesional(persona);
            agregar.ShowDialog();
            cargar();
        }

        private void btnEditarEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidades esp = (Especialidades)dgvEspecialidadesProf.CurrentRow.DataBoundItem;
            frmModificarEspecialidadProfesional modif = new frmModificarEspecialidadProfesional(persona, esp);
            modif.ShowDialog();
            cargar();
        }

        private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidades espec = (Especialidades)dgvEspecialidadesProf.CurrentRow.DataBoundItem;
                EspecialidadesNegocio neg = new EspecialidadesNegocio();
                neg.EliminarEspecialidadProfesional(espec.IdEspXProf);
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
