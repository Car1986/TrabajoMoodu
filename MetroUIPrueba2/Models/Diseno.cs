using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Diseno
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public int UsuarioId { get; set; }
        public int UsuarioInternoId { get; set; }
    }
}