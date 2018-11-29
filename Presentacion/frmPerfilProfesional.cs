using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPerfilProfesional : Form
    {
        public frmPerfilProfesional()
        {
            InitializeComponent();
        }

        private void frmSeleccionPerfilMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet19.VW_PROFESIONALES' Puede moverla o quitarla según sea necesario.
            this.vW_PROFESIONALESTableAdapter.Fill(this.lOBOS_DBDataSet19.VW_PROFESIONALES);

        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            frmPerfilProfesionalAtender atender = new frmPerfilProfesionalAtender(int.Parse(cboProfesionalLogueado.SelectedValue.ToString()));
            atender.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
