namespace Presentacion
{
    partial class frmAgregarPartido
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
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.cboProvincias = new System.Windows.Forms.ComboBox();
            this.vWPROVINCIASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet4 = new Presentacion.LOBOS_DBDataSet4();
            this.vW_PROVINCIASTableAdapter = new Presentacion.LOBOS_DBDataSet4TableAdapters.VW_PROVINCIASTableAdapter();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.btnCancelarAgPartido = new System.Windows.Forms.Button();
            this.btnAceptarAgPartido = new System.Windows.Forms.Button();
            this.btnAgregarProv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vWPROVINCIASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPartido
            // 
            this.txtPartido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPartido.Location = new System.Drawing.Point(12, 53);
            this.txtPartido.MaxLength = 50;
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(195, 20);
            this.txtPartido.TabIndex = 0;
            // 
            // cboProvincias
            // 
            this.cboProvincias.DataSource = this.vWPROVINCIASBindingSource;
            this.cboProvincias.DisplayMember = "PROVINCIAS";
            this.cboProvincias.FormattingEnabled = true;
            this.cboProvincias.Location = new System.Drawing.Point(12, 132);
            this.cboProvincias.Name = "cboProvincias";
            this.cboProvincias.Size = new System.Drawing.Size(280, 21);
            this.cboProvincias.TabIndex = 1;
            this.cboProvincias.ValueMember = "IDPROVINCIA";
            // 
            // vWPROVINCIASBindingSource
            // 
            this.vWPROVINCIASBindingSource.DataMember = "VW_PROVINCIAS";
            this.vWPROVINCIASBindingSource.DataSource = this.lOBOS_DBDataSet4;
            // 
            // lOBOS_DBDataSet4
            // 
            this.lOBOS_DBDataSet4.DataSetName = "LOBOS_DBDataSet4";
            this.lOBOS_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_PROVINCIASTableAdapter
            // 
            this.vW_PROVINCIASTableAdapter.ClearBeforeFill = true;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(12, 37);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(43, 13);
            this.lblPartido.TabIndex = 2;
            this.lblPartido.Text = "Partido:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(12, 116);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(110, 13);
            this.lblProvincia.TabIndex = 3;
            this.lblProvincia.Text = "Seleccione Provincia:";
            // 
            // btnCancelarAgPartido
            // 
            this.btnCancelarAgPartido.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarAgPartido.Location = new System.Drawing.Point(202, 205);
            this.btnCancelarAgPartido.Name = "btnCancelarAgPartido";
            this.btnCancelarAgPartido.Size = new System.Drawing.Size(90, 30);
            this.btnCancelarAgPartido.TabIndex = 3;
            this.btnCancelarAgPartido.Text = "Cancelar";
            this.btnCancelarAgPartido.UseVisualStyleBackColor = true;
            this.btnCancelarAgPartido.Click += new System.EventHandler(this.btnCancelarAgPartido_Click);
            // 
            // btnAceptarAgPartido
            // 
            this.btnAceptarAgPartido.Location = new System.Drawing.Point(41, 205);
            this.btnAceptarAgPartido.Name = "btnAceptarAgPartido";
            this.btnAceptarAgPartido.Size = new System.Drawing.Size(90, 30);
            this.btnAceptarAgPartido.TabIndex = 2;
            this.btnAceptarAgPartido.Text = "Agregar";
            this.btnAceptarAgPartido.UseVisualStyleBackColor = true;
            this.btnAceptarAgPartido.Click += new System.EventHandler(this.btnAceptarAgPartido_Click);
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.Location = new System.Drawing.Point(298, 132);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarProv.TabIndex = 4;
            this.btnAgregarProv.Text = "+";
            this.btnAgregarProv.UseVisualStyleBackColor = true;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // frmAgregarPartido
            // 
            this.AcceptButton = this.btnAceptarAgPartido;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarAgPartido;
            this.ClientSize = new System.Drawing.Size(335, 247);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarProv);
            this.Controls.Add(this.btnCancelarAgPartido);
            this.Controls.Add(this.btnAceptarAgPartido);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.cboProvincias);
            this.Controls.Add(this.txtPartido);
            this.MaximumSize = new System.Drawing.Size(351, 285);
            this.MinimumSize = new System.Drawing.Size(351, 285);
            this.Name = "frmAgregarPartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Partido";
            this.Load += new System.EventHandler(this.frmAgregarPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWPROVINCIASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.ComboBox cboProvincias;
        private LOBOS_DBDataSet4 lOBOS_DBDataSet4;
        private System.Windows.Forms.BindingSource vWPROVINCIASBindingSource;
        private LOBOS_DBDataSet4TableAdapters.VW_PROVINCIASTableAdapter vW_PROVINCIASTableAdapter;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnCancelarAgPartido;
        private System.Windows.Forms.Button btnAceptarAgPartido;
        private System.Windows.Forms.Button btnAgregarProv;
    }
}