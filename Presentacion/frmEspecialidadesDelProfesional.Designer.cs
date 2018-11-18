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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesProf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEspecialidadesProf
            // 
            this.dgvEspecialidadesProf.AllowUserToAddRows = false;
            this.dgvEspecialidadesProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidadesProf.Location = new System.Drawing.Point(12, 40);
            this.dgvEspecialidadesProf.Name = "dgvEspecialidadesProf";
            this.dgvEspecialidadesProf.ReadOnly = true;
            this.dgvEspecialidadesProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidadesProf.Size = new System.Drawing.Size(296, 256);
            this.dgvEspecialidadesProf.TabIndex = 0;
            // 
            // frmEspecialidadesDelProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 355);
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
    }
}