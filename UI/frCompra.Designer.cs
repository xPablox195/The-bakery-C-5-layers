namespace UI
{
    partial class frCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.buttonFinalizarCompra = new System.Windows.Forms.Button();
            this.buttonAgregarAlCarrito = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewListaDeProductos = new System.Windows.Forms.DataGridView();
            this.radioButtonTarjetaCredito = new System.Windows.Forms.RadioButton();
            this.radioButtonTarjetaDebito = new System.Windows.Forms.RadioButton();
            this.radioButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxProductos);
            this.groupBox1.Controls.Add(this.buttonFinalizarCompra);
            this.groupBox1.Controls.Add(this.buttonAgregarAlCarrito);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridViewListaDeProductos);
            this.groupBox1.Controls.Add(this.radioButtonTarjetaCredito);
            this.groupBox1.Controls.Add(this.radioButtonTarjetaDebito);
            this.groupBox1.Controls.Add(this.radioButtonEfectivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPRA";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(25, 345);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(299, 55);
            this.buttonSalir.TabIndex = 16;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "PRODUCTOS";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(25, 238);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(299, 21);
            this.comboBoxProductos.TabIndex = 1;
            // 
            // buttonFinalizarCompra
            // 
            this.buttonFinalizarCompra.Location = new System.Drawing.Point(25, 303);
            this.buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            this.buttonFinalizarCompra.Size = new System.Drawing.Size(299, 36);
            this.buttonFinalizarCompra.TabIndex = 13;
            this.buttonFinalizarCompra.Text = "FINALIZAR COMPRA";
            this.buttonFinalizarCompra.UseVisualStyleBackColor = true;
            this.buttonFinalizarCompra.Click += new System.EventHandler(this.buttonFinalizarCompra_Click);
            // 
            // buttonAgregarAlCarrito
            // 
            this.buttonAgregarAlCarrito.Location = new System.Drawing.Point(25, 265);
            this.buttonAgregarAlCarrito.Name = "buttonAgregarAlCarrito";
            this.buttonAgregarAlCarrito.Size = new System.Drawing.Size(299, 32);
            this.buttonAgregarAlCarrito.TabIndex = 12;
            this.buttonAgregarAlCarrito.Text = "AGREGAR AL CARRITO";
            this.buttonAgregarAlCarrito.UseVisualStyleBackColor = true;
            this.buttonAgregarAlCarrito.Click += new System.EventHandler(this.buttonAgregarAlCarrito_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "LISTA DE COMPRA";
            // 
            // dataGridViewListaDeProductos
            // 
            this.dataGridViewListaDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeProductos.Location = new System.Drawing.Point(348, 68);
            this.dataGridViewListaDeProductos.Name = "dataGridViewListaDeProductos";
            this.dataGridViewListaDeProductos.Size = new System.Drawing.Size(422, 332);
            this.dataGridViewListaDeProductos.TabIndex = 10;
            // 
            // radioButtonTarjetaCredito
            // 
            this.radioButtonTarjetaCredito.AutoSize = true;
            this.radioButtonTarjetaCredito.Location = new System.Drawing.Point(25, 141);
            this.radioButtonTarjetaCredito.Name = "radioButtonTarjetaCredito";
            this.radioButtonTarjetaCredito.Size = new System.Drawing.Size(142, 17);
            this.radioButtonTarjetaCredito.TabIndex = 8;
            this.radioButtonTarjetaCredito.TabStop = true;
            this.radioButtonTarjetaCredito.Text = "TARJETA DE CRÉDITO";
            this.radioButtonTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // radioButtonTarjetaDebito
            // 
            this.radioButtonTarjetaDebito.AutoSize = true;
            this.radioButtonTarjetaDebito.Location = new System.Drawing.Point(190, 118);
            this.radioButtonTarjetaDebito.Name = "radioButtonTarjetaDebito";
            this.radioButtonTarjetaDebito.Size = new System.Drawing.Size(134, 17);
            this.radioButtonTarjetaDebito.TabIndex = 7;
            this.radioButtonTarjetaDebito.TabStop = true;
            this.radioButtonTarjetaDebito.Text = "TARJETA DE DEBITO";
            this.radioButtonTarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // radioButtonEfectivo
            // 
            this.radioButtonEfectivo.AutoSize = true;
            this.radioButtonEfectivo.Location = new System.Drawing.Point(25, 118);
            this.radioButtonEfectivo.Name = "radioButtonEfectivo";
            this.radioButtonEfectivo.Size = new System.Drawing.Size(77, 17);
            this.radioButtonEfectivo.TabIndex = 6;
            this.radioButtonEfectivo.TabStop = true;
            this.radioButtonEfectivo.Text = "EFECTIVO";
            this.radioButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MÉTODO DE PAGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(25, 68);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(299, 20);
            this.textBoxDNI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVA COMPRA";
            // 
            // frCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 531);
            this.Controls.Add(this.groupBox1);
            this.Name = "frCompra";
            this.Text = "frCompra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTarjetaCredito;
        private System.Windows.Forms.RadioButton radioButtonTarjetaDebito;
        private System.Windows.Forms.RadioButton radioButtonEfectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewListaDeProductos;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Button buttonFinalizarCompra;
        private System.Windows.Forms.Button buttonAgregarAlCarrito;
    }
}