namespace Presentacion
{
    partial class frmAltaPaciente
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.vWNACIONALIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet1 = new Presentacion.LOBOS_DBDataSet1();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelFijo = new System.Windows.Forms.TextBox();
            this.txtTelMovil = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumeroCalle = new System.Windows.Forms.Label();
            this.lblPisoDto = new System.Windows.Forms.Label();
            this.lblBarra = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelFijo = new System.Windows.Forms.Label();
            this.lblTelMovil = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboMunicipio = new System.Windows.Forms.ComboBox();
            this.vWMUNICIPIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet2 = new Presentacion.LOBOS_DBDataSet2();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet = new Presentacion.LOBOS_DBDataSet();
            this.sexoTableAdapter = new Presentacion.LOBOS_DBDataSetTableAdapters.SexoTableAdapter();
            this.vW_NACIONALIDADTableAdapter = new Presentacion.LOBOS_DBDataSet1TableAdapters.VW_NACIONALIDADTableAdapter();
            this.vW_MUNICIPIOSTableAdapter = new Presentacion.LOBOS_DBDataSet2TableAdapters.VW_MUNICIPIOSTableAdapter();
            this.btnAgregarSexo = new System.Windows.Forms.Button();
            this.btnAgregarNacionalidad = new System.Windows.Forms.Button();
            this.btnAgregarMunicipio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vWNACIONALIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMUNICIPIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.AllowDrop = true;
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(218, 41);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(210, 20);
            this.txtDni.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.AllowDrop = true;
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(218, 73);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(285, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(218, 105);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(285, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboNacionalidad.DataSource = this.vWNACIONALIDADBindingSource;
            this.cboNacionalidad.DisplayMember = "NACIONALIDAD";
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(218, 170);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(178, 21);
            this.cboNacionalidad.TabIndex = 4;
            this.cboNacionalidad.ValueMember = "IdPais";
            // 
            // vWNACIONALIDADBindingSource
            // 
            this.vWNACIONALIDADBindingSource.DataMember = "VW_NACIONALIDAD";
            this.vWNACIONALIDADBindingSource.DataSource = this.lOBOS_DBDataSet1;
            // 
            // lOBOS_DBDataSet1
            // 
            this.lOBOS_DBDataSet1.DataSetName = "LOBOS_DBDataSet1";
            this.lOBOS_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(218, 203);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2018, 9, 20, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            this.dtpFechaNacimiento.Value = new System.DateTime(2018, 9, 20, 0, 0, 0, 0);
            // 
            // txtCalle
            // 
            this.txtCalle.AllowDrop = true;
            this.txtCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(218, 235);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(241, 20);
            this.txtCalle.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.AllowDrop = true;
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(505, 235);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // txtPiso
            // 
            this.txtPiso.AllowDrop = true;
            this.txtPiso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPiso.Location = new System.Drawing.Point(218, 267);
            this.txtPiso.MaxLength = 10;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(77, 20);
            this.txtPiso.TabIndex = 8;
            // 
            // txtDepto
            // 
            this.txtDepto.AllowDrop = true;
            this.txtDepto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepto.Location = new System.Drawing.Point(319, 267);
            this.txtDepto.MaxLength = 10;
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(77, 20);
            this.txtDepto.TabIndex = 9;
            this.txtDepto.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtPartido
            // 
            this.txtPartido.AllowDrop = true;
            this.txtPartido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPartido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPartido.Location = new System.Drawing.Point(218, 331);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(224, 20);
            this.txtPartido.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.AllowDrop = true;
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMail.Location = new System.Drawing.Point(218, 363);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(285, 20);
            this.txtMail.TabIndex = 12;
            // 
            // txtTelFijo
            // 
            this.txtTelFijo.AllowDrop = true;
            this.txtTelFijo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelFijo.Location = new System.Drawing.Point(479, 395);
            this.txtTelFijo.MaxLength = 14;
            this.txtTelFijo.Name = "txtTelFijo";
            this.txtTelFijo.Size = new System.Drawing.Size(178, 20);
            this.txtTelFijo.TabIndex = 14;
            // 
            // txtTelMovil
            // 
            this.txtTelMovil.AccessibleDescription = "";
            this.txtTelMovil.AccessibleName = "";
            this.txtTelMovil.AllowDrop = true;
            this.txtTelMovil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelMovil.Location = new System.Drawing.Point(218, 395);
            this.txtTelMovil.MaxLength = 14;
            this.txtTelMovil.Name = "txtTelMovil";
            this.txtTelMovil.Size = new System.Drawing.Size(191, 20);
            this.txtTelMovil.TabIndex = 13;
            // 
            // lblDni
            // 
            this.lblDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(183, 44);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 15;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(150, 76);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 13);
            this.lblApellido.TabIndex = 16;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(155, 108);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(173, 140);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 13);
            this.lblSexo.TabIndex = 18;
            this.lblSexo.Text = "SEXO:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(122, 173);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(90, 13);
            this.lblNacionalidad.TabIndex = 19;
            this.lblNacionalidad.Text = "NACIONALIDAD:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(79, 209);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(133, 13);
            this.lblFechaNacimiento.TabIndex = 20;
            this.lblFechaNacimiento.Text = "FECHA DE NACIMIENTO:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "CALLE:";
            // 
            // lblNumeroCalle
            // 
            this.lblNumeroCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroCalle.AutoSize = true;
            this.lblNumeroCalle.Location = new System.Drawing.Point(465, 238);
            this.lblNumeroCalle.Name = "lblNumeroCalle";
            this.lblNumeroCalle.Size = new System.Drawing.Size(34, 13);
            this.lblNumeroCalle.TabIndex = 22;
            this.lblNumeroCalle.Text = "NRO:";
            // 
            // lblPisoDto
            // 
            this.lblPisoDto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPisoDto.AutoSize = true;
            this.lblPisoDto.Location = new System.Drawing.Point(129, 270);
            this.lblPisoDto.Name = "lblPisoDto";
            this.lblPisoDto.Size = new System.Drawing.Size(83, 13);
            this.lblPisoDto.TabIndex = 23;
            this.lblPisoDto.Text = "PISO / DEPTO:";
            // 
            // lblBarra
            // 
            this.lblBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarra.AutoSize = true;
            this.lblBarra.Location = new System.Drawing.Point(301, 270);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(12, 13);
            this.lblBarra.TabIndex = 24;
            this.lblBarra.Text = "/";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(146, 302);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(66, 13);
            this.lblMunicipio.TabIndex = 25;
            this.lblMunicipio.Text = "MUNICIPIO:";
            // 
            // lblPartido
            // 
            this.lblPartido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(154, 334);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(58, 13);
            this.lblPartido.TabIndex = 26;
            this.lblPartido.Text = "PARTIDO:";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(167, 366);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 13);
            this.lblMail.TabIndex = 27;
            this.lblMail.Text = "E-MAIL:";
            // 
            // lblTelFijo
            // 
            this.lblTelFijo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelFijo.AutoSize = true;
            this.lblTelFijo.Location = new System.Drawing.Point(415, 398);
            this.lblTelFijo.Name = "lblTelFijo";
            this.lblTelFijo.Size = new System.Drawing.Size(58, 13);
            this.lblTelFijo.TabIndex = 28;
            this.lblTelFijo.Text = "TEL. FIJO:";
            // 
            // lblTelMovil
            // 
            this.lblTelMovil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelMovil.AutoSize = true;
            this.lblTelMovil.Location = new System.Drawing.Point(143, 398);
            this.lblTelMovil.Name = "lblTelMovil";
            this.lblTelMovil.Size = new System.Drawing.Size(69, 13);
            this.lblTelMovil.TabIndex = 29;
            this.lblTelMovil.Text = "TEL. MOVIL:";
            this.lblTelMovil.Click += new System.EventHandler(this.lblTelMovil_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrabar.Location = new System.Drawing.Point(234, 454);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(115, 43);
            this.btnGrabar.TabIndex = 15;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(444, 454);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 43);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMunicipio.DataSource = this.vWMUNICIPIOSBindingSource;
            this.cboMunicipio.DisplayMember = "MUNICIPIOS";
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(218, 302);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.Size = new System.Drawing.Size(439, 21);
            this.cboMunicipio.TabIndex = 10;
            this.cboMunicipio.ValueMember = "IDMUNICIPIO";
            // 
            // vWMUNICIPIOSBindingSource
            // 
            this.vWMUNICIPIOSBindingSource.DataMember = "VW_MUNICIPIOS";
            this.vWMUNICIPIOSBindingSource.DataSource = this.lOBOS_DBDataSet2;
            // 
            // lOBOS_DBDataSet2
            // 
            this.lOBOS_DBDataSet2.DataSetName = "LOBOS_DBDataSet2";
            this.lOBOS_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboSexo
            // 
            this.cboSexo.DataSource = this.sexoBindingSource;
            this.cboSexo.DisplayMember = "Sexo";
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(218, 137);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(121, 21);
            this.cboSexo.TabIndex = 3;
            this.cboSexo.ValueMember = "Idsexo";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.lOBOS_DBDataSet;
            // 
            // lOBOS_DBDataSet
            // 
            this.lOBOS_DBDataSet.DataSetName = "LOBOS_DBDataSet";
            this.lOBOS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // vW_NACIONALIDADTableAdapter
            // 
            this.vW_NACIONALIDADTableAdapter.ClearBeforeFill = true;
            // 
            // vW_MUNICIPIOSTableAdapter
            // 
            this.vW_MUNICIPIOSTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarSexo
            // 
            this.btnAgregarSexo.Location = new System.Drawing.Point(345, 137);
            this.btnAgregarSexo.Name = "btnAgregarSexo";
            this.btnAgregarSexo.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarSexo.TabIndex = 17;
            this.btnAgregarSexo.Text = "+";
            this.btnAgregarSexo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarSexo.UseVisualStyleBackColor = true;
            this.btnAgregarSexo.Click += new System.EventHandler(this.btnAgregarSexo_Click);
            // 
            // btnAgregarNacionalidad
            // 
            this.btnAgregarNacionalidad.Location = new System.Drawing.Point(402, 170);
            this.btnAgregarNacionalidad.Name = "btnAgregarNacionalidad";
            this.btnAgregarNacionalidad.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarNacionalidad.TabIndex = 18;
            this.btnAgregarNacionalidad.Text = "+";
            this.btnAgregarNacionalidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarNacionalidad.UseVisualStyleBackColor = true;
            this.btnAgregarNacionalidad.Click += new System.EventHandler(this.btnAgregarNacionalidad_Click);
            // 
            // btnAgregarMunicipio
            // 
            this.btnAgregarMunicipio.Location = new System.Drawing.Point(663, 302);
            this.btnAgregarMunicipio.Name = "btnAgregarMunicipio";
            this.btnAgregarMunicipio.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarMunicipio.TabIndex = 19;
            this.btnAgregarMunicipio.Text = "+";
            this.btnAgregarMunicipio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarMunicipio.UseVisualStyleBackColor = true;
            this.btnAgregarMunicipio.Click += new System.EventHandler(this.btnAgregarMunicipio_Click);
            // 
            // frmAltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarMunicipio);
            this.Controls.Add(this.btnAgregarNacionalidad);
            this.Controls.Add(this.btnAgregarSexo);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.cboMunicipio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblTelMovil);
            this.Controls.Add(this.lblTelFijo);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.lblPisoDto);
            this.Controls.Add(this.lblNumeroCalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtTelMovil);
            this.Controls.Add(this.txtTelFijo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPartido);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cboNacionalidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmAltaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Paciente";
            this.Load += new System.EventHandler(this.frmAltaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWNACIONALIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMUNICIPIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboNacionalidad;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelFijo;
        private System.Windows.Forms.TextBox txtTelMovil;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumeroCalle;
        private System.Windows.Forms.Label lblPisoDto;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelFijo;
        private System.Windows.Forms.Label lblTelMovil;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboMunicipio;
        private System.Windows.Forms.ComboBox cboSexo;
        private LOBOS_DBDataSet lOBOS_DBDataSet;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private LOBOS_DBDataSetTableAdapters.SexoTableAdapter sexoTableAdapter;
        private LOBOS_DBDataSet1 lOBOS_DBDataSet1;
        private System.Windows.Forms.BindingSource vWNACIONALIDADBindingSource;
        private LOBOS_DBDataSet1TableAdapters.VW_NACIONALIDADTableAdapter vW_NACIONALIDADTableAdapter;
        private LOBOS_DBDataSet2 lOBOS_DBDataSet2;
        private System.Windows.Forms.BindingSource vWMUNICIPIOSBindingSource;
        private LOBOS_DBDataSet2TableAdapters.VW_MUNICIPIOSTableAdapter vW_MUNICIPIOSTableAdapter;
        private System.Windows.Forms.Button btnAgregarSexo;
        private System.Windows.Forms.Button btnAgregarNacionalidad;
        private System.Windows.Forms.Button btnAgregarMunicipio;
    }
}