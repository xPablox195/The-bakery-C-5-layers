using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;
using System.Collections;

namespace MPP
{
    public class MPPLogin
    {
        public bool Operacion(BELogin oBELogin, int NumOperacion)
        {

            string Consulta_SQL;
            switch (NumOperacion)
            {
                case 1:
                    Consulta_SQL = "ValidarUsuario";

                    break;

                case 2:
                    Consulta_SQL = "altaUsuario";
                    break;

                default:
                    Consulta_SQL = null;
                    break;
            }

            //instancio un objeto de la clase datos para operar con la BD
            Acceso oAcceso = new Acceso();
            Hashtable oHashTable = new Hashtable();
            oHashTable.Add("@Usuario", oBELogin.Usuario);
            oHashTable.Add("@Contraseña", oBELogin.Contraseña);
            if (NumOperacion == 1) //Valida Usuario y Contraseña
            {
                return oAcceso.LeerEscalar(Consulta_SQL, oHashTable);
            }
            else //ALTA usuario
            {
                return oAcceso.Operacion(oHashTable, Consulta_SQL);
            }



        }

       
    }
}

