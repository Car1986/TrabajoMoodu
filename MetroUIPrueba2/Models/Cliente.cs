using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Cliente
    {
        public int Id { get; set; }        
        [Required]
        [StringLength(35, MinimumLength = 3)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(35, MinimumLength = 3)]
        public string Apellidos { get; set; }
        [Required]        
        public string Correo { get; set; }
        [Required]       
        public int Telefono { get; set; }
        [Required]       
        public string Rut { get; set; }

        public virtual ICollection<ClienteProducto> ClienteProductos { get; set; }

        //puesto alreves de lo que dice la logica con el cliente usuario       

        [Key]
        [ForeignKey("Usuario")]
        public int? UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}