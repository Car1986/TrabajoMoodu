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
        Usuario user1 = new Usuario() { Id = 1, NombreUsuario = "Manuel Neuer", Password = "123" };
        Usuario user2 = new Usuario() { Id = 2, NombreUsuario = "Phillipe Lamp", Password = "456" };
        private List<Producto> GetProductos()
        {
            Producto pd1 = new Producto()
            {
                Id = 1,
                Codigo = "PD-01",
                Fecha = "01-01-2019",
                Precio = 650000,
                Imagen = "la ruta",
                Descripcion = "bla bla",
                Estado = "Diseño",
                Usuario = user1

            };
            Producto pd2 = new Producto()
            {
                Id = 2,
                Codigo = "PD-02",
                Fecha = "01-01-2019",
                Precio = 750000,
                Imagen = "la ruta",
                Descripcion = "bla bla",
                Estado = "Diseño",
                Usuario = user2

            };
            List<Producto> list = new List<Producto>();
            list.Add(pd1);
            list.Add(pd2);
            return list;
        }
        private List<Usuario> GetUsuarios()
        {
            Usuario user1 = new Usuario() { Id = 1, NombreUsuario = "Manuel Neuer", Password = "123" };
            Usuario user2 = new Usuario() { Id = 2, NombreUsuario = "Phillipe Lamp", Password = "456" };
            List<Usuario> lista = new List<Usuario>();
            lista.Add(user1);
            lista.Add(user2);
            return lista;
        }

            

        public ActionResult Index()
        {
            List<Producto> misProductos = GetProductos();
            return View(misProductos);
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            ViewBag.Usuario = GetUsuarios();
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