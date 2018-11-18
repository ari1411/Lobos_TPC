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
    public partial class frmModificarEspecialidadProfesional : Form
    {
        Persona Pers = new Persona();
        public frmModificarEspecialidadProfesional(Persona persona)
        {
            InitializeComponent();
            Pers = persona;
        }

        private void frmModificarFuncionProfesional_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet14.VW_ESPECIALIDADES_MEDICAS' Puede moverla o quitarla según sea necesario.
            this.vW_ESPECIALIDADES_MEDICASTableAdapter.Fill(this.lOBOS_DBDataSet14.VW_ESPECIALIDADES_MEDICAS);
            lblDniApellidoNombre.Text = "DNI: " + Pers.Dni.ToString() + " - Apellido y Nombre: " + Pers.Apellido + ", " + Pers.Nombre;
        }
    }
}
