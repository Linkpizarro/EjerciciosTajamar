using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientePracticaMonedas.Models
{
    public class Cliente
    {
        public int Cliente_Id { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public DateTime Fecha_Nacimiento{get;set;}
        public String UserName { get; set; }
        public String Password { get; set; }

    }
}
