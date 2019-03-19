using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientePracticaMonedas.Models
{
    public class Moneda
    {
        public int Id { get; set; }
        public String Pais { get; set; }
        public int Anyo { get; set; }
        public String Descripcion { get; set; }
        public int Precio { get; set; }
        public String Foto { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
    }
}
