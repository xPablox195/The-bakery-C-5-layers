using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class frlogin : Form
    {
        public frlogin()
        {
            InitializeComponent();
        }

        int multilenguaje = 0;

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxNombreDeUsuario.Text != string.Empty && textBoxContraseña.Text != string.Empty)
                {
                    BELogin oBELogin = new BELogin();
                    BLLLogin oBLLLogin = new BLLLogin();
                    oBELogin.Usuario = textBoxNombreDeUsuario.Text;
                    oBELogin.Contraseña = oBLLLogin.Encriptar(textBoxContraseña.Text);
                    // oBLLLogin.Operacion(oBELogin, 2);
                    if (oBLLLogin.Operacion(oBELogin,1))
                    {
                        MessageBox.Show(Res.CartelUno);
                        ((Menu)this.MdiParent).HabilitarMenuStrip();
                        Limpiar();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(Res.CartelDos);
                    }


                }
                else
                {
                    MessageBox.Show(Res.CartelTres);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            textBoxNombreDeUsuario.Text = "";
            textBoxContraseña.Text = "";
        }

        private void buttonNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxNombreDeUsuario.Text != string.Empty && textBoxContraseña.Text != string.Empty)
                {
                    BELogin oBELogin = new BELogin();
                    BLLLogin oBLLLogin = new BLLLogin();
                    oBELogin.Usuario = Convert.ToString(textBoxNombreDeUsuario.Text);
                    oBELogin.Contraseña = oBLLLogin.Encriptar(textBoxContraseña.Text);
                    oBLLLogin.Operacion(oBELogin, 2);
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("Todos los datos son obligatorios para dar de alta un usuario");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frlogin_Load(object sender, EventArgs e)
        {
           
        }

        public void getText()
        {
            labelContraseña.Text = Res.CONTRASEÑA;
            labelNombre.Text = Res.USUARIO;
            buttonIdioma.Text = Res.IDIOMA;
            buttonIngresar.Text = Res.INGRESAR;
            buttonSalir.Text = Res.SALIR;
            
        }

        private void buttonIdioma_Click(object sender, EventArgs e)
        {
            if (multilenguaje == 0)
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
    }
}
