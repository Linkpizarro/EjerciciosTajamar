using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAzure.Providers
{
    public enum Folders{
        Images = 0,
        Documents = 1,
        Clientes = 2     
    }

    public class PathProvider
    {
        IHostingEnvironment environment;
        public PathProvider(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public String MapPath(String filename,Folders folder)
        {
            String carpeta = "";
            if (folder == Folders.Documents)
            {
                carpeta = "documents";
            }else if (folder == Folders.Images)
            {
                carpeta = "images";
            }
            else if (folder == Folders.Clientes)
            {
                carpeta = "images/clientes";
            }
            String path = Path.Combine(this.environment.WebRootPath, carpeta, filename);
            return path;
        }
    }
}
