using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEmpleadosCore.Models
{
    [Table("EMP")]
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("EMP_NO")]
        public int IdEmpleado { get; set; }
        [Column("APELLIDO")]
        public String Apellido { get; set; }
        [Column("OFICIO")]
        public String Oficio { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
        [Column("DEPT_NO")]
        public int DeptNo { get; set; }

    }
}
