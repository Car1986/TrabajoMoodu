
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Razon { get; set; }
        public string Rut { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string Comuna { get; set; }
    }
}