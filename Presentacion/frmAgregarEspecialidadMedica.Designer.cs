namespace Presentacion
{
    partial class frmAgregarEspecialidadMedica
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
            this.txtEspecialidadNueva = new System.Windows.Forms.TextBox();
            this.btnGrabarEspecialidad = new System.Windows.Forms.Button();
            this.btnVolverEspecialidad = new System.Windows.Forms.Button();
            this.lblNuevaEspecialidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEspecialidadNueva
            // 
            this.txtEspecialidadNueva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEspecialidadNueva.Location = new System.Drawing.Point(37, 73);
            this.txtEspecialidadNueva.MaxLength = 50;
            this.txtEspecialidadNueva.Name = "txtEspecialidadNueva";
            this.txtEspecialidadNueva.Size = new System.Drawing.Size(163, 20);
            this.txtEspecialidadNueva.TabIndex = 0;
            // 
            // btnGrabarEspecialidad
            // 
            this.btnGrabarEspecialidad.Location = new System.Drawing.Point(12, 137);
            this.btnGrabarEspecialidad.Name = "btnGrabarEspecialidad";
            this.btnGrabarEspecialidad.Size = new System.Drawing.Size(94, 36);
            this.btnGrabarEspecialidad.TabIndex = 1;
            this.btnGrabarEspecialidad.Text = "Grabar";
            this.btnGrabarEspecialidad.UseVisualStyleBackColor = true;
            this.btnGrabarEspecialidad.Click += new System.EventHandler(this.btnGrabarEspecialidad_Click);
            // 
            // btnVolverEspecialidad
            // 
            this.btnVolverEspecialidad.Location = new System.Drawing.Point(134, 137);
            this.btnVolverEspecialidad.Name = "btnVolverEspecialidad";
            this.btnVolverEspecialidad.Size = new System.Drawing.Size(94, 36);
            this.btnVolverEspecialidad.TabIndex = 2;
            this.btnVolverEspecialidad.Text = "Volver";
            this.btnVolverEspecialidad.UseVisualStyleBackColor = true;
            this.btnVolverEspecialidad.Click += new System.EventHandler(this.btnVolverEspecialidad_Click);
            // 
            // lblNuevaEspecialidad
            // 
            this.lblNuevaEspecialidad.AutoSize = true;
            this.lblNuevaEspecialidad.Location = new System.Drawing.Point(45, 41);
            this.lblNuevaEspecialidad.Name = "lblNuevaEspecialidad";
            this.lblNuevaEspecialidad.Size = new System.Drawing.Size(143, 13);
            this.lblNuevaEspecialidad.TabIndex = 3;
            this.lblNuevaEspecialidad.Text = "Ingrese Nueva Especialidad:";
            // 
            // frmAgregarEspecialidadMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 185);
            this.Controls.Add(this.lblNuevaEspecialidad);
            this.Controls.Add(this.btnVolverEspecialidad);
            this.Controls.Add(this.btnGrabarEspecialidad);
            this.Controls.Add(this.txtEspecialidadNueva);
            this.MaximumSize = new System.Drawing.Size(256, 223);
            this.MinimumSize = new System.Drawing.Size(256, 223);
            this.Name = "frmAgregarEspecialidadMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Especialidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEspecialidadNueva;
        private System.Windows.Forms.Button btnGrabarEspecialidad;
        private System.Windows.Forms.Button btnVolverEspecialidad;
        private System.Windows.Forms.Label lblNuevaEspecialidad;
    }
}