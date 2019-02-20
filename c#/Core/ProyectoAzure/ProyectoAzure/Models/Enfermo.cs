using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAzure.Models
{
    [Table("ENFERMO")]
    public class Enfermo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("INSCRIPCION")]
        public int Inscripcion { get; set; }

        [Column("APELLIDO")]
        public String Apellido { get; set; }
        [Column("DIRECCION")]
        public String Direccion { get; set; }

        [Column("S")]
        public String Sexo { get; set; }
    }
}
