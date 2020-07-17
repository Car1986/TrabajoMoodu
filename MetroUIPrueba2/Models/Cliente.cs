using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroUIPrueba2.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Rut { get; set; }
        //puesto alreves de lo que dice la logica con el cliente usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}