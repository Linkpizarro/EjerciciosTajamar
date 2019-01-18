using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using TCAP_2._0.Models.Class;

namespace TCAP_2._0.Models.Tools
{
    public class ToolAccount
    {
        public String CreateToken()
        {
            int longitud = 12;
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            String key = "";
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                key += alfabeto[indice];
            }

            String token = Hashing.HashPassword(key);

            return token;
        }
        public String UploadImage(User user)
        {
            String name = null;
            if (!(user.Image_User is null))
            {
                DateTime s = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                TimeSpan t = (DateTime.Now - s);
                name = String.Concat("AvatarUser" + t.TotalMilliseconds.ToString(), ".", user.File_User.FileName.Split('.')[1]);
                string path = Path.Combine(user.Image_User, Path.GetFileName(name));
                user.File_User.SaveAs(path);
            }
            return name;
        }
    }
}