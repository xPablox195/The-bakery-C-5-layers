﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BE;
using MPP;

namespace BLL
{
    public class BLLLogin
    {
        public string Encriptar(string texto)
        {
            try
            {

                string key = "miencritacion"; //llave para encriptar datos
                byte[] keyArray;
                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

                //Se utilizan las clases de encriptación MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
            }
            catch (Exception)
            {

            }
            return texto;
        }

        public bool Operacion(BELogin oBELogin, int NumOperacion)
        {
            MPPLogin oMPPLogin = new MPPLogin();
            return oMPPLogin.Operacion(oBELogin, NumOperacion);
        }

        //public bool ValidarUsuario(BELogin oBELogin)
        //{
        //    MPPLogin oMPPLogin = new MPPLogin();
        //    return oMPPLogin.ValidarUsuario(oBELogin);
        //}
    }
}
