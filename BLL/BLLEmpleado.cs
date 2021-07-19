using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Collections;
using MPP;


namespace BLL
{
    public class BLLEmpleado : BLLPersona
    {
        #region Polimorfismo MontoTotal
        public override decimal MontoTotal()
        {
            MPPEmpleado oMPPEmpleado = new MPPEmpleado();
            List<BEmpleado> ListaDeEmpleados = new List<BEmpleado>();
            ListaDeEmpleados = oMPPEmpleado.LeerListaDeEmpleados();
            if (ListaDeEmpleados != null)
            {
                decimal sueldo = 0;
                foreach (BEmpleado Empleado in ListaDeEmpleados)
                {
                    sueldo += Empleado.Sueldo;

                }
                return sueldo;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        public bool NuevoEmpleado(BEmpleado NewEmpleado)
        {
            VerificarExistenciaDNI(NewEmpleado.DNI);
            return false;
        }

        public bool VerificarExistenciaDNI(int DNI)
        {
            MPPEmpleado oMPPEmpleado = new MPPEmpleado();
            return oMPPEmpleado.VerificarExistenciaDNI(DNI);
        }


        public List<BEmpleado> LeerListaDeEmpleados()
        {
            List<BEmpleado> ListaDeEmpleados = new List<BEmpleado>();
            MPPEmpleado oMPPEmpleado = new MPPEmpleado();
            return oMPPEmpleado.LeerListaDeEmpleados();
        }
        public bool Operacion(BEmpleado oBEEmpleado, int CodOperacion)
        {
            MPPEmpleado oMPPEmpleado = new MPPEmpleado();
            return oMPPEmpleado.Operacion(oBEEmpleado, CodOperacion);
        }

    }
}
