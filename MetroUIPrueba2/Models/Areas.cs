using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Areas
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection <Empleado> Empleado { get; set; }
    }
}