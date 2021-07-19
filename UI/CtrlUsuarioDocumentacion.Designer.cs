namespace UI
{
    partial class CtrlUsuarioDocumentacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonAlumno = new System.Windows.Forms.RadioButton();
            this.radioButtonInformacionDelProyecto = new System.Windows.Forms.RadioButton();
            this.labelInformacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonAlumno
            // 
            this.radioButtonAlumno.AutoSize = true;
            this.radioButtonAlumno.Location = new System.Drawing.Point(17, 16);
            this.radioButtonAlumno.Name = "radioButtonAlumno";
            this.radioButtonAlumno.Size = new System.Drawing.Size(71, 17);
            this.radioButtonAlumno.TabIndex = 0;
            this.radioButtonAlumno.TabStop = true;
            this.radioButtonAlumno.Text = "ALUMNO";
            this.radioButtonAlumno.UseVisualStyleBackColor = true;
            this.radioButtonAlumno.CheckedChanged += new System.EventHandler(this.radioButtonAlumno_CheckedChanged);
            // 
            // radioButtonInformacionDelProyecto
            // 
            this.radioButtonInformacionDelProyecto.AutoSize = true;
            this.radioButtonInformacionDelProyecto.Location = new System.Drawing.Point(17, 48);
            this.radioButtonInformacionDelProyecto.Name = "radioButtonInformacionDelProyecto";
            this.radioButtonInformacionDelProyecto.Size = new System.Drawing.Size(186, 17);
            this.radioButtonInformacionDelProyecto.TabIndex = 1;
            this.radioButtonInformacionDelProyecto.TabStop = true;
            this.radioButtonInformacionDelProyecto.Text = "INFORMACIÓN DEL PROYECTO";
            this.radioButtonInformacionDelProyecto.UseVisualStyleBackColor = true;
            this.radioButtonInformacionDelProyecto.CheckedChanged += new System.EventHandler(this.radioButtonInformacionDelProyecto_CheckedChanged);
            // 
            // labelInformacion
            // 
            this.labelInformacion.AutoSize = true;
            this.labelInformacion.Location = new System.Drawing.Point(22, 89);
            this.labelInformacion.Name = "labelInformacion";
            this.labelInformacion.Size = new System.Drawing.Size(181, 13);
            this.labelInformacion.TabIndex = 2;
            this.labelInformacion.Text = "----------------------------------------------------------";
            // 
            // CtrlUsuarioDocumentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelInformacion);
            this.Controls.Add(this.radioButtonInformacionDelProyecto);
            this.Controls.Add(this.radioButtonAlumno);
            this.Name = "CtrlUsuarioDocumentacion";
            this.Size = new System.Drawing.Size(835, 331);
            this.Load += new System.EventHandler(this.CtrlUsuarioDocumentacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAlumno;
        private System.Windows.Forms.RadioButton radioButtonInformacionDelProyecto;
        private System.Windows.Forms.Label labelInformacion;
    }
}
