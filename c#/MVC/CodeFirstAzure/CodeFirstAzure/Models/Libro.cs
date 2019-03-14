using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace CodeFirstAzure.Models
{
    
    [TableName("Libros")]
    public class Libro
    {
        [Key]
        public int IdLibro { get; set; }
        public String Nombre { get; set; }
        public String Autor { get; set; }
        public String Sinopsis { get; set; }
        public int IdGenero { get; set; }
        public virtual Genero Genero { get; set; }
    }
    
}