using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class ProveeInsumo
    {
        public int Id { get; set; }
        public int InsumoId { get; set; }
        public virtual Insumo Insumo { get; set; }
        public int ProveedorId { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}