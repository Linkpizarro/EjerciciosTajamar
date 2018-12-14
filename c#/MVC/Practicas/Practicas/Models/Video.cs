using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicas.Models
{
    public class Video
    {
        String _Code;
        String _Name;

        public string Code { get => _Code; set => _Code = value; }
        public string Name { get => _Name; set => _Name = value; }
    }
}