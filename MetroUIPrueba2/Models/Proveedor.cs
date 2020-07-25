
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required]
        public string Razon { get; set; }
        [Required]
        [StringLength(12, MinimumLength =11)]
        public string Rut { get; set; }
        [Required]
        [StringLength(50, MinimumLength =5)]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Contacto { get; set; }
        [Required]
        public string Comuna { get; set; }
        public virtual ICollection<CompraInsumo> CompraInsumo { get; set; }
    }
}