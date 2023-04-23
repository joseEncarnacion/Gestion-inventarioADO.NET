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
    public class CDsalidadVentas
    {

        //conexion con mi base de datos
        SqlConnection cor =
           new SqlConnection(ConfigurationManager.ConnectionStrings["appConnex"].ConnectionString);


        public void InsertarSalida(CEsalidadVentas salidaPD)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_crearSalida", cor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigopdFK", salidaPD.codigopdfk);
                cmd.Parameters.AddWithValue("@cantidad", salidaPD.cantidad);
                cmd.Parameters.AddWithValue("@fecha", salidaPD.fecha);
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

        public DataTable ListarSalida()
        {
            SqlCommand cmd = new SqlCommand("sp_listarSalida", cor);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;



        }


        //Editar productos

        public void ActuzalizarSalida(CEsalidadVentas salidaPD)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarSalida", cor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigopdFK", salidaPD.codigopdfk);
                cmd.Parameters.AddWithValue("@cantidad", salidaPD.cantidad);
                cmd.Parameters.AddWithValue("@fecha", salidaPD.fecha); ;
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

        public void EliminarSalida(int id)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_eliminarSalida", cor);
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
