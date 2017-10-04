using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios_propuestos.Models;

namespace Ejercicios_propuestos.Controllers
{
    public class CambioController : Controller
    {
        // GET: Cambio
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult vistamoneda()
        {
            return View();
        }
        public ActionResult Calmoneda()
        {
            Cambio cambio = new Cambio();

            double cam = Convert.ToDouble(Request.Form["cantidad"]);
            string t = Request.Form["moneda"];

            cambio.moneda = t;

            cambio.cantidad = cam;


            if (t == "euro")
            {
                cambio.cambio = cam * 0.26;
            }
            else if (t=="yen")
            {
                cambio.cambio = cam * 34.49;
            }
            else if (t == "dolar")
            {
                cambio.cambio = cam * 0.30;
            }
            else
            {
                cambio.cambio = cam * 193.00;
            }

            return View("Calmoneda",cambio);
        }
    }
}