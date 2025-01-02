using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEfective.Modelos
{
    [Table("ESTADO_CIVIL", Schema = "dbo")]
    public class EstadoCivil
    {
        [Key]
        public int ID_ESTADO_CIVIL { get; set; }
        public string? DESCRIPCION { get; set; }
        public DateTime? FECHA_CREACION { get; set; }
        public DateTime? FECHA_MODIFICACION { get; set; }
        public bool ESTADO { get; set; }
    }
}
