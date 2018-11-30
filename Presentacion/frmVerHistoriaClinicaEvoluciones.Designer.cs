namespace Presentacion
{
    partial class frmVerHistoriaClinicaEvoluciones
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
            this.lblDatosPaciente = new System.Windows.Forms.Label();
            this.lblHC = new System.Windows.Forms.Label();
            this.dgvEvoluciones = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatosPaciente
            // 
            this.lblDatosPaciente.AutoSize = true;
            this.lblDatosPaciente.Location = new System.Drawing.Point(12, 9);
            this.lblDatosPaciente.Name = "lblDatosPaciente";
            this.lblDatosPaciente.Size = new System.Drawing.Size(219, 13);
            this.lblDatosPaciente.TabIndex = 0;
            this.lblDatosPaciente.Text = "Apellido, Nombre, DNI, Fecha de Nacimiento";
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Location = new System.Drawing.Point(451, 9);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(22, 13);
            this.lblHC.TabIndex = 1;
            this.lblHC.Text = "HC";
            // 
            // dgvEvoluciones
            // 
            this.dgvEvoluciones.AllowUserToAddRows = false;
            this.dgvEvoluciones.AllowUserToDeleteRows = false;
            this.dgvEvoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvoluciones.Location = new System.Drawing.Point(12, 25);
            this.dgvEvoluciones.MultiSelect = false;
            this.dgvEvoluciones.Name = "dgvEvoluciones";
            this.dgvEvoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvoluciones.Size = new System.Drawing.Size(760, 394);
            this.dgvEvoluciones.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(168, 441);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 42);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(500, 441);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(130, 42);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVerHistoriaClinicaEvoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvEvoluciones);
            this.Controls.Add(this.lblHC);
            this.Controls.Add(this.lblDatosPaciente);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmVerHistoriaClinicaEvoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evoluciones";
            this.Load += new System.EventHandler(this.frmVerHistoriaClinicaEvoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosPaciente;
        private System.Windows.Forms.Label lblHC;
        private System.Windows.Forms.DataGridView dgvEvoluciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
    }
}