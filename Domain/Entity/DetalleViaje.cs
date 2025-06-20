using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    [Table("detalleViaje")]
    public class detalleViaje
    {
        [Key]
        public int id { get; set; }

        [Column("longitude")]
        public string longitude { get; set; }

        [Column("latitud")]
        public string latitud { get; set; }

        [Column("fecha")]
        public DateTime fecha { get; set; }

        [Column("idViaje")]
        public int idViaje { get; set; }

        [ForeignKey("idViaje")]
        public viaje viaje { get; set; }
    }
}
