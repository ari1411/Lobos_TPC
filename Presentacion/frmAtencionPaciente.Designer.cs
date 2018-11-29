namespace Presentacion
{
    partial class frmAtencionPaciente
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
            this.txtEvolucion = new System.Windows.Forms.TextBox();
            this.lvlEscribaEvolucion = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.gbxPacienteHC = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblMotivoHC = new System.Windows.Forms.Label();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.lblFechaHrTurno = new System.Windows.Forms.Label();
            this.lblprofesional = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblFechaHrAsignado = new System.Windows.Forms.Label();
            this.lblUsuarioAsigna = new System.Windows.Forms.Label();
            this.lblUsuarioAdmin = new System.Windows.Forms.Label();
            this.gbxPacienteHC.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEvolucion
            // 
            this.txtEvolucion.Location = new System.Drawing.Point(12, 56);
            this.txtEvolucion.Multiline = true;
            this.txtEvolucion.Name = "txtEvolucion";
            this.txtEvolucion.Size = new System.Drawing.Size(285, 390);
            this.txtEvolucion.TabIndex = 0;
            // 
            // lvlEscribaEvolucion
            // 
            this.lvlEscribaEvolucion.AutoSize = true;
            this.lvlEscribaEvolucion.Location = new System.Drawing.Point(13, 37);
            this.lvlEscribaEvolucion.Name = "lvlEscribaEvolucion";
            this.lvlEscribaEvolucion.Size = new System.Drawing.Size(131, 13);
            this.lvlEscribaEvolucion.TabIndex = 1;
            this.lvlEscribaEvolucion.Text = "Escriba aqui su evolucion:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(6, 32);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 13);
            this.lblPaciente.TabIndex = 2;
            this.lblPaciente.Text = "Paciente:";
            // 
            // gbxPacienteHC
            // 
            this.gbxPacienteHC.Controls.Add(this.lblMotivoHC);
            this.gbxPacienteHC.Controls.Add(this.lblRazonSocial);
            this.gbxPacienteHC.Controls.Add(this.lblDni);
            this.gbxPacienteHC.Controls.Add(this.lblPaciente);
            this.gbxPacienteHC.Location = new System.Drawing.Point(422, 56);
            this.gbxPacienteHC.Name = "gbxPacienteHC";
            this.gbxPacienteHC.Size = new System.Drawing.Size(310, 166);
            this.gbxPacienteHC.TabIndex = 3;
            this.gbxPacienteHC.TabStop = false;
            this.gbxPacienteHC.Text = "Detalles Paciente y Historia Clinica";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(7, 49);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "Dni: ";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(10, 83);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 4;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // lblMotivoHC
            // 
            this.lblMotivoHC.AutoSize = true;
            this.lblMotivoHC.Location = new System.Drawing.Point(10, 117);
            this.lblMotivoHC.Name = "lblMotivoHC";
            this.lblMotivoHC.Size = new System.Drawing.Size(60, 13);
            this.lblMotivoHC.TabIndex = 5;
            this.lblMotivoHC.Text = "Motivo HC:";
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.lblUsuarioAdmin);
            this.gbxTurno.Controls.Add(this.lblUsuarioAsigna);
            this.gbxTurno.Controls.Add(this.lblFechaHrAsignado);
            this.gbxTurno.Controls.Add(this.lblObservaciones);
            this.gbxTurno.Controls.Add(this.lblEspecialidad);
            this.gbxTurno.Controls.Add(this.lblprofesional);
            this.gbxTurno.Controls.Add(this.lblFechaHrTurno);
            this.gbxTurno.Location = new System.Drawing.Point(422, 255);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(319, 191);
            this.gbxTurno.TabIndex = 4;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // lblFechaHrTurno
            // 
            this.lblFechaHrTurno.AutoSize = true;
            this.lblFechaHrTurno.Location = new System.Drawing.Point(6, 16);
            this.lblFechaHrTurno.Name = "lblFechaHrTurno";
            this.lblFechaHrTurno.Size = new System.Drawing.Size(72, 13);
            this.lblFechaHrTurno.TabIndex = 0;
            this.lblFechaHrTurno.Text = "Fecha y hora:";
            // 
            // lblprofesional
            // 
            this.lblprofesional.AutoSize = true;
            this.lblprofesional.Location = new System.Drawing.Point(6, 41);
            this.lblprofesional.Name = "lblprofesional";
            this.lblprofesional.Size = new System.Drawing.Size(62, 13);
            this.lblprofesional.TabIndex = 1;
            this.lblprofesional.Text = "Profesional:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(7, 68);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(7, 98);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblFechaHrAsignado
            // 
            this.lblFechaHrAsignado.AutoSize = true;
            this.lblFechaHrAsignado.Location = new System.Drawing.Point(6, 127);
            this.lblFechaHrAsignado.Name = "lblFechaHrAsignado";
            this.lblFechaHrAsignado.Size = new System.Drawing.Size(86, 13);
            this.lblFechaHrAsignado.TabIndex = 4;
            this.lblFechaHrAsignado.Text = "Fecha asignado:";
            // 
            // lblUsuarioAsigna
            // 
            this.lblUsuarioAsigna.AutoSize = true;
            this.lblUsuarioAsigna.Location = new System.Drawing.Point(5, 149);
            this.lblUsuarioAsigna.Name = "lblUsuarioAsigna";
            this.lblUsuarioAsigna.Size = new System.Drawing.Size(72, 13);
            this.lblUsuarioAsigna.TabIndex = 5;
            this.lblUsuarioAsigna.Text = "Asignado por:";
            // 
            // lblUsuarioAdmin
            // 
            this.lblUsuarioAdmin.AutoSize = true;
            this.lblUsuarioAdmin.Location = new System.Drawing.Point(10, 175);
            this.lblUsuarioAdmin.Name = "lblUsuarioAdmin";
            this.lblUsuarioAdmin.Size = new System.Drawing.Size(68, 13);
            this.lblUsuarioAdmin.TabIndex = 6;
            this.lblUsuarioAdmin.Text = "Admitido por:";
            // 
            // frmAtencionPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxPacienteHC);
            this.Controls.Add(this.lvlEscribaEvolucion);
            this.Controls.Add(this.txtEvolucion);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmAtencionPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atencion Paciente";
            this.Load += new System.EventHandler(this.frmAtencionPaciente_Load);
            this.gbxPacienteHC.ResumeLayout(false);
            this.gbxPacienteHC.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEvolucion;
        private System.Windows.Forms.Label lvlEscribaEvolucion;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.GroupBox gbxPacienteHC;
        private System.Windows.Forms.Label lblMotivoHC;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.Label lblUsuarioAdmin;
        private System.Windows.Forms.Label lblUsuarioAsigna;
        private System.Windows.Forms.Label lblFechaHrAsignado;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblprofesional;
        private System.Windows.Forms.Label lblFechaHrTurno;
    }
}