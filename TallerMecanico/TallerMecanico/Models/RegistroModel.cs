using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanico.Models
{
    class RegistroModel
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public bool Permiso { get; set; }
    }
}
