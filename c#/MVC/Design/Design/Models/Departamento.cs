using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design.Models
{
    public class Departamento
    {
        String _Numero;
        String _Nombre;
        String _Localidad;

        public string Numero { get => _Numero; set => _Numero = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Localidad { get => _Localidad; set => _Localidad = value; }
    }
}