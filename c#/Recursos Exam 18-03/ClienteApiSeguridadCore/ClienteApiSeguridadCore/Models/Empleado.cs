﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApiSeguridadCore.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public String Apellido { get; set; }
        public String Oficio { get; set; }
        public int Director { get; set; }
        public int Salario { get; set; }
    }
}
