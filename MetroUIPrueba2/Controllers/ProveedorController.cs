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
    public class ProveedorController : Controller
    {
        MooduContext _db = new MooduContext();

        // GET: Proveedor
        [HttpGet]
        public ActionResult Index()
        {
            List<Proveedor> proveedor = _db.Proveedor.ToList();

            return View(proveedor);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Proveedor proveedor = new Proveedor();
            return View(proveedor);
        }

        [HttpPost]
        public ActionResult Create(Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                //acá codigo para guardar
                return RedirectToAction("View","Proveedor", new { id=proveedor.Id });
            }
            return View(proveedor);
        }


        [HttpGet]
        public ActionResult View(int id)
        {
            Proveedor proveedor = _db.Proveedor.Find(id);
            if (proveedor==null)
            {
                return new HttpNotFoundResult();
            }
            return View(proveedor);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Proveedor proveedor = _db.Proveedor.Find(id);
            if (proveedor == null)
            {
                return new HttpNotFoundResult();
            }
            return View(proveedor);
        }
       
     
    }
}