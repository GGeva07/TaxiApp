using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    [Table("usuario")]
    public class usuario
    {
        [Key]
        public int id { get; set; }

        [Column("idDocumento")]
        public int idDocumento { get; set; }

        [Column("nombre")]
        public string nombre { get; set; }

        [Column("apellido")]
        public string apellido { get; set; }

        public ICollection<viaje> viajes { get; set; }
        public ICollection<grupoUsuario> grupos { get; set; }
    }
}
