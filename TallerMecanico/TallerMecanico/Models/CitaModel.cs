﻿using System;
using System.Collections.Generic;
using System.Text;
using TallerMecanico.views.Login;

namespace TallerMecanico.Models
{
    class CitaModel
    {
        public int ID { get; set; }
        public string Vehiculo { get; set; }
        public string Servicio { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estatus { get; set; }
        public int RegistroID { get; set; }
        public virtual RegistroModel Registro { get; set; }
        public int EstadosID { get; set; }
        public virtual EstadoModel Estados { get; set; }
    }
}
