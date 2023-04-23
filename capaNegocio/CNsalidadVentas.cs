using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class CNsalidadVentas
    {
        private CDsalidadVentas SalidaD = new CDsalidadVentas();



        //validacion
        public bool validarSalida(CEsalidadVentas pSalidad)
        {
            bool resultado = true;

            if (pSalidad.codigopdfk == string.Empty)  // ""
            {
                //MessageBox.Show("nombre Obligatoria");
                resultado = false;
            }

            if (pSalidad.cantidad < 0)
            {
                //MessageBox.Show("El Apellido es obligatorio");
                resultado = false;
            }


            return resultado;
        }



        //Crud Producto

        public void CN_crearSalidad(CEsalidadVentas pSalidad)
        {
            SalidaD.InsertarSalida(pSalidad);

        }

        public DataTable CN_listarSalidad()
        {
            return SalidaD.ListarSalida();
        }

        public void CN_ActualizarSalidad(CEsalidadVentas pSalidad)
        {

            SalidaD.ActuzalizarSalida(pSalidad);

        }

        public void CN_EliminarSalidad(int id)
        {
            SalidaD.EliminarSalida(id);
        }
    }
}
