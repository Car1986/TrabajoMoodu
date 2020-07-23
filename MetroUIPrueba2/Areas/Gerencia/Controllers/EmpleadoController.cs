using MetroUIPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Areas.Gerencia.Controllers
{
    
    public class EmpleadoController : Controller
    {
        MooduContext _db = new MooduContext();
        // GET: Insumo
        [HttpGet]
        public ActionResult Index()
        {
            List<Empleado> empleado = _db.Empleado.ToList();
            return View(empleado);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View(empleado);
        }
        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                //acá codigo para guardar
                return RedirectToAction("Index", "Empleado");
            }
            return View(empleado);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Empleado empleado = _db.Empleado.Find(id);
            if (empleado == null)
            {
                return new HttpNotFoundResult();
            }
            return View(empleado);
        }
        [HttpPost]
        public ActionResult Edit(int id, Empleado empleado)
        {
            Empleado e = _db.Empleado.Find(id);
            if (e == null)
            {
                return new HttpNotFoundResult();
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Empleado", new { id = id });
            }
            return View(empleado);
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            Empleado empleado = _db.Empleado.Find(id);
            if (empleado == null)
            {
                return new HttpNotFoundResult();
            }
            return View(empleado);
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