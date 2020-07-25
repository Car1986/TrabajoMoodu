namespace MetroUIPrueba2.Migrations
{
    using MetroUIPrueba2.Models;
    using Microsoft.SqlServer.Server;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MetroUIPrueba2.Models.MooduContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MetroUIPrueba2.Models.MooduContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
           

           

            // para que reconozca las fechas se debe meter dia mes an
            Producto p1 = new Producto()
            {
                Codigo = "pd-01",
                Fecha = "2020-02-15",
                Precio = 650000,
                Imagen = "La ruta1",
                Descripcion = "La descripcion",
                Estado = "Produccion"
            };
            Producto p2 = new Producto()
            {
                Codigo = "pd-02",
                Fecha = "2020-02-15",
                Precio = 450000,
                Imagen = "La ruta2",
                Descripcion = "La descripcion2",
                Estado = "Produccion"
            };
            Producto p3 = new Producto()
            {
                Codigo = "pd-03",
                Fecha = "2020-02-15",
                Precio = 350000,
                Imagen = "La ruta3",
                Descripcion = "La descripcion3",
                Estado = "Produccion"
            };
            Producto p4 = new Producto()
            {
                Codigo = "pd-04",
                Fecha = "2020-02-15",
                Precio = 250000,
                Imagen = "La ruta4",
                Descripcion = "La descripcion4",
                Estado = "Produccion"
            };
            context.Producto.Add(p1);
            context.Producto.Add(p2);
            context.Producto.Add(p3);
            context.Producto.Add(p4);
            context.SaveChanges();

            Almacen a1 = new Almacen()
            {
                Id=1,
                Descripcion="Almacen Produccion",
                Ubicacion="Sector G, Bodega Principal",
                Observacion="Sin Observacion"
            };
            Almacen a2 = new Almacen()
            { 
                Id=2,
                Descripcion = "Almacen Diseño",
                Ubicacion = "Sector H, Bodega Principal",
                Observacion = "Sin Observacion"
            };
            context.Almacenes.Add(a1);
            context.Almacenes.Add(a2);
            context.SaveChanges();

            InventarioProducto ip1 = new InventarioProducto()
            {
                Id = 1,
                Fecha = "10/02/2020",
                Cantidad = 32,
                Critico = 10,
                Observacion = "fdfkjsdfkf",
                AlmacenId=a1.Id,
                ProductoId=p1.Id
                };

            InventarioProducto ip2 = new InventarioProducto()
            {
                Id = 1,
                Fecha = "13/03/2020",
                Cantidad = 45,
                Critico = 10,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a1.Id,
                ProductoId = p1.Id
            };
            InventarioProducto ip3 = new InventarioProducto()
            {
                Id = 1,
                Fecha = "14/04/2020",
                Cantidad = 15,
                Critico = 5,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a1.Id,
                ProductoId = p1.Id
            };
            InventarioProducto ip4 = new InventarioProducto()
            {
                Id = 1,
                Fecha = "13/05/2020",
                Cantidad = 13,
                Critico = 5,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a2.Id,
                ProductoId = p3.Id
            };
            InventarioProducto ip5 = new InventarioProducto()
            {
                Id = 1,
                Fecha = "13/06/2020",
                Cantidad = 8,
                Critico = 5,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a2.Id,
                ProductoId = p3.Id
            };
            InventarioProducto ip6 = new InventarioProducto()
            {
                Id = 1,
                Fecha = "13/06/2020",
                Cantidad = 23,
                Critico = 10,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a1.Id,
                ProductoId = p4.Id
            };
            context.InventarioProductos.Add(ip1);
            context.InventarioProductos.Add(ip2);
            context.InventarioProductos.Add(ip3);
            context.InventarioProductos.Add(ip4);
            context.InventarioProductos.Add(ip5);
            context.InventarioProductos.Add(ip6);
            context.SaveChanges();

            Proveedor pr1 = new Proveedor()
            {

                Razon = "Empresas de Insumos S.A",
                Rut = "65.452.123-k",
                Direccion = "Los avedules # 456",
                Telefono = "+56 9 86425787",
                Email = "ei@email.com",
                Contacto = "Juan Medina Garces",
                Comuna = "Concepcion"
            };
            Proveedor pr2 = new Proveedor()
            {
                Razon = "Empresas de Insumos1 S.A",
                Rut = "70.444.666-k",
                Direccion = "Anibal Pinto # 456",
                Telefono = "+56 9 55555555",
                Email = "ei1@email.com",
                Contacto = "Bernardo Silva Medina",
                Comuna = "Santiago"
            };
            context.Proveedor.Add(pr1);
            context.Proveedor.Add(pr2);
            context.SaveChanges();

            Insumo i1 = new Insumo()
            {
                Id = 1,
                Descripcion = "Manillas de Comodas",
                Umedida = "C/U",
                Categoria = "Accesorio"
            };
            Insumo i2 = new Insumo()
            {
                Id = 2,
                Descripcion = "Manillas de Roperos",
                Umedida = "C/U",
                Categoria = "Accesorio"
            };
            context.Insumo.Add(i1);
            context.Insumo.Add(i2);
            context.SaveChanges();

            CompraInsumo ci1 = new CompraInsumo()
            {
                Id=1,
                Fecha="25-02-2020",
                Valor=3000,
                Cantidad=100,
                Observacion="fsfdsdsf",
                InsumoId=i1.Id,
                ProveedorId=pr1.Id
            };
            CompraInsumo ci2 = new CompraInsumo()
            {
                Id = 1,
                Fecha = "25-02-2020",
                Valor = 2500,
                Cantidad = 150,
                Observacion = "fsfdsdsf",
                InsumoId = i2.Id,
                ProveedorId = pr1.Id
            };
            context.CompraInsumo.Add(ci1);
            context.CompraInsumo.Add(ci2);
            context.SaveChanges();

            Recurso re1 = new Recurso()
            {
                Descripcion = "Madera de Pino",
                Umedida = "m"
            };
            Recurso re2 = new Recurso()
            {
                Descripcion = "Tela Sintetica",
                Umedida = "m"
            };
            Recurso re3 = new Recurso()
            {
                Descripcion = "Relleno de lana",
                Umedida = "m*3"
            };
            context.Recurso.Add(re1);
            context.Recurso.Add(re2);
            context.Recurso.Add(re3);
            context.SaveChanges();

             Empleado em1 = new Empleado()
             {
                 Rut = "10897213-1",
                 Nombres = "Juan Alberto",
                 Apellidos = "Camaño Perez",
                 Direccion = "Arturo Prat # 2285",
                 Telefono = "9-98765342",
                 Correo = "jac@email.com",
                 Cargo = "Control Produccion"
             };
        Empleado em2 = new Empleado()
        {
            Rut = "10358692-1",
            Nombres = "Manuel Bernardo",
            Apellidos = "Pellegrini Cortez",
            Direccion = "Arturo Prat # 2315",
            Telefono = "9-65832142",
            Correo = "mbpc@email.com",
            Cargo = "Supervisor"
        };

        Empleado em3 = new Empleado()
        {
            Rut = "19999000-2",
            Nombres = "Arturo Ignacio",
            Apellidos = "Vidal Benitez",
            Direccion = "Manuel Bulnes # 555",
            Telefono = "9-1111111",
            Correo = "aivb@email.com",
            Cargo = "Gerente"
        };

        Empleado em4 = new Empleado()
        {
            Rut = "14071986-k",
            Nombres = "Marcelo Andres",
            Apellidos = "Placencia Velasquez",
            Direccion = "Igancio Serrano # 1500",
            Telefono = "9-4444231",
            Correo = "mapv@email.com",
            Cargo = "Ensamblador"
        };
        context.Empleado.Add(em1);
            context.Empleado.Add(em2);
            context.Empleado.Add(em3);
            context.Empleado.Add(em4);
            context.SaveChanges();
        }
    }
}
