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
    public partial class frmCrearHistoriaClinica : Form
    {
        int idPte;

        public frmCrearHistoriaClinica(int IdPaciente)
        {
            InitializeComponent();
            idPte = IdPaciente;
        }

        private void frmCrearHistoriaClinica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet9.vw_RazonSocial' Puede moverla o quitarla según sea necesario.
            this.vw_RazonSocialTableAdapter.Fill(this.lOBOS_DBDataSet9.vw_RazonSocial);
            dtpFechaVtoCarnet.MinDate = DateTime.Today;
        }

        private void btnAgregarRazonSocial_Click(object sender, EventArgs e)
        {
            this.vw_RazonSocialTableAdapter.Fill(this.lOBOS_DBDataSet9.vw_RazonSocial);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNumeroAfiliado.TextLength > 0 && txtMotivoHC.TextLength > 0 && DateTime.Today.CompareTo(dtpFechaVtoCarnet.Value) < 0)
            {
                AccesoDatos conexion = null;
                string consulta = "";
                try
                {
                    conexion = new AccesoDatos();
                    consulta = "insert into HistoriaClinica (IdRazonSocial,IdPaciente,NumAfiliado,FechaVtoCarnet,Motivo,FechaAlta,IdAdmAlta,FechaModif,IdAdmModif,Estado) values (" + int.Parse(cboRazonSocial.SelectedValue.ToString()) + ", " + idPte + ", '" + txtNumeroAfiliado.Text + "','" + DateTime.Parse(dtpFechaVtoCarnet.Text).ToString("yyyy/MM/dd") + "','" + txtMotivoHC.Text + "',GETDATE(),1,GETDATE(),1,1)";

                    conexion.setearConsulta(consulta);
                    conexion.abrirConexion();
                    conexion.ejecutarAccion();
                    MessageBox.Show("Genial, se creo exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conexion != null) conexion.cerrarConexion();
                    Close();
                }
            }
            else if (!(DateTime.Today.CompareTo(dtpFechaVtoCarnet.Value) < 0)) MessageBox.Show("La fecha de vencimiento debe ser igual o posterior al dia de hoy");
            else MessageBox.Show("Para continuar primero debes completar todos los campos");
        }
    }
}
