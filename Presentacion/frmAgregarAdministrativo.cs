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
    public partial class frmAgregarAdministrativo : Form
    {
        Administrativo pers = new Administrativo();
        AdministrativoNegocio neg = new AdministrativoNegocio();

        public frmAgregarAdministrativo(Administrativo X)
        {
            InitializeComponent();
            pers = X;
        }

        private void frmAgregarAdministrativo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet12.VW_CARGOS' Puede moverla o quitarla según sea necesario.
            this.vW_CARGOSTableAdapter.Fill(this.lOBOS_DBDataSet12.VW_CARGOS);
            lblDniApellidoNombre.Text = "DNI: " + pers.Dni.ToString() + " - " + pers.Apellido + ", " + pers.Nombre;

        }

        private void btnVolverAgregarAdmin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabarAgregarAdministrativo_Click(object sender, EventArgs e)
        {
            try
            {
                neg.AgregarFuncionAdministrativo(pers.Id, int.Parse(cboCargo.SelectedValue.ToString()), txtSector.Text);
                MessageBox.Show("Se grabo exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
