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
    public partial class frmModificarEspecialidadProfesional : Form
    {
        Persona pers = new Persona();
        Especialidades esp = new Especialidades();
        bool esModificar = true;
        EspecialidadesNegocio neg = new EspecialidadesNegocio();

        public frmModificarEspecialidadProfesional(Persona persona) //añadir especialidad
        {
            InitializeComponent();
            pers = persona;
            esModificar = false;
            this.Text = "Agregar Especialidad";
        }

        public frmModificarEspecialidadProfesional(Persona persona, Especialidades especialidad) //modifica especialidad
        {
            InitializeComponent();
            esp = especialidad;
            pers = persona;
            esModificar = true;
            cboEspecialidad.Enabled = false;
        }

        private void frmModificarFuncionProfesional_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet14.VW_ESPECIALIDADES_MEDICAS' Puede moverla o quitarla según sea necesario.
            this.vW_ESPECIALIDADES_MEDICASTableAdapter.Fill(this.lOBOS_DBDataSet14.VW_ESPECIALIDADES_MEDICAS);
            lblDniApellidoNombre.Text = "DNI: " + pers.Dni.ToString() + " - Apellido y Nombre: " + pers.Apellido + ", " + pers.Nombre;
            dtpVtoMatNac.Text = dtpVtoMatProv.Text = DateTime.Today.ToString();
            if (esModificar == true)
            {
                cboEspecialidad.SelectedValue = esp.IdEspecialidad.ToString();
                txtMatriculaNac.Text = esp.MatriculaNac;
                if (esp.MatriculaNac.Length > 0) dtpVtoMatNac.Text = esp.FechaVtoNac.ToString();
                txtMatriculaProv.Text = esp.MatriculaProv;
                if (esp.MatriculaProv.Length > 0) dtpVtoMatProv.Text = esp.FechaVtoProv.ToString();
            }
        }

        private void btnGrabarEspecialidadMed_Click(object sender, EventArgs e)
        {
            try
            {
                esp.IdProfesional = pers.Id;
                esp.IdEspecialidad = int.Parse(cboEspecialidad.SelectedValue.ToString());
                esp.MatriculaNac = txtMatriculaNac.Text;
                esp.FechaVtoNac = DateTime.Parse(dtpVtoMatNac.Text);
                esp.MatriculaProv = txtMatriculaProv.Text;
                esp.FechaVtoProv = DateTime.Parse(dtpVtoMatProv.Text);

                if (esModificar == false) //añadir especialidad
                {
                    neg.AgregarEspecialidadProfesional(esp);
                }
                if (esModificar == true) //modifica especialidad
                {
                    neg.ModificarEspecialidadProfesional(esp);
                }
                MessageBox.Show("Se grabo exitosamente");
                Close();
            }
            catch (Exception) // No encontre la forma de manejar la excepcion por infringir una primary key, igualmente esta validado para que no pinche de otro modo.
            {
                MessageBox.Show("El profesional ya posee asignada la Especialidad elegida");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
