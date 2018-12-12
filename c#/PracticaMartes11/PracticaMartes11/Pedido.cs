using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMartes11
{
    class Pedido
    {
        String _CodPed;
        String _CodCli;
        DateTime _Fec;
        String _Env;
        int _Imp;

        public string CodPed { get => _CodPed; set => _CodPed = value; }
        public string CodCli { get => _CodCli; set => _CodCli = value; }
        public DateTime Fec { get => _Fec; set => _Fec = value; }
        public string Env { get => _Env; set => _Env = value; }
        public int Imp { get => _Imp; set => _Imp = value; }
    }
}
