using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NuGetNorthwindApiDPC
{
    public class DatosNorthwind
    {
        public ListaProductos GetProductos()
        {
            WebClient cliente = new WebClient();
            cliente.Headers["content-type"] = "application/json";
            String url = "https://services.odata.org/V4/Northwind/Northwind.svc/Products";
            String contenido = cliente.DownloadString(url);
            ListaProductos productos = JsonConvert.DeserializeObject<ListaProductos>(contenido);
            return productos;
        }
    }
}
