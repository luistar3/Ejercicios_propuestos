using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios_propuestos.Models;

namespace Ejercicios_propuestos.Controllers
{
    public class EntradaController : Controller
    {
        // GET: Entrada
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EntradaIndex()
        {
            return View();
        }
        public ActionResult CalcularEntrada()
        {
            ClsEntrada Objentrada = new ClsEntrada();

            Objentrada.dia = Request.Form["dia"];
            Objentrada.edad = Convert.ToInt32(Request.Form["edad"]);
            Objentrada.precio = 100;
            double des = 0;
            double to = 0;
            if (Objentrada.dia == "lunes")
            {
                if (Objentrada.edad < 22)
                {
                    des = 20;
                }
            }
            else if (Objentrada.dia == "martes")
            {
                if (Objentrada.edad >= 22 && Objentrada.edad <=35)
                {
                    des = 30;
                }
            }
            else if (Objentrada.dia == "miercoles")
            {
                if (Objentrada.edad >= 60)
                {
                    des = 40;
                }
            }
            else if (Objentrada.dia == "jueves")
            {
                des = 20;
            }
            else
            {

            }
            Objentrada.desc = des;
            to = Objentrada.precio - ((Objentrada.precio*des)/100);

            Objentrada.total = to;

            return View("CalcularEntrada" , Objentrada);
        }
    }
}