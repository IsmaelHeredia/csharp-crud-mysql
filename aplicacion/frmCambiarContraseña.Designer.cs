namespace aplicacion
{
    partial class frmCambiarContraseña
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
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuarioActual = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtNuevaContraseña);
            this.gbDatos.Controls.Add(this.lblNuevaContraseña);
            this.gbDatos.Controls.Add(this.txtContraseña);
            this.gbDatos.Controls.Add(this.txtUsuarioActual);
            this.gbDatos.Controls.Add(this.lblContraseña);
            this.gbDatos.Controls.Add(this.lblActual);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(260, 120);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(125, 84);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(118, 20);
            this.txtNuevaContraseña.TabIndex = 5;
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(15, 84);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(104, 13);
            this.lblNuevaContraseña.TabIndex = 4;
            this.lblNuevaContraseña.Text = "Nueva contraseña : ";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(91, 50);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(152, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // txtUsuarioActual
            // 
            this.txtUsuarioActual.Location = new System.Drawing.Point(105, 23);
            this.txtUsuarioActual.Name = "txtUsuarioActual";
            this.txtUsuarioActual.ReadOnly = true;
            this.txtUsuarioActual.Size = new System.Drawing.Size(138, 20);
            this.txtUsuarioActual.TabIndex = 2;
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
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(15, 26);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(84, 13);
            this.lblActual.TabIndex = 0;
            this.lblActual.Text = "Usuario actual : ";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(49, 147);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(173, 23);
            this.btnCambiar.TabIndex = 2;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.gbDatos);
            this.MaximizeBox = false;
            this.Name = "frmCambiarContraseña";
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.frmCambiarContraseña_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuarioActual;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Button btnCambiar;

    }
}