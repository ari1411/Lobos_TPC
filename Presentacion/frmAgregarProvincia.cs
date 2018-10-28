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
    public partial class frmAgregarProvincia : Form
    {
        public frmAgregarProvincia()
        {
            InitializeComponent();
        }

        private void frmAgregarProvincia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet5.Paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.lOBOS_DBDataSet5.Paises);

        }

        private void btnCancelarAgProvincia_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarAgProvincia_Click(object sender, EventArgs e)
        {
            if (txtProvincia.TextLength > 0)
            {
                AccesoDatos conexion = null;
                string consulta = "";
                try
                {
                    conexion = new AccesoDatos();
                    consulta = "INSERT INTO PROVINCIAS (PROVINCIA, IDPAIS, ESTADO) VALUES ('" + txtProvincia.Text + "', " + int.Parse(cboPaises.SelectedValue.ToString()) + ", 1)";

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
            else MessageBox.Show("Primero debe completar el campo Provincia.");
        }

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            frmAgregarPais pais = new frmAgregarPais();
            pais.ShowDialog();
            this.paisesTableAdapter.Fill(this.lOBOS_DBDataSet5.Paises);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.paisesTableAdapter.FillBy(this.lOBOS_DBDataSet5.Paises);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
