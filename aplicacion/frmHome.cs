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
    public partial class frmHome : Form
    {

        AccesoDatos datos = new AccesoDatos("Data Source=localhost\\SQLEXPRESS;Initial Catalog=sistema;User ID=admin;Password=123456");
        String username = "";

        public frmHome(string username_login)
        {
            InitializeComponent();
            username = username_login;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if (datos.es_admin(username))
            {
                UserAdmin.Enabled = true;
            }
            else
            {
                UserAdmin.Enabled = false;
            }
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos form = new frmProductos();
            form.Show();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores form = new frmProveedores();
            form.Show();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Esta seguro de salir del programa ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cambiarNombreDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarUsuario formCambiarUsuario = new frmCambiarUsuario(username);
            formCambiarUsuario.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña formCambiarContraseña = new frmCambiarContraseña(username);
            formCambiarContraseña.Show();
        }

        private void tsmiUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios formUsuarios = new frmUsuarios();
            formUsuarios.Show();
        }

        private void tsEstadisticas_Click(object sender, EventArgs e)
        {
            frmReporte f2 = new frmReporte();
            f2.Show();
        }
    }
}
