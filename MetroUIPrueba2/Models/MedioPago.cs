using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MetroUIPrueba2.Models
{
    public class MedioPago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string EntidadComercial { get; set; }
        public virtual Pago Pago { get; set; }

    }
}