using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicas.Models
{
    public class TablaMultiplicar
    {
        String _operacion;
        int? _resultado;

        public string Operacion { get => _operacion; set => _operacion = value; }
        public int? Resultado { get => _resultado; set => _resultado = value; }
    }
}