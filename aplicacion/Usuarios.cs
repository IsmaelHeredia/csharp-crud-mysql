// Written By Ismael Heredia in the year 2016

using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacion
{
    class Usuarios
    {
        int id_usuario;
        String nombre;
        String password;
        int tipo;
        String fecha_registro;

        public int pId_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public String pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String pPassword
        {
            get { return password; }
            set { password = value; }
        }
      
        public int pTipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String pFecha_registro
        {
            get { return fecha_registro; }
            set { fecha_registro = value; }
        }

        public Usuarios()
        {
            id_usuario = 0;
            nombre = "";
            password = "";
            tipo = 0;
            fecha_registro = "";
        }

        public Usuarios(int id_usuario, String nombre, String password, int tipo, String fecha_registro)
        {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.password = password;
            this.tipo = tipo;
            this.fecha_registro = fecha_registro;
        }

        public string ToString()
        {
            return "[+] ID Usuario : " + id_usuario + "\n" +
                   "[+] Nombre : " + nombre + "\n" +
                   "[+] Password : " + password + "\n" +
                   "[+] Tipo : " + tipo + "\n" +
                   "[+] Fecha registro : " + fecha_registro;
        }

    }
}
