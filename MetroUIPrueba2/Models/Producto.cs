using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Producto
    {
        public  int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =1)]
        public string Codigo { get; set; }
        [Required]
        public string Fecha { get; set; }
        [Required]
        [Range(0,100000000)]
        public double Precio { get; set; }
        [Required]
        public string Imagen { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Descripcion { get; set; }
        [Required]      
        public string Estado { get; set; }
        //[Required]
        //public int id { get; set; }
        //public Usuario Usuario { get; set; }
       
    }
}