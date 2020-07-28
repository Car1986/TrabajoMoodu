using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class AsignaRoles
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public virtual Empleado Empleado { get; set; }
        public int RolId { get; set; }
        public virtual Roles Roles { get; set; }
    }
}