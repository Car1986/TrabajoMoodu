using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Almacen
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Ubicacion { get; set; }
        public string Observacion { get; set; }
    }
}