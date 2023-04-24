using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace capaDatos
{
    public class CDUsario
    {
        //conexion con mi base de datos
        SqlConnection cor =
           new SqlConnection(ConfigurationManager.ConnectionStrings["appConnex"].ConnectionString);


        public DataTable Datos_Listar(CEUsuario US)
        {
            SqlCommand cmd = new SqlCommand("sp_usuarioADM", cor);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", US.UsuarioE);
            cmd.Parameters.AddWithValue("@pass", US.passE);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
