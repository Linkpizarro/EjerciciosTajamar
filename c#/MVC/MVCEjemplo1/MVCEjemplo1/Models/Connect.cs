using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCEjemplo1.Models
{
    public class Connect
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public Connect()
        {
            this.strCon = "Data Source = LOCALHOST;" +
           " Initial Catalog = PRACTICAADO;" +
           " Persist Security Info = True;" +
           "User ID = SA;" +
           "Password = 'MCSD2018'";
            //this.strCon = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog= PRACTICAADO;Integrated Security=True";
            this.con = new SqlConnection(this.strCon);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
            this.com.CommandType = System.Data.CommandType.Text;
        }
       
        public List<String> GetData(String sql,String col)
        {
            com.Connection = con;
            com.CommandText = sql;
            com.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();
            reader = com.ExecuteReader();
            List<String> result = new List<String>();
            while (reader.Read())
            {
                String x = reader[col].ToString();
                result.Add(x);
            }

            reader.Close();
            con.Close();

            return result;
        }

    }
}