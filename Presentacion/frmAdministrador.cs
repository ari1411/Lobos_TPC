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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void btnCrearAgenda_Click(object sender, EventArgs e)
        {
            frmCrearAgenda crear = new frmCrearAgenda();
            crear.ShowDialog();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            frmConsultasPersonas ConsPers = new frmConsultasPersonas();
            ConsPers.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultaTurnos_Click(object sender, EventArgs e)
        {
            frmConsultaTurnos consTur = new frmConsultaTurnos();
            consTur.ShowDialog();
        }

        private void btnAltaPersona_Click(object sender, EventArgs e)
        {
            frmAltaPaciente alta = new frmAltaPaciente(true);
            alta.ShowDialog();
        }
    }
}
