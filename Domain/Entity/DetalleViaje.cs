using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class DetalleViaje
    {
        public int Id { get; set; }
        public double Longitud { get; set; }
        public double Latitud { get; set; }
        public DateTime Fecha { get; set; }

        public int IdViaje { get; set; }
        public Viaje Viaje { get; set; }
    }
}
