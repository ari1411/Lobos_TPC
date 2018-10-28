namespace Presentacion
{
    partial class frmAgregarMunicipio
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cboPartidos = new System.Windows.Forms.ComboBox();
            this.vWPARTIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet3 = new Presentacion.LOBOS_DBDataSet3();
            this.vW_PARTIDOSTableAdapter = new Presentacion.LOBOS_DBDataSet3TableAdapters.VW_PARTIDOSTableAdapter();
            this.lblpartido = new System.Windows.Forms.Label();
            this.btnCancelarAgMun = new System.Windows.Forms.Button();
            this.btnAceptarAgMun = new System.Windows.Forms.Button();
            this.lblMunCP = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.btnAgregarPartido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vWPARTIDOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(183, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(57, 399);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.Location = new System.Drawing.Point(12, 36);
            this.txtMunicipio.MaxLength = 50;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(209, 20);
            this.txtMunicipio.TabIndex = 0;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(12, 20);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(93, 13);
            this.lblMunicipio.TabIndex = 8;
            this.lblMunicipio.Text = "Ingrese Municipio:";
            // 
            // cboPartidos
            // 
            this.cboPartidos.DataSource = this.vWPARTIDOSBindingSource;
            this.cboPartidos.DisplayMember = "PARTIDOS";
            this.cboPartidos.Location = new System.Drawing.Point(12, 136);
            this.cboPartidos.Name = "cboPartidos";
            this.cboPartidos.Size = new System.Drawing.Size(280, 21);
            this.cboPartidos.TabIndex = 2;
            this.cboPartidos.ValueMember = "IDPARTIDO";
            // 
            // vWPARTIDOSBindingSource
            // 
            this.vWPARTIDOSBindingSource.DataMember = "VW_PARTIDOS";
            this.vWPARTIDOSBindingSource.DataSource = this.lOBOS_DBDataSet3;
            // 
            // lOBOS_DBDataSet3
            // 
            this.lOBOS_DBDataSet3.DataSetName = "LOBOS_DBDataSet3";
            this.lOBOS_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_PARTIDOSTableAdapter
            // 
            this.vW_PARTIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // lblpartido
            // 
            this.lblpartido.AutoSize = true;
            this.lblpartido.Location = new System.Drawing.Point(12, 120);
            this.lblpartido.Name = "lblpartido";
            this.lblpartido.Size = new System.Drawing.Size(99, 13);
            this.lblpartido.TabIndex = 9;
            this.lblpartido.Text = "Seleccione Partido:";
            // 
            // btnCancelarAgMun
            // 
            this.btnCancelarAgMun.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarAgMun.Location = new System.Drawing.Point(202, 172);
            this.btnCancelarAgMun.Name = "btnCancelarAgMun";
            this.btnCancelarAgMun.Size = new System.Drawing.Size(90, 30);
            this.btnCancelarAgMun.TabIndex = 5;
            this.btnCancelarAgMun.Text = "Cancelar";
            this.btnCancelarAgMun.UseVisualStyleBackColor = true;
            this.btnCancelarAgMun.Click += new System.EventHandler(this.btnCancelarAgMun_Click);
            // 
            // btnAceptarAgMun
            // 
            this.btnAceptarAgMun.Location = new System.Drawing.Point(42, 172);
            this.btnAceptarAgMun.Name = "btnAceptarAgMun";
            this.btnAceptarAgMun.Size = new System.Drawing.Size(90, 30);
            this.btnAceptarAgMun.TabIndex = 4;
            this.btnAceptarAgMun.Text = "Agregar";
            this.btnAceptarAgMun.UseVisualStyleBackColor = true;
            this.btnAceptarAgMun.Click += new System.EventHandler(this.btnAceptarAgMun_Click);
            // 
            // lblMunCP
            // 
            this.lblMunCP.AutoSize = true;
            this.lblMunCP.Location = new System.Drawing.Point(12, 71);
            this.lblMunCP.Name = "lblMunCP";
            this.lblMunCP.Size = new System.Drawing.Size(24, 13);
            this.lblMunCP.TabIndex = 12;
            this.lblMunCP.Text = "CP:";
            // 
            // txtCP
            // 
            this.txtCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCP.Location = new System.Drawing.Point(12, 87);
            this.txtCP.MaxLength = 6;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(99, 20);
            this.txtCP.TabIndex = 1;
            // 
            // btnAgregarPartido
            // 
            this.btnAgregarPartido.Location = new System.Drawing.Point(298, 136);
            this.btnAgregarPartido.Name = "btnAgregarPartido";
            this.btnAgregarPartido.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarPartido.TabIndex = 14;
            this.btnAgregarPartido.Text = "+";
            this.btnAgregarPartido.UseVisualStyleBackColor = true;
            this.btnAgregarPartido.Click += new System.EventHandler(this.btnAgregarPartido_Click);
            // 
            // frmAgregarMunicipio
            // 
            this.AcceptButton = this.btnAceptarAgMun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarAgMun;
            this.ClientSize = new System.Drawing.Size(335, 214);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarPartido);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.lblMunCP);
            this.Controls.Add(this.btnCancelarAgMun);
            this.Controls.Add(this.btnAceptarAgMun);
            this.Controls.Add(this.lblpartido);
            this.Controls.Add(this.cboPartidos);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.MaximumSize = new System.Drawing.Size(351, 252);
            this.MinimumSize = new System.Drawing.Size(351, 252);
            this.Name = "frmAgregarMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Municipio";
            this.Load += new System.EventHandler(this.frmAgregarMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWPARTIDOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox cboPartidos;
        private LOBOS_DBDataSet3 lOBOS_DBDataSet3;
        private System.Windows.Forms.BindingSource vWPARTIDOSBindingSource;
        private LOBOS_DBDataSet3TableAdapters.VW_PARTIDOSTableAdapter vW_PARTIDOSTableAdapter;
        private System.Windows.Forms.Label lblpartido;
        private System.Windows.Forms.Button btnCancelarAgMun;
        private System.Windows.Forms.Button btnAceptarAgMun;
        private System.Windows.Forms.Label lblMunCP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Button btnAgregarPartido;
    }
}