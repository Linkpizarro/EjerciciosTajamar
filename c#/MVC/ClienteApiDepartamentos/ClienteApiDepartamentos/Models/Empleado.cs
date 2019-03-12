using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApiDepartamentos.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        public String Surname { get; set; }

        public String Ofice { get; set; }

        public int Dept { get; set; }
    }
}