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
    public partial class frmConsultaTurnos : Form
    {
        int seleccion = 0; //segun la seleccion del radiobutton
        public frmConsultaTurnos()
        {
            InitializeComponent();
        }

        private void frmConsultaTurnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet20.VW_ESPECIALIDADES_MEDICAS' Puede moverla o quitarla según sea necesario.
            this.vW_ESPECIALIDADES_MEDICASTableAdapter.Fill(this.lOBOS_DBDataSet20.VW_ESPECIALIDADES_MEDICAS);
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet19.VW_PROFESIONALES' Puede moverla o quitarla según sea necesario.
            this.vW_PROFESIONALESTableAdapter.Fill(this.lOBOS_DBDataSet19.VW_PROFESIONALES);
            seleccion = 1;
        }

        private void rdbProfesional_CheckedChanged(object sender, EventArgs e)
        {
            lblProfesional.Visible = cboProfesional.Visible = true;
            lblEspecialidad.Visible = cboEspecialidad.Visible = false;
            seleccion = 2;
        }

        private void rdbEspecialidad_CheckedChanged(object sender, EventArgs e)
        {
            lblProfesional.Visible = cboProfesional.Visible = false;
            lblEspecialidad.Visible = cboEspecialidad.Visible = true;
            seleccion = 3;
        }

        private void rdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            lblProfesional.Visible = cboProfesional.Visible = false;
            lblEspecialidad.Visible = cboEspecialidad.Visible = false;
            seleccion = 1;
        }

        private void cboProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime inicial = DateTime.Parse(dtpFechaDesde.Text);
            DateTime final = DateTime.Parse(dtpFechaHasta.Text);
            int profesional = int.Parse(cboProfesional.SelectedValue.ToString());
            int especialidad = int.Parse(cboEspecialidad.SelectedValue.ToString());
            frmConsultaTurnosResultado nvo = new frmConsultaTurnosResultado(inicial,final, profesional, especialidad, seleccion);
            nvo.ShowDialog();
        }
    }




}
