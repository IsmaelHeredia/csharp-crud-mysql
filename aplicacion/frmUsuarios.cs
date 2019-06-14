// Written By Ismael Heredia in the year 2016

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aplicacion
{
    public partial class frmUsuarios : Form
    {

        AccesoDatos datos = new AccesoDatos("Data Source=localhost\\SQLEXPRESS;Initial Catalog=sistema;User ID=admin;Password=123456");
        funciones funcion = new funciones();
        bool nuevo = true;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        // Funciones

        private void cargarUsuarios()
        {

            lvUsuarios.Items.Clear();

            string nombre_buscar = txtBuscar.Text;

            ArrayList listaUsuarios = datos.cargarListaUsuarios(nombre_buscar);

            foreach (Usuarios usuario in listaUsuarios)
            {

                int tipo = usuario.pTipo; 
                String nombre_tipo = "";

                if (tipo == 1)
                {
                    nombre_tipo = "Administrador";
                }
                else
                {
                    nombre_tipo = "Usuario";
                }

                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToString(nombre_tipo);
                item.SubItems.Add(Convert.ToString(usuario.pNombre));
                item.SubItems.Add(Convert.ToString(usuario.pFecha_registro));
                item.Tag = Convert.ToString(usuario.pId_usuario);
                lvUsuarios.Items.Add(item);
            }
        }

        private void limpiar()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            cmbTipo.SelectedIndex = -1;
        }

        private void recargarLista()
        {
            cargarUsuarios();
        }

        private bool validar()
        {

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese nombre de usuario");
                txtUsuario.Focus();
                return false;
            }
            if (nuevo)
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Ingrese contraseña");
                    txtPassword.Focus();
                    return false;
                }
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione tipo");
                cmbTipo.Focus();
                return false;
            }

            return true;
        }

        private void cargarCombo(ComboBox combo, string tabla)
        {

            DataTable dt = new DataTable();
            dt = datos.consultarTabla(tabla);
            combo.DataSource = datos.consultarTabla(tabla);
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
        }

        private void CargarCamposUsuario(int id_usuario)
        {
            Usuarios usuario = datos.cargarUsuario(id_usuario);
            txtID.Text = Convert.ToString(usuario.pId_usuario);
            txtUsuario.Text = usuario.pNombre;

            if (usuario.pTipo == 1)
            {
                cmbTipo.SelectedIndex = 1;
            }
            else
            {
                cmbTipo.SelectedIndex = 0;
            }
        }

        private void grabar()
        {
            if (validar())
            {

                int tipo = 0;

                if (cmbTipo.SelectedIndex == 1)
                {
                    tipo = 1;
                }
                else
                {
                    tipo = 2;
                }

                Usuarios u = new Usuarios();
                funciones funciones = new funciones();

                String password = funciones.md5_encode(txtPassword.Text);

                u.pNombre = txtUsuario.Text;
                u.pPassword = password;
                u.pTipo = tipo;
                u.pFecha_registro = funcion.fecha_del_dia();

                String sql = "";

                if (nuevo)
                {
                    sql = "insert into usuarios(usuario,clave,tipo,fecha_registro) values('" + u.pNombre + "','" + u.pPassword + "'," + u.pTipo + ",'" + u.pFecha_registro + "')";
                }
                else
                {
                    sql = "update usuarios set tipo=" + tipo + " where usuario='" + u.pNombre + "'";
                }

                bool grabar_ready = false;

                if (nuevo)
                {
                    if (datos.comprobar_existencia_usuario_crear(u.pNombre))
                    {
                        grabar_ready = false;
                    }
                    else
                    {
                        grabar_ready = true;
                    }
                }
                else
                {
                    grabar_ready = true;
                }

                if (grabar_ready)
                {
                    if (datos.CargarConsulta(sql))
                    {
                        if (nuevo)
                        {
                            MessageBox.Show("Registro agregado");
                            tsStatus.Text = "[+] Registro agregado";
                            this.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Registro actualizado");
                            tsStatus.Text = "[+] Registro actualizado";
                            this.Refresh();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error en la base de datos");
                        tsStatus.Text = "[-] Ha ocurrido un error en la base de datos";
                        this.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario " + u.pNombre + " ya existe");
                    tsStatus.Text = "[-] El usuario " + u.pNombre + " ya existe";
                    this.Refresh();
                }

                cargarUsuarios();
                limpiar();

            }
        }

        private void agregar()
        {

            nuevo = true;

            txtID.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";

            txtID.Enabled = true;
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;

            cmbTipo.SelectedIndex = 0;

            tsStatus.Text = "[+] Programa en modo nuevo";
            this.Refresh();
            limpiar();
            MessageBox.Show("Programa cargado en modo nuevo");

        }

        private void editar()
        {

            nuevo = false;

            txtID.Enabled = false;
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;

            tsStatus.Text = "[+] Programa en modo editar";
            this.Refresh();
            nuevo = false;
            MessageBox.Show("Programa cargado en modo editar");
        }

        private void borrar()
        {
            int id_usuario = 0;

            if (lvUsuarios.SelectedIndices.Count > 0 && lvUsuarios.SelectedIndices[0] != -1)
            {
                id_usuario = Convert.ToInt32((lvUsuarios.SelectedItems[0].Tag));
            }

            Usuarios usuario = datos.cargarUsuario(id_usuario);

            if (MessageBox.Show("Seguro de borrar a " + usuario.pNombre, "Borrar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                lvUsuarios.Items.Clear();

                string sql = "delete from usuarios where id_usuario=" + usuario.pId_usuario;

                if (datos.CargarConsulta(sql))
                {
                    MessageBox.Show("Registro borrado");
                    tsStatus.Text = "[+] Registro borrado";
                    this.Refresh();

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error en la base de datos");
                    tsStatus.Text = "[-] Ha ocurrido un error en la base de datos";
                    this.Refresh();
                }

                cargarUsuarios();
                limpiar();

            }
        }

        private void asignar(string tipo_usuario)
        {
            int id_usuario = 0;

            if (lvUsuarios.SelectedIndices.Count > 0 && lvUsuarios.SelectedIndices[0] != -1)
            {
                id_usuario = Convert.ToInt32((lvUsuarios.SelectedItems[0].Tag));
            }

            Usuarios usuario = datos.cargarUsuario(id_usuario);

            String nombre_usuario = usuario.pNombre;

            int tipo = 0;
            String rango = "";

            if (tipo_usuario == "admin")
            {
                tipo = 1;
                rango = "Administrador";
            }
            else if (tipo_usuario == "user")
            {
                tipo = 2;
                rango = "Usuario";
            }
            else
            {
                tipo = 2;
                rango = "Usuario";
            }

            if (MessageBox.Show("Seguro de asignar como " + rango + " a " + nombre_usuario, "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                lvUsuarios.Items.Clear();

                String sql = "update usuarios set tipo=" + tipo + " where usuario='" + nombre_usuario + "'";

                if (datos.CargarConsulta(sql))
                {
                    tsStatus.Text = "[+] Asignacion realizada";
                    this.Refresh();

                    MessageBox.Show("Asignacion realizada");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error en la base de datos");
                    tsStatus.Text = "[-] Ha ocurrido un error en la base de datos";
                    this.Refresh();
                }

                cargarUsuarios();

                limpiar();

            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0;
            recargarLista();
        }

        private void recargarListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            recargarLista();
        }

        private void eliminarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            asignar("user");
        }

        private void administradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            asignar("admin");
        }

        private void agregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignar("user");
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignar("admin");
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void recargarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recargarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            grabar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            recargarLista();
        }

        private void lvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsuarios.SelectedIndices.Count > 0 && lvUsuarios.SelectedIndices[0] != -1)
            {
                CargarCamposUsuario(Convert.ToInt32((lvUsuarios.SelectedItems[0].Tag)));
            }
        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void editarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void grabarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            grabar();
        }

        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grabar();
        }
    }
}
