namespace Presentacion
{
    partial class frmConsultaTurnos
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
            this.grbModoBuscar = new System.Windows.Forms.GroupBox();
            this.rdbEspecialidad = new System.Windows.Forms.RadioButton();
            this.rdbProfesional = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.cboProfesional = new System.Windows.Forms.ComboBox();
            this.vWPROFESIONALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet19 = new Presentacion.LOBOS_DBDataSet19();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.vWESPECIALIDADESMEDICASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet20 = new Presentacion.LOBOS_DBDataSet20();
            this.vW_PROFESIONALESTableAdapter = new Presentacion.LOBOS_DBDataSet19TableAdapters.VW_PROFESIONALESTableAdapter();
            this.vW_ESPECIALIDADES_MEDICASTableAdapter = new Presentacion.LOBOS_DBDataSet20TableAdapters.VW_ESPECIALIDADES_MEDICASTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grbModoBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWPROFESIONALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWESPECIALIDADESMEDICASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // grbModoBuscar
            // 
            this.grbModoBuscar.Controls.Add(this.rdbEspecialidad);
            this.grbModoBuscar.Controls.Add(this.rdbProfesional);
            this.grbModoBuscar.Controls.Add(this.rdbFecha);
            this.grbModoBuscar.Location = new System.Drawing.Point(51, 89);
            this.grbModoBuscar.Name = "grbModoBuscar";
            this.grbModoBuscar.Size = new System.Drawing.Size(200, 167);
            this.grbModoBuscar.TabIndex = 0;
            this.grbModoBuscar.TabStop = false;
            this.grbModoBuscar.Text = "Selecciona como deseas buscar:";
            // 
            // rdbEspecialidad
            // 
            this.rdbEspecialidad.AutoSize = true;
            this.rdbEspecialidad.Location = new System.Drawing.Point(7, 124);
            this.rdbEspecialidad.Name = "rdbEspecialidad";
            this.rdbEspecialidad.Size = new System.Drawing.Size(85, 17);
            this.rdbEspecialidad.TabIndex = 2;
            this.rdbEspecialidad.Text = "Especialidad";
            this.rdbEspecialidad.UseVisualStyleBackColor = true;
            this.rdbEspecialidad.CheckedChanged += new System.EventHandler(this.rdbEspecialidad_CheckedChanged);
            // 
            // rdbProfesional
            // 
            this.rdbProfesional.AutoSize = true;
            this.rdbProfesional.Location = new System.Drawing.Point(7, 79);
            this.rdbProfesional.Name = "rdbProfesional";
            this.rdbProfesional.Size = new System.Drawing.Size(77, 17);
            this.rdbProfesional.TabIndex = 1;
            this.rdbProfesional.Text = "Profesional";
            this.rdbProfesional.UseVisualStyleBackColor = true;
            this.rdbProfesional.CheckedChanged += new System.EventHandler(this.rdbProfesional_CheckedChanged);
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Checked = true;
            this.rdbFecha.Location = new System.Drawing.Point(7, 34);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(55, 17);
            this.rdbFecha.TabIndex = 0;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            this.rdbFecha.CheckedChanged += new System.EventHandler(this.rdbFecha_CheckedChanged);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(293, 125);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.lblFechaDesde.TabIndex = 1;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(293, 168);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFechaHasta.TabIndex = 2;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(360, 119);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(211, 20);
            this.dtpFechaDesde.TabIndex = 3;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(360, 164);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(211, 20);
            this.dtpFechaHasta.TabIndex = 4;
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(293, 215);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(62, 13);
            this.lblProfesional.TabIndex = 5;
            this.lblProfesional.Text = "Profesional:";
            this.lblProfesional.Visible = false;
            // 
            // cboProfesional
            // 
            this.cboProfesional.DataSource = this.vWPROFESIONALESBindingSource;
            this.cboProfesional.DisplayMember = "Apellido y Nombre";
            this.cboProfesional.FormattingEnabled = true;
            this.cboProfesional.Location = new System.Drawing.Point(360, 212);
            this.cboProfesional.Name = "cboProfesional";
            this.cboProfesional.Size = new System.Drawing.Size(200, 21);
            this.cboProfesional.TabIndex = 6;
            this.cboProfesional.ValueMember = "IdProfesional";
            this.cboProfesional.Visible = false;
            this.cboProfesional.SelectedIndexChanged += new System.EventHandler(this.cboProfesional_SelectedIndexChanged);
            // 
            // vWPROFESIONALESBindingSource
            // 
            this.vWPROFESIONALESBindingSource.DataMember = "VW_PROFESIONALES";
            this.vWPROFESIONALESBindingSource.DataSource = this.lOBOS_DBDataSet19;
            // 
            // lOBOS_DBDataSet19
            // 
            this.lOBOS_DBDataSet19.DataSetName = "LOBOS_DBDataSet19";
            this.lOBOS_DBDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(293, 215);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 7;
            this.lblEspecialidad.Text = "Especialidad:";
            this.lblEspecialidad.Visible = false;
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DataSource = this.vWESPECIALIDADESMEDICASBindingSource;
            this.cboEspecialidad.DisplayMember = "Especialidad";
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(360, 212);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(211, 21);
            this.cboEspecialidad.TabIndex = 8;
            this.cboEspecialidad.ValueMember = "IdEspecialidad";
            this.cboEspecialidad.Visible = false;
            // 
            // vWESPECIALIDADESMEDICASBindingSource
            // 
            this.vWESPECIALIDADESMEDICASBindingSource.DataMember = "VW_ESPECIALIDADES_MEDICAS";
            this.vWESPECIALIDADESMEDICASBindingSource.DataSource = this.lOBOS_DBDataSet20;
            // 
            // lOBOS_DBDataSet20
            // 
            this.lOBOS_DBDataSet20.DataSetName = "LOBOS_DBDataSet20";
            this.lOBOS_DBDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_PROFESIONALESTableAdapter
            // 
            this.vW_PROFESIONALESTableAdapter.ClearBeforeFill = true;
            // 
            // vW_ESPECIALIDADES_MEDICASTableAdapter
            // 
            this.vW_ESPECIALIDADES_MEDICASTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(296, 288);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(135, 37);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(611, 443);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 38);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmConsultaTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cboProfesional);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.grbModoBuscar);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmConsultaTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Turnos";
            this.Load += new System.EventHandler(this.frmConsultaTurnos_Load);
            this.grbModoBuscar.ResumeLayout(false);
            this.grbModoBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWPROFESIONALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWESPECIALIDADESMEDICASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbModoBuscar;
        private System.Windows.Forms.RadioButton rdbEspecialidad;
        private System.Windows.Forms.RadioButton rdbProfesional;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cboProfesional;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private LOBOS_DBDataSet19 lOBOS_DBDataSet19;
        private System.Windows.Forms.BindingSource vWPROFESIONALESBindingSource;
        private LOBOS_DBDataSet19TableAdapters.VW_PROFESIONALESTableAdapter vW_PROFESIONALESTableAdapter;
        private LOBOS_DBDataSet20 lOBOS_DBDataSet20;
        private System.Windows.Forms.BindingSource vWESPECIALIDADESMEDICASBindingSource;
        private LOBOS_DBDataSet20TableAdapters.VW_ESPECIALIDADES_MEDICASTableAdapter vW_ESPECIALIDADES_MEDICASTableAdapter;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
    }
}