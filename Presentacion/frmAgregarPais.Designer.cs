namespace Presentacion
{
    partial class frmAgregarPais
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
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtNacionalidadMasc = new System.Windows.Forms.TextBox();
            this.txtNacionalidadFem = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblNacionalidadMasc = new System.Windows.Forms.Label();
            this.lblNacionalidadFem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(102, 31);
            this.txtPais.MaxLength = 20;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(126, 20);
            this.txtPais.TabIndex = 0;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNacionalidad.Location = new System.Drawing.Point(102, 83);
            this.txtNacionalidad.MaxLength = 20;
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(126, 20);
            this.txtNacionalidad.TabIndex = 1;
            // 
            // txtNacionalidadMasc
            // 
            this.txtNacionalidadMasc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNacionalidadMasc.Location = new System.Drawing.Point(102, 135);
            this.txtNacionalidadMasc.MaxLength = 20;
            this.txtNacionalidadMasc.Name = "txtNacionalidadMasc";
            this.txtNacionalidadMasc.Size = new System.Drawing.Size(126, 20);
            this.txtNacionalidadMasc.TabIndex = 2;
            // 
            // txtNacionalidadFem
            // 
            this.txtNacionalidadFem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNacionalidadFem.Location = new System.Drawing.Point(102, 187);
            this.txtNacionalidadFem.MaxLength = 20;
            this.txtNacionalidadFem.Name = "txtNacionalidadFem";
            this.txtNacionalidadFem.Size = new System.Drawing.Size(126, 20);
            this.txtNacionalidadFem.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(138, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 250);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(61, 34);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 6;
            this.lblPais.Text = "Pais:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(19, 86);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.lblNacionalidad.TabIndex = 7;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblNacionalidadMasc
            // 
            this.lblNacionalidadMasc.AutoSize = true;
            this.lblNacionalidadMasc.Location = new System.Drawing.Point(7, 138);
            this.lblNacionalidadMasc.Name = "lblNacionalidadMasc";
            this.lblNacionalidadMasc.Size = new System.Drawing.Size(84, 13);
            this.lblNacionalidadMasc.TabIndex = 8;
            this.lblNacionalidadMasc.Text = "Nac. Masculino:";
            // 
            // lblNacionalidadFem
            // 
            this.lblNacionalidadFem.AutoSize = true;
            this.lblNacionalidadFem.Location = new System.Drawing.Point(9, 190);
            this.lblNacionalidadFem.Name = "lblNacionalidadFem";
            this.lblNacionalidadFem.Size = new System.Drawing.Size(82, 13);
            this.lblNacionalidadFem.TabIndex = 9;
            this.lblNacionalidadFem.Text = "Nac. Femenino:";
            // 
            // frmAgregarPais
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(240, 292);
            this.ControlBox = false;
            this.Controls.Add(this.lblNacionalidadFem);
            this.Controls.Add(this.lblNacionalidadMasc);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNacionalidadFem);
            this.Controls.Add(this.txtNacionalidadMasc);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtPais);
            this.MaximumSize = new System.Drawing.Size(256, 330);
            this.MinimumSize = new System.Drawing.Size(256, 330);
            this.Name = "frmAgregarPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Pais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtNacionalidadMasc;
        private System.Windows.Forms.TextBox txtNacionalidadFem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblNacionalidadMasc;
        private System.Windows.Forms.Label lblNacionalidadFem;
    }
}