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
    public partial class frmCambiarContraseña : Form
    {

        AccesoDatos datos = new AccesoDatos("Data Source=localhost\\SQLEXPRESS;Initial Catalog=sistema;User ID=admin;Password=123456");
        String username = "";

        public frmCambiarContraseña(String username_login)
        {
            InitializeComponent();
            username = username_login;
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {
            txtUsuarioActual.Text = username;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioActual.Text == "" || txtContraseña.Text == "" || txtNuevaContraseña.Text == "")
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                if (datos.ingreso_usuario(txtUsuarioActual.Text, txtContraseña.Text))
                {
                    if (datos.cambiar_contraseña(txtUsuarioActual.Text, txtNuevaContraseña.Text))
                    {
                        MessageBox.Show("La contraseña ha sido cambiada , reinicie la aplicacion");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error en la base de datos");
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
        }
    }
}
