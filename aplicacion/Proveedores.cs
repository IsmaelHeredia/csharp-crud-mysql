// Written By Ismael Heredia in the year 2016

using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacion
{
    class Proveedores
    {
        int id_proveedor;
        String nombre_empresa;
        String direccion;
        int telefono;
        String fecha_registro;

        public int pId_proveedor
        {
            get { return id_proveedor; }
            set { id_proveedor = value; }
        }

        public String pNombre_empresa
        {
            get { return nombre_empresa; }
            set { nombre_empresa = value; }
        }

        public String pDireccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int pTelefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String pFecha_registro
        {
            get { return fecha_registro; }
            set { fecha_registro = value; }
        }

        public Proveedores()
        {
            id_proveedor = 0;
            nombre_empresa = "";
            direccion = "";
            telefono = 0;
            fecha_registro = "";
        }

        public Proveedores(int id_proveedor,String nombre_empresa,String direccion,int telefono,String fecha_registro)
        {
            this.id_proveedor = id_proveedor;
            this.nombre_empresa = nombre_empresa;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fecha_registro = fecha_registro;
        }

        public string ToString()
        {
            return "[+] ID Proveedor : " + id_proveedor + "\n" +
                   "[+] Nombre empresa : " + nombre_empresa + "\n" +
                   "[+] Telefono : " + telefono + "\n" +
                   "[+] Fecha registro : " + fecha_registro;
        }
    }
}
