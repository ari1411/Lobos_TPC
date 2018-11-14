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
    public partial class frmModificarHistoriaClinica : Form
    {
        int pte;
        HC aux = null;
        
        public frmModificarHistoriaClinica(int idPaciente, HC historiaClinica)
        {
            InitializeComponent();
            pte = idPaciente;
            aux = historiaClinica;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmModificarHistoriaClinica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet11.vw_RazonSocial' Puede moverla o quitarla según sea necesario.
            this.vw_RazonSocialTableAdapter.Fill(this.lOBOS_DBDataSet11.vw_RazonSocial);
            cboRazonSocial.SelectedValue = aux.IdRazonSocial.ToString();
            txtNumeroAfiliado.Text = aux.NumeroAfiliado;
            dtpFechaVtoCarnet.Text = aux.FechaVencimientoCarnet.ToString();
            txtMotivoHC.Text = aux.DescripcionAccidente;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNumeroAfiliado.TextLength > 0 && txtMotivoHC.TextLength > 0) //No verifica si el carnet esta vencido por que tal vez se modifique tiempo despues de la atencion.
            {
                HCnegocio neg = new HCnegocio();
                try
                {
                    aux.IdRazonSocial = int.Parse(cboRazonSocial.SelectedValue.ToString());
                    aux.NumeroAfiliado = txtNumeroAfiliado.Text;
                    aux.FechaVencimientoCarnet = DateTime.Parse(dtpFechaVtoCarnet.Text);
                    aux.DescripcionAccidente = txtMotivoHC.Text;

                    neg.editarHC(aux);
                    MessageBox.Show("Se edito exitosamente");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("Todos los campos deben estar completos");
        }
    }
}
