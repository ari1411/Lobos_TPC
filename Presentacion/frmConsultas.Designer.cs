﻿namespace Presentacion
{
    partial class frmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsultasPacientes = new System.Windows.Forms.Button();
            this.btnConsultasVolver = new System.Windows.Forms.Button();
            this.btnConsultasTurnos = new System.Windows.Forms.Button();
            this.btnConsultasEvoluciones = new System.Windows.Forms.Button();
            this.btnConsultasUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultasPacientes
            // 
            this.btnConsultasPacientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultasPacientes.AutoSize = true;
            this.btnConsultasPacientes.Location = new System.Drawing.Point(91, 130);
            this.btnConsultasPacientes.Name = "btnConsultasPacientes";
            this.btnConsultasPacientes.Size = new System.Drawing.Size(144, 75);
            this.btnConsultasPacientes.TabIndex = 0;
            this.btnConsultasPacientes.Text = "Consultas de Pacientes";
            this.btnConsultasPacientes.UseVisualStyleBackColor = true;
            this.btnConsultasPacientes.Click += new System.EventHandler(this.btnConsultasPacientes_Click);
            // 
            // btnConsultasVolver
            // 
            this.btnConsultasVolver.Location = new System.Drawing.Point(585, 442);
            this.btnConsultasVolver.Name = "btnConsultasVolver";
            this.btnConsultasVolver.Size = new System.Drawing.Size(187, 58);
            this.btnConsultasVolver.TabIndex = 4;
            this.btnConsultasVolver.Text = "Volver";
            this.btnConsultasVolver.UseVisualStyleBackColor = true;
            this.btnConsultasVolver.Click += new System.EventHandler(this.btnConsultasVolver_Click);
            // 
            // btnConsultasTurnos
            // 
            this.btnConsultasTurnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultasTurnos.AutoSize = true;
            this.btnConsultasTurnos.Location = new System.Drawing.Point(333, 130);
            this.btnConsultasTurnos.Name = "btnConsultasTurnos";
            this.btnConsultasTurnos.Size = new System.Drawing.Size(144, 75);
            this.btnConsultasTurnos.TabIndex = 1;
            this.btnConsultasTurnos.Text = "Consultas de Turnos";
            this.btnConsultasTurnos.UseVisualStyleBackColor = true;
            // 
            // btnConsultasEvoluciones
            // 
            this.btnConsultasEvoluciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultasEvoluciones.AutoSize = true;
            this.btnConsultasEvoluciones.Location = new System.Drawing.Point(562, 130);
            this.btnConsultasEvoluciones.Name = "btnConsultasEvoluciones";
            this.btnConsultasEvoluciones.Size = new System.Drawing.Size(144, 75);
            this.btnConsultasEvoluciones.TabIndex = 2;
            this.btnConsultasEvoluciones.Text = "Consultas de Evoluciones";
            this.btnConsultasEvoluciones.UseVisualStyleBackColor = true;
            // 
            // btnConsultasUsuarios
            // 
            this.btnConsultasUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultasUsuarios.AutoSize = true;
            this.btnConsultasUsuarios.Location = new System.Drawing.Point(333, 258);
            this.btnConsultasUsuarios.Name = "btnConsultasUsuarios";
            this.btnConsultasUsuarios.Size = new System.Drawing.Size(144, 75);
            this.btnConsultasUsuarios.TabIndex = 3;
            this.btnConsultasUsuarios.Text = "Consultas de Usuarios";
            this.btnConsultasUsuarios.UseVisualStyleBackColor = true;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnConsultasUsuarios);
            this.Controls.Add(this.btnConsultasEvoluciones);
            this.Controls.Add(this.btnConsultasTurnos);
            this.Controls.Add(this.btnConsultasVolver);
            this.Controls.Add(this.btnConsultasPacientes);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultasPacientes;
        private System.Windows.Forms.Button btnConsultasVolver;
        private System.Windows.Forms.Button btnConsultasTurnos;
        private System.Windows.Forms.Button btnConsultasEvoluciones;
        private System.Windows.Forms.Button btnConsultasUsuarios;
    }
}