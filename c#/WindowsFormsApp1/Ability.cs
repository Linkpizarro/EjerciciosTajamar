using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Ability
    {
        private String _Name;
        private int _Power;

        public Ability(String Name,int Power)
        {
            this.Name = Name;
            this.Power = Power;
        }

        public string Name { get => _Name; set => _Name = value; }
        public int Power { get => _Power; set => _Power = value; }
    }
}
