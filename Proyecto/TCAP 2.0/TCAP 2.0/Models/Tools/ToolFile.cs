using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TCAP_2._0.Models.Tools
{
    public class ToolFile
    {
        //Se encarga de subir la imagen al servidor.
        public static String UploadImage(String image_user, HttpPostedFileBase file)
        {
            String name = null;
            if (!(image_user is null))
            {
                DateTime s = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                TimeSpan t = (DateTime.Now - s);
                name = String.Concat("AvatarUser" + t.TotalMilliseconds.ToString(), ".", file.FileName.Split('.')[1]);
                string path = Path.Combine(image_user, Path.GetFileName(name));
                file.SaveAs(path);
            }
            return name;
        }
    }
}