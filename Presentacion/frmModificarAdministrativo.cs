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
    public partial class frmModificarAdministrativo : Form
    {
        Administrativo admin = new Administrativo();
        AdministrativoNegocio neg = new AdministrativoNegocio();

        public frmModificarAdministrativo(Administrativo X)
        {
            InitializeComponent();
            admin = X;
        }

        private void frmModificarDatoAdministrativo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet13.VW_CARGOS' Puede moverla o quitarla según sea necesario.
            this.vW_CARGOSTableAdapter.Fill(this.lOBOS_DBDataSet13.VW_CARGOS);
            lblDniApellidoNombre.Text = "DNI: " + admin.Dni.ToString() + " - Apellido y Nombre: " + admin.Apellido + ", " + admin.Nombre;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                admin.IdCargo = int.Parse(cboCargo.SelectedValue.ToString());
                admin.Sector = txtSector.Text;
                if (cboEstado.Text == "ACTIVO") admin.Estado = true; else admin.Estado = false;

                neg.EditarFuncionAdministrativo(admin.Id, admin.IdCargo, admin.Sector, admin.Estado);
                MessageBox.Show("Se grabo con Exito");
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
