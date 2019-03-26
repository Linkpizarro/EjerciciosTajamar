using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using AlmacenarMensajes;
using Microsoft.ServiceBus.Messaging;

namespace AlmacenarMensajes
{
    class Program
    {
        public static List<Provincia> GetProvincias()
        {

                String recursoXml = "AlmacenarMensajes.provincias.xml";

                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(recursoXml);

                XDocument docXml = XDocument.Load(stream);

                var linq = from d in docXml.Descendants("provincia")

                           select new Provincia

                           {

                               IdProvincia = d.Attribute("id").Value,

                               Nombre = d.Element("nombre").Value,

                               Localidades = new List<String>(

                               from loc in d.Descendants("localidad")

                               select loc.Value)

                           };

                return linq.ToList();

            }





            public static String GenerarMensaje(List<Provincia> provincias)
            {
                Random random = new Random();
                int idUser = random.Next(1, 300);
                int idProvincia = random.Next(0, provincias.Count);
                Provincia provincia = provincias[idProvincia];  
                int idLoc = random.Next(0, provincia.Localidades.Count);
                String loc = provincia.Localidades[idUser];
                return $"El usuario {idUser} se ha conectado desde {provincia.Nombre} en {loc}";
            }

            static void Main(string[] args)

            {

                List<Provincia> provincias = GetProvincias();

            String hubCenter = "centroeventos";

            String cnneventhub = ConfigurationManager.AppSettings["eventhub"];

            EventHubClient client = EventHubClient.CreateFromConnectionString(cnneventhub, hubCenter);

            while (true)

                {
                    String mensaje = GenerarMensaje(provincias);
                    Console.WriteLine(mensaje);
                byte[] Informacion = Encoding.UTF8.GetBytes(mensaje);
                EventData @event = new EventData(Informacion);
                client.Send(@event);
                Thread.Sleep(1000);

                }

            }
        }
}
