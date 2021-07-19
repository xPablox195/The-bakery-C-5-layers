namespace UI
{
    partial class frlogin
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
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonNuevoUsuario = new System.Windows.Forms.Button();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonIdioma = new System.Windows.Forms.Button();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonIdioma);
            this.groupBoxLogin.Controls.Add(this.buttonNuevoUsuario);
            this.groupBoxLogin.Controls.Add(this.textBoxContraseña);
            this.groupBoxLogin.Controls.Add(this.textBoxNombreDeUsuario);
            this.groupBoxLogin.Controls.Add(this.labelContraseña);
            this.groupBoxLogin.Controls.Add(this.labelNombre);
            this.groupBoxLogin.Controls.Add(this.buttonSalir);
            this.groupBoxLogin.Controls.Add(this.buttonIngresar);
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(382, 206);
            this.groupBoxLogin.TabIndex = 1;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "LOGIN";
            // 
            // buttonNuevoUsuario
            // 
            this.buttonNuevoUsuario.Location = new System.Drawing.Point(207, 9);
            this.buttonNuevoUsuario.Name = "buttonNuevoUsuario";
            this.buttonNuevoUsuario.Size = new System.Drawing.Size(161, 22);
            this.buttonNuevoUsuario.TabIndex = 8;
            this.buttonNuevoUsuario.Text = "NUEVO USUARIO";
            this.buttonNuevoUsuario.UseVisualStyleBackColor = true;
            this.buttonNuevoUsuario.Visible = false;
            this.buttonNuevoUsuario.Click += new System.EventHandler(this.buttonNuevoUsuario_Click);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(10, 86);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(358, 20);
            this.textBoxContraseña.TabIndex = 7;
            // 
            // textBoxNombreDeUsuario
            // 
            this.textBoxNombreDeUsuario.Location = new System.Drawing.Point(10, 37);
            this.textBoxNombreDeUsuario.Name = "textBoxNombreDeUsuario";
            this.textBoxNombreDeUsuario.Size = new System.Drawing.Size(358, 20);
            this.textBoxNombreDeUsuario.TabIndex = 6;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(7, 70);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(81, 13);
            this.labelContraseña.TabIndex = 5;
            this.labelContraseña.Text = "CONTRASEÑA";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(7, 21);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(124, 13);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "NOMBRE DE USUARIO";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(192, 132);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(176, 33);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(10, 132);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(176, 33);
            this.buttonIngresar.TabIndex = 1;
            this.buttonIngresar.Text = "INGRESAR";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonIdioma
            // 
            this.buttonIdioma.Location = new System.Drawing.Point(192, 171);
            this.buttonIdioma.Name = "buttonIdioma";
            this.buttonIdioma.Size = new System.Drawing.Size(176, 22);
            this.buttonIdioma.TabIndex = 9;
            this.buttonIdioma.Text = "IDIOMA";
            this.buttonIdioma.UseVisualStyleBackColor = true;
            this.buttonIdioma.Click += new System.EventHandler(this.buttonIdioma_Click);
            // 
            // frlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "frlogin";
            this.Text = "frlogin";
            this.Load += new System.EventHandler(this.frlogin_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxNombreDeUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonNuevoUsuario;
        private System.Windows.Forms.Button buttonIdioma;
    }
}