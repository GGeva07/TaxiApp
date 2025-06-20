using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    [Table("GrupoUsuarioDetalle")]
    public class grupoUsuarioDetalle
    {
        [Key]
        public int id { get; set; }

        [Column("idGrupoUsuario")]
        public int idGrupoUsuario { get; set; }

        [ForeignKey("idGrupoUsuario")]
        public grupoUsuario grupoUsuario { get; set; }
    }
}
