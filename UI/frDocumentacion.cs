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
    public partial class frDocumentacion : Form
    {
        public frDocumentacion()
        {
            InitializeComponent();
        }

        private void buttonCtrlUsuario_Click(object sender, EventArgs e)
        {
            CtrlUsuarioDocumentacion oCtrlUsuarioDocumentacion = new CtrlUsuarioDocumentacion();
            if(panelMuestra.Contains(oCtrlUsuarioDocumentacion) == false)
            {
                panelMuestra.Controls.Add(oCtrlUsuarioDocumentacion);
                oCtrlUsuarioDocumentacion.BringToFront();

            }
            else
            {
                oCtrlUsuarioDocumentacion.BringToFront();
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
