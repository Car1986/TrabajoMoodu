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
        
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
        // al reves de lo que dicen la logica
        //public virtual ICollection<Cliente> Cliente { get; set; }
        //public virtual ICollection<Producto> Producto { get; set; }
    }
}