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
    public class InsumoController : Controller
    {
        MooduContext _db = new MooduContext();

        // GET: Insumo
        [HttpGet]
        public ActionResult Index()
        {
            List<Insumo> insumos = _db.Insumo.ToList();
            return View(insumos);
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            Insumo insumo = new Insumo();
            return View(insumo);
        }
        [HttpGet]
        public ActionResult Ver(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear()
        {
            return View();
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