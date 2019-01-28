using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Criptografia.Models;

namespace Criptografia.Models
{
    public class RepositoryCifrado
    {
        public void CifrarArchivo(String texto,String publica,String privada,String path)
        {
            Crypt.encryptToFile(texto,path, Crypt.EncodingPrivateKey(privada), Crypt.EncodingPublicKey(publica));
        }
        public String DecifrarArchivo(String publica, String privada, String path)
        {
            return Crypt.decryptFromFile(path, Crypt.EncodingPrivateKey(privada), Crypt.EncodingPublicKey(publica)); ;
        }
    }
}