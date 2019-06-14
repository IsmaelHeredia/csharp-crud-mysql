// Written By Ismael Heredia in the year 2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aplicacion
{
    public partial class frmLogin : Form
    {

        AccesoDatos datos = new AccesoDatos("Data Source=localhost\\SQLEXPRESS;Initial Catalog=sistema;User ID=admin;Password=123456");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Datos incorrectos");
            }
            else
            {

                if (datos.ingreso_usuario(txtUsuario.Text, txtPassword.Text))
                {
                    if (datos.es_admin(txtUsuario.Text))
                    {
                        MessageBox.Show("Bienvenido administrador " + txtUsuario.Text + " al sistema");

                        frmLogin.ActiveForm.Hide();

                        frmHome formHome = new frmHome(txtUsuario.Text);
                        formHome.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido usuario " + txtUsuario.Text + " al sistema");

                        frmLogin.ActiveForm.Hide();

                        frmHome formHome = new frmHome(txtUsuario.Text);
                        formHome.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            /*
            Proveedores proveedor = new Proveedores(0,"test","test",0,"test");
            Productos producto = new Productos(0,"test","test",0,"test",0);
            Usuarios usuario = new Usuarios(0,"test","test",0,"test");
            MessageBox.Show(proveedor.ToString());
            MessageBox.Show(producto.ToString());
            MessageBox.Show(usuario.ToString());
            */
        }
    }
}
