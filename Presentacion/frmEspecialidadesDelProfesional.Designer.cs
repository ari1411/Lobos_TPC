namespace Presentacion
{
    partial class frmEspecialidadesDelProfesional
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
            this.dgvEspecialidadesProf = new System.Windows.Forms.DataGridView();
            this.btnAgregarEspecialidad = new System.Windows.Forms.Button();
            this.btnEditarEspecialidad = new System.Windows.Forms.Button();
            this.btnEliminarEspecialidad = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesProf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEspecialidadesProf
            // 
            this.dgvEspecialidadesProf.AllowUserToAddRows = false;
            this.dgvEspecialidadesProf.AllowUserToDeleteRows = false;
            this.dgvEspecialidadesProf.AllowUserToOrderColumns = true;
            this.dgvEspecialidadesProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidadesProf.Location = new System.Drawing.Point(12, 40);
            this.dgvEspecialidadesProf.MultiSelect = false;
            this.dgvEspecialidadesProf.Name = "dgvEspecialidadesProf";
            this.dgvEspecialidadesProf.ReadOnly = true;
            this.dgvEspecialidadesProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidadesProf.Size = new System.Drawing.Size(296, 256);
            this.dgvEspecialidadesProf.TabIndex = 0;
            // 
            // btnAgregarEspecialidad
            // 
            this.btnAgregarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecialidad.Location = new System.Drawing.Point(12, 302);
            this.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            this.btnAgregarEspecialidad.Size = new System.Drawing.Size(41, 41);
            this.btnAgregarEspecialidad.TabIndex = 1;
            this.btnAgregarEspecialidad.Text = "+";
            this.btnAgregarEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEspecialidad.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidad.Click += new System.EventHandler(this.btnAgregarEspecialidad_Click);
            // 
            // btnEditarEspecialidad
            // 
            this.btnEditarEspecialidad.Location = new System.Drawing.Point(59, 302);
            this.btnEditarEspecialidad.Name = "btnEditarEspecialidad";
            this.btnEditarEspecialidad.Size = new System.Drawing.Size(41, 41);
            this.btnEditarEspecialidad.TabIndex = 2;
            this.btnEditarEspecialidad.Text = "Modif";
            this.btnEditarEspecialidad.UseVisualStyleBackColor = true;
            this.btnEditarEspecialidad.Click += new System.EventHandler(this.btnEditarEspecialidad_Click);
            // 
            // btnEliminarEspecialidad
            // 
            this.btnEliminarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEspecialidad.Location = new System.Drawing.Point(106, 302);
            this.btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            this.btnEliminarEspecialidad.Size = new System.Drawing.Size(41, 41);
            this.btnEliminarEspecialidad.TabIndex = 3;
            this.btnEliminarEspecialidad.Text = "-";
            this.btnEliminarEspecialidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarEspecialidad.UseVisualStyleBackColor = true;
            this.btnEliminarEspecialidad.Click += new System.EventHandler(this.btnEliminarEspecialidad_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(226, 302);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(82, 41);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmEspecialidadesDelProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 355);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarEspecialidad);
            this.Controls.Add(this.btnEditarEspecialidad);
            this.Controls.Add(this.btnAgregarEspecialidad);
            this.Controls.Add(this.dgvEspecialidadesProf);
            this.MaximumSize = new System.Drawing.Size(336, 393);
            this.MinimumSize = new System.Drawing.Size(336, 393);
            this.Name = "frmEspecialidadesDelProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Especialidades del Profesional";
            this.Load += new System.EventHandler(this.frmEspecialidadesDelProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesProf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEspecialidadesProf;
        private System.Windows.Forms.Button btnAgregarEspecialidad;
        private System.Windows.Forms.Button btnEditarEspecialidad;
        private System.Windows.Forms.Button btnEliminarEspecialidad;
        private System.Windows.Forms.Button btnVolver;
    }
}