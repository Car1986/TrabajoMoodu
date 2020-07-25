using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class InventarioProducto
    {
        public int Id { get; set; }
        [Required]
        public string Producto { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }
        [Required]
        [Range(0, 50)]
        public int Cantidad { get; set; }
        [Required]
        [Range(3,10)]
        public int Critico { get; set; }
       [StringLength(100,MinimumLength =5)]
        public string Observacion {get;set;}
        [Required]
        public int Almacen { get; set; }
        

    }
}