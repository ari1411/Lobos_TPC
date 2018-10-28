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
    public partial class frmAgregarSexo : Form
    {
        public frmAgregarSexo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtSexo.TextLength > 0)
            {
                AccesoDatos conexion = null;
                string consulta = "";
                try
                {
                    conexion = new AccesoDatos();
                    consulta = "INSERT INTO Sexo(Sexo) VALUES('" + txtSexo.Text + "')";

                    conexion.setearConsulta(consulta);
                    conexion.abrirConexion();
                    conexion.ejecutarAccion();
                    MessageBox.Show("Genial, se agrego con exito!");
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
            else MessageBox.Show("Primero tenes que escribir algo...");
        }
    }
}
