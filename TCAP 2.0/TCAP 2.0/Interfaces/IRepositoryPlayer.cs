using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCAP_2._0.Models.Class;

namespace TCAP_2._0.Interfaces
{
    public interface IRepositoryPlayer
    {
        Player GetDataPlayer(int id_user);
    }
}
