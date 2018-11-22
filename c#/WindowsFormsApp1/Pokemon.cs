using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pokemon
    {
        private String _Name;
        private int _HP;
        private int _EX;
        private int _Level;
        private String _Image;
        private Ability[] _Abilities;

        public Pokemon(String Name ,int HP ,int EX,int Level,String Image, Ability[] Abilities)
        {
            this.Name = Name;
            this.HP = HP;
            this.EX = EX;
            this.Level = Level;
            this.Image = Image;
            this.Abilities = Abilities;
        }

        public string Name { get => _Name; set => _Name = value; }
        public int HP { get => _HP; set => _HP = value; }
        public int EX { get => _EX; set => _EX = value; }
        public int Level { get => _Level; set => _Level = value; }
        public String Image { get => _Image; set => _Image = value; }
        public Ability[] Abilities { get => _Abilities; set => _Abilities = value; }

        public void Attack(Ability a,Pokemon p)
        {
            p._HP = p._HP - a.Power;
        }
    }
}
