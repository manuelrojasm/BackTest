using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEfective.Modelos
{
    [Table("TIPO_DOCUMENTO", Schema = "dbo")]
    public class TipoDocumento
    {
        [Key]
        public int ID_TIPO_DOCUMENTO { get; set; }
        public string CODIGO { get; set; }
        public string? DESCRIPCION { get; set; }
        public DateTime? FECHA_CREACION { get; set; }
        public DateTime? FECHA_MODIFICACION { get; set; }
        public bool ESTADO { get; set; }
    }
}
