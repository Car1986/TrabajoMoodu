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
        [StringLength(100,MinimumLength = 3, ErrorMessage = "La descripción debe de tener un minimo de 3 y máximo de 100 caracteres" )]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 1, ErrorMessage ="La unidad de medidad deberá estar abreviada de un minimo 1 caracter y un máximo de 6")]
        public string Umedida { get; set; }
    }
}