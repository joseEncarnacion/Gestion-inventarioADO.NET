using capaDatos;
using capaEntidad;
using capaNegocio;
using System.Data;

namespace GestionInventario
{
    public partial class pantalla1 : Form
    {
        public pantalla1()
        {
            InitializeComponent();

        }
        CNproductos productoNeg = new CNproductos();
        CEproductos productoEnt = new CEproductos();
        bool existe;

        //insertar producto 
        private void Listarproducto()
        {
            DataTable dt = productoNeg.CN_listarProd();
            dtGridProd.DataSource= dt;
        }

        //Limpiar campos de lis inputs
        private void LimpliarINputs()
        {
            tboxCodigo.Text = "";
            tboxDescripcion.Text = "";
            tboxNombre.Text = "";
            tboxPrecio.Text = "";
        }


        //Crear producto
      private void InsertarProducto()
        {
            bool respuesta;

            productoEnt.idProd = tboxCodigo.Text;
            productoEnt.nomProd = tboxNombre.Text;  
            productoEnt.descriProd = tboxDescripcion.Text;
            productoEnt.precio=double.Parse(tboxPrecio.Text);

            respuesta = productoNeg.validarProd(productoEnt);

            if(respuesta == false)
            {
                return;
            }

            if (!existe)
            {
                productoNeg.CN_crearProducto(productoEnt);
                MessageBox.Show("Creado Satisfactorio");

                LimpliarINputs();

                
                Listarproducto();
            }
            else if (existe)
            {
                productoNeg.CN_ActualizarProd(productoEnt);
                MessageBox.Show("Actualizado Satisfactorio");

                LimpliarINputs();

                panelCrearProducto.Visible = false;
                panelProdList.Visible = true;
                Listarproducto();
            }


        }

        private void pantalla1_Load(object sender, EventArgs e)
        {
            Listarproducto();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            panelCrearProducto.Visible = true;
        }

        private void btnProdPanel_Click(object sender, EventArgs e)
        {
            panelCrearProducto.Visible = false;
            panelProdList.Visible = true;
        }

        private void btnEntradaPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnSalidaPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnReporPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void dtGridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGridProd.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                var eliminar = ( dtGridProd.Rows[e.RowIndex].Cells["codigo"].Value);

                //MessageBox.Show(eliminar+"");

                productoNeg.CN_EliminarProd(eliminar+"");


                Listarproducto();


            }
            else
            {
                panelCrearProducto.Visible = true;
                existe = true;

                if (dtGridProd.Rows[e.RowIndex].Cells["editar"].Selected)
                {
                    tboxCodigo.Text = dtGridProd.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                    tboxNombre.Text = dtGridProd.Rows[e.RowIndex].Cells["nombreProd"].Value.ToString();
                    tboxDescripcion.Text = dtGridProd.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                    tboxPrecio.Text =dtGridProd.Rows[e.RowIndex].Cells["precio"].Value.ToString();
                }

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            InsertarProducto();
        }
    }
}