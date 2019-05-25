using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ArticulosController : Controller
    {
        // GET: Articulos
        public ActionResult Index(MantenimientoArticulo mantenimientoArticulo)
        {
            return View(mantenimientoArticulo.RecuperarTodos());
        }

        // GET: Articulos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Articulos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Articulos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
            
             //   string aux = values;
                // TODO: Add insert logic here
                MantenimientoArticulo ma = new MantenimientoArticulo();
                Articulo art = new Articulo
                {
                    Codigo = int.Parse(collection["codigo"]),
                    Descripcion = collection["descripcion"],
                    Precio = float.Parse(collection["precio"])
                };

                ma.Alta(art);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult TercerNivel()
        {
            return View();
        }

        // GET: Articulos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Articulos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Articulos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Articulos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
