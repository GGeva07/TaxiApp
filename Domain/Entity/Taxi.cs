using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Taxi
    {
        public int Id { get; set; }
        public string Placa { get; set; }

        public int IdViaje { get; set; }
        public Viaje Viaje { get; set; }
    }
}
