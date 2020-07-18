namespace MetroUIPrueba2.Migrations
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
                Cargo = "Gerente" 
        };
            Empleado em2 = new Empleado()
            {
                Rut = "129726261",
                Nombres = "Manuel Bernardo",
                Apellidos = "Pellegrini Cortez",
                Direccion = "Arturo Prat # 2315",
                Telefono = "9-65832142",
                Correo = "mbpc@email.com",
                Cargo = "Gerente"
            };


        }
    }
}
