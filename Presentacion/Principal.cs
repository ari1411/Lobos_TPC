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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarSesion(); // Lo probamos el cuatrimestre pasado y funcionaba
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            foreach (Form Ariel in Application.OpenForms)
            {
                if (Ariel.GetType() == typeof(frmInicio))
                {
                    MessageBox.Show("¿¿Que haces?? ¡ya esta abierta!");
                    return;
                }
            }
            frmInicio Inicio = new frmInicio();
            Inicio.MdiParent = this;
            Inicio.WindowState = FormWindowState.Maximized;
            Inicio.Show();
        }
    }
}
