using MetroUIPrueba2.Models;
using MetroUIPrueba2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroUIPrueba2.Controllers
{
    public class HomeController : Controller
    {
        private MooduContext _db = new MooduContext();
        [HttpGet]
        public ActionResult Index()
        {
            List<Producto> productos = _db.Producto.ToList();
            return View(productos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PayDocumentUser()
        {      
            return View();
        }

        public ActionResult PayDocumentClient()
        {
            return View();
        }
        public ActionResult user_client_choose()
        {
            return View();
        }

        public ActionResult product_selected(int id, Producto producto)
        {
            Producto p = _db.Producto.Find(id);
            if (p == null)
            {
                return new HttpNotFoundResult();
            }
            return View(p);
        }
        public ActionResult Mesas()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Intranet()
        {
            return View();
        }
        public ActionResult Disenno()
        {
            return View();
        }

        public ActionResult Vision()
        {
            return View();
        }

        public ActionResult Mission()
        {
            return View();
        }

        public ActionResult Prueba()
        {
            return View();
        }




    //    public ActionResult InsumoEmpleado()
    //    {
    //        List<Empleado> empleados = _db.Empleado
    //                                        .Where(e => e.Areas.Descripcion == "Insumo")
    //                                        .Select(e => e)
    //                                        .ToList();
    //        return View(empleados);
    //    }

    //    public ActionResult GerenciaEmpleado()
    //    {
    //        List<Empleado> empleados = _db.Empleado
    //                                        .Where(e => e.Areas.Descripcion == "Gerencia")
    //                                        .Select(e => e)
    //                                        .ToList();
    //        return View(empleados);
    //    }

    //    public ActionResult Ranking()
    //    {
    //        List<RankingArea> ranking = _db.Areas
    //                                      .Select(r => new RankingArea
    //                                      {
    //                                          Area = r,
    //                                          Cantidad = r.Empleado.Count()
    //                                      })
    //                                      .ToList();
    //        return View(ranking);
    //    }

    //    public ActionResult ProduccionEmpleado()
    //    {
    //        List<Empleado> empleados = _db.Empleado
    //                                        .Where(e => e.Areas.Descripcion == "Produccion")
    //                                        .Select(e => e)
    //                                        .ToList();
    //        return View(empleados);
    //    }
    }
}