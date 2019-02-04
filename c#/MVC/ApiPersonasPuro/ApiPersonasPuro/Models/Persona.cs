using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPersonasPuro.Models
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public String Nombre { get; set; }
        public String Email { get; set; }
        public int Edad { get; set; }
    }
}