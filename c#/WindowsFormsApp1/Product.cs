using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Product
    {
        String _Name;
        double _Price;

        public Product(String Name,double price){
            this._Name = Name;
            this._Price = price;
        }

        public string Name { get => _Name; set => _Name = value; }
        public double Price { get => _Price; set => _Price = value; }


    }
}
