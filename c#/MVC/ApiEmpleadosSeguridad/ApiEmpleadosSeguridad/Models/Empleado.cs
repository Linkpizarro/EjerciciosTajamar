using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiEmpleadosSeguridad.Models
{
    [Table("EMP")]
    public class Empleado
    {
        [Key]
        [Column("EMP_NO")]
        public int Id { get; set; }

        [Column("APELLIDO")]
        public String Surname { get; set; }

        [Column("OFICIO")]
        public String Ofice { get; set; }

        [Column("DIR")]
        public int Dir { get; set; }

        [Column("SALARIO")]
        public int Salary { get; set; }
    }
}