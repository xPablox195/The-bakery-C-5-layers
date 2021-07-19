namespace UI
{
    partial class frDocumentacion
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
            this.buttonCtrlUsuario = new System.Windows.Forms.Button();
            this.panelMuestra = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCtrlUsuario
            // 
            this.buttonCtrlUsuario.Location = new System.Drawing.Point(12, 12);
            this.buttonCtrlUsuario.Name = "buttonCtrlUsuario";
            this.buttonCtrlUsuario.Size = new System.Drawing.Size(158, 38);
            this.buttonCtrlUsuario.TabIndex = 0;
            this.buttonCtrlUsuario.Text = "Control de Usuario";
            this.buttonCtrlUsuario.UseVisualStyleBackColor = true;
            this.buttonCtrlUsuario.Click += new System.EventHandler(this.buttonCtrlUsuario_Click);
            // 
            // panelMuestra
            // 
            this.panelMuestra.Location = new System.Drawing.Point(12, 56);
            this.panelMuestra.Name = "panelMuestra";
            this.panelMuestra.Size = new System.Drawing.Size(437, 291);
            this.panelMuestra.TabIndex = 1;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(176, 12);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(158, 38);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // frDocumentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.panelMuestra);
            this.Controls.Add(this.buttonCtrlUsuario);
            this.Name = "frDocumentacion";
            this.Text = "frDocumentación";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCtrlUsuario;
        private System.Windows.Forms.Panel panelMuestra;
        private System.Windows.Forms.Button buttonSalir;
    }
}