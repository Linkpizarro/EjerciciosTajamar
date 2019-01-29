using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCAProject.Models.Class;

namespace TCAProject.Interfaces
{
    public interface IRepositoryPlayer
    {
        Player GetPlayer(int id_user);
        List<Party> GetParties(int id_player);
        List<Pub> GetPubs(int cp);
    }
}
