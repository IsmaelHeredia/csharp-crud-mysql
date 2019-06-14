namespace aplicacion
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOpcionProducto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbProducto.SuspendLayout();
            this.gbProductos.SuspendLayout();
            this.cmsOpcionProducto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.txtID);
            this.gbProducto.Controls.Add(this.cmbProveedor);
            this.gbProducto.Controls.Add(this.lblProveedor);
            this.gbProducto.Controls.Add(this.btn_Grabar);
            this.gbProducto.Controls.Add(this.txtPrecio);
            this.gbProducto.Controls.Add(this.lblPrecio);
            this.gbProducto.Controls.Add(this.rtbDescripcion);
            this.gbProducto.Controls.Add(this.lblDescripcion);
            this.gbProducto.Controls.Add(this.txtNombre);
            this.gbProducto.Controls.Add(this.lblNombre);
            this.gbProducto.Location = new System.Drawing.Point(12, 27);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(200, 354);
            this.gbProducto.TabIndex = 0;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Datos del producto";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(101, 65);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(48, 20);
            this.txtID.TabIndex = 9;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(79, 216);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(98, 21);
            this.cmbProveedor.TabIndex = 8;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(18, 219);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(65, 13);
            this.lblProveedor.TabIndex = 7;
            this.lblProveedor.Text = "Proveedor : ";
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(40, 301);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(109, 23);
            this.btn_Grabar.TabIndex = 6;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(68, 254);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(16, 254);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio : ";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(21, 102);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(156, 96);
            this.rtbDescripcion.TabIndex = 3;
            this.rtbDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 72);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion : ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre : ";
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.btnBuscar);
            this.gbProductos.Controls.Add(this.txtNombreBuscar);
            this.gbProductos.Controls.Add(this.lblNombreBuscar);
            this.gbProductos.Controls.Add(this.lvProductos);
            this.gbProductos.Location = new System.Drawing.Point(218, 27);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(506, 354);
            this.gbProductos.TabIndex = 1;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(279, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(208, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(84, 36);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(189, 20);
            this.txtNombreBuscar.TabIndex = 2;
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(25, 36);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(53, 13);
            this.lblNombreBuscar.TabIndex = 1;
            this.lblNombreBuscar.Text = "Nombre : ";
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvProductos.ContextMenuStrip = this.cmsOpcionProducto;
            this.lvProductos.FullRowSelect = true;
            this.lvProductos.Location = new System.Drawing.Point(19, 90);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(468, 245);
            this.lvProductos.TabIndex = 0;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            this.lvProductos.SelectedIndexChanged += new System.EventHandler(this.lvProductos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 49;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Proveedor";
            this.columnHeader5.Width = 122;
            // 
            // cmsOpcionProducto
            // 
            this.cmsOpcionProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.editarProductoToolStripMenuItem,
            this.borrarProductoToolStripMenuItem,
            this.cancelarToolStripMenuItem,
            this.recargarListaToolStripMenuItem,
            this.grabarToolStripMenuItem});
            this.cmsOpcionProducto.Name = "cmsOpcionProducto";
            this.cmsOpcionProducto.Size = new System.Drawing.Size(169, 136);
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editarProductoToolStripMenuItem.Text = "Editar Producto";
            this.editarProductoToolStripMenuItem.Click += new System.EventHandler(this.editarProductoToolStripMenuItem_Click);
            // 
            // borrarProductoToolStripMenuItem
            // 
            this.borrarProductoToolStripMenuItem.Name = "borrarProductoToolStripMenuItem";
            this.borrarProductoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.borrarProductoToolStripMenuItem.Text = "Borrar Producto";
            this.borrarProductoToolStripMenuItem.Click += new System.EventHandler(this.borrarProductoToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // recargarListaToolStripMenuItem
            // 
            this.recargarListaToolStripMenuItem.Name = "recargarListaToolStripMenuItem";
            this.recargarListaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.recargarListaToolStripMenuItem.Text = "Recargar lista";
            this.recargarListaToolStripMenuItem.Click += new System.EventHandler(this.recargarListaToolStripMenuItem_Click);
            // 
            // grabarToolStripMenuItem
            // 
            this.grabarToolStripMenuItem.Name = "grabarToolStripMenuItem";
            this.grabarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.grabarToolStripMenuItem.Text = "Grabar";
            this.grabarToolStripMenuItem.Click += new System.EventHandler(this.grabarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem1,
            this.editarProductoToolStripMenuItem1,
            this.borrarProductoToolStripMenuItem1,
            this.cancelarToolStripMenuItem1,
            this.recargarListaToolStripMenuItem1,
            this.grabarToolStripMenuItem1});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarProductoToolStripMenuItem1
            // 
            this.agregarProductoToolStripMenuItem1.Name = "agregarProductoToolStripMenuItem1";
            this.agregarProductoToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.agregarProductoToolStripMenuItem1.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem1.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem1_Click);
            // 
            // editarProductoToolStripMenuItem1
            // 
            this.editarProductoToolStripMenuItem1.Name = "editarProductoToolStripMenuItem1";
            this.editarProductoToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.editarProductoToolStripMenuItem1.Text = "Editar Producto";
            this.editarProductoToolStripMenuItem1.Click += new System.EventHandler(this.editarProductoToolStripMenuItem1_Click);
            // 
            // borrarProductoToolStripMenuItem1
            // 
            this.borrarProductoToolStripMenuItem1.Name = "borrarProductoToolStripMenuItem1";
            this.borrarProductoToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.borrarProductoToolStripMenuItem1.Text = "Borrar Producto";
            this.borrarProductoToolStripMenuItem1.Click += new System.EventHandler(this.borrarProductoToolStripMenuItem1_Click);
            // 
            // cancelarToolStripMenuItem1
            // 
            this.cancelarToolStripMenuItem1.Name = "cancelarToolStripMenuItem1";
            this.cancelarToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.cancelarToolStripMenuItem1.Text = "Cancelar";
            this.cancelarToolStripMenuItem1.Click += new System.EventHandler(this.cancelarToolStripMenuItem1_Click);
            // 
            // recargarListaToolStripMenuItem1
            // 
            this.recargarListaToolStripMenuItem1.Name = "recargarListaToolStripMenuItem1";
            this.recargarListaToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.recargarListaToolStripMenuItem1.Text = "Recargar lista";
            this.recargarListaToolStripMenuItem1.Click += new System.EventHandler(this.recargarListaToolStripMenuItem1_Click);
            // 
            // grabarToolStripMenuItem1
            // 
            this.grabarToolStripMenuItem1.Name = "grabarToolStripMenuItem1";
            this.grabarToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.grabarToolStripMenuItem1.Text = "Grabar";
            this.grabarToolStripMenuItem1.Click += new System.EventHandler(this.grabarToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(105, 17);
            this.tsStatus.Text = "Programa cargado";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.gbProducto);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            this.cmsOpcionProducto.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip cmsOpcionProducto;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarProductoToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recargarListaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}