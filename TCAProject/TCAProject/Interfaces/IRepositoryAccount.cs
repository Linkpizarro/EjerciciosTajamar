using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TCAProject.Models.Class;

namespace TCAProject.Interfaces
{
    public interface IRepositoryAccount
    {
        Boolean Register(User user, String pass, String repPass, HttpPostedFileBase file,ref String error);
        User Confirm(String token);
        Boolean ClientConfirm(Client client, ref String error);
        Boolean PlayerConfirm(Player player, ref String error);
        User Login(String email,String password, ref String error);
    }
}
