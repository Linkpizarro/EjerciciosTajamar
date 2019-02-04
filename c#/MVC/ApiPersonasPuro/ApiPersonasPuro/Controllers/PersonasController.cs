using ApiPersonasPuro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPersonasPuro.Controllers
{
    public class PersonasController : ApiController
    {
        List<Persona> listapersonas = new List<Persona>();

        public PersonasController()
        {
            Persona p = new Persona { IdPersona = 1, Nombre = "Lucia", Email = "lucia@gmail.com", Edad = 19 };
            this.listapersonas.Add(p);
            p = new Persona { IdPersona = 2, Nombre = "Adrian", Email = "adrian@gmail.com", Edad = 24 };
            this.listapersonas.Add(p);
            p = new Persona { IdPersona = 3, Nombre = "Alejandro", Email = "alejandro@gmail.com", Edad = 21 };
            this.listapersonas.Add(p);
            p = new Persona { IdPersona = 4, Nombre = "Sara", Email = "sara@gmail.com", Edad = 17 };
            this.listapersonas.Add(p);
        }

        //api/CONTROLLER   Get(), GetPersons(), GetPersonas()
        public List<Persona> Get()
        {
            return this.listapersonas;
        }

        //api/CONTROLLER/{id}  -->  Get(id), GetPerson(id)
        public Persona GetPersona(int id)
        {
            return
                this.listapersonas.Single(z => z.IdPersona == id);
        }
    }
}
