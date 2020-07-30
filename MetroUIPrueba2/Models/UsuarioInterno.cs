using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class UsuarioInterno
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Proveedor> Proveedores { get; set; }
        public virtual ICollection<Insumo> Insumos { get; set; }
    }
}