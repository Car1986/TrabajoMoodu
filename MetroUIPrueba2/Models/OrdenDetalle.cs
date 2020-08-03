using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class OrdenDetalle
    {
        public int Id { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public double Precio { get; set; }
        public int ProductoId { get; set; }
        public int OrdenId { get; set; }

    }
}