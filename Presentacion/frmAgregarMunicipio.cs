﻿using System;
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
    public partial class frmAgregarMunicipio : Form
    {
        public frmAgregarMunicipio()
        {
            InitializeComponent();
        }

        private void frmAgregarMunicipio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lOBOS_DBDataSet3.VW_PARTIDOS' Puede moverla o quitarla según sea necesario.
            this.vW_PARTIDOSTableAdapter.Fill(this.lOBOS_DBDataSet3.VW_PARTIDOS);

        }

        private void btnCancelarAgMun_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarAgMun_Click(object sender, EventArgs e)
        {
            if (txtMunicipio.TextLength > 0 && txtCP.TextLength > 0)
            {
                AccesoDatos conexion = null;
                string consulta = "";
                try
                {
                    conexion = new AccesoDatos();
                    consulta = "INSERT INTO Municipios (Municipio, CP, IdPartido, Estado) VALUES ('" + txtMunicipio.Text + "', '" + txtCP.Text + "', " + int.Parse(cboPartidos.SelectedValue.ToString()) + ", 1)";

                    conexion.setearConsulta(consulta);
                    conexion.abrirConexion();
                    conexion.ejecutarAccion();
                    MessageBox.Show("Genial, se agrego con exito!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conexion != null)
                        conexion.cerrarConexion();
                    Close();
                }
            }
            else MessageBox.Show("Primero debe completar los campos Municipio y CP.");
        }

        private void btnAgregarPartido_Click(object sender, EventArgs e)
        {
            frmAgregarPartido part = new frmAgregarPartido();
            part.ShowDialog();
            this.vW_PARTIDOSTableAdapter.Fill(this.lOBOS_DBDataSet3.VW_PARTIDOS);
        }
    }
}
