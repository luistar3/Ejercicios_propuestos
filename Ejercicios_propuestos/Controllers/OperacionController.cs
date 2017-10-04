using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios_propuestos.Models;

namespace Ejercicios_propuestos.Controllers
{
    public class OperacionController : Controller
    {
        // GET: Operacion
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OperacionIndex()
        {
            return View();
        }
        public ActionResult OperacionCalcular(ClsOperacion ope)
        {
            if (ope.tipo == "r1")
            {
                ope.ope = " A + B + C+ D ";
                ope.resultado = ope.a + ope.b + ope.c + ope.d;
            }
            else if (ope.tipo == "r2")
            {
                ope.ope = " (A + B + C+ D)/4  ";
                ope.resultado = (ope.a + ope.b + ope.c + ope.d)/4;
            }
            else if (ope.tipo == "r3")
            {
                if (ope.c + ope.d == 0)
                {
                    ope.ope = "No se peude dividir entre 0";
                    ope.resultado = 0;
                }
                else
                {
                    ope.ope = " (A + B)/(C + D) ";
                    ope.resultado = (ope.a + ope.b) / (ope.c + ope.d);
                }
                
            }
            else if (ope.tipo == "r4")
            {
                if (ope.b == 0 || ope.d == 0) 
                {
                    ope.ope = "No se peude dividir entre 0";
                    ope.resultado = 0;
                }
                else
                {
                    ope.ope = " (A / B)+(C / D) ";
                    ope.resultado = (ope.a / ope.b) + (ope.c / ope.d);
                }
               
            }
            else
            {
                ope.ope = " A / (B-C*D) ";
                ope.resultado = ope.a /( ope.b - ope.c * ope.d);
            }
            return View(ope);
        }
    }
}