using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Mes
    {
        String _Name;
        double _Max;
        double _Min;

        public Mes(String Name,double Max ,double Min)
        {
            this._Name = Name;
            this._Max = Max;
            this._Min = Min;
        }
        
        public String Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }
        public double Max
        {
            get { return this._Max; }
            set { this._Max = value; }
        }
        public double Min
        {
            get { return this._Min; }
            set { this._Min = value; }
        }

        public double Media()
        {
            return ((this._Max + this._Min) / 2);
        }
    }
}
