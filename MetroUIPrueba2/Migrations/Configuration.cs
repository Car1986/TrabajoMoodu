﻿namespace MetroUIPrueba2.Migrations
{
    using MetroUIPrueba2.Models;
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
            Producto p1 = new Producto()
            {
                Codigo = "pd-01",
                Fecha = "15-02-2020",
                Precio = 650000,
                Imagen = "La ruta1",
                Descripcion = "La descripcion",
                Estado = "Produccion"
            };
            Producto p2 = new Producto()
            {
                Codigo = "pd-02",
                Fecha = "15-02-2020",
                Precio = 450000,
                Imagen = "La ruta2",
                Descripcion = "La descripcion2",
                Estado = "Produccion"
            };
            Producto p3 = new Producto()
            {
                Codigo = "pd-03",
                Fecha = "15-02-2020",
                Precio = 350000,
                Imagen = "La ruta3",
                Descripcion = "La descripcion3",
                Estado = "Produccion"
            };
            Producto p4 = new Producto()
            {
                Codigo = "pd-04",
                Fecha = "15-02-2020",
                Precio = 250000,
                Imagen = "La ruta4",
                Descripcion = "La descripcion4",
                Estado = "Produccion"
            };
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

            context.Producto.Add(p1);
            context.Producto.Add(p2);
            context.Producto.Add(p3);
            context.Producto.Add(p4);
            context.Empleado.Add(em1);
            context.Empleado.Add(em2);
            context.Empleado.Add(em3);
            context.Empleado.Add(em4);
            context.Proveedor.Add(pr1);
            context.Proveedor.Add(pr2);
            context.SaveChanges();

        }
    }
}