using System;
using System.Collections.Generic;
using System.Text;

namespace CochesNuGet
{
    public class ListaCoches : List<Coche>
    {
        public ListaCoches()
        {
            Coche c = new Coche
            {
                IdCoche = 1
                ,
                Marca = "DMG"
                ,
                Modelo = "Delorian"
                ,
                Imagen = "https://static.motor.es/fotos-noticias/2015/10/min652x435/curiosidades-delorean-regreso-al-futuro-201523728_4.jpg"
            };
            this.Add(c);
            c = new Coche
            {
                IdCoche = 2
                ,
                Marca = "PONTIAC"
                ,
                Modelo = "FireBird"
                ,
                Imagen = "https://i.ytimg.com/vi/UJFwmjfTSJw/hqdefault.jpg"
            };
            this.Add(c);
            c = new Coche
            {
                IdCoche = 3
                ,
                Marca = "Volkswagen"
                ,
                Modelo = "Escarabajo"
                ,
                Imagen = "https://i.ytimg.com/vi/AP-HLHi0HUw/maxresdefault.jpg"
            };
            this.Add(c);
            c = new Coche
            {
                IdCoche = 4
                ,
                Marca = "Citroen"
                ,
                Modelo = "2 CV"
                ,
                Imagen = "http://iconroad.es/onewebmedia/Iconos%20Citro%C3%ABn%202CV%20En%20el%20cine%204.png"
            };
            this.Add(c);

        }
    }
}
