using MetroUIPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Areas.Produccion.Controllers
{
    public class RecursoController : Controller
    {
        MooduContext _db = new MooduContext();
        // GET: Insumo
        [HttpGet]
        public ActionResult Index()
        {
            List<Recurso> recursos = _db.Recurso.ToList();
            return View(recursos);
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
                return RedirectToAction("Index", "Recurso");
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
        [HttpPost]
        public ActionResult Edit(int id, Recurso recurso)
        {
            Recurso r = _db.Recurso.Find(id);
            if (r == null)
            {
                return new HttpNotFoundResult();
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Recurso", new { id = id });
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
