namespace Presentacion
{
    partial class frmAdmisionTurno
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblIngresoObservacion = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtHistoriaClinica = new System.Windows.Forms.TextBox();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellidoNombre = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblHC = new System.Windows.Forms.Label();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtHrTurno = new System.Windows.Forms.TextBox();
            this.lblFechaHrTurno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(31, 9);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(273, 13);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Estas por admisionar el turno, ¿Los datos son correctos?";
            // 
            // lblIngresoObservacion
            // 
            this.lblIngresoObservacion.AutoSize = true;
            this.lblIngresoObservacion.Location = new System.Drawing.Point(12, 246);
            this.lblIngresoObservacion.Name = "lblIngresoObservacion";
            this.lblIngresoObservacion.Size = new System.Drawing.Size(157, 13);
            this.lblIngresoObservacion.TabIndex = 1;
            this.lblIngresoObservacion.Text = "Podes modificar la observacion:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(12, 262);
            this.txtObservaciones.MaxLength = 100;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(344, 121);
            this.txtObservaciones.TabIndex = 2;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(34, 389);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(92, 36);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(246, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Location = new System.Drawing.Point(114, 74);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.ReadOnly = true;
            this.txtApellidoNombre.Size = new System.Drawing.Size(242, 20);
            this.txtApellidoNombre.TabIndex = 5;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(114, 48);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(242, 20);
            this.txtDNI.TabIndex = 6;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(114, 100);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(242, 20);
            this.txtRazonSocial.TabIndex = 7;
            // 
            // txtHistoriaClinica
            // 
            this.txtHistoriaClinica.Location = new System.Drawing.Point(114, 126);
            this.txtHistoriaClinica.Name = "txtHistoriaClinica";
            this.txtHistoriaClinica.ReadOnly = true;
            this.txtHistoriaClinica.Size = new System.Drawing.Size(242, 20);
            this.txtHistoriaClinica.TabIndex = 8;
            // 
            // txtProfesional
            // 
            this.txtProfesional.Location = new System.Drawing.Point(114, 152);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.ReadOnly = true;
            this.txtProfesional.Size = new System.Drawing.Size(242, 20);
            this.txtProfesional.TabIndex = 9;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(114, 178);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(242, 20);
            this.txtEspecialidad.TabIndex = 10;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(13, 51);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 11;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.AutoSize = true;
            this.lblApellidoNombre.Location = new System.Drawing.Point(13, 77);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(95, 13);
            this.lblApellidoNombre.TabIndex = 12;
            this.lblApellidoNombre.Text = "Apellido y Nombre:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(13, 103);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 13;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Location = new System.Drawing.Point(13, 129);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(60, 13);
            this.lblHC.TabIndex = 14;
            this.lblHC.Text = "Motivo HC:";
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(13, 155);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(59, 13);
            this.lblProfesional.TabIndex = 15;
            this.lblProfesional.Text = "Profesional";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(13, 181);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 16;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // txtHrTurno
            // 
            this.txtHrTurno.Location = new System.Drawing.Point(114, 204);
            this.txtHrTurno.Name = "txtHrTurno";
            this.txtHrTurno.ReadOnly = true;
            this.txtHrTurno.Size = new System.Drawing.Size(242, 20);
            this.txtHrTurno.TabIndex = 17;
            // 
            // lblFechaHrTurno
            // 
            this.lblFechaHrTurno.AutoSize = true;
            this.lblFechaHrTurno.Location = new System.Drawing.Point(13, 207);
            this.lblFechaHrTurno.Name = "lblFechaHrTurno";
            this.lblFechaHrTurno.Size = new System.Drawing.Size(64, 13);
            this.lblFechaHrTurno.TabIndex = 18;
            this.lblFechaHrTurno.Text = "Hora Turno:";
            // 
            // frmAdmisionTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 440);
            this.ControlBox = false;
            this.Controls.Add(this.lblFechaHrTurno);
            this.Controls.Add(this.txtHrTurno);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.lblHC);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblApellidoNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.txtHistoriaClinica);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellidoNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblIngresoObservacion);
            this.Controls.Add(this.lblPregunta);
            this.Name = "frmAdmisionTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admision Turno";
            this.Load += new System.EventHandler(this.frmAdmisionTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblIngresoObservacion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtHistoriaClinica;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellidoNombre;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblHC;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtHrTurno;
        private System.Windows.Forms.Label lblFechaHrTurno;
    }
}