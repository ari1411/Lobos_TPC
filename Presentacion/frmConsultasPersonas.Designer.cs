namespace Presentacion
{
    partial class frmConsultasPersonas
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
            this.btnVolverBPers = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombreBPers = new System.Windows.Forms.TextBox();
            this.txtApellidoBPers = new System.Windows.Forms.TextBox();
            this.btnBuscarBPers = new System.Windows.Forms.Button();
            this.txtDniBPers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolverBPers
            // 
            this.btnVolverBPers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolverBPers.Location = new System.Drawing.Point(585, 442);
            this.btnVolverBPers.Name = "btnVolverBPers";
            this.btnVolverBPers.Size = new System.Drawing.Size(187, 58);
            this.btnVolverBPers.TabIndex = 15;
            this.btnVolverBPers.Text = "Volver";
            this.btnVolverBPers.UseVisualStyleBackColor = true;
            this.btnVolverBPers.Click += new System.EventHandler(this.btnVolverBPers_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(245, 227);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(240, 181);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(273, 135);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 12;
            this.lblDni.Text = "DNI:";
            // 
            // txtNombreBPers
            // 
            this.txtNombreBPers.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBPers.Location = new System.Drawing.Point(314, 224);
            this.txtNombreBPers.Name = "txtNombreBPers";
            this.txtNombreBPers.Size = new System.Drawing.Size(191, 20);
            this.txtNombreBPers.TabIndex = 10;
            // 
            // txtApellidoBPers
            // 
            this.txtApellidoBPers.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoBPers.Location = new System.Drawing.Point(314, 178);
            this.txtApellidoBPers.Name = "txtApellidoBPers";
            this.txtApellidoBPers.Size = new System.Drawing.Size(191, 20);
            this.txtApellidoBPers.TabIndex = 9;
            // 
            // btnBuscarBPers
            // 
            this.btnBuscarBPers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscarBPers.Location = new System.Drawing.Point(330, 279);
            this.btnBuscarBPers.Name = "btnBuscarBPers";
            this.btnBuscarBPers.Size = new System.Drawing.Size(131, 52);
            this.btnBuscarBPers.TabIndex = 11;
            this.btnBuscarBPers.Text = "Buscar";
            this.btnBuscarBPers.UseVisualStyleBackColor = true;
            this.btnBuscarBPers.Click += new System.EventHandler(this.btnBuscarBPers_Click);
            // 
            // txtDniBPers
            // 
            this.txtDniBPers.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDniBPers.Location = new System.Drawing.Point(314, 132);
            this.txtDniBPers.Name = "txtDniBPers";
            this.txtDniBPers.Size = new System.Drawing.Size(191, 20);
            this.txtDniBPers.TabIndex = 8;
            // 
            // frmConsultasPersonas
            // 
            this.AcceptButton = this.btnBuscarBPers;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolverBPers;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnVolverBPers);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtNombreBPers);
            this.Controls.Add(this.txtApellidoBPers);
            this.Controls.Add(this.btnBuscarBPers);
            this.Controls.Add(this.txtDniBPers);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmConsultasPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverBPers;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombreBPers;
        private System.Windows.Forms.TextBox txtApellidoBPers;
        private System.Windows.Forms.Button btnBuscarBPers;
        private System.Windows.Forms.TextBox txtDniBPers;
    }
}