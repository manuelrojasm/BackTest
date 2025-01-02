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

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string? NOMBRE { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido no puede exceder los 100 caracteres.")]
        public string? APELLIDO { get; set; }

        [Required(ErrorMessage = "El tipo de documento es obligatorio.")]
        public int ID_TIPO_DOCUMENTO { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "La fecha de nacimiento debe ser una fecha válida.")]
        public DateTime? FECHA_NACIMIENTO { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El valor debe ser un número positivo.")]
        public int? VALOR { get; set; }

        [Required(ErrorMessage = "El estado civil es obligatorio.")]
        public int ID_ESTADO_CIVIL { get; set; }

        [Required(ErrorMessage = "La fecha de creación es obligatoria.")]
        public DateTime? FECHA_CREACION { get; set; }

        public DateTime? FECHA_MODIFICACION { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio.")]
        public bool ESTADO { get; set; }

    }
}
