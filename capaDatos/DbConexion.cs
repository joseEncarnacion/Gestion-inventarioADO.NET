using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace capaDatos
{
    public class DbConexion
    {
        private static DbConexion _dbInstace = null;
        private SqlConnection _connection;

        public DbConexion()
        {

        }

        public static DbConexion GetInstance
        {
            get
            {
                try
                {
                    if (_dbInstace == null)
                    {
                        _dbInstace = new DbConexion();
                    }

                } 
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return _dbInstace;
            }
        }


        //Connecion db
        public SqlConnection MyConnexion()
        {
            if(_dbInstace == null)
            {
                _dbInstace = new DbConexion();
                _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["appConnex"].ConnectionString);
            }

            return _connection;
        }

    }
}