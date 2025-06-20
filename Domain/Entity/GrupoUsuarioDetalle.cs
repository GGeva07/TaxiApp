using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class GrupoUsuarioDetalle
    {
        public int Id { get; set; }

        public int IdGrupoUsuario { get; set; }
        public GrupoUsuario GrupoUsuario { get; set; }
    }
}
