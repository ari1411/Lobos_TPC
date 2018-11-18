namespace Presentacion
{
    partial class frmModificarAdministrativo
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
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.lOBOS_DBDataSet12 = new Presentacion.LOBOS_DBDataSet12();
            this.lOBOSDBDataSet12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet13 = new Presentacion.LOBOS_DBDataSet13();
            this.vWCARGOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_CARGOSTableAdapter = new Presentacion.LOBOS_DBDataSet13TableAdapters.VW_CARGOSTableAdapter();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDniApellidoNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOSDBDataSet12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCARGOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCargo
            // 
            this.cboCargo.DataSource = this.vWCARGOSBindingSource;
            this.cboCargo.DisplayMember = "Cargo";
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(99, 62);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(121, 21);
            this.cboCargo.TabIndex = 0;
            this.cboCargo.ValueMember = "IdCargo";
            // 
            // lOBOS_DBDataSet12
            // 
            this.lOBOS_DBDataSet12.DataSetName = "LOBOS_DBDataSet12";
            this.lOBOS_DBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOBOSDBDataSet12BindingSource
            // 
            this.lOBOSDBDataSet12BindingSource.DataSource = this.lOBOS_DBDataSet12;
            this.lOBOSDBDataSet12BindingSource.Position = 0;
            // 
            // lOBOS_DBDataSet13
            // 
            this.lOBOS_DBDataSet13.DataSetName = "LOBOS_DBDataSet13";
            this.lOBOS_DBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWCARGOSBindingSource
            // 
            this.vWCARGOSBindingSource.DataMember = "VW_CARGOS";
            this.vWCARGOSBindingSource.DataSource = this.lOBOS_DBDataSet13;
            // 
            // vW_CARGOSTableAdapter
            // 
            this.vW_CARGOSTableAdapter.ClearBeforeFill = true;
            // 
            // txtSector
            // 
            this.txtSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSector.Location = new System.Drawing.Point(74, 151);
            this.txtSector.MaxLength = 50;
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(175, 20);
            this.txtSector.TabIndex = 1;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cboEstado.Location = new System.Drawing.Point(99, 239);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cargo:";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(133, 132);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(41, 13);
            this.lblSector.TabIndex = 4;
            this.lblSector.Text = "Sector:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(136, 220);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(36, 304);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(99, 39);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(182, 304);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(99, 39);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDniApellidoNombre
            // 
            this.lblDniApellidoNombre.AutoSize = true;
            this.lblDniApellidoNombre.Location = new System.Drawing.Point(13, 13);
            this.lblDniApellidoNombre.Name = "lblDniApellidoNombre";
            this.lblDniApellidoNombre.Size = new System.Drawing.Size(115, 13);
            this.lblDniApellidoNombre.TabIndex = 8;
            this.lblDniApellidoNombre.Text = "DNI, Apellido y nombre";
            // 
            // frmModificarDatoAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 355);
            this.Controls.Add(this.lblDniApellidoNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.cboCargo);
            this.MaximumSize = new System.Drawing.Size(336, 393);
            this.MinimumSize = new System.Drawing.Size(336, 393);
            this.Name = "frmModificarDatoAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Administrativo";
            this.Load += new System.EventHandler(this.frmModificarDatoAdministrativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOSDBDataSet12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWCARGOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.BindingSource lOBOSDBDataSet12BindingSource;
        private LOBOS_DBDataSet12 lOBOS_DBDataSet12;
        private LOBOS_DBDataSet13 lOBOS_DBDataSet13;
        private System.Windows.Forms.BindingSource vWCARGOSBindingSource;
        private LOBOS_DBDataSet13TableAdapters.VW_CARGOSTableAdapter vW_CARGOSTableAdapter;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDniApellidoNombre;
    }
}