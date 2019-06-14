// Written By Ismael Heredia in the year 2016

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace aplicacion
{
    class Conexion
    {
        public MySqlConnection conexion;
        public MySqlCommand comando;
        public MySqlDataReader dr;
        public DataTable dt;

        public Conexion()
        {
            conexion = new MySqlConnection();
            comando = new MySqlCommand();
            dt = new DataTable();
            dr = null;
        }

        public void abrir()
        {
            conexion.ConnectionString = "SERVER=localhost;" + "DATABASE=sistema;" + "UID=root;" + "PASSWORD=;";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void cerrar()
        {
            conexion.Close();
            conexion.Dispose();
        }
    }
}
