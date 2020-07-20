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
        // GET: Empleado
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
        [HttpGet]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Empleado", new { id = empleado.Id });
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
    }
}