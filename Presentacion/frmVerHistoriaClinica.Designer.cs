namespace Presentacion
{
    partial class frmVerHistoriaClinica
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
            this.dgvVerHistoriasClinicas = new System.Windows.Forms.DataGridView();
            this.lblDatosPaciente = new System.Windows.Forms.Label();
            this.btnCrearHC = new System.Windows.Forms.Button();
            this.btnEditarHC = new System.Windows.Forms.Button();
            this.btnEliminarHC = new System.Windows.Forms.Button();
            this.btnVerHC = new System.Windows.Forms.Button();
            this.btnVolverHC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerHistoriasClinicas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerHistoriasClinicas
            // 
            this.dgvVerHistoriasClinicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerHistoriasClinicas.Location = new System.Drawing.Point(12, 25);
            this.dgvVerHistoriasClinicas.Name = "dgvVerHistoriasClinicas";
            this.dgvVerHistoriasClinicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerHistoriasClinicas.Size = new System.Drawing.Size(760, 393);
            this.dgvVerHistoriasClinicas.TabIndex = 0;
            // 
            // lblDatosPaciente
            // 
            this.lblDatosPaciente.AutoSize = true;
            this.lblDatosPaciente.Location = new System.Drawing.Point(12, 9);
            this.lblDatosPaciente.Name = "lblDatosPaciente";
            this.lblDatosPaciente.Size = new System.Drawing.Size(219, 13);
            this.lblDatosPaciente.TabIndex = 1;
            this.lblDatosPaciente.Text = "Apellido, Nombre, DNI, Fecha de Nacimiento";
            this.lblDatosPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrearHC
            // 
            this.btnCrearHC.Location = new System.Drawing.Point(12, 442);
            this.btnCrearHC.Name = "btnCrearHC";
            this.btnCrearHC.Size = new System.Drawing.Size(132, 44);
            this.btnCrearHC.TabIndex = 2;
            this.btnCrearHC.Text = "Crear HC";
            this.btnCrearHC.UseVisualStyleBackColor = true;
            this.btnCrearHC.Click += new System.EventHandler(this.btnCrearHC_Click);
            // 
            // btnEditarHC
            // 
            this.btnEditarHC.Location = new System.Drawing.Point(150, 442);
            this.btnEditarHC.Name = "btnEditarHC";
            this.btnEditarHC.Size = new System.Drawing.Size(132, 44);
            this.btnEditarHC.TabIndex = 3;
            this.btnEditarHC.Text = "Editar HC";
            this.btnEditarHC.UseVisualStyleBackColor = true;
            this.btnEditarHC.Click += new System.EventHandler(this.btnEditarHC_Click);
            // 
            // btnEliminarHC
            // 
            this.btnEliminarHC.Location = new System.Drawing.Point(288, 442);
            this.btnEliminarHC.Name = "btnEliminarHC";
            this.btnEliminarHC.Size = new System.Drawing.Size(132, 44);
            this.btnEliminarHC.TabIndex = 4;
            this.btnEliminarHC.Text = "Eliminar HC";
            this.btnEliminarHC.UseVisualStyleBackColor = true;
            this.btnEliminarHC.Click += new System.EventHandler(this.btnEliminarHC_Click);
            // 
            // btnVerHC
            // 
            this.btnVerHC.Location = new System.Drawing.Point(466, 442);
            this.btnVerHC.Name = "btnVerHC";
            this.btnVerHC.Size = new System.Drawing.Size(132, 44);
            this.btnVerHC.TabIndex = 5;
            this.btnVerHC.Text = "Ver Evoluciones";
            this.btnVerHC.UseVisualStyleBackColor = true;
            this.btnVerHC.Click += new System.EventHandler(this.btnVerHC_Click);
            // 
            // btnVolverHC
            // 
            this.btnVolverHC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolverHC.Location = new System.Drawing.Point(640, 442);
            this.btnVolverHC.Name = "btnVolverHC";
            this.btnVolverHC.Size = new System.Drawing.Size(132, 44);
            this.btnVolverHC.TabIndex = 6;
            this.btnVolverHC.Text = "Volver";
            this.btnVolverHC.UseVisualStyleBackColor = true;
            this.btnVolverHC.Click += new System.EventHandler(this.btnVolverHC_Click);
            // 
            // frmVerHistoriaClinica
            // 
            this.AcceptButton = this.btnVerHC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolverHC;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnVolverHC);
            this.Controls.Add(this.btnVerHC);
            this.Controls.Add(this.btnEliminarHC);
            this.Controls.Add(this.btnEditarHC);
            this.Controls.Add(this.btnCrearHC);
            this.Controls.Add(this.lblDatosPaciente);
            this.Controls.Add(this.dgvVerHistoriasClinicas);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmVerHistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historias Clinicas";
            this.Load += new System.EventHandler(this.frmVerHistoriaClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerHistoriasClinicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerHistoriasClinicas;
        private System.Windows.Forms.Label lblDatosPaciente;
        private System.Windows.Forms.Button btnCrearHC;
        private System.Windows.Forms.Button btnEditarHC;
        private System.Windows.Forms.Button btnEliminarHC;
        private System.Windows.Forms.Button btnVerHC;
        private System.Windows.Forms.Button btnVolverHC;
    }
}