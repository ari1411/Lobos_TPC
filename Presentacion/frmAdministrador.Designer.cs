namespace Presentacion
{
    partial class frmAdministrador
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
            this.btnCrearAgenda = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConsultaTurnos = new System.Windows.Forms.Button();
            this.btnAltaPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearAgenda
            // 
            this.btnCrearAgenda.Location = new System.Drawing.Point(215, 163);
            this.btnCrearAgenda.Name = "btnCrearAgenda";
            this.btnCrearAgenda.Size = new System.Drawing.Size(144, 48);
            this.btnCrearAgenda.TabIndex = 0;
            this.btnCrearAgenda.Text = "Crear Agenda";
            this.btnCrearAgenda.UseVisualStyleBackColor = true;
            this.btnCrearAgenda.Click += new System.EventHandler(this.btnCrearAgenda_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.Location = new System.Drawing.Point(448, 241);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(144, 48);
            this.btnPersonas.TabIndex = 1;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(667, 459);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(105, 41);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConsultaTurnos
            // 
            this.btnConsultaTurnos.Location = new System.Drawing.Point(215, 241);
            this.btnConsultaTurnos.Name = "btnConsultaTurnos";
            this.btnConsultaTurnos.Size = new System.Drawing.Size(144, 48);
            this.btnConsultaTurnos.TabIndex = 3;
            this.btnConsultaTurnos.Text = "Consulta Turnos";
            this.btnConsultaTurnos.UseVisualStyleBackColor = true;
            this.btnConsultaTurnos.Click += new System.EventHandler(this.btnConsultaTurnos_Click);
            // 
            // btnAltaPersona
            // 
            this.btnAltaPersona.Location = new System.Drawing.Point(448, 163);
            this.btnAltaPersona.Name = "btnAltaPersona";
            this.btnAltaPersona.Size = new System.Drawing.Size(144, 47);
            this.btnAltaPersona.TabIndex = 4;
            this.btnAltaPersona.Text = "Alta Persona";
            this.btnAltaPersona.UseVisualStyleBackColor = true;
            this.btnAltaPersona.Click += new System.EventHandler(this.btnAltaPersona_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnAltaPersona);
            this.Controls.Add(this.btnConsultaTurnos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnPersonas);
            this.Controls.Add(this.btnCrearAgenda);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAdministrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAgenda;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConsultaTurnos;
        private System.Windows.Forms.Button btnAltaPersona;
    }
}