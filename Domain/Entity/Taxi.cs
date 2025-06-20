using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    [Table("taxi")]
    public class taxi
    {
        [Key]
        public int id { get; set; }

        [Column("placa")]
        public string placa { get; set; }

        [Column("idViaje")]
        public int idViaje { get; set; }

        [ForeignKey("idViaje")]
        public viaje viaje { get; set; }
    }
}
