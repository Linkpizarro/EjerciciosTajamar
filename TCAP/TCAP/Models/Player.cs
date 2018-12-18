using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCAP.Models
{
    public class Player:User
    {
        String _PlayerId;
        String _NickName;

        public string PlayerId { get => _PlayerId; set => _PlayerId = value; }
        public string NickName { get => _NickName; set => _NickName = value; }
    }
}