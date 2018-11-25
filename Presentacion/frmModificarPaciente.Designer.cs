namespace Presentacion
{
    partial class frmModificarPaciente
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
            this.lblTelMovil = new System.Windows.Forms.Label();
            this.lblTelFijo = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblPisoDto = new System.Windows.Forms.Label();
            this.lblNumeroCalle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet6 = new Presentacion.LOBOS_DBDataSet6();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.vWNACIONALIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet7 = new Presentacion.LOBOS_DBDataSet7();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.lblBarra = new System.Windows.Forms.Label();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.cboMunicipio = new System.Windows.Forms.ComboBox();
            this.vWMUNICIPIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet8 = new Presentacion.LOBOS_DBDataSet8();
            this.txtTelMovil = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelFijo = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarSexo = new System.Windows.Forms.Button();
            this.btnAgregarNacionalidad = new System.Windows.Forms.Button();
            this.btnAgregarMunicipio = new System.Windows.Forms.Button();
            this.sexoTableAdapter = new Presentacion.LOBOS_DBDataSet6TableAdapters.SexoTableAdapter();
            this.vW_NACIONALIDADTableAdapter = new Presentacion.LOBOS_DBDataSet7TableAdapters.VW_NACIONALIDADTableAdapter();
            this.vW_MUNICIPIOSTableAdapter = new Presentacion.LOBOS_DBDataSet8TableAdapters.VW_MUNICIPIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWNACIONALIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMUNICIPIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTelMovil
            // 
            this.lblTelMovil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelMovil.AutoSize = true;
            this.lblTelMovil.Location = new System.Drawing.Point(143, 374);
            this.lblTelMovil.Name = "lblTelMovil";
            this.lblTelMovil.Size = new System.Drawing.Size(69, 13);
            this.lblTelMovil.TabIndex = 43;
            this.lblTelMovil.Text = "TEL. MOVIL:";
            // 
            // lblTelFijo
            // 
            this.lblTelFijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelFijo.AutoSize = true;
            this.lblTelFijo.Location = new System.Drawing.Point(415, 374);
            this.lblTelFijo.Name = "lblTelFijo";
            this.lblTelFijo.Size = new System.Drawing.Size(58, 13);
            this.lblTelFijo.TabIndex = 42;
            this.lblTelFijo.Text = "TEL. FIJO:";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(167, 345);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 13);
            this.lblMail.TabIndex = 41;
            this.lblMail.Text = "E-MAIL:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(146, 304);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(66, 13);
            this.lblMunicipio.TabIndex = 39;
            this.lblMunicipio.Text = "MUNICIPIO:";
            // 
            // lblPisoDto
            // 
            this.lblPisoDto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPisoDto.AutoSize = true;
            this.lblPisoDto.Location = new System.Drawing.Point(129, 272);
            this.lblPisoDto.Name = "lblPisoDto";
            this.lblPisoDto.Size = new System.Drawing.Size(83, 13);
            this.lblPisoDto.TabIndex = 38;
            this.lblPisoDto.Text = "PISO / DEPTO:";
            // 
            // lblNumeroCalle
            // 
            this.lblNumeroCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroCalle.AutoSize = true;
            this.lblNumeroCalle.Location = new System.Drawing.Point(465, 240);
            this.lblNumeroCalle.Name = "lblNumeroCalle";
            this.lblNumeroCalle.Size = new System.Drawing.Size(34, 13);
            this.lblNumeroCalle.TabIndex = 37;
            this.lblNumeroCalle.Text = "NRO:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "CALLE:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(79, 211);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(133, 13);
            this.lblFechaNacimiento.TabIndex = 35;
            this.lblFechaNacimiento.Text = "FECHA DE NACIMIENTO:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(122, 175);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(90, 13);
            this.lblNacionalidad.TabIndex = 34;
            this.lblNacionalidad.Text = "NACIONALIDAD:";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(173, 142);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 13);
            this.lblSexo.TabIndex = 33;
            this.lblSexo.Text = "SEXO:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(155, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(150, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 13);
            this.lblApellido.TabIndex = 31;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // lblDni
            // 
            this.lblDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(183, 46);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 30;
            this.lblDni.Text = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(218, 107);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(285, 20);
            this.txtNombre.TabIndex = 46;
            // 
            // txtApellido
            // 
            this.txtApellido.AllowDrop = true;
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(218, 75);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(285, 20);
            this.txtApellido.TabIndex = 45;
            // 
            // txtDni
            // 
            this.txtDni.AllowDrop = true;
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(218, 43);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(210, 20);
            this.txtDni.TabIndex = 44;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // cboSexo
            // 
            this.cboSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSexo.DataSource = this.sexoBindingSource;
            this.cboSexo.DisplayMember = "Sexo";
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(218, 139);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(121, 21);
            this.cboSexo.TabIndex = 47;
            this.cboSexo.ValueMember = "Idsexo";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.lOBOS_DBDataSet6;
            // 
            // lOBOS_DBDataSet6
            // 
            this.lOBOS_DBDataSet6.DataSetName = "LOBOS_DBDataSet6";
            this.lOBOS_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCalle
            // 
            this.txtCalle.AllowDrop = true;
            this.txtCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(218, 237);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(241, 20);
            this.txtCalle.TabIndex = 50;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(218, 205);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2018, 9, 20, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaNacimiento.TabIndex = 49;
            this.dtpFechaNacimiento.Value = new System.DateTime(2018, 9, 20, 0, 0, 0, 0);
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboNacionalidad.DataSource = this.vWNACIONALIDADBindingSource;
            this.cboNacionalidad.DisplayMember = "NACIONALIDAD";
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(218, 172);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(178, 21);
            this.cboNacionalidad.TabIndex = 48;
            this.cboNacionalidad.ValueMember = "IdPais";
            // 
            // vWNACIONALIDADBindingSource
            // 
            this.vWNACIONALIDADBindingSource.DataMember = "VW_NACIONALIDAD";
            this.vWNACIONALIDADBindingSource.DataSource = this.lOBOS_DBDataSet7;
            // 
            // lOBOS_DBDataSet7
            // 
            this.lOBOS_DBDataSet7.DataSetName = "LOBOS_DBDataSet7";
            this.lOBOS_DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumero
            // 
            this.txtNumero.AllowDrop = true;
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(505, 237);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 51;
            // 
            // txtPiso
            // 
            this.txtPiso.AllowDrop = true;
            this.txtPiso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPiso.Location = new System.Drawing.Point(218, 269);
            this.txtPiso.MaxLength = 10;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(77, 20);
            this.txtPiso.TabIndex = 52;
            // 
            // lblBarra
            // 
            this.lblBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarra.AutoSize = true;
            this.lblBarra.Location = new System.Drawing.Point(301, 272);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(12, 13);
            this.lblBarra.TabIndex = 53;
            this.lblBarra.Text = "/";
            // 
            // txtDepto
            // 
            this.txtDepto.AllowDrop = true;
            this.txtDepto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepto.Location = new System.Drawing.Point(319, 269);
            this.txtDepto.MaxLength = 10;
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(77, 20);
            this.txtDepto.TabIndex = 54;
            // 
            // cboMunicipio
            // 
            this.cboMunicipio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMunicipio.DataSource = this.vWMUNICIPIOSBindingSource;
            this.cboMunicipio.DisplayMember = "MUNICIPIOS";
            this.cboMunicipio.FormattingEnabled = true;
            this.cboMunicipio.Location = new System.Drawing.Point(218, 301);
            this.cboMunicipio.Name = "cboMunicipio";
            this.cboMunicipio.Size = new System.Drawing.Size(439, 21);
            this.cboMunicipio.TabIndex = 55;
            this.cboMunicipio.ValueMember = "IDMUNICIPIO";
            // 
            // vWMUNICIPIOSBindingSource
            // 
            this.vWMUNICIPIOSBindingSource.DataMember = "VW_MUNICIPIOS";
            this.vWMUNICIPIOSBindingSource.DataSource = this.lOBOS_DBDataSet8;
            // 
            // lOBOS_DBDataSet8
            // 
            this.lOBOS_DBDataSet8.DataSetName = "LOBOS_DBDataSet8";
            this.lOBOS_DBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTelMovil
            // 
            this.txtTelMovil.AccessibleDescription = "";
            this.txtTelMovil.AccessibleName = "";
            this.txtTelMovil.AllowDrop = true;
            this.txtTelMovil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelMovil.Location = new System.Drawing.Point(218, 371);
            this.txtTelMovil.MaxLength = 14;
            this.txtTelMovil.Name = "txtTelMovil";
            this.txtTelMovil.Size = new System.Drawing.Size(191, 20);
            this.txtTelMovil.TabIndex = 58;
            // 
            // txtMail
            // 
            this.txtMail.AllowDrop = true;
            this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMail.Location = new System.Drawing.Point(218, 339);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(285, 20);
            this.txtMail.TabIndex = 57;
            // 
            // txtTelFijo
            // 
            this.txtTelFijo.AllowDrop = true;
            this.txtTelFijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelFijo.Location = new System.Drawing.Point(479, 371);
            this.txtTelFijo.MaxLength = 14;
            this.txtTelFijo.Name = "txtTelFijo";
            this.txtTelFijo.Size = new System.Drawing.Size(178, 20);
            this.txtTelFijo.TabIndex = 59;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(224, 465);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(115, 43);
            this.btnGrabar.TabIndex = 60;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(468, 465);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 43);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarSexo
            // 
            this.btnAgregarSexo.Location = new System.Drawing.Point(345, 139);
            this.btnAgregarSexo.Name = "btnAgregarSexo";
            this.btnAgregarSexo.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarSexo.TabIndex = 62;
            this.btnAgregarSexo.Text = "+";
            this.btnAgregarSexo.UseVisualStyleBackColor = true;
            this.btnAgregarSexo.Click += new System.EventHandler(this.btnAgregarSexo_Click);
            // 
            // btnAgregarNacionalidad
            // 
            this.btnAgregarNacionalidad.Location = new System.Drawing.Point(402, 172);
            this.btnAgregarNacionalidad.Name = "btnAgregarNacionalidad";
            this.btnAgregarNacionalidad.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarNacionalidad.TabIndex = 63;
            this.btnAgregarNacionalidad.Text = "+";
            this.btnAgregarNacionalidad.UseVisualStyleBackColor = true;
            this.btnAgregarNacionalidad.Click += new System.EventHandler(this.btnAgregarNacionalidad_Click);
            // 
            // btnAgregarMunicipio
            // 
            this.btnAgregarMunicipio.Location = new System.Drawing.Point(663, 301);
            this.btnAgregarMunicipio.Name = "btnAgregarMunicipio";
            this.btnAgregarMunicipio.Size = new System.Drawing.Size(25, 21);
            this.btnAgregarMunicipio.TabIndex = 64;
            this.btnAgregarMunicipio.Text = "+";
            this.btnAgregarMunicipio.UseVisualStyleBackColor = true;
            this.btnAgregarMunicipio.Click += new System.EventHandler(this.btnAgregarMunicipio_Click);
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
            // frmModificarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.Controls.Add(this.btnAgregarMunicipio);
            this.Controls.Add(this.btnAgregarNacionalidad);
            this.Controls.Add(this.btnAgregarSexo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtTelFijo);
            this.Controls.Add(this.cboMunicipio);
            this.Controls.Add(this.txtTelMovil);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cboNacionalidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblTelMovil);
            this.Controls.Add(this.lblTelFijo);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblPisoDto);
            this.Controls.Add(this.lblNumeroCalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.MaximumSize = new System.Drawing.Size(800, 622);
            this.MinimumSize = new System.Drawing.Size(800, 622);
            this.Name = "frmModificarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Paciente";
            this.Load += new System.EventHandler(this.frmModificarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWNACIONALIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWMUNICIPIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelMovil;
        private System.Windows.Forms.Label lblTelFijo;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblPisoDto;
        private System.Windows.Forms.Label lblNumeroCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cboNacionalidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.ComboBox cboMunicipio;
        private System.Windows.Forms.TextBox txtTelMovil;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelFijo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarSexo;
        private System.Windows.Forms.Button btnAgregarNacionalidad;
        private System.Windows.Forms.Button btnAgregarMunicipio;
        private LOBOS_DBDataSet6 lOBOS_DBDataSet6;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private LOBOS_DBDataSet6TableAdapters.SexoTableAdapter sexoTableAdapter;
        private LOBOS_DBDataSet7 lOBOS_DBDataSet7;
        private System.Windows.Forms.BindingSource vWNACIONALIDADBindingSource;
        private LOBOS_DBDataSet7TableAdapters.VW_NACIONALIDADTableAdapter vW_NACIONALIDADTableAdapter;
        private LOBOS_DBDataSet8 lOBOS_DBDataSet8;
        private System.Windows.Forms.BindingSource vWMUNICIPIOSBindingSource;
        private LOBOS_DBDataSet8TableAdapters.VW_MUNICIPIOSTableAdapter vW_MUNICIPIOSTableAdapter;
    }
}