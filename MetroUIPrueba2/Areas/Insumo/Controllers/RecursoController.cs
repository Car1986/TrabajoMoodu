using MetroUIPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Areas.Insumo.Controllers
{
    public class RecursoController : Controller
    {
        // GET: Insumo/Recurso
        MooduContext _db = new MooduContext();
        // GET: Insumo
        [HttpGet]
        public ActionResult Index()
        {
            List<Recurso> recurso = _db.Recurso.ToList();
            return View(recurso);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Recurso recurso = new Recurso();
            return View(recurso);
        }
        [HttpPost]
        public ActionResult Create(Recurso recurso)
        {
            if (ModelState.IsValid)
            {
                //acá codigo para guardar
                return RedirectToAction("View", "Empleado", new { id = recurso.Id });
            }
            return View(recurso);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Recurso recurso = _db.Recurso.Find(id);
            if (recurso == null)
            {
                return new HttpNotFoundResult();
            }
            return View(recurso);
        }
        [HttpGet]
        public ActionResult View(int id)
        {
            Recurso recurso = _db.Recurso.Find(id);
            if (recurso == null)
            {
                return new HttpNotFoundResult();
            }
            return View(recurso);
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
