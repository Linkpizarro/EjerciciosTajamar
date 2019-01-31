using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Videoclub.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IdCliente")]
        public int Id { get; set; }
        [Column("Nombre")]
        public String Nombre { get; set; }
        [Column("Email")]
        public String Email { get; set; }
        [Column("Imagen_Cliente")]
        public String Imagen { get; set; }
    }
}