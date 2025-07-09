using Microsoft.ApplicationBlocks.Data;
using ProyectosWeb.Clases;
using ProyectosWeb.Entidades.ENT_MCAdmin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProyectosWeb.Datos.DNG_ad_tmusua
{
    public class DNG_ad_tmusua
    {
        public static DataTable Login(E_ad_tmusua usua)
        {
            return SqlHelper.ExecuteDataTable(Cls_conexion.cadena, "sp_ad_tmusua_Q01", usua.co_usua, usua.no_clav);
        }
    }
}