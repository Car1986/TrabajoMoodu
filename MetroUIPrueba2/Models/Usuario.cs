using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
       
        // al reves de lo que dicen la logica
        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}