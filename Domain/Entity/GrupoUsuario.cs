using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class GrupoUsuario
    {
        public int Id { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<GrupoUsuarioDetalle> Detalles { get; set; }
    }
}
