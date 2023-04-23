using capaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CDEntrada
    {

        //conexion con mi base de datos
        SqlConnection cor =
           new SqlConnection(ConfigurationManager.ConnectionStrings["appConnex"].ConnectionString);


        public void InsertarEntrada(CEentrada entradaPD)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_crearEntrada", cor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigopdFK", entradaPD.codigopdfk);
                cmd.Parameters.AddWithValue("@cantidad", entradaPD.cantidad);
                cmd.Parameters.AddWithValue("@fecha", entradaPD.fecha);
                // if(conn.MyConnexion().State ==ConnectionState.Open) { conn.MyConnexion().Close(); }
                cor.Open();
                cmd.ExecuteNonQuery();
                // conn.MyConnexion().Close() ;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cor.Close();
            }
        }

        // lISTAR PRODUCTOS

        public DataTable ListarEntrada()
        {
            SqlCommand cmd = new SqlCommand("sp_listarEntrada", cor);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;



        }


        //Editar productos

        public void ActujalizarEntrada(CEentrada entradaPD)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarEntrada", cor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigopdFK", entradaPD.codigopdfk);
                cmd.Parameters.AddWithValue("@cantidad", entradaPD.cantidad);
                cmd.Parameters.AddWithValue("@fecha", entradaPD.fecha); ;
                if (cor.State == ConnectionState.Open) { cor.Close(); }
                // if (conn.MyConnexion().State == ConnectionState.Open) { conn.MyConnexion().Close(); }
                cor.Open();
                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cor.Close();
            }
        }




        //Eliminar Producto

        public void EliminarEntrada(int id)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_eliminarEntrada", cor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id ", id);
                if (cor.State == ConnectionState.Open) { cor.Close(); }
                cor.Open();
                //if (conn.MyConnexion().State == ConnectionState.Open) { conn.MyConnexion().Close(); }

                cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cor.Close();
            }

        }


    }
}
