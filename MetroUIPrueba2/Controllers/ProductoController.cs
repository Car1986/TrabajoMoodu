using Antlr.Runtime.Misc;
using MetroUIPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Controllers
{
    public class ProductoController : Controller
    {
    
    

        public ActionResult Index()
        {
        
            return View();
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
         
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(Producto producto)
        {
            if (ModelState.IsValid)
            { 
                //codigo para guardar en BD
                return RedirectToAction("Index", "Producto");
            }
            else
            {
                return View();
            }
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