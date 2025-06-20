using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    [Table("grupoUsuario")]
    public class grupoUsuario
    {
        [Key]
        public int id { get; set; }

        [Column("idUsuario")]
        public int idUsuario { get; set; }

        [ForeignKey("idUsuario")]
        public usuario usuario { get; set; }

        public ICollection<grupoUsuarioDetalle> detalles { get; set; }
    }
}
