namespace UI
{
    partial class frLocalidad
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
            this.groupBoxLocalidad = new System.Windows.Forms.GroupBox();
            this.buttonIdioma = new System.Windows.Forms.Button();
            this.labelListaLocalidades = new System.Windows.Forms.Label();
            this.labelCodArea = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonModificacion = new System.Windows.Forms.Button();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.dataGridViewLocalidad = new System.Windows.Forms.DataGridView();
            this.textBoxCodArea = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.buttonXmlAl = new System.Windows.Forms.Button();
            this.buttonXmlDocument = new System.Windows.Forms.Button();
            this.buttonXMLBD = new System.Windows.Forms.Button();
            this.groupBoxLocalidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLocalidad
            // 
            this.groupBoxLocalidad.Controls.Add(this.buttonIdioma);
            this.groupBoxLocalidad.Controls.Add(this.labelListaLocalidades);
            this.groupBoxLocalidad.Controls.Add(this.labelCodArea);
            this.groupBoxLocalidad.Controls.Add(this.labelNombre);
            this.groupBoxLocalidad.Controls.Add(this.labelCodigo);
            this.groupBoxLocalidad.Controls.Add(this.buttonSalir);
            this.groupBoxLocalidad.Controls.Add(this.buttonBaja);
            this.groupBoxLocalidad.Controls.Add(this.buttonModificacion);
            this.groupBoxLocalidad.Controls.Add(this.buttonAlta);
            this.groupBoxLocalidad.Controls.Add(this.dataGridViewLocalidad);
            this.groupBoxLocalidad.Controls.Add(this.textBoxCodArea);
            this.groupBoxLocalidad.Controls.Add(this.textBoxNombre);
            this.groupBoxLocalidad.Controls.Add(this.textBoxCodigo);
            this.groupBoxLocalidad.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLocalidad.Name = "groupBoxLocalidad";
            this.groupBoxLocalidad.Size = new System.Drawing.Size(486, 277);
            this.groupBoxLocalidad.TabIndex = 0;
            this.groupBoxLocalidad.TabStop = false;
            this.groupBoxLocalidad.Text = "LOCALIDAD";
            // 
            // buttonIdioma
            // 
            this.buttonIdioma.Location = new System.Drawing.Point(354, 16);
            this.buttonIdioma.Name = "buttonIdioma";
            this.buttonIdioma.Size = new System.Drawing.Size(124, 26);
            this.buttonIdioma.TabIndex = 12;
            this.buttonIdioma.Text = "IDIOMA";
            this.buttonIdioma.UseVisualStyleBackColor = true;
            this.buttonIdioma.Click += new System.EventHandler(this.buttonIdioma_Click);
            // 
            // labelListaLocalidades
            // 
            this.labelListaLocalidades.AutoSize = true;
            this.labelListaLocalidades.Location = new System.Drawing.Point(195, 37);
            this.labelListaLocalidades.Name = "labelListaLocalidades";
            this.labelListaLocalidades.Size = new System.Drawing.Size(132, 13);
            this.labelListaLocalidades.TabIndex = 11;
            this.labelListaLocalidades.Text = "LISTA DE LOCALIDADES";
            // 
            // labelCodArea
            // 
            this.labelCodArea.AutoSize = true;
            this.labelCodArea.Location = new System.Drawing.Point(6, 127);
            this.labelCodArea.Name = "labelCodArea";
            this.labelCodArea.Size = new System.Drawing.Size(99, 13);
            this.labelCodArea.TabIndex = 10;
            this.labelCodArea.Text = "CÓDIGO DE ÁREA";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 81);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 13);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(6, 37);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(49, 13);
            this.labelCodigo.TabIndex = 8;
            this.labelCodigo.Text = "CÓDIGO";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(354, 233);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(125, 38);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(236, 233);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(112, 38);
            this.buttonBaja.TabIndex = 6;
            this.buttonBaja.Text = "BAJA";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // buttonModificacion
            // 
            this.buttonModificacion.Location = new System.Drawing.Point(120, 233);
            this.buttonModificacion.Name = "buttonModificacion";
            this.buttonModificacion.Size = new System.Drawing.Size(110, 38);
            this.buttonModificacion.TabIndex = 5;
            this.buttonModificacion.Text = "MODIFICACIÓN";
            this.buttonModificacion.UseVisualStyleBackColor = true;
            this.buttonModificacion.Click += new System.EventHandler(this.buttonModificacion_Click);
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(6, 233);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(108, 38);
            this.buttonAlta.TabIndex = 4;
            this.buttonAlta.Text = "ALTA";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // dataGridViewLocalidad
            // 
            this.dataGridViewLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalidad.Location = new System.Drawing.Point(198, 53);
            this.dataGridViewLocalidad.Name = "dataGridViewLocalidad";
            this.dataGridViewLocalidad.Size = new System.Drawing.Size(281, 174);
            this.dataGridViewLocalidad.TabIndex = 3;
            this.dataGridViewLocalidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocalidad_CellContentClick);
            // 
            // textBoxCodArea
            // 
            this.textBoxCodArea.Location = new System.Drawing.Point(6, 143);
            this.textBoxCodArea.Name = "textBoxCodArea";
            this.textBoxCodArea.Size = new System.Drawing.Size(172, 20);
            this.textBoxCodArea.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(6, 97);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(172, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(6, 53);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(172, 20);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // buttonXmlAl
            // 
            this.buttonXmlAl.Location = new System.Drawing.Point(504, 114);
            this.buttonXmlAl.Name = "buttonXmlAl";
            this.buttonXmlAl.Size = new System.Drawing.Size(108, 38);
            this.buttonXmlAl.TabIndex = 13;
            this.buttonXmlAl.Text = "XML aleatorio";
            this.buttonXmlAl.UseVisualStyleBackColor = true;
            this.buttonXmlAl.Click += new System.EventHandler(this.buttonXmlAl_Click);
            // 
            // buttonXmlDocument
            // 
            this.buttonXmlDocument.Location = new System.Drawing.Point(504, 158);
            this.buttonXmlDocument.Name = "buttonXmlDocument";
            this.buttonXmlDocument.Size = new System.Drawing.Size(108, 38);
            this.buttonXmlDocument.TabIndex = 14;
            this.buttonXmlDocument.Text = "XML Document";
            this.buttonXmlDocument.UseVisualStyleBackColor = true;
            this.buttonXmlDocument.Click += new System.EventHandler(this.buttonXmlDocument_Click);
            // 
            // buttonXMLBD
            // 
            this.buttonXMLBD.Location = new System.Drawing.Point(504, 201);
            this.buttonXMLBD.Name = "buttonXMLBD";
            this.buttonXMLBD.Size = new System.Drawing.Size(108, 38);
            this.buttonXMLBD.TabIndex = 15;
            this.buttonXMLBD.Text = "XML BD";
            this.buttonXMLBD.UseVisualStyleBackColor = true;
            this.buttonXMLBD.Click += new System.EventHandler(this.buttonXMLBD_Click);
            // 
            // frLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonXMLBD);
            this.Controls.Add(this.buttonXmlDocument);
            this.Controls.Add(this.buttonXmlAl);
            this.Controls.Add(this.groupBoxLocalidad);
            this.Name = "frLocalidad";
            this.Text = "frLocalidad";
            this.Load += new System.EventHandler(this.frLocalidad_Load);
            this.groupBoxLocalidad.ResumeLayout(false);
            this.groupBoxLocalidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLocalidad;
        private System.Windows.Forms.DataGridView dataGridViewLocalidad;
        private System.Windows.Forms.TextBox textBoxCodArea;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodArea;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonModificacion;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Label labelListaLocalidades;
        private System.Windows.Forms.Button buttonIdioma;
        private System.Windows.Forms.Button buttonXmlAl;
        private System.Windows.Forms.Button buttonXmlDocument;
        private System.Windows.Forms.Button buttonXMLBD;
    }
}