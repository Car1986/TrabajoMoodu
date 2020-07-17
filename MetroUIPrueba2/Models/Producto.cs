using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Producto
    {
        public  int Id { get; set; }
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public double Precio { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }


    }
}