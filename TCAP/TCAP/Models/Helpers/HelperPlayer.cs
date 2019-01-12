using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCAP.Models.Helpers
{
    
    public class HelperPlayer
    {
        TcapContext c;
        public HelperPlayer()
        {
            c = new TcapContext();
        }

        public String StartSession(String u)
        {
            //Necesito procedure para hacer una sola consulta a una view o algo
            return "";
        }
    }
}