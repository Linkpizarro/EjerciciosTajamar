using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CochesNuGet
{
    public enum TiposCoche
    {
        Dmg = 1,
        Pontiac = 2,
        Volkswagen = 3,
        Citroen = 4
    }

    public class Garaje
    {
        public Coche RecuperarCoche(TiposCoche tipo)
        {
            int indice = (int)tipo;
            ListaCoches coches = new ListaCoches();
            Coche car = coches.Where(z => z.IdCoche == indice).FirstOrDefault();
            return car;  
        }
    }

}
