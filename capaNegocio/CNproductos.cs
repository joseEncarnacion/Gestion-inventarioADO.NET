using capaDatos;
using capaEntidad;
using System.Data;
 using global::System;
 using global::System.Collections.Generic;

namespace capaNegocio
{
    public class CNproductos
    {
        private CDproducto producto = new CDproducto();



        //validacion
        public bool validarProd(CEproductos ProdEnt)
        {
            bool resultado = true; 

            if (ProdEnt.idProd == string.Empty)  // ""
            {
                //MessageBox.Show("nombre Obligatoria");
                resultado = false;
            }

            if (ProdEnt.nomProd == string.Empty)
            {
                //MessageBox.Show("El Apellido es obligatorio");
                resultado = false;
            }

            if (ProdEnt.descriProd == string.Empty)
            {
                //MessageBox.Show("Nacimiento es obligarotio");
                resultado = false;
            }

            if (ProdEnt.precio <=0)
            {
                //MessageBox.Show("Genero no debe ser nulo");
                resultado = false;
            }
            

            return resultado;
        }



        //Crud Producto

        public void CN_crearProducto(CEproductos pde)
        {
            producto.InsertarProducto(pde);
          
        }

        public DataTable CN_listarProd()
        {
            return producto.ListarProductos();
        }

        public void CN_ActualizarProd(CEproductos pde) { 
            
            producto.ActujalizarProductos(pde);
        
        }

        public void CN_EliminarProd(string id)
        {
            producto.EliminarProductos(id);
        }

    }
}