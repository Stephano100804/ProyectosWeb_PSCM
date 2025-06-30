using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectosWeb.Clases
{
    public class Funciones
    {
        public DataTable Retorna_Tabla(string strSQLConsulta)
        {
            SqlConnection cnx = new SqlConnection(Cls_conexion.cadena);
            cnx.Open();
            SqlCommand comando = new SqlCommand(strSQLConsulta, cnx);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tbl = new DataTable();
            adaptador.Fill(tbl);
            cnx.Close();
            return tbl;
        }
    }
}