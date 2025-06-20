using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Viaje
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Desde { get; set; }
        public string Hasta { get; set; }
        public int Calificacion { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public Taxi Taxi { get; set; }
        public ICollection<DetalleViaje> Detalles { get; set; }
    }
}
