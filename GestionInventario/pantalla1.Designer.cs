namespace GestionInventario
{
    partial class pantalla1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddProd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtGridProd = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnProdPanel = new System.Windows.Forms.Button();
            this.btnEntradaPanel = new System.Windows.Forms.Button();
            this.btnSalidaPanel = new System.Windows.Forms.Button();
            this.btnReporPanel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelProdList = new System.Windows.Forms.Panel();
            this.panelCrearProducto = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxPrecio = new System.Windows.Forms.TextBox();
            this.tboxDescripcion = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProd)).BeginInit();
            this.panelProdList.SuspendLayout();
            this.panelCrearProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = global::GestionInventario.Properties.Resources.Menu_operarios;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(-5, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 852);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1051, 108);
            this.label2.TabIndex = 1;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Active = false;
            this.btnAddProd.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btnAddProd.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProd.BorderRadius = 0;
            this.btnAddProd.ButtonText = "Crear Nuevo producto";
            this.btnAddProd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddProd.Iconimage")));
            this.btnAddProd.Iconimage_right = null;
            this.btnAddProd.Iconimage_right_Selected = null;
            this.btnAddProd.Iconimage_Selected = null;
            this.btnAddProd.IconMarginLeft = 0;
            this.btnAddProd.IconMarginRight = 0;
            this.btnAddProd.IconRightVisible = true;
            this.btnAddProd.IconRightZoom = 0D;
            this.btnAddProd.IconVisible = true;
            this.btnAddProd.IconZoom = 90D;
            this.btnAddProd.IsTab = false;
            this.btnAddProd.Location = new System.Drawing.Point(281, 282);
            this.btnAddProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Normalcolor = System.Drawing.Color.SlateBlue;
            this.btnAddProd.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnAddProd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProd.selected = false;
            this.btnAddProd.Size = new System.Drawing.Size(287, 45);
            this.btnAddProd.TabIndex = 2;
            this.btnAddProd.Text = "Crear Nuevo producto";
            this.btnAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProd.Textcolor = System.Drawing.Color.White;
            this.btnAddProd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // dtGridProd
            // 
            this.dtGridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombreProd,
            this.descripcion,
            this.precio,
            this.eliminar,
            this.editar});
            this.dtGridProd.Location = new System.Drawing.Point(32, 245);
            this.dtGridProd.Name = "dtGridProd";
            this.dtGridProd.RowHeadersWidth = 51;
            this.dtGridProd.RowTemplate.Height = 29;
            this.dtGridProd.Size = new System.Drawing.Size(942, 444);
            this.dtGridProd.TabIndex = 3;
            this.dtGridProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProd_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Codigo de Producto";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Width = 125;
            // 
            // nombreProd
            // 
            this.nombreProd.DataPropertyName = "nombreProd";
            this.nombreProd.HeaderText = "Nombre Producto";
            this.nombreProd.MinimumWidth = 6;
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion del Producto";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 125;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio de Producto";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 125;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar Producto";
            this.eliminar.Image = global::GestionInventario.Properties.Resources.hombre;
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.Width = 125;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar Producto";
            this.editar.Image = global::GestionInventario.Properties.Resources.usuario;
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.Width = 125;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 2;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1109, 33);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(114, 40);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnProdPanel
            // 
            this.btnProdPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProdPanel.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnProdPanel.FlatAppearance.BorderSize = 3;
            this.btnProdPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProdPanel.ForeColor = System.Drawing.Color.White;
            this.btnProdPanel.Location = new System.Drawing.Point(37, 371);
            this.btnProdPanel.Name = "btnProdPanel";
            this.btnProdPanel.Size = new System.Drawing.Size(151, 74);
            this.btnProdPanel.TabIndex = 6;
            this.btnProdPanel.Text = "Productos";
            this.btnProdPanel.UseVisualStyleBackColor = false;
            this.btnProdPanel.Click += new System.EventHandler(this.btnProdPanel_Click);
            // 
            // btnEntradaPanel
            // 
            this.btnEntradaPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEntradaPanel.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnEntradaPanel.FlatAppearance.BorderSize = 3;
            this.btnEntradaPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntradaPanel.ForeColor = System.Drawing.Color.White;
            this.btnEntradaPanel.Location = new System.Drawing.Point(37, 465);
            this.btnEntradaPanel.Name = "btnEntradaPanel";
            this.btnEntradaPanel.Size = new System.Drawing.Size(151, 69);
            this.btnEntradaPanel.TabIndex = 7;
            this.btnEntradaPanel.Text = "Entradas - Stock";
            this.btnEntradaPanel.UseVisualStyleBackColor = false;
            this.btnEntradaPanel.Click += new System.EventHandler(this.btnEntradaPanel_Click);
            // 
            // btnSalidaPanel
            // 
            this.btnSalidaPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalidaPanel.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalidaPanel.FlatAppearance.BorderSize = 3;
            this.btnSalidaPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidaPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalidaPanel.ForeColor = System.Drawing.Color.White;
            this.btnSalidaPanel.Location = new System.Drawing.Point(37, 554);
            this.btnSalidaPanel.Name = "btnSalidaPanel";
            this.btnSalidaPanel.Size = new System.Drawing.Size(151, 69);
            this.btnSalidaPanel.TabIndex = 8;
            this.btnSalidaPanel.Text = "Salidas - ventas";
            this.btnSalidaPanel.UseVisualStyleBackColor = false;
            this.btnSalidaPanel.Click += new System.EventHandler(this.btnSalidaPanel_Click);
            // 
            // btnReporPanel
            // 
            this.btnReporPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReporPanel.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnReporPanel.FlatAppearance.BorderSize = 3;
            this.btnReporPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReporPanel.ForeColor = System.Drawing.Color.White;
            this.btnReporPanel.Location = new System.Drawing.Point(37, 641);
            this.btnReporPanel.Name = "btnReporPanel";
            this.btnReporPanel.Size = new System.Drawing.Size(151, 69);
            this.btnReporPanel.TabIndex = 9;
            this.btnReporPanel.Text = "Reportes";
            this.btnReporPanel.UseVisualStyleBackColor = false;
            this.btnReporPanel.Click += new System.EventHandler(this.btnReporPanel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-5, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "20080485";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelProdList
            // 
            this.panelProdList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProdList.Controls.Add(this.dtGridProd);
            this.panelProdList.Location = new System.Drawing.Point(249, 107);
            this.panelProdList.Name = "panelProdList";
            this.panelProdList.Size = new System.Drawing.Size(1036, 741);
            this.panelProdList.TabIndex = 11;
            // 
            // panelCrearProducto
            // 
            this.panelCrearProducto.Controls.Add(this.btnEnviar);
            this.panelCrearProducto.Controls.Add(this.label9);
            this.panelCrearProducto.Controls.Add(this.label8);
            this.panelCrearProducto.Controls.Add(this.label7);
            this.panelCrearProducto.Controls.Add(this.label6);
            this.panelCrearProducto.Controls.Add(this.tboxPrecio);
            this.panelCrearProducto.Controls.Add(this.tboxDescripcion);
            this.panelCrearProducto.Controls.Add(this.tboxNombre);
            this.panelCrearProducto.Controls.Add(this.tboxCodigo);
            this.panelCrearProducto.Controls.Add(this.label5);
            this.panelCrearProducto.Controls.Add(this.label4);
            this.panelCrearProducto.Location = new System.Drawing.Point(246, 92);
            this.panelCrearProducto.Name = "panelCrearProducto";
            this.panelCrearProducto.Size = new System.Drawing.Size(1036, 738);
            this.panelCrearProducto.TabIndex = 4;
            this.panelCrearProducto.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(432, 622);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(130, 44);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(303, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(303, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(303, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(303, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Codigo";
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tboxPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxPrecio.ForeColor = System.Drawing.Color.White;
            this.tboxPrecio.Location = new System.Drawing.Point(432, 523);
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.Size = new System.Drawing.Size(268, 34);
            this.tboxPrecio.TabIndex = 5;
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tboxDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxDescripcion.ForeColor = System.Drawing.Color.White;
            this.tboxDescripcion.Location = new System.Drawing.Point(432, 404);
            this.tboxDescripcion.Multiline = true;
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.Size = new System.Drawing.Size(268, 92);
            this.tboxDescripcion.TabIndex = 4;
            // 
            // tboxNombre
            // 
            this.tboxNombre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tboxNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxNombre.ForeColor = System.Drawing.Color.White;
            this.tboxNombre.Location = new System.Drawing.Point(432, 335);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(268, 34);
            this.tboxNombre.TabIndex = 3;
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tboxCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxCodigo.ForeColor = System.Drawing.Color.White;
            this.tboxCodigo.Location = new System.Drawing.Point(432, 264);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(268, 34);
            this.tboxCodigo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(265, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(499, 549);
            this.label5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(406, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nuevos Productos ";
            // 
            // pantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 842);
            this.Controls.Add(this.panelCrearProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReporPanel);
            this.Controls.Add(this.btnSalidaPanel);
            this.Controls.Add(this.btnEntradaPanel);
            this.Controls.Add(this.btnProdPanel);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelProdList);
            this.MaximizeBox = false;
            this.Name = "pantalla1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fo - Gestion de inventario";
            this.Load += new System.EventHandler(this.pantalla1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProd)).EndInit();
            this.panelProdList.ResumeLayout(false);
            this.panelCrearProducto.ResumeLayout(false);
            this.panelCrearProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProd;
        private DataGridView dtGridProd;
        private Button btnCerrarSesion;
        private Button btnProdPanel;
        private Button btnEntradaPanel;
        private Button btnSalidaPanel;
        private Button btnReporPanel;
        private Label label3;
        private Panel panelProdList;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombreProd;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewImageColumn eliminar;
        private DataGridViewImageColumn editar;
        private Panel panelCrearProducto;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox tboxPrecio;
        private TextBox tboxDescripcion;
        private TextBox tboxNombre;
        private TextBox tboxCodigo;
        private Label label5;
        private Label label4;
        private Button btnEnviar;
    }
}