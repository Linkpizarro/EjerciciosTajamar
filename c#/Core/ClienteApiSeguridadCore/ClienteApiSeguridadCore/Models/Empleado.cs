using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApiSeguridadCore.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        public String Surname { get; set; }

        public String Ofice { get; set; }

        public int Dir { get; set; }

        public int Salary { get; set; }
    }
}
