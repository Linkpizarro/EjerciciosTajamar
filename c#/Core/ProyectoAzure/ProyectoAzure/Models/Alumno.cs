using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAzure.Models
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Nota { get; set; }
    }
}
