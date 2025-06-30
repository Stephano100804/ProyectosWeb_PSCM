using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProyectosWeb.Clases
{
    public class Cls_conexion
    {
        public static string cadena
        {
            get { return ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString; }
        }
    }
}