using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Orden
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int? PagoId { get; set; }
        public virtual ICollection<OrdenDetalle> OrdenDetalle { get; set; }

    }
}