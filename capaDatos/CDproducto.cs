using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace capaDatos
{
    public class CDproducto
    {
        public DbConexion conn =  DbConexion.GetInstance;

        //conexion con mi base de datos
        SqlConnection cor =
           new SqlConnection(ConfigurationManager.ConnectionStrings["appConnex"].ConnectionString);


        public void InsertarProducto(CEproductos prod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_crearProductos", cor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", prod.idProd);
                cmd.Parameters.AddWithValue("@nomProd", prod.nomProd);
                cmd.Parameters.AddWithValue("@descrip", prod.descriProd);
                cmd.Parameters.AddWithValue("@precio", prod.precio);
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

        public DataTable ListarProductos()
        {
            SqlCommand cmd = new SqlCommand("sp_listarProductos", cor);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
          

            
        }


        //Editar productos

        public void ActujalizarProductos(CEproductos prod)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarProductos", cor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", prod.idProd);
                cmd.Parameters.AddWithValue("@nomProd", prod.nomProd);
                cmd.Parameters.AddWithValue("@descrip", prod.descriProd);
                cmd.Parameters.AddWithValue("@precio", prod.precio);
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

        public void EliminarProductos(string id)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_eliminarProducto", cor);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id ", id);
                if(cor.State == ConnectionState.Open) { cor.Close(); }
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
