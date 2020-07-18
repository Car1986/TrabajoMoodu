using MetroUIPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Controllers
{
    public class ProveedorController : Controller
    {
     
        // GET: Proveedor
        [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
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
    }
}