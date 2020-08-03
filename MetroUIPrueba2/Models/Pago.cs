using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Design;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Pago
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int MedioPagoId { get; set; }
        public virtual Orden Orden { get; set; }
    }
}