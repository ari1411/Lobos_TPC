namespace Presentacion
{
    partial class frmModificarEspecialidadProfesional
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
            this.lblDniApellidoNombre = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.lOBOS_DBDataSet14 = new Presentacion.LOBOS_DBDataSet14();
            this.vWESPECIALIDADESMEDICASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_ESPECIALIDADES_MEDICASTableAdapter = new Presentacion.LOBOS_DBDataSet14TableAdapters.VW_ESPECIALIDADES_MEDICASTableAdapter();
            this.txtMatriculaNac = new System.Windows.Forms.TextBox();
            this.txtMatriculaProv = new System.Windows.Forms.TextBox();
            this.dtpVtoMatNac = new System.Windows.Forms.DateTimePicker();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblMatriculaNac = new System.Windows.Forms.Label();
            this.lblVtoMatNac = new System.Windows.Forms.Label();
            this.lblMatriculaProv = new System.Windows.Forms.Label();
            this.dtpVtoMatProv = new System.Windows.Forms.DateTimePicker();
            this.lblVtoMatProv = new System.Windows.Forms.Label();
            this.btnGrabarEspecialidadMed = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWESPECIALIDADESMEDICASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDniApellidoNombre
            // 
            this.lblDniApellidoNombre.AutoSize = true;
            this.lblDniApellidoNombre.Location = new System.Drawing.Point(12, 9);
            this.lblDniApellidoNombre.Name = "lblDniApellidoNombre";
            this.lblDniApellidoNombre.Size = new System.Drawing.Size(172, 13);
            this.lblDniApellidoNombre.TabIndex = 0;
            this.lblDniApellidoNombre.Text = "DNI, Apellido y Nombre Profesional";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DataSource = this.vWESPECIALIDADESMEDICASBindingSource;
            this.cboEspecialidad.DisplayMember = "Especialidad";
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(88, 66);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(220, 21);
            this.cboEspecialidad.TabIndex = 1;
            this.cboEspecialidad.ValueMember = "IdEspecialidad";
            // 
            // lOBOS_DBDataSet14
            // 
            this.lOBOS_DBDataSet14.DataSetName = "LOBOS_DBDataSet14";
            this.lOBOS_DBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWESPECIALIDADESMEDICASBindingSource
            // 
            this.vWESPECIALIDADESMEDICASBindingSource.DataMember = "VW_ESPECIALIDADES_MEDICAS";
            this.vWESPECIALIDADESMEDICASBindingSource.DataSource = this.lOBOS_DBDataSet14;
            // 
            // vW_ESPECIALIDADES_MEDICASTableAdapter
            // 
            this.vW_ESPECIALIDADES_MEDICASTableAdapter.ClearBeforeFill = true;
            // 
            // txtMatriculaNac
            // 
            this.txtMatriculaNac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMatriculaNac.Location = new System.Drawing.Point(116, 128);
            this.txtMatriculaNac.MaxLength = 20;
            this.txtMatriculaNac.Name = "txtMatriculaNac";
            this.txtMatriculaNac.Size = new System.Drawing.Size(192, 20);
            this.txtMatriculaNac.TabIndex = 2;
            // 
            // txtMatriculaProv
            // 
            this.txtMatriculaProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMatriculaProv.Location = new System.Drawing.Point(116, 213);
            this.txtMatriculaProv.MaxLength = 20;
            this.txtMatriculaProv.Name = "txtMatriculaProv";
            this.txtMatriculaProv.Size = new System.Drawing.Size(192, 20);
            this.txtMatriculaProv.TabIndex = 4;
            // 
            // dtpVtoMatNac
            // 
            this.dtpVtoMatNac.Location = new System.Drawing.Point(97, 154);
            this.dtpVtoMatNac.Name = "dtpVtoMatNac";
            this.dtpVtoMatNac.Size = new System.Drawing.Size(211, 20);
            this.dtpVtoMatNac.TabIndex = 3;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(12, 69);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 5;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblMatriculaNac
            // 
            this.lblMatriculaNac.AutoSize = true;
            this.lblMatriculaNac.Location = new System.Drawing.Point(12, 131);
            this.lblMatriculaNac.Name = "lblMatriculaNac";
            this.lblMatriculaNac.Size = new System.Drawing.Size(98, 13);
            this.lblMatriculaNac.TabIndex = 6;
            this.lblMatriculaNac.Text = "Matricula Nacional:";
            // 
            // lblVtoMatNac
            // 
            this.lblVtoMatNac.AutoSize = true;
            this.lblVtoMatNac.Location = new System.Drawing.Point(12, 160);
            this.lblVtoMatNac.Name = "lblVtoMatNac";
            this.lblVtoMatNac.Size = new System.Drawing.Size(79, 13);
            this.lblVtoMatNac.TabIndex = 7;
            this.lblVtoMatNac.Text = "Vto. Mat. Nac.:";
            // 
            // lblMatriculaProv
            // 
            this.lblMatriculaProv.AutoSize = true;
            this.lblMatriculaProv.Location = new System.Drawing.Point(12, 216);
            this.lblMatriculaProv.Name = "lblMatriculaProv";
            this.lblMatriculaProv.Size = new System.Drawing.Size(102, 13);
            this.lblMatriculaProv.TabIndex = 8;
            this.lblMatriculaProv.Text = "Matricula Provincial:";
            // 
            // dtpVtoMatProv
            // 
            this.dtpVtoMatProv.Location = new System.Drawing.Point(97, 239);
            this.dtpVtoMatProv.Name = "dtpVtoMatProv";
            this.dtpVtoMatProv.Size = new System.Drawing.Size(211, 20);
            this.dtpVtoMatProv.TabIndex = 9;
            // 
            // lblVtoMatProv
            // 
            this.lblVtoMatProv.AutoSize = true;
            this.lblVtoMatProv.Location = new System.Drawing.Point(12, 245);
            this.lblVtoMatProv.Name = "lblVtoMatProv";
            this.lblVtoMatProv.Size = new System.Drawing.Size(81, 13);
            this.lblVtoMatProv.TabIndex = 10;
            this.lblVtoMatProv.Text = "Vto. Mat. Prov.:";
            // 
            // btnGrabarEspecialidadMed
            // 
            this.btnGrabarEspecialidadMed.Location = new System.Drawing.Point(12, 313);
            this.btnGrabarEspecialidadMed.Name = "btnGrabarEspecialidadMed";
            this.btnGrabarEspecialidadMed.Size = new System.Drawing.Size(98, 30);
            this.btnGrabarEspecialidadMed.TabIndex = 11;
            this.btnGrabarEspecialidadMed.Text = "Grabar";
            this.btnGrabarEspecialidadMed.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(210, 313);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 30);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmModificarFuncionProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 355);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGrabarEspecialidadMed);
            this.Controls.Add(this.lblVtoMatProv);
            this.Controls.Add(this.dtpVtoMatProv);
            this.Controls.Add(this.lblMatriculaProv);
            this.Controls.Add(this.lblVtoMatNac);
            this.Controls.Add(this.lblMatriculaNac);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.dtpVtoMatNac);
            this.Controls.Add(this.txtMatriculaProv);
            this.Controls.Add(this.txtMatriculaNac);
            this.Controls.Add(this.cboEspecialidad);
            this.Controls.Add(this.lblDniApellidoNombre);
            this.MaximumSize = new System.Drawing.Size(336, 393);
            this.MinimumSize = new System.Drawing.Size(336, 393);
            this.Name = "frmModificarFuncionProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Funcion Profesional";
            this.Load += new System.EventHandler(this.frmModificarFuncionProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWESPECIALIDADESMEDICASBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDniApellidoNombre;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private LOBOS_DBDataSet14 lOBOS_DBDataSet14;
        private System.Windows.Forms.BindingSource vWESPECIALIDADESMEDICASBindingSource;
        private LOBOS_DBDataSet14TableAdapters.VW_ESPECIALIDADES_MEDICASTableAdapter vW_ESPECIALIDADES_MEDICASTableAdapter;
        private System.Windows.Forms.TextBox txtMatriculaNac;
        private System.Windows.Forms.TextBox txtMatriculaProv;
        private System.Windows.Forms.DateTimePicker dtpVtoMatNac;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblMatriculaNac;
        private System.Windows.Forms.Label lblVtoMatNac;
        private System.Windows.Forms.Label lblMatriculaProv;
        private System.Windows.Forms.DateTimePicker dtpVtoMatProv;
        private System.Windows.Forms.Label lblVtoMatProv;
        private System.Windows.Forms.Button btnGrabarEspecialidadMed;
        private System.Windows.Forms.Button btnVolver;
    }
}