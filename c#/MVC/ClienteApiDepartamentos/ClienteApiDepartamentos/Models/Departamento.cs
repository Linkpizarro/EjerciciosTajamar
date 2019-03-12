using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteApiDepartamentos.Models
{
    public class Departamento
    {
        [JsonProperty("Numero")]
        public int Numero { get; set; }
        [JsonProperty("Nombre")]
        public String Nombre { get; set; }
        [JsonProperty("Localidad")]
        public String Localidad { get; set; }
    }
}
