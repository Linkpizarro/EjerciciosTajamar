using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCAP.Models
{
    public class User
    {
        int _UserId;
        int _Rol;
        String _Name;
        String _Surname;
        String _Email;
        String _Password;
        String _Country;
        String _CpZip;
        DateTime _CreateAt;
        DateTime _UpdatedAt;

        public int UserId { get => _UserId; set => _UserId = value; }
        public int Rol { get => _Rol; set => _Rol = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Surname { get => _Surname; set => _Surname = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Country { get => _Country; set => _Country = value; }
        public string CpZip { get => _CpZip; set => _CpZip = value; }
        public DateTime CreateAt { get => _CreateAt; set => _CreateAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; set => _UpdatedAt = value; }
    }
}