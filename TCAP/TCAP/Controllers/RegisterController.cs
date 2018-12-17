using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCAP.Models;
using System.Text;

namespace TCAP.Controllers
{
    public class RegisterController : Controller
    {
        HelperRegister h = new HelperRegister();
        // GET: Register
        public ActionResult Index()
        {
           // byte[] key = UTF8Encoding.UTF8.GetBytes("ClavePrivada");
           // byte[] iv = UTF8Encoding.UTF8.GetBytes("Publica");
           // //byte[] keyf = UTF8Encoding.UTF8.GetBytes("ClavePrivad");
           // int keySize = 32;
           // int ivSize = 16;
           // Array.Resize(ref key, keySize);
           // Array.Resize(ref iv, ivSize);
           // CifradoAsimetrico.encryptToFile("Soy Daniel", "C:\\Users\\AlumnoMCSD\\Desktop\\fichero.txt", key, iv);
           //ViewBag.Mensaje = CifradoAsimetrico.decryptFromFile("C:\\Users\\AlumnoMCSD\\Desktop\\fichero.txt", key, iv);
            //ViewBag.Mensaje = "Esto es un mensaje que se tiene que cifrar.";
            //ViewBag.Cifrado = CifradoAsimetrico.encryptString(ViewBag.Mensaje,key,iv);
            //ViewBag.Descifrado = CifradoAsimetrico.decryptString(ViewBag.Cifrado, key, iv);
            return View();
        }
        //POST: Register
        [HttpPost]
        public ActionResult Index(String user,String name,String surname,String email,String password,
            String country,String cp_zip)
        {
            h.InsertUser(user, name, surname, email, password, country, cp_zip);
            return View("Login");
        }
    }
}