using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frProducto : Form
    {
        public frProducto()
        {
            InitializeComponent();
        }

        BEProducto oBEProducto = new BEProducto();
        BLLProducto oBLLProducto = new BLLProducto();

        private void frProducto_Load(object sender, EventArgs e)
        {
            comboBoxTipoDeProducto.DataSource = Enum.GetValues(typeof(TipoProducto));
            ActualizarDataGridViewProducto();
        }

        public enum TipoProducto : int
        {
            Dulce = 0,
            Saldo = 1
        }

        public void ActualizarDataGridViewProducto()
        {
            this.dataGridViewProducto.DataSource = null;
            this.dataGridViewProducto.DataSource = oBLLProducto.LeerListaDeProductos();
            this.dataGridViewProducto.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dataGridViewProducto.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
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

        public bool CapturarDatosDelFormulario()
        {
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
        private void buttonAlta_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                //Se cargaron todos los datos Necesarios
                if (oBLLProducto.VerificarExistenciaProducto(oBEProducto.CodProducto))
                {
                    //DNI Existe en Base de Datos                   
                    MessageBox.Show("Se han ingresado los datos de un Producto \n Existente en la Base de Datos");
                }
                else
                {
                    //DNI no Existe en Base de Datos
                    oBLLProducto.Operacion(oBEProducto, 1);
                    MessageBox.Show("Producto fue dado de ALTA en la Base De Datos");
                    ActualizarDataGridViewProducto();
                }
            }
        }

        private void buttonModificacion_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                //Se cargaron todos los datos Necesarios
                if (oBLLProducto.VerificarExistenciaProducto(oBEProducto.CodProducto))
                {
                    oBLLProducto.Operacion(oBEProducto, 2);
                    MessageBox.Show("Producto fue modificado correctamente en la Base De Datos");
                    ActualizarDataGridViewProducto();

                }
                else
                {
                    MessageBox.Show("Los Productos que se pueden modificar son los del listado \n Haga clic sobre el que desea modificar");
                }
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                //Se cargaron todos los datos Necesarios
                if (oBLLProducto.VerificarExistenciaProducto(oBEProducto.CodProducto))
                {
                    //DNI Existe en Base de Datos  
                    oBLLProducto.Operacion(oBEProducto, 3);
                    MessageBox.Show("Producto fue eliminado correctamente de la Base De Datos");
                    ActualizarDataGridViewProducto();

                }
                else
                {
                    //DNI no Existe en Base de Datos
                    MessageBox.Show("Los Productos que puede borrar son los del listado \n Haga clic sobre el que desea eliminar");
                }
            }
        }

        private void comboBoxTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
