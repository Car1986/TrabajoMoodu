using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class CompraInsumo
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public double Valor { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
        public int InsumoId { get; set; }
        public virtual Insumo Insumo { get; set; }
        public int ProveedorId { get; set; }
        public virtual Proveedor Proveedor{ get; set; }
    }
}