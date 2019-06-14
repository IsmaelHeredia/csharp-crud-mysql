namespace aplicacion
{
    partial class frmUsuarios
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
            this.msOpciones = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarTipoAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpciones.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.gbUsuarios.SuspendLayout();
            this.ppOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // msOpciones
            // 
            this.msOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.msOpciones.Location = new System.Drawing.Point(0, 0);
            this.msOpciones.Name = "msOpciones";
            this.msOpciones.Size = new System.Drawing.Size(593, 24);
            this.msOpciones.TabIndex = 0;
            this.msOpciones.Text = "msOpciones";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.editarUsuarioToolStripMenuItem,
            this.cambiarTipoToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.grabarToolStripMenuItem,
            this.recargarListaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            this.editarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.editarUsuarioToolStripMenuItem_Click);
            // 
            // cambiarTipoToolStripMenuItem
            // 
            this.cambiarTipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.cambiarTipoToolStripMenuItem.Name = "cambiarTipoToolStripMenuItem";
            this.cambiarTipoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cambiarTipoToolStripMenuItem.Text = "Cambiar Tipo de usuario a ";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // grabarToolStripMenuItem
            // 
            this.grabarToolStripMenuItem.Name = "grabarToolStripMenuItem";
            this.grabarToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.grabarToolStripMenuItem.Text = "Grabar";
            this.grabarToolStripMenuItem.Click += new System.EventHandler(this.grabarToolStripMenuItem_Click);
            // 
            // recargarListaToolStripMenuItem
            // 
            this.recargarListaToolStripMenuItem.Name = "recargarListaToolStripMenuItem";
            this.recargarListaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.recargarListaToolStripMenuItem.Text = "Recargar Lista";
            this.recargarListaToolStripMenuItem.Click += new System.EventHandler(this.recargarListaToolStripMenuItem_Click);
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.txtID);
            this.gbUsuario.Controls.Add(this.btnGrabar);
            this.gbUsuario.Controls.Add(this.cmbTipo);
            this.gbUsuario.Controls.Add(this.txtPassword);
            this.gbUsuario.Controls.Add(this.txtUsuario);
            this.gbUsuario.Controls.Add(this.lblTipo);
            this.gbUsuario.Controls.Add(this.lblPassword);
            this.gbUsuario.Controls.Add(this.lblUsuario);
            this.gbUsuario.Location = new System.Drawing.Point(12, 38);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(210, 175);
            this.gbUsuario.TabIndex = 1;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Datos del usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 134);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(40, 20);
            this.txtID.TabIndex = 7;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(58, 134);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(99, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.cmbTipo.Location = new System.Drawing.Point(58, 91);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(136, 21);
            this.cmbTipo.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(111, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(73, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(15, 94);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(37, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo : ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 62);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password : ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(15, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario : ";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 268);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(593, 22);
            this.ssStatus.TabIndex = 2;
            this.ssStatus.Text = "ssStatus";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(105, 17);
            this.tsStatus.Text = "Programa cargado";
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.btnBuscar);
            this.gbUsuarios.Controls.Add(this.txtBuscar);
            this.gbUsuarios.Controls.Add(this.lblNombreUsuario);
            this.gbUsuarios.Controls.Add(this.lvUsuarios);
            this.gbUsuarios.Location = new System.Drawing.Point(228, 38);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(353, 212);
            this.gbUsuarios.TabIndex = 3;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Text = "Usuarios";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(249, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(86, 33);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(157, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(27, 33);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(53, 13);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre : ";
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvUsuarios.ContextMenuStrip = this.ppOpciones;
            this.lvUsuarios.FullRowSelect = true;
            this.lvUsuarios.Location = new System.Drawing.Point(15, 75);
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Size = new System.Drawing.Size(332, 118);
            this.lvUsuarios.TabIndex = 0;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.Details;
            this.lvUsuarios.SelectedIndexChanged += new System.EventHandler(this.lvUsuarios_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha registro";
            this.columnHeader4.Width = 101;
            // 
            // ppOpciones
            // 
            this.ppOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem1,
            this.editarUsuarioToolStripMenuItem1,
            this.cambiarTipoAToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem1,
            this.grabarToolStripMenuItem1,
            this.recargarListaToolStripMenuItem1});
            this.ppOpciones.Name = "ppOpciones";
            this.ppOpciones.Size = new System.Drawing.Size(161, 136);
            // 
            // agregarUsuarioToolStripMenuItem1
            // 
            this.agregarUsuarioToolStripMenuItem1.Name = "agregarUsuarioToolStripMenuItem1";
            this.agregarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.agregarUsuarioToolStripMenuItem1.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem1_Click);
            // 
            // editarUsuarioToolStripMenuItem1
            // 
            this.editarUsuarioToolStripMenuItem1.Name = "editarUsuarioToolStripMenuItem1";
            this.editarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.editarUsuarioToolStripMenuItem1.Text = "Editar Usuario";
            this.editarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.editarUsuarioToolStripMenuItem1_Click);
            // 
            // cambiarTipoAToolStripMenuItem
            // 
            this.cambiarTipoAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem1,
            this.administradorToolStripMenuItem1});
            this.cambiarTipoAToolStripMenuItem.Name = "cambiarTipoAToolStripMenuItem";
            this.cambiarTipoAToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cambiarTipoAToolStripMenuItem.Text = "Cambiar tipo a";
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuario";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // administradorToolStripMenuItem1
            // 
            this.administradorToolStripMenuItem1.Name = "administradorToolStripMenuItem1";
            this.administradorToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.administradorToolStripMenuItem1.Text = "Administrador";
            this.administradorToolStripMenuItem1.Click += new System.EventHandler(this.administradorToolStripMenuItem1_Click);
            // 
            // eliminarUsuarioToolStripMenuItem1
            // 
            this.eliminarUsuarioToolStripMenuItem1.Name = "eliminarUsuarioToolStripMenuItem1";
            this.eliminarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.eliminarUsuarioToolStripMenuItem1.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem1_Click);
            // 
            // grabarToolStripMenuItem1
            // 
            this.grabarToolStripMenuItem1.Name = "grabarToolStripMenuItem1";
            this.grabarToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.grabarToolStripMenuItem1.Text = "Grabar";
            this.grabarToolStripMenuItem1.Click += new System.EventHandler(this.grabarToolStripMenuItem1_Click);
            // 
            // recargarListaToolStripMenuItem1
            // 
            this.recargarListaToolStripMenuItem1.Name = "recargarListaToolStripMenuItem1";
            this.recargarListaToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.recargarListaToolStripMenuItem1.Text = "Recargar Lista";
            this.recargarListaToolStripMenuItem1.Click += new System.EventHandler(this.recargarListaToolStripMenuItem1_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 290);
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.msOpciones);
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.msOpciones.ResumeLayout(false);
            this.msOpciones.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            this.ppOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msOpciones;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarListaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip ppOpciones;
        private System.Windows.Forms.ToolStripMenuItem cambiarTipoAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recargarListaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem1;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem1;

    }
}