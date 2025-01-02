using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestEfective.Modelos
{
    [Table("EMPLEADO", Schema = "dbo")]
    public class Empleado
    {
        [Key]
        public int ID_EMPLEADO { get; set; }
        public string? NOMBRE { get; set; }
        public string? APELLIDO { get; set; }
        public int ID_TIPO_DOCUMENTO { get; set; }
        public DateTime? FECHA_NACIMIENTO { get; set; }
        public int? VALOR { get; set; }
        public int ID_ESTADO_CIVIL { get; set; }
        public DateTime? FECHA_CREACION { get; set; }
        public DateTime? FECHA_MODIFICACION { get; set; }
        public bool ESTADO { get; set; }

    }
}
