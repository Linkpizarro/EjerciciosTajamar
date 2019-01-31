using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Videoclub.Models
{
    [Table("Peliculas")]
    public class Pelicula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IdPelicula")]
        public int Id { get; set; }
        [Column("IdGenero")]
        public int IdGenero { get; set; }
        [Column("Titulo")]
        public String Titulo { get; set; }
        [Column("Argumento")]
        public String Argumento { get; set; }
        [Column("Actores")]
        public String Actores { get; set; }
        [Column("Precio")]
        public int Precio { get; set; }
        [Column("Foto")]
        public String Cartel { get; set; }
    }
}