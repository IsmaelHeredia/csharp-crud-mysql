// Written By Ismael Heredia in the year 2016

using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacion
{
    class funciones
    {
        public string md5_encode(string input)
        {

            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        public String fecha_del_dia()
        {
            DateTime Hoy = DateTime.Today;

            string fecha_actual = Hoy.ToString("yyyy-MM-dd");

            return fecha_actual;
        }

    }
}
