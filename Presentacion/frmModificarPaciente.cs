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
    public partial class frmModificarPaciente : Form
    {
        Paciente aux;
        public frmModificarPaciente(Paciente paciente)
        {
            InitializeComponent();
            aux = paciente;
        }

        public frmModificarPaciente(Persona paciente)
        {
            InitializeComponent();
            aux = (Paciente)paciente;
            Text = "Modificar Persona";
        }

        private void frmModificarPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet8.VW_MUNICIPIOS' Puede moverla o quitarla según sea necesario.
            this.vW_MUNICIPIOSTableAdapter.Fill(this.lOBOS_DBDataSet8.VW_MUNICIPIOS);
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet7.VW_NACIONALIDAD' Puede moverla o quitarla según sea necesario.
            this.vW_NACIONALIDADTableAdapter.Fill(this.lOBOS_DBDataSet7.VW_NACIONALIDAD);
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet6.Sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.lOBOS_DBDataSet6.Sexo);

            txtDni.Text = aux.Dni;
            txtApellido.Text = aux.Apellido;
            txtNombre.Text = aux.Nombre;
            cboSexo.SelectedValue = aux.IdSexo.ToString();
            cboNacionalidad.SelectedValue = aux.IdNacionalidad.ToString();
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            dtpFechaNacimiento.Text = aux.FechaNacimiento.ToString();
            txtCalle.Text = aux.Calle;
            txtNumero.Text = aux.Altura;
            txtPiso.Text = aux.Piso;
            txtDepto.Text = aux.Dpto;
            cboMunicipio.SelectedValue = aux.IdMunicipio.ToString();
            txtTelMovil.Text = aux.TelCelular;
            txtTelFijo.Text = aux.TelFijo;
            txtMail.Text = aux.Mail;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarSexo_Click(object sender, EventArgs e)
        {
            frmAgregarSexo sex = new frmAgregarSexo();
            sex.ShowDialog();
            this.sexoTableAdapter.Fill(this.lOBOS_DBDataSet6.Sexo);
        }

        private void btnAgregarNacionalidad_Click(object sender, EventArgs e)
        {
            frmAgregarPais pais = new frmAgregarPais();
            pais.ShowDialog();
            this.vW_NACIONALIDADTableAdapter.Fill(this.lOBOS_DBDataSet7.VW_NACIONALIDAD);
        }

        private void btnAgregarMunicipio_Click(object sender, EventArgs e)
        {
            frmAgregarMunicipio mun = new frmAgregarMunicipio();
            mun.ShowDialog();
            this.vW_MUNICIPIOSTableAdapter.Fill(this.lOBOS_DBDataSet8.VW_MUNICIPIOS);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Separator))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDni.TextLength > 0 && txtApellido.TextLength > 0 && txtNombre.TextLength > 0 && txtCalle.TextLength > 0 && txtNumero.TextLength > 0)
            {

                PacienteNegocio neg = new PacienteNegocio();
                try
                {
                    aux.Dni = txtDni.Text;
                    aux.Apellido = txtApellido.Text;
                    aux.Nombre = txtNombre.Text;
                    aux.IdSexo = int.Parse(cboSexo.SelectedValue.ToString());
                    aux.FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
                    aux.IdNacionalidad = int.Parse(cboNacionalidad.SelectedValue.ToString());
                    aux.Calle = txtCalle.Text;
                    aux.Altura = txtNumero.Text;
                    aux.Piso = txtPiso.Text;
                    aux.Dpto = txtDepto.Text;
                    aux.IdMunicipio = int.Parse(cboMunicipio.SelectedValue.ToString());
                    aux.TelCelular = txtTelMovil.Text;
                    aux.TelFijo = txtTelFijo.Text;
                    aux.Mail = txtMail.Text;
                    aux.IdUsuarioModif = 1;

                    neg.Modificar(aux);
                    MessageBox.Show("Se grabo con exito");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
