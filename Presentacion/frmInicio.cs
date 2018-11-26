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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            frmAdministrador admin = new frmAdministrador();
            admin.ShowDialog();
        }

        private void btnAltaPaciente_Click(object sender, EventArgs e)
        {
            /*foreach (Form Ariel in Application.OpenForms)
             {
                 if (Ariel.GetType() == typeof(frmAltaPaciente))
                 {
                     MessageBox.Show("Ya está abierta...");
                     return;
                 }
             }
             frmAltaPaciente AltaPte = new frmAltaPaciente();
             AltaPte.MdiParent = frmPrincipal;
             AltaPte.WindowState = FormWindowState.Maximized;
             AltaPte.Show();*/

            frmAltaPaciente AltaPte = new frmAltaPaciente();
            AltaPte.ShowDialog();
        }

        private void btnConsultas_Click_1(object sender, EventArgs e)
        {
            frmConsultas Consultas = new frmConsultas();
            Consultas.ShowDialog();
        }

        private void btnAdmision_Click(object sender, EventArgs e)
        {
            frmAdmision admin = new frmAdmision();
            admin.ShowDialog();
        }

        private void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            frmAsignarTurno asig = new frmAsignarTurno();
            asig.ShowDialog();
        }
    }
}
