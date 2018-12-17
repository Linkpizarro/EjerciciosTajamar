using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace TCAP.Models.Helpers
{
    public class HelperAccount
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public HelperAccount()
        {
            String connect = ConfigurationManager.ConnectionStrings["HomeConnection"].ConnectionString;
            this.con = new SqlConnection(connect);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
            this.com.CommandType = System.Data.CommandType.Text;
        }
        private Boolean ValidateField(String field)
        {
            if (field is null)
            {
                return false;
            }
            return true;
        }
        public Boolean InsertUser(String user, String name, String surname, String email, String password,
           String country, String cp_zip)
        {
            String sql = "INSERTUSER";
            SqlParameter r = new SqlParameter("@ROL", user);
            this.com.Parameters.Add(r);
            SqlParameter n = new SqlParameter("@N", name);
            this.com.Parameters.Add(n);
            SqlParameter s = new SqlParameter("@S", surname);
            this.com.Parameters.Add(s);
            SqlParameter e = new SqlParameter("@E", email);
            this.com.Parameters.Add(e);
            SqlParameter p = new SqlParameter("@P", Hashing.HashPassword(password));
            this.com.Parameters.Add(p);
            SqlParameter c = new SqlParameter("@C", country);
            this.com.Parameters.Add(c);
            SqlParameter cp = new SqlParameter("@CP", cp_zip);
            this.com.Parameters.Add(cp);

            this.com.Connection = this.con;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.con.Open();

            int afec = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.con.Close();

            if (afec > 0)
            {
                return true;
            }

            return false;
        }
        public Boolean ValidateLogin(String email, String password)
        {
            String sql = "SELECTUSER";
            SqlParameter e = new SqlParameter("@E", email);
            this.com.Parameters.Add(e);
            SqlParameter p = new SqlParameter("@P",password);
            this.com.Parameters.Add(p);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.con.Open();

            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            String result = null;

            if (this.reader.HasRows)
            {
                result = this.reader["PASSWORD_USER"].ToString();
            }

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
            if(!(result is null))
            {
                if (Hashing.ValidatePassword(password, result))
                {
                    return true;
                }

                return false;
                
            }

            return false;

        }
    }
}