using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Controllers;

namespace UnitTest.Tests.Controllers
{
    [TestClass]
    public class PersonasControllerTest
    {

        [TestMethod]
        public void MostrarPersonas()
        {
            //CREAMOS EL CONTROLADOR
            PersonasController controller = new PersonasController();
            //CAPTURAMOS LOS RESULTADOS 
            //DE LA LLAMADA AL ACTIONRESULT
            ViewResult result = controller.MostrarPersonas() as ViewResult;
            var lista = result.Model;
            Assert.IsNotNull(lista);
        }
       
    }
}
