﻿namespace Presentacion
{
    partial class frmCrearHistoriaClinica
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
            this.txtNumeroAfiliado = new System.Windows.Forms.TextBox();
            this.lblNumeroAfiliado = new System.Windows.Forms.Label();
            this.dtpFechaVtoCarnet = new System.Windows.Forms.DateTimePicker();
            this.txtMotivoHC = new System.Windows.Forms.TextBox();
            this.cboRazonSocial = new System.Windows.Forms.ComboBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblFechaVtoCarnet = new System.Windows.Forms.Label();
            this.lblMotivoConsulta = new System.Windows.Forms.Label();
            this.btnAgregarRazonSocial = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lOBOS_DBDataSet9 = new Presentacion.LOBOS_DBDataSet9();
            this.vwRazonSocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_RazonSocialTableAdapter = new Presentacion.LOBOS_DBDataSet9TableAdapters.vw_RazonSocialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRazonSocialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroAfiliado
            // 
            this.txtNumeroAfiliado.Location = new System.Drawing.Point(117, 72);
            this.txtNumeroAfiliado.Name = "txtNumeroAfiliado";
            this.txtNumeroAfiliado.Size = new System.Drawing.Size(243, 20);
            this.txtNumeroAfiliado.TabIndex = 1;
            // 
            // lblNumeroAfiliado
            // 
            this.lblNumeroAfiliado.AutoSize = true;
            this.lblNumeroAfiliado.Location = new System.Drawing.Point(12, 75);
            this.lblNumeroAfiliado.Name = "lblNumeroAfiliado";
            this.lblNumeroAfiliado.Size = new System.Drawing.Size(99, 13);
            this.lblNumeroAfiliado.TabIndex = 1;
            this.lblNumeroAfiliado.Text = "Numero de Afiliado:";
            // 
            // dtpFechaVtoCarnet
            // 
            this.dtpFechaVtoCarnet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVtoCarnet.Location = new System.Drawing.Point(117, 102);
            this.dtpFechaVtoCarnet.Name = "dtpFechaVtoCarnet";
            this.dtpFechaVtoCarnet.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaVtoCarnet.TabIndex = 2;
            // 
            // txtMotivoHC
            // 
            this.txtMotivoHC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivoHC.Location = new System.Drawing.Point(117, 142);
            this.txtMotivoHC.Multiline = true;
            this.txtMotivoHC.Name = "txtMotivoHC";
            this.txtMotivoHC.Size = new System.Drawing.Size(304, 125);
            this.txtMotivoHC.TabIndex = 3;
            // 
            // cboRazonSocial
            // 
            this.cboRazonSocial.DataSource = this.vwRazonSocialBindingSource;
            this.cboRazonSocial.DisplayMember = "Nombre";
            this.cboRazonSocial.FormattingEnabled = true;
            this.cboRazonSocial.Location = new System.Drawing.Point(117, 37);
            this.cboRazonSocial.Name = "cboRazonSocial";
            this.cboRazonSocial.Size = new System.Drawing.Size(273, 21);
            this.cboRazonSocial.TabIndex = 0;
            this.cboRazonSocial.ValueMember = "idrazonsocial";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(38, 40);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 4;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // lblFechaVtoCarnet
            // 
            this.lblFechaVtoCarnet.AutoSize = true;
            this.lblFechaVtoCarnet.Location = new System.Drawing.Point(48, 108);
            this.lblFechaVtoCarnet.Name = "lblFechaVtoCarnet";
            this.lblFechaVtoCarnet.Size = new System.Drawing.Size(63, 13);
            this.lblFechaVtoCarnet.TabIndex = 5;
            this.lblFechaVtoCarnet.Text = "Vto. Carnet:";
            // 
            // lblMotivoConsulta
            // 
            this.lblMotivoConsulta.AutoSize = true;
            this.lblMotivoConsulta.Location = new System.Drawing.Point(69, 145);
            this.lblMotivoConsulta.Name = "lblMotivoConsulta";
            this.lblMotivoConsulta.Size = new System.Drawing.Size(42, 13);
            this.lblMotivoConsulta.TabIndex = 6;
            this.lblMotivoConsulta.Text = "Motivo:";
            // 
            // btnAgregarRazonSocial
            // 
            this.btnAgregarRazonSocial.Location = new System.Drawing.Point(396, 37);
            this.btnAgregarRazonSocial.Name = "btnAgregarRazonSocial";
            this.btnAgregarRazonSocial.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarRazonSocial.TabIndex = 7;
            this.btnAgregarRazonSocial.Text = "+";
            this.btnAgregarRazonSocial.UseVisualStyleBackColor = true;
            this.btnAgregarRazonSocial.Click += new System.EventHandler(this.btnAgregarRazonSocial_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(25, 300);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(132, 44);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(272, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 44);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lOBOS_DBDataSet9
            // 
            this.lOBOS_DBDataSet9.DataSetName = "LOBOS_DBDataSet9";
            this.lOBOS_DBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwRazonSocialBindingSource
            // 
            this.vwRazonSocialBindingSource.DataMember = "vw_RazonSocial";
            this.vwRazonSocialBindingSource.DataSource = this.lOBOS_DBDataSet9;
            // 
            // vw_RazonSocialTableAdapter
            // 
            this.vw_RazonSocialTableAdapter.ClearBeforeFill = true;
            // 
            // frmCrearHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 375);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnAgregarRazonSocial);
            this.Controls.Add(this.lblMotivoConsulta);
            this.Controls.Add(this.lblFechaVtoCarnet);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.cboRazonSocial);
            this.Controls.Add(this.txtMotivoHC);
            this.Controls.Add(this.dtpFechaVtoCarnet);
            this.Controls.Add(this.lblNumeroAfiliado);
            this.Controls.Add(this.txtNumeroAfiliado);
            this.Name = "frmCrearHistoriaClinica";
            this.Text = "frmCrearHistoriaClinica";
            this.Load += new System.EventHandler(this.frmCrearHistoriaClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRazonSocialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroAfiliado;
        private System.Windows.Forms.Label lblNumeroAfiliado;
        private System.Windows.Forms.DateTimePicker dtpFechaVtoCarnet;
        private System.Windows.Forms.TextBox txtMotivoHC;
        private System.Windows.Forms.ComboBox cboRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblFechaVtoCarnet;
        private System.Windows.Forms.Label lblMotivoConsulta;
        private System.Windows.Forms.Button btnAgregarRazonSocial;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private LOBOS_DBDataSet9 lOBOS_DBDataSet9;
        private System.Windows.Forms.BindingSource vwRazonSocialBindingSource;
        private LOBOS_DBDataSet9TableAdapters.vw_RazonSocialTableAdapter vw_RazonSocialTableAdapter;
    }
}