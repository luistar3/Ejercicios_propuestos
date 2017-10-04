using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios_propuestos.Models;

namespace Ejercicios_propuestos.Controllers
{
    public class FiguraController : Controller
    {
        // GET: Figura
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FiguraIndex()
        {
            return View();
        }
        public ActionResult Deterfigura()
        {
            ClsFigura figura = new ClsFigura();

            double dbase = Convert.ToDouble(Request.Form["base"]);
            double daltura = Convert.ToDouble(Request.Form["altura"]);
            string entre = Request.Form["entre"];
            string pi = Request.Form["pi"];
            double diagma = Convert.ToDouble(Request.Form["diagma"]);
            double diagme = Convert.ToDouble(Request.Form["diagme"]);
            double radio = 0;
             radio = Convert.ToDouble(Request.Form["radio"]);

            if (dbase != 0 && daltura != 0)
            {
                figura.figura += "cuadraro  -   Rectangulo";

                figura.areacua = dbase * daltura;
                figura.arearec = dbase * daltura;

                if (entre =="entre")
                {
                    figura.figura += "-  triangulos";
                    figura.areatri = (dbase * daltura)/2;

                }

            }

            if (pi == "pi" && radio != 0)
            {
                figura.figura += "-  Circulo ";

                figura.areacir = 3.16 * (Math.Pow(radio, 2));
            }

            if (diagma != 0 && diagme != 0 && entre == "entre")
            {
                figura.figura += "-  rombo ";
                figura.arearom = (diagma * diagme) / 2;
            }
            return View("Deterfigura", figura);
        }
    }
}