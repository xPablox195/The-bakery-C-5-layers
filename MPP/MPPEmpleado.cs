using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace MPP
{
    public class MPPEmpleado
    {
        public bool VerificarExistenciaDNI(int DNI)
        {
            Hashtable oHashtable = new Hashtable();
            oHashtable.Add("@DNI", DNI);
            Acceso oAcceso = new Acceso();
            return oAcceso.LeerEscalar("VerificarExistenciaDNI", oHashtable);
        }

        public List<BEmpleado> LeerListaDeEmpleados()
        {
            Acceso oAcceso = new Acceso();
            DataSet oDataSet = new DataSet();
            List<BEmpleado> ListaDeEmpleados = new List<BEmpleado>();
            oDataSet = oAcceso.LeerLista("leerListaDeEmpleados");

            if (oDataSet.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow Item in oDataSet.Tables[0].Rows)
                {
                    BEmpleado oBEEmpleado = new BEmpleado();
                    BELocalidad oBELocalidad = new BELocalidad();
                    oBEEmpleado.CodPersona = Convert.ToInt32(Item[0]);
                    oBEEmpleado.DNI = Convert.ToInt32(Item[1]);
                    oBEEmpleado.Nombre = Item[2].ToString();
                    oBEEmpleado.Apellido = Item[3].ToString();
                    oBEEmpleado.Sueldo = Convert.ToDecimal(Item[4]);
                    oBELocalidad.CodLocalidad = Convert.ToInt32(Item[5]);
                    oBELocalidad.Nombre = Item[6].ToString();
                    oBELocalidad.CodArea = Convert.ToInt32(Item[7]);
                    oBEEmpleado.Localidad = oBELocalidad;
                    ListaDeEmpleados.Add(oBEEmpleado);
                }
            }

            if (ListaDeEmpleados.Count != 0)
            {
                return ListaDeEmpleados;
            }
            else
            {
                return null;
            }
        }

        public bool Operacion(BEmpleado oBEEmpleado, int CodOperacion)
        {
            Hashtable oHastable = new Hashtable();
            Acceso oAcceso = new Acceso();
            string consulta; //Seleccioanr Procedimiento
            switch (CodOperacion)
            {
                case 1:
                    consulta = "altaEmpleado";
                    break;
                case 2:
                    consulta = "modificarEmpleado";
                    break;
                case 3:
                    consulta = "eliminarEmpleado";
                    break;
                default:
                    consulta = null;
                    break;
            }

            if (CodOperacion == 1 || CodOperacion == 2)
            {
                oHastable.Add("@DNI", oBEEmpleado.DNI);
                oHastable.Add("@Nombre", oBEEmpleado.Nombre);
                oHastable.Add("@Apellido", oBEEmpleado.Apellido);
                oHastable.Add("@Sueldo", oBEEmpleado.Sueldo);
                oHastable.Add("@CodLocalidad", oBEEmpleado.Localidad.CodLocalidad);
            }
            else
            {
                oHastable.Add("@CodPersona", oBEEmpleado.CodPersona);
             
            }
            return oAcceso.Operacion(oHastable, consulta);
        }
    }

}

