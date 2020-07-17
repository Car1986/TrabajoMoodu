using MetroUIPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Controllers
{
    public class UserController : Controller
    {
        private List<Cliente> GetClientes()
        {
            Usuario Carl_1 = new Usuario() { Id = 1, NombreUsuario = "Carl_1" };
            Usuario Juancho = new Usuario() { Id = 2, NombreUsuario = "Juancho" };
            Usuario RORRO = new Usuario() { Id = 3, NombreUsuario = "RORRO" };

            Cliente carlos = new Cliente()
            {
                Id = 1,
                Nombres = "Carlos Andrés",
                Apellidos = "Marchant Sánchez",
                Correo = "carlos@dsa.cl",
                Telefono = 12343435,
                Rut = "12443432-2",
                Usuario = Carl_1
            };
            Cliente juan = new Cliente()
            {
                Id = 2,
                Nombres = "Juan Gustavo",
                Apellidos = "Leiva León",
                Correo = "Juan@dsa.cl",
                Telefono = 11626756,
                Rut = "11626756-2",
                Usuario = Juancho
            };
            Cliente rodrigo = new Cliente()
            {
                Id = 1,
                Nombres = "Rodrigo Esteban",
                Apellidos = "Urrutia Vazquéz",
                Correo = "Rodrigo@dsa.cl",
                Telefono = 16745999,
                Rut = "16745999-3",
                Usuario = RORRO
            };

            List<Cliente> lista = new List<Cliente>();
            lista.Add(carlos);
            lista.Add(juan);
            lista.Add(rodrigo);

            return lista;
        }

        private List<Usuario> GetUsuarios()
        {
            Usuario Carl_1 = new Usuario() { Id = 1, NombreUsuario = "Carl_1" };
            Usuario Juancho = new Usuario() { Id = 2, NombreUsuario = "Juancho" };
            Usuario RORRO = new Usuario() { Id = 3, NombreUsuario = "RORRO" };

            List<Usuario> lista = new List<Usuario>();
            lista.Add(Carl_1);
            lista.Add(Juancho);
            lista.Add(RORRO);
            return lista;
        }

        // GET: User
        public ActionResult Index()
        {
            List<Cliente> misClientes = GetClientes();
            return View(misClientes);
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            ViewBag.usuarios = GetUsuarios();
            Cliente cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Nuevo(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View(cliente);
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult RecoverPassword()
        {
            return View();
        }

    }
}