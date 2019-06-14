namespace aplicacion
{
    partial class frmHome
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
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.tsOpcionessssssss = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombreDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.msOptions.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msOptions
            // 
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpcionessssssss,
            this.tsEstadisticas,
            this.cuentaToolStripMenuItem,
            this.tsSalir});
            this.msOptions.Location = new System.Drawing.Point(0, 0);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(527, 24);
            this.msOptions.TabIndex = 0;
            this.msOptions.Text = "menuStrip1";
            // 
            // tsOpcionessssssss
            // 
            this.tsOpcionessssssss.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductosToolStripMenuItem,
            this.ProveedoresToolStripMenuItem,
            this.UserAdmin});
            this.tsOpcionessssssss.Name = "tsOpcionessssssss";
            this.tsOpcionessssssss.Size = new System.Drawing.Size(69, 20);
            this.tsOpcionessssssss.Text = "Opciones";
            // 
            // ProductosToolStripMenuItem
            // 
            this.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            this.ProductosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ProductosToolStripMenuItem.Text = "Productos";
            this.ProductosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // ProveedoresToolStripMenuItem
            // 
            this.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem";
            this.ProveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ProveedoresToolStripMenuItem.Text = "Proveedores";
            this.ProveedoresToolStripMenuItem.Click += new System.EventHandler(this.ProveedoresToolStripMenuItem_Click);
            // 
            // UserAdmin
            // 
            this.UserAdmin.Name = "UserAdmin";
            this.UserAdmin.Size = new System.Drawing.Size(139, 22);
            this.UserAdmin.Text = "Usuarios";
            this.UserAdmin.Click += new System.EventHandler(this.tsmiUsuarios_Click);
            // 
            // tsEstadisticas
            // 
            this.tsEstadisticas.Name = "tsEstadisticas";
            this.tsEstadisticas.Size = new System.Drawing.Size(79, 20);
            this.tsEstadisticas.Text = "Estadisticas";
            this.tsEstadisticas.Click += new System.EventHandler(this.tsEstadisticas_Click);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarNombreDeUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // cambiarNombreDeUsuarioToolStripMenuItem
            // 
            this.cambiarNombreDeUsuarioToolStripMenuItem.Name = "cambiarNombreDeUsuarioToolStripMenuItem";
            this.cambiarNombreDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cambiarNombreDeUsuarioToolStripMenuItem.Text = "Cambiar nombre de usuario";
            this.cambiarNombreDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarNombreDeUsuarioToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // tsSalir
            // 
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(41, 20);
            this.tsSalir.Text = "Salir";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(527, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 17);
            this.toolStripStatusLabel1.Text = "Programa cargado";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 350);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msOptions);
            this.MainMenuStrip = this.msOptions;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem tsOpcionessssssss;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem UserAdmin;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
    }
}