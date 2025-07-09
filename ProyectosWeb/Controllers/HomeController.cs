using System.Linq;
using System.Web.Mvc;

namespace ProyectosWeb.Controllers
{
    public class HomeController : Controller
    {
        string nombreEmpresa = ProyectosWeb.Clases.VarGlobales.StrEmpresa;

      
        public ActionResult Inicio()
        {
            ViewBag.Empresa = nombreEmpresa;
            return View();
        }

        public ActionResult Nosotros()
        {
            if (Request.UrlReferrer == null)
            {
                return RedirectToAction("Inicio", "Home");
            }

            ViewBag.Empresa = nombreEmpresa;
            return View();
        }

        public ActionResult Contactanos()
        {
            if (Request.UrlReferrer == null)
            {
                return RedirectToAction("Inicio", "Home");
            }

            ViewBag.Empresa = nombreEmpresa;
            return View();
        }
    }
}
