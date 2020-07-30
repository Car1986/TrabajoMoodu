using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }

        
        public virtual ICollection<Producto> Productos { get; set; }

        public virtual Cliente Cliente { get; set; }

        // al reves de lo que dicen la logica
        //public virtual ICollection<Cliente> Cliente { get; set; }
        //public virtual ICollection<Producto> Producto { get; set; }
    }
}