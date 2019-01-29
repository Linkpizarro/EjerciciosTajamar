using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCAProject.Models.Class;

namespace TCAProject.Interfaces
{
    public interface IRepositoryClient
    {
        Client GetClient(int id_user);
        List<Pub> GetPubs(int id_client);
    }
}
