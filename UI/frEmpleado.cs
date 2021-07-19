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
using System.Text.RegularExpressions;

namespace UI
{
    public partial class frEmpleado : Form
    {
        public frEmpleado()
        {
            InitializeComponent();
        }
        private void frEmpleado_Load(object sender, EventArgs e)
        {
            CargarComboBoxLocalidad();
            ActualizarDataGridViewEmpleados();
        }

        BEmpleado oBEEmpleado = new BEmpleado();
        BLLEmpleado oBLLEmpleado = new BLLEmpleado();
        BLLLocalidad oBLLLocalidad = new BLLLocalidad();

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CargarComboBoxLocalidad()
        {
            comboBoxLocalidad.DataSource = null;
            comboBoxLocalidad.DataSource = oBLLLocalidad.LeerListaDeLocalidades();
            comboBoxLocalidad.ValueMember = "CodLocalidad";
            comboBoxLocalidad.DisplayMember = "Nombre";
            comboBoxLocalidad.Refresh();
        }

        public void ActualizarDataGridViewEmpleados()
        {
            this.dataGridViewEmpleados.DataSource = null;
            this.dataGridViewEmpleados.DataSource = oBLLEmpleado.LeerListaDeEmpleados();
            this.dataGridViewEmpleados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dataGridViewEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        public bool CapturarDatosDelFormulario()
        {
            try
            {
                if (textBoxCodigo.Text != string.Empty && textBoxDNI.Text != string.Empty && textBoxNombre.Text != string.Empty && textBoxApellido.Text != string.Empty && textBoxSueldo.Text != string.Empty)
                {
                    oBEEmpleado.CodPersona = Convert.ToInt32(textBoxCodigo.Text);
                    
                    oBEEmpleado.DNI = Convert.ToInt32(textBoxDNI.Text);
                    Regex oRegexDNI = new Regex("^\\d{8}$");
                    if (oRegexDNI.IsMatch(textBoxDNI.Text))
                    {
                        oBEEmpleado.Nombre = textBoxNombre.Text;
                        oBEEmpleado.Apellido = textBoxApellido.Text;
                        oBEEmpleado.Sueldo = Convert.ToDecimal(textBoxSueldo.Text);
                        oBEEmpleado.Localidad = (BELocalidad)this.comboBoxLocalidad.SelectedItem;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El DNI ingresado no tiene el formato correcto");
                    }
                    return false;
                    
                }
                else
                {
                    MessageBox.Show("Todos los campos son Obligatorios");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != 0)
            {
                BEmpleado oBEEmpleado = new BEmpleado();
                oBEEmpleado = (BEmpleado)dataGridViewEmpleados.CurrentRow.DataBoundItem;
                this.textBoxCodigo.Text = oBEEmpleado.CodPersona.ToString();
                this.textBoxDNI.Text = oBEEmpleado.DNI.ToString();
                this.textBoxNombre.Text = oBEEmpleado.Nombre;
                this.textBoxApellido.Text = oBEEmpleado.Apellido.ToString();
                this.textBoxSueldo.Text = oBEEmpleado.Sueldo.ToString();
                this.comboBoxLocalidad.SelectedValue = oBEEmpleado.Localidad.CodLocalidad;
            }
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                //Se cargaron todos los datos Necesarios
                if (oBLLEmpleado.VerificarExistenciaDNI(oBEEmpleado.DNI))
                {
                    //DNI Existe en Base de Datos                   
                    MessageBox.Show("Se han ingresado los datos de un Empleado \n con un DNI Existente en la Base de Datos");
                }
                else
                {
                    //DNI no Existe en Base de Datos
                    oBLLEmpleado.Operacion(oBEEmpleado, 1);
                    MessageBox.Show("Empleado fue dado de ALTA en la Base De Datos");
                    ActualizarDataGridViewEmpleados();
                }
            }


        }

        private void buttonModificacion_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                //Se cargaron todos los datos Necesarios
                if (oBLLEmpleado.VerificarExistenciaDNI(oBEEmpleado.DNI))
                {
                    //DNI Existe en Base de Datos  
                    oBLLEmpleado.Operacion(oBEEmpleado, 2);
                    MessageBox.Show("Empleado fue modificado correctamente en la Base De Datos");
                    ActualizarDataGridViewEmpleados();

                }
                else
                {
                    //DNI no Existe en Base de Datos
                    MessageBox.Show("Los empleados que pueden modificar son los del listado \n Haga clic sobre el que desea modificar");
                }
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            if (CapturarDatosDelFormulario())
            {
                //Se cargaron todos los datos Necesarios
                if (oBLLEmpleado.VerificarExistenciaDNI(oBEEmpleado.DNI))
                {
                    //DNI Existe en Base de Datos  
                    oBLLEmpleado.Operacion(oBEEmpleado, 3);
                    MessageBox.Show("Empleado fue eliminado correctamente de la Base De Datos");
                    ActualizarDataGridViewEmpleados();

                }
                else
                {
                    //DNI no Existe en Base de Datos
                    MessageBox.Show("Los empleados que puede borrar son los del listado \n Haga clic sobre el que desea eliminar");
                }
            }
        }


    }
}
