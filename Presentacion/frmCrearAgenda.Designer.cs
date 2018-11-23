namespace Presentacion
{
    partial class frmCrearAgenda
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
            this.components = new System.ComponentModel.Container();
            this.mtbHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtbHoraHasta = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraDesde = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.cboProfesionales = new System.Windows.Forms.ComboBox();
            this.lOBOS_DBDataSet19 = new Presentacion.LOBOS_DBDataSet19();
            this.vWPROFESIONALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_PROFESIONALESTableAdapter = new Presentacion.LOBOS_DBDataSet19TableAdapters.VW_PROFESIONALESTableAdapter();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.btnGenerarTurnos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPROFESIONALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbHoraInicio
            // 
            this.mtbHoraInicio.Location = new System.Drawing.Point(124, 54);
            this.mtbHoraInicio.Mask = "00/00/0000 00:00";
            this.mtbHoraInicio.Name = "mtbHoraInicio";
            this.mtbHoraInicio.Size = new System.Drawing.Size(130, 20);
            this.mtbHoraInicio.TabIndex = 1;
            this.mtbHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHoraHasta
            // 
            this.mtbHoraHasta.Location = new System.Drawing.Point(124, 100);
            this.mtbHoraHasta.Mask = "00/00/0000 00:00";
            this.mtbHoraHasta.Name = "mtbHoraHasta";
            this.mtbHoraHasta.Size = new System.Drawing.Size(130, 20);
            this.mtbHoraHasta.TabIndex = 2;
            this.mtbHoraHasta.ValidatingType = typeof(System.DateTime);
            // 
            // lblHoraDesde
            // 
            this.lblHoraDesde.AutoSize = true;
            this.lblHoraDesde.Location = new System.Drawing.Point(77, 57);
            this.lblHoraDesde.Name = "lblHoraDesde";
            this.lblHoraDesde.Size = new System.Drawing.Size(41, 13);
            this.lblHoraDesde.TabIndex = 4;
            this.lblHoraDesde.Text = "Desde:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(77, 103);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(38, 13);
            this.lblHoraFin.TabIndex = 5;
            this.lblHoraFin.Text = "Hasta:";
            // 
            // cboProfesionales
            // 
            this.cboProfesionales.DataSource = this.vWPROFESIONALESBindingSource;
            this.cboProfesionales.DisplayMember = "Apellido y Nombre";
            this.cboProfesionales.FormattingEnabled = true;
            this.cboProfesionales.Location = new System.Drawing.Point(110, 168);
            this.cboProfesionales.Name = "cboProfesionales";
            this.cboProfesionales.Size = new System.Drawing.Size(214, 21);
            this.cboProfesionales.TabIndex = 6;
            this.cboProfesionales.ValueMember = "IdProfesional";
            this.cboProfesionales.SelectedIndexChanged += new System.EventHandler(this.cboProfesionales_SelectedIndexChanged);
            // 
            // lOBOS_DBDataSet19
            // 
            this.lOBOS_DBDataSet19.DataSetName = "LOBOS_DBDataSet19";
            this.lOBOS_DBDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWPROFESIONALESBindingSource
            // 
            this.vWPROFESIONALESBindingSource.DataMember = "VW_PROFESIONALES";
            this.vWPROFESIONALESBindingSource.DataSource = this.lOBOS_DBDataSet19;
            // 
            // vW_PROFESIONALESTableAdapter
            // 
            this.vW_PROFESIONALESTableAdapter.ClearBeforeFill = true;
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(31, 171);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(62, 13);
            this.lblProfesional.TabIndex = 7;
            this.lblProfesional.Text = "Profesional:";
            this.lblProfesional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(31, 226);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 9;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Location = new System.Drawing.Point(124, 207);
            this.dgvEspecialidades.MultiSelect = false;
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.Size = new System.Drawing.Size(200, 90);
            this.dgvEspecialidades.TabIndex = 10;
            // 
            // btnGenerarTurnos
            // 
            this.btnGenerarTurnos.Location = new System.Drawing.Point(56, 338);
            this.btnGenerarTurnos.Name = "btnGenerarTurnos";
            this.btnGenerarTurnos.Size = new System.Drawing.Size(109, 49);
            this.btnGenerarTurnos.TabIndex = 11;
            this.btnGenerarTurnos.Text = "Generar Turnos";
            this.btnGenerarTurnos.UseVisualStyleBackColor = true;
            this.btnGenerarTurnos.Click += new System.EventHandler(this.btnGenerarTurnos_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(233, 338);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 49);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCrearAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 399);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGenerarTurnos);
            this.Controls.Add(this.dgvEspecialidades);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.cboProfesionales);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblHoraDesde);
            this.Controls.Add(this.mtbHoraHasta);
            this.Controls.Add(this.mtbHoraInicio);
            this.MaximumSize = new System.Drawing.Size(400, 437);
            this.MinimumSize = new System.Drawing.Size(400, 437);
            this.Name = "frmCrearAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Agenda";
            this.Load += new System.EventHandler(this.frmCrearAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPROFESIONALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtbHoraInicio;
        private System.Windows.Forms.MaskedTextBox mtbHoraHasta;
        private System.Windows.Forms.Label lblHoraDesde;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.ComboBox cboProfesionales;
        private LOBOS_DBDataSet19 lOBOS_DBDataSet19;
        private System.Windows.Forms.BindingSource vWPROFESIONALESBindingSource;
        private LOBOS_DBDataSet19TableAdapters.VW_PROFESIONALESTableAdapter vW_PROFESIONALESTableAdapter;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnGenerarTurnos;
        private System.Windows.Forms.Button btnVolver;
    }
}