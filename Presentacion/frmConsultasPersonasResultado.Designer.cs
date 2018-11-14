namespace Presentacion
{
    partial class frmConsultasPersonasResultado
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
            this.btnEliminarPers = new System.Windows.Forms.Button();
            this.btnAñadirFuncion = new System.Windows.Forms.Button();
            this.btnEditarPers = new System.Windows.Forms.Button();
            this.btnVolverPers = new System.Windows.Forms.Button();
            this.btnActualizarPers = new System.Windows.Forms.Button();
            this.dgvConsultasPersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarPers
            // 
            this.btnEliminarPers.Location = new System.Drawing.Point(173, 456);
            this.btnEliminarPers.Name = "btnEliminarPers";
            this.btnEliminarPers.Size = new System.Drawing.Size(132, 44);
            this.btnEliminarPers.TabIndex = 18;
            this.btnEliminarPers.Text = "Eliminar Persona";
            this.btnEliminarPers.UseVisualStyleBackColor = true;
            this.btnEliminarPers.Click += new System.EventHandler(this.btnEliminarPers_Click);
            // 
            // btnAñadirFuncion
            // 
            this.btnAñadirFuncion.Location = new System.Drawing.Point(341, 456);
            this.btnAñadirFuncion.Name = "btnAñadirFuncion";
            this.btnAñadirFuncion.Size = new System.Drawing.Size(132, 44);
            this.btnAñadirFuncion.TabIndex = 17;
            this.btnAñadirFuncion.Text = "Añadir Funcion";
            this.btnAñadirFuncion.UseVisualStyleBackColor = true;
            this.btnAñadirFuncion.Click += new System.EventHandler(this.btnAñadirFuncion_Click);
            // 
            // btnEditarPers
            // 
            this.btnEditarPers.Location = new System.Drawing.Point(12, 456);
            this.btnEditarPers.Name = "btnEditarPers";
            this.btnEditarPers.Size = new System.Drawing.Size(132, 44);
            this.btnEditarPers.TabIndex = 16;
            this.btnEditarPers.Text = "Editar Persona";
            this.btnEditarPers.UseVisualStyleBackColor = true;
            this.btnEditarPers.Click += new System.EventHandler(this.btnEditarPers_Click);
            // 
            // btnVolverPers
            // 
            this.btnVolverPers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolverPers.Location = new System.Drawing.Point(640, 456);
            this.btnVolverPers.Name = "btnVolverPers";
            this.btnVolverPers.Size = new System.Drawing.Size(132, 44);
            this.btnVolverPers.TabIndex = 15;
            this.btnVolverPers.Text = "Volver";
            this.btnVolverPers.UseVisualStyleBackColor = true;
            this.btnVolverPers.Click += new System.EventHandler(this.btnVolverPers_Click);
            // 
            // btnActualizarPers
            // 
            this.btnActualizarPers.Location = new System.Drawing.Point(12, 12);
            this.btnActualizarPers.Name = "btnActualizarPers";
            this.btnActualizarPers.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPers.TabIndex = 14;
            this.btnActualizarPers.Text = "Actualizar";
            this.btnActualizarPers.UseVisualStyleBackColor = true;
            // 
            // dgvConsultasPersonas
            // 
            this.dgvConsultasPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasPersonas.Location = new System.Drawing.Point(12, 41);
            this.dgvConsultasPersonas.MultiSelect = false;
            this.dgvConsultasPersonas.Name = "dgvConsultasPersonas";
            this.dgvConsultasPersonas.ReadOnly = true;
            this.dgvConsultasPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultasPersonas.Size = new System.Drawing.Size(760, 395);
            this.dgvConsultasPersonas.TabIndex = 13;
            // 
            // frmConsultasPersonasResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnEliminarPers);
            this.Controls.Add(this.btnAñadirFuncion);
            this.Controls.Add(this.btnEditarPers);
            this.Controls.Add(this.btnVolverPers);
            this.Controls.Add(this.btnActualizarPers);
            this.Controls.Add(this.dgvConsultasPersonas);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmConsultasPersonasResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.frmConsultasPersonasResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarPers;
        private System.Windows.Forms.Button btnAñadirFuncion;
        private System.Windows.Forms.Button btnEditarPers;
        private System.Windows.Forms.Button btnVolverPers;
        private System.Windows.Forms.Button btnActualizarPers;
        private System.Windows.Forms.DataGridView dgvConsultasPersonas;
    }
}