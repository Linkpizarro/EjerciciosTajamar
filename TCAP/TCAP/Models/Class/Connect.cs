using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TCAP.Models
{
    public class Connect
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public Connect(String db)
        {
            this.strCon = "Data Source = LOCALHOST;" +
            " Initial Catalog = " + db + ";" +
            " Persist Security Info = True;" +
            "User ID = SA;" +
            "Password = 'MCSD2018'";
            //this.strCon = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=" + db + ";Integrated Security=True";
            this.con = new SqlConnection(this.strCon);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
            this.com.CommandType = CommandType.Text;
        }

        public void InsertUser(String sql, User u)
        {
            SqlParameter rol = new SqlParameter("@ROL",u.Rol);
            this.com.Parameters.Add(rol);
            SqlParameter name = new SqlParameter("@N", u.Name);
            this.com.Parameters.Add(name);
            SqlParameter surname = new SqlParameter("@S", u.Surname);
            this.com.Parameters.Add(surname);
            SqlParameter email = new SqlParameter("@E", u.Email);
            this.com.Parameters.Add(email);
            SqlParameter password = new SqlParameter("@P", u.Password);
            this.com.Parameters.Add(password);
            SqlParameter coutry = new SqlParameter("@C", u.Country);
            this.com.Parameters.Add(coutry);
            SqlParameter cp_zip = new SqlParameter("@CP", u.CpZip);
            this.com.Parameters.Add(cp_zip);

            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.con.Open();
            int afec = this.com.ExecuteNonQuery();
            this.com.Parameters.Clear();
            this.con.Close();
        }
    }
}