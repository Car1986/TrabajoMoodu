using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MetroUIPrueba2.Models
{
    public class MooduContext: DbContext
    {
        public DbSet<Producto> Productos { get; set; }
    }
}