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
        private List<Proveedor> GetProveedor()
        {
            Proveedor pv1 = new Proveedor()
            {
                Id = 1,
                Razon = "Provedor1",
                Rut = "65.897.564-k",
                Direccion = "Colo-Colo # 1256",
                Telefono = "+56 9 67543421",
                Email = "pv1@gmail.com",
                Contacto = "Juan Valdebenito Segura",
                 Comuna = "Concepción",
            };
            Proveedor pv2 = new Proveedor()
            {
                Id = 1,
                Razon = "Provedor2",
                Rut = "85.897.564-k",
                Direccion = "Anibal Pinto # 1256",
                Telefono = "+56 9 86548920",
                Email = "pv2@gmail.com",
                Contacto = "Guido Medina Cartes",
                Comuna = "Concepción",
            };
            List<Proveedor> list = new List<Proveedor>();
            list.Add(pv1);
            list.Add(pv2);
            return list;
        }
        // GET: Proveedor
        [HttpGet]
        public ActionResult Index()
        {
            List<Proveedor> misProveedores = GetProveedor();
            return View(misProveedores);
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