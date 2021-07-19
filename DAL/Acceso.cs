using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;




namespace DAL
{
    public class Acceso
    {
        private SqlConnection Cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LaPanaderia;Integrated Security=True");
        private SqlCommand Cmd; //Tiene la responsabilidad de ejecutar todas las ordenes para los datos de la BD
        private SqlTransaction Tranx;

        public bool LeerEscalar(string consulta, Hashtable oHashtable)
        { //Hashtable representa una colección de palabras clave y valor ("@DNI", DNI)
            Cmd = new SqlCommand();
            try
            {
                Cnn.Open(); //Abro la conexíón
                Cmd.Connection = Cnn; //Le asigno la conexión al SqlCommand
                Cmd.CommandText = consulta;  //Aca le pasamos la consulta. Ejemplo: Select*** o el nombre del procedimiento
                Cmd.CommandType = CommandType.StoredProcedure; //Aca expresamos el tipo de procedimiento


                if ((oHashtable != null))
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in oHashtable.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(dato, oHashtable[dato]);
                    }

                }
                int Respuesta = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnn.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            { //cierro la Conexion
                Cnn.Close();
            }
        }

        public DataSet LeerEscalarDevolverEscalar(string consulta, Hashtable hdatos)
        {

            DataSet Ds = new DataSet();
            Cmd = new SqlCommand();
            try
            {
                Cmd.Connection = Cnn;
                Cmd.CommandText = consulta;
                Cmd.CommandType = CommandType.StoredProcedure;


                if ((hdatos != null))
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in hdatos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(dato, hdatos[dato]);
                    }
                }

                SqlDataAdapter Adaptador = new SqlDataAdapter(Cmd);
                Adaptador.Fill(Ds);
                return Ds;
            }
            catch (SqlException ex)
            {
                throw ex;
                //return null;
            }
            catch (Exception ex)
            {
                throw ex;
                //return null;
            }
        }


        public DataSet LeerLista(string consulta)
        {

            DataSet oDataSet = new DataSet(); //Creo el DataSet, que luego retornaré
            Cmd = new SqlCommand(); //Instancio el SQLCommand (responsable de ejecutar todas las ordenescnecesarias para tomar Datos de la BD
            try
            {
                Cnn.Open(); //Abro la Conexión
                Cmd.Connection = Cnn; //Le asigno  la conexión 
                Cmd.CommandText = consulta; //Aca le pasamos la consulta. Ejemplo: Select*** o el nombre del procedimiento
                Cmd.CommandType = CommandType.StoredProcedure; //Expresamos el tipo de consulta

                SqlDataAdapter Adaptador = new SqlDataAdapter(Cmd); //SqlDAtaApater permite rellenar el DataSet
                Adaptador.Fill(oDataSet); //Se le indica cual DataSetRellena
                return oDataSet;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { //cierro la Conexion
                Cnn.Close();
            }
        }

        public bool Operacion(Hashtable oHashtable, string consulta)
        {
            try
            {

                Cnn.Open();
                Tranx = Cnn.BeginTransaction();
                Cmd = new SqlCommand();
                Cmd.Connection = Cnn;
                Cmd.CommandText = consulta;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Transaction = Tranx;


                if ((oHashtable != null))
                {
                    foreach (string dato in oHashtable.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(dato, oHashtable[dato]);
                    }
                }

                int respuesta = Cmd.ExecuteNonQuery();
                Tranx.Commit();
                return true;

            }
            catch (Exception ex)
            {
                Tranx.Rollback();
                throw ex;

            }
            finally
            {
                Cnn.Close();
            }
        }

        public bool AltaDesconectadoProductos(DataSet oDataSet, string Consulta)
        {
            try
            {
                SqlCommand oSqlCommand = new SqlCommand();
                SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                Cnn.Open();
                oSqlDataAdapter = new SqlDataAdapter(("SELECT * FROM " + Consulta), Cnn);
                // SE SETEAN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
                SqlCommandBuilder Cb = new SqlCommandBuilder(oSqlDataAdapter);
                oSqlDataAdapter.UpdateCommand = Cb.GetUpdateCommand();
                oSqlDataAdapter.DeleteCommand = Cb.GetDeleteCommand();
                oSqlDataAdapter.InsertCommand = Cb.GetInsertCommand();
                oSqlDataAdapter.ContinueUpdateOnError = true;
                oSqlDataAdapter.Fill(oDataSet);
                // SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
                oSqlDataAdapter.Update(oDataSet.Tables[0]);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                Cnn.Close();
            }
        }


    }

}
