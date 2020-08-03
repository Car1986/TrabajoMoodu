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
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "Debe de seleccionar una fecha válida")]
        public DateTime Fecha { get; set; }
        [Required]
        [Range(1, 99999999, ErrorMessage = "El valor por producto debe de ser minimo de 1 y máximo de 99999999")]
        public double Precio { get; set; }
        [Required]
        public string Imagen { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "La descripción debe de tener un minimo de 3 y máximo de 100 caracteres")]
        public string Descripcion { get; set; }
        [Required]
        public string Estado { get; set; }
        //[Required]
        public virtual ICollection<OrdenDetalle> OrdenDetalle { get; set; }
        public virtual ICollection<InventarioProducto> InventarioProductos { get; set; }
    }
}