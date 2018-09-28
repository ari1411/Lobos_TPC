﻿namespace Presentacion
{
    partial class frmInicio
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
            this.btnAltaPaciente = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.btnAdmision = new System.Windows.Forms.Button();
            this.btnEditarTurno = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaPaciente
            // 
            this.btnAltaPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaPaciente.AutoSize = true;
            this.btnAltaPaciente.Location = new System.Drawing.Point(100, 70);
            this.btnAltaPaciente.Name = "btnAltaPaciente";
            this.btnAltaPaciente.Size = new System.Drawing.Size(120, 75);
            this.btnAltaPaciente.TabIndex = 0;
            this.btnAltaPaciente.Text = "Alta Paciente";
            this.btnAltaPaciente.UseVisualStyleBackColor = true;
            this.btnAltaPaciente.Click += new System.EventHandler(this.btnAltaPaciente_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultas.Location = new System.Drawing.Point(320, 70);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(120, 75);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click_1);
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAsignarTurno.Location = new System.Drawing.Point(560, 70);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(120, 75);
            this.btnAsignarTurno.TabIndex = 2;
            this.btnAsignarTurno.Text = "Asignar Turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            this.btnAsignarTurno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdmision
            // 
            this.btnAdmision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmision.Location = new System.Drawing.Point(100, 241);
            this.btnAdmision.Name = "btnAdmision";
            this.btnAdmision.Size = new System.Drawing.Size(120, 75);
            this.btnAdmision.TabIndex = 3;
            this.btnAdmision.Text = "Admision";
            this.btnAdmision.UseVisualStyleBackColor = true;
            this.btnAdmision.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnEditarTurno
            // 
            this.btnEditarTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarTurno.Location = new System.Drawing.Point(320, 241);
            this.btnEditarTurno.Name = "btnEditarTurno";
            this.btnEditarTurno.Size = new System.Drawing.Size(120, 75);
            this.btnEditarTurno.TabIndex = 4;
            this.btnEditarTurno.Text = "Editar Turno";
            this.btnEditarTurno.UseVisualStyleBackColor = true;
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdministrador.Location = new System.Drawing.Point(560, 241);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(120, 75);
            this.btnAdministrador.TabIndex = 5;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(492, 428);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(280, 50);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnEditarTurno);
            this.Controls.Add(this.btnAdmision);
            this.Controls.Add(this.btnAsignarTurno);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnAltaPaciente);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inicio";
            this.MaximumSizeChanged += new System.EventHandler(this.frmInicio_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaPaciente;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.Button btnAdmision;
        private System.Windows.Forms.Button btnEditarTurno;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}