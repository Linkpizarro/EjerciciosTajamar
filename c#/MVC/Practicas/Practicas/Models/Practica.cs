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
    }
}