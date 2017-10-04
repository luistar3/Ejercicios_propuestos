using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios_propuestos.Models;
using System.Collections;
using Ejercicios_propuestos.Models;

namespace Ejercicios_propuestos.Controllers
{
    public class Ejer1Controller : Controller
    {
        // GET: Ejer1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ejer1add()
        {


            if (Session["edad"] == null)

            {
                ArrayList edades = new ArrayList();

                Session["edad"] = edades;
                
            }
            else
            {
                Ejer1 objedad = new Ejer1();
                ArrayList edades = (ArrayList)Session["edad"];
               // objedad.edad = Convert.ToDouble(Request.Form["edad"]);

                int e = Convert.ToInt32(Request.Form["edad"]);
                if (e == 0)
                {

                }
                else
                {
                    edades.Add(e);

                    Session["edad"] = edades;
                }

               

            }

            return View();
        }
        public ActionResult Ejer1calcular()
        {

            Ejer1 objmujer = new Ejer1();

            if (Session["edad"] == null)
                {
                Response.Redirect(Url.Action("Ejer1add", "Ejer1"));
            }
            else
            {
                

                double dinero = 0;
                string tipo = Request.Form["viuda"];
                if (tipo == "viuda")
                {
                    dinero += 20;
                }
                ArrayList edades = (ArrayList)Session["edad"];
                int canthijos = edades.Count;

                if (canthijos <= 2)
                {
                    dinero += 70;
                }
                else if (canthijos >= 3 && canthijos <= 5)
                {
                    dinero += 90;
                }
                else
                {
                    dinero += 120;
                }

                int escolar = 0;

                for (int i = 0; i < edades.Count; i++)
                {



                    if (Convert.ToInt32(edades[i]) >= 6 && Convert.ToInt32(edades[i]) <= 18)
                    {
                        escolar++;
                    }
                }

                objmujer.total = dinero + (escolar * 10);
                
            }




            return View("Ejer1calcular", objmujer);


        }
    }
}