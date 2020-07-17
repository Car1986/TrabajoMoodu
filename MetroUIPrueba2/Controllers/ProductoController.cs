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
      
        private List<Producto> GetProductos()
        {
            Producto pd1 = new Producto()
            {
                Id = 1,
                Codigo = "PD-01",
                Fecha = "01-01-2019",
                Precio = 650000,
                Imagen="la ruta",
                Descripcion= "bla bla",
                Estado ="Diseño"

            };
            Producto pd2 = new Producto()
            {
                Id = 2,
                Codigo = "PD-02",
                Fecha = "01-01-2019",
                Precio = 750000,
                Imagen = "la ruta",
                Descripcion = "bla bla",
                Estado = "Diseño"

            };
            List<Producto> list = new List<Producto>();
            list.Add(pd1);
            list.Add(pd2);
            return list;
        }

        public ActionResult Index()
        {
            List<Producto> misProductos = GetProductos();
            return View(misProductos);
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