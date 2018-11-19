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
    public partial class frmAnadirFuncionPersona : Form
    {
        Persona pers = new Persona();
        Paciente paciente = new Paciente();
        PacienteNegocio pacient = new PacienteNegocio();
        Administrativo administrativo = new Administrativo();
        AdministrativoNegocio admin = new AdministrativoNegocio();
        Profesional profesional = new Profesional();
        ProfesionalNegocio prof = new ProfesionalNegocio();

        public frmAnadirFuncionPersona(Persona X)
        {
            InitializeComponent();
            pers = X;
        }

        private void frmAnadirFuncionPersona_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                paciente = pacient.VerificarExiste(pers.Id);
                administrativo = admin.VerificarExiste(pers.Id);
                profesional = prof.VerificarExiste(pers.Id);

                if (paciente.IdPaciente != 0)
                {
                    btnAgregarPaciente.Visible = false;
                    btnEditarPaciente.Visible = true;
                    btnEditarPaciente.Text = "Activar";
                    btnEliminarPaciente.Visible = true;
                    if (paciente.Estado == false)
                    {
                        btnEliminarPaciente.Enabled = false;
                        btnEditarPaciente.Enabled = true;
                    }
                    else
                    {
                        btnEliminarPaciente.Enabled = true;
                        btnEditarPaciente.Enabled = false;
                    }
                }
                if (administrativo.IdAdministrativo != 0)
                {
                    btnAgregarAdmin.Visible = false;
                    btnEditarAdmin.Visible = true;
                    btnEliminarAdmin.Visible = true;
                    if (administrativo.Estado == false)
                    {
                        btnEditarAdmin.Enabled = true;
                        btnEliminarAdmin.Enabled = false;
                    }
                    else
                    {
                        btnEditarAdmin.Enabled = true;
                        btnEliminarAdmin.Enabled = true;
                    }
                }
                if (profesional.IdProfesional != 0)
                {
                    btnAgregarMedico.Visible = false;
                    btnEditarMedico.Visible = true;
                    btnEliminarMedico.Visible = true;
                    if (profesional.Estado == false)
                    {
                        btnEliminarMedico.Enabled = false;
                        btnEditarMedico.Enabled = true;
                    }
                    else
                    {
                        btnEliminarMedico.Enabled = true;
                        btnEditarMedico.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolverAñadirFuncion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            pacient.AgregarFuncionPaciente(pers.Id);
            cargar();
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            pacient.EditarFuncionPaciente(pers.Id);
            cargar();
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            pacient.EliminarFuncionPaciente(pers.Id);
            cargar();
        }

        private void btnAgregarAdmin_Click(object sender, EventArgs e)
        {
            administrativo.Id = pers.Id;
            administrativo.Dni = pers.Dni;
            administrativo.Apellido = pers.Apellido;
            administrativo.Nombre = pers.Nombre;
            frmAgregarAdministrativo nvo = new frmAgregarAdministrativo(administrativo);
            nvo.ShowDialog();
            cargar();
        }

        private void btnEditarAdmin_Click(object sender, EventArgs e)
        {
            administrativo.Id = pers.Id;
            administrativo.Dni = pers.Dni;
            administrativo.Apellido = pers.Apellido;
            administrativo.Nombre = pers.Nombre;
            frmModificarAdministrativo modif = new frmModificarAdministrativo(administrativo);
            modif.ShowDialog();
            cargar();
        }

        private void btnEliminarAdmin_Click(object sender, EventArgs e)
        {
            admin.EliminarFuncionAdministrativo(pers.Id);
            cargar();
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            prof.AgregarFuncionProfesional(pers.Id);
            cargar();
        }

        private void btnEditarMedico_Click(object sender, EventArgs e)
        {
            frmEspecialidadesDelProfesional especialidades = new frmEspecialidadesDelProfesional(pers);
            especialidades.ShowDialog();
            cargar();
        }

        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            prof.EliminarFuncionProfesional(pers.Id);
            cargar();
        }
    }
}
