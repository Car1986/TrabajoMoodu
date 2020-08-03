﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class CategoriaInsumo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<CompraInsumo> CompraInsumo { get; set; }

    }
}