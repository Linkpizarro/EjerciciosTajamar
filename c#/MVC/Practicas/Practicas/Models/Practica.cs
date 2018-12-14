using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicas.Models
{
    public class Practica
    {
        public int? NoNull(int? num)
        {
            if (num is null)
            {
                num = 0;
                return num;
            }
            return num;
        }
        public int? GetSuma(int? n1,int? n2)
        {
            if (n1 is null)
            {
                n1 = 0;
            }
            if (n2 is null)
            {
                n2 = 0;
            }
            int? t = n1 + n2;
            return t;
        }
        public int? GetDoble(int? num)
        {
            int? res = num * 2;
            return res;
        }
        public List<int?> GetTablaMultiplicar(int? num)
        {
            List<int?> n = new List<int?>();
            for (int i = 0; i < 10; i++)
            {
                n.Add(num * (i + 1));
            }
            return n;
        }
        public List<TablaMultiplicar> GetTablaMultiplicarObjeto(int? num)
        {
            List<TablaMultiplicar> n = new List<TablaMultiplicar>();
            for (int i = 0; i < 10; i++)
            {
                TablaMultiplicar t = new TablaMultiplicar();
                t.Operacion = num.ToString() + "X" + (i + 1).ToString(); 
                t.Resultado = num * (i + 1);
                n.Add(t);
            }
            return n;
        }
        public String GetVideo(String url,String type) {
            String code;
            if (url.Contains('='))
            {
               code = url.Split('=')[1];
            }
            else
            {
                if (url.Contains('/'))
                {
                    String[] part =  url.Split('/');
                    code = part[part.Length - 1];
                }
                else{
                    code = url;
                }
            }
            if (type != "vimeo.com")
            {
                type = "youtube.com";
            }
            String html = "<iframe width='600px' height='500px' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' src = 'https://www.'"+type+"/embed/" + code+ "?controls=1&autoplay=1'></ iframe >";
            return html;
        }
        public List<Video> CreateSelectVideo()
        {
            List<String[]> MisVideos = new List<string[]>();
            String[] x = new String[] { "SXUJGlXxKSI","La Resistencia" };
            String[] y = new String[] { "ohMHufFj1-E", "Radio Dayo" };
            String[] z = new String[] { "Wf_Wdd7LqUY", "Repaso Gala 12 OT" };
            MisVideos.Add(x);
            MisVideos.Add(y);
            MisVideos.Add(z);
            List<Video> result = new List<Video>();
            foreach (String[] item in MisVideos)
            {
                Video v = new Video();
                v.Code = item[0];
                v.Name = item[1];
                result.Add(v);
            }
            return result;
        }
    }
}