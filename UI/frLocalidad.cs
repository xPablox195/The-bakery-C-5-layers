using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using BE;

namespace UI
{
    public partial class frLocalidad : Form
    {
        public frLocalidad()
        {
            InitializeComponent();
        }
        BELocalidad oBELocalidad = new BELocalidad();
        BLLLocalidad oBLLLocalidad = new BLLLocalidad();
        int multilenguaje = 0;
       
        private void frLocalidad_Load(object sender, EventArgs e)
        {
            ActualizarDataGridViewLocalidades();
        }

        public void ActualizarDataGridViewLocalidades()
        {
            this.dataGridViewLocalidad.DataSource = null;
            this.dataGridViewLocalidad.DataSource = oBLLLocalidad.LeerListaDeLocalidades();
            this.dataGridViewLocalidad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dataGridViewLocalidad.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewLocalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                oBELocalidad = (BELocalidad)dataGridViewLocalidad.CurrentRow.DataBoundItem;
                this.textBoxCodigo.Text = oBELocalidad.CodLocalidad.ToString();
                this.textBoxNombre.Text = oBELocalidad.Nombre.ToString();
                this.textBoxCodArea.Text = oBELocalidad.CodArea.ToString();
            }
        }

        public bool CapturarDatosDelFormulario()
        {
            try
            {
                if (textBoxCodigo.Text != string.Empty && textBoxNombre.Text != string.Empty && textBoxCodArea.Text != string.Empty)
                {
                    Regex oRegexCodArea = new Regex("^\\d{4}|\\d{3}$");
                    Regex oRegexCod = new Regex("^\\d");
                    if (oRegexCod.IsMatch(textBoxCodigo.Text))
                    {
                        if (oRegexCodArea.IsMatch(textBoxCodArea.Text))
                    {
                            oBELocalidad.CodLocalidad = Convert.ToInt32(textBoxCodigo.Text);
                            oBELocalidad.Nombre = textBoxNombre.Text.ToString();
                            oBELocalidad.CodArea = Convert.ToInt32(textBoxCodArea.Text);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Los códigos de Area de la Provincia de Bs As \n" +
                                "Tienen un Mínimo de 3 (tres) caracteres numéricos y \n" +
                                "un Máximo de 4 (cuatro)");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Código de Localidad debe ser numérico");
                        return false;
                    }
                   

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

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                //Se cargaron todos los datos Necesarios
                if (oBLLLocalidad.VerificarExistenciaLocalidad(oBELocalidad.CodLocalidad))
                {
                    //DNI Existe en Base de Datos                   
                    MessageBox.Show("Se han ingresado los datos de una Localidad \n Existente en la Base de Datos");
                }
                else
                {
                    //DNI no Existe en Base de Datos
                    oBLLLocalidad.Operacion(oBELocalidad, 1);
                    MessageBox.Show("Localidad fue dada de ALTA en la Base De Datos");
                    ActualizarDataGridViewLocalidades();
                    Limpiar();
                }
            }
        }

        private void buttonModificacion_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                //Se cargaron todos los datos Necesarios
                if (oBLLLocalidad.VerificarExistenciaLocalidad(oBELocalidad.CodLocalidad))
                {
                    oBLLLocalidad.Operacion(oBELocalidad, 2);
                    MessageBox.Show("Loclaidad fue modificado correctamente en la Base De Datos");
                    ActualizarDataGridViewLocalidades();

                }
                else
                {
                    MessageBox.Show("Las Localidades que se pueden modificar son los del listado \n Haga clic sobre el que desea modificar");
                }
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                //Se cargaron todos los datos Necesarios
                if (oBLLLocalidad.VerificarExistenciaLocalidad(oBELocalidad.CodLocalidad))
                {
                    //DNI Existe en Base de Datos  
                    oBLLLocalidad.Operacion(oBELocalidad, 3);
                    MessageBox.Show("Localidad fue eliminado correctamente de la Base De Datos");
                    ActualizarDataGridViewLocalidades();

                }
                else
                {
                    //DNI no Existe en Base de Datos
                    MessageBox.Show("Las Localidad que puede borrar son los del listado \n Haga clic sobre el que desea eliminar");
                }
            }
        }

        public void Limpiar()
        {
            textBoxCodigo.Text = string.Empty;
            textBoxCodArea.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
        }

        public void getText()
        {
            groupBoxLocalidad.Text = Res.LOCALIDAD;
            labelNombre.Text = Res.NOMBRE;
            labelCodigo.Text = Res.CÓDIGO;
            labelCodArea.Text = Res.CÓDIGO_DE_AREA;
            buttonAlta.Text = Res.ALTA;
            buttonBaja.Text = Res.BAJA;
            buttonIdioma.Text = Res.IDIOMA;
            buttonModificacion.Text = Res.MODIFICACIÓN;
            buttonSalir.Text = Res.SALIR;
            labelListaLocalidades.Text = Res.LISTA_DE_LOCALIDADES;
            
        }

        private void buttonIdioma_Click(object sender, EventArgs e)
        {
            if(multilenguaje == 0)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                multilenguaje = 1;
                getText();
            }
            else
            {
                multilenguaje = 0;
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("");
                getText();
            }
         
        }

        private void buttonXmlAl_Click(object sender, EventArgs e)
        {
            oBLLLocalidad.CrearXML();
        }

        private void buttonXmlDocument_Click(object sender, EventArgs e)
        {
            oBLLLocalidad.CrearDocumentoXML();
        }

        private void buttonXMLBD_Click(object sender, EventArgs e)
        {
            oBLLLocalidad.CrearDocumentoXMLLocalidades();
        }
    }
}
