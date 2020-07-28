using System;
using System.Collections.Generic;
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
        public int ClienteProductoId { get; set; }
        public ClienteProducto ClienteProducto { get; set; }
        public int MedioPagoId { get; set; }
        public MedioPago MedioPago { get; set; }
    }
}