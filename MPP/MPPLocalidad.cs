using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace MPP
{
    public class MPPLocalidad
    {
        public List<BELocalidad> LeerListaDeLocalidades()
        {
            Acceso oAcceso = new Acceso();  //CREO una instancia de ACCESO (DAL)
            DataSet oDataSet = new DataSet();  //DATASET es una TABLA (obtenida de BDSQL en Cache)
            List<BELocalidad> ListaDeLocalidades = new List<BELocalidad>();
            oDataSet = oAcceso.LeerLista("leerListaDeLocalidades"); //Llama a Acceso para Cargar el DataSet con los datos del BDSQL

            if (oDataSet.Tables[0].Rows.Count > 0) //Recorro si el DataSet (tabla obtenida) tiene fila > 0
            {
                foreach (DataRow Item in oDataSet.Tables[0].Rows)
                {
                    BELocalidad oBELocalidad = new BELocalidad();
                    oBELocalidad.CodLocalidad = Convert.ToInt32(Item[0]);
                    oBELocalidad.Nombre = Item[1].ToString();
                    oBELocalidad.CodArea = Convert.ToInt32(Item[2]);
                    ListaDeLocalidades.Add(oBELocalidad);
                }

                return ListaDeLocalidades;
            }
            else
            {
                return null;
            }
        }
        public bool VerificarExistenciaLocalidad(int CodLocalidad)
        {
            Acceso oAcceso = new Acceso();
            Hashtable oHashtable = new Hashtable();
            oHashtable.Add("@CodLocalidad", CodLocalidad);
            return oAcceso.LeerEscalar("verificarExistenciaLocalidadCod", oHashtable);
        }

        public bool Operacion(BELocalidad oBELocalidad, int CodOperacion)
        {
            Hashtable oHastable = new Hashtable();
            Acceso oAcceso = new Acceso();
            string consulta; //Seleccioanr Procedimiento
            switch (CodOperacion)
            {
                case 1:
                    consulta = "altaLocalidad";
                    break;
                case 2:
                    consulta = "modificarLocalidad";
                    break;
                case 3:
                    consulta = "eliminarLocalidad";
                    break;
                default:
                    consulta = null;
                    break;
            }

            if (CodOperacion == 1 || CodOperacion == 2)
            {
                oHastable.Add("@CodLocalidad", oBELocalidad.CodLocalidad);
                oHastable.Add("@Nombre", oBELocalidad.Nombre);
                oHastable.Add("@CodArea", oBELocalidad.CodArea);
            }
            else
            {
                oHastable.Add("@CodLocalidad", oBELocalidad.CodLocalidad);

            }
            return oAcceso.Operacion(oHastable, consulta);
        }

    }
}
