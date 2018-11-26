namespace Presentacion
{
    partial class frmAdmision
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
            this.dgvTurnosAsignados = new System.Windows.Forms.DataGridView();
            this.btnAdmisionar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.btnReprogramar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnosAsignados
            // 
            this.dgvTurnosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosAsignados.Location = new System.Drawing.Point(12, 12);
            this.dgvTurnosAsignados.MultiSelect = false;
            this.dgvTurnosAsignados.Name = "dgvTurnosAsignados";
            this.dgvTurnosAsignados.ReadOnly = true;
            this.dgvTurnosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnosAsignados.Size = new System.Drawing.Size(662, 488);
            this.dgvTurnosAsignados.TabIndex = 0;
            // 
            // btnAdmisionar
            // 
            this.btnAdmisionar.Location = new System.Drawing.Point(680, 43);
            this.btnAdmisionar.Name = "btnAdmisionar";
            this.btnAdmisionar.Size = new System.Drawing.Size(92, 44);
            this.btnAdmisionar.TabIndex = 1;
            this.btnAdmisionar.Text = "Admisionar";
            this.btnAdmisionar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(680, 432);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 44);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(680, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 44);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLiberar
            // 
            this.btnLiberar.Location = new System.Drawing.Point(680, 143);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(92, 44);
            this.btnLiberar.TabIndex = 4;
            this.btnLiberar.Text = "Liberar";
            this.btnLiberar.UseVisualStyleBackColor = true;
            // 
            // btnReprogramar
            // 
            this.btnReprogramar.Location = new System.Drawing.Point(680, 193);
            this.btnReprogramar.Name = "btnReprogramar";
            this.btnReprogramar.Size = new System.Drawing.Size(92, 44);
            this.btnReprogramar.TabIndex = 5;
            this.btnReprogramar.Text = "Reprogramar";
            this.btnReprogramar.UseVisualStyleBackColor = true;
            // 
            // frmAdmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnReprogramar);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAdmisionar);
            this.Controls.Add(this.dgvTurnosAsignados);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmAdmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAdmision";
            this.Load += new System.EventHandler(this.frmAdmision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosAsignados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurnosAsignados;
        private System.Windows.Forms.Button btnAdmisionar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.Button btnReprogramar;
    }
}