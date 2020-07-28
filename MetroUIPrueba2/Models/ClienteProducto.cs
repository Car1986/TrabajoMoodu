using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class ClienteProducto
    {
        public int Id { get; set; }
        public int NumOrden { get; set; }
        public int Subtotal { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }

        public virtual Pago Pago { get; set; }
    }
}