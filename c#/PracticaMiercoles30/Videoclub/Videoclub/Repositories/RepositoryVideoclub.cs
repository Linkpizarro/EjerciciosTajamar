using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videoclub.Models;

namespace Videoclub.Repositories
{
    public class RepositoryVideoclub
    {
        VideoclubContext context = new VideoclubContext();

        public List<Genero> GetGeneros()
        {
            List<Genero> generos = (from data in context.Generos
                                    select data).ToList();

            return generos;
        }
        public List<Pelicula> GetPeliculas(int idGenero = 0)
        {
            List<Pelicula> peliculas;
            if (idGenero == 0)
            {
                peliculas = (from data in context.Peliculas
                             select data).ToList();
            }
            else
            {
                peliculas = (from data in context.Peliculas
                             where data.IdGenero == idGenero
                             select data).ToList();
            }

            return peliculas;
        }
        public Pelicula GetDetallePelicula(int id)
        {
            Pelicula pelicula = (from data in context.Peliculas
                                 where data.Id == id
                                 select data).FirstOrDefault();
            return pelicula;
        }
        public List<Pelicula> GetCompras(List<int> compras)
        {
            List<Pelicula> compradas = (from data in context.Peliculas
                                        where compras.Contains(data.Id)
                                        select data).ToList();

            return compradas;
        }
        public void InsertPedido(List<Pelicula> peliculas)
        {
            int idCliente = int.Parse(HttpContext.Current.User.Identity.Name);
            foreach (Pelicula item in peliculas)
            {
                Pedido pedido = new Pedido()
                {
                    IdCliente = idCliente,
                    IdPelicula = item.Id,
                    Fecha = DateTime.Now,
                    Cantidad = 1,
                    Precio = item.Precio
                };

                context.Pedidos.Add(pedido);
                context.SaveChanges();
            }
        }
    }
}