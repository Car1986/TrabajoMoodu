using Antlr.Runtime.Misc;
using MetroUIPrueba2.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Controllers
{
    public class ProductoController : Controller
    {
        MooduContext _db = new MooduContext();
    

        public ActionResult Index()
        {
            List<Producto> producto = _db.Producto.ToList();
            return View(producto);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Producto producto = new Producto();
         
            return View(producto);
        }


        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            { 
                //codigo para guardar en BD
                return RedirectToAction("View", "Producto", new {id=producto.Id });
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public ActionResult View(int id)
        {
            Producto producto = _db.Producto.Find(id);
            if (producto==null)
            {
                return new HttpNotFoundResult();
            }
            return View(producto);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Producto producto = _db.Producto.Find(id);
            if (producto==null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        [HttpPost]
        public ActionResult Inventario()
        {
            return View();
        }
        public ActionResult Closets()
        {
            return View();
        }
        public ActionResult ClosetsCR()
        {
            return View();
        }
        public ActionResult Comedores()
        {
            return View();
        }
        public ActionResult Comodas()
        {
            return View();
        }
        public ActionResult ComodasCR()
        {
            return View();
        }
        public ActionResult Camas()
        {
            return View();
        }
        public ActionResult Disenno()
        {
            return View();
        }
        public ActionResult Mesas()
        {
            return View();
        }
    }
}