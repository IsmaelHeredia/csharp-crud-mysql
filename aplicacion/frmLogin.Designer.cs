namespace aplicacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.lblUsuario);
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(260, 100);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(152, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(83, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(162, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password : ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario : ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(65, 134);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(148, 23);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.gbLogin);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Aplicacion basica";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;
    }
}

