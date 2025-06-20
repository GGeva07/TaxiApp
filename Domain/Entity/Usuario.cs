using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Usuario
    {
        public int Id { get; set; }
        public string IdDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public ICollection<Viaje> Viajes { get; set; }
        public ICollection<GrupoUsuario> Grupos { get; set; }
    }
}
