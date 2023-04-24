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

        //Login Admin
        CNusuario usuarioNeg = new CNusuario();
        CEUsuario UsuarioEntidad = new CEUsuario();

        //login usuario general 
        CNUsuarioGeneral usuariogENERALNeg = new CNUsuarioGeneral();
        CEUsuarioGeneral usuariogENERALEN = new CEUsuarioGeneral();

        //loginUusario

        private void LimpiarInputLogin()
        {
            textBoxUusarioADM.Text = "";
            textBoxClaveADM.Text = "";

            tboxpassGenral.Text = "";
            tboxUsuarioGenral.Text = "";
        }

        //usuario general

        public void loginUserGeneral()
        {
            bool respuesta;
            DataTable dt;
            string userAuth;
            string passAuth;

            usuariogENERALEN.UsuarioE = tboxUsuarioGenral.Text;
            usuariogENERALEN.passE = tboxpassGenral.Text;

            respuesta = usuariogENERALNeg.validarUsuario(usuariogENERALEN);

            if (respuesta == false)
            {

                return;
            }

            dt = usuariogENERALNeg.NEBuscarUsuario(usuariogENERALEN);

            //dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("ususario no existe");
                tboxpassGenral.Text = string.Empty;
                return;

            }
            else
            {
                userAuth = dt.Rows[0]["usuarioADM"].ToString();
                passAuth = dt.Rows[0]["passADM"].ToString();

                if (tboxUsuarioGenral.Text == userAuth && tboxpassGenral.Text == passAuth)
                {

                    //mostrar pantallas
                    panelPrincipal2.Visible = false;
                    panel1LoginADM.Visible = false;
                    panelLoginGeneral.Visible = false;
                    panelProdList.Visible = false;
                    panelVERGeneralNUveo.Visible = false;

                    LimpiarInputLogin();

                }

            }




        }



        //fin usuario general

        //usuario admin
        public void loginAdm()
        {
            bool respuesta;
            DataTable dt;
            string userAuth;
            string passAuth;

            UsuarioEntidad.UsuarioE = textBoxUusarioADM.Text;
            UsuarioEntidad.passE = textBoxClaveADM.Text;

            respuesta = usuarioNeg.validarUsuario(UsuarioEntidad);

            if (respuesta == false)
            {

                return;
            }

            dt = usuarioNeg.NEBuscarUsuario(UsuarioEntidad);

            //dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("ususario no existe");
                textBoxClaveADM.Text = string.Empty;
                return;

            }
            else
            {
                userAuth = dt.Rows[0]["usuarioADM"].ToString();
                passAuth = dt.Rows[0]["passADM"].ToString();

                if (textBoxUusarioADM.Text == userAuth && textBoxClaveADM.Text == passAuth)
                {

                    //mostrar pantallas
                    panelPrincipal2.Visible = false;
                    panel1LoginADM.Visible = false;
                    panelLoginGeneral.Visible = false;
                    panelProdList.Visible = true;

                    LimpiarInputLogin();

                }

            }




        }


        //Fing loginUusario


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
           
            panelVERGeneralNUveo.Visible = false;
            panel1LoginADM.Visible = true;
            panelLoginGeneral.Visible = true;
            panelPrincipal2.Visible = false;
            panelPrincipal2.Visible = true;

            
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
            
            panel1LoginADM.Visible = true; 
            panelPrincipal2.Visible = true;
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
            loginAdm();
        }

        private void btnINGGeneral_Click(object sender, EventArgs e)
        {
            loginUserGeneral();
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //adm

           // if (panelVERGeneral.Visible) { panelVERGeneral.Visible = false; }

            panelPrincipal2.Visible = false;
            panel1LoginADM.Visible = false;
            panelLoginGeneral.Visible = false;
            panel1LoginADM.Visible=true;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
           //Emp
           panelPrincipal2.Visible=false;

           panelVERGeneralNUveo.Visible=true;
        }

        private void btnSesionGeneral_Click(object sender, EventArgs e)
        {
            //cerrar la sesion en general
            
            panelPrincipal2.Visible=true;
        }

        private void btnIRadm_Click(object sender, EventArgs e)
        {
            panelLoginGeneral.Visible=false;
            panel1LoginADM.Visible = true;
        }

        private void btnIrGeneral_Click(object sender, EventArgs e)
        {
            panel1LoginADM.Visible = false;
            panelLoginGeneral.Visible = true;
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            panelPrincipal2.Visible = false;
            panel1LoginADM.Visible = false;
            panelLoginGeneral.Visible = false;
            panel1LoginADM.Visible = true;
        }

        private void btnEmpleado_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIRadm_Click_1(object sender, EventArgs e)
        {
            panelLoginGeneral.Visible = false;
            panel1LoginADM.Visible = true;
        }

        private void btnIrGeneral_Click_1(object sender, EventArgs e)
        {

            panel1LoginADM.Visible = false;
            panelLoginGeneral.Visible = true;
        }
    }
}