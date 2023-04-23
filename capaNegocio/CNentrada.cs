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
    public class CNentrada
    {
        private CDEntrada EntradaPD = new CDEntrada();



        //validacion
        public bool validarProd(CEentrada pEntrada)
        {
            bool resultado = true;

            if (pEntrada.codigopdfk == string.Empty)  // ""
            {
                //MessageBox.Show("nombre Obligatoria");
                resultado = false;
            }

            if (pEntrada.cantidad <0)
            {
                //MessageBox.Show("El Apellido es obligatorio");
                resultado = false;
            }

           
            return resultado;
        }



        //Crud Producto

        public void CN_crearEntrada(CEentrada pEntrada)
        {
            EntradaPD.InsertarEntrada(pEntrada);

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
