using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCAProject.Interfaces;
using TCAProject.Models;
using TCAProject.Models.Class;

namespace TCAProject.Repositories
{
    public class RepositoryPlayer : IRepositoryPlayer
    {
        TCAPContext context;
        public RepositoryPlayer(TCAPContext context)
        {
            this.context = context;
        }
        public Player GetPlayer(int id_user)
        {
            Player player = (from data in context.Players
                             where data.Id_User == id_user
                             select data).FirstOrDefault();
            User user = (from data in context.Users
                         where data.Id_User == id_user
                         select data).FirstOrDefault();

            player.User = user;

            return player;
        }
        public List<Party> GetParties(int id_player)
        {
            List<int> id_parties = (from data in context.Participants
                                       where data.Id_Player == id_player
                                       select data.Id_Party).ToList();
            if (id_parties != null && id_parties.Count > 0)
            {
                List<Party> parties = new List<Party>();
                foreach (int id in id_parties)
                {
                   Party party = (from data in context.Parties
                               where data.Id_Party == id
                               select data).FirstOrDefault();

                    parties.Add(party);
                }
              
                if (parties.Count > 0)
                {
                     foreach (Party item in parties)
                     {
                        List<Participant> participants = (from data in context.Participants
                                                          where data.Id_Party == item.Id_Party
                                                          select data).ToList();
                        if(participants.Count > 0)
                        {
                            item.Participants = participants;

                            foreach (Participant x in item.Participants)
                            {
                                Player player = (from data in context.Players
                                                 where data.Id_Player == x.Id_Player
                                                 select data).FirstOrDefault();

                                User user = (from data in context.Users
                                             where data.Id_User == player.Id_User
                                             select data).FirstOrDefault();

                                player.User = user;

                                x.Player = player;
                            }
                        }
                    
                        Pub pub = (from data in context.Pubs
                                   where data.Id_Pub == item.Id_Pub
                                   select data).FirstOrDefault();
                            
                        item.Pub = pub;
                    }
                    return parties;
                }
            }
            return null;
        }
        public List<Pub> GetPubs(int cp)
        {
            int min = (from data in context.Pubs
                       where data.CP_Pub < cp
                       select data.CP_Pub).FirstOrDefault();

            int max = (from data in context.Pubs
                       where data.CP_Pub > cp
                       select data.CP_Pub).FirstOrDefault();

            List<Pub> pubs = (from data in context.Pubs
                              where data.CP_Pub >= min
                              && data.CP_Pub <= max
                              select data).ToList();

            return pubs;
        }
    }
}