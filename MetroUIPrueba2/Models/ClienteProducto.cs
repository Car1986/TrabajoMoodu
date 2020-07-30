using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class ClienteProducto
    {
        //[Key]
        //[Column(Order = 1)]
        public int Id { get; set; }
        public int NumOrden { get; set; }
        public int Subtotal { get; set; }
        public DateTime Fecha { get; set; }
        //[Key]
        //[Column(Order = 2)]
        public int ClienteId { get; set; }       
        public virtual Cliente Cliente { get; set; }
        //[Key]
        //[Column(Order = 3)]
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
        //[Key]
        //[Column(Order = 4)]
        //public int? PagoId { get; set; }
        //public Pago Pago { get; set; }
    }
}