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

namespace Presentacion
{
    public partial class frmAgregarPais : Form
    {
        public frmAgregarPais()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtPais.TextLength > 0 && txtNacionalidad.TextLength > 0 && txtNacionalidadMasc.TextLength > 0 && txtNacionalidadFem.TextLength > 0)
            {
                AccesoDatos conexion = null;
                string consulta = "";
                try
                {
                    conexion = new AccesoDatos();
                    consulta = "INSERT INTO Paises(Pais, Nacionalidad, NacionalidadM, NacionalidadF, Estado) VALUES('" + txtPais.Text + "', '" + txtNacionalidad.Text + "', '" + txtNacionalidadMasc.Text + "', '" + txtNacionalidadFem.Text + "', 1)";
                    conexion.setearConsulta(consulta);
                    conexion.abrirConexion();
                    conexion.ejecutarAccion();
                    MessageBox.Show("Genial, se agrego correctamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conexion != null)
                        conexion.cerrarConexion();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Primero debes completar todos los campos");
            }
        }
    }
}
