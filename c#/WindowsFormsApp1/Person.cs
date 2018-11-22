using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Person
    {
        String _Name;
        String _Surname;
        int _Age;
        public Person(String Name, String Surname, int Age)
        {
            this._Name = Name;
            this._Surname = Surname;
            this._Age = Age;
        }
        public string Name { get => _Name; set => _Name = value; }
        public string Surname { get => _Surname; set => _Surname = value; }
        public int Age { get => _Age; set => _Age = value; }
    }
}
