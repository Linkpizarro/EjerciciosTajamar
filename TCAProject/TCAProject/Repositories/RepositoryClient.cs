using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCAProject.Interfaces;
using TCAProject.Models;
using TCAProject.Models.Class;

namespace TCAProject.Repositories
{
    public class RepositoryClient : IRepositoryClient
    {
        TCAPContext context;
        public RepositoryClient(TCAPContext context)
        {
            this.context = context;
        }
        public Client GetClient(int id_user)
        {
            Client client = (from data in context.Clients
                             where data.Id_User == id_user
                             select data).FirstOrDefault();

            User user = (from data in context.Users
                         where data.Id_User == id_user
                         select data).FirstOrDefault();

            client.User = user;

            return client;
        }
        public List<Pub> GetPubs(int id_client)
        {
            List<Pub> pubs = (from data in context.Pubs
                              where data.Id_Client == id_client
                              select data).ToList();

            return pubs;
        }


    }
}