﻿using System;
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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void btnConsultasVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultasPacientes_Click(object sender, EventArgs e)
        {
            frmConsultasPacientes ConsPte = new frmConsultasPacientes();
            ConsPte.ShowDialog();
        }


        private void btnConsultasTurnos_Click(object sender, EventArgs e)
        {
            frmConsultaTurnos consTur = new frmConsultaTurnos();
            consTur.ShowDialog();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

        }
    }
}
