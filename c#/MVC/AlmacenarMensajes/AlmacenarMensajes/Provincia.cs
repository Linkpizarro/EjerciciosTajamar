using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenarMensajes
{
   public class Provincia
    {
        public String IdProvincia { get; set; }
        public String Nombre { get; set; }
        public List<String> Localidades { get; set; }

    }
}
