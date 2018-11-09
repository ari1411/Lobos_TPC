namespace Presentacion
{
    partial class frmConsultasPacientesResultado
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
            this.dgvConsultasPacientes = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConsultaPteVolver = new System.Windows.Forms.Button();
            this.btnEditarPte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerHC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultasPacientes
            // 
            this.dgvConsultasPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasPacientes.Location = new System.Drawing.Point(12, 41);
            this.dgvConsultasPacientes.MultiSelect = false;
            this.dgvConsultasPacientes.Name = "dgvConsultasPacientes";
            this.dgvConsultasPacientes.ReadOnly = true;
            this.dgvConsultasPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultasPacientes.Size = new System.Drawing.Size(760, 395);
            this.dgvConsultasPacientes.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnConsultaPteVolver
            // 
            this.btnConsultaPteVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConsultaPteVolver.Location = new System.Drawing.Point(640, 449);
            this.btnConsultaPteVolver.Name = "btnConsultaPteVolver";
            this.btnConsultaPteVolver.Size = new System.Drawing.Size(132, 44);
            this.btnConsultaPteVolver.TabIndex = 8;
            this.btnConsultaPteVolver.Text = "Volver";
            this.btnConsultaPteVolver.UseVisualStyleBackColor = true;
            this.btnConsultaPteVolver.Click += new System.EventHandler(this.btnBuscarPteVolver_Click);
            // 
            // btnEditarPte
            // 
            this.btnEditarPte.Location = new System.Drawing.Point(12, 449);
            this.btnEditarPte.Name = "btnEditarPte";
            this.btnEditarPte.Size = new System.Drawing.Size(132, 44);
            this.btnEditarPte.TabIndex = 9;
            this.btnEditarPte.Text = "Editar";
            this.btnEditarPte.UseVisualStyleBackColor = true;
            this.btnEditarPte.Click += new System.EventHandler(this.btnEditarPte_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminar.Location = new System.Drawing.Point(173, 449);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 44);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerHC
            // 
            this.btnVerHC.Location = new System.Drawing.Point(341, 449);
            this.btnVerHC.Name = "btnVerHC";
            this.btnVerHC.Size = new System.Drawing.Size(132, 44);
            this.btnVerHC.TabIndex = 11;
            this.btnVerHC.Text = "Ver HC";
            this.btnVerHC.UseVisualStyleBackColor = true;
            this.btnVerHC.Click += new System.EventHandler(this.btnVerHC_Click);
            // 
            // frmConsultasPacientesResultado
            // 
            this.AcceptButton = this.btnVerHC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnConsultaPteVolver;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnVerHC);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditarPte);
            this.Controls.Add(this.btnConsultaPteVolver);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvConsultasPacientes);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmConsultasPacientesResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.frmConsultasPacientesResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultasPacientes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnConsultaPteVolver;
        private System.Windows.Forms.Button btnEditarPte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerHC;
    }
}