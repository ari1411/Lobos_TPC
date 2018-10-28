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
    public partial class frmAgregarPartido : Form
    {
        public frmAgregarPartido()
        {
            InitializeComponent();
        }

        private void frmAgregarPartido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet4.VW_PROVINCIAS' Puede moverla o quitarla según sea necesario.
            this.vW_PROVINCIASTableAdapter.Fill(this.lOBOS_DBDataSet4.VW_PROVINCIAS);

        }

        private void btnCancelarAgPartido_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarAgPartido_Click(object sender, EventArgs e)
        {
            if (txtPartido.TextLength > 0)
            {
                AccesoDatos conexion = null;
                string consulta = "";
                try
                {
                    conexion = new AccesoDatos();
                    consulta = "INSERT INTO PARTIDOS (PARTIDO, IDPROVINCIA, ESTADO) VALUES ('" + txtPartido.Text + "', " + int.Parse(cboProvincias.SelectedValue.ToString()) + ", 1)";

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
            else MessageBox.Show("Primero debe completar el campo Partido.");
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            frmAgregarProvincia prov = new frmAgregarProvincia();
            prov.ShowDialog();
            this.vW_PROVINCIASTableAdapter.Fill(this.lOBOS_DBDataSet4.VW_PROVINCIAS);
        }
    }
}
