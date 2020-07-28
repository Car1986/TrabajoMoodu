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
        [StringLength(11, MinimumLength = 10)]
        public string Rut  { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage =" El o los nombres deben de tener un mínimo de 1 y máximo 50 caracteres")]
        public string Nombres { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 1, ErrorMessage = " El o los nombres deben de tener un mínimo de 1 y máximo 80 caracteres")]
        public string Apellidos { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = " El o los nombres deben de tener un mínimo de 1 y máximo 100 caracteres")]
        public string Direccion { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 9, ErrorMessage = " El telefono debe de tener un maximo de 16 números y un minimo de 9")]
        public string Telefono { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Cargo { get; set; }

        public virtual Usuario Usuario { get; set; }
        public int AreaId { get; set; }
        public virtual Areas Areas { get; set; }
        public virtual ICollection<AsignaRoles> AsignaRoles { get; set; }
    }
}