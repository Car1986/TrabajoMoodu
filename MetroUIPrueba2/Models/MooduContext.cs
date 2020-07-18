using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class MooduContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Producto> Productos { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Insumo> Insumo { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
    }
}