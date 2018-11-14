namespace Presentacion
{
    partial class frmModificarHistoriaClinica
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblMotivoConsulta = new System.Windows.Forms.Label();
            this.lblFechaVtoCarnet = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.cboRazonSocial = new System.Windows.Forms.ComboBox();
            this.vwRazonSocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet11 = new Presentacion.LOBOS_DBDataSet11();
            this.txtMotivoHC = new System.Windows.Forms.TextBox();
            this.dtpFechaVtoCarnet = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroAfiliado = new System.Windows.Forms.Label();
            this.txtNumeroAfiliado = new System.Windows.Forms.TextBox();
            this.lOBOS_DBDataSet10 = new Presentacion.LOBOS_DBDataSet10();
            this.lOBOSDBDataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_RazonSocialTableAdapter = new Presentacion.LOBOS_DBDataSet11TableAdapters.vw_RazonSocialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vwRazonSocialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOSDBDataSet10BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(272, 297);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 44);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(25, 297);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(132, 44);
            this.btnGrabar.TabIndex = 18;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblMotivoConsulta
            // 
            this.lblMotivoConsulta.AutoSize = true;
            this.lblMotivoConsulta.Location = new System.Drawing.Point(69, 142);
            this.lblMotivoConsulta.Name = "lblMotivoConsulta";
            this.lblMotivoConsulta.Size = new System.Drawing.Size(42, 13);
            this.lblMotivoConsulta.TabIndex = 17;
            this.lblMotivoConsulta.Text = "Motivo:";
            // 
            // lblFechaVtoCarnet
            // 
            this.lblFechaVtoCarnet.AutoSize = true;
            this.lblFechaVtoCarnet.Location = new System.Drawing.Point(48, 105);
            this.lblFechaVtoCarnet.Name = "lblFechaVtoCarnet";
            this.lblFechaVtoCarnet.Size = new System.Drawing.Size(63, 13);
            this.lblFechaVtoCarnet.TabIndex = 16;
            this.lblFechaVtoCarnet.Text = "Vto. Carnet:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(38, 37);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 15;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // cboRazonSocial
            // 
            this.cboRazonSocial.DataSource = this.vwRazonSocialBindingSource;
            this.cboRazonSocial.DisplayMember = "Nombre";
            this.cboRazonSocial.FormattingEnabled = true;
            this.cboRazonSocial.Location = new System.Drawing.Point(117, 34);
            this.cboRazonSocial.Name = "cboRazonSocial";
            this.cboRazonSocial.Size = new System.Drawing.Size(273, 21);
            this.cboRazonSocial.TabIndex = 10;
            this.cboRazonSocial.ValueMember = "idrazonsocial";
            // 
            // vwRazonSocialBindingSource
            // 
            this.vwRazonSocialBindingSource.DataMember = "vw_RazonSocial";
            this.vwRazonSocialBindingSource.DataSource = this.lOBOS_DBDataSet11;
            // 
            // lOBOS_DBDataSet11
            // 
            this.lOBOS_DBDataSet11.DataSetName = "LOBOS_DBDataSet11";
            this.lOBOS_DBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMotivoHC
            // 
            this.txtMotivoHC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivoHC.Location = new System.Drawing.Point(117, 139);
            this.txtMotivoHC.Multiline = true;
            this.txtMotivoHC.Name = "txtMotivoHC";
            this.txtMotivoHC.Size = new System.Drawing.Size(304, 125);
            this.txtMotivoHC.TabIndex = 14;
            // 
            // dtpFechaVtoCarnet
            // 
            this.dtpFechaVtoCarnet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVtoCarnet.Location = new System.Drawing.Point(117, 99);
            this.dtpFechaVtoCarnet.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVtoCarnet.Name = "dtpFechaVtoCarnet";
            this.dtpFechaVtoCarnet.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaVtoCarnet.TabIndex = 13;
            // 
            // lblNumeroAfiliado
            // 
            this.lblNumeroAfiliado.AutoSize = true;
            this.lblNumeroAfiliado.Location = new System.Drawing.Point(12, 72);
            this.lblNumeroAfiliado.Name = "lblNumeroAfiliado";
            this.lblNumeroAfiliado.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroAfiliado.TabIndex = 11;
            this.lblNumeroAfiliado.Text = "Numero de Afiliado:";
            // 
            // txtNumeroAfiliado
            // 
            this.txtNumeroAfiliado.Location = new System.Drawing.Point(117, 69);
            this.txtNumeroAfiliado.Name = "txtNumeroAfiliado";
            this.txtNumeroAfiliado.Size = new System.Drawing.Size(243, 20);
            this.txtNumeroAfiliado.TabIndex = 12;
            // 
            // lOBOS_DBDataSet10
            // 
            this.lOBOS_DBDataSet10.DataSetName = "LOBOS_DBDataSet10";
            this.lOBOS_DBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOBOSDBDataSet10BindingSource
            // 
            this.lOBOSDBDataSet10BindingSource.DataSource = this.lOBOS_DBDataSet10;
            this.lOBOSDBDataSet10BindingSource.Position = 0;
            // 
            // vw_RazonSocialTableAdapter
            // 
            this.vw_RazonSocialTableAdapter.ClearBeforeFill = true;
            // 
            // frmModificarHistoriaClinica
            // 
            this.AcceptButton = this.btnGrabar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(433, 375);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblMotivoConsulta);
            this.Controls.Add(this.lblFechaVtoCarnet);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.cboRazonSocial);
            this.Controls.Add(this.txtMotivoHC);
            this.Controls.Add(this.dtpFechaVtoCarnet);
            this.Controls.Add(this.lblNumeroAfiliado);
            this.Controls.Add(this.txtNumeroAfiliado);
            this.MinimumSize = new System.Drawing.Size(449, 413);
            this.Name = "frmModificarHistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Historia Clinica";
            this.Load += new System.EventHandler(this.frmModificarHistoriaClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwRazonSocialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOSDBDataSet10BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblMotivoConsulta;
        private System.Windows.Forms.Label lblFechaVtoCarnet;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.ComboBox cboRazonSocial;
        private System.Windows.Forms.TextBox txtMotivoHC;
        private System.Windows.Forms.DateTimePicker dtpFechaVtoCarnet;
        private System.Windows.Forms.Label lblNumeroAfiliado;
        private System.Windows.Forms.TextBox txtNumeroAfiliado;
        private System.Windows.Forms.BindingSource lOBOSDBDataSet10BindingSource;
        private LOBOS_DBDataSet10 lOBOS_DBDataSet10;
        private LOBOS_DBDataSet11 lOBOS_DBDataSet11;
        private System.Windows.Forms.BindingSource vwRazonSocialBindingSource;
        private LOBOS_DBDataSet11TableAdapters.vw_RazonSocialTableAdapter vw_RazonSocialTableAdapter;
    }
}