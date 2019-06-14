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
    public partial class frmCambiarUsuario : Form
    {
        AccesoDatos datos = new AccesoDatos("Data Source=localhost\\SQLEXPRESS;Initial Catalog=sistema;User ID=admin;Password=123456");
        String username = "";

        public frmCambiarUsuario(String username_login)
        {
            InitializeComponent();
            username = username_login;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioActual.Text == "" || txtContraseña.Text == "" || txtNuevoNombre.Text == "")
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                if (datos.ingreso_usuario(txtUsuarioActual.Text, txtContraseña.Text))
                {

                    bool grabar_ready = false;

                    if (datos.comprobar_existencia_usuario_editar(txtNuevoNombre.Text))
                    {
                        grabar_ready = false;
                    }
                    else
                    {
                        grabar_ready = true;
                    }

                    if (grabar_ready)
                    {
                        if (datos.cambiar_usuario(txtUsuarioActual.Text, txtNuevoNombre.Text))
                        {
                            MessageBox.Show("El nombre de usuario ha sido cambiado , reinicie la aplicacion");
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error en la base de datos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario " + txtNuevoNombre.Text + " ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
        }

        private void frmCambiarUsuario_Load(object sender, EventArgs e)
        {
            txtUsuarioActual.Text = username;
        }
    }
}
