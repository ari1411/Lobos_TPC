namespace Presentacion
{
    partial class frmAsignarTurno
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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.lblApellidoNombre = new System.Windows.Forms.Label();
            this.grbModoSeleccion = new System.Windows.Forms.GroupBox();
            this.cboEspecialidades = new System.Windows.Forms.ComboBox();
            this.vWESPECIALIDADESMEDICASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet20 = new Presentacion.LOBOS_DBDataSet20();
            this.rdbEspecialidad = new System.Windows.Forms.RadioButton();
            this.cboProfesionales = new System.Windows.Forms.ComboBox();
            this.vWPROFESIONALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet19 = new Presentacion.LOBOS_DBDataSet19();
            this.rdbProfesional = new System.Windows.Forms.RadioButton();
            this.vW_PROFESIONALESTableAdapter = new Presentacion.LOBOS_DBDataSet19TableAdapters.VW_PROFESIONALESTableAdapter();
            this.vW_ESPECIALIDADES_MEDICASTableAdapter = new Presentacion.LOBOS_DBDataSet20TableAdapters.VW_ESPECIALIDADES_MEDICASTableAdapter();
            this.btnBuscarPte = new System.Windows.Forms.Button();
            this.dtpFechaTurnoIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechaTurno = new System.Windows.Forms.Label();
            this.btnBuscarTurnos = new System.Windows.Forms.Button();
            this.dgvTurnosDisponibles = new System.Windows.Forms.DataGridView();
            this.dtpFechaTurnoFin = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblHC = new System.Windows.Forms.Label();
            this.dgvHistoriasClinicas = new System.Windows.Forms.DataGridView();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.grbModoSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWESPECIALIDADESMEDICASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPROFESIONALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(73, 24);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(191, 20);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(24, 25);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 20;
            this.lblDNI.Text = "DNI:";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Location = new System.Drawing.Point(125, 50);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.ReadOnly = true;
            this.txtApellidoNombre.Size = new System.Drawing.Size(238, 20);
            this.txtApellidoNombre.TabIndex = 20;
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.AutoSize = true;
            this.lblApellidoNombre.Location = new System.Drawing.Point(24, 53);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(95, 13);
            this.lblApellidoNombre.TabIndex = 20;
            this.lblApellidoNombre.Text = "Apellido y Nombre:";
            // 
            // grbModoSeleccion
            // 
            this.grbModoSeleccion.Controls.Add(this.cboEspecialidades);
            this.grbModoSeleccion.Controls.Add(this.rdbEspecialidad);
            this.grbModoSeleccion.Controls.Add(this.cboProfesionales);
            this.grbModoSeleccion.Controls.Add(this.rdbProfesional);
            this.grbModoSeleccion.Location = new System.Drawing.Point(409, 20);
            this.grbModoSeleccion.Name = "grbModoSeleccion";
            this.grbModoSeleccion.Size = new System.Drawing.Size(336, 71);
            this.grbModoSeleccion.TabIndex = 2;
            this.grbModoSeleccion.TabStop = false;
            this.grbModoSeleccion.Text = "Seleccione el modo de busqueda";
            // 
            // cboEspecialidades
            // 
            this.cboEspecialidades.DataSource = this.vWESPECIALIDADESMEDICASBindingSource;
            this.cboEspecialidades.DisplayMember = "Especialidad";
            this.cboEspecialidades.FormattingEnabled = true;
            this.cboEspecialidades.Location = new System.Drawing.Point(98, 43);
            this.cboEspecialidades.Name = "cboEspecialidades";
            this.cboEspecialidades.Size = new System.Drawing.Size(223, 21);
            this.cboEspecialidades.TabIndex = 6;
            this.cboEspecialidades.ValueMember = "IdEspecialidad";
            this.cboEspecialidades.Visible = false;
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
            // rdbEspecialidad
            // 
            this.rdbEspecialidad.AutoSize = true;
            this.rdbEspecialidad.Location = new System.Drawing.Point(7, 44);
            this.rdbEspecialidad.Name = "rdbEspecialidad";
            this.rdbEspecialidad.Size = new System.Drawing.Size(85, 17);
            this.rdbEspecialidad.TabIndex = 5;
            this.rdbEspecialidad.TabStop = true;
            this.rdbEspecialidad.Text = "Especialidad";
            this.rdbEspecialidad.UseVisualStyleBackColor = true;
            this.rdbEspecialidad.CheckedChanged += new System.EventHandler(this.rdbEspecialidad_CheckedChanged);
            // 
            // cboProfesionales
            // 
            this.cboProfesionales.DataSource = this.vWPROFESIONALESBindingSource;
            this.cboProfesionales.DisplayMember = "Apellido y Nombre";
            this.cboProfesionales.FormattingEnabled = true;
            this.cboProfesionales.Location = new System.Drawing.Point(98, 19);
            this.cboProfesionales.Name = "cboProfesionales";
            this.cboProfesionales.Size = new System.Drawing.Size(223, 21);
            this.cboProfesionales.TabIndex = 4;
            this.cboProfesionales.ValueMember = "IdProfesional";
            this.cboProfesionales.Visible = false;
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
            // rdbProfesional
            // 
            this.rdbProfesional.AutoSize = true;
            this.rdbProfesional.Location = new System.Drawing.Point(7, 20);
            this.rdbProfesional.Name = "rdbProfesional";
            this.rdbProfesional.Size = new System.Drawing.Size(77, 17);
            this.rdbProfesional.TabIndex = 3;
            this.rdbProfesional.TabStop = true;
            this.rdbProfesional.Text = "Profesional";
            this.rdbProfesional.UseVisualStyleBackColor = true;
            this.rdbProfesional.CheckedChanged += new System.EventHandler(this.rdbProfesional_CheckedChanged);
            // 
            // vW_PROFESIONALESTableAdapter
            // 
            this.vW_PROFESIONALESTableAdapter.ClearBeforeFill = true;
            // 
            // vW_ESPECIALIDADES_MEDICASTableAdapter
            // 
            this.vW_ESPECIALIDADES_MEDICASTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscarPte
            // 
            this.btnBuscarPte.Location = new System.Drawing.Point(288, 20);
            this.btnBuscarPte.Name = "btnBuscarPte";
            this.btnBuscarPte.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPte.TabIndex = 1;
            this.btnBuscarPte.Text = "Buscar";
            this.btnBuscarPte.UseVisualStyleBackColor = true;
            this.btnBuscarPte.Click += new System.EventHandler(this.btnBuscarPte_Click);
            // 
            // dtpFechaTurnoIni
            // 
            this.dtpFechaTurnoIni.Location = new System.Drawing.Point(507, 125);
            this.dtpFechaTurnoIni.Name = "dtpFechaTurnoIni";
            this.dtpFechaTurnoIni.Size = new System.Drawing.Size(238, 20);
            this.dtpFechaTurnoIni.TabIndex = 7;
            this.dtpFechaTurnoIni.ValueChanged += new System.EventHandler(this.dtpFechaTurnoIni_ValueChanged);
            // 
            // lblFechaTurno
            // 
            this.lblFechaTurno.AutoSize = true;
            this.lblFechaTurno.Location = new System.Drawing.Point(406, 115);
            this.lblFechaTurno.Name = "lblFechaTurno";
            this.lblFechaTurno.Size = new System.Drawing.Size(84, 13);
            this.lblFechaTurno.TabIndex = 25;
            this.lblFechaTurno.Text = "Fecha del turno:";
            // 
            // btnBuscarTurnos
            // 
            this.btnBuscarTurnos.Location = new System.Drawing.Point(507, 177);
            this.btnBuscarTurnos.Name = "btnBuscarTurnos";
            this.btnBuscarTurnos.Size = new System.Drawing.Size(107, 25);
            this.btnBuscarTurnos.TabIndex = 9;
            this.btnBuscarTurnos.Text = "Buscar disponibles";
            this.btnBuscarTurnos.UseVisualStyleBackColor = true;
            this.btnBuscarTurnos.Click += new System.EventHandler(this.btnBuscarTurnos_Click);
            // 
            // dgvTurnosDisponibles
            // 
            this.dgvTurnosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosDisponibles.Location = new System.Drawing.Point(409, 208);
            this.dgvTurnosDisponibles.MultiSelect = false;
            this.dgvTurnosDisponibles.Name = "dgvTurnosDisponibles";
            this.dgvTurnosDisponibles.ReadOnly = true;
            this.dgvTurnosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnosDisponibles.Size = new System.Drawing.Size(363, 231);
            this.dgvTurnosDisponibles.TabIndex = 10;
            // 
            // dtpFechaTurnoFin
            // 
            this.dtpFechaTurnoFin.Location = new System.Drawing.Point(507, 151);
            this.dtpFechaTurnoFin.Name = "dtpFechaTurnoFin";
            this.dtpFechaTurnoFin.Size = new System.Drawing.Size(238, 20);
            this.dtpFechaTurnoFin.TabIndex = 8;
            this.dtpFechaTurnoFin.ValueChanged += new System.EventHandler(this.dtpFechaTurnoFin_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(434, 131);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 26;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(434, 157);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 27;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Location = new System.Drawing.Point(169, 463);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(133, 37);
            this.btnAsignarTurno.TabIndex = 11;
            this.btnAsignarTurno.Text = "Asignar Turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            this.btnAsignarTurno.Click += new System.EventHandler(this.btnAsignarTurno_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(507, 463);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(133, 37);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblHC
            // 
            this.lblHC.AutoSize = true;
            this.lblHC.Location = new System.Drawing.Point(24, 89);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(79, 13);
            this.lblHC.TabIndex = 28;
            this.lblHC.Text = "Historia Clinica:";
            // 
            // dgvHistoriasClinicas
            // 
            this.dgvHistoriasClinicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriasClinicas.Location = new System.Drawing.Point(27, 111);
            this.dgvHistoriasClinicas.MultiSelect = false;
            this.dgvHistoriasClinicas.Name = "dgvHistoriasClinicas";
            this.dgvHistoriasClinicas.ReadOnly = true;
            this.dgvHistoriasClinicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoriasClinicas.Size = new System.Drawing.Size(336, 240);
            this.dgvHistoriasClinicas.TabIndex = 29;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(27, 384);
            this.txtObservaciones.MaxLength = 50;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(336, 55);
            this.txtObservaciones.TabIndex = 30;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(24, 368);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 31;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // frmAsignarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.dgvHistoriasClinicas);
            this.Controls.Add(this.lblHC);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAsignarTurno);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpFechaTurnoFin);
            this.Controls.Add(this.dgvTurnosDisponibles);
            this.Controls.Add(this.btnBuscarTurnos);
            this.Controls.Add(this.lblFechaTurno);
            this.Controls.Add(this.dtpFechaTurnoIni);
            this.Controls.Add(this.btnBuscarPte);
            this.Controls.Add(this.grbModoSeleccion);
            this.Controls.Add(this.lblApellidoNombre);
            this.Controls.Add(this.txtApellidoNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmAsignarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAsignarTurno";
            this.Load += new System.EventHandler(this.frmAsignarTurno_Load);
            this.grbModoSeleccion.ResumeLayout(false);
            this.grbModoSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWESPECIALIDADESMEDICASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWPROFESIONALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.Label lblApellidoNombre;
        private System.Windows.Forms.GroupBox grbModoSeleccion;
        private System.Windows.Forms.RadioButton rdbEspecialidad;
        private System.Windows.Forms.RadioButton rdbProfesional;
        private LOBOS_DBDataSet19 lOBOS_DBDataSet19;
        private System.Windows.Forms.BindingSource vWPROFESIONALESBindingSource;
        private LOBOS_DBDataSet19TableAdapters.VW_PROFESIONALESTableAdapter vW_PROFESIONALESTableAdapter;
        private LOBOS_DBDataSet20 lOBOS_DBDataSet20;
        private System.Windows.Forms.BindingSource vWESPECIALIDADESMEDICASBindingSource;
        private LOBOS_DBDataSet20TableAdapters.VW_ESPECIALIDADES_MEDICASTableAdapter vW_ESPECIALIDADES_MEDICASTableAdapter;
        private System.Windows.Forms.ComboBox cboEspecialidades;
        private System.Windows.Forms.ComboBox cboProfesionales;
        private System.Windows.Forms.Button btnBuscarPte;
        private System.Windows.Forms.DateTimePicker dtpFechaTurnoIni;
        private System.Windows.Forms.Label lblFechaTurno;
        private System.Windows.Forms.Button btnBuscarTurnos;
        private System.Windows.Forms.DataGridView dgvTurnosDisponibles;
        private System.Windows.Forms.DateTimePicker dtpFechaTurnoFin;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblHC;
        private System.Windows.Forms.DataGridView dgvHistoriasClinicas;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
    }
}