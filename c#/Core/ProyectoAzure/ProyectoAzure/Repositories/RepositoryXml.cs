using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using ProyectoAzure.Models;
using ProyectoAzure.Providers;

namespace ProyectoAzure.Repositories
{
    public class RepositoryXml : IRepositoryXml
    {
        PathProvider pathprovider;

        public RepositoryXml(PathProvider pathprovider)
        {
            this.pathprovider = pathprovider;
        }
        public List<Alumno> GetAlumnos()
        {
            String path =
                this.pathprovider.MapPath("alumnos.xml", Folders.Documents);
            XDocument docxml = XDocument.Load(path);
            var consulta = from datos in docxml.Descendants("alumno")
                           select new Alumno
                           {
IdAlumno = int.Parse( datos.Element("idalumno").Value)
, Nombre = datos.Element("nombre").Value
, Apellidos = datos.Element("apellidos").Value
, Nota = int.Parse(datos.Element("nota").Value)
                           };
            return consulta.ToList();
        }

        public Alumno BuscarAlumno(int idalumno)
        {
            String path =
                this.pathprovider.MapPath("alumnos.xml", Folders.Documents);
            XDocument docxml = XDocument.Load(path);
            var consulta = from datos in docxml.Descendants("alumno")
                           where datos.Element("idalumno").Value
                           == idalumno.ToString()
                           select new Alumno
                           {
 IdAlumno = int.Parse(datos.Element("idalumno").Value)
 , Nombre = datos.Element("nombre").Value
 , Apellidos = datos.Element("apellidos").Value
 , Nota = int.Parse(datos.Element("nota").Value)
                           };
            return consulta.FirstOrDefault();
        }

        //COMO NO VAMOS A EXPONER EL METODO XElement DE UN ALUMNO
        //NO ES NECESARIO PONERLO EN LA interface
        //YA QUE ES UNA HERRAMIENTO INTERNA DE LA CLASE Repository
        private XElement BuscarXElementAlumno(int idalumno)
        {
            String path =
                this.pathprovider.MapPath("alumnos.xml", Folders.Documents);
            XDocument docxml = XDocument.Load(path);
            var consulta = from datos in docxml.Descendants("alumno")
                           where datos.Element("idalumno").Value
                           == idalumno.ToString()
                           select datos;
            return consulta.FirstOrDefault();
        }

        public void EliminarAlumno(int idalumno)
        {
            String path =
                this.pathprovider.MapPath("alumnos.xml", Folders.Documents);
            XDocument docxml = XDocument.Load(path);
            //PARA ELIMINAR UN ALUMNO, NECESITAMOS EL NODO
            //DEL ALUMNO (XElement)
            var consulta = from datos in docxml.Descendants("alumno")
                           where datos.Element("idalumno").Value
                           == idalumno.ToString()
                           select datos;
            XElement xmlalumno = consulta.FirstOrDefault();
            xmlalumno.Remove();
            docxml.Save(path);
        }

        public List<Joyeria> GetJoyerias()
        {
            String path =
                this.pathprovider.MapPath("joyeria.xml", Folders.Documents);
            XDocument docxml = XDocument.Load(path);
            var consulta = from datos in docxml.Descendants("joyeria")
                           select new Joyeria
                           {
  Nombre = datos.Element("nombrejoyeria").Value
  , Direccion = datos.Element("direccion").Value
  , Telefono = datos.Element("telf").Value
  , Cif = datos.Attribute("cif").Value
                           };
            return consulta.ToList();
        }

        public void InsertarAlumno(int idalumno, string nombre, string apellidos, int nota)
        {
            String path =
                this.pathprovider.MapPath("alumnos.xml", Folders.Documents);
            XDocument docxml = XDocument.Load(path);
            //TENEMOS QUE CREAR NUEVOS OBJETOS XElement
            XElement xmlalumno = new XElement("alumno");
            //DEBEMOS CREAR NUEVOS XElement ANIDADOS EN EL NODO ALUMNO
            xmlalumno.Add(new XElement("idalumno", idalumno));
            xmlalumno.Add(new XElement("nombre", nombre));
            xmlalumno.Add(new XElement("apellidos", apellidos));
            xmlalumno.Add(new XElement("nota", nota));
            //DEBEMOS AÑADIR EL XElement AL DOCUMENTO PRINCIPAL
            docxml.Element("alumnos").Add(xmlalumno);
            docxml.Save(path);
        }

        public void ModificarAlumno(int idalumno, string nombre, string apellidos, int nota)
        {
            String path =
                this.pathprovider.MapPath("alumnos.xml", Folders.Documents);
            XDocument docxml = XDocument.Load(path);
            var consulta = from datos in docxml.Descendants("alumno")
                           where datos.Element("idalumno").Value
                           == idalumno.ToString()
                           select datos;
            XElement xmlalumno = consulta.FirstOrDefault();

            //MODIFICAMOS SUS DATOS MEDIANTE XML
            xmlalumno.Element("nombre").Value = nombre;
            xmlalumno.Element("apellidos").Value = apellidos;
            xmlalumno.Element("nota").Value = nota.ToString();
            docxml.Save(path);
        }
    }
}
