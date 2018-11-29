namespace Presentacion
{
    partial class frmPerfilProfesional
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
            this.cboProfesionalLogueado = new System.Windows.Forms.ComboBox();
            this.vWPROFESIONALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOBOS_DBDataSet19 = new Presentacion.LOBOS_DBDataSet19();
            this.vW_PROFESIONALESTableAdapter = new Presentacion.LOBOS_DBDataSet19TableAdapters.VW_PROFESIONALESTableAdapter();
            this.lblprofesionalLogueado = new System.Windows.Forms.Label();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vWPROFESIONALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProfesionalLogueado
            // 
            this.cboProfesionalLogueado.DataSource = this.vWPROFESIONALESBindingSource;
            this.cboProfesionalLogueado.DisplayMember = "Apellido y Nombre";
            this.cboProfesionalLogueado.FormattingEnabled = true;
            this.cboProfesionalLogueado.Location = new System.Drawing.Point(80, 12);
            this.cboProfesionalLogueado.Name = "cboProfesionalLogueado";
            this.cboProfesionalLogueado.Size = new System.Drawing.Size(218, 21);
            this.cboProfesionalLogueado.TabIndex = 0;
            this.cboProfesionalLogueado.ValueMember = "IdProfesional";
            // 
            // vWPROFESIONALESBindingSource
            // 
            this.vWPROFESIONALESBindingSource.DataMember = "VW_PROFESIONALES";
            this.vWPROFESIONALESBindingSource.DataSource = this.lOBOS_DBDataSet19;
            // 
            // lOBOS_DBDataSet19
            // 
            this.lOBOS_DBDataSet19.DataSetName = "LOBOS_DBDataSet19";
            this.lOBOS_DBDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vW_PROFESIONALESTableAdapter
            // 
            this.vW_PROFESIONALESTableAdapter.ClearBeforeFill = true;
            // 
            // lblprofesionalLogueado
            // 
            this.lblprofesionalLogueado.AutoSize = true;
            this.lblprofesionalLogueado.Location = new System.Drawing.Point(12, 15);
            this.lblprofesionalLogueado.Name = "lblprofesionalLogueado";
            this.lblprofesionalLogueado.Size = new System.Drawing.Size(62, 13);
            this.lblprofesionalLogueado.TabIndex = 1;
            this.lblprofesionalLogueado.Text = "Profesional:";
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(129, 126);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(178, 75);
            this.btnAtender.TabIndex = 2;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(474, 126);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(178, 75);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(298, 265);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(178, 75);
            this.btnAgenda.TabIndex = 4;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(652, 450);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 50);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmSeleccionPerfilProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.lblprofesionalLogueado);
            this.Controls.Add(this.cboProfesionalLogueado);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "frmSeleccionPerfilProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profesional";
            this.Load += new System.EventHandler(this.frmSeleccionPerfilMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWPROFESIONALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOBOS_DBDataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProfesionalLogueado;
        private LOBOS_DBDataSet19 lOBOS_DBDataSet19;
        private System.Windows.Forms.BindingSource vWPROFESIONALESBindingSource;
        private LOBOS_DBDataSet19TableAdapters.VW_PROFESIONALESTableAdapter vW_PROFESIONALESTableAdapter;
        private System.Windows.Forms.Label lblprofesionalLogueado;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}