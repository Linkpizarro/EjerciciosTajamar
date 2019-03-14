using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace CodeFirstAzure.Models
{
    [TableName("Generos")]
    public class Genero
    {
        [Key]
        public int IdGenero { get; set; }
        public String Nombre { get; set; }

        public virtual List<Libro> Libros { get; set; }
    }
}