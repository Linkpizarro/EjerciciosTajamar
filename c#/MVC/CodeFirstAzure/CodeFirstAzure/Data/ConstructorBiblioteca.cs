using CodeFirstAzure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstAzure.Models
{
    public class ConstructorBiblioteca : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);
            List<Genero> generos = new List<Genero>()
            {
                new Genero{ IdGenero = 1 , Nombre = "Aventura"},
                new Genero{ IdGenero = 2 , Nombre = "Terror"}
            };
            List<Libro> libros = new List<Libro>()
            {
                new Libro{ IdLibro=1,IdGenero=1,Nombre="Harry Potter",Autor="J.K. Rowling",Sinopsis="Harry potter es bien."},
                  new Libro{ IdLibro=1,IdGenero=1,Nombre="Harry Potter 2",Autor="J.K. Rowling",Sinopsis="Harry potter es bien x2."},
                    new Libro{ IdLibro=1,IdGenero=1,Nombre="Harry Potter 3",Autor="J.K. Rowling",Sinopsis="Harry potter es bien x3."},
                      new Libro{ IdLibro=1,IdGenero=1,Nombre="Harry Potter 4",Autor="J.K. Rowling",Sinopsis="Harry potter es bien x4."},
            };
        }
    }
}