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
            if (txtNumeroAfiliado.TextLength > 0 && txtMotivoHC.TextLength > 0 && DateTime.Today.CompareTo(dtpFechaVtoCarnet.Value)>0)
            {
                AccesoDatos conexion = null;
                string consulta = "insert into HistoriaClinica (IdRazonSocial,IdPaciente,NumAfiliado,FechaVtoCarnet,Motivo,FechaAlta,IdAdmAlta,FechaModif,IdAdmModif,Estado) values (" + int.Parse(cboRazonSocial.SelectedValue.ToString()) + ", " + idPte + ",'0-35755757-3','2018/12/10','Hiper actividad',GETDATE(),1,GETDATE(),1,1)";
                try
                {
                    conexion = new AccesoDatos();
                    consulta = "";

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
        }
    }
}
