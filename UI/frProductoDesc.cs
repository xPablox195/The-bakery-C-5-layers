using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frProductoDesc : Form
    {
        public frProductoDesc()
        {
            InitializeComponent();
        }

        DataSet oDataSet = new DataSet();
        DataTable oDataTable = new DataTable();
        DataRow oDataRow;
        List<BEProducto> ListaDeProductosDesconectado = new List<BEProducto>();
        BEProducto oBEProducto = new BEProducto();
        BLLProducto oBLLProducto = new BLLProducto();


        private void frProductoDesc_Load(object sender, EventArgs e)
        {
            comboBoxTipoDeProducto.DataSource = Enum.GetValues(typeof(TipoProducto));
            CrearTablaProductoAdoDesconectado();
        }
        public enum TipoProducto : int
        {
            Dulce = 0,
            Saldo = 1
        }

        public bool CapturarDatosDelFormulario()
        {
            try
            {
                oBEProducto = new BEProducto();
                if (textBoxCodigo.Text != string.Empty && textBoxNombre.Text != string.Empty && textBoxPrecio.Text != string.Empty)
                {
                    oBEProducto.CodProducto = Convert.ToInt32(textBoxCodigo.Text);
                    oBEProducto.Nombre = (textBoxNombre.Text).ToString();
                    oBEProducto.Precio = Convert.ToInt32(textBoxPrecio.Text);
                    oBEProducto.Tipo = comboBoxTipoDeProducto.SelectedValue.ToString();
                    return true;
                }
                else
                {
                    MessageBox.Show("Todos los campos son Obligatorios");
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public void ActualizarDataGridViewProducto()
        {
            this.dataGridViewProducto.DataSource = null;
            this.dataGridViewProducto.DataSource = ListaDeProductosDesconectado;
            this.dataGridViewProducto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dataGridViewProducto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CrearTablaProductoAdoDesconectado()
        {

            oDataTable.TableName = "Producto";
            //Creo la columna CodProducto
            DataColumn CodProducto;
            //Completo la columna 
            CodProducto = new DataColumn("CodProducto", typeof(int));
            //Creo la columna Nombre
            DataColumn Nombre;
            //Completo la columna Nombre
            Nombre = new DataColumn("Nombre", typeof(string));
            Nombre.MaxLength = 50;
            //Agrego las columnas a la tabla 
            //ETC
            DataColumn Tipo;
            Tipo = new DataColumn("Tipo", typeof(string));
            DataColumn Precio;
            Precio = new DataColumn("Precio", typeof(decimal));

            //Agrego las columnas a la tabla
            oDataTable.Columns.Add(CodProducto);
            oDataTable.Columns.Add(Nombre);
            oDataTable.Columns.Add(Tipo);
            oDataTable.Columns.Add(Precio);

            //Determino la clave primaria
            oDataTable.PrimaryKey = new DataColumn[] { CodProducto };
            //Agrego la Tabla al DataSet
            oDataSet.Tables.Add(oDataTable);
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                if (VerificarExistenciaCodP())
                {
                    MessageBox.Show("Ya existe un Producto con este código");
                }
                else
                {
                    if (VerificarExistenciaNombre())
                    {
                        MessageBox.Show("Ya existe un Producto con este Nombre");
                    }
                    else
                    {
                        ListaDeProductosDesconectado.Add(oBEProducto);
                        ActualizarDataGridViewProducto();
                    }

                }


            }

        }

        private void buttonltaBaseDeDatos_Click(object sender, EventArgs e)
        {
            if (ListaDeProductosDesconectado.Count != 0)
            {
                foreach (BEProducto Producto in ListaDeProductosDesconectado)
                {
                    oDataRow = oDataTable.NewRow();
                    oDataRow["CodProducto"] = Producto.CodProducto;
                    oDataRow["Nombre"] = Producto.Nombre;
                    oDataRow["Tipo"] = Producto.Tipo;
                    oDataRow["Precio"] = Producto.Precio;
                    oDataTable.Rows.Add(oDataRow);
                }

                oBLLProducto.AltaProductoDesconectado(oDataSet, 1);
            }

        }

        private void dataGridViewProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                oBEProducto = (BEProducto)dataGridViewProducto.CurrentRow.DataBoundItem;
                this.textBoxCodigo.Text = oBEProducto.CodProducto.ToString();
                this.textBoxNombre.Text = oBEProducto.Nombre.ToString();
                this.textBoxPrecio.Text = oBEProducto.Precio.ToString();
            }
        }

        private void buttonModificacion_Click(object sender, EventArgs e)
        {
            if (ListaDeProductosDesconectado.Count != 0)
            {
                foreach (BEProducto ProductoB in ListaDeProductosDesconectado)
                {
                    if (ProductoB.CodProducto == Convert.ToInt32(textBoxCodigo.Text))
                    {
                        ProductoB.Nombre = textBoxNombre.Text;
                        if (VerificarExistenciaNombre())
                        {
                            MessageBox.Show("Ya existe un producto con este Nombre");
                        }
                        else
                        {
                            ProductoB.Nombre = textBoxNombre.Text;
                            ProductoB.Precio = Convert.ToDecimal(textBoxPrecio.Text);
                            ProductoB.Tipo = comboBoxTipoDeProducto.SelectedValue.ToString();
                            ActualizarDataGridViewProducto();
                        }

                    }
                }
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            if (ListaDeProductosDesconectado.Count != 0)
            {
                List<BEProducto> Lista = new List<BEProducto>();
                foreach (BEProducto ProductoB in ListaDeProductosDesconectado)
                {
                    if (ProductoB.CodProducto != Convert.ToInt32(textBoxCodigo.Text))
                    {

                        Lista.Add(ProductoB);
                    }
                }
                ListaDeProductosDesconectado = Lista;
                Lista.Clear();
                ActualizarDataGridViewProducto();
            }
        }

        public bool VerificarExistenciaCodP()
        {
            if (ListaDeProductosDesconectado.Count != 0)
            {
                foreach (BEProducto ProductoL in ListaDeProductosDesconectado)
                {
                    if (ProductoL.CodProducto == Convert.ToInt32(textBoxCodigo.Text))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool VerificarExistenciaNombre()
        {
            foreach (BEProducto ProductoL in ListaDeProductosDesconectado)
            {
                if (ProductoL.Nombre == textBoxNombre.Text)
                {
                    return true;
                }
            }
            return false;

        }

        private void buttonOrdenarListaDeProductos_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(oDataTable);
            dv.RowFilter = ("Precio < 50");
            dataGridViewProducto.DataSource = null;
            dataGridViewProducto.DataSource = dv;


        }
    }
}
