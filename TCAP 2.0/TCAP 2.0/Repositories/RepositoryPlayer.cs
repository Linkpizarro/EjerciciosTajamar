using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCAP_2._0.Interfaces;
using TCAP_2._0.Models;
using TCAP_2._0.Models.Class;

namespace TCAP_2._0.Repositories
{
    public class RepositoryPlayer : IRepositoryPlayer
    {
        TCAPContext context;
        public RepositoryPlayer(TCAPContext context)
        {
            this.context = context;
        }
        public Player GetDataPlayer(int id_user)
        {
            Player player = (from data in context.Players
                             where data.Id_User == id_user
                             select data).FirstOrDefault();
            User user = (from data in context.Users
                         where data.Id_User == id_user
                         select data).FirstOrDefault();

            player.GeneralData = user;

            return player;
        }
    }
}