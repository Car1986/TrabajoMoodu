namespace MetroUIPrueba2.Migrations
{
    using MetroUIPrueba2.Models;
    using Microsoft.SqlServer.Server;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography;

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


            //TABLAS SIN FOREIGN KEY
            Areas ar1 = new Areas()
            {
                Descripcion = "Gerencia"
            };
            Areas ar2 = new Areas()
            {
                Descripcion = "Insumo"
            };
            Areas ar3 = new Areas()
            {
                Descripcion = "Produccion"
            };
            context.Areas.Add(ar1);
            context.Areas.Add(ar2);
            context.Areas.Add(ar3);
            context.SaveChanges();

            Roles rol1 = new Roles()
            {
                Descripcion = "Administrador"
            };
            Roles rol2 = new Roles()
            {
                Descripcion = "Supervisor"
            };
            Roles rol3 = new Roles()
            {
                Descripcion = "Trabajador"
            };
            context.Roles.Add(rol1);
            context.Roles.Add(rol2);
            context.Roles.Add(rol3);
            context.SaveChanges();

            Usuario us1 = new Usuario()
            {
                NombreUsuario = "Roberto123",
                Password = "1234"
            };
            Usuario us2 = new Usuario()
            {
                NombreUsuario = "Batman1234",
                Password = "1234"
            };
            Usuario us3 = new Usuario()
            {
                NombreUsuario = "roro",
                Password = "1234"
            };
            context.Usuarios.Add(us1);
            context.Usuarios.Add(us2);
            context.Usuarios.Add(us3);
            context.SaveChanges();

            UsuarioInterno usi1 = new UsuarioInterno()
            {
                NombreUsuario = "nfncv",
                Password = "1234"
            };
            UsuarioInterno usi2 = new UsuarioInterno()
            {
                NombreUsuario = "yrttr",
                Password = "1234"
            };
            UsuarioInterno usi3 = new UsuarioInterno()
            {
                NombreUsuario = "hgfhg",
                Password = "1234"
            };
            UsuarioInterno usi4 = new UsuarioInterno()
            {
                NombreUsuario = "dster",
                Password = "1234"
            };
            context.UsuarioInterno.Add(usi1);
            context.UsuarioInterno.Add(usi2);
            context.UsuarioInterno.Add(usi3);
            context.UsuarioInterno.Add(usi4);
            context.SaveChanges();

            Almacen a1 = new Almacen()
            {

                Descripcion = "Almacen Muebles de Produccion",
                Ubicacion = "Sector G, Bodega Principal",
                Observacion = "Sin Observacion"
            };
            Almacen a2 = new Almacen()
            {

                Descripcion = "Almacen Muebles Diseño",
                Ubicacion = "Sector H, Bodega Principal",
                Observacion = "Sin Observacion"
            };
            Almacen a3 = new Almacen()
            {

                Descripcion = "Almacen de Insumos",
                Ubicacion = "Sector A, Interior Fabrica",
                Observacion = "Sin Observacion"
            };
            context.Almacenes.Add(a1);
            context.Almacenes.Add(a2);
            context.Almacenes.Add(a3);
            context.SaveChanges();

            CatergoriaInsumo cti1 = new CatergoriaInsumo()
            {
                Descripcion = "Materia Prima"
            };
            CatergoriaInsumo cti2 = new CatergoriaInsumo()
            {
                Descripcion = "Pinturas"
            };
            CatergoriaInsumo cti3 = new CatergoriaInsumo()
            {
                Descripcion = "Accesorios"
            };
            context.CategoriaInsumo.Add(cti1);
            context.CategoriaInsumo.Add(cti2);
            context.CategoriaInsumo.Add(cti3);
            context.SaveChanges();

            MedioPago mp1 = new MedioPago()
            {
                Descripcion = "tarjeta credito",
                EntidadComercial = "Banco Estado"

            };
            MedioPago mp2 = new MedioPago()
            {
                Descripcion = "tarjeta debito",
                EntidadComercial = "Banco Estado"
            };
            context.MedioPago.Add(mp1);
            context.MedioPago.Add(mp2); ;
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

            // TABLAS CON FOREIGN KEY

            Empleado em1 = new Empleado()
            {
                Rut = "10897213-1",
                Nombres = "Juan Alberto",
                Apellidos = "Camaño Perez",
                Direccion = "Arturo Prat # 2285",
                Telefono = "9-98765342",
                Correo = "jac@email.com",
                Cargo = "Control Produccion",
                AreaId = ar3.Id,
                UsuarioInternoId = usi1.Id
            };
            Empleado em2 = new Empleado()
            {
                Rut = "10358692-1",
                Nombres = "Manuel Bernardo",
                Apellidos = "Pellegrini Cortez",
                Direccion = "Arturo Prat # 2315",
                Telefono = "9-65832142",
                Correo = "mbpc@email.com",
                Cargo = "Supervisor",
                AreaId = ar2.Id,
                UsuarioInternoId = usi2.Id
            };
            Empleado em3 = new Empleado()
            {
                Rut = "19999000-2",
                Nombres = "Arturo Ignacio",
                Apellidos = "Vidal Benitez",
                Direccion = "Manuel Bulnes # 555",
                Telefono = "9-1111111",
                Correo = "aivb@email.com",
                Cargo = "Gerente",
                AreaId = ar1.Id,
                UsuarioInternoId = usi3.Id
            };
            Empleado em4 = new Empleado()
            {
                Rut = "14071986-k",
                Nombres = "Marcelo Andres",
                Apellidos = "Placencia Velasquez",
                Direccion = "Igancio Serrano # 1500",
                Telefono = "9-4444231",
                Correo = "mapv@email.com",
                Cargo = "Ensamblador",
                AreaId = ar3.Id,
                UsuarioInternoId = usi4.Id
            };
            context.Empleado.Add(em1);
            context.Empleado.Add(em2);
            context.Empleado.Add(em3);
            context.Empleado.Add(em4);
            context.SaveChanges();

            Cliente cl1 = new Cliente()
            {
                Nombres = "Roberto Carlos",
                Apellidos = "Rojas Ascencio",
                Correo = "ewqewq@das.cl",
                Telefono = 94444231,
                Rut = "14074567-k",
                UsuarioId = us1.Id

            };
            Cliente cl2 = new Cliente()
            {
                Nombres = "Juan Pedro",
                Apellidos = "Perez Merea",
                Correo = "gfdgdf@das.cl",
                Telefono = 94444231,
                Rut = "12074437-k",
                UsuarioId = us2.Id
            };
            Cliente cl3 = new Cliente()
            {
                Nombres = "Sebastian Rodolfo",
                Apellidos = "Mella Prieto",
                Correo = "tttt@das.cl",
                Telefono = 94444231,
                Rut = "14567543-1",
                UsuarioId = us3.Id
            };
            context.Clientes.Add(cl1);
            context.Clientes.Add(cl2);
            context.Clientes.Add(cl3);
            context.SaveChanges();

            AsignaRoles asig1 = new AsignaRoles()
            {
                EmpleadoId = em1.Id,
                RolId = rol1.Id
            };
            AsignaRoles asig2 = new AsignaRoles()
            {
                EmpleadoId = em2.Id,
                RolId = rol2.Id
            };
            context.AsignaRoles.Add(asig1);
            context.AsignaRoles.Add(asig2);
            context.SaveChanges();

            Producto p1 = new Producto()
            {
                Codigo = "pd-01",
                Fecha = new DateTime(2020, 6, 10),
                Precio = 650000,
                Imagen = "La ruta1",
                Descripcion = "La descripcion",
                Estado = "Produccion"
            };
            Producto p2 = new Producto()
            {
                Codigo = "pd-02",
                Fecha = new DateTime(2020, 6, 10),
                Precio = 450000,
                Imagen = "La ruta2",
                Descripcion = "La descripcion2",
                Estado = "Produccion"
            };
            Producto p3 = new Producto()
            {
                Codigo = "pd-03",
                Fecha = new DateTime(2020, 6, 10),
                Precio = 350000,
                Imagen = "La ruta3",
                Descripcion = "La descripcion3",
                Estado = "Produccion"
            };
            Producto p4 = new Producto()
            {

                Codigo = "pd-04",
                Fecha = new DateTime(2020, 6, 10),
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

            InventarioProducto ip1 = new InventarioProducto()
            {

                Fecha = new DateTime(2020, 2, 10),
                Cantidad = 32,
                Critico = 10,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a1.Id,
                ProductoId = p1.Id
            };
            InventarioProducto ip2 = new InventarioProducto()
            {

                Fecha = new DateTime(2020, 2, 10),
                Cantidad = 45,
                Critico = 10,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a1.Id,
                ProductoId = p1.Id
            };
            InventarioProducto ip3 = new InventarioProducto()
            {

                Fecha = new DateTime(2020, 2, 10),
                Cantidad = 15,
                Critico = 5,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a1.Id,
                ProductoId = p1.Id
            };
            InventarioProducto ip4 = new InventarioProducto()
            {

                Fecha = new DateTime(2020, 2, 10),
                Cantidad = 13,
                Critico = 5,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a2.Id,
                ProductoId = p3.Id
            };
            InventarioProducto ip5 = new InventarioProducto()
            {

                Fecha = new DateTime(2020, 6, 12),
                Cantidad = 8,
                Critico = 5,
                Observacion = "fdfkjsdfkf",
                AlmacenId = a2.Id,
                ProductoId = p3.Id
            };
            InventarioProducto ip6 = new InventarioProducto()
            {

                Fecha = new DateTime(2020, 6, 12),
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
                Comuna = "Concepcion",
                UsuarioInternoId = usi1.Id
            };
            Proveedor pr2 = new Proveedor()
            {

                Razon = "Empresas de Insumos1 S.A",
                Rut = "70.444.666-k",
                Direccion = "Anibal Pinto # 456",
                Telefono = "+56 9 55555555",
                Email = "ei1@email.com",
                Contacto = "Bernardo Silva Medina",
                Comuna = "Santiago",
                UsuarioInternoId = usi2.Id
            };
            context.Proveedor.Add(pr1);
            context.Proveedor.Add(pr2);
            context.SaveChanges();



            Insumo i1 = new Insumo()
            {

                Descripcion = "Manillas de Comodas",
                Umedida = "C/U",
                CategoriaId = cti3.Id,
                UsuarioInternoId = usi1.Id
            };
            Insumo i2 = new Insumo()
            {

                Descripcion = "Manillas de Roperos",
                Umedida = "C/U",
                CategoriaId = cti3.Id,
                UsuarioInternoId = usi2.Id
            };
            Insumo i3 = new Insumo()
            {

                Descripcion = "Barniz Cafe Cipres",
                Umedida = "Galon",
                CategoriaId = cti2.Id,
                UsuarioInternoId = usi3.Id
            };
            context.Insumo.Add(i1);
            context.Insumo.Add(i2);
            context.Insumo.Add(i3);
            context.SaveChanges();

            Pago pa1 = new Pago()
            {
                Num_orden = 12,
                Total = 120000,
                Fecha = new DateTime(2020, 2, 25),
                MedioPagoId = mp1.Id
            };

            Pago pa2 = new Pago()
            {
                Num_orden = 132,
                Total = 1200000,
                Fecha = new DateTime(2020, 2, 25),
                MedioPagoId = mp1.Id
            };

            Pago pa3 = new Pago()
            {
                Num_orden = 11,
                Total = 100000,
                Fecha = new DateTime(2020, 2, 25),
                MedioPagoId = mp2.Id
            };
            context.Pago.Add(pa1);
            context.Pago.Add(pa2);
            context.Pago.Add(pa3);
            context.SaveChanges();

            ClienteProducto cp1 = new ClienteProducto()
            {
                NumOrden = 145,
                Subtotal = 120000,
                Fecha = new DateTime(2020, 6, 10),
                ProductoId = p1.Id,
                ClienteId = cl1.Id
                //PagoId = pa1.Id
            };

            ClienteProducto cp2 = new ClienteProducto()
            {
                NumOrden = 122,
                Subtotal = 203000,
                Fecha = new DateTime(2020, 6, 10),
                ProductoId = p2.Id,
                ClienteId = cl2.Id
                //PagoId = pa2.Id
            };

            ClienteProducto cp3 = new ClienteProducto()
            {
                NumOrden = 111,
                Subtotal = 320000,
                Fecha = new DateTime(2020, 6, 10),
                ProductoId = p3.Id,
                ClienteId = cl3.Id
                //PagoId = pa3.Id
            };
            context.ClienteProducto.Add(cp1);
            context.ClienteProducto.Add(cp2);
            context.ClienteProducto.Add(cp3);
            context.SaveChanges();

            InventarioInsumo ii1 = new InventarioInsumo()
            {

                Fecha = new DateTime(2020, 1, 21),
                Cantidad = 50,
                Critico = 50,
                Observacion = "no hay",
                AlmacenId = a3.Id,
                InsumoId = i2.Id

            };
            InventarioInsumo ii2 = new InventarioInsumo()
            {

                Fecha = new DateTime(2020, 1, 21),
                Cantidad = 150,
                Critico = 50,
                Observacion = "no hay",
                AlmacenId = a3.Id,
                InsumoId = i1.Id
            };

            context.InventarioInsumo.Add(ii1);
            context.InventarioInsumo.Add(ii2);
            context.SaveChanges();

            CompraInsumo ci1 = new CompraInsumo()
            {

                Fecha = new DateTime(2020, 2, 25),
                Valor = 3000,
                Cantidad = 100,
                Observacion = "fsfdsdsf",
                InsumoId = i1.Id,
                ProveedorId = pr1.Id
            };
            CompraInsumo ci2 = new CompraInsumo()
            {
                Fecha = new DateTime(2020, 2, 25),
                Valor = 2500,
                Cantidad = 150,
                Observacion = "fsfdsdsf",
                InsumoId = i2.Id,
                ProveedorId = pr1.Id
            };
            context.CompraInsumo.Add(ci1);
            context.CompraInsumo.Add(ci2);
            context.SaveChanges();

            ProveeInsumo pri1 = new ProveeInsumo()
            {
                InsumoId = i2.Id,
                ProveedorId = pr1.Id
            };
            ProveeInsumo pri2 = new ProveeInsumo()
            {
                InsumoId = i2.Id,
                ProveedorId = pr1.Id
            };
            context.ProveeInsumo.Add(pri1);
            context.ProveeInsumo.Add(pri2);
            context.SaveChanges();

        }


    }
}
