using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class frCompra : Form
    {
        public frCompra()
        {
            InitializeComponent();
        }

        BECliente oBECliente = new BECliente();
        BLLProducto oBLLProdcto = new BLLProducto();
        BLLCliente oBLLCliente = new BLLCliente();
        List<BEProducto> ListaDeProductosChango = new List<BEProducto>();
        BLLPersonaProducto oBLLPersonaProducto = new BLLPersonaProducto();
        BEPersonaProducto oBEPersonaProducto = new BEPersonaProducto();

        private void frCompra_Load(object sender, EventArgs e)
        {
            radioButtonEfectivo.Checked = true;
            CargarCOmboBoxProducto();
        }



        public void CargarCOmboBoxProducto()
        {
            comboBoxProductos.DataSource = null;
            comboBoxProductos.DataSource = oBLLProdcto.LeerListaDeProductos();
            comboBoxProductos.ValueMember = "CodProducto";
            comboBoxProductos.DisplayMember = "Nombre";
            comboBoxProductos.Refresh();
        }

        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            ListaDeProductosChango.Add((BEProducto)this.comboBoxProductos.SelectedItem);
            ActualizarDataGridViewProducto();
        }

        public void ActualizarDataGridViewProducto()
        {
            this.dataGridViewListaDeProductos.DataSource = null;
            this.dataGridViewListaDeProductos.DataSource = ListaDeProductosChango;
            this.dataGridViewListaDeProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dataGridViewListaDeProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        public void Limpiar()
        {
            textBoxDNI.Text = "";
            dataGridViewListaDeProductos.DataSource = null;
            ListaDeProductosChango.Clear();
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text != string.Empty)
            {

                CapturarDatosDelFormulario();
                oBLLCliente.Operacion(oBECliente, 1);//Gardar Cliente en Tabla Persona en BD
                oBECliente = oBLLCliente.LeerClienteFiltradoPorDNI(Convert.ToInt32(textBoxDNI.Text)); //Buscar el Cliente en la BD, con el fin de obtener el CodPersona correspondiente
                if(ListaDeProductosChango.Count != 0)
                {
                    oBEPersonaProducto.CodPersona = oBECliente.CodPersona;
                    foreach (BEProducto Producto in ListaDeProductosChango)
                    {
                        oBEPersonaProducto.CodProducto = Producto.CodProducto;
                        oBLLPersonaProducto.Operacion(oBEPersonaProducto, 1);
                    }
                }
                Limpiar();
            }
          
        }

        public string MetodoDePagoRadioButton()
        {
            if (radioButtonTarjetaDebito.Checked == true)
            {
                return "Tarjeta De Debito";
            }
            if (radioButtonTarjetaCredito.Checked == true)
            {
                return "Tarjeta De Credito";
            }
            return "Efectivo";
        }

        public decimal CalcularMontoTotal()
        {
            decimal MontoT = 0;
            if (ListaDeProductosChango.Count != 0)
            {
               
                foreach(BEProducto oBEProducto in ListaDeProductosChango)
                {
                    MontoT += oBEProducto.Precio;
                }
            }
            return MontoT;
        }

        public void CapturarDatosDelFormulario()
        {
            try
            {
                oBECliente.DNI = Convert.ToInt32(textBoxDNI.Text);
                oBECliente.MétodoDePago = MetodoDePagoRadioButton();
                oBECliente.TotalCompra = CalcularMontoTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
