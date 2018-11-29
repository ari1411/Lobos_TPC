namespace Presentacion
{
    partial class frmPerfilProfesionalAtender
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
            this.dgvPacientesAdmitidos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesAdmitidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientesAdmitidos
            // 
            this.dgvPacientesAdmitidos.AllowUserToAddRows = false;
            this.dgvPacientesAdmitidos.AllowUserToDeleteRows = false;
            this.dgvPacientesAdmitidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesAdmitidos.Location = new System.Drawing.Point(12, 74);
            this.dgvPacientesAdmitidos.MultiSelect = false;
            this.dgvPacientesAdmitidos.Name = "dgvPacientesAdmitidos";
            this.dgvPacientesAdmitidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientesAdmitidos.Size = new System.Drawing.Size(641, 345);
            this.dgvPacientesAdmitidos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(13, 45);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(659, 74);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(113, 32);
            this.btnAtender.TabIndex = 2;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(659, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(675, 459);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 41);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmPerfilProfesionalAtender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPacientesAdmitidos);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmPerfilProfesionalAtender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atender paciente";
            this.Load += new System.EventHandler(this.frmPerfilProfesionalAtender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesAdmitidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientesAdmitidos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
    }
}