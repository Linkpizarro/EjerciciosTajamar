using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videoclub.Models;

namespace Videoclub.Repositories
{
    public class RepositoryUser
    {
        VideoclubContext context = new VideoclubContext();
        public Cliente GetCliente(int id)
        {
            Cliente cliente = (from data in context.Clientes
                               where data.Id == id
                               select data).FirstOrDefault();

            return cliente;
        }
        public Boolean Login(string email ,int pass)
        {
            int existe = (from data in context.Clientes
                          where data.Email == email
                          && data.Id == pass
                          select data.Id).FirstOrDefault();

            if (existe != 0)
            {
                return true;
            }

            return false;
        }
        public List<Pedido> GetPedidos(int idCliente)
        {
            List<Pedido> pedidos = (from data in context.Pedidos
                                    where data.IdCliente == idCliente
                                    select data).ToList();

            return pedidos;
        }
    }
}