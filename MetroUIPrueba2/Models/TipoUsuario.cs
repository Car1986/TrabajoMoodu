using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class TipoUsuario
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } 
        public virtual Usuario Usuario { get; set; }
    }
}