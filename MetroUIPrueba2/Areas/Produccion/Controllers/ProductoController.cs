using MetroUIPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Areas.Produccion.Controllers
{
    public class ProductoController : Controller
    {
        MooduContext _db = new MooduContext();
        // GET: Insumo
        [HttpGet]
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
                //acá codigo para guardar
                return RedirectToAction("Index","Producto");
            }
            return View(producto);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Producto producto = _db.Producto.Find(id);
            if (producto == null)
            {
                return new HttpNotFoundResult();
            }
            return View(producto);
        }
        [HttpPost]
        public ActionResult Edit(int id, Producto producto)
        {
            Producto p = _db.Producto.Find(id);
            if(p == null)
            {
                return new HttpNotFoundResult();
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Producto", new { id = id });
            }
            return View(producto);
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            Producto producto = _db.Producto.Find(id);
            if (producto == null)
            {
                return new HttpNotFoundResult();
            }
            return View(producto);
        }

        [HttpPost]
        public ActionResult Actualizar()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Inventario()
        {
            return View();
        }
    }
}