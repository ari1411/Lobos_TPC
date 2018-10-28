namespace Presentacion
{
    partial class frmAgregarProvincia
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
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.cboPaises = new System.Windows.Forms.ComboBox();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet5 = new Presentacion.LOBOS_DBDataSet5();
            this.paisesTableAdapter = new Presentacion.LOBOS_DBDataSet5TableAdapters.PaisesTableAdapter();
            this.btnCancelarAgProvincia = new System.Windows.Forms.Button();
            this.btnAceptarAgProvincia = new System.Windows.Forms.Button();
            this.btnAgregarPais = new System.Windows.Forms.Button();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblPaises = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProvincia
            // 
            this.txtProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProvincia.Location = new System.Drawing.Point(12, 77);
            this.txtProvincia.MaxLength = 50;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(202, 20);
            this.txtProvincia.TabIndex = 0;
            // 
            // cboPaises
            // 
            this.cboPaises.DataSource = this.paisesBindingSource;
            this.cboPaises.DisplayMember = "Pais";
            this.cboPaises.FormattingEnabled = true;
            this.cboPaises.Location = new System.Drawing.Point(12, 172);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(279, 21);
            this.cboPaises.TabIndex = 1;
            this.cboPaises.ValueMember = "IdPais";
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "Paises";
            this.paisesBindingSource.DataSource = this.lOBOS_DBDataSet5;
            // 
            // lOBOS_DBDataSet5
            // 
            this.lOBOS_DBDataSet5.DataSetName = "LOBOS_DBDataSet5";
            this.lOBOS_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelarAgProvincia
            // 
            this.btnCancelarAgProvincia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarAgProvincia.Location = new System.Drawing.Point(201, 271);
            this.btnCancelarAgProvincia.Name = "btnCancelarAgProvincia";
            this.btnCancelarAgProvincia.Size = new System.Drawing.Size(90, 30);
            this.btnCancelarAgProvincia.TabIndex = 3;
            this.btnCancelarAgProvincia.Text = "Cancelar";
            this.btnCancelarAgProvincia.UseVisualStyleBackColor = true;
            this.btnCancelarAgProvincia.Click += new System.EventHandler(this.btnCancelarAgProvincia_Click);
            // 
            // btnAceptarAgProvincia
            // 
            this.btnAceptarAgProvincia.Location = new System.Drawing.Point(40, 271);
            this.btnAceptarAgProvincia.Name = "btnAceptarAgProvincia";
            this.btnAceptarAgProvincia.Size = new System.Drawing.Size(90, 30);
            this.btnAceptarAgProvincia.TabIndex = 2;
            this.btnAceptarAgProvincia.Text = "Agregar";
            this.btnAceptarAgProvincia.UseVisualStyleBackColor = true;
            this.btnAceptarAgProvincia.Click += new System.EventHandler(this.btnAceptarAgProvincia_Click);
            // 
            // btnAgregarPais
            // 
            this.btnAgregarPais.Location = new System.Drawing.Point(297, 172);
            this.btnAgregarPais.Name = "btnAgregarPais";
            this.btnAgregarPais.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarPais.TabIndex = 4;
            this.btnAgregarPais.Text = "+";
            this.btnAgregarPais.UseVisualStyleBackColor = true;
            this.btnAgregarPais.Click += new System.EventHandler(this.btnAgregarPais_Click);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(12, 61);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 17;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblPaises
            // 
            this.lblPaises.AutoSize = true;
            this.lblPaises.Location = new System.Drawing.Point(12, 157);
            this.lblPaises.Name = "lblPaises";
            this.lblPaises.Size = new System.Drawing.Size(86, 13);
            this.lblPaises.TabIndex = 18;
            this.lblPaises.Text = "Seleccione Pais:";
            // 
            // frmAgregarProvincia
            // 
            this.AcceptButton = this.btnAceptarAgProvincia;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarAgProvincia;
            this.ClientSize = new System.Drawing.Size(342, 321);
            this.ControlBox = false;
            this.Controls.Add(this.lblPaises);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.btnAgregarPais);
            this.Controls.Add(this.btnCancelarAgProvincia);
            this.Controls.Add(this.btnAceptarAgProvincia);
            this.Controls.Add(this.cboPaises);
            this.Controls.Add(this.txtProvincia);
            this.MaximumSize = new System.Drawing.Size(358, 359);
            this.MinimumSize = new System.Drawing.Size(358, 359);
            this.Name = "frmAgregarProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAgregarProvincia";
            this.Load += new System.EventHandler(this.frmAgregarProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.ComboBox cboPaises;
        private LOBOS_DBDataSet5 lOBOS_DBDataSet5;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private LOBOS_DBDataSet5TableAdapters.PaisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.Button btnCancelarAgProvincia;
        private System.Windows.Forms.Button btnAceptarAgProvincia;
        private System.Windows.Forms.Button btnAgregarPais;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblPaises;
    }
}