namespace aplicacion
{
    partial class frmProveedores
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
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbProveedores = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.lvProveedores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOpcionProveedor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarProveedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbProveedor.SuspendLayout();
            this.gbProveedores.SuspendLayout();
            this.cmsOpcionProveedor.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.txtID);
            this.gbProveedor.Controls.Add(this.btn_Grabar);
            this.gbProveedor.Controls.Add(this.txtTelefono);
            this.gbProveedor.Controls.Add(this.lblTelefono);
            this.gbProveedor.Controls.Add(this.txtDireccion);
            this.gbProveedor.Controls.Add(this.lblDireccion);
            this.gbProveedor.Controls.Add(this.txtNombre);
            this.gbProveedor.Controls.Add(this.lblNombre);
            this.gbProveedor.Location = new System.Drawing.Point(12, 39);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(200, 185);
            this.gbProveedor.TabIndex = 0;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "Datos del proveedor";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 147);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(40, 20);
            this.txtID.TabIndex = 7;
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(64, 145);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_Grabar.TabIndex = 6;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(76, 108);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(109, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 111);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono : ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(76, 73);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(109, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 73);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion : ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(109, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre : ";
            // 
            // gbProveedores
            // 
            this.gbProveedores.Controls.Add(this.btnBuscar);
            this.gbProveedores.Controls.Add(this.txtBuscar);
            this.gbProveedores.Controls.Add(this.lblNombreBuscar);
            this.gbProveedores.Controls.Add(this.lvProveedores);
            this.gbProveedores.Location = new System.Drawing.Point(218, 39);
            this.gbProveedores.Name = "gbProveedores";
            this.gbProveedores.Size = new System.Drawing.Size(310, 249);
            this.gbProveedores.TabIndex = 1;
            this.gbProveedores.TabStop = false;
            this.gbProveedores.Text = "Proveedores";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(198, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(74, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(118, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(15, 35);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(53, 13);
            this.lblNombreBuscar.TabIndex = 1;
            this.lblNombreBuscar.Text = "Nombre : ";
            // 
            // lvProveedores
            // 
            this.lvProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvProveedores.ContextMenuStrip = this.cmsOpcionProveedor;
            this.lvProveedores.FullRowSelect = true;
            this.lvProveedores.Location = new System.Drawing.Point(18, 91);
            this.lvProveedores.Name = "lvProveedores";
            this.lvProveedores.Size = new System.Drawing.Size(276, 141);
            this.lvProveedores.TabIndex = 0;
            this.lvProveedores.UseCompatibleStateImageBehavior = false;
            this.lvProveedores.View = System.Windows.Forms.View.Details;
            this.lvProveedores.SelectedIndexChanged += new System.EventHandler(this.lvProveedores_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Direccion";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefono";
            this.columnHeader3.Width = 96;
            // 
            // cmsOpcionProveedor
            // 
            this.cmsOpcionProveedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProveedorToolStripMenuItem,
            this.editarProveedorToolStripMenuItem,
            this.borrarProveedorToolStripMenuItem,
            this.cancelarToolStripMenuItem,
            this.recargarListaToolStripMenuItem,
            this.grabarToolStripMenuItem});
            this.cmsOpcionProveedor.Name = "cmsOpcionProveedor";
            this.cmsOpcionProveedor.Size = new System.Drawing.Size(174, 136);
            // 
            // agregarProveedorToolStripMenuItem
            // 
            this.agregarProveedorToolStripMenuItem.Name = "agregarProveedorToolStripMenuItem";
            this.agregarProveedorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarProveedorToolStripMenuItem.Text = "Agregar Proveedor";
            this.agregarProveedorToolStripMenuItem.Click += new System.EventHandler(this.agregarProveedorToolStripMenuItem_Click);
            // 
            // editarProveedorToolStripMenuItem
            // 
            this.editarProveedorToolStripMenuItem.Name = "editarProveedorToolStripMenuItem";
            this.editarProveedorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editarProveedorToolStripMenuItem.Text = "Editar Proveedor";
            this.editarProveedorToolStripMenuItem.Click += new System.EventHandler(this.editarProveedorToolStripMenuItem_Click);
            // 
            // borrarProveedorToolStripMenuItem
            // 
            this.borrarProveedorToolStripMenuItem.Name = "borrarProveedorToolStripMenuItem";
            this.borrarProveedorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.borrarProveedorToolStripMenuItem.Text = "Borrar Proveedor";
            this.borrarProveedorToolStripMenuItem.Click += new System.EventHandler(this.borrarProveedorToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // recargarListaToolStripMenuItem
            // 
            this.recargarListaToolStripMenuItem.Name = "recargarListaToolStripMenuItem";
            this.recargarListaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.recargarListaToolStripMenuItem.Text = "Recargar lista";
            this.recargarListaToolStripMenuItem.Click += new System.EventHandler(this.recargarListaToolStripMenuItem_Click);
            // 
            // grabarToolStripMenuItem
            // 
            this.grabarToolStripMenuItem.Name = "grabarToolStripMenuItem";
            this.grabarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.grabarToolStripMenuItem.Text = "Grabar";
            this.grabarToolStripMenuItem.Click += new System.EventHandler(this.grabarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(540, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "ssStatus";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(105, 17);
            this.tsStatus.Text = "Programa cargado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProveedorToolStripMenuItem1,
            this.editarProveedorToolStripMenuItem1,
            this.borrarProveedorToolStripMenuItem1,
            this.cancelarToolStripMenuItem1,
            this.recargarListaToolStripMenuItem1,
            this.grabarToolStripMenuItem1});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarProveedorToolStripMenuItem1
            // 
            this.agregarProveedorToolStripMenuItem1.Name = "agregarProveedorToolStripMenuItem1";
            this.agregarProveedorToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.agregarProveedorToolStripMenuItem1.Text = "Agregar Proveedor";
            this.agregarProveedorToolStripMenuItem1.Click += new System.EventHandler(this.agregarProveedorToolStripMenuItem1_Click);
            // 
            // editarProveedorToolStripMenuItem1
            // 
            this.editarProveedorToolStripMenuItem1.Name = "editarProveedorToolStripMenuItem1";
            this.editarProveedorToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.editarProveedorToolStripMenuItem1.Text = "Editar Proveedor";
            this.editarProveedorToolStripMenuItem1.Click += new System.EventHandler(this.editarProveedorToolStripMenuItem1_Click);
            // 
            // borrarProveedorToolStripMenuItem1
            // 
            this.borrarProveedorToolStripMenuItem1.Name = "borrarProveedorToolStripMenuItem1";
            this.borrarProveedorToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.borrarProveedorToolStripMenuItem1.Text = "Borrar Proveedor";
            this.borrarProveedorToolStripMenuItem1.Click += new System.EventHandler(this.borrarProveedorToolStripMenuItem1_Click);
            // 
            // cancelarToolStripMenuItem1
            // 
            this.cancelarToolStripMenuItem1.Name = "cancelarToolStripMenuItem1";
            this.cancelarToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.cancelarToolStripMenuItem1.Text = "Cancelar";
            this.cancelarToolStripMenuItem1.Click += new System.EventHandler(this.cancelarToolStripMenuItem1_Click);
            // 
            // recargarListaToolStripMenuItem1
            // 
            this.recargarListaToolStripMenuItem1.Name = "recargarListaToolStripMenuItem1";
            this.recargarListaToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.recargarListaToolStripMenuItem1.Text = "Recargar Lista";
            this.recargarListaToolStripMenuItem1.Click += new System.EventHandler(this.recargarListaToolStripMenuItem1_Click);
            // 
            // grabarToolStripMenuItem1
            // 
            this.grabarToolStripMenuItem1.Name = "grabarToolStripMenuItem1";
            this.grabarToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.grabarToolStripMenuItem1.Text = "Grabar";
            this.grabarToolStripMenuItem1.Click += new System.EventHandler(this.grabarToolStripMenuItem1_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 326);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbProveedores);
            this.Controls.Add(this.gbProveedor);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            this.gbProveedores.ResumeLayout(false);
            this.gbProveedores.PerformLayout();
            this.cmsOpcionProveedor.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.GroupBox gbProveedores;
        private System.Windows.Forms.ListView lvProveedores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip cmsOpcionProveedor;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarProveedorToolStripMenuItem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarListaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarProveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarProveedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recargarListaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}