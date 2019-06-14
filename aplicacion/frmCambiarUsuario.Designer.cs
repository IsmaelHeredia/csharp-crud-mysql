namespace aplicacion
{
    partial class frmCambiarUsuario
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblActual = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuarioActual = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtNuevoNombre);
            this.gbDatos.Controls.Add(this.lblNuevoNombre);
            this.gbDatos.Controls.Add(this.txtContraseña);
            this.gbDatos.Controls.Add(this.txtUsuarioActual);
            this.gbDatos.Controls.Add(this.lblContraseña);
            this.gbDatos.Controls.Add(this.lblActual);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(260, 120);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(15, 26);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(84, 13);
            this.lblActual.TabIndex = 0;
            this.lblActual.Text = "Usuario actual : ";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(15, 50);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(70, 13);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña : ";
            // 
            // txtUsuarioActual
            // 
            this.txtUsuarioActual.Location = new System.Drawing.Point(105, 23);
            this.txtUsuarioActual.Name = "txtUsuarioActual";
            this.txtUsuarioActual.ReadOnly = true;
            this.txtUsuarioActual.Size = new System.Drawing.Size(138, 20);
            this.txtUsuarioActual.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(91, 50);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(152, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(15, 84);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(86, 13);
            this.lblNuevoNombre.TabIndex = 4;
            this.lblNuevoNombre.Text = "Nuevo nombre : ";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(105, 84);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNuevoNombre.TabIndex = 5;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(53, 156);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(173, 23);
            this.btnCambiar.TabIndex = 1;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // frmCambiarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.gbDatos);
            this.MaximizeBox = false;
            this.Name = "frmCambiarUsuario";
            this.Text = "Cambiar nombre de usuario";
            this.Load += new System.EventHandler(this.frmCambiarUsuario_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.TextBox txtUsuarioActual;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.Button btnCambiar;
    }
}