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
        public bool validarProd(CEsalidadVentas pSalidad)
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

        public void CN_crearEntrada(CEsalidadVentas pSalidad)
        {
            SalidaD.Ins(pEntrada);

        }

        public DataTable CN_listarEntrada()
        {
            return EntradaPD.ListarEntrada();
        }

        public void CN_ActualizarEntrada(CEentrada pEntrada)
        {

            EntradaPD.ActujalizarEntrada(pEntrada);

        }

        public void CN_EliminarEntrada(int id)
        {
            EntradaPD.EliminarEntrada(id);
        }
    }
}
