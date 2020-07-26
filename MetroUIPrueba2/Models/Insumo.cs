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
            public virtual CatergoriaInsumo CategoriaInsumo { get; set; }

       


    }
}