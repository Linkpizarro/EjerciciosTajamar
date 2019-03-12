using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiDepartamentos.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("DEPT_NO")]
        public int Numero { get; set; }
        [Column("DNOMBRE")]
        public String Nombre { get; set; }
        [Column("LOC")]
        public String Localidad { get; set; }
    }
}