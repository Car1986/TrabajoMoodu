using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Insumo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Umedida { get; set; }
        public double Precio { get; set; }
        public string Observacion { get; set; }

        public virtual ICollection<InventarioInsumo> InventarioInsumo { get; set; }
        public virtual ICollection<ProveeInsumo> ProveeInsumo { get; set; }

    }
}