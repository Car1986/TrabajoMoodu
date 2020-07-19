using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required]
        public string Rut  { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Cargo { get; set; }
    }
}