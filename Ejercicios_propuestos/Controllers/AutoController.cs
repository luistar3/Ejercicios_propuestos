using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios_propuestos.Models;

namespace Ejercicios_propuestos.Controllers
{
    public class AutoController : Controller
    {
        // GET: Auto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AutoIndex()
        {
            return View();
        }
        public ActionResult AutoCalcular()
        {
            ClsAuto auto = new ClsAuto();

            string t = Request.Form["tipo"];
            double km = Convert.ToDouble(Request.Form["km"]);
            int dias = Convert.ToInt32(Request.Form["dias"]);
            double total = 0;
            if (t == "chico")
            {
                total = dias * 15 + (km * 20);
            }
            else if (t == "mediano")
            {
                total = dias * 20 + (km * 30);
            }
            else
            {
                total = dias * 30 + (km * 40);
            }
            auto.tipo = t;
            auto.dias = dias;
            auto.km = km;
            auto.total = total;

            return View("AutoCalcular", auto);
        }
    }
}