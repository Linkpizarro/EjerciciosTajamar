using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEjemplo1.Models
{
    public class Car
    {
        String _Brand;
        String _Model;

        public string Brand { get => _Brand; set => _Brand = value; }
        public string Model { get => _Model; set => _Model = value; }
    }
}