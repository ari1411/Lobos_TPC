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
    public partial class frmAltaPaciente : Form
    {
        bool altaPersona = false;

        public frmAltaPaciente()
        {
            InitializeComponent();
        }

        public frmAltaPaciente(bool esAltaPersona)
        {
            InitializeComponent();
            Text = "Alta Persona";
            altaPersona = true;
        }

        private void frmAltaPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet2.VW_MUNICIPIOS' Puede moverla o quitarla según sea necesario.
            this.vW_MUNICIPIOSTableAdapter.Fill(this.lOBOS_DBDataSet2.VW_MUNICIPIOS);
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet1.VW_NACIONALIDAD' Puede moverla o quitarla según sea necesario.
            this.vW_NACIONALIDADTableAdapter.Fill(this.lOBOS_DBDataSet1.VW_NACIONALIDAD);
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet.Sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.lOBOS_DBDataSet.Sexo);
            dtpFechaNacimiento.Value = dtpFechaNacimiento.MaxDate = DateTime.Today;
        }

        private void lblTelMovil_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDni.TextLength > 0 && txtApellido.TextLength > 0 && txtNombre.TextLength > 0 && txtCalle.TextLength > 0 && txtNumero.TextLength > 0)
            {
                try
                {
                    if (altaPersona == false)
                    {
                        PacienteNegocio neg = new PacienteNegocio();
                        Paciente nvo = new Paciente();
                        nvo.Dni = txtDni.Text;
                        nvo.Apellido = txtApellido.Text;
                        nvo.Nombre = txtNombre.Text;
                        nvo.IdSexo = int.Parse(cboSexo.SelectedValue.ToString());
                        nvo.IdNacionalidad = int.Parse(cboNacionalidad.SelectedValue.ToString());
                        nvo.FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
                        nvo.Calle = txtCalle.Text;
                        nvo.Altura = txtNumero.Text;
                        nvo.Piso = txtPiso.Text;
                        nvo.Dpto = txtDepto.Text;
                        nvo.IdMunicipio = int.Parse(cboMunicipio.SelectedValue.ToString());
                        nvo.TelCelular = txtTelMovil.Text;
                        nvo.TelFijo = txtTelFijo.Text;
                        nvo.Mail = txtMail.Text;
                        nvo.IdUsuarioAlta = 1;
                        nvo.IdUsuarioModif = 1;

                        neg.Alta(nvo);
                        MessageBox.Show("Se grabo con exito");
                        Close();
                    }
                    else if (altaPersona == true)
                    {
                        PersonaNegocio neg = new PersonaNegocio();
                        Persona nvo = new Persona();
                        nvo.Dni = txtDni.Text;
                        nvo.Apellido = txtApellido.Text;
                        nvo.Nombre = txtNombre.Text;
                        nvo.IdSexo = int.Parse(cboSexo.SelectedValue.ToString());
                        nvo.IdNacionalidad = int.Parse(cboNacionalidad.SelectedValue.ToString());
                        nvo.FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
                        nvo.Calle = txtCalle.Text;
                        nvo.Altura = txtNumero.Text;
                        nvo.Piso = txtPiso.Text;
                        nvo.Dpto = txtDepto.Text;
                        nvo.IdMunicipio = int.Parse(cboMunicipio.SelectedValue.ToString());
                        nvo.TelCelular = txtTelMovil.Text;
                        nvo.TelFijo = txtTelFijo.Text;
                        nvo.Mail = txtMail.Text;
                        nvo.IdUsuarioAlta = 1;
                        nvo.IdUsuarioModif = 1;

                        neg.Alta(nvo);
                        MessageBox.Show("Se grabo con exito");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnAgregarSexo_Click(object sender, EventArgs e)
        {
            frmAgregarSexo sex = new frmAgregarSexo();
            sex.ShowDialog();
            this.sexoTableAdapter.Fill(this.lOBOS_DBDataSet.Sexo);
        }

        private void btnAgregarNacionalidad_Click(object sender, EventArgs e)
        {
            frmAgregarPais pais = new frmAgregarPais();
            pais.ShowDialog();
            this.vW_NACIONALIDADTableAdapter.Fill(this.lOBOS_DBDataSet1.VW_NACIONALIDAD);
        }

        private void btnAgregarMunicipio_Click(object sender, EventArgs e)
        {
            frmAgregarMunicipio mun = new frmAgregarMunicipio();
            mun.ShowDialog();
            this.vW_MUNICIPIOSTableAdapter.Fill(this.lOBOS_DBDataSet2.VW_MUNICIPIOS);
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
    }
}
