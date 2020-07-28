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
        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual ICollection<Proveedor> Proveedor { get; set; }
        public virtual ICollection<Insumo> Insumo { get; set; }

        //public int ClienteId { get; set; }
        //public Cliente Cliente { get; set; }

        // al reves de lo que dicen la logica
        //public virtual ICollection<Cliente> Cliente { get; set; }
        //public virtual ICollection<Producto> Producto { get; set; }
    }
}