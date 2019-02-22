using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetNorthwindApiDPC
{
    public class Producto
    {
        [JsonProperty("ProductId")]
        public int IdProducto{get;set;}
        [JsonProperty("ProductName")]
        public String Nombre { get; set; }
        [JsonProperty("QuantityPerUnit")]
        public String Cantidad { get; set; }
        [JsonProperty("UnitsInStock")]
        public int Stock { get; set; }
    }
}
