using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Recurso
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 3)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(5, MinimumLength = 1)]
        public string Umedida { get; set; }
    }
}