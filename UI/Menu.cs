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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frEmpleado ofrEmpleado = new frEmpleado();
            ofrEmpleado.MdiParent = this;
            ofrEmpleado.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frProducto ofrProducto = new frProducto();
            ofrProducto.MdiParent = this;
            ofrProducto.Show();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frLocalidad ofrLocalidad = new frLocalidad();
            ofrLocalidad.MdiParent = this;
            ofrLocalidad.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCompra ofrCompra = new frCompra();
            ofrCompra.MdiParent = this;
            ofrCompra.Show();
        }

        public void HabilitarMenuStrip()
        {
            menuStrip1.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            frlogin ofrLogin = new frlogin();
            ofrLogin.MdiParent = this;
            ofrLogin.Show();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frProductoDesc ofrProductoDesc = new frProductoDesc();
            ofrProductoDesc.MdiParent = this;
            ofrProductoDesc.Show();
        }

        private void panelDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frPanelDeResultados ofrPanelDeResultados = new frPanelDeResultados();
            ofrPanelDeResultados.MdiParent = this;
            ofrPanelDeResultados.Show();
        }

        private void documentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frDocumentacion ofrDocumentacion = new frDocumentacion();
            ofrDocumentacion.MdiParent = this;
            ofrDocumentacion.Show();
        }
    }
}
