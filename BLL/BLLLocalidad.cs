using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace BLL
{
    public class BLLLocalidad
    {
        public List<BELocalidad> LeerListaDeLocalidades()
        {
            MPPLocalidad oMPPLocalidad = new MPPLocalidad();
            return oMPPLocalidad.LeerListaDeLocalidades();
        }

        public bool VerificarExistenciaLocalidad(int CodLocalidad)
        {
            MPPLocalidad oMPPLocalidad = new MPPLocalidad();
            return oMPPLocalidad.VerificarExistenciaLocalidad(CodLocalidad);
        }
        public bool Operacion(BELocalidad oBELocalidad, int CodOperacion)
        {
            MPPLocalidad oMPPLocalidad = new MPPLocalidad();
            return oMPPLocalidad.Operacion(oBELocalidad, CodOperacion);
        }

        public void CrearXML()
        {
            XElement ducumentoLocalidades = new XElement("Localidades",
                new XElement("Localidad", new XAttribute("CodLocalidad", "1001"),
                new XElement("Nombre", "Ciudadela"),
                new XElement("CodArea", "1100")
                ),
                new XElement("Localidad", new XAttribute("CodLocalidad", "1002"),
                new XElement("Nombre", "Ciudadela"),
                new XElement("CodArea", "1101")
                )
             );
            ducumentoLocalidades.Save("Localidades.xml");
        }

        public void CrearDocumentoXML()
        {
            XDocument documento = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),

             new XElement("Localidades",
                new XElement("Localidad", new XAttribute("CodLocalidad", "1001"),
                new XElement("Nombre", "Ciudadela"),
                new XElement("CodArea", "1100")
                ),
                new XElement("Localidad", new XAttribute("CodLocalidad", "1002"),
                new XElement("Nombre", "Ciudadela"),
                new XElement("CodArea", "1101")
                )
             ));
            documento.Save("Localidades.xml");
        }

        public void CrearDocumentoXMLLocalidades()
        {
            MPPLocalidad oMPPLocalidad = new MPPLocalidad();
            List<BELocalidad> ListaLocalidades = new List<BELocalidad>();
            ListaLocalidades = oMPPLocalidad.LeerListaDeLocalidades();
            XDocument documento = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),

             new XElement("Localidades",
             from Localidad in ListaLocalidades
             select new XElement("Localidad", new XAttribute("CodLocalidad", Localidad.CodLocalidad),
              new XElement("Nombre", Localidad.Nombre),
              new XElement("CodArea", Localidad.CodArea)
              )
             ));
            documento.Save("Localidades.xml");
        }
    }



}

