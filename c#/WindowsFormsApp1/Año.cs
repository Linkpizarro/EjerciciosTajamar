using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Año
    {
        int _Year;
        List<Mes> _Month;

        public int Year { get => _Year; set => _Year = value; }
        public List<Mes> Month { get => _Month; set => _Month = value; }

        public Año(int Year, List<Mes> Month)
        {
            this._Year = Year;
            this._Month = Month;
        }

        public Double MaxYear()
        {
            double max = 0;
            foreach (Mes mes in _Month)
            {
                if (max < mes.Max)
                {
                    max = mes.Max;
                }
            }
            return max;
        }

        public Double MinYear()
        {
            double min = 0;
            foreach (Mes mes in _Month)
            {
                if (min > mes.Min)
                {
                    min = mes.Min;
                }
            }
            return min;
        }

        public Double MediaYear()
        {
           return ((MaxYear() + MinYear()) / 2);
           
        }
    }
}
