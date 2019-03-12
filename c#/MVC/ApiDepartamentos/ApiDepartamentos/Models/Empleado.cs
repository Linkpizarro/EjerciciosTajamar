using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiDepartamentos.Models
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

        [Column("DEPT_NO")]
        public int Dept { get; set; }
    }
}