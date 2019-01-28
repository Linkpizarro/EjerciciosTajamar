using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCAP_2._0.Interfaces;
using TCAP_2._0.Models;
using TCAP_2._0.Models.Class;

namespace TCAP_2._0.Repositories
{
    public class RepositoryClient : IRepositoryClient
    {
        TCAPContext context;
        public RepositoryClient(TCAPContext context)
        {
            this.context = context;
        }
        public Client GetDataClient(int id_user)
        {
            Client client = (from data in context.Clients
                             where data.Id_User == id_user
                             select data).FirstOrDefault();

            User user = (from data in context.Users
                         where data.Id_User == id_user
                         select data).FirstOrDefault();

            client.GeneralData = user;

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