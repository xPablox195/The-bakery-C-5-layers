using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CtrlUsuarioDocumentacion : UserControl
    {
        public CtrlUsuarioDocumentacion()
        {
            InitializeComponent();
        }

        private void CtrlUsuarioDocumentacion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la documentación que está buscando");
        }

        private void radioButtonAlumno_CheckedChanged(object sender, EventArgs e)
        {
            labelInformacion.Text = "El desarrollador de este proyecto se llama:\n" +
                "Luparia Pablo Javier\n" +
                "Título: Técnico Electrónico\n" +
                "Edad: 25 años\n" +
                "Fecha de Nacimiento: 28.10-1995\n" +
                "Trabajo: Programador en la Empresa: Ardison S.R.L\n" +
                "Horario Laboral: 9 a 18 hs\n" +
                "Estudiante de ingeniería Informática en la Universidad Abierta Interamericana\n" +
                "Materias Aprobadas: 24\n";
        }

        private void radioButtonInformacionDelProyecto_CheckedChanged(object sender, EventArgs e)
        {
            labelInformacion.Text = "El Manual del Proyecto y el listado de funcionalidades\n" +
                "se encvuentra adjuntado en la carpeta .rar solicitada por el Profesor.\n" +
                "En el mismo además se encuentran el backup de la base de datos al día de la fecha,\n" +
                "diagrama de clases y enunciado efectuado por el alumno";
        }
    }
}
