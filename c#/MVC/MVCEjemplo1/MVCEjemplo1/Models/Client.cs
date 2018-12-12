using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEjemplo1.Models
{
    public class Client
    {
        String _CodCli;
        String _Emp;
        String _Cont;
        String _Car;
        String _Ciu;
        long _Tel;

        public string CodCli { get => _CodCli; set => _CodCli = value; }
        public string Emp { get => _Emp; set => _Emp = value; }
        public string Cont { get => _Cont; set => _Cont = value; }
        public string Car { get => _Car; set => _Car = value; }
        public string Ciu { get => _Ciu; set => _Ciu = value; }
        public long Tel { get => _Tel; set => _Tel = value; }
    }
}