// Written By Ismael Heredia in the year 2016

// Clase AccesoDatos

using System;
using System.Collections;
using System.Text;

using System.Data;
using MySql.Data.MySqlClient;

namespace aplicacion
{
    class AccesoDatos
    {

        public AccesoDatos()
        {
            //
        }

        public AccesoDatos(string cadenaConexion)
        {
            //
        }

        public DataTable consultarTabla(string tabla)
        {
            Conexion conexion = new Conexion();
            conexion.abrir();
            DataTable dt = new DataTable();
            conexion.comando.CommandText = "select * from " + tabla;
            dt.Load(conexion.comando.ExecuteReader());
            conexion.cerrar();
            return dt;
        }

        public ArrayList cargarListaProveedores(string patron)
        {
            ArrayList listaProveedores = new ArrayList();
            Conexion conexion = new Conexion();
            conexion.abrir();
            conexion.comando.CommandText = "select * from proveedores where nombre_empresa like '%"+patron+"%'";
            var reader = conexion.comando.ExecuteReader();
            while (reader.Read())
            {
                Proveedores proveedor = new Proveedores();
                if (!reader.IsDBNull(0))
                {
                    proveedor.pId_proveedor = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    proveedor.pNombre_empresa = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    proveedor.pDireccion = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    proveedor.pTelefono = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    proveedor.pFecha_registro = reader.GetString(4);
                }
                listaProveedores.Add(proveedor);
            }
            conexion.cerrar();
            return listaProveedores;
        }

        public Proveedores cargarProveedor(int id_proveedor)
        {

            Proveedores proveedor = new Proveedores();

            Conexion conexion = new Conexion();
            conexion.abrir();

            conexion.comando.CommandText = "select * from proveedores where id_proveedor=" + id_proveedor;
            var reader = conexion.comando.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    if (!reader.IsDBNull(0))
                    {
                        proveedor.pId_proveedor = reader.GetInt32(0);
                    }
                    if (!reader.IsDBNull(1))
                    {
                        proveedor.pNombre_empresa = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        proveedor.pDireccion = reader.GetString(2);
                    }
                    if (!reader.IsDBNull(3))
                    {
                        proveedor.pTelefono = reader.GetInt32(3);
                    }
                    if (!reader.IsDBNull(4))
                    {
                        proveedor.pFecha_registro = reader.GetString(4);
                    }
                }
            }

            conexion.cerrar();

            return proveedor;

        }

        public ArrayList cargarListaProductos(string patron)
        {
            ArrayList listaProductos = new ArrayList();
            Conexion conexion = new Conexion();
            conexion.abrir();
            conexion.comando.CommandText = "select * from productos where nombre_producto like '%" + patron + "%'";
            var reader = conexion.comando.ExecuteReader();
            while (reader.Read())
            {
                Productos producto = new Productos();

                if (!reader.IsDBNull(0))
                {
                    producto.pId_producto = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    producto.pNombre_producto = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    producto.pDescripcion = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    producto.pPrecio = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    producto.pId_proveedor = reader.GetInt32(4);
                }
                if (!reader.IsDBNull(5))
                {
                    producto.pFecha_registro = reader.GetString(5);
                }

                listaProductos.Add(producto);
            }
            conexion.cerrar();
            return listaProductos;
        }

        public Productos cargarProducto(int id_producto)
        {
            Productos producto = new Productos();
            Conexion conexion = new Conexion();
            conexion.abrir();
            conexion.comando.CommandText = "select * from productos where id_producto="+id_producto;
            var reader = conexion.comando.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    producto.pId_producto = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    producto.pNombre_producto = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    producto.pDescripcion = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    producto.pPrecio = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    producto.pId_proveedor = reader.GetInt32(4);
                }
                if (!reader.IsDBNull(5))
                {
                    producto.pFecha_registro = reader.GetString(5);
                }
            }
            conexion.cerrar();
            return producto;
        }

        public ArrayList cargarListaUsuarios(string patron)
        {
            ArrayList listaUsuarios = new ArrayList();
            Conexion conexion = new Conexion();
            conexion.abrir();
            conexion.comando.CommandText = "select * from usuarios where usuario like '%" + patron + "%'";
            var reader = conexion.comando.ExecuteReader();
            while (reader.Read())
            {
                Usuarios usuario = new Usuarios();
                if (!reader.IsDBNull(0))
                {
                    usuario.pId_usuario = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    usuario.pNombre = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    usuario.pPassword = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    usuario.pTipo = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    usuario.pFecha_registro = reader.GetString(4);
                }
                listaUsuarios.Add(usuario);
            }
            conexion.cerrar();
            return listaUsuarios;
        }

        public Usuarios cargarUsuario(int id_usuario)
        {
            Usuarios usuario = new Usuarios();
            Conexion conexion = new Conexion();
            conexion.abrir();
            conexion.comando.CommandText = "select * from usuarios where id_usuario="+id_usuario;
            var reader = conexion.comando.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    usuario.pId_usuario = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    usuario.pNombre = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    usuario.pPassword = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    usuario.pTipo = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    usuario.pFecha_registro = reader.GetString(4);
                }
            }
            conexion.cerrar();
            return usuario;
        }

        public bool CargarConsulta(string sql)
        {
            Boolean response = false;
            Conexion conexion = new Conexion();
            conexion.abrir();
            try
            {
                conexion.comando.CommandText = sql;
                conexion.comando.ExecuteNonQuery();
                response = true;
            }
            catch
            {
                response = false;
            }
            conexion.cerrar();
            return response;
        }

        public int EjecutarConsulta(string sql)
        {

            int length = 0;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                DataTable dt = new DataTable();
                conexion.comando.CommandText = sql;
                dt.Load(conexion.comando.ExecuteReader());
                length = dt.Rows.Count;
            }
            catch
            {
                length = 0;
            }

            conexion.cerrar();

            return length;

        }

        public Boolean ingreso_usuario(string username, string password)
        {
            funciones funcion = new funciones();
            password = funcion.md5_encode(password);

            int length = 0;

            bool response = false;

            Conexion conexion = new Conexion();
            conexion.abrir();
            DataTable dt = new DataTable();
            conexion.comando.CommandText = "select id_usuario from usuarios where usuario='" + username + "' and clave='" + password + "'";
            dt.Load(conexion.comando.ExecuteReader());
            length = dt.Rows.Count;
            conexion.cerrar();

            if (length >= 1)
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
            
        }

        public Boolean es_admin(String username)
        {
            Boolean response = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            conexion.comando.CommandText = "select tipo from usuarios where usuario='"+username+"'";
            var reader = conexion.comando.ExecuteReader();

            if(reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    int tipo = reader.GetInt32(0);
                    if (tipo == 1)
                    {
                        response = true;
                    }
                    else
                    {
                        response = false;
                    }
                }
            }

            conexion.cerrar();

            return response;
        }

        public String nombre_proveedor(int id_proveedor)
        {

            String nombre_empresa = "";

            Conexion conexion = new Conexion();
            conexion.abrir();

            conexion.comando.CommandText = "select nombre_empresa from proveedores where id_proveedor='" + id_proveedor + "'";
            var reader = conexion.comando.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    nombre_empresa = reader.GetString(0);
                }
            }

            conexion.cerrar();

            return nombre_empresa;
        }

        public int get_id_by_username(String nombre_usuario)
        {

            int id_usuario = 0;

            Conexion conexion = new Conexion();
            conexion.abrir();

            conexion.comando.CommandText = "select id_usuario from usuarios where usuario like '"+nombre_usuario+"'";
            var reader = conexion.comando.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    id_usuario = reader.GetInt32(0);

                }
            }

            conexion.cerrar();

            return id_usuario;
        }

        public bool cambiar_usuario(String username,String new_username)
        {
            Boolean respuesta = false;
            String sql = "update usuarios set usuario='"+new_username+"' where usuario='"+username+"'";
            try
            {
                Conexion conexion = new Conexion();
                conexion.abrir();
                conexion.comando.CommandText = sql;
                conexion.comando.ExecuteNonQuery();
                conexion.cerrar();
                respuesta = true;
            }
            catch
            {
                respuesta = false;
            }
            return respuesta;
        }

        public bool cambiar_contraseña(String username, String new_password)
        {
            Boolean respuesta = false;
            funciones funcion = new funciones();
            String password = funcion.md5_encode(new_password);

            String sql = "update usuarios set clave='" + password + "' where usuario='" + username + "'";
            try
            {
                Conexion conexion = new Conexion();
                conexion.abrir();
                conexion.comando.CommandText = sql;
                conexion.comando.ExecuteNonQuery();
                conexion.cerrar();
                respuesta = true;
            }
            catch
            {
                respuesta = false;
            }
            return respuesta;
        }

        public bool comprobar_existencia_producto_crear(String nombre_producto)
        {
            Boolean respuesta = false;
            String sql = "select * from productos where nombre_producto like '"+nombre_producto+"'";
            if (EjecutarConsulta(sql) >= 1)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }

        public bool comprobar_existencia_producto_editar(int id_producto,String nombre_producto)
        {
            Boolean respuesta = false;
            String sql = "select * from productos where nombre_producto like '" + nombre_producto + "' and id_producto!="+id_producto;
            if (EjecutarConsulta(sql) >= 1)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }

        public bool comprobar_existencia_proveedor_crear(String nombre_empresa)
        {
            Boolean respuesta = false;
            String sql = "select * from proveedores where nombre_empresa like '" + nombre_empresa + "'";
            if (EjecutarConsulta(sql) >= 1)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }

        public bool comprobar_existencia_proveedor_editar(int id_proveedor,String nombre_empresa)
        {
            Boolean respuesta = false;
            String sql = "select * from proveedores where nombre_empresa like '" + nombre_empresa + "' and id_proveedor!=" + id_proveedor;
            if (EjecutarConsulta(sql) >= 1)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }

        public bool comprobar_existencia_usuario_crear(String nombre_usuario)
        {
            Boolean respuesta = false;
            String sql = "select * from usuarios where usuario like '" + nombre_usuario + "'";
            if (EjecutarConsulta(sql) >= 1)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }

        public bool comprobar_existencia_usuario_editar(String nombre_usuario)
        {
            Boolean respuesta = false;
            String sql = "select * from usuarios where usuario like '" + nombre_usuario + "'";
            if (EjecutarConsulta(sql) >= 1)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }

    }
}