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
            public int CategoriaId { get; set; }
            public int? UsuarioInternoId { get; set; }
            public virtual UsuarioInterno UsuarioInterno { get; set; }
            public virtual CatergoriaInsumo CategoriaInsumo { get; set; }
            public virtual ICollection<CompraInsumo> CompraInsumo { get; set; }
            public virtual ICollection<ProveeInsumo> ProveeInsumo { get; set; }
    }
}