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
    public partial class frmProductos : Form
    {

        AccesoDatos datos = new AccesoDatos("Data Source=localhost\\SQLEXPRESS;Initial Catalog=sistema;User ID=admin;Password=123456");
        funciones funcion = new funciones();
        bool nuevo = true;

        public frmProductos()
        {
            InitializeComponent();
        }

        // Funciones

        private void cargarProductos()
        {

            lvProductos.Items.Clear();

            string nombre_buscar = txtNombreBuscar.Text;

            ArrayList listaProductos = datos.cargarListaProductos(nombre_buscar);

            foreach (Productos producto in listaProductos)
            {

                String nombre_empresa = datos.nombre_proveedor(producto.pId_proveedor);

                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToString(producto.pNombre_producto);
                item.SubItems.Add(Convert.ToString(producto.pDescripcion));
                item.SubItems.Add(Convert.ToString(producto.pPrecio));
                item.SubItems.Add(Convert.ToString(producto.pFecha_registro));
                item.SubItems.Add(Convert.ToString(nombre_empresa));
                item.Tag = Convert.ToString(producto.pId_producto);
                lvProductos.Items.Add(item);
            }
        }

        private bool valid_number(String numberString)
        {
            int number;
            return int.TryParse(numberString, out number);
        }

        private bool validar()
        {

            if(txtNombre.Text=="") {
                MessageBox.Show("Ingrese nombre");
                txtNombre.Focus();
                return false;
            }
            if(rtbDescripcion.Text=="") {
                MessageBox.Show("Ingrese descripcion");
                rtbDescripcion.Focus();
                return false;
            }
            if(cmbProveedor.SelectedIndex==-1) {
                MessageBox.Show("Seleccione proveedor");
                cmbProveedor.Focus();
                return false;
            }
            if (txtPrecio.Text == "" || !valid_number(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese precio");
                txtPrecio.Focus();
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

        private void limpiar()
        {
            nuevo = true;
            txtID.Text = "";
            txtNombre.Text = "";
            rtbDescripcion.Text = "";
            txtPrecio.Text = "";
            cmbProveedor.SelectedIndex = -1;
        }

        private void CargarCamposProductos(int id_producto)
        {
            Productos producto = datos.cargarProducto(id_producto);
            txtID.Text = producto.pId_producto.ToString();
            txtNombre.Text = producto.pNombre_producto;
            rtbDescripcion.Text = producto.pDescripcion;
            cmbProveedor.SelectedValue = producto.pId_proveedor;
            txtPrecio.Text = producto.pPrecio.ToString();
        }

        private void grabar()
        {
            if (validar())
            {

                Productos p = new Productos();
                if (txtID.Text != "")
                {
                    p.pId_producto = Convert.ToInt32(txtID.Text);
                }
                p.pNombre_producto = txtNombre.Text;
                p.pDescripcion = rtbDescripcion.Text;
                p.pPrecio = Convert.ToDouble(txtPrecio.Text);
                p.pId_proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                p.pFecha_registro = funcion.fecha_del_dia();

                string sql = "";

                if (nuevo)
                {
                    sql = "insert into productos(nombre_producto,descripcion,precio,id_proveedor,fecha_registro) values('" + p.pNombre_producto + "','" + p.pDescripcion + "'," + p.pPrecio + "," + p.pId_proveedor + ",'" + p.pFecha_registro + "')";
                }
                else
                {
                    sql = "update productos set nombre_producto='" + p.pNombre_producto + "',descripcion='" + p.pDescripcion + "',precio=" + p.pPrecio + ",id_proveedor='" + p.pId_proveedor +  "'" +  " where id_producto=" + p.pId_producto;
                }

                bool grabar_ready = false;

                if (nuevo)
                {
                    if (datos.comprobar_existencia_producto_crear(p.pNombre_producto))
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
                    if (datos.comprobar_existencia_producto_editar(p.pId_producto,p.pNombre_producto))
                    {
                        grabar_ready = false;
                    }
                    else
                    {
                        grabar_ready = true;
                    }
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
                    MessageBox.Show("El producto " + p.pNombre_producto + " ya existe");
                    tsStatus.Text = "[-] El producto " + p.pNombre_producto + " ya existe";
                    this.Refresh();
                }

                cargarProductos();
                limpiar();

            }
        }

        private void agregar()
        {
            tsStatus.Text = "[+] Programa en modo nuevo";
            this.Refresh();
            nuevo = true;
            limpiar();
            MessageBox.Show("Programa cargado en modo nuevo");

        }

        private void editar()
        {
            tsStatus.Text = "[+] Programa en modo editar";
            this.Refresh();
            nuevo = false;
            MessageBox.Show("Programa cargado en modo editar");
        }

        private void borrar()
        {
            int id_producto = 0;

            if (lvProductos.SelectedIndices.Count > 0 && lvProductos.SelectedIndices[0] != -1)
            {
                id_producto = Convert.ToInt32((lvProductos.SelectedItems[0].Tag));
            }

            Productos producto = datos.cargarProducto(id_producto);

            if (MessageBox.Show("Seguro de borrar a " + producto.pNombre_producto, "Borrar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                lvProductos.Items.Clear();

                string sql = "delete from productos where id_producto=" + producto.pId_producto;

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

                cargarProductos();
                limpiar();

            }
        }

        private void cancelar()
        {
            tsStatus.Text = "[+] Programa cargado";
            this.Refresh();
            nuevo = false;
            limpiar();
            MessageBox.Show("Opcion cancelada");
        }

        private void recargarLista()
        {
            cargarProductos();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cargarCombo(cmbProveedor, "proveedores");
            cargarProductos();
        }

        private void lvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProductos.SelectedIndices.Count > 0 && lvProductos.SelectedIndices[0] != -1)
            {
                CargarCamposProductos(Convert.ToInt32((lvProductos.SelectedItems[0].Tag)));
            }
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void borrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void recargarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recargarLista();
        }

        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grabar();
        }

        private void agregarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void editarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void borrarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void cancelarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void recargarListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            recargarLista();
        }

        private void grabarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            grabar();
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            grabar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            recargarLista();
        }

    }
}