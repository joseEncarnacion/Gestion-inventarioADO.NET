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
        //Productos
        CNproductos productoNeg = new CNproductos();
        CEproductos productoEnt = new CEproductos();

        //Entrada
        CNentrada entradaNeg = new CNentrada();
        CEentrada entradaEN= new CEentrada();

        //Entrada
        CNsalidadVentas salidasNeg =new CNsalidadVentas();
        CEsalidadVentas salidaE = new CEsalidadVentas();    


        bool existe;

        //insertar producto 
        private void Listarproducto()
        {
            DataTable dt = productoNeg.CN_listarProd();
            dtGridProd.DataSource= dt;
        }

        //Listar Salidas 
        private void ListarSalidas()
        {
            DataTable dt = salidasNeg.CN_listarSalidad();
            dtGridSalidas.DataSource = dt;
        }

        //Listar Entrada 
        private void ListarEntrada()
        {
            DataTable dt = entradaNeg.CN_listarEntrada();
            dtGridEntrada.DataSource = dt;
        }

        //Limpiar campos de lis inputs
        private void LimpliarINputs()
        {
            tboxCodigo.Text = "";
            tboxDescripcion.Text = "";
            tboxNombre.Text = "";
            tboxPrecio.Text = "";

            tboxfechaEntrada.Text = "";
            tboxcodeEntrada.Text = "";
            tboxcandEntrada.Text = "";
        }

        //Crear Entrada
        private void InsertarEntrada()
        {
            bool respuesta;

            entradaEN.codigopdfk = tboxcodeEntrada.Text;
            entradaEN.cantidad = int.Parse(tboxcandEntrada.Text);
            entradaEN.fecha = DateTime.Parse( tboxfechaEntrada.Text);
            

            respuesta = entradaNeg.validarEntrada(entradaEN);

            if (respuesta == false)
            {
                return;
            }

            if (!existe)
            {
                entradaNeg.CN_crearEntrada(entradaEN);
                MessageBox.Show("Creado Satisfactorio");

                LimpliarINputs();


                ListarEntrada();
            }
            else if (existe)
            {
                productoNeg.CN_ActualizarProd(productoEnt);
                MessageBox.Show("Actualizado Satisfactorio");

                LimpliarINputs();

                panelcrearEntrada.Visible = false;
                panelEntrada.Visible = true;
                ListarEntrada();
            }


        }

        //Crear Salida
        private void InsertarSalida()
        {
            bool respuesta;

            salidaE.codigopdfk = tboxSalidaCode.Text;
            salidaE.cantidad = int.Parse(tboxSalidaCantidad.Text);
            salidaE.fecha = DateTime.Parse(tboxSalidaFecha.Text);


            respuesta = salidasNeg.validarSalida(salidaE);

            if (respuesta == false)
            {
                return;
            }

            if (!existe)
            {
                salidasNeg.CN_crearSalidad(salidaE);
                MessageBox.Show("Creado Satisfactorio");

                LimpliarINputs();


                ListarSalidas();
            }
            else if (existe)
            {
                salidasNeg.CN_ActualizarSalidad(salidaE);
                MessageBox.Show("Actualizado Satisfactorio");

                LimpliarINputs();

                panelregSalida.Visible = false;
                panelverSalidas.Visible = true;
                ListarSalidas();
            }


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
            ListarEntrada();
            ListarSalidas();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            panelregSalida.Visible = false;
            panelregSalida.Visible = false;
            panelCrearProducto.Visible = true;
        }

        private void btnProdPanel_Click(object sender, EventArgs e)
        {
            panelverSalidas.Visible = false;
            panelregSalida.Visible = false;
            panelCrearProducto.Visible = false;
            panelEntrada.Visible = false;
            panelProdList.Visible = true;
        }

        private void btnEntradaPanel_Click(object sender, EventArgs e)
        {
            panelverSalidas.Visible = false;
            panelregSalida.Visible = false;
            panelcrearEntrada.Visible = false;
            panelCrearProducto.Visible = false;
            panelEntrada.Visible = true;
           

        }

        private void btnSalidaPanel_Click(object sender, EventArgs e)
        {
           panelregSalida.Visible=false;
            panelcrearEntrada.Visible = false;
            panelCrearProducto.Visible = false;
            panelEntrada.Visible = false;
            panelProdList.Visible = false;
            panelverSalidas.Visible = true; 

        }

        private void btnReporPanel_Click(object sender, EventArgs e)
        {
            panelcrearEntrada.Visible = false;
            panelCrearProducto.Visible = false;
            panelEntrada.Visible = false;
            panelProdList.Visible = true;
            panelverSalidas.Visible = false;


            //Reporte
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //cerrar sesion admin
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

        private void dtGridEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      

            
            if (dtGridEntrada.Rows[e.RowIndex].Cells["dataGridViewImageColumn1"].Selected)
            {
                int eliminar = Convert.ToInt32(dtGridEntrada.Rows[e.RowIndex].Cells["idEntrada"].Value.ToString());

                entradaNeg.CN_EliminarEntrada(eliminar );


                ListarEntrada();


            }
            else
            {
                panelcrearEntrada.Visible = true;
                existe = true;

                if (dtGridEntrada.Rows[e.RowIndex].Cells["dataGridViewImageColumn2"].Selected)
                {
                    tboxcodeEntrada.Text = dtGridEntrada.Rows[e.RowIndex].Cells["codigoPdE"].Value.ToString();
                    tboxcandEntrada.Text = dtGridEntrada.Rows[e.RowIndex].Cells["cantidad"].Value.ToString();
                    tboxfechaEntrada.Text = dtGridEntrada.Rows[e.RowIndex].Cells["fecha"].Value.ToString();
                    
                }

            }

        }

        private void btnGestionStock_Click(object sender, EventArgs e)
        {
            // ir a la vista crear o editar entrada
            panelcrearEntrada.Visible = true;
        }

        private void btnEntradaEnviar_Click(object sender, EventArgs e)
        {
            //enviar dastos Entrada

            InsertarEntrada();
            ListarEntrada();
        }

        private void btnSalidasGestion_Click(object sender, EventArgs e)
        {
            //gestion panel crear salida
            panelregSalida.Visible = true;
            MessageBox.Show("Se dio clie");
        }

        private void dtGridSalidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Acciones Eliminar y editar

            if (dtGridSalidas.Rows[e.RowIndex].Cells["dataGridViewImageColumn3"].Selected)
            {
                int eliminar = Convert.ToInt32(dtGridSalidas.Rows[e.RowIndex].Cells["idSalida"].Value.ToString());

                salidasNeg.CN_EliminarSalidad(eliminar);


                ListarSalidas();


            }
            else
            {

                panelregSalida.Visible = true;
                existe = true;

                if (dtGridSalidas.Rows[e.RowIndex].Cells["dataGridViewImageColumn4"].Selected)
                {
                    tboxSalidaCode.Text = dtGridSalidas.Rows[e.RowIndex].Cells["codigoPdS"].Value.ToString();
                    tboxSalidaCantidad.Text = dtGridSalidas.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                    tboxSalidaFecha.Text = dtGridSalidas.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                }

            }


        }

        private void btnSalidasGestion_Click_1(object sender, EventArgs e)
        {
            panelregSalida.Visible=true;
        }

        private void btnRegistroSalida_Click(object sender, EventArgs e)
        {
            InsertarSalida();
            ListarSalidas();
        }

        private void dtReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // reportes
           // panel1ReporteVista.Visible=true;    
        }

        private void BtnEntrarADMIN_Click(object sender, EventArgs e)
        {

        }

        private void btnINGGeneral_Click(object sender, EventArgs e)
        {

        }

        private void panelVerProductoGeneral_Paint(object sender, PaintEventArgs e)
        {
            //ver producto general
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnGrealProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnGrealrepVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnGrealVentasRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}