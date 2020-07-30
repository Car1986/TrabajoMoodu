using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int Num_orden { get; set; }
        public int Total { get; set; }
        public DateTime Fecha { get; set; }
        //[Key]
        //[Required]
        //public virtual ClienteProducto ClienteProducto { get; set; }
        //[ForeignKey("MedioPago")]
        public int MedioPagoId { get; set; }
        public MedioPago MedioPago { get; set; }
    }
}