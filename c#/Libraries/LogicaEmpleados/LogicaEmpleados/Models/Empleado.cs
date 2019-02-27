using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaEmpleados.Models
{
    [DataContract]
    [Table("EMP")]
    public class Empleado
    {
        [Key]
        [Column("EMP_NO")]
        [DataMember]
        public int IdEmpleado { get; set; }
        [Column("APELLIDO")]
        [DataMember]
        public String Apellido { get; set; }
        [Column("OFICIO")]
        [DataMember]
        public String Oficio { get; set; }
        [Column("SALARIO")]
        [DataMember]
        public int Salario { get; set; }
       

    }
}
