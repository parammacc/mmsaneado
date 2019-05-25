using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //    return View();
            //   MantenimientoArticulo ma = new MantenimientoArticulo();
            //    return RedirectToAction("Index","Articulos", ma.RecuperarTodos());
            //    return RedirectToAction("Index", "Articulos", new {ma = new MantenimientoArticulo() });   //ha funcionado
            return RedirectToAction("Index", "Articulos", new MantenimientoArticulo());     //http://localhost:50789/Articulos
        }

        public ActionResult About()
        {
            //    ViewBag.Message = "Your application description page.";
            ViewBag.Message = "<script>alert('hola mundo')<script>";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}