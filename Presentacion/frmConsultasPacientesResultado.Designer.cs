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
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultasPacientes
            // 
            this.dgvConsultasPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasPacientes.Location = new System.Drawing.Point(12, 41);
            this.dgvConsultasPacientes.Name = "dgvConsultasPacientes";
            this.dgvConsultasPacientes.Size = new System.Drawing.Size(760, 334);
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
            // 
            // frmConsultasPacientesResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvConsultasPacientes);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmConsultasPacientesResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConsultasPacientesResultado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultasPacientes;
        private System.Windows.Forms.Button btnActualizar;
    }
}