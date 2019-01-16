using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InyeccionEntity.Models
{
    [Table("HOSPITAL")]
    public class Hospital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("HOSPITAL_COD")]
        public int Id{ get; set; }
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("DIRECCION")]
        public String Direccion { get; set; }
        [Column("TELEFONO")]
        public String Telefono { get; set; }
        [Column("NUM_CAMA")]
        public int Camas { get; set; }


    }
}