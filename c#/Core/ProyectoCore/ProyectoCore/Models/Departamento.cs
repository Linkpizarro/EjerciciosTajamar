using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCore.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("DEPT_NO")]
        [Display(Name ="Número")]
        public int Dept_no { get; set; }
        [Column("DNOMBRE")]
        [Display(Name = "Nombre")]
        public String Dnombre { get; set; }
        [Column("LOC")]
        [Display(Name = "Localidad")]
        public String Loc { get; set; }
    }
}
