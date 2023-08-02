using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanico.Models
{
    class EstadoModel
    {
        public int ID { get; set; }
        public bool EntregarVehiculo { get; set; }
        public bool PrepararCoche { get; set; }
        public bool DarMantenimiento { get; set; }
        public bool Finalizar { get; set; }
        public bool RecogerVehiculo { get; set; }
    }
}
