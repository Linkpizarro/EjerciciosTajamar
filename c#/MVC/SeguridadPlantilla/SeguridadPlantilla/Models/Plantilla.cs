using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguridadPlantilla.Models
{
    [Table("PLANTILLA")]
    public class Plantilla
    {
        [Key]
        [Column("EMPLEADO_NO")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Número de Empleado")]
        public int Emp_no { get; set; }
        [Column("APELLIDO")]
        [Display(Name = "Apellido")]
        public String Apellido { get; set; }
        [Column("FUNCION")]
        [Display(Name = "Función")]
        public String Funcion { get; set; }
        [Column("SALARIO")]
        [Display(Name = "Salario")]
        public int Salario { get; set; }
    }
}