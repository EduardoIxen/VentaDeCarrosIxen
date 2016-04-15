using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VentaDeCarrosIxen.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["idUsuario"]!= null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","Cuenta");
            }
        }
    }
}