using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    [Table("viaje")]
    public class viaje
    {
        [Key]
        public int id { get; set; }

        [Column("fechaInicio")]
        public DateTime fechaInicio { get; set; }

        [Column("fechaFin")]
        public DateTime fechaFin { get; set; }

        [Column("desde")]
        public string desde { get; set; }

        [Column("hasta")]
        public string hasta { get; set; }

        [Column("calificacion")]
        public int calificacion { get; set; }

        [Column("idUsuario")]
        public int idUsuario { get; set; }

        [ForeignKey("idUsuario")]
        public usuario usuario { get; set; }

        public taxi taxi { get; set; }

        public ICollection<detalleViaje> detalles { get; set; }
    }
}
