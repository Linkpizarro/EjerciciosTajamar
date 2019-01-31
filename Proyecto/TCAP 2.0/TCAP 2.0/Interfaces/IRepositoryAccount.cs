﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TCAP_2._0.Models.Class;

namespace TCAP_2._0.Interfaces
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
