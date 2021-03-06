﻿using MetroUIPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Areas.Gerencia.Controllers
{
    public class ProveedorController : Controller
    {
        MooduContext _db = new MooduContext();
        // GET: Insumo
        [HttpGet]
        public ActionResult Index()
        {
            List<Proveedor> proveedores = _db.Proveedor.ToList();
            return View(proveedores);
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
                return RedirectToAction("Index", "Proveedor");
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
        [HttpPost]
        public ActionResult Edit(int id, Proveedor proveedor)
        {
            Proveedor p = _db.Proveedor.Find(id);
            if (p == null)
            {
                return new HttpNotFoundResult();
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("View", "Proveedor", new { id = id });
            }
            return View(proveedor);
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            Proveedor proveedor = _db.Proveedor.Find(id);
            if (proveedor == null)
            {
                return new HttpNotFoundResult();
            }
            return View(proveedor);
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