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
        TCAPContextDataContext c;
        //CAMBIAR TODO A LINQ Y SIN USAR PROCEDURES
        //REALIZAR AQUÍ LA VALIDACIÓN
        public HelperAccount()
        {
            String connect = ConfigurationManager.ConnectionStrings["HomeConnection"].ConnectionString;
            this.con = new SqlConnection(connect);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
            this.com.CommandType = System.Data.CommandType.Text;
            c = new TCAPContextDataContext();
        }
        private String CreateToken()
        {
            int longitud = 12;
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            String key = "";
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                key += alfabeto[indice];
            }

            String token = Hashing.HashPassword(key);

            return token;
        }
        private Boolean ValidateField(String field)
        {
            if (field is null)
            {
                return false;
            }
            return true;
        }
        public Boolean Register(String user, String name, String surname, String email, String password,
           String country, String cp_zip)
        {
            String sql = "REGISTER";
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
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;

            this.con.Open();

            int afec = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.con.Close();

            if (afec > 0)
            {
                Token(email, CreateToken());
                return true;
            }

            return false;
        }
        public User Login(String email, String password)
        {
            String sql = "LOGON";
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
            User result = new User();

            if (this.reader.HasRows)
            {
                if (Hashing.ValidatePassword(password, this.reader["PASSWORD_USER"].ToString()))
                {
                    result.Rol = int.Parse(this.reader["ID_ROL"].ToString());
                    result.Name = this.reader["NAME_USER"].ToString();
                    result.Surname = this.reader["SURNAME_USER"].ToString();
                    result.Email = this.reader["EMAIL_USER"].ToString();
                }
            }

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();

            return result;

        }        
        public void Token(String email,String token)
        {
            String sql = "TOKEN";
            SqlParameter e = new SqlParameter("@E", email);
            this.com.Parameters.Add(e);
            SqlParameter t = new SqlParameter("@T", token);
            this.com.Parameters.Add(t);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;

            this.con.Open();
            int afect = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.con.Close();

        }
        public List<Object> ValidateToken(String token)
        {
            //String sql = "CONFIRM";
            //SqlParameter e = new SqlParameter("@T", token);
            //this.com.Parameters.Add(e);
            //this.com.Connection = this.con;
            //this.com.CommandText = sql;
            //this.com.CommandType = System.Data.CommandType.StoredProcedure;
            //this.con.Open();

            //this.reader = this.com.ExecuteReader();
            //this.reader.Read();
            //User result = new User();

            //if (this.reader.HasRows)
            //{
            //    result.Rol = int.Parse(this.reader["ID_ROL"].ToString());
            //    result.Name = this.reader["NAME_USER"].ToString();
            //    result.Surname = this.reader["SURNAME_USER"].ToString();
            //    result.UserId = int.Parse(this.reader["ID_USER"].ToString());  
            //}

            //this.com.Parameters.Clear();
            //this.reader.Close();
            //this.con.Close();

            //return result;
            List<Object> result = new List<Object>();
            //String error = null;
            //CONFIRMResult linq = c.CONFIRM(token, ref error).FirstOrDefault();
            //result.Add(linq);
            //result.Add(error);
            return result;
        }
    }
}