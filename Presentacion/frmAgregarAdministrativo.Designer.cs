namespace Presentacion
{
    partial class frmAgregarAdministrativo
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
            this.vWCARGOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet12 = new Presentacion.LOBOS_DBDataSet12();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblDniApellidoNombre = new System.Windows.Forms.Label();
            this.btnGrabarAgregarAdministrativo = new System.Windows.Forms.Button();
            this.btnVolverAgregarAdmin = new System.Windows.Forms.Button();
            this.vW_CARGOSTableAdapter = new Presentacion.LOBOS_DBDataSet12TableAdapters.VW_CARGOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vWCARGOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCargo
            // 
            this.cboCargo.DataSource = this.vWCARGOSBindingSource;
            this.cboCargo.DisplayMember = "Cargo";
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(92, 101);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(121, 21);
            this.cboCargo.TabIndex = 0;
            this.cboCargo.ValueMember = "IdCargo";
            // 
            // vWCARGOSBindingSource
            // 
            this.vWCARGOSBindingSource.DataMember = "VW_CARGOS";
            this.vWCARGOSBindingSource.DataSource = this.lOBOS_DBDataSet12;
            // 
            // lOBOS_DBDataSet12
            // 
            this.lOBOS_DBDataSet12.DataSetName = "LOBOS_DBDataSet12";
            this.lOBOS_DBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSector
            // 
            this.txtSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSector.Location = new System.Drawing.Point(60, 198);
            this.txtSector.MaxLength = 50;
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(183, 20);
            this.txtSector.TabIndex = 1;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(130, 70);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(130, 168);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(41, 13);
            this.lblSector.TabIndex = 3;
            this.lblSector.Text = "Sector:";
            // 
            // lblDniApellidoNombre
            // 
            this.lblDniApellidoNombre.AutoSize = true;
            this.lblDniApellidoNombre.Location = new System.Drawing.Point(13, 13);
            this.lblDniApellidoNombre.Name = "lblDniApellidoNombre";
            this.lblDniApellidoNombre.Size = new System.Drawing.Size(112, 13);
            this.lblDniApellidoNombre.TabIndex = 4;
            this.lblDniApellidoNombre.Text = "DNI, Apellido, Nombre";
            // 
            // btnGrabarAgregarAdministrativo
            // 
            this.btnGrabarAgregarAdministrativo.Location = new System.Drawing.Point(37, 293);
            this.btnGrabarAgregarAdministrativo.Name = "btnGrabarAgregarAdministrativo";
            this.btnGrabarAgregarAdministrativo.Size = new System.Drawing.Size(100, 35);
            this.btnGrabarAgregarAdministrativo.TabIndex = 5;
            this.btnGrabarAgregarAdministrativo.Text = "Grabar";
            this.btnGrabarAgregarAdministrativo.UseVisualStyleBackColor = true;
            this.btnGrabarAgregarAdministrativo.Click += new System.EventHandler(this.btnGrabarAgregarAdministrativo_Click);
            // 
            // btnVolverAgregarAdmin
            // 
            this.btnVolverAgregarAdmin.Location = new System.Drawing.Point(188, 293);
            this.btnVolverAgregarAdmin.Name = "btnVolverAgregarAdmin";
            this.btnVolverAgregarAdmin.Size = new System.Drawing.Size(97, 35);
            this.btnVolverAgregarAdmin.TabIndex = 6;
            this.btnVolverAgregarAdmin.Text = "Volver";
            this.btnVolverAgregarAdmin.UseVisualStyleBackColor = true;
            this.btnVolverAgregarAdmin.Click += new System.EventHandler(this.btnVolverAgregarAdmin_Click);
            // 
            // vW_CARGOSTableAdapter
            // 
            this.vW_CARGOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmAgregarAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 355);
            this.Controls.Add(this.btnVolverAgregarAdmin);
            this.Controls.Add(this.btnGrabarAgregarAdministrativo);
            this.Controls.Add(this.lblDniApellidoNombre);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.cboCargo);
            this.MaximumSize = new System.Drawing.Size(336, 393);
            this.MinimumSize = new System.Drawing.Size(336, 393);
            this.Name = "frmAgregarAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Administrativo";
            this.Load += new System.EventHandler(this.frmAgregarAdministrativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWCARGOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblDniApellidoNombre;
        private System.Windows.Forms.Button btnGrabarAgregarAdministrativo;
        private System.Windows.Forms.Button btnVolverAgregarAdmin;
        private LOBOS_DBDataSet12 lOBOS_DBDataSet12;
        private System.Windows.Forms.BindingSource vWCARGOSBindingSource;
        private LOBOS_DBDataSet12TableAdapters.VW_CARGOSTableAdapter vW_CARGOSTableAdapter;
    }
}