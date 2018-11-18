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
    public partial class frmAgregarEspecialidadMedica : Form
    {
        public frmAgregarEspecialidadMedica()
        {
            InitializeComponent();
        }

        private void btnVolverEspecialidad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabarEspecialidad_Click(object sender, EventArgs e)
        {
            try
            {
                EspecialidadesNegocio neg = new EspecialidadesNegocio();
                neg.AgregarEspecialidad(txtEspecialidadNueva.Text);
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
