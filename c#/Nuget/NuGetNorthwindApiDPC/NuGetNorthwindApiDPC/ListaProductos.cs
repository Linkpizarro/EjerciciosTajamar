using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetNorthwindApiDPC
{
   public class ListaProductos
    {
        [JsonProperty("value")]
        public List<Producto> Productos { get; set; }
    }
}
